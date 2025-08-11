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
			 
		}

		public NsSettingTabPage TabSetting => NsBarSetting;

		public SettingItems		Settings =>
			new SettingItems()
			{
				 
			};
	}
}
