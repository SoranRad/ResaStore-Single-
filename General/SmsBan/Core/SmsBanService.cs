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
			_modem		= new ModemGateway();
			_queue		= new SmsQueueService(options);
			_limiter	= new SmsRateLimiter(options);
			_sender		= new SmsSenderWorker(options, _modem);
			_inbox		= new SmsInboxService(options, _modem);
		}

		public SmsBanOptions	Options			{ get { return _options; } }

		public ModemGateway		Modem			{ get { return _modem; } }

		public SmsQueueService	Queue			{ get { return _queue; } }

		public SmsRateLimiter	RateLimiter		{ get { return _limiter; } }

		public SmsInboxService	Inbox			{ get { return _inbox; } }

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
		/// هم‌خوانی گزارش تحویل با رویدادهای مودم.
		/// رویدادهای «ارسال موفق» شماره‌ی مرجع را برمی‌گردانند و با آن
		/// رکورد آرشیو علامت‌گذاری می‌شود. تعداد رکوردهای به‌روزشده برگردانده می‌شود.
		/// </summary>
		public int SyncDeliveryReports()
		{
			if (!_options.IsModemHost)
				return 0;

			var events = _modem.PollEvents();

			if (events.Count == 0)
				return 0;

			var references = new List<string>();

			foreach (var item in events)
			{
				if (item.Code != ModemEventCode.SmsPartSentReference
					&& item.Code != ModemEventCode.SmsPartSentSuccessful
					&& item.Code != ModemEventCode.SmsAllPartsSentSuccessful)
					continue;

				var reference = (item.Text ?? string.Empty).Trim();

				if (reference.Length > 0)
					references.Add(reference);
			}

			if (references.Count == 0)
				return 0;

			int updated = 0;

			try
			{
				using (var db = SmsBanDb.Create(_options.ConnectionString))
				{
					foreach (var reference in references.Distinct())
					{
						var rows = db.tbl_SmsArchive
							.Where(x => x.SmsReference == reference && x.Status == (int)SmsMessageStatus.Sent)
							.ToList();

						foreach (var row in rows)
						{
							if (row.IsDelivered)
								continue;

							row.IsDelivered			= true;
							row.DeliveredAt			= DateTime.Now;
							row.DeliveredAtShamsi	= JalaliDate.ToShamsi(DateTime.Now);
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
