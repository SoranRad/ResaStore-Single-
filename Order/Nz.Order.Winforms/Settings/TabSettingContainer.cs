using Nz.Order.Winforms.Properties;
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

namespace Nz.Order.Winforms.Settings
{
	public partial class TabSettingContainer : UserControl
	{
		public TabSettingContainer()
		{
			InitializeComponent();
			NsOrderSetting.SettingFunction += () => Settings;
		}

		public void LoadSetting(SettingItems settings)
		{
			NsApikey.Text				= settings.ApiKey;
			NsAutoSyncStock.Checked		= settings.AutoSyncStock;
			NsAutoSyncOrders.Checked	= settings.AutoSyncOrders;
			NsSyncInterval.MS_Decimal	= settings.SyncInterval;
		}

		public NsSettingTabPage TabSetting => NsOrderSetting;

		public Nz.Order.Winforms.Settings.SettingItems Settings =>
			new Nz.Order.Winforms.Settings.SettingItems() 
			{
				ApiKey			= NsApikey.Text,
				AutoSyncStock	= NsAutoSyncStock.Checked,
				AutoSyncOrders	= NsAutoSyncOrders.Checked,
				SyncInterval	= Convert.ToByte(NsSyncInterval.MS_Decimal)
			};
	}
}
