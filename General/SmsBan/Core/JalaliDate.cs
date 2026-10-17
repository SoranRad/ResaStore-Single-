using System;
using System.Globalization;

namespace SmsBan.Core
{
	/// <summary>
	/// تبدیل و قالب‌بندی تاریخ و زمان به شمسی و میلادی.
	///
	/// طبق نیازمندی، همه‌ی تاریخ‌ها به هر دو تقویم ذخیره می‌شوند:
	///   - ستون‌های میلادی از نوع DateTime
	///   - ستون‌های شمسی از نوع رشته با قالب yyyy/MM/dd HH:mm:ss
	/// </summary>
	public static class JalaliDate
	{
		private static readonly PersianCalendar	Calendar	= new PersianCalendar();

		/// <summary>قالب کامل تاریخ و ساعت شمسی.</summary>
		public const string DateTimeFormat	= "yyyy/MM/dd HH:mm:ss";

		/// <summary>قالب تاریخ شمسی بدون ساعت.</summary>
		public const string DateFormat		= "yyyy/MM/dd";

		/// <summary>زمان جاری سیستم.</summary>
		public static DateTime Now
		{
			get { return DateTime.Now; }
		}

		/// <summary>تاریخ و ساعت شمسی، مثلاً 1405/01/21 14:35:02</summary>
		public static string ToShamsi(DateTime value)
		{
			return string.Format(
				"{0:0000}/{1:00}/{2:00} {3:00}:{4:00}:{5:00}",
				Calendar.GetYear(value),
				Calendar.GetMonth(value),
				Calendar.GetDayOfMonth(value),
				value.Hour,
				value.Minute,
				value.Second);
		}

		/// <summary>تاریخ شمسی بدون ساعت، مثلاً 1405/01/21</summary>
		public static string ToShamsiDate(DateTime value)
		{
			return string.Format(
				"{0:0000}/{1:00}/{2:00}",
				Calendar.GetYear(value),
				Calendar.GetMonth(value),
				Calendar.GetDayOfMonth(value));
		}

		/// <summary>کلید شمسی دقیقه، مثلاً 140501211435 (برای شمارنده‌ی دقیقه).</summary>
		public static string ToShamsiMinuteKey(DateTime value)
		{
			return string.Format(
				"{0:0000}{1:00}{2:00}{3:00}{4:00}",
				Calendar.GetYear(value),
				Calendar.GetMonth(value),
				Calendar.GetDayOfMonth(value),
				value.Hour,
				value.Minute);
		}

		/// <summary>کلید شمسی روز، مثلاً 14050121 (برای شمارنده‌ی روز).</summary>
		public static string ToShamsiDayKey(DateTime value)
		{
			return string.Format(
				"{0:0000}{1:00}{2:00}",
				Calendar.GetYear(value),
				Calendar.GetMonth(value),
				Calendar.GetDayOfMonth(value));
		}

		/// <summary>کلید میلادی دقیقه، مثلاً 202604101435.</summary>
		public static string ToGregorianMinuteKey(DateTime value)
		{
			return value.ToString("yyyyMMddHHmm", CultureInfo.InvariantCulture);
		}

		/// <summary>کلید میلادی روز، مثلاً 20260410.</summary>
		public static string ToGregorianDayKey(DateTime value)
		{
			return value.ToString("yyyyMMdd", CultureInfo.InvariantCulture);
		}

		/// <summary>قالب میلادی کامل برای گزارش‌های متنی.</summary>
		public static string ToGregorian(DateTime value)
		{
			return value.ToString("yyyy/MM/dd HH:mm:ss", CultureInfo.InvariantCulture);
		}

		/// <summary>ابتدای روز جاری به وقت محلی.</summary>
		public static DateTime StartOfToday()
		{
			var now = DateTime.Now;
			return new DateTime(now.Year, now.Month, now.Day, 0, 0, 0, DateTimeKind.Local);
		}

		/// <summary>ابتدای دقیقه‌ی مربوط به یک زمان.</summary>
		public static DateTime StartOfMinute(DateTime value)
		{
			return new DateTime(value.Year, value.Month, value.Day, value.Hour, value.Minute, 0, DateTimeKind.Local);
		}

		/// <summary>ابتدای روز بعد.</summary>
		public static DateTime StartOfTomorrow()
		{
			return StartOfToday().AddDays(1);
		}
	}
}
