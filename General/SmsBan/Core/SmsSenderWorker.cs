using System;
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
	/// نخ ارسال پیامک.
	/// فقط روی کامپیوتری اجرا می‌شود که مودم به آن وصل است.
	///
	/// چرخه‌ی کار:
	///   1) گرفتن مالکیت (lease) برای جلوگیری از ارسال هم‌زمان دو نمونه
	///   2) برداشتن پیامک بعدی صف به‌صورت اتمیک
	///   3) بررسی سهمیه بر مبنای تعداد صفحه
	///   4) ارسال از طریق مودم
	///   5) انتقال به آرشیو در صورت موفقیت، یا بازگشت به صف در صورت شکست
	/// </summary>
	public class SmsSenderWorker : IDisposable
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

		private readonly SmsBanOptions	_options;
		private readonly ModemGateway	_modem;
		private readonly SmsRateLimiter	_limiter;

		private Thread					_thread;
		private volatile bool			_stopping;
		private bool					_disposed;

		/// <summary>زمان انتظاری که پس از پر شدن سهمیه محاسبه شده است.</summary>
		private DateTime				_waitUntil = DateTime.MinValue;

		public SmsSenderWorker(SmsBanOptions options, ModemGateway modem)
		{
			if (options == null)
				throw new ArgumentNullException("options");

			if (modem == null)
				throw new ArgumentNullException("modem");

			_options	= options;
			_modem		= modem;
			_limiter	= new SmsRateLimiter(options);
		}

		/// <summary>شناسه‌ی این نمونه، برای مالکیت ارسال.</summary>
		public string OwnerId
		{
			get
			{
				if (!string.IsNullOrWhiteSpace(_options.InstanceId))
					return _options.InstanceId;

				return string.Format("{0}-{1}", Environment.MachineName,
					System.Diagnostics.Process.GetCurrentProcess().Id);
			}
		}

		public bool IsRunning
		{
			get { return _thread != null && _thread.IsAlive; }
		}

		/// <summary>آخرین وضعیت مودم.</summary>
		public ModemStatus ModemStatus
		{
			get { return _modem.Status; }
		}

		// ==================================================================
		// چرخه‌ی عمر
		// ==================================================================

		public void Start()
		{
			if (_thread != null && _thread.IsAlive)
				return;

			_stopping = false;

			// پیامک‌هایی که به دلیل قطع برق در وضعیت «در حال ارسال» مانده‌اند آزاد شوند.
			RecoverStaleItems();

			_thread = new Thread(Loop)
			{
				IsBackground	= true,
				Name			= "SmsBan-Sender"
			};

			_thread.Start();

			log.Info("نخ ارسال پیامک آغاز شد.");
		}

		public void Stop()
		{
			_stopping = true;

			if (_thread != null && _thread.IsAlive)
				_thread.Join(TimeSpan.FromSeconds(15));

			_thread = null;

			try
			{
				using (var db = CreateContext())
				{
					SmsWorkerStateService.Release(db, OwnerId);
				}
			}
			catch (Exception ex)
			{
				log.Error(ex);
			}

			log.Info("نخ ارسال پیامک متوقف شد.");
		}

		private SmsBanContext CreateContext()
		{
			return SmsBanDb.Create(_options.ConnectionString);
		}

		/// <summary>
		/// آزادسازی پیامک‌هایی که بیش از حد در وضعیت «در حال ارسال» مانده‌اند.
		/// این حالت پس از قطع ناگهانی برق یا بسته شدن برنامه رخ می‌دهد.
		/// </summary>
		private void RecoverStaleItems()
		{
			try
			{
				using (var db = CreateContext())
				{
					var threshold = DateTime.Now.AddMinutes(-5);

					int affected = db.Database.ExecuteSqlCommand(
						"UPDATE SmsBan.tbl_SmsOutbox " +
						"   SET Status = @p0, LockedBy = NULL, LockedAt = NULL, LockedAtShamsi = NULL " +
						" WHERE Status = @p1 AND (LockedAt IS NULL OR LockedAt < @p2)",
						(int)SmsMessageStatus.Pending,
						(int)SmsMessageStatus.Sending,
						threshold);

					if (affected > 0)
						log.WarnFormat("{0} پیامک رهاشده در وضعیت «در حال ارسال» به صف برگردانده شد.", affected);
				}
			}
			catch (Exception ex)
			{
				log.Error(ex);
			}
		}

		// ==================================================================
		// حلقه‌ی اصلی
		// ==================================================================

		private void Loop()
		{
			while (!_stopping)
			{
				try
				{
					var processed = ProcessOnce();

					if (!processed)
						Thread.Sleep(Math.Max(200, _options.SendPollIntervalMs));
				}
				catch (Exception ex)
				{
					log.Error(ex);
					Thread.Sleep(2000);
				}
			}
		}

		/// <summary>
		/// یک دور پردازش: حداکثر یک پیامک ارسال می‌شود.
		/// خروجی true یعنی یک پیامک پردازش شد.
		/// </summary>
		public bool ProcessOnce()
		{
			// اگر زمان انتظار سهمیه فرانرسیده باشد، کاری انجام نمی‌شود.
			if (DateTime.Now < _waitUntil)
				return false;

			// آماده‌سازی مودم.
			if (!_modem.Status.Connected)
			{
				var status = _modem.Open();

				if (!status.DeviceFound)
				{
					_waitUntil = DateTime.Now.AddSeconds(5);
					return false;
				}

				try
				{
					using (var db = CreateContext())
					{
						SmsWorkerStateService.SetModemDevice(db, status.DeviceInfo);
					}
				}
				catch (Exception ex)
				{
					log.Error(ex);
				}
			}

			using (var db = CreateContext())
			{
				// وضعیت توقف.
				var state = SmsWorkerStateService.Get(db);

				if (state != null && state.IsPaused)
					return false;

				// مالکیت ارسال.
				if (!SmsWorkerStateService.TryAcquireLease(db, OwnerId, _options.LeaseSeconds))
					return false;

				SmsWorkerStateService.Touch(db, OwnerId);

				// برداشتن پیامک بعدی صف.
				var next = db.tbl_SmsOutbox
					.AsNoTracking()
					.Where(x => x.Status == (int)SmsMessageStatus.Pending)
					.OrderBy(x => x.SortOrder)
					.ThenBy(x => x.ID)
					.FirstOrDefault();

				if (next == null)
					return false;

				// بررسی سهمیه پیش از برداشتن پیامک.
				var wait = _limiter.GetWaitTime(next.PageCount);

				if (wait > TimeSpan.Zero)
				{
					_waitUntil = DateTime.Now.Add(wait);

					log.InfoFormat(
						"سهمیه‌ی ارسال تکمیل است. ارسال {0} صفحه نیاز به {1} انتظار دارد.",
						next.PageCount, wait);

					return false;
				}

				// برداشتن اتمیک پیامک.
				if (!TryClaim(db, next.ID))
					return false;

				return SendClaimed(db, next.ID);
			}
		}

		/// <summary>
		/// تغییر وضعیت پیامک به «در حال ارسال» به‌صورت اتمیک.
		/// اگر نمونه‌ی دیگری زودتر آن را برداشته باشد، false برمی‌گردد.
		/// </summary>
		private bool TryClaim(SmsBanContext db, long id)
		{
			var now = DateTime.Now;

			int affected = db.Database.ExecuteSqlCommand(
				"UPDATE SmsBan.tbl_SmsOutbox " +
				"   SET Status = @p0, LockedBy = @p1, LockedAt = @p2, LockedAtShamsi = @p3 " +
				" WHERE ID = @p4 AND Status = @p5",
				(int)SmsMessageStatus.Sending,
				OwnerId,
				now,
				JalaliDate.ToShamsi(now),
				id,
				(int)SmsMessageStatus.Pending);

			return affected > 0;
		}

		/// <summary>
		/// ارسال پیامک برداشته‌شده و ثبت نتیجه.
		/// </summary>
		private bool SendClaimed(SmsBanContext db, long id)
		{
			var item = db.tbl_SmsOutbox.FirstOrDefault(x => x.ID == id);

			if (item == null)
				return false;

			var attemptStart = DateTime.Now;

			var sendOptions = new ModemSendOptions
			{
				RequestDeliveryReport	= _options.RequestDeliveryReport,
				SendInterval			= _options.SendInterval,
				RetryTimes				= _options.ModemRetryTimes,
				SmsValidity				= _options.SmsValidity,
				SmsCenter				= _options.SmsCenter
			};

			var result = _modem.Send(item.PhoneNumber, item.MessageText, sendOptions);

			var duration = (int)(DateTime.Now - attemptStart).TotalMilliseconds;

			if (result.Success)
				CompleteItem(db, item, result.Reference, attemptStart, duration);
			else
				FailItem(db, item, result, attemptStart, duration);

			return true;
		}

		/// <summary>ثبت ارسال موفق: انتقال به آرشیو و کسر از سهمیه.</summary>
		private void CompleteItem(SmsBanContext db, SmsOutbox item, string reference, DateTime sentAt, int durationMs)
		{
			using (var transaction = db.Database.BeginTransaction())
			{
				db.tbl_SmsArchive.Add(new SmsArchive
				{
					OutboxID		= item.ID,
					SortOrder		= item.SortOrder,
					Priority		= item.Priority,
					PhoneNumber		= item.PhoneNumber,
					MessageText		= item.MessageText,
					PageCount		= item.PageCount,
					Status			= (int)SmsMessageStatus.Sent,
					RetryCount		= item.RetryCount,
					SmsReference	= reference,
					CreatedAt		= item.CreatedAt,
					CreatedAtShamsi	= item.CreatedAtShamsi,
					SentAt			= sentAt,
					SentAtShamsi	= JalaliDate.ToShamsi(sentAt),
					DurationMs		= durationMs,
					ModemDevice		= _modem.Status.DeviceInfo,
					EnqueuedBy		= item.EnqueuedBy,
					SentBy			= OwnerId,
					SendInterval	= _options.SendInterval,
					RetryTimes		= _options.ModemRetryTimes,
					SmsValidity		= _options.SmsValidity,
					SmsCenter		= _options.SmsCenter
				});

				db.tbl_SmsOutbox.Remove(item);
				db.SaveChanges();

				transaction.Commit();
			}

			_limiter.RegisterSend(item.PageCount, sentAt);

			log.InfoFormat("پیامک {0} به {1} ({2} صفحه) ارسال شد. مرجع: {3}",
				item.ID, item.PhoneNumber, item.PageCount, reference);
		}

		/// <summary>
		/// ثبت شکست: بازگشت به صف تا سقف مجاز، سپس ثبت به عنوان غیرقابل ارسال.
		/// </summary>
		private void FailItem(SmsBanContext db, SmsOutbox item, ModemSendResult result, DateTime sentAt, int durationMs)
		{
			var error = string.IsNullOrWhiteSpace(result.ErrorCode)
				? result.Message
				: string.Format("{0} (کد {1})", result.Message, result.ErrorCode);

			bool canRetry = item.RetryCount < _options.MaxRetryCount;

			using (var transaction = db.Database.BeginTransaction())
			{
				if (canRetry)
				{
					var max = db.tbl_SmsOutbox.Max(x => (decimal?)x.SortOrder);

					item.RetryCount++;
					item.Status			= (int)SmsMessageStatus.Pending;
					item.LastError		= error;
					item.LockedBy		= null;
					item.LockedAt		= null;
					item.LockedAtShamsi	= null;

					// به انتهای صف می‌رود تا مانع ارسال بقیه نشود.
					item.SortOrder		= (max ?? SmsQueueService.InitialSortOrder) + SmsQueueService.SortGap;

					db.SaveChanges();
					transaction.Commit();

					log.WarnFormat("ارسال پیامک {0} ناموفق بود ({1}). بازگشت به صف: تلاش {2} از {3}.",
						item.ID, error, item.RetryCount, _options.MaxRetryCount);
				}
				else
				{
					db.tbl_SmsArchive.Add(new SmsArchive
					{
						OutboxID		= item.ID,
						SortOrder		= item.SortOrder,
						Priority		= item.Priority,
						PhoneNumber		= item.PhoneNumber,
						MessageText		= item.MessageText,
						PageCount		= item.PageCount,
						Status			= (int)SmsMessageStatus.Failed,
						RetryCount		= item.RetryCount,
						ErrorMessage	= error,
						CreatedAt		= item.CreatedAt,
						CreatedAtShamsi	= item.CreatedAtShamsi,
						SentAt			= sentAt,
						SentAtShamsi	= JalaliDate.ToShamsi(sentAt),
						DurationMs		= durationMs,
						ModemDevice		= _modem.Status.DeviceInfo,
						EnqueuedBy		= item.EnqueuedBy,
						SentBy			= OwnerId,
						SendInterval	= _options.SendInterval,
						RetryTimes		= _options.ModemRetryTimes,
						SmsValidity		= _options.SmsValidity,
						SmsCenter		= _options.SmsCenter
					});

					db.tbl_SmsOutbox.Remove(item);
					db.SaveChanges();
					transaction.Commit();

					log.ErrorFormat("ارسال پیامک {0} پس از {1} تلاش ناموفق ماند: {2}",
						item.ID, item.RetryCount, error);
				}
			}
		}

		public void Dispose()
		{
			if (_disposed)
				return;

			_disposed = true;
			Stop();

			GC.SuppressFinalize(this);
		}
	}
}
