using MS_Control;
using NZ.General.Business;
using NZ.General.WinForms.Setting;
using ShareLib;
using ShareLib.Interfaces;
using ShareLib.Models;
using ShareLib.Sms;
using ShareLib.Utils;
using SmsBan.Core;
using SmsBan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Stimulsoft.Report.StiOptions;

namespace NZ.General.WinForms.Sms
{
	public class ModemSmsSender : ISmsSender, IDisposable
	{
		#region Logging
		private static readonly log4net.ILog log =
			log4net
				.LogManager
				.GetLogger
					(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		#endregion
		#region Fields
		SettingItems				_setting; 
		private Manager				_Manager;
		private List<SmsTemplate>	_templates;

		#endregion

		#region statics
		private static SmsBanService _service;      // private، نه public
		private static SmsBanOptions _options;

		/// <summary>نمونهی مشترک سرویس مودم برای فرمهای مدیریتی.</summary>
		public static SmsBanService Service { get { return _service; } }
		public static SmsBanOptions Options { get { return _options; } }
		public static bool			IsReady { get { return _service != null; } }

		#endregion



		public ModemSmsSender()
		{
			_setting		= Form_Factory._Form_Factory_General.GetSettings() as SettingItems;
			_Manager		= new Manager();
			_templates		= new List<SmsTemplate>();
			_templates		= _Manager.GetList<SmsTemplate>()?.ToList();

			_options = new SmsBanOptions
			{
				ConnectionString		= _setting.ConStr,
				
				MaxSmsPerDay			= _setting.MaxSmsPerDay,
				MaxSmsPerMinute			= _setting.MaxSmsPerMinute,
				CharsPerPage			= _setting.CharacterPerPart,

				// شماره مقصد
				CountryCode				= _setting.CountryCode.ToString(),     // نتیجه: 98 + 9123456789 = 989123456789

				// مودم
				DeviceNumber			= _setting.ModemDeviceNo,        // شماره دستگاه برای SMS_Select_Device (۰ تا ۱۲۷)
				IsModemHost				= _setting.ModemConnected,     // فقط روی کامپیوتری که مودم وصل است

				// پارامترهای ارسال
				SmsValidity				= (int)SmsValidityPeriod.Maximum,   // حداکثر
				PartSendIntervalMs		= 1000,// تاخیر بین بخشهای پیامک چندصفحهای
				ModemRetryCount			= 2,        // تلاش مجدد مودم در صورت بروز مشکل
				RequestDeliveryReport	= true,

				// دریافت
				ReadIntervalMinutes		= _setting.PeriodReadSmsInMinute,
				DeleteAfterRead			= false
			};

			_service = new SmsBanService(_options);			// ← همینجا به فیلد استاتیک
			if (!_service.EnsureDatabase())
				log.Error(_service.InitializationError);	// ← throw نکنید، فقط لاگ

			_service.Start();								// روی میزبان مودم: نخ ارسال + تایمر دریافت
		}

		public async Task<bool> SendSarResidQest
		(
			long PhoneNumber, string Customer, string Count, string AGHSATTITLE,
			string Date, string Amount, string CardNumber, string phoneBill
		)
		{
			var template = _templates.FirstOrDefault(x => x.Kind == (byte)Enums.NsSmsTemplateKind.AqsatSarresid);
			if (template == null)
				return false;

			var message		= template.Message.Replace("#" +nameof(PhoneNumber)+"#",	PhoneNumber.ToString());
			message			= message.Replace("#" +nameof(Customer) +"#",		Customer);
			message			= message.Replace("#" +nameof(Count) +"#",			Count);
			message			= message.Replace("#" +nameof(AGHSATTITLE) +"#",	AGHSATTITLE);
			message			= message.Replace("#" +nameof(Date) +"#",			Date);
			message			= message.Replace("#" +nameof(Amount) +"#",		Amount);
			message			= message.Replace("#" +nameof(CardNumber) +"#",	CardNumber);
			message			= message.Replace("#" +nameof(phoneBill) +"#",		phoneBill);

			var i = _service.Enqueue(PhoneNumber.ToString(), message, SmsPriority.Normal);
			return i > 0;
		}

		public async Task<bool> SendAqsatMande
		(
			long PhoneNumber, string Customer, string Count,
			string AGHSATTITLE, string Date, string Amount,
			string CardNumber, string phoneBill
		)
		{
			var template = _templates.FirstOrDefault(x => x.Kind == (byte)Enums.NsSmsTemplateKind.AqsatMande);
			if (template == null)
				return false;

			var message		= template.Message.Replace("#" + nameof(PhoneNumber) + "#",		PhoneNumber.ToString());
			message			= message.Replace("#" + nameof(Customer) + "#",		Customer);
			message			= message.Replace("#" + nameof(Count) + "#",			Count);
			message			= message.Replace("#" + nameof(AGHSATTITLE) + "#",		AGHSATTITLE);
			message			= message.Replace("#" + nameof(Date) + "#",			Date);
			message			= message.Replace("#" + nameof(Amount) + "#",			Amount);
			message			= message.Replace("#" + nameof(CardNumber) + "#",		CardNumber);
			message			= message.Replace("#" + nameof(phoneBill) + "#",		phoneBill);

			var i = _service.Enqueue(PhoneNumber.ToString(), message, SmsPriority.Normal);
			return i > 0;
		}

		public async Task<bool> SendFactorAlarm
		(
			long PhoneNumber, string NAME, string SERIAL,
			decimal PRICE, string DATE, string MANDE_HESAB = null,
			string TARIKH_TASVIEH = null
		)
		{
			var template = _templates.FirstOrDefault(x => x.Kind == (byte)Enums.NsSmsTemplateKind.Frosh);
			if (template == null)
				return false;

			var message		= template.Message.Replace("#" + nameof(PhoneNumber) + "#",		PhoneNumber.ToString());
			message			= message.Replace("#" + nameof(NAME) + "#",				NAME);
			message			= message.Replace("#" + nameof(SERIAL) + "#",				SERIAL);
			message			= message.Replace("#" + nameof(PRICE) + "#",				PRICE.ToString("N"));
			message			= message.Replace("#" + nameof(DATE) + "#",				DATE);
			message			= message.Replace("#" + nameof(MANDE_HESAB) + "#",			MANDE_HESAB);
			message			= message.Replace("#" + nameof(TARIKH_TASVIEH) + "#",		TARIKH_TASVIEH); 

			var i = _service.Enqueue(PhoneNumber.ToString(), message, SmsPriority.Normal);
			return i > 0;
		}

		public async Task<bool> SendRemainAlarm(long PhoneNumber, string NAME, decimal MONY)
		{
			var template = _templates.FirstOrDefault(x => x.Kind == (byte)Enums.NsSmsTemplateKind.MandeShaxs);
			if (template == null)
				return false;

			var message = template.Message.Replace("#" + nameof(PhoneNumber) + "#", PhoneNumber.ToString());
			message = message.Replace("#" + nameof(NAME) + "#", NAME);
			message = message.Replace("#" + nameof(MONY) + "#", MONY.ToString("N"));

			var i = _service.Enqueue(PhoneNumber.ToString(), message, SmsPriority.Normal);
			return i > 0;
		}

		public async Task<SmsCustomerInfo> GetAccountInfo(string username)
		{
			return null;
		}

		public static void Stop() { _service?.Stop(); _service?.Dispose(); _service = null; }

		public void Dispose() => Stop();
	}
}
