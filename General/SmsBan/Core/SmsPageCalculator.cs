using System;

namespace SmsBan.Core
{
	/// <summary>
	/// محاسبه‌ی تعداد صفحات یک پیامک.
	///
	/// نکته‌ی مهم: پیامک هرگز توسط این ماژول تقسیم نمی‌شود؛ متن کامل در یک
	/// فراخوانی به مودم داده می‌شود و خود DLL آن را به بخش‌ها می‌شکند.
	/// تعداد صفحات فقط برای دو کار محاسبه می‌شود:
	///   1) ذخیره در بانک اطلاعاتی (ستون PageCount)
	///   2) کسر از سهمیه‌ی «در دقیقه» و «شبانه‌روز»
	///
	/// اپراتور هر صفحه را یک پیامک محسوب می‌کند. برای مثال متن فارسی با
	/// ۱۶۰ کاراکتر و صفحه‌ی ۷۰ کاراکتری، ۳ پیامک محسوب می‌شود.
	/// </summary>
	public static class SmsPageCalculator
	{
		/// <summary>تعداد کاراکتر پیش‌فرض در یک صفحه‌ی پیامک فارسی (UCS2).</summary>
		public const int DefaultCharsPerPage = 70;

		/// <summary>
		/// محاسبه‌ی تعداد صفحات: سقف تقسیم طول متن بر تعداد کاراکتر هر صفحه.
		/// برای متن خالی صفر برمی‌گرداند.
		/// </summary>
		public static int CalculatePageCount(string text, int charsPerPage)
		{
			if (string.IsNullOrEmpty(text))
				return 0;

			if (charsPerPage <= 0)
				charsPerPage = DefaultCharsPerPage;

			return (int)Math.Ceiling(text.Length / (double)charsPerPage);
		}

		/// <summary>
		/// طول مؤثر متن به شکلی که اپراتور می‌شمارد.
		/// </summary>
		public static int GetEffectiveLength(string text)
		{
			if (string.IsNullOrEmpty(text))
				return 0;

			return text.Replace("\r\n", "\n").Length;
		}
	}
}
