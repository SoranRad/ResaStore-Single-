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
					// این تابع «شماره دستگاه» می‌گیرد (شماره‌گذاری از صفر).
					var deviceNumber = DeviceNumber;

					if (deviceNumber < 0 || deviceNumber >= count)
					{
						log.WarnFormat(
							"شماره دستگاه {0} معتبر نیست (تعداد دستگاه‌های شناسایی‌شده: {1}). " +
							"دستگاه شماره ۰ انتخاب می‌شود.",
							deviceNumber, count);

						deviceNumber = 0;
					}

					NativeModem.SMS_Select_Device((short)deviceNumber);

					SelectedDeviceNumber		= deviceNumber;
					Status.SelectedDeviceNumber	= deviceNumber;

					Status.Ready = NativeModem.GSM_Ready();

					// اگر ماژول خاموش باشد، روشن و کمی صبر می‌کنیم.
					if (!Status.Ready)
					{
						log.Info("ماژول GSM آماده نیست؛ روشن می‌شود.");

						NativeModem.GSM_ON();
						System.Threading.Thread.Sleep(3000);

						Status.Ready = NativeModem.GSM_Ready();
					}

					Status.Connected = NativeModem.GSM_Test_Connect();

					// شناسایی دستگاه باید پس از آماده‌شدن ماژول انجام شود؛
					// در غیر این صورت IMEI و مشخصات دستگاه خالی برمی‌گردند.
					ReadIdentity();

					if (string.IsNullOrEmpty(Status.DeviceInfo))
					{
						System.Threading.Thread.Sleep(500);
						ReadIdentity();
					}

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

		/// <summary>
		/// اطمینان از آماده و متصل بودن مودم.
		///
		/// اگر اتصال برقرار باشد true برمی‌گرداند؛ در غیر این صورت یک بار مودم را
		/// باز و آماده می‌کند (انتخاب دستگاه، تنظیم UCS2 و PDU).
		/// این متد پیش از هر ارسال و هر دور خواندن صدا زده می‌شود تا اگر مودم
		/// جدا و دوباره وصل شده باشد، بدون خطا به کار خود ادامه دهد.
		/// </summary>
		public bool EnsureConnected()
		{
			lock (_sync)
			{
				try
				{
					NativeModem.EnsureAvailable();

					if (NativeModem.SMS_Device_Count() > 0 && NativeModem.GSM_Test_Connect())
					{
						Status.DeviceFound	= true;
						Status.Connected	= true;

						return true;
					}

					log.Warn("اتصال مودم برقرار نیست؛ تلاش برای بازکردن دوباره.");
				}
				catch (Exception ex)
				{
					log.Warn("بررسی اتصال مودم ناموفق بود؛ تلاش برای بازکردن دوباره.", ex);
				}

				// اتصال قطع است → بازکردن دوباره.
				var status = Open();

				return status != null && status.DeviceFound && status.Connected;
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
					// اطمینان از متصل بودن مودم پیش از ارسال.
					// اگر اتصال قطع شده باشد، مودم دوباره باز و آماده می‌شود.
					if (!EnsureConnected())
					{
						result.Success		= false;
						result.NotConnected	= true;
						result.Message		= "مودم متصل نیست.";

						log.WarnFormat("ارسال به {0} انجام نشد؛ مودم متصل نیست.", phoneNumber);

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
		/// وضعیت حافظه‌ی پیامک مودم/سیم‌کارت (ظرفیت، فضای آزاد و تعداد پیامک).
		/// </summary>
		public ModemMemoryInfo GetMemoryInfo()
		{
			var info = new ModemMemoryInfo();

			lock (_sync)
			{
				try
				{
					NativeModem.SmsSpaceStruct space;

					NativeModem.Get_SMS_Space(out space);

					info.FreeSpace	= space.FreeSpace;
					info.TotalSize	= space.TotalSize;
					info.IsValid	= space.Result;
				}
				catch (Exception ex)
				{
					log.Error(ex);
					info.IsValid = false;
				}

				try
				{
					info.MessageCount = NativeModem.Get_SMS_NO();
				}
				catch (Exception ex)
				{
					log.Error(ex);
					info.MessageCount = -1;
				}
			}

			return info;
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
		/// خالی‌کردن کامل حافظه‌ی پیامک مودم/سیم‌کارت.
		/// </summary>
		public bool DeleteAll()
		{
			lock (_sync)
			{
				try
				{
					return NativeModem.SMS_Delete(0, (int)ModemDeleteType.All);
				}
				catch (Exception ex)
				{
					log.Error(ex);
					return false;
				}
			}
		}

		// ==================================================================
		// بافر ارسال گروهی (مطابق نمونه‌ی رسمی شرکت)
		// ==================================================================

		/// <summary>شماره‌ی ردیف جاری بافر ارسال.</summary>
		public int GetBufferIndex()
		{
			lock (_sync)
			{
				try
				{
					return NativeModem.Get_SMS_Buf_Indx();
				}
				catch (Exception ex)
				{
					log.Error(ex);
					return -1;
				}
			}
		}

		/// <summary>تعداد پیامک‌های ارسال‌شده از بافر.</summary>
		public int GetBufferSentCount()
		{
			lock (_sync)
			{
				try
				{
					return NativeModem.Get_SMS_Buf_Sended();
				}
				catch (Exception ex)
				{
					log.Error(ex);
					return -1;
				}
			}
		}

		/// <summary>
		/// وضعیت یک ردیف بافر: آیا ارسال تمام شده و آیا گزارش تحویل آمده است.
		/// </summary>
		public ModemBufferStatus GetBufferStatus(int index)
		{
			var status = new ModemBufferStatus { Index = index };

			lock (_sync)
			{
				try
				{
					bool sendDone = false;

					status.Delivered	= NativeModem.Get_SMS_Buf_Status2(index, ref sendDone);
					status.SendDone		= sendDone;
				}
				catch (Exception ex)
				{
					log.Error(ex);
				}
			}

			return status;
		}

		/// <summary>خالی‌کردن بافر ارسال؛ اگر stop=true ارسال در جریان هم متوقف می‌شود.</summary>
		public void ClearSendBuffer(bool stop)
		{
			lock (_sync)
			{
				try
				{
					NativeModem.SMS_Buf_Clear(stop);
				}
				catch (Exception ex)
				{
					log.Error(ex);
				}
			}
		}

		/// <summary>شروع یا توقف ارسال بافر.</summary>
		public void StartSendBuffer(bool start)
		{
			lock (_sync)
			{
				try
				{
					NativeModem.SMS_Buf_Start(start);
				}
				catch (Exception ex)
				{
					log.Error(ex);
				}
			}
		}

		/// <summary>توقف موقت ارسال بافر.</summary>
		public void PauseSendBuffer()
		{
			lock (_sync)
			{
				try
				{
					NativeModem.SMS_Buf_Pause();
				}
				catch (Exception ex)
				{
					log.Error(ex);
				}
			}
		}

		/// <summary>
		/// تنظیمات بافر ارسال گروهی؛ پیش از افزودن پیامک‌ها صدا زده می‌شود.
		/// </summary>
		/// <param name="changeSimAfter">پس از چند پیامک، سیم‌کارت عوض شود (۰ = هرگز).</param>
		public void ConfigureGroupSending(ModemSendOptions options, int changeSimAfter = 0)
		{
			options = options ?? new ModemSendOptions();

			lock (_sync)
			{
				try
				{
					NativeModem.Group_SMS_Setting(
						options.RequestDeliveryReport,
						options.SmsValidity,
						changeSimAfter,
						options.RetryCount,
						options.PartSendIntervalMs,
						options.SmsCenter ?? string.Empty);
				}
				catch (Exception ex)
				{
					log.Error(ex);
				}
			}
		}

		/// <summary>افزودن یک پیامک به بافر ارسال گروهی.</summary>
		public void AddGroupMessage(string phoneNumber, string text)
		{
			lock (_sync)
			{
				try
				{
					NativeModem.Add_Group_SMS_Buffer(phoneNumber, text);
				}
				catch (Exception ex)
				{
					log.Error(ex);
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

						NativeModem.Clear_Buf();

						// رویداد نامعتبر (بدون کد و بدون متن) نادیده گرفته می‌شود.
						if (message.Result < 0 && string.IsNullOrEmpty(message.MessageText))
							continue;

						list.Add(new ModemEvent
						{
							Code		= message.Result,
							Text		= message.MessageText,
							OccurredAt	= DateTime.Now
						});
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
