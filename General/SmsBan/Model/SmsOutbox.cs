using System;

namespace SmsBan.Model
{
	/// <summary>
	/// یک درخواست ارسال پیامک در صف.
	/// این جدول فقط پیامک‌های فعال (در انتظار یا در حال ارسال) را نگه می‌دارد؛
	/// به محض رسیدن به وضعیت نهایی، رکورد به <see cref="SmsArchive"/> منتقل و از صف حذف می‌شود.
	/// </summary>
	public class SmsOutbox
	{
		public long				ID					{ get; set; }

		/// <summary>
		/// ترتیب دقیق در صف. عدد کوچک‌تر زودتر ارسال می‌شود.
		/// عادی = بزرگ‌ترین + گام، فوری = کوچک‌ترین − گام، متوسط = میانگین.
		/// </summary>
		public decimal			SortOrder			{ get; set; }

		/// <summary>مقدار <see cref="SmsPriority"/> برای فیلتر و نمایش.</summary>
		public int				Priority			{ get; set; }

		public string			PhoneNumber			{ get; set; }

		public string			MessageText			{ get; set; }

		/// <summary>تعداد صفحات پیامک؛ مبنای مصرف سهمیه‌ی دقیقه و شبانه‌روز.</summary>
		public int				PageCount			{ get; set; }

		/// <summary>مقدار <see cref="SmsMessageStatus"/>.</summary>
		public int				Status				{ get; set; }

		/// <summary>تعداد بارهایی که این پیامک به صف برگشته است.</summary>
		public int				RetryCount			{ get; set; }

		public string			LastError			{ get; set; }

		public DateTime			CreatedAt			{ get; set; }

		public string			CreatedAtShamsi		{ get; set; }

		/// <summary>شناسه‌ی کامپیوتر/کاربری که درخواست را ثبت کرده است.</summary>
		public string			EnqueuedBy			{ get; set; }

		/// <summary>شناسه‌ی پردازش‌کننده‌ای که پیامک را برداشته است.</summary>
		public string			LockedBy			{ get; set; }

		public DateTime?		LockedAt			{ get; set; }

		public string			LockedAtShamsi		{ get; set; }
	}
}
