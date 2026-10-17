using System;

namespace SmsBan.Core
{
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

		/// <summary>
		/// حداکثر تعداد صفحه‌ی قابل ارسال در شبانه‌روز.
		/// مبنا «صفحه» است، نه «پیامک»؛ یک پیامک سه‌صفحه‌ای سه واحد مصرف می‌کند.
		/// </summary>
		public int		MaxSmsPerDay			{ get; set; }

		/// <summary>
		/// حداکثر تعداد صفحه‌ی قابل ارسال در هر دقیقه.
		/// </summary>
		public int		MaxSmsPerMinute			{ get; set; }

		/// <summary>
		/// تعداد حروف (کاراکتر) در یک صفحه‌ی پیامکی.
		/// برای پیامک فارسی مقدار ۷۰ رایج است.
		/// </summary>
		public int		CharsPerPage			{ get; set; }

		/// <summary>
		/// هر چند دقیقه یک‌بار پیامک‌های رسیده از مودم خوانده شوند.
		/// </summary>
		public int		ReadIntervalMinutes		{ get; set; }

		/// <summary>
		/// پیش‌شماره‌ی کشور برای نرمال‌سازی شماره‌ها، مثلاً +98.
		/// </summary>
		public string	CountryCode				{ get; set; }

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

		/// <summary>فاصله‌ی ارسال بین بخش‌های یک پیامک چندصفحه‌ای (پارامتر مودم).</summary>
		public int		SendInterval			{ get; set; }

		/// <summary>تعداد تلاش مجدد خود مودم در صورت خطا.</summary>
		public int		ModemRetryTimes			{ get; set; }

		/// <summary>مدت اعتبار پیامک در مودم.</summary>
		public int		SmsValidity				{ get; set; }

		/// <summary>
		/// شماره‌ی مرکز پیامک. اگر خالی باشد از سیم‌کارت خوانده می‌شود.
		/// </summary>
		public string	SmsCenter				{ get; set; }

		/// <summary>درخواست گزارش تحویل از اپراتور.</summary>
		public bool		RequestDeliveryReport	{ get; set; }

		/// <summary>
		/// فاصله‌ی زمانی بین بررسی‌های نخ ارسال، به میلی‌ثانیه.
		/// </summary>
		public int		SendPollIntervalMs		{ get; set; }

		/// <summary>
		/// مدت اعتبار مالکیت کامپیوتری که ارسال را در اختیار دارد (ثانیه).
		/// اگر ضربان مالک قدیمی‌تر از این مقدار باشد، مالکیت قابل تصاحب است.
		/// </summary>
		public int		LeaseSeconds			{ get; set; }

		/// <summary>
		/// اگر true باشد، پس از خواندن موفق هر پیامک، از حافظه‌ی مودم حذف می‌شود.
		/// </summary>
		public bool		DeleteAfterRead			{ get; set; }

		/// <summary>
		/// حداکثر تعداد پیامکی که در هر دور خواندن از مودم بررسی می‌شود.
		/// </summary>
		public int		MaxReadPerCycle			{ get; set; }

		/// <summary>
		/// شناسه‌ی این نمونه/کامپیوتر. اگر خالی باشد خودکار ساخته می‌شود.
		/// </summary>
		public string	InstanceId				{ get; set; }

		/// <summary>
		/// شناسه‌ای که در فیلد «درخواست‌دهنده» ثبت می‌شود.
		/// </summary>
		public string	EnqueuedBy				{ get; set; }

		public SmsBanOptions()
		{
			MaxSmsPerDay			= 500;
			MaxSmsPerMinute			= 50;
			CharsPerPage			= SmsPageCalculator.DefaultCharsPerPage;
			ReadIntervalMinutes		= 5;
			CountryCode				= "+98";
			IsModemHost				= true;
			MaxRetryCount			= 3;
			SendInterval			= 0;
			ModemRetryTimes			= 0;
			SmsValidity				= 1;
			RequestDeliveryReport	= true;
			SendPollIntervalMs		= 1000;
			LeaseSeconds			= 60;
			DeleteAfterRead			= false;
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
		}
	}
}
