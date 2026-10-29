using ShareLib.Sms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareLib.Interfaces
{
	public interface ISmsSender
	{
		Task<bool> SendSarResidQest
		(
			long PhoneNumber, string Customer, string Count,
			string AGHSATTITLE, string Date, string Amount,
			string CardNumber, string phoneBill
		);
		Task<bool> SendAqsatMande
		(
			long PhoneNumber, string Customer, string Count,
			string AGHSATTITLE, string Date, string Amount,
			string CardNumber, string phoneBill
		);
		Task<bool> SendFactorAlarm
		(
			long PhoneNumber, string NAME, string SERIAL,
			decimal PRICE, string DATE, string MANDE_HESAB = null,
			string TARIKH_TASVIEH = null
		);

		Task<SmsCustomerInfo>	GetAccountInfo			(string username);
		Task<bool>				SendRemainAlarm			(long PhoneNumber, string NAME, decimal MONY);
		
	}
}
