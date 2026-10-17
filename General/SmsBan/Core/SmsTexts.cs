using SmsBan.Model;

namespace SmsBan.Core
{
	/// <summary>
	/// برچسب‌های فارسی برای نمایش وضعیت‌ها در رابط کاربری و گزارش‌ها.
	/// </summary>
	public static class SmsTexts
	{
		public static string Priority(SmsPriority priority)
		{
			switch (priority)
			{
				case SmsPriority.Urgent:	return "فوری";
				case SmsPriority.Medium:	return "متوسط";
				default:					return "عادی";
			}
		}

		public static string Priority(int priority)
		{
			return Priority((SmsPriority)priority);
		}

		public static string Status(SmsMessageStatus status)
		{
			switch (status)
			{
				case SmsMessageStatus.Pending:	return "در انتظار ارسال";
				case SmsMessageStatus.Sending:	return "در حال ارسال";
				case SmsMessageStatus.Sent:		return "ارسال شد";
				case SmsMessageStatus.Failed:	return "ارسال نشد";
				case SmsMessageStatus.Canceled:	return "لغو شد";
				default:						return status.ToString();
			}
		}

		public static string Status(int status)
		{
			return Status((SmsMessageStatus)status);
		}
	}
}
