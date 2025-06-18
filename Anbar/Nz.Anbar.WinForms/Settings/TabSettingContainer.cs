using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShareLib.Component;

namespace Nz.Anbar.WinForms.Settings
{
	public partial class TabSettingContainer : UserControl
	{
		public TabSettingContainer()
		{
			InitializeComponent();
			NsStorageSetting.SettingFunction += () => Settings;
		}

		public void LoadSetting(SettingItems settings)
		{
			NsAdvancedSearch.Checked = settings.AdvancedSearch;
			NsMainGroup.Checked = settings.MainGroupActivated;
			NsPrintRemaind.Checked = settings.ShowRemaind;
		}

		public NsSettingTabPage TabSetting => NsStorageSetting;

		public SettingItems		Settings =>
			new SettingItems()
			{
				AdvancedSearch		= NsAdvancedSearch.Checked,
				MainGroupActivated	= NsMainGroup.Checked,
				ShowRemaind			= NsPrintRemaind.Checked
			};
	}
}
