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
		/// تبدیل ارقام فارسی/عربی به لاتین و حذف کاراکترهای جداکننده،
		/// سپس افزودن پیش‌شماره‌ی کشور در صورت نبودن آن.
		/// </summary>
		public static string Normalize(string number, string countryCode)
		{
			if (string.IsNullOrWhiteSpace(number))
				return string.Empty;

			if (string.IsNullOrWhiteSpace(countryCode))
				countryCode = "+98";

			countryCode = countryCode.Trim();

			var clean = new StringBuilder(number.Length);

			foreach (var ch in number)
			{
				if (ch >= '0' && ch <= '9')
					clean.Append(ch);
				else if (ch >= '\u06F0' && ch <= '\u06F9')		// ارقام فارسی
					clean.Append((char)('0' + (ch - '\u06F0')));
				else if (ch >= '\u0660' && ch <= '\u0669')		// ارقام عربی
					clean.Append((char)('0' + (ch - '\u0660')));
				// سایر کاراکترها (فاصله، خط تیره، پرانتز، +) نادیده گرفته می‌شوند.
			}

			var digits = clean.ToString();

			if (digits.Length == 0)
				return string.Empty;

			var code = countryCode.Replace("+", string.Empty).Trim();

			// 0098... -> 98...
			if (digits.StartsWith("00"))
				digits = digits.Substring(2);

			// شماره‌ای که از قبل پیش‌شماره‌ی کشور را دارد.
			if (digits.StartsWith(code) && digits.Length > code.Length + 3)
				return "+" + digits;

			// شماره‌ی داخلی مانند 09121234567
			if (digits.StartsWith("0"))
				digits = digits.Substring(1);

			return "+" + code + digits;
		}

		/// <summary>نمایش خوانا برای گزارش‌ها.</summary>
		public static string ToDisplay(string number)
		{
			if (string.IsNullOrWhiteSpace(number))
				return string.Empty;

			return number.Replace("+98", "0").Trim();
		}
	}
}
