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
				  
			};
		}

		public SettingItems()
		{
			Name = KeyName;
		}

		public string	WebSite				{ get; set; }
		public string	ApiKey				{ get; set; }
		public string	SecretKey			{ get; set; }

		public short?	FK_Location			{ get; set; }
		public short?	KindFrosh			{ get; set; }
		public int?		FK_BankAccount		{ get; set; }


	}
}
