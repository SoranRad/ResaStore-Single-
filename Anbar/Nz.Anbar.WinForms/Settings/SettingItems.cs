using ShareLib.Interfaces;
using ShareLib.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Nz.Anbar.WinForms.Settings
{
	public class SettingItems : ISettingItems
	{
		public static readonly string KeyName = "Storage";

		public static SettingItems GetDefault()
		{
			return new SettingItems()
			{
				 ShowRemaind = false,
				 AdvancedSearch = false,
				 MainGroupActivated = true
			};
		}

		public SettingItems()
		{
			Name = KeyName;
		}

		public bool		ShowRemaind				{ get; set; }
		public bool		AdvancedSearch			{ get; set; }
		public bool		MainGroupActivated		{ get; set; }
	}
}
