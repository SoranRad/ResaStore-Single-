using System.Windows.Forms;
using Nz.Anbar.WinForms.Component;
using Nz.Bar.WinForms.Settings;
using NZ.Anbar.Model;
using ShareLib.Component;

namespace Nz.Bar.Winforms.Settings
{
	public partial class TabSettingContainer : UserControl
	{
		public TabSettingContainer()
		{
			InitializeComponent();
			NsBarSetting.SettingFunction += () => Settings;
			NzObjectSelection.Refresh_Grid((object)null);
		}

		public void LoadSetting(SettingItems settings)
		{
			if(settings.DefaultKala>0)
				NzObjectSelection.MS_Set_Select(settings.DefaultKala);
			 
		}

		public NsSettingTabPage TabSetting => NsBarSetting;

		public SettingItems		Settings =>
			new SettingItems()
			{
				DefaultKala = (NzObjectSelection.MS_Get_Selected()as NzObject)?.Code??0,
			};
	}
}
