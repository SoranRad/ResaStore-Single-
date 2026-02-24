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
		
		public async Task<bool>		SendSarResidQest		(long PhoneNumber, string Customer, string Count, string AGHSATTITLE, string Date ,string Amount, string CardNumber, string phoneBill)
	    {
		    try
		    {
				if(await GetToken() == false)
					return false;


				var SmsApi = new FastSmsApi(HttpClientFactory.Generate(new TokenDto(){Token = TOKEN}));
				var result = await SmsApi.SendSms(new FastSendSmsDto()
				{
					Mobile			= PhoneNumber,
					Password		= _setting.Password,
					UserName		= _setting.Username,
					TemplateID		= 919155,
					TemplateParams	= new TemplateParamDto[]
					{
						new TemplateParamDto(){Name = "CUSTOMER",		Value = Customer.En2Fa()},
						new TemplateParamDto(){Name = "COUNT",			Value = Count},
						new TemplateParamDto(){Name = "AGHSATTITLE",	Value = AGHSATTITLE.En2Fa()},
						new TemplateParamDto(){Name = "DATE",			Value = Date.En2Fa()},
						new TemplateParamDto(){Name = "AMOUNT",			Value = Amount.En2Fa() + " " + SystemConstant.ActiveYear.Money},
						new TemplateParamDto(){Name = "CARDNUMBER",		Value = CardNumber},
						//new TemplateParamDto(){Name = "MOBILENUMBER",	Value = phoneBill},
						new TemplateParamDto(){Name = "COMPANY",		Value = SystemConstant.ActiveCompany.title.En2Fa()},
					}
				}, 
					TOKEN);

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
	    public async Task<bool>		SendAqsatMande			(long PhoneNumber, string Customer, string Count, string AGHSATTITLE, string Date, string Amount, string CardNumber, string phoneBill)
	    {
		    try
		    {
			    if (await GetToken() == false)
				    return false;


			    var SmsApi = new FastSmsApi(HttpClientFactory.Generate(new TokenDto() { Token = TOKEN }));
			    var result = await SmsApi.SendSms(new FastSendSmsDto()
			    {
				    Mobile = PhoneNumber,
				    Password = _setting.Password,
				    UserName = _setting.Username,
				    TemplateID = 780599,
				    TemplateParams = new TemplateParamDto[]
				    {
					    new TemplateParamDto(){Name = "CUSTOMER",       Value = Customer.En2Fa()},
					    new TemplateParamDto(){Name = "COUNT",          Value = Count.En2Fa()},
					    new TemplateParamDto(){Name = "AGHSATTITLE",    Value = AGHSATTITLE.En2Fa()},
					    new TemplateParamDto(){Name = "DATE",           Value = Date.En2Fa()},
					    new TemplateParamDto(){Name = "AMOUNT",         Value = Amount.En2Fa()},
					    new TemplateParamDto(){Name = "CARDNUMBER",     Value = CardNumber},
					    //new TemplateParamDto(){Name = "MOBILENUMBER",   Value = phoneBill},
						new TemplateParamDto(){Name = "COMPANY",        Value = SystemConstant.ActiveCompany.title.En2Fa()},
				    }
			    }, 
				    TOKEN);

			    if (!result.IsSuccess)
			    {
				    if (result.Errors != null && result.Errors.Any())
				    {
					    var error = string.Join("\r\n", result.Errors.SelectMany(x => x.Value));
					    log.Error(result.Message, new Exception(error));
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
	    public async Task<SmsCustomerInfo>	GetAccountInfo	(string username )
	    {
		    var SmsApi = new FastSmsApi(HttpClientFactory.Generate());
		    var result = await SmsApi.GetAccountInfo(username);

		    return result.Result ? result.Data : null;
	    }
	    private async Task<bool>			GetToken		()
	    {
			if(!string.IsNullOrEmpty(TOKEN))
				return true;


			var SmsApi = new FastSmsApi(HttpClientFactory.Generate());
			var Token = await SmsApi.GetToken(_setting.Username, _setting.Password);
			
			if (Token == null)
				return false;

			TOKEN = Token.Trim();
			return true;
	    }

	}
}
