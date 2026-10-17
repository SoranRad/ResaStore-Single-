using System;
using System.Data.Entity;
using System.Linq;
using SmsBan.DataLayer;
using SmsBan.DataLayer.Context;
using SmsBan.Model;

namespace SmsBan.Core
{
	/// <summary>
	/// وضعیت سهمیه‌ی ارسال در لحظه.
	/// </summary>
	public class SmsQuota
	{
		public int DayLimit		{ get; set; }

		public int DayUsed		{ get; set; }

		public int MinuteLimit	{ get; set; }

		public int MinuteUsed	{ get; set; }

		public int DayRemaining
		{
			get { return Math.Max(0, DayLimit - DayUsed); }
		}

		public int MinuteRemaining
		{
			get { return Math.Max(0, MinuteLimit - MinuteUsed); }
		}

		/// <summary>
		/// آیا ارسال پیامکی با این تعداد صفحه، با توجه به سهمیه‌ی دقیقه و روز، مجاز است؟
		/// </summary>
		public bool CanSend(int pages)
		{
			return pages > 0
				&& pages <= DayRemaining
				&& pages <= MinuteRemaining;
		}

		public override string ToString()
		{
			return string.Format(
				"دقیقه: {0}/{1}   روز: {2}/{3}",
				MinuteUsed, MinuteLimit, DayUsed, DayLimit);
		}
	}

	/// <summary>
	/// کنترل سهمیه‌ی ارسال.
	///
	/// مبنای شمارش «تعداد صفحه» است، نه «تعداد پیامک».
	/// پنجره‌ی دقیقه به‌صورت غلتان (۶۰ ثانیه‌ی اخیر) و پنجره‌ی روز از
	/// نیمه‌شب محلی محاسبه می‌شود.
	///
	/// مقدار مصرف‌شده از جدول آرشیو خوانده می‌شود (دقیق و مقاوم در برابر خطا)
	/// و هم‌زمان در جدول شمارنده‌ها هم برای گزارش ذخیره می‌شود.
	/// </summary>
	public class SmsRateLimiter
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

		/// <summary>طول پنجره‌ی دقیقه به ثانیه.</summary>
		public const int MinuteWindowSeconds = 60;

		private readonly SmsBanOptions _options;

		public SmsRateLimiter(SmsBanOptions options)
		{
			if (options == null)
				throw new ArgumentNullException("options");

			_options = options;
		}

		private SmsBanContext CreateContext()
		{
			return SmsBanDb.Create(_options.ConnectionString);
		}

		/// <summary>
		/// خواندن سهمیه‌ی مصرف‌شده در پنجره‌ی دقیقه و روز.
		/// </summary>
		public SmsQuota GetQuota()
		{
			var quota = new SmsQuota
			{
				DayLimit	= _options.MaxSmsPerDay,
				MinuteLimit	= _options.MaxSmsPerMinute
			};

			using (var db = CreateContext())
			{
				var now			= DateTime.Now;
				var minuteFrom	= now.AddSeconds(-MinuteWindowSeconds);
				var dayFrom		= JalaliDate.StartOfToday();

				var sentStatus = (int)SmsMessageStatus.Sent;

				quota.MinuteUsed = db.tbl_SmsArchive
					.Where(x => x.Status == sentStatus
								&& x.SentAt != null
								&& x.SentAt >= minuteFrom)
					.Sum(x => (int?)x.PageCount) ?? 0;

				quota.DayUsed = db.tbl_SmsArchive
					.Where(x => x.Status == sentStatus
								&& x.SentAt != null
								&& x.SentAt >= dayFrom)
					.Sum(x => (int?)x.PageCount) ?? 0;
			}

			return quota;
		}

		/// <summary>
		/// چه مدت باید صبر کرد تا ارسال پیامکی با این تعداد صفحه مجاز شود؟
		/// صفر یعنی همین حالا مجاز است.
		/// </summary>
		public TimeSpan GetWaitTime(int pageCount)
		{
			if (pageCount <= 0)
				return TimeSpan.Zero;

			var quota = GetQuota();

			if (quota.CanSend(pageCount))
				return TimeSpan.Zero;

			// سهمیه‌ی روزانه تمام شده؛ صبر تا نیمه‌شب.
			if (quota.DayRemaining < pageCount)
			{
				var untilTomorrow = JalaliDate.StartOfTomorrow() - DateTime.Now;

				return untilTomorrow > TimeSpan.Zero
					? untilTomorrow
					: TimeSpan.FromMinutes(1);
			}

			// سهمیه‌ی دقیقه تمام شده؛ صبر تا آزاد شدن پنجره.
			var untilMinute = GetNextMinuteSlot() - DateTime.Now;

			return untilMinute > TimeSpan.Zero
				? untilMinute
				: TimeSpan.FromSeconds(1);
		}

		/// <summary>
		/// زمانی که قدیمی‌ترین ارسال پنجره‌ی جاری از پنجره خارج می‌شود.
		/// </summary>
		public DateTime GetNextMinuteSlot()
		{
			using (var db = CreateContext())
			{
				var minuteFrom	= DateTime.Now.AddSeconds(-MinuteWindowSeconds);
				var sentStatus	= (int)SmsMessageStatus.Sent;

				var oldest = db.tbl_SmsArchive
					.Where(x => x.Status == sentStatus
								&& x.SentAt != null
								&& x.SentAt >= minuteFrom)
					.Min(x => (DateTime?)x.SentAt);

				if (oldest == null)
					return DateTime.Now;

				return oldest.Value.AddSeconds(MinuteWindowSeconds);
			}
		}

		/// <summary>
		/// ثبت مصرف پس از ارسال موفق، در جدول شمارنده‌ها.
		/// این جدول برای گزارش «تعداد ارسال در دقیقه و روز» استفاده می‌شود.
		/// </summary>
		public void RegisterSend(int pageCount, DateTime sentAt)
		{
			if (pageCount <= 0)
				return;

			try
			{
				using (var db = CreateContext())
				using (var transaction = db.Database.BeginTransaction())
				{
					Increment(db, SmsRatePeriod.Minute, JalaliDate.StartOfMinute(sentAt), pageCount);
					Increment(db, SmsRatePeriod.Day,    JalaliDate.StartOfToday(),        pageCount);

					db.SaveChanges();
					transaction.Commit();
				}
			}
			catch (Exception ex)
			{
				// خطای شمارنده نباید مانع ارسال شود.
				log.Error(ex);
			}
		}

		private static void Increment(SmsBanContext db, SmsRatePeriod period, DateTime periodStart, int pageCount)
		{
			var periodKey = period == SmsRatePeriod.Minute
				? JalaliDate.ToGregorianMinuteKey(periodStart)
				: JalaliDate.ToGregorianDayKey(periodStart);

			var type = (int)period;

			var counter = db.tbl_SmsRateCounter
				.FirstOrDefault(x => x.PeriodType == type && x.PeriodKey == periodKey);

			if (counter == null)
			{
				db.tbl_SmsRateCounter.Add(new SmsRateCounter
				{
					PeriodType			= type,
					PeriodKey			= periodKey,
					PeriodKeyShamsi		= period == SmsRatePeriod.Minute
											? JalaliDate.ToShamsiMinuteKey(periodStart)
											: JalaliDate.ToShamsiDayKey(periodStart),
					PeriodStart			= periodStart,
					PeriodStartShamsi	= JalaliDate.ToShamsi(periodStart),
					PageCount			= pageCount,
					MessageCount		= 1,
					UpdatedAt			= DateTime.Now
				});

				return;
			}

			counter.PageCount		+= pageCount;
			counter.MessageCount	+= 1;
			counter.UpdatedAt		= DateTime.Now;
		}

		/// <summary>
		/// خواندن شمارنده‌ی یک بازه برای گزارش.
		/// </summary>
		public SmsRateCounter GetCounter(SmsRatePeriod period, DateTime periodStart)
		{
			var periodKey = period == SmsRatePeriod.Minute
				? JalaliDate.ToGregorianMinuteKey(periodStart)
				: JalaliDate.ToGregorianDayKey(periodStart);

			var type = (int)period;

			using (var db = CreateContext())
			{
				return db.tbl_SmsRateCounter
					.AsNoTracking()
					.FirstOrDefault(x => x.PeriodType == type && x.PeriodKey == periodKey);
			}
		}

		/// <summary>گزارش امروز.</summary>
		public SmsRateCounter GetTodayCounter()
		{
			return GetCounter(SmsRatePeriod.Day, JalaliDate.StartOfToday());
		}
	}
}
