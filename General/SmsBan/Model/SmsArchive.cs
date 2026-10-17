using System;

namespace SmsBan.Model
{
	/// <summary>
	/// آرشیو نهایی پیامک‌ها همراه با جزئیات ارسال.
	/// هر پیامک پس از رسیدن به وضعیت نهایی (ارسال‌شده، ناموفق یا لغوشده)
	/// از صف حذف و در این جدول ثبت می‌شود.
	/// </summary>
	public class SmsArchive
	{
		public long				ID					{ get; set; }

		/// <summary>شناسه‌ی رکورد در صف، در زمان انتقال.</summary>
		public long?			OutboxID			{ get; set; }

		public decimal			SortOrder			{ get; set; }

		public int				Priority			{ get; set; }

		public string			PhoneNumber			{ get; set; }

		public string			MessageText			{ get; set; }

		/// <summary>تعداد صفحات پیامک.</summary>
		public int				PageCount			{ get; set; }

		/// <summary>
		/// وضعیت نهایی: <see cref="SmsMessageStatus.Sent"/>،
		/// <see cref="SmsMessageStatus.Failed"/> یا <see cref="SmsMessageStatus.Canceled"/>.
		/// </summary>
		public int				Status				{ get; set; }

		public int				RetryCount			{ get; set; }

		public string			ErrorMessage		{ get; set; }

		/// <summary>شماره‌ی مرجع دریافتی از مودم برای پیگیری گزارش تحویل.</summary>
		public string			SmsReference		{ get; set; }

		/// <summary>آیا تحویل پیامک توسط اپراتور تأیید شده است.</summary>
		public bool				IsDelivered			{ get; set; }

		public DateTime?		DeliveredAt			{ get; set; }

		public string			DeliveredAtShamsi	{ get; set; }

		public DateTime			CreatedAt			{ get; set; }

		public string			CreatedAtShamsi		{ get; set; }

		/// <summary>زمان شروع آخرین تلاش ارسال.</summary>
		public DateTime?		SentAt				{ get; set; }

		public string			SentAtShamsi		{ get; set; }

		/// <summary>مدت زمان آخرین تلاش ارسال به میلی‌ثانیه.</summary>
		public int?				DurationMs			{ get; set; }

		public string			ModemDevice			{ get; set; }

		public string			EnqueuedBy			{ get; set; }

		public string			SentBy				{ get; set; }

		// ---- جزئیات پارامترهای ارسال ----

		public int				SendInterval		{ get; set; }

		public int				RetryTimes			{ get; set; }

		public int				SmsValidity			{ get; set; }

		public string			SmsCenter			{ get; set; }
	}
}
