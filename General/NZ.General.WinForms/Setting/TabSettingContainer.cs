using ShareLib.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control;
using MS_Control.DataBase.Con_Str;
using ShareLib.RestApi;
using ShareLib.Utils;
using ShareLib.Sms;
using SmsBan.UI;

namespace NZ.General.WinForms.Setting
{
	public partial class TabSettingContainer : UserControl
	{
		private string ConStrDetail = ";Persist Security Info = True;MultipleActiveResultSets=true;App=NsResaaStore;";

		public TabSettingContainer()
		{
			InitializeComponent();
			NsGeneralSetting.SettingFunction += () => Settings;
			NsSmsTabPage.SettingFunction += () => null;
		}

		public void LoadSetting(SettingItems settings)
		{
			NsLown.Checked				= settings.LownActive;
			NsConStr.Text				= settings.ConStr;
			NsPayments.Checked			= settings.PaymentsActive;
			NsSms.Checked				= settings.SmsActive;
			NsStorage.Checked			= settings.StorageActive;
			NsAlarm.Checked				= settings.ShowAlarm;
			NsLown.Checked				= settings.LownActive;
			NsBackup.Checked			= settings.ShowBackupOnExit;
			NsMultipleDatabase.Checked	= settings.AllowMultipleDatabase;
			NsSmsActivation.Checked		= settings.SmsActivation;
			if (NsSmsActivation.Checked)
			{
				NsUsername.Text = settings.Username;
				NsPassword.Text = settings.Password;
			}

			if (settings.UseModemForSms)
			{
				NsUseModem.Checked = settings.UseModemForSms;
				NsMaxSmsPerDay.MS_Decimal = settings.MaxSmsPerDay;
				NsMaxSmsPerMinute.MS_Decimal = settings.MaxSmsPerMinute;
				NsCharacterInPart.MS_Decimal = settings.CharacterPerPart;
				NsReadSmsPeriod.MS_Decimal = settings.PeriodReadSmsInMinute;
				NsConnectedModem.Checked = settings.ModemConnected;
				NsCountryCode.MS_Decimal = settings.CountryCode;
			}
		}

		public NsSettingTabPage[] TabSetting => new NsSettingTabPage[]{ NsGeneralSetting,NsSmsTabPage};

		public SettingItems		Settings =>
			new SettingItems()
			{ 
				 ConStr					= NsConStr.Text,
				 PaymentsActive			= NsPayments.Checked,
				 SmsActive				= NsSms.Checked,
				 StorageActive			= NsStorage.Checked,
				 LownActive				= NsLown.Checked,
				 ShowAlarm				= NsAlarm.Checked,
				 ShowBackupOnExit		= NsBackup.Checked,
				 AllowMultipleDatabase	= NsMultipleDatabase.Checked,
				 SmsActivation			= NsSmsActivation.Checked,
				 Username				= NsSmsActivation.Checked? NsUsername.Text.Trim() : string.Empty,
				 Password				= NsSmsActivation.Checked? NsPassword.Text.Trim() : string.Empty,
				 UseModemForSms			= NsUseModem.Checked,
				 ModemConnected			= NsUseModem.Checked ? NsConnectedModem.Checked : false,
				 ModemDeviceNo			= NsUseModem.Checked ? (byte)NsDeviceNo.MS_Decimal :(byte)0,
				 CountryCode			= NsUseModem.Checked ? (short)NsCountryCode.MS_Decimal : (short)0,
				 CharacterPerPart		= NsUseModem.Checked ? (byte)NsCharacterInPart.MS_Decimal: (byte)69,
				 MaxSmsPerDay			= NsUseModem.Checked ? (short)NsMaxSmsPerDay.MS_Decimal: (short)69,
				 MaxSmsPerMinute		= NsUseModem.Checked ? (short)NsMaxSmsPerMinute.MS_Decimal : (short)69,
				 PeriodReadSmsInMinute	= NsUseModem.Checked ? (byte)NsMaxSmsPerDay.MS_Decimal : (byte)5,
				 
			};

		private bool IsOK()
		{
			if (string.IsNullOrWhiteSpace(NsUsername.Text))
			{
				NsUsername.Focus();
				mS_Notify1.Show(NsUsername);
				return false;
			}

			if (string.IsNullOrWhiteSpace(NsPassword.Text))
			{
				NsPassword.Focus();
				mS_Notify1.Show(NsPassword);
				return false;
			}
			return true;
		}

		private void NzTitle_ButtonClick(object sender, EventArgs e)
		{
			var Frm = new Form_Con_Str_New();
			if (Frm.ShowDialog() != DialogResult.OK)
				return;

			NsConStr.Text = Frm.MS_Con_str + ConStrDetail;
			NsMultipleDatabase.Checked = Frm.MultipleDatabase;

		}

        private async void NsOK_Click(object sender, EventArgs e)
        {

			if(!IsOK())
				return;

			NsOK.SafeSetProperty(nameof(NsOK.Enabled),false);
			NsLoading.SafeSetProperty(nameof(NsLoading.Visible),true);

			var SmsApi = new FastSmsApi(HttpClientFactory.Generate());

			var Token = await SmsApi.GetToken(NsUsername.Text.Trim(), NsPassword.Text.Trim());

			MS_Message.Show(string.IsNullOrEmpty(Token)
				? "نام کاربری یا کلمه عبور اشتباه است"
				: "نام کاربری یا کلمه عبور درست است");

			NsLoading.SafeSetProperty(nameof(NsLoading.Visible), false);
			NsOK.SafeSetProperty(nameof(NsOK.Enabled), true);

		}

        private void NsSmsActivation_CheckedChanged(object sender, EventArgs e)
        {
			NsGroupBoxSmsInfo.Enabled = NsSmsActivation.Checked;
		}

        private async void NzGetInfo_Click(object sender, EventArgs e)
        {
	        if (!IsOK())
		        return;

	        NzGetInfo.SafeSetProperty(nameof(NzGetInfo.Enabled), false);
	        nsLoading2.SafeSetProperty(nameof(nsLoading2.Visible), true);

	        var SmsApi = new FastSmsApi(HttpClientFactory.Generate());

	        var info = await SmsApi.GetAccountInfo(NsUsername.Text.Trim());

			if(info == null)
				MS_Message.Show("نام کاربری یا کلمه عبور اشتباه است");
			else
			{

				NsSmsCount.SafeSetProperty(nameof(NsSmsCount.MS_Decimal),info.Data.SmsCount); 
				NsSmsAmount.SafeSetProperty(nameof(NsSmsAmount.MS_Decimal),info.Data.ChargeAmount);
				NsExpiration.SafeSetProperty(nameof(NsExpiration.Text),info.Data.ExpiredDate.ToPersianDate()); 
			}

			nsLoading2.SafeSetProperty(nameof(nsLoading2.Visible), false);
	        NzGetInfo.SafeSetProperty(nameof(NzGetInfo.Enabled), true);

		}

		private void mS_CheckBox1_CheckedChanged(object sender, EventArgs e)
		{
			uiGroupBox2.Enabled = NsUseModem.Checked;
		}

		private void NsModemConfig_Click(object sender, EventArgs e)
		{
			new FormConfigModem().ShowDialog(this.ParentForm);
		}
	}
}
