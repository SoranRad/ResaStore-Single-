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
			NsBarSetting.SettingFunction += () => Settings;
		}

		public void LoadSetting(SettingItems settings)
		{
			 
		}

		public NsSettingTabPage TabSetting => NsBarSetting;

		public SettingItems		Settings =>
			new SettingItems()
			{
				 
			};
	}
}
