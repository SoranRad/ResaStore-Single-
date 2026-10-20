using System;
using System.Collections.Generic;

namespace SmsBan.Modem
{
	/// <summary>
	/// نوع حذف پیامک از حافظه‌ی مودم/سیم‌کارت.
	/// مقادیر مطابق مستندات فایل OCX است.
	/// </summary>
	public enum ModemDeleteType
	{
		/// <summary>حذف بر اساس شماره‌ی پیامک (اندیس).</summary>
		ByIndex = 0,

		/// <summary>حذف پیامک‌های خوانده‌شده.</summary>
		Read = 1,

		/// <summary>حذف پیامک‌های خوانده و ارسال‌شده.</summary>
		ReadAndSent = 2,

		/// <summary>حذف پیامک‌های خوانده، ارسال‌شده و ارسال‌نشده.</summary>
		ReadSentAndUnsent = 3,

		/// <summary>حذف تمام پیامک‌ها.</summary>
		All = 6
	}

	/// <summary>
	/// کدهای رویدادی که مودم برمی‌گرداند. استخراج‌شده از نمونه‌ی رسمی شرکت.
	/// </summary>
	public static class ModemEventCode
	{
		public const int ModemReady					= 0;
		public const int ModemPowerOff				= 1;
		public const int ModemStartup				= 2;
		public const int OkDial						= 3;
		public const int NoDialTone					= 4;
		public const int NumberBusy					= 5;
		public const int NoCarrier					= 6;
		public const int NoAnswer					= 7;
		public const int NewSmsReceived				= 8;
		public const int Ring						= 9;
		public const int DeviceConnected			= 10;
		public const int CallerId					= 11;
		public const int ModemPowerOn				= 12;
		public const int NewSmsSaved				= 13;

		/// <summary>یک بخش پیامک ارسال و شماره‌ی مرجع دریافت شد.</summary>
		public const int SmsPartSentReference		= 14;

		/// <summary>ارسال پیامک ناموفق بود.</summary>
		public const int SmsSendFailed				= 15;

		/// <summary>شماره‌ی مرجع از سمت BTS دریافت نشد.</summary>
		public const int SmsNoReference				= 16;

		/// <summary>ارسال یک بخش پیامک با موفقیت انجام شد.</summary>
		public const int SmsPartSentSuccessful		= 17;

		/// <summary>ارسال تمام بخش‌های پیامک با موفقیت انجام شد.</summary>
		public const int SmsAllPartsSentSuccessful	= 18;
	}

	/// <summary>
	/// یک پیامک خوانده‌شده از حافظه‌ی مودم/سیم‌کارت.
	/// </summary>
	public class ModemSmsMessage
	{
		public int		Index		{ get; set; }

		public string	SmsCenter	{ get; set; }

		public string	SmsType		{ get; set; }

		public string	TelNumber	{ get; set; }

		public string	TimeStamp	{ get; set; }

		public string	Discharge	{ get; set; }

		public string	SmsText		{ get; set; }

		public string	TPPid		{ get; set; }

		public string	TPDcs		{ get; set; }

		public string	TPVp		{ get; set; }

		public string	TPSt		{ get; set; }

		public string	SReference	{ get; set; }

		public int		AllPart		{ get; set; }

		public int		PartNo		{ get; set; }

		public override string ToString()
		{
			return string.Format("[{0}] {1} : {2}", Index, TelNumber, SmsText);
		}
	}

	/// <summary>
	/// نتیجه‌ی یک تلاش ارسال پیامک.
	/// </summary>
	public class ModemSendResult
	{
		public bool		Success		{ get; set; }

		/// <summary>شماره‌ی مرجع؛ برای پیگیری گزارش تحویل به کار می‌رود.</summary>
		public string	Reference	{ get; set; }

		/// <summary>کد خطای گزارش‌شده توسط مودم.</summary>
		public string	ErrorCode	{ get; set; }

		public string	Message		{ get; set; }

		public override string ToString()
		{
			return Success
				? string.Format("OK (Ref={0})", Reference)
				: string.Format("FAILED (ErrorCode={0}, {1})", ErrorCode, Message);
		}
	}

	/// <summary>
	/// رویداد خوانده‌شده از صف رویدادهای مودم.
	/// </summary>
	public class ModemEvent
	{
		public int		Code	{ get; set; }

		public string	Text	{ get; set; }

		public DateTime	OccurredAt { get; set; }

		public override string ToString()
		{
			return string.Format("{0} -> {1}", Code, Text);
		}
	}

	/// <summary>
	/// وضعیت اتصال به مودم.
	/// </summary>
	public class ModemStatus
	{
		public bool		DeviceFound		{ get; set; }

		public bool		Connected		{ get; set; }

		public bool		Ready			{ get; set; }

		public short	DeviceCount		{ get; set; }

		/// <summary>شماره دستگاهی که با <c>SMS_Select_Device</c> انتخاب شده است (۰ تا ۱۲۷).</summary>
		public int		SelectedDeviceNumber	{ get; set; }

		public string	DeviceInfo		{ get; set; }

		public string	SoftwareVersion	{ get; set; }

		public string	Imei			{ get; set; }

		public string	SimId			{ get; set; }

		public string	Signal			{ get; set; }

		public string	SmsCenter		{ get; set; }

		public string	LastError		{ get; set; }

		public override string ToString()
		{
			return string.Format("{0} | Connected={1} | Ready={2} | Sig={3}",
				DeviceInfo, Connected, Ready, Signal);
		}
	}
}
