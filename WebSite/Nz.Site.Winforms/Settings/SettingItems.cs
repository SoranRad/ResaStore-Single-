using ShareLib.Interfaces;
using ShareLib.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Nz.Site.WinForms.Settings
{
	public class SettingItems : ISettingItems
	{
		public static readonly string KeyName = "Site";

		public static SettingItems GetDefault()
		{
			return new SettingItems()
			{
				 DefaultKala = 0
			};
		}

		public SettingItems()
		{
			Name = KeyName;
		}

		public int DefaultKala { get; set; }
	}
}
