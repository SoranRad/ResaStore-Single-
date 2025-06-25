using Nz.Anbar.Model.Model;
using ShareLib.Component;
using ShareLib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nz.Anbar.WinForms.Settings
{
	public partial class TabSettingContainer : UserControl
	{
		public TabSettingContainer()
		{
			InitializeComponent();
			NsStorageSetting.SettingFunction += () => Settings;
			NzCustomer.Refresh_Grid(null,2);
			NzLocation.RefreshItems();
		}

		public void LoadSetting(SettingItems settings)
		{
			NsAdvancedSearch.Checked = settings.AdvancedSearch;
			NsMainGroup.Checked = settings.MainGroupActivated;
			NsPrintRemaind.Checked = settings.ShowRemaind;

			if(settings.MiscID>0)
				NzCustomer.MS_Set_Select(settings.MiscID);
			if(settings.LocationID>0)
				NzLocation.SetLocation(settings.LocationID);
		}

		public NsSettingTabPage TabSetting => NsStorageSetting;

		public SettingItems		Settings =>
			new SettingItems()
			{
				AdvancedSearch		= NsAdvancedSearch.Checked,
				MainGroupActivated	= NsMainGroup.Checked,
				ShowRemaind			= NsPrintRemaind.Checked,
				LocationID			= (NzLocation.SelectedItem?.DataRow as Location)?.ID??0,
				MiscID				= (NzCustomer.MS_Get_Selected() as People)?.ID??0,
			};
	}
}
