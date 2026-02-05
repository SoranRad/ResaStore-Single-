using ShareLib.Interfaces;
using ShareLib.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Nz.Aqsat.WinForms.Settings
{
	public class SettingItems : ISettingItems
	{
		public static readonly string KeyName = "Aqsat";

		public static SettingItems GetDefault()
		{
			return new SettingItems()
			{
				  
			};
		}

		public SettingItems()
		{
			Name = KeyName;
		}

		public string		CardNumber		{ get; set; }
		public string		PhoneNumber		{ get; set; }

	}
}
