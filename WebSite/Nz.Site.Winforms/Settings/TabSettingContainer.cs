using System.Windows.Forms;
using Nz.Site.WinForms.Settings;
using ShareLib.Component;

namespace Nz.Site.Winforms.Settings
{
	public partial class TabSettingContainer : UserControl
	{
		public TabSettingContainer()
		{
			InitializeComponent();
			NsSiteSetting.SettingFunction += () => Settings;
		}

		public void LoadSetting(SettingItems settings)
		{
			NsWebSite.Text		= settings.WebSite;
			NsApiKey.Text		= settings.ApiKey;
			NsSecretKey.Text	= settings.SecretKey;
		}

		public NsSettingTabPage TabSetting => NsSiteSetting;

		public SettingItems		Settings =>
			new SettingItems()
			{
				 WebSite = NsWebSite.Text,
				 ApiKey = NsApiKey.Text,
				 SecretKey = NsSecretKey.Text
			};
	}
}
