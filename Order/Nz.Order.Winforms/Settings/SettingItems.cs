using ShareLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Nz.Order.Winforms.Settings
{
	public class SettingItems : ISettingItems
	{
		public static readonly string KeyName = "Order";

		public static SettingItems GetDefault()
		{
			return new SettingItems()
			{
				AutoSyncStock = false,
				AutoSyncOrders = false
			};
		}

		public SettingItems()
		{
			Name = KeyName;
		}

		public string	ApiKey				{ get; set; }
		public bool		AutoSyncStock		{ get; set; }
		public byte		SyncInterval		{ get; set; }
		public bool		AutoSyncOrders		{ get; set; }

	}
}
