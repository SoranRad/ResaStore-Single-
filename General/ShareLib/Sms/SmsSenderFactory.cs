using ShareLib.RestApi;
using ShareLib.Sms;
using ShareLib.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Interfaces;

namespace ShareLib.Sms
{
	public static class SmsSenderFactory
	{
		public static ISmsSender Current { get; private set; }

		public static void Initialize(ISmsSender sender) { Current = sender; }
		public static void Reset() { Current = null; }
	}

	//public class SendSmsFactory
 //   {
	//    #region Logging
	//    private static readonly log4net.ILog log =
	//	    log4net
	//		    .LogManager
	//		    .GetLogger
	//			    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
	//	#endregion


		
	//	public SendSms()
	//    {
	//	    _setting = Form_Factory._Form_Factory_General.GetSettings() as SettingItems;

	//	    if (_setting.SmsActivation)
	//		    _smsSender = new UsraServiceSmsSender();
	//		else if (_setting.UseModemForSms)
	//			_smsSender = new ModemSmsSender();
				
	//    } 
		
	//	public async Task<bool>					SendSarResidQest		(long PhoneNumber, string Customer, string Count, string AGHSATTITLE, string Date ,string Amount, string CardNumber, string phoneBill)
	//    {
	//	    try
	//	    {
	//		    return await _smsSender.SendSarResidQest
	//		    (
	//			    PhoneNumber, Customer, Count, AGHSATTITLE, 
	//			    Date, Amount, CardNumber,
	//			    phoneBill
	//			);
	//	    }
	//	    catch (Exception ex)
	//	    {
	//			log.Error(ex.Message, ex);
	//		    return false;
	//	    }
	//    }
	//    public async Task<bool>					SendAqsatMande			(long PhoneNumber, string Customer, string Count, string AGHSATTITLE, string Date, string Amount, string CardNumber, string phoneBill)
	//    {
	//	    try
	//	    {
	//			return await _smsSender.SendAqsatMande
	//			(
	//				PhoneNumber, Customer, Count, AGHSATTITLE,
	//				Date, Amount, CardNumber,
	//				phoneBill
	//			);
	//		}
	//	    catch (Exception ex)
	//	    {
	//		    log.Error(ex.Message, ex);
	//		    return false;
	//	    }
	//    }
	//    public async Task<SmsCustomerInfo>		GetAccountInfo			(string username )
	//    {
	//	    return await _smsSender.GetAccountInfo(username);
	//    }
	  
	//    public async Task<bool>					SendRemainAlarm			(long PhoneNumber, string NAME,decimal MONY )
	//    {
	//	    try
	//	    {
	//		    return await _smsSender.SendRemainAlarm(PhoneNumber, NAME, MONY);
	//	    }
	//	    catch (Exception ex)
	//	    {
	//		    log.Error(ex.Message, ex);
	//		    return false;
	//	    }
	//	}
	//    public async Task<bool>					SendFactorAlarm			(long PhoneNumber, string NAME, string SERIAL, decimal PRICE, string DATE,
	//																		string MANDE_HESAB =null, string TARIKH_TASVIEH = null)
	//    {
	//		try
	//		{
	//			return await _smsSender.SendFactorAlarm
	//			(
	//				PhoneNumber, NAME, SERIAL, PRICE, DATE,
	//				MANDE_HESAB , TARIKH_TASVIEH 
	//			);
	//		}
	//	    catch (Exception ex)
	//	    {
	//		    log.Error(ex.Message, ex);
	//		    return false;
	//	    }
	//    }
	//}
}
