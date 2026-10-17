using System;

namespace SmsBan.Model
{
	/// <summary>
	/// وضعیت مشترک ماژول بین همه‌ی کامپیوترها. همیشه یک رکورد با شناسه‌ی ۱ دارد.
	/// شامل وضعیت توقف/ادامه‌ی ارسال و مالکیت (lease) کامپیوتری که به مودم وصل است.
	/// </summary>
	public class SmsWorkerState
	{
		public int				ID					{ get; set; }

		/// <summary>در صورت true هیچ پیامکی ارسال نمی‌شود تا دوباره ادامه داده شود.</summary>
		public bool				IsPaused			{ get; set; }

		public DateTime?		PausedAt			{ get; set; }

		public string			PausedAtShamsi		{ get; set; }

		public string			PausedBy			{ get; set; }

		/// <summary>مشخصات آخرین مودم شناسایی‌شده.</summary>
		public string			ModemDevice			{ get; set; }

		/// <summary>شناسه‌ی پردازش/کامپیوتری که در حال حاضر ارسال را در اختیار دارد.</summary>
		public string			OwnerID				{ get; set; }

		/// <summary>زمان آخرین ضربان مالک؛ اگر قدیمی باشد مالکیت قابل تصاحب است.</summary>
		public DateTime?		Heartbeat			{ get; set; }

		public DateTime			UpdatedAt			{ get; set; }
	}
}
