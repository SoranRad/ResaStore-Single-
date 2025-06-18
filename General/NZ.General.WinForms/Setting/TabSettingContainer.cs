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

namespace NZ.General.WinForms.Setting
{
	public partial class TabSettingContainer : UserControl
	{
		public TabSettingContainer()
		{
			InitializeComponent();
			NsGeneralSetting.SettingFunction += () => Settings;
		}

		public void LoadSetting(SettingItems settings)
		{
			NsLown.Checked = settings.LownActive;
			NsConStr.Text = settings.ConStr;
			NsPayments.Checked = settings.PaymentsActive;
			NsSms.Checked = settings.SmsActive;
			NsStorage.Checked = settings.StorageActive;
		}

		public NsSettingTabPage TabSetting => NsGeneralSetting;

		public SettingItems		Settings =>
			new SettingItems()
			{
				 AqsatActive = NsLown.Checked,
				 ConStr = NsConStr.Text,
				 PaymentsActive = NsPayments.Checked,
				 SmsActive = NsSms.Checked,
				 StorageActive = NsStorage.Checked
			};

		private void NzTitle_ButtonClick(object sender, EventArgs e)
		{

		}
	}
}
