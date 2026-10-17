using System;

namespace SmsBan.Model
{
	/// <summary>
	/// اولویت درخواست ارسال پیامک.
	/// مقدار عددی کوچک‌تر یعنی اولویت بالاتر.
	/// </summary>
	public enum SmsPriority
	{
		/// <summary>فوری – به ابتدای صف درج می‌شود.</summary>
		Urgent = 0,

		/// <summary>متوسط – به وسط صف درج می‌شود.</summary>
		Medium = 1,

		/// <summary>عادی – به انتهای صف اضافه می‌شود.</summary>
		Normal = 2
	}

	/// <summary>
	/// وضعیت یک پیامک در چرخه‌ی ارسال.
	/// </summary>
	public enum SmsMessageStatus
	{
		/// <summary>در صف، آماده‌ی ارسال.</summary>
		Pending = 0,

		/// <summary>توسط یکی از کامپیوترها برای ارسال برداشته شده است.</summary>
		Sending = 1,

		/// <summary>با موفقیت تحویل مودم شد.</summary>
		Sent = 2,

		/// <summary>پس از تلاش‌های مجاز، ارسال نشد.</summary>
		Failed = 3,

		/// <summary>توسط کاربر لغو شد.</summary>
		Canceled = 4
	}

	/// <summary>
	/// نوع بازه‌ی شمارنده‌ی مصرف سهمیه.
	/// </summary>
	public enum SmsRatePeriod
	{
		/// <summary>بازه‌ی یک‌دقیقه‌ای.</summary>
		Minute = 1,

		/// <summary>بازه‌ی یک‌روزه.</summary>
		Day = 2
	}
}
