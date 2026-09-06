using Janus.Windows.GridEX;
using MS_Control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Utils;

namespace NZ.General.WinForms.Sms
{
	internal class Messaging
	{
		public Messaging()
		{
			
		}

		public async Task SendSarResidQest(GridEXCell Cell, long PhoneNumber, string NAME, decimal MONY)
		{
			var tmp		= Cell.Image;
			Cell.Image	= MS_Resource.GlobalResources.refresh;
		 
			 
			var sendSms = new SendSms();
			var r = await sendSms.SendRemainAlarm(

				PhoneNumber,
				NAME,
				MONY
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
