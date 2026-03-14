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
using Janus.Windows.EditControls;
using ShareLib;

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
			var printers = System
				.Drawing
				.Printing
				.PrinterSettings
				.InstalledPrinters
				.OfType<string>()
				.Select(x=>new UIComboBoxItem(x,x))
				.ToArray();
			NsPrinters.Items.AddRange(printers);
		}

		public void LoadSetting(SettingItems settings)
		{
			NsAdvancedSearch.Checked	= settings.AdvancedSearch;
			NsMainGroup.Checked			= settings.MainGroupActivated;
			NsPrintRemaind.Checked		= settings.ShowRemaind;

			if(settings.MiscID>0)
				NzCustomer.MS_Set_Select(settings.MiscID);
			if(settings.LocationID>0)
				NzLocation.SetLocation(settings.LocationID);

			if (!string.IsNullOrWhiteSpace(settings.FishPrinter))
				NsPrinters.SelectedValue = settings.FishPrinter;

			NsIsOffActive.Checked		= settings.IsOffActive;
			NsIsOffPercent.Checked		= settings.IsOffPercent;
			NsOffAmount.MS_Decimal		= settings.OffAmount;
			NsPrintCount.MS_Decimal		= settings.PrintCountInBarcode;
			NsAutomaticSave.Checked		= settings.AutoSave;
			NzKindPrint.SelectedIndex	= (byte)settings.KindPrint;
		}

		public NsSettingTabPage TabSetting => NsStorageSetting;

		public SettingItems		Settings =>
			new SettingItems()
			{
				AdvancedSearch			= NsAdvancedSearch.Checked,
				MainGroupActivated		= NsMainGroup.Checked,
				ShowRemaind				= NsPrintRemaind.Checked,
				LocationID				= (NzLocation.SelectedItem?.DataRow as Location)?.ID??0,
				MiscID					= (NzCustomer.MS_Get_Selected() as People)?.ID??0,
				FishPrinter				= NsPrinters.Text,
				IsOffActive				= NsIsOffActive.Checked,
				IsOffPercent			= NsIsOffPercent.Checked,
				OffAmount				= NsOffAmount.MS_Decimal,
				PrintCountInBarcode		= (short)NsPrintCount.MS_Decimal,
				AutoSave				= NsAutomaticSave.Checked,
				KindPrint				= ((Enums.NzKindPrint)NzKindPrint.SelectedIndex)
			};

        private void NsIsOffActive_CheckedChanged(object sender, EventArgs e)
        {
	        NsOffAmount.Enabled = NsIsOffPercent.Enabled = NsIsOffAmount.Enabled = NsIsOffActive.Checked;
        }
    }
}
