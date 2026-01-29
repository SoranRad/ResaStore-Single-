using NZ.General.WinForms.Setting;
using ShareLib.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.RestApi;
using ShareLib.Sms;

namespace NZ.General.WinForms.Sms
{
    public class SendSms
    {
	    #region Logging
	    private static readonly log4net.ILog log =
		    log4net
			    .LogManager
			    .GetLogger
				    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
	    #endregion

		SettingItems			_setting;
		private static string	TOKEN	= string.Empty;


	    public SendSms()
	    {
		    _setting = Form_Factory._Form_Factory_General.GetSettings() as SettingItems;
	    } 
		/// <summary>
		///  #CUSTOMER# موعد پرداخت #COUNT# قسط عقب افتاده #AGHSATTITLE# شما تاریخ #DATE# به مبلغ #AMOUNT# می باشد.
		/// #COMPANY#
		///
		/// 780599 کد قالب
		/// </summary>
		/// <param name="PhoneNumber"></param>
		/// <param name="Customer"></param>
		/// <param name="Count"></param>
		/// <param name="AGHSATTITLE"></param>
		/// <param name="Date"></param>
		/// <param name="Amount"></param>
		/// <returns></returns>
		public async Task<bool> SendPayamakYekQest(long PhoneNumber, string Customer, string Count, string AGHSATTITLE, string Date ,string Amount)
	    {
		    try
		    {
				if(await GetToken()== false)
					return false;


				var SmsApi = new FastSmsApi(HttpClientFactory.Generate(new TokenDto(){Token = TOKEN}));
				var result = await SmsApi.SendSms(new FastSendSmsDto()
				{
					Mobile		= PhoneNumber,
					Password	= _setting.Password,
					UserName	= _setting.Username,
					TemplateID = 780599,
					TemplateParams = new TemplateParamDto[]
					{
						new TemplateParamDto(){Name = "CUSTOMER",		Value = Customer},
						new TemplateParamDto(){Name = "COUNT",			Value = Count},
						new TemplateParamDto(){Name = "AGHSATTITLE",	Value = AGHSATTITLE},
						new TemplateParamDto(){Name = "DATE",			Value = Date},
						new TemplateParamDto(){Name = "AMOUNT",			Value = Amount},
						new TemplateParamDto(){Name = "COMPANY",		Value = " بیمه ایران نمایندگی محسن قوندر"},
					}
				}, TOKEN);

				if (!result.IsSuccess)
				{
					if (result.Errors != null && result.Errors.Any())
					{
						var error = string.Join("\r\n", result.Errors.SelectMany(x => x.Value));
						log.Error(result.Message,new Exception(error));
					}

					return false;
				}

				return true;
		    }
		    catch (Exception ex)
		    {
				log.Error(ex.Message, ex);
			    return false;
		    }
	    }

	    private async Task<bool> GetToken()
	    {
			if(!string.IsNullOrEmpty(TOKEN))
				return true;


			var SmsApi = new FastSmsApi(HttpClientFactory.Generate());
			var Token = await SmsApi.GetToken(_setting.Username, _setting.Password);
			
			if (Token == null)
				return false;
			
			Token = Token.Trim();
			return true;
	    }

	}
}
