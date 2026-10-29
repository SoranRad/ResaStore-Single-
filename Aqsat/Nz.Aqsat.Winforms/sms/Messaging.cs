using Janus.Windows.GridEX;
using MS_Control;
using Nz.Aqsat.WinForms.Settings;
using NZ.General.WinForms.Sms;
using ShareLib.Sms;
using ShareLib.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Nz.Aqsat.Winforms.sms
{
    public class Messaging
    {
	    private static SettingItems _setting;
	    public Messaging()
	    {
			if(_setting == null)
				_setting =Form_Factory._Form_Factory_Aqsat.GetSettings() as SettingItems;
	    }

	    public async Task  SendSarResidQest(GridEXCell Cell ,long PhoneNumber, string Customer, string Count, string AGHSATTITLE, string Date, string Amount)
	    {
			Cell.Image	= MS_Resource.GlobalResources.refresh;
			Count		= Converter.ConvertToPersian(Convert.ToInt32(Count));

			 
			var r = await SmsSenderFactory.Current.SendSarResidQest(

				PhoneNumber,
				Customer,
				Count,
				AGHSATTITLE,
				Date,
				Amount,
				_setting.CardNumber,
				_setting.PhoneNumber
			);


			Cell.Image = r? MS_Resource.GlobalResources._ms_Save : MS_Resource.GlobalResources._ms_Laqv_Save;

		    new Form_Notify("تـوجـه",
				    r
					    ? "پیامک با موفقیت ارسال شد."
					    : "پیامک ارسال نشد",
				    r ? Form_Notify.FarsiMessageBoxIcon.چـک_باکس
					    : Form_Notify.FarsiMessageBoxIcon.خطا
			    )
			    .Popup(Form_Notify.Direction_Show.Down_To_Up, 1500);

	    }

	    public async Task SendAqsatMande(GridEXCell Cell, long PhoneNumber, string Customer, string Count, string AGHSATTITLE, string Date, string Amount)

	    { 
		    Cell.Image = MS_Resource.GlobalResources.refresh;
			 
			var r = await SmsSenderFactory.Current.SendAqsatMande(

			 PhoneNumber,
			 Customer,
			 Count,
			 AGHSATTITLE,
			 Date,
			 Amount,
			 _setting.CardNumber,
			 _setting.PhoneNumber
			);

			Cell.Image = r ? MS_Resource.GlobalResources._ms_Save : MS_Resource.GlobalResources._ms_Laqv_Save;

		    new Form_Notify("تـوجـه",
				    r
					    ? "پیامک با موفقیت ارسال شد."
					    : "پیامک ارسال نشد",
				    r ? Form_Notify.FarsiMessageBoxIcon.چـک_باکس
					    : Form_Notify.FarsiMessageBoxIcon.خطا
			    )
			    .Popup(Form_Notify.Direction_Show.Down_To_Up, 1500);

	    }

	}
}
