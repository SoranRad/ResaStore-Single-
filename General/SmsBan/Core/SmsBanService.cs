using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using SmsBan.DataLayer;
using SmsBan.DataLayer.Context;
using SmsBan.Modem;
using SmsBan.Model;

namespace SmsBan.Core
{
	/// <summary>
	/// نقطه‌ی ورود ماژول ارسال پیامک.
	///
	/// نمونه‌ی استفاده:
	/// <code>
	/// var service = new SmsBanService(new SmsBanOptions
	/// {
	///     ConnectionString    = "Server=...;Database=...;",
	///     MaxSmsPerDay        = 500,
	///     MaxSmsPerMinute     = 50,
	///     CharsPerPage        = 70,
	///     ReadIntervalMinutes = 5,
	///     IsModemHost         = true
	/// });
	///
	/// service.Start();
	///
	/// service.Enqueue("09121234567", "متن پیامک", SmsPriority.Normal);
	/// service.EnqueueSameText(new[] { "0912...", "0935..." }, "متن", SmsPriority.Urgent);
	/// service.EnqueueMany(new[]
	/// {
	///     new SmsRequest("0912...", "متن اول"),
	///     new SmsRequest("0935...", "متن دوم")
	/// }, SmsPriority.Medium);
	///
	/// service.ReadNow();
	/// </code>
	/// </summary>
	public class SmsBanService : IDisposable
	{
		#region Logging
		private static readonly log4net.ILog log =
			log4net
				.LogManager
				.GetLogger
				(System.Reflection
					.MethodBase
					.GetCurrentMethod()
					.DeclaringType);
		#endregion

		private readonly SmsBanOptions		_options;
		private readonly ModemGateway		_modem;
		private readonly SmsQueueService	_queue;
		private readonly SmsRateLimiter		_limiter;
		private readonly SmsSenderWorker	_sender;
		private readonly SmsInboxService	_inbox;
		private readonly SmsConversationService _conversation;

		private Timer						_readTimer;
		private bool						_started;
		private bool						_disposed;

		public SmsBanService(SmsBanOptions options)
		{
			if (options == null)
				throw new ArgumentNullException("options");

			options.Validate();

			if (string.IsNullOrWhiteSpace(options.InstanceId))
				options.InstanceId = string.Format("{0}-{1}",
					Environment.MachineName,
					System.Diagnostics.Process.GetCurrentProcess().Id);

			if (string.IsNullOrWhiteSpace(options.EnqueuedBy))
				options.EnqueuedBy = Environment.MachineName;

			_options	= options;
			_modem		= new ModemGateway
			{
				// انتخاب دستگاه مورد نظر با تابع SMS_Select_Device (شماره دستگاه، نه اندیس).
				DeviceNumber = options.DeviceNumber
			};
			_queue		= new SmsQueueService(options);
			_limiter	= new SmsRateLimiter(options);
			_sender		= new SmsSenderWorker(options, _modem);
			_inbox		= new SmsInboxService(options, _modem);
			_conversation = new SmsConversationService(options);
		}

		public SmsBanOptions	Options			{ get { return _options; } }

		public ModemGateway		Modem			{ get { return _modem; } }

		public SmsQueueService	Queue			{ get { return _queue; } }

		public SmsRateLimiter	RateLimiter		{ get { return _limiter; } }

		public SmsInboxService	Inbox			{ get { return _inbox; } }

		/// <summary>سرویس خواندن گفتگو و حذف پیامک‌ها.</summary>
		public SmsConversationService Conversations { get { return _conversation; } }

		public bool				IsStarted		{ get { return _started; } }

		/// <summary>خطای احتمالی در ساخت جداول هنگام شروع.</summary>
		public string			InitializationError { get; private set; }

		// ==================================================================
		// آماده‌سازی و اجرا
		// ==================================================================

		/// <summary>
		/// اطمینان از وجود Schema و جداول.
		/// این کار به‌صورت خودکار با ساخت اولین کانتکست انجام می‌شود.
		/// </summary>
		public bool EnsureDatabase()
		{
			try
			{
				using (var db = SmsBanDb.Create(_options.ConnectionString))
				{
					// دسترسی ساده برای اجبار به اجرای مایگریشن.
					db.tbl_SmsWorkerState.Any();
				}

				InitializationError = null;
				return true;
			}
			catch (Exception ex)
			{
				InitializationError = ex.Message;
				log.Error("آماده‌سازی بانک اطلاعاتی ماژول پیامک ناموفق بود.", ex);
				return false;
			}
		}

		/// <summary>
		/// شروع کار ماژول.
		/// نخ ارسال و تایمر خواندن فقط روی کامپیوتری فعال می‌شوند که
		/// <c>IsModemHost</c> آن true باشد.
		/// </summary>
		public void Start()
		{
			if (_started)
				return;

			EnsureDatabase();

			if (!_options.IsModemHost)
			{
				_started = true;
				log.Info("ماژول در حالت «فقط درخواست» راه‌اندازی شد: ارسال و خواندن انجام نمی‌شود.");
				return;
			}

			_sender.Start();

			_readTimer = new Timer(
				ReadTimerCallback,
				null,
				TimeSpan.FromSeconds(5),
				TimeSpan.FromMinutes(Math.Max(1, _options.ReadIntervalMinutes)));

			_started = true;

			log.InfoFormat("ماژول پیامک راه‌اندازی شد (فاصله‌ی خواندن: {0} دقیقه).",
				_options.ReadIntervalMinutes);
		}

		private void ReadTimerCallback(object state)
		{
			try
			{
				ReadNow();
				SyncDeliveryReports();
			}
			catch (Exception ex)
			{
				log.Error(ex);
			}
		}

		public void Stop()
		{
			if (!_started)
				return;

			if (_readTimer != null)
			{
				_readTimer.Dispose();
				_readTimer = null;
			}

			_sender.Stop();

			_started = false;

			log.Info("ماژول پیامک متوقف شد.");
		}

		/// <summary>یک دور پردازش دستی صف (برای کنترل از بیرون).</summary>
		public bool ProcessOnce()
		{
			return _sender.ProcessOnce();
		}

		// ==================================================================
		// درج در صف
		// ==================================================================

		public long Enqueue(string phoneNumber, string text, SmsPriority priority)
		{
			return _queue.Enqueue(phoneNumber, text, priority);
		}

		public List<long> EnqueueSameText(IEnumerable<string> phoneNumbers, string text, SmsPriority priority)
		{
			return _queue.EnqueueSameText(phoneNumbers, text, priority);
		}

		public List<long> EnqueueMany(IEnumerable<SmsRequest> requests, SmsPriority priority)
		{
			return _queue.EnqueueMany(requests, priority);
		}

		// ==================================================================
		// مدیریت صف
		// ==================================================================

		public List<SmsQueueItem>	GetQueue(SmsQueueFilter filter)			{ return _queue.GetQueue(filter); }
		public int					GetQueueCount(SmsMessageStatus? status)	{ return _queue.GetQueueCount(status); }
		public bool					Cancel(long id)							{ return _queue.Cancel(id); }
		public int					CancelAllPending()						{ return _queue.CancelAllPending(); }
		public bool					ChangePriority(long id, SmsPriority p)	{ return _queue.ChangePriority(id, p); }
		public bool					MoveToTop(long id)						{ return _queue.MoveToTop(id); }
		public bool					MoveToBottom(long id)					{ return _queue.MoveToBottom(id); }
		public bool					MoveUp(long id)							{ return _queue.MoveUp(id); }
		public bool					MoveDown(long id)						{ return _queue.MoveDown(id); }
		public bool					RetryFailed(long archiveId)				{ return _queue.RetryFailed(archiveId); }
		public void					Pause(string by)						{ _queue.Pause(by); }
		public void					Resume()								{ _queue.Resume(); }
		public bool					IsPaused()								{ return _queue.IsPaused(); }

		// ==================================================================
		// آرشیو
		// ==================================================================

		/// <summary>
		/// فهرست پیامک‌های آرشیو‌شده (ارسال‌شده، ناموفق، لغوشده).
		/// </summary>
		public List<SmsArchive> GetArchive(SmsMessageStatus? status, DateTime? from, DateTime? to, int maxRows)
		{
			using (var db = SmsBanDb.Create(_options.ConnectionString))
			{
				var query = db.tbl_SmsArchive.AsNoTracking().AsQueryable();

				if (status != null)
					query = query.Where(x => x.Status == (int)status.Value);

				if (from != null)
					query = query.Where(x => x.CreatedAt >= from.Value);

				if (to != null)
					query = query.Where(x => x.CreatedAt <= to.Value);

				query = query.OrderByDescending(x => x.ID);

				if (maxRows > 0)
					query = query.Take(maxRows);

				return query.ToList();
			}
		}

		/// <summary>
		/// هم‌خوانی رویدادهای ارسال مودم با آرشیو.
		///
		/// مودم پس از ارسال، رویدادهایی می‌فرستد که شماره‌های مرجع پارت‌ها را دارند
		/// (مثلاً «All_Part:3 Refrences:56-57-58-»). اینجا آن‌ها با مرجع ذخیره‌شده
		/// در آرشیو مقایسه می‌شوند:
		///   - رویداد موفق اگر رکوردی اشتباهاً ناموفق ثبت شده باشد، به «ارسال‌شده» برمی‌گردد.
		///   - رویداد خطا اگر رکوردی «ارسال‌شده» ثبت شده باشد، به «ناموفق» تغییر می‌کند.
		///
		/// توجه: این رویدادها «ارسال» را تأیید می‌کنند، نه «تحویل» را.
		/// وضعیت تحویل فقط با گزارش تحویل اپراتور (SMS STATUS REPORT) مشخص می‌شود.
		/// </summary>
		public int SyncDeliveryReports()
		{
			if (!_options.IsModemHost)
				return 0;

			var events = _modem.PollEvents();

			if (events.Count == 0)
				return 0;

			var sentReferences	= new List<string>();
			var failedReferences = new List<string>();
			var failureText		= string.Empty;

			foreach (var item in events)
			{
				var references = SmsReferenceParser.Parse(item.Text);

				if (references.Count == 0)
					continue;

				switch (item.Code)
				{
					case ModemEventCode.SmsPartSentReference:
					case ModemEventCode.SmsPartSentSuccessful:
					case ModemEventCode.SmsAllPartsSentSuccessful:
						foreach (var reference in references)
							if (!sentReferences.Contains(reference))
								sentReferences.Add(reference);
						break;

					case ModemEventCode.SmsSendFailed:
					case ModemEventCode.SmsNoReference:
						foreach (var reference in references)
							if (!failedReferences.Contains(reference))
								failedReferences.Add(reference);

						if (string.IsNullOrEmpty(failureText))
							failureText = item.Text;
						break;
				}
			}

			if (sentReferences.Count == 0 && failedReferences.Count == 0)
				return 0;

			int updated = 0;

			try
			{
				using (var db = SmsBanDb.Create(_options.ConnectionString))
				{
					var rows = db.tbl_SmsArchive
						.Where(x => x.SmsReference != null && x.SmsReference != "")
						.ToList();

					foreach (var row in rows)
					{
						// رویداد موفق برای رکورد ناموفق → اصلاح به ارسال‌شده.
						if (row.Status == (int)SmsMessageStatus.Failed
							&& SmsReferenceParser.Overlaps(row.SmsReference, sentReferences))
						{
							row.Status			= (int)SmsMessageStatus.Sent;
							row.ErrorMessage	= null;
							updated++;
							continue;
						}

						// رویداد خطا برای رکورد ارسال‌شده → اصلاح به ناموفق.
						if (row.Status == (int)SmsMessageStatus.Sent
							&& SmsReferenceParser.Overlaps(row.SmsReference, failedReferences))
						{
							row.Status = (int)SmsMessageStatus.Failed;

							if (!string.IsNullOrEmpty(failureText))
								row.ErrorMessage = failureText;

							updated++;
						}
					}

					if (updated > 0)
						db.SaveChanges();
				}
			}
			catch (Exception ex)
			{
				log.Error(ex);
			}

			if (updated > 0)
				log.InfoFormat("{0} رکورد آرشیو با رویدادهای مودم هم‌خوان شد.", updated);

			return updated;
		}

		// ==================================================================
		// دریافت
		// ==================================================================

		/// <summary>خواندن فوری پیامک‌های رسیده. تعداد پیامک جدید برگردانده می‌شود.</summary>
		public int ReadNow()
		{
			if (!_options.IsModemHost)
				return 0;

			return _inbox.ReadNow();
		}

		/// <summary>
		/// خواندن پیامک‌هایی که در حافظه‌ی سیم‌کارت یا مودم ذخیره شده‌اند.
		/// </summary>
		public List<ModemSmsMessage> ReadStoredFromModem()
		{
			if (!_options.IsModemHost)
				return new List<ModemSmsMessage>();

			return _inbox.ReadStoredFromModem();
		}

		/// <summary>حذف پیامک از حافظه‌ی مودم/سیم‌کارت (فقط روی کامپیوتر میزبان مودم).</summary>
		public bool DeleteFromModem(int index)
		{
			if (!_options.IsModemHost)
				return false;

			return _inbox.DeleteFromModem(index);
		}

		public List<SmsInbox> GetInbox(DateTime? from, DateTime? to, string phoneNumber, int maxRows)
		{
			return _inbox.GetInbox(from, to, phoneNumber, maxRows);
		}

		/// <summary>
		/// پیامک‌های موجود در حافظه‌ی دستگاه، گروه‌بندی‌شده.
		/// پارت‌های یک پیامک چندپارتی یک ردیف محسوب می‌شوند.
		/// </summary>
		public List<DeviceSmsGroup> ReadDeviceGroups()
		{
			return _inbox.ReadDeviceGroups();
		}

		/// <summary>وضعیت حافظه‌ی پیامک مودم/سیم‌کارت.</summary>
		public ModemMemoryInfo GetMemoryInfo()
		{
			return _modem.GetMemoryInfo();
		}

		// ==================================================================
		// حذف پیامک‌ها از بانک اطلاعاتی
		// ==================================================================

		/// <summary>حذف یک پیامک ارسالی (از جدول آرشیو).</summary>
		public bool DeleteSent(long id)
		{
			return _conversation.DeleteOutgoing(id);
		}

		/// <summary>حذف یک پیامک دریافتی (از جدول صندوق ورودی).</summary>
		public bool DeleteReceived(long id)
		{
			return _conversation.DeleteIncoming(id);
		}

		/// <summary>حذف یک پیامک بر اساس شناسه و جهت آن.</summary>
		public bool DeleteMessage(long id, bool isOutgoing)
		{
			return _conversation.DeleteMessage(id, isOutgoing);
		}

		/// <summary>حذف گروهی پیامک‌های ارسالی. تعداد ردیف‌های حذف‌شده برگردانده می‌شود.</summary>
		public int DeleteSent(IEnumerable<long> ids)
		{
			return _conversation.DeleteOutgoing(ids);
		}

		/// <summary>حذف گروهی پیامک‌های دریافتی. تعداد ردیف‌های حذف‌شده برگردانده می‌شود.</summary>
		public int DeleteReceived(IEnumerable<long> ids)
		{
			return _conversation.DeleteIncoming(ids);
		}

		/// <summary>
		/// حذف کل گفتگوی یک یا چند شماره (هم ارسالی و هم دریافتی).
		/// برای گرفتن حالت‌های مختلف شماره از <c>SmsContact.Variants</c> استفاده کنید.
		/// </summary>
		public int DeleteConversation(IEnumerable<string> phoneVariants)
		{
			return _conversation.DeleteConversation(phoneVariants);
		}

		/// <summary>حذف گفتگوی یک شماره در جهت مشخص.</summary>
		public int DeleteConversation(IEnumerable<string> phoneVariants, SmsDirection direction)
		{
			return _conversation.DeleteConversation(phoneVariants, direction);
		}

		/// <summary>حذف پیامک‌های ارسالی قدیمی‌تر از یک تاریخ.</summary>
		public int DeleteSentBefore(DateTime date)
		{
			return _conversation.DeleteOutgoingBefore(date);
		}

		/// <summary>حذف پیامک‌های دریافتی قدیمی‌تر از یک تاریخ.</summary>
		public int DeleteReceivedBefore(DateTime date)
		{
			return _conversation.DeleteIncomingBefore(date);
		}

		// ==================================================================
		// وضعیت
		// ==================================================================

		public ModemStatus GetModemStatus()
		{
			return _modem.RefreshStatus();
		}

		public SmsQuota GetQuota()
		{
			return _limiter.GetQuota();
		}

		public SmsRateCounter GetTodayCounter()
		{
			return _limiter.GetTodayCounter();
		}

		public void Dispose()
		{
			if (_disposed)
				return;

			_disposed = true;

			Stop();

			if (_sender != null)
				_sender.Dispose();

			if (_modem != null)
				_modem.Dispose();

			GC.SuppressFinalize(this);
		}
	}
}
