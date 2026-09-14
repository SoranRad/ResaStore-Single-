using Janus.Windows.GridEX;
using MS_Control;
using NZ.General.WinForms.Sms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Anbar.WinForms.Sms
{
	internal class Messaging
	{
		public Messaging()
		{

		}

		public async Task SendAlarmFactor(GridEXCell Cell, long PhoneNumber, string NAME, string SERIAL, decimal PRICE, string DATE,
			string MANDE_HESAB = null, string TARIKH_TASVIEH = null)
		{
			var tmp = Cell.Image;
			Cell.Image = MS_Resource.GlobalResources.refresh;


			var sendSms = new SendSms();
			var r = await sendSms.SendFactorAlarm(

				PhoneNumber,
				NAME,
				SERIAL, 
				PRICE, 
				DATE,
				MANDE_HESAB , 
				TARIKH_TASVIEH
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

