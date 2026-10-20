using System;
using System.Collections.Generic;

namespace SmsBan.Modem
{
	/// <summary>
	/// پارامترهای یک عملیات ارسال در سطح مودم.
	/// </summary>
	public class ModemSendOptions
	{
		/// <summary>درخواست گزارش تحویل از اپراتور.</summary>
		public bool		RequestDeliveryReport	{ get; set; }

		/// <summary>
		/// فاصله‌ی زمانی بین ارسال بخش‌های یک پیامک چندصفحه‌ای، به میلی‌ثانیه
		/// (پارامتر <c>Send_Interval</c>).
		/// </summary>
		public int		PartSendIntervalMs		{ get; set; }

		/// <summary>
		/// تعداد تلاش مجدد مودم در صورت بروز مشکل هنگام ارسال
		/// (پارامتر <c>Retry_Times</c>).
		/// </summary>
		public int		RetryCount				{ get; set; }

		/// <summary>
		/// مدت اعتبار پیامک در مرکز پیامک (پارامتر <c>SMS_Validity</c>)، بازه‌ی ۱ تا ۷.
		/// </summary>
		public int		SmsValidity				{ get; set; }

		/// <summary>شماره‌ی مرکز پیامک؛ اگر خالی باشد از سیم‌کارت خوانده می‌شود.</summary>
		public string	SmsCenter				{ get; set; }

		public ModemSendOptions()
		{
			RequestDeliveryReport	= true;
			PartSendIntervalMs		= 1000;
			RetryCount				= 2;
			SmsValidity				= 7;		// حداکثر
			SmsCenter				= null;
		}
	}

	/// <summary>
	/// حالت کاراکتر پیامک، مطابق مستندات فایل OCX.
	/// </summary>
	public enum ModemCharMode
	{
		Gsm			= 1,
		Hex			= 2,
		Ira			= 3,
		Pccp437		= 4,
		Iso88591	= 5,

		/// <summary>یونیکد دو بایتی؛ حالت لازم برای پیامک فارسی.</summary>
		Ucs2		= 6
	}

	/// <summary>
	/// پوشش امن روی توابع بومی DLL مودم.
	///
	/// تمام فراخوانی‌ها سریالایز می‌شوند، زیرا DLL یک حالت سراسری در سطح پروسه دارد
	/// و فراخوانی هم‌زمان از چند نخ نتیجه‌ی نامعتبر می‌دهد.
	/// </summary>
	public class ModemGateway : IDisposable
	{
		#region Logging
		private static readonly log4net.ILog log =
			log4net
				.LogManager
				.GetLogger
				(System.Reflection
					.MethodBase
					.GetCurrentMethod()
					.DeclaringType);
		#endregion

		/// <summary>قفل سراسری تمام فراخوانی‌های بومی.</summary>
		private static readonly object	_sync	= new object();

		private bool					_disposed;

		public ModemStatus				Status	{ get; private set; }

		/// <summary>
		/// شماره‌ی دستگاهی که با تابع <c>SMS_Select_Device</c> انتخاب می‌شود.
		/// این شماره دستگاه است، نه اندیس؛ بازه‌ی مجاز ۰ تا ۱۲۷.
		/// </summary>
		public int						DeviceNumber { get; set; }

		/// <summary>شماره دستگاهی که در آخرین <see cref="Open"/> واقعاً انتخاب شد.</summary>
		public int						SelectedDeviceNumber { get; private set; }

		public ModemGateway()
		{
			Status		= new ModemStatus();
			DeviceNumber = 1;
		}

		/// <summary>
		/// باز کردن و آماده‌سازی مودم.
		/// مودم مورد نظر با تابع <c>SMS_Select_Device</c> انتخاب می‌شود.
		/// </summary>
		public ModemStatus Open()
		{
			lock (_sync)
			{
				Status = new ModemStatus();

				try
				{
					NativeModem.EnsureAvailable();

					short count = NativeModem.SMS_Device_Count();

					Status.DeviceCount	= count;
					Status.DeviceFound	= count > 0;

					if (count <= 0)
					{
						Status.LastError = "هیچ مودمی شناسایی نشد.";
						log.Warn(Status.LastError);
						return Status;
					}

					// انتخاب دستگاه مورد نظر با تابع SMS_Select_Device.
					// این تابع «شماره دستگاه» (۰ تا ۱۲۷) می‌گیرد، نه اندیس دستگاه.
					var deviceNumber = DeviceNumber;

					if (deviceNumber < 0 || deviceNumber > 127)
					{
						log.WarnFormat(
							"شماره دستگاه {0} خارج از بازه ۰ تا ۱۲۷ است. مقدار ۱ استفاده می‌شود.",
							deviceNumber);

						deviceNumber = 1;
					}

					NativeModem.SMS_Select_Device((short)deviceNumber);

					SelectedDeviceNumber		= deviceNumber;
					Status.SelectedDeviceNumber	= deviceNumber;

					ReadIdentity();

					Status.Connected = NativeModem.GSM_Test_Connect();
					Status.Ready     = NativeModem.GSM_Ready();

					// پیامک فارسی: ابتدا نوع کاراکتر یونیکد، سپس حالت PDU.
					// ترتیب مهم است (طبق مستندات رسمی).
					if (!NativeModem.SMS_Char_Mode((int)ModemCharMode.Ucs2))
						log.Warn("تنظیم نوع کاراکتر روی UCS2 ناموفق بود.");

					if (!NativeModem.SMS_PDU_Mode(true))
						log.Warn("تنظیم حالت PDU ناموفق بود.");

					// فعال‌سازی رویداد پیامک جدید برای تشخیص دریافت.
					NativeModem.Active_New_SMS_Event(true);

					RefreshStatusCore();
				}
				catch (DllNotFoundException ex)
				{
					Status.LastError = string.Format("فایل «{0}» پیدا نشد یا بارگذاری نشد.", NativeModem.DllName);
					log.Error(Status.LastError, ex);
				}
				catch (BadImageFormatException ex)
				{
					Status.LastError = "معماری فایل DLL مودم با معماری برنامه هم‌خوان نیست.";
					log.Error(Status.LastError, ex);
				}
				catch (EntryPointNotFoundException ex)
				{
					Status.LastError = "یکی از توابع مورد انتظار در DLL مودم پیدا نشد.";
					log.Error(Status.LastError, ex);
				}
				catch (Exception ex)
				{
					Status.LastError = "خطا در آماده‌سازی مودم: " + ex.Message;
					log.Error(ex);
				}

				return Status;
			}
		}

		private void ReadIdentity()
		{
			try
			{
				string value;

				NativeModem.SMS_Dev_INFO(out value);
				Status.DeviceInfo = value;

				NativeModem.SMS_Soft_Ver(out value);
				Status.SoftwareVersion = value;

				NativeModem.R_IMEI(out value);
				Status.Imei = value;

				NativeModem.R_SIM_ID(out value);
				Status.SimId = value;
			}
			catch (Exception ex)
			{
				log.Error(ex);
			}
		}

		/// <summary>
		/// به‌روزرسانی وضعیت اتصال، آنتن و مرکز پیامک.
		/// </summary>
		public ModemStatus RefreshStatus()
		{
			lock (_sync)
			{
				try
				{
					RefreshStatusCore();
				}
				catch (Exception ex)
				{
					Status.LastError = ex.Message;
					log.Error(ex);
				}

				return Status;
			}
		}

		private void RefreshStatusCore()
		{
			Status.Connected = NativeModem.GSM_Test_Connect();
			Status.Ready     = NativeModem.GSM_Ready();

			string value;

			NativeModem.GSM_Signal(out value);
			Status.Signal = value;

			NativeModem.R_SMS_Center(out value);
			Status.SmsCenter = value;
		}

		/// <summary>
		/// ارسال یک پیامک. متن به‌صورت کامل و بدون تقسیم به DLL داده می‌شود؛
		/// تقسیم به بخش‌ها وظیفه‌ی خود DLL است.
		/// </summary>
		public ModemSendResult Send(string phoneNumber, string text, ModemSendOptions options)
		{
			var result = new ModemSendResult { Success = false };

			if (string.IsNullOrWhiteSpace(phoneNumber))
			{
				result.Message = "شماره‌ی مقصد خالی است.";
				return result;
			}

			if (string.IsNullOrEmpty(text))
			{
				result.Message = "متن پیامک خالی است.";
				return result;
			}

			options = options ?? new ModemSendOptions();

			lock (_sync)
			{
				try
				{
					NativeModem.EnsureAvailable();

					if (NativeModem.SMS_Device_Count() <= 0)
					{
						result.Message = "مودم متصل نیست.";
						return result;
					}

					// اطمینان از تنظیمات پیش از هر ارسال.
					NativeModem.SMS_Char_Mode((int)ModemCharMode.Ucs2);
					NativeModem.SMS_PDU_Mode(true);

					string smsCenter = options.SmsCenter;

					if (string.IsNullOrWhiteSpace(smsCenter))
						NativeModem.R_SMS_Center(out smsCenter);

					string reference;

					log.DebugFormat(
						"ارسال به {0} | اعتبار: {1} | تاخیر بین بخش‌ها: {2} ms | تلاش مجدد: {3} | گزارش تحویل: {4} | مرکز: {5}",
						phoneNumber, options.SmsValidity, options.PartSendIntervalMs,
						options.RetryCount, options.RequestDeliveryReport, smsCenter);

					NativeModem.S_SMS3(
						out reference,
						phoneNumber,
						text,
						options.RequestDeliveryReport,
						options.PartSendIntervalMs,
						options.RetryCount,
						options.SmsValidity,
						0,
						smsCenter ?? string.Empty);

					string errorCode;

					NativeModem.Send_SMS_Error_Code(out errorCode);
					result.ErrorCode = errorCode;

					result.Success   = !string.IsNullOrEmpty(reference);
					result.Reference = reference;
					result.Message   = result.Success ? "ارسال شد." : "ارسال انجام نشد.";

					if (!result.Success)
						log.WarnFormat("ارسال پیامک به {0} ناموفق بود. کد خطا: {1}", phoneNumber, errorCode);
				}
				catch (Exception ex)
				{
					result.Success = false;
					result.Message = ex.Message;
					log.Error(ex);
				}
			}

			return result;
		}

		/// <summary>تعداد پیامک‌های موجود در حافظه‌ی مودم/سیم‌کارت.</summary>
		public int GetSmsCount()
		{
			lock (_sync)
			{
				try
				{
					return NativeModem.Get_SMS_NO();
				}
				catch (Exception ex)
				{
					log.Error(ex);
					return -1;
				}
			}
		}

		/// <summary>
		/// بازه‌ی پیامک‌های تازه‌رسیده. اگر پیامک جدیدی نباشد false برمی‌گرداند.
		/// </summary>
		public bool TryGetNewSmsRange(out int indexFrom, out int indexTo)
		{
			indexFrom = 0;
			indexTo   = 0;

			lock (_sync)
			{
				try
				{
					return NativeModem.Recieved_New_SMS(ref indexFrom, ref indexTo);
				}
				catch (Exception ex)
				{
					log.Error(ex);
					return false;
				}
			}
		}

		/// <summary>خواندن یک پیامک بر اساس اندیس.</summary>
		public ModemSmsMessage Read(int index)
		{
			lock (_sync)
			{
				try
				{
					return ReadCore(index);
				}
				catch (Exception ex)
				{
					log.Error(ex);
					return null;
				}
			}
		}

		private ModemSmsMessage ReadCore(int index)
		{
			string result, smsCenter, smsType, telNumber, timeStamp, discharge;
			string smsText, tpPid, tpDcs, tpVp, tpSt, sReference, allPart, partNo;

			bool ok = NativeModem.R_SMS4(
				out result, true, index,
				out smsCenter, out smsType, out telNumber, out timeStamp, out discharge,
				out smsText, out tpPid, out tpDcs, out tpVp, out tpSt, out sReference,
				out allPart, out partNo);

			if (!ok)
				return null;

			return new ModemSmsMessage
			{
				Index		= index,
				SmsCenter	= smsCenter,
				SmsType		= smsType,
				TelNumber	= telNumber,
				TimeStamp	= timeStamp,
				Discharge	= discharge,
				SmsText		= smsText,
				TPPid		= tpPid,
				TPDcs		= tpDcs,
				TPVp		= tpVp,
				TPSt		= tpSt,
				SReference	= sReference,
				AllPart		= ToInt(allPart),
				PartNo		= ToInt(partNo)
			};
		}

		/// <summary>
		/// خواندن تمام پیامک‌های موجود در حافظه‌ی مودم/سیم‌کارت.
		/// </summary>
		public List<ModemSmsMessage> ReadAll(int maxCount)
		{
			lock (_sync)
			{
				var list = new List<ModemSmsMessage>();

				try
				{
					int count = NativeModem.Get_SMS_NO();

					if (count <= 0)
						return list;

					if (maxCount > 0 && count > maxCount)
						count = maxCount;

					for (int i = 1; i <= count; i++)
					{
						var message = ReadCore(i);

						if (message != null && !string.IsNullOrEmpty(message.SmsText))
							list.Add(message);
					}
				}
				catch (Exception ex)
				{
					log.Error(ex);
				}

				return list;
			}
		}

		/// <summary>حذف پیامک از حافظه‌ی مودم/سیم‌کارت.</summary>
		public bool Delete(int index, ModemDeleteType deleteType)
		{
			lock (_sync)
			{
				try
				{
					return NativeModem.SMS_Delete(index, (int)deleteType);
				}
				catch (Exception ex)
				{
					log.Error(ex);
					return false;
				}
			}
		}

		/// <summary>
		/// خواندن رویدادهای انباشته‌شده‌ی مودم (ارسال موفق، خطای ارسال و ...).
		/// </summary>
		public List<ModemEvent> PollEvents()
		{
			var list = new List<ModemEvent>();

			lock (_sync)
			{
				try
				{
					int guard = 0;

					while (guard++ < 100 && NativeModem.Last_Buf_Index() > 0)
					{
						NativeModem.GsmMessageStruct message;
						NativeModem.Get_GSM_Message(out message);

						list.Add(new ModemEvent
						{
							Code		= message.Result,
							Text		= message.MessageText,
							OccurredAt	= DateTime.Now
						});

						NativeModem.Clear_Buf();
					}
				}
				catch (Exception ex)
				{
					log.Error(ex);
				}
			}

			return list;
		}

		/// <summary>مقدار عددی امن از رشته‌ی برگشتی مودم.</summary>
		internal static int ToInt(string value)
		{
			int number;

			return int.TryParse((value ?? string.Empty).Trim(), out number) ? number : 0;
		}

		public void Dispose()
		{
			if (_disposed)
				return;

			_disposed = true;

			try
			{
				lock (_sync)
				{
					NativeModem.Active_New_SMS_Event(false);
				}
			}
			catch (Exception ex)
			{
				log.Error(ex);
			}

			GC.SuppressFinalize(this);
		}
	}
}
