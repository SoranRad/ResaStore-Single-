using System;

namespace SmsBan.Model
{
	/// <summary>
	/// شمارنده‌ی مصرف سهمیه‌ی ارسال، به تفکیک دقیقه و روز.
	/// هر رکورد مجموع صفحات ارسال‌شده در یک بازه را نگه می‌دارد.
	/// </summary>
	public class SmsRateCounter
	{
		public long				ID					{ get; set; }

		/// <summary>مقدار <see cref="SmsRatePeriod"/>.</summary>
		public int				PeriodType			{ get; set; }

		/// <summary>کلید یکتای بازه (میلادی)، مثلاً 202604101435 برای دقیقه و 20260410 برای روز.</summary>
		public string			PeriodKey			{ get; set; }

		/// <summary>همان کلید به شمسی، مثلاً 140501211435.</summary>
		public string			PeriodKeyShamsi		{ get; set; }

		public DateTime			PeriodStart			{ get; set; }

		public string			PeriodStartShamsi	{ get; set; }

		/// <summary>مجموع تعداد صفحات ارسال‌شده در این بازه.</summary>
		public int				PageCount			{ get; set; }

		/// <summary>تعداد پیامک‌های ارسال‌شده در این بازه.</summary>
		public int				MessageCount		{ get; set; }

		public DateTime			UpdatedAt			{ get; set; }
	}
}
