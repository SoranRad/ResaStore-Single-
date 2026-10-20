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
	}
}
