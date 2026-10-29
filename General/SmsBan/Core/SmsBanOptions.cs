using System;

namespace SmsBan.Core
{
	/// <summary>
	/// مدت اعتبار پیامک در مرکز پیامک (پارامتر <c>SMS_Validity</c> مودم).
	///
	/// مقادیر دقیقاً مطابق فهرست نمونه‌ی رسمی شرکت است.
	/// </summary>
	public enum SmsValidityPeriod
	{
		/// <summary>۱ ساعت</summary>
		OneHour			= 1,

		/// <summary>۳ ساعت</summary>
		ThreeHours		= 2,

		/// <summary>۶ ساعت</summary>
		SixHours		= 3,

		/// <summary>۱۲ ساعت</summary>
		TwelveHours		= 4,

		/// <summary>۲۴ ساعت</summary>
		TwentyFourHours	= 5,

		/// <summary>۱ هفته</summary>
		OneWeek			= 6,

		/// <summary>حداکثر مدت ممکن</summary>
		Maximum			= 7
	}

	/// <summary>
	/// تنظیمات ماژول ارسال پیامک که هنگام ساخت سرویس به آن داده می‌شود.
	/// </summary>
	public class SmsBanOptions
	{
		/// <summary>
		/// رشته‌ی اتصال بانک اطلاعاتی. اجباری است.
		/// مثال: Server=.\sqlentr;Database=DB_NzResaaStore;User Id=sa;Password=...;
		/// </summary>
		public string	ConnectionString		{ get; set; }

		// ==================================================================
		// سهمیه
		// ==================================================================

		/// <summary>
		/// حداکثر تعداد صفحه‌ی قابل ارسال در شبانه‌روز.
		/// مبنا «صفحه» است، نه «پیامک»؛ یک پیامک سه‌صفحه‌ای سه واحد مصرف می‌کند.
		/// </summary>
		public int		MaxSmsPerDay			{ get; set; }

		/// <summary>حداکثر تعداد صفحه‌ی قابل ارسال در هر دقیقه.</summary>
		public int		MaxSmsPerMinute			{ get; set; }

		/// <summary>
		/// تعداد حروف (کاراکتر) در یک صفحه‌ی پیامکی.
		/// برای پیامک فارسی مقدار ۷۰ رایج است.
		/// </summary>
		public int		CharsPerPage			{ get; set; }

		// ==================================================================
		// شماره‌ی مقصد
		// ==================================================================

		/// <summary>
		/// پیش‌شماره‌ی کشور برای ساخت شماره‌ی مقصد. برای ایران «98».
		/// شماره‌ی نهایی به شکل «پیش‌شماره + شماره‌ی ملی بدون صفر ابتدایی» ساخته می‌شود،
		/// مثلاً 98 + 9123456789 = 989123456789
		/// (بدون علامت + و بدون صفر ابتدایی، مطابق نمونه‌ی رسمی شرکت).
		/// </summary>
		public string	CountryCode				{ get; set; }

		// ==================================================================
		// انتخاب مودم
		// ==================================================================

		/// <summary>
		/// شماره‌ی دستگاهی که با تابع <c>SMS_Select_Device</c> انتخاب می‌شود.
		///
		/// توجه: این «شماره دستگاه» است، نه اندیس دستگاه.
		/// بازه‌ی مجاز ۰ تا ۱۲۷ است (مطابق نمونه‌ی رسمی شرکت).
		/// </summary>
		public int		DeviceNumber			{ get; set; }

		// ==================================================================
		// پارامترهای ارسال
		// ==================================================================

		/// <summary>
		/// مدت اعتبار پیامک (پارامتر <c>SMS_Validity</c>).
		/// مقدار را از <see cref="SmsValidityPeriod"/> بگیرید؛ بازه‌ی مجاز ۱ تا ۷.
		/// </summary>
		public int		SmsValidity				{ get; set; }

		/// <summary>
		/// فاصله‌ی زمانی بین ارسال بخش‌های یک پیامک چندصفحه‌ای، به میلی‌ثانیه
		/// (پارامتر <c>Send_Interval</c>). مقدار پیش‌فرض ۱۰۰۰ میلی‌ثانیه،
		/// مطابق نمونه‌ی رسمی شرکت.
		/// </summary>
		public int		PartSendIntervalMs		{ get; set; }

		/// <summary>
		/// تعداد تلاش مجدد مودم در صورت بروز مشکل هنگام ارسال
		/// (پارامتر <c>Retry_Times</c>). مقدار پیش‌فرض ۲، مطابق نمونه‌ی رسمی شرکت.
		/// این مقدار با <see cref="MaxRetryCount"/> که مربوط به بازگشت به صف است تفاوت دارد.
		/// </summary>
		public int		ModemRetryCount			{ get; set; }

		/// <summary>
		/// شماره‌ی مرکز پیامک. اگر خالی باشد از سیم‌کارت خوانده می‌شود.
		/// </summary>
		public string	SmsCenter				{ get; set; }

		/// <summary>درخواست گزارش تحویل از اپراتور.</summary>
		public bool		RequestDeliveryReport	{ get; set; }

		// ==================================================================
		// صف و اجرا
		// ==================================================================

		/// <summary>هر چند دقیقه یک‌بار پیامک‌های رسیده از مودم خوانده شوند.</summary>
		public int		ReadIntervalMinutes		{ get; set; }

		/// <summary>
		/// اگر true باشد، این نمونه نخ ارسال و خواندن را اجرا می‌کند.
		/// این گزینه فقط روی کامپیوتری که مودم به آن وصل است باید true باشد.
		/// </summary>
		public bool		IsModemHost				{ get; set; }

		/// <summary>
		/// حداکثر تعداد بارهایی که یک پیامک ناموفق به صف برگردانده می‌شود.
		/// پس از آن به عنوان پیامک غیرقابل‌ارسال در آرشیو ثبت می‌شود.
		/// </summary>
		public int		MaxRetryCount			{ get; set; }

		/// <summary>فاصله‌ی زمانی بین بررسی‌های نخ ارسال، به میلی‌ثانیه.</summary>
		public int		SendPollIntervalMs		{ get; set; }

		/// <summary>
		/// مدت اعتبار مالکیت کامپیوتری که ارسال را در اختیار دارد (ثانیه).
		/// اگر ضربان مالک قدیمی‌تر از این مقدار باشد، مالکیت قابل تصاحب است.
		/// </summary>
		public int		LeaseSeconds			{ get; set; }

		/// <summary>
		/// اگر true باشد، هر پیامکی که خوانده و ذخیره‌اش در بانک تأیید شود
		/// از حافظه‌ی مودم پاک می‌شود.
		/// پیامکی که ذخیره نشده باشد در حافظه باقی می‌ماند.
		/// </summary>
		public bool		DeleteAfterRead			{ get; set; }

		/// <summary>حداکثر تعداد پیامکی که در هر دور خواندن از مودم بررسی می‌شود.</summary>
		public int		MaxReadPerCycle			{ get; set; }

		/// <summary>شناسه‌ی این نمونه/کامپیوتر. اگر خالی باشد خودکار ساخته می‌شود.</summary>
		public string	InstanceId				{ get; set; }

		/// <summary>شناسه‌ای که در فیلد «درخواست‌دهنده» ثبت می‌شود.</summary>
		public string	EnqueuedBy				{ get; set; }

		public SmsBanOptions()
		{
			MaxSmsPerDay			= 500;
			MaxSmsPerMinute			= 50;
			CharsPerPage			= SmsPageCalculator.DefaultCharsPerPage;
			CountryCode				= "98";
			DeviceNumber			= 0;
			SmsValidity				= (int)SmsValidityPeriod.Maximum;
			PartSendIntervalMs		= 1000;
			ModemRetryCount			= 2;
			RequestDeliveryReport	= true;
			ReadIntervalMinutes		= 5;
			IsModemHost				= true;
			MaxRetryCount			= 3;
			SendPollIntervalMs		= 1000;
			LeaseSeconds			= 60;
			DeleteAfterRead			= true;
			MaxReadPerCycle			= 500;
		}

		/// <summary>بررسی صحت تنظیمات و پرتاب استثنا در صورت نبود مقدار اجباری.</summary>
		public void Validate()
		{
			if (string.IsNullOrWhiteSpace(ConnectionString))
				throw new ArgumentException("رشته‌ی اتصال بانک اطلاعاتی تعیین نشده است.", "ConnectionString");

			if (MaxSmsPerDay <= 0)
				throw new ArgumentException("حداکثر پیامک روزانه باید بزرگ‌تر از صفر باشد.", "MaxSmsPerDay");

			if (MaxSmsPerMinute <= 0)
				throw new ArgumentException("حداکثر پیامک در دقیقه باید بزرگ‌تر از صفر باشد.", "MaxSmsPerMinute");

			if (CharsPerPage <= 0)
				throw new ArgumentException("تعداد حروف در صفحه باید بزرگ‌تر از صفر باشد.", "CharsPerPage");

			if (ReadIntervalMinutes <= 0)
				throw new ArgumentException("فاصله‌ی خواندن پیامک باید بزرگ‌تر از صفر باشد.", "ReadIntervalMinutes");

			if (DeviceNumber < 0 || DeviceNumber > 127)
				throw new ArgumentException("شماره دستگاه باید بین ۰ تا ۱۲۷ باشد.", "DeviceNumber");

			if (SmsValidity < (int)SmsValidityPeriod.OneHour || SmsValidity > (int)SmsValidityPeriod.Maximum)
				throw new ArgumentException("مدت اعتبار پیامک باید بین ۱ تا ۷ باشد.", "SmsValidity");

			if (PartSendIntervalMs < 0)
				throw new ArgumentException("فاصله‌ی بین بخش‌های پیامک نمی‌تواند منفی باشد.", "PartSendIntervalMs");

			if (ModemRetryCount < 0)
				throw new ArgumentException("تعداد تلاش مجدد مودم نمی‌تواند منفی باشد.", "ModemRetryCount");

			if (string.IsNullOrWhiteSpace(CountryCode))
				throw new ArgumentException("پیش‌شماره‌ی کشور تعیین نشده است.", "CountryCode");
		}
	}
}
