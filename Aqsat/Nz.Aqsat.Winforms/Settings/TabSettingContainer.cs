using System.Windows.Forms;
using Nz.Aqsat.WinForms.Settings;
using ShareLib.Component;

namespace Nz.Asat.Winforms.Settings
{
	public partial class TabSettingContainer : UserControl
	{
		public TabSettingContainer()
		{
			InitializeComponent();
			NsBarSetting.SettingFunction += () => Settings;
		}

		public void LoadSetting(SettingItems settings)
		{
			 NsPhoneNumber.Text = settings.PhoneNumber;
			 NsCardNumber.Text = settings.CardNumber;
		}

		public NsSettingTabPage TabSetting => NsBarSetting;

		public SettingItems		Settings =>
			new SettingItems()
			{
				 CardNumber		= NsCardNumber.Text,
				 PhoneNumber	= NsPhoneNumber.Text
			};
	}
}
