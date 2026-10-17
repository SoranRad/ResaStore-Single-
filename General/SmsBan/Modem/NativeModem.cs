using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace SmsBan.Modem
{
	/// <summary>
	/// اعلان توابع بومی DLL مودم (DllManshoorGSM.dll).
	///
	/// نکات مهم:
	/// 1) نام توابع در این کلاس با جدول Export واقعی DLL تطبیق داده شده است.
	///    دو مورد در نمونه‌ی رسمی شرکت اشتباه بود:
	///       - نام درست تابع وضعیت صف: Get_SMS_Buf_Status2  (نه Get_SMS_Buf_Status)
	///       - نام درست تابع نمایش پیامک آفلاین: Show_Oflline_SMS (نه Total_Oflline_SMS_NO)
	/// 2) معماری DLL باید با معماری پروسه یکسان باشد؛ در غیر این صورت
	///    خطای BadImageFormatException رخ می‌دهد.
	/// 3) این DLL رشته‌ها را به صورت BSTR (نوع WideString دلفی) می‌پذیرد و
	///    برمی‌گرداند، بنابراین CharSet.Unicode به همراه MarshalAs(BStr) لازم است.
	/// </summary>
	internal static class NativeModem
	{
		internal const string DllName = "DllManshoorGSM.dll";

		// ------------------------------------------------------------------
		// بررسی وجود و معماری فایل DLL
		// ------------------------------------------------------------------

		/// <summary>
		/// مسیر مورد انتظار فایل DLL (کنار اسمبلی در حال اجرا).
		/// </summary>
		internal static string ExpectedDllPath
		{
			get { return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, DllName); }
		}

		/// <summary>
		/// اطمینان از وجود فایل بومی و هم‌خوانی معماری آن با پروسه.
		/// در صورت مشکل، پیام فارسی گویا پرتاب می‌شود.
		/// </summary>
		internal static void EnsureAvailable()
		{
			var path = ExpectedDllPath;

			if (!File.Exists(path))
				throw new FileNotFoundException(
					string.Format(
						"فایل «{0}» در مسیر «{1}» پیدا نشد. " +
						"این فایل باید کنار فایل اجرایی برنامه قرار داشته باشد.",
						DllName, AppDomain.CurrentDomain.BaseDirectory), path);

			var expected = Environment.Is64BitProcess ? "x64" : "x86";
			var actual   = DetectArchitecture(path);

			if (actual != null && actual != expected)
				throw new BadImageFormatException(
					string.Format(
						"معماری فایل «{0}» برابر {1} است در حالی که برنامه در حالت {2} اجرا می‌شود. " +
						"باید نسخه‌ی {2} این فایل استفاده شود.",
						DllName, actual, expected));
		}

		/// <summary>
		/// خواندن معماری فایل PE. مقدار بازگشتی "x86"، "x64" یا null است.
		/// </summary>
		internal static string DetectArchitecture(string filePath)
		{
			try
			{
				using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
				using (var reader = new BinaryReader(stream))
				{
					if (stream.Length < 0x200)
						return null;

					stream.Position = 0x3C;
					int peOffset = reader.ReadInt32();

					if (peOffset <= 0 || peOffset + 6 > stream.Length)
						return null;

					stream.Position = peOffset;
					if (reader.ReadUInt32() != 0x00004550)	// "PE\0\0"
						return null;

					ushort machine = reader.ReadUInt16();

					switch (machine)
					{
						case 0x014C: return "x86";
						case 0x8664: return "x64";
						default:     return null;
					}
				}
			}
			catch
			{
				return null;
			}
		}

		// ------------------------------------------------------------------
		// شناسایی و انتخاب دستگاه
		// ------------------------------------------------------------------

		[DllImport(DllName, EntryPoint = "SMS_Device_Count", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
		internal static extern short SMS_Device_Count();

		[DllImport(DllName, EntryPoint = "SMS_Select_Device", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
		internal static extern void SMS_Select_Device(short index);

		[DllImport(DllName, EntryPoint = "SMS_SelectDeicve_ByIndex", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
		internal static extern void SMS_SelectDeicve_ByIndex(short index);

		[DllImport(DllName, EntryPoint = "SMS_Dev_INFO", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
		internal static extern void SMS_Dev_INFO([MarshalAs(UnmanagedType.BStr)] out string devInfo);

		[DllImport(DllName, EntryPoint = "SMS_Soft_Ver", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
		internal static extern void SMS_Soft_Ver([MarshalAs(UnmanagedType.BStr)] out string softVer);

		// ------------------------------------------------------------------
		// وضعیت اتصال
		// ------------------------------------------------------------------

		[DllImport(DllName, EntryPoint = "GSM_Test_Connect", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
		internal static extern bool GSM_Test_Connect();

		[DllImport(DllName, EntryPoint = "GSM_Ready", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
		internal static extern bool GSM_Ready();

		[DllImport(DllName, EntryPoint = "GSM_ON", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
		internal static extern bool GSM_ON();

		[DllImport(DllName, EntryPoint = "GSM_OFF", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
		internal static extern bool GSM_OFF();

		// ------------------------------------------------------------------
		// تنظیمات
		// ------------------------------------------------------------------

		[DllImport(DllName, EntryPoint = "SMS_Char_Mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
		internal static extern bool SMS_Char_Mode(int charMode);

		[DllImport(DllName, EntryPoint = "SMS_PDU_Mode", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
		internal static extern bool SMS_PDU_Mode(bool pdu);

		[DllImport(DllName, EntryPoint = "R_SMS_Center", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
		internal static extern void R_SMS_Center([MarshalAs(UnmanagedType.BStr)] out string result);

		[DllImport(DllName, EntryPoint = "GSM_Set_Device_NO", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
		internal static extern bool GSM_Set_Device_NO(int deviceNo);

		[DllImport(DllName, EntryPoint = "GSM_Get_Device_NO", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
		internal static extern int GSM_Get_Device_NO();

		// ------------------------------------------------------------------
		// ارسال
		// ------------------------------------------------------------------

		/// <summary>
		/// ارسال پیامک (متن کامل، بدون تقسیم). نتیجه در پارامتر اول برگردانده می‌شود
		/// و همان شماره‌ی مرجع پیامک است.
		/// </summary>
		[DllImport(DllName, EntryPoint = "S_SMS3", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
		internal static extern void S_SMS3(
			[MarshalAs(UnmanagedType.BStr)] out string result,
			[MarshalAs(UnmanagedType.BStr)] string phoneNo,
			[MarshalAs(UnmanagedType.BStr)] string smsText,
			bool requestDeliveryReport,
			int  sendInterval,
			int  retryTimes,
			int  smsValidity,
			int  smsReference,
			[MarshalAs(UnmanagedType.BStr)] string smsCenter);

		[DllImport(DllName, EntryPoint = "Send_SMS_Error_Code", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
		internal static extern void Send_SMS_Error_Code([MarshalAs(UnmanagedType.BStr)] out string result);

		[DllImport(DllName, EntryPoint = "R_SMS_Ref", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
		internal static extern void R_SMS_Ref([MarshalAs(UnmanagedType.BStr)] out string result);

		// ------------------------------------------------------------------
		// خواندن
		// ------------------------------------------------------------------

		[DllImport(DllName, EntryPoint = "Get_SMS_NO", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
		internal static extern int Get_SMS_NO();

		[DllImport(DllName, EntryPoint = "Recieved_New_SMS", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
		internal static extern bool Recieved_New_SMS(ref int indexFrom, ref int indexTo);

		[DllImport(DllName, EntryPoint = "R_SMS4", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
		internal static extern bool R_SMS4(
			[MarshalAs(UnmanagedType.BStr)] out string result,
			bool pdu,
			int  index,
			[MarshalAs(UnmanagedType.BStr)] out string smsCenter,
			[MarshalAs(UnmanagedType.BStr)] out string smsType,
			[MarshalAs(UnmanagedType.BStr)] out string telNumber,
			[MarshalAs(UnmanagedType.BStr)] out string timeStamp,
			[MarshalAs(UnmanagedType.BStr)] out string discharge,
			[MarshalAs(UnmanagedType.BStr)] out string smsText,
			[MarshalAs(UnmanagedType.BStr)] out string tpPid,
			[MarshalAs(UnmanagedType.BStr)] out string tpDcs,
			[MarshalAs(UnmanagedType.BStr)] out string tpVp,
			[MarshalAs(UnmanagedType.BStr)] out string tpSt,
			[MarshalAs(UnmanagedType.BStr)] out string sReference,
			[MarshalAs(UnmanagedType.BStr)] out string allPart,
			[MarshalAs(UnmanagedType.BStr)] out string partNo);

		[DllImport(DllName, EntryPoint = "SMS_Delete", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
		internal static extern bool SMS_Delete(int index, int deleteType);

		// ------------------------------------------------------------------
		// اطلاعات سیم‌کارت و مودم
		// ------------------------------------------------------------------

		[DllImport(DllName, EntryPoint = "R_IMEI", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
		internal static extern void R_IMEI([MarshalAs(UnmanagedType.BStr)] out string imei);

		[DllImport(DllName, EntryPoint = "R_SIM_ID", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
		internal static extern void R_SIM_ID([MarshalAs(UnmanagedType.BStr)] out string simId);

		[DllImport(DllName, EntryPoint = "R_Natttional_Mobile_ID", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
		internal static extern void R_Natttional_Mobile_ID([MarshalAs(UnmanagedType.BStr)] out string nationalMobileId);

		[DllImport(DllName, EntryPoint = "GSM_Signal", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
		internal static extern void GSM_Signal([MarshalAs(UnmanagedType.BStr)] out string signal);

		// ------------------------------------------------------------------
		// رویدادها
		// ------------------------------------------------------------------

		[DllImport(DllName, EntryPoint = "Last_Buf_Index", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
		internal static extern short Last_Buf_Index();

		[DllImport(DllName, EntryPoint = "Clear_Buf", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
		internal static extern void Clear_Buf();

		[DllImport(DllName, EntryPoint = "Active_New_SMS_Event", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
		internal static extern bool Active_New_SMS_Event(bool active);

		[DllImport(DllName, EntryPoint = "Res_AT_Delay", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
		internal static extern void Res_AT_Delay(int delay);

		[DllImport(DllName, EntryPoint = "GSM_MSG", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall)]
		internal static extern void GSM_MSG(
			[MarshalAs(UnmanagedType.BStr)] out string result,
			ref int gsmCmd,
			ref int gsmLen);

		/// <summary>
		/// ساختار پیام رویداد مودم، مطابق تعریف نمونه‌ی رسمی شرکت.
		/// </summary>
		[StructLayout(LayoutKind.Sequential)]
		internal struct GsmMessageStruct
		{
			[MarshalAs(UnmanagedType.BStr)]
			public string	MessageText;

			/// <summary>کد رویداد؛ مقادیر در <see cref="ModemEventCode"/> تعریف شده است.</summary>
			public int		Result;
		}

		[DllImport(DllName, EntryPoint = "Get_GSM_Message", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
		internal static extern void Get_GSM_Message(out GsmMessageStruct gsmMsg);
	}
}
