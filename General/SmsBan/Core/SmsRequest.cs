using System;
using System.Text;
using SmsBan.Model;

namespace SmsBan.Core
{
	/// <summary>
	/// یک درخواست ارسال پیامک برای یک شماره با متن اختصاصی.
	/// </summary>
	public class SmsRequest
	{
		public string		PhoneNumber	{ get; set; }

		public string		Text		{ get; set; }

		/// <summary>
		/// اولویت این مورد. اگر مقدار نداشته باشد، اولویت دسته‌ای که این
		/// درخواست در آن ثبت شده اعمال می‌شود.
		/// </summary>
		public SmsPriority?	Priority	{ get; set; }

		public SmsRequest()
		{
		}

		public SmsRequest(string phoneNumber, string text)
		{
			PhoneNumber	= phoneNumber;
			Text		= text;
		}

		public SmsRequest(string phoneNumber, string text, SmsPriority priority)
		{
			PhoneNumber	= phoneNumber;
			Text		= text;
			Priority	= priority;
		}
	}

	/// <summary>
	/// فیلتر نمایش صف ارسال.
	/// </summary>
	public class SmsQueueFilter
	{
		public SmsMessageStatus?	Status		{ get; set; }

		public SmsPriority?			Priority	{ get; set; }

		public DateTime?			FromDate	{ get; set; }

		public DateTime?			ToDate		{ get; set; }

		/// <summary>جست‌وجوی بخشی از شماره‌ی مقصد.</summary>
		public string				PhoneNumber	{ get; set; }

		/// <summary>حداکثر تعداد ردیف بازگشتی. صفر یعنی بدون محدودیت.</summary>
		public int					MaxRows		{ get; set; }

		public SmsQueueFilter()
		{
			MaxRows = 1000;
		}
	}

	/// <summary>
	/// ردیف قابل نمایش صف؛ برای Grid یا هر رابط کاربری.
	/// </summary>
	public class SmsQueueItem
	{
		public long		ID				{ get; set; }

		public decimal	SortOrder		{ get; set; }

		public int		Priority		{ get; set; }

		public string	PriorityText	{ get; set; }

		public string	PhoneNumber		{ get; set; }

		/// <summary>
		/// نام مخاطبِ شماره؛ اگر شماره در دفترچه‌ی اشخاص نباشد «ناشناس» است.
		/// این مقدار در لایه‌ی نمایش پر می‌شود، نه در کوئری صف.
		/// </summary>
		public string	ContactName		{ get; set; }

		public string	MessageText		{ get; set; }

		public int		PageCount		{ get; set; }

		public int		Status			{ get; set; }

		public string	StatusText		{ get; set; }

		public int		RetryCount		{ get; set; }

		public string	LastError		{ get; set; }

		public DateTime	CreatedAt		{ get; set; }

		public string	CreatedAtShamsi	{ get; set; }

		public string	EnqueuedBy		{ get; set; }

		public string	LockedBy		{ get; set; }

		public override string ToString()
		{
			return string.Format("{0} [{1}] {2} : {3}", ID, PriorityText, PhoneNumber, MessageText);
		}
	}

	/// <summary>
	/// نرمال‌سازی شماره‌ی تلفن همراه برای تحویل به مودم.
	/// خروجی به شکل +989121234567 است.
	/// </summary>
	public static class SmsPhoneNumber
	{
		/// <summary>
		/// تنها ارقام لاتین را برمی‌گرداند؛ ارقام فارسی و عربی تبدیل می‌شوند
		/// و سایر کاراکترها (فاصله، خط تیره، پرانتز، علامت +) حذف می‌گردند.
		/// </summary>
		public static string DigitsOnly(string value)
		{
			if (string.IsNullOrEmpty(value))
				return string.Empty;

			var builder = new StringBuilder(value.Length);

			foreach (var ch in value)
			{
				if (ch >= '0' && ch <= '9')
					builder.Append(ch);
				else if (ch >= '\u06F0' && ch <= '\u06F9')		// ارقام فارسی
					builder.Append((char)('0' + (ch - '\u06F0')));
				else if (ch >= '\u0660' && ch <= '\u0669')		// ارقام عربی
					builder.Append((char)('0' + (ch - '\u0660')));
			}

			return builder.ToString();
		}

		/// <summary>
		/// ساخت شماره‌ی نهایی برای تحویل به مودم:
		///     پیش‌شماره‌ی کشور + شماره‌ی ملی بدون صفر ابتدایی
		///
		/// برای مثال با پیش‌شماره‌ی 98 و شماره‌ی 09123456789 نتیجه 989123456789 است.
		/// علامت + و صفر ابتدایی حذف می‌شوند.
		/// </summary>
		public static string Normalize(string number, string countryCode)
		{
			var digits = DigitsOnly(number);

			if (digits.Length == 0)
				return string.Empty;

			var code = DigitsOnly(countryCode);

			if (code.Length == 0)
				code = "98";

			// 0098... → 98...
			if (digits.StartsWith("00"))
				digits = digits.Substring(2);

			// اگر شماره از قبل پیش‌شماره‌ی کشور را دارد، دست‌نخورده می‌ماند.
			if (digits.StartsWith(code) && digits.Length > code.Length + 5)
				return digits;

			// صفر ابتدایی شماره‌ی ملی حذف می‌شود.
			if (digits.StartsWith("0"))
				digits = digits.Substring(1);

			return code + digits;
		}

		/// <summary>نمایش خوانا برای گزارش‌ها (به شکل 09121234567).</summary>
		public static string ToDisplay(string number, string countryCode)
		{
			if (string.IsNullOrWhiteSpace(number))
				return string.Empty;

			var digits = DigitsOnly(number);
			var code   = DigitsOnly(countryCode);

			if (code.Length == 0)
				code = "98";

			if (digits.StartsWith(code) && digits.Length > code.Length)
				return "0" + digits.Substring(code.Length);

			return digits;
		}

		/// <summary>نمایش خوانا با پیش‌شماره‌ی پیش‌فرض 98.</summary>
		public static string ToDisplay(string number)
		{
			return ToDisplay(number, "98");
		}

		/// <summary>
		/// شماره‌ی ملی بدون پیش‌شماره‌ی کشور و بدون صفر ابتدایی.
		/// مثلاً 989123456789 یا 09123456789 هر دو به 9123456789 تبدیل می‌شوند.
		/// </summary>
		public static string ToNational(string number, string countryCode)
		{
			var digits = DigitsOnly(number);

			if (digits.Length == 0)
				return string.Empty;

			var code = DigitsOnly(countryCode);

			if (code.Length == 0)
				code = "98";

			// 0098... → 98...
			if (digits.StartsWith("00"))
				digits = digits.Substring(2);

			// حذف پیش‌شماره‌ی کشور
			if (digits.StartsWith(code) && digits.Length > code.Length)
				digits = digits.Substring(code.Length);

			// حذف صفر ابتدایی
			if (digits.StartsWith("0"))
				digits = digits.Substring(1);

			return digits;
		}

		/// <summary>شماره‌ی ملی با پیش‌شماره‌ی پیش‌فرض 98.</summary>
		public static string ToNational(string number)
		{
			return ToNational(number, "98");
		}

		/// <summary>
		/// قالب‌بندی یک شماره‌ی ملی (بدون کد کشور) به شکل 912-345-6789.
		/// اگر طول شماره ۱۰ نباشد، بدون تغییر برگردانده می‌شود.
		/// </summary>
		public static string FormatNationalDigits(string nationalDigits)
		{
			var digits = DigitsOnly(nationalDigits);

			if (digits.Length != 10)
				return digits;

			return digits.Substring(0, 3) + "-" +
				   digits.Substring(3, 3) + "-" +
				   digits.Substring(6, 4);
		}

		/// <summary>
		/// قالب‌بندی هر شکل شماره به 912-345-6789.
		/// مثلاً 989123456789 و 09123456789 هر دو 912-345-6789 می‌شوند.
		/// </summary>
		public static string FormatNational(string number, string countryCode)
		{
			return FormatNationalDigits(ToNational(number, countryCode));
		}

		/// <summary>قالب‌بندی با پیش‌شماره‌ی پیش‌فرض 98.</summary>
		public static string FormatNational(string number)
		{
			return FormatNational(number, "98");
		}

		/// <summary>
		/// حالت‌های مختلف نوشتن یک شماره (برای جست‌وجو در بانک اطلاعاتی).
		///
		/// چون شماره‌ی پیامک‌های دریافتی ممکن است با قالب‌های مختلف ذخیره شده باشد
		/// (مثلاً 09121234567 یا +989121234567 یا 989121234567)، برای یافتن
		/// همه‌ی پیامک‌های یک مخاطب از این فهرست استفاده می‌شود.
		/// </summary>
		public static string[] Variants(string normalizedNumber, string countryCode)
		{
			if (string.IsNullOrWhiteSpace(normalizedNumber))
				return new string[0];

			var digits = DigitsOnly(normalizedNumber);

			if (digits.Length == 0)
				return new string[0];

			var code = DigitsOnly(countryCode);

			if (code.Length == 0)
				code = "98";

			var list = new System.Collections.Generic.List<string>();

			list.Add(digits);
			list.Add("+" + digits);
			list.Add("00" + digits);

			if (digits.StartsWith(code) && digits.Length > code.Length)
			{
				var rest = digits.Substring(code.Length);

				list.Add("0" + rest);
				list.Add(rest);
			}

			return System.Linq.Enumerable.ToArray(
				System.Linq.Enumerable.Distinct(list));
		}
	}
}
