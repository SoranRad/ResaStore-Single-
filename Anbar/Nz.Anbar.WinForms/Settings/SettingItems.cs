using ShareLib.Interfaces;
using ShareLib.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ShareLib;

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
				 MainGroupActivated = true,
				 MiscID = 0,
				 LocationID = 0,
				 IsOffActive = false,
				 IsOffPercent = true,
				 OffAmount = 0,
				 PrintCountInBarcode = 1,
			};
		}

		public SettingItems()
		{
			Name = KeyName;
		}

		public bool		ShowRemaind				{ get; set; }
		public bool		AdvancedSearch			{ get; set; }
		public bool		MainGroupActivated		{ get; set; }
		public long     MiscID					{ get; set; }
		public short    LocationID				{ get; set; }
		public string	FishPrinter				{ get; set; }
		public bool		IsOffActive				{ get; set; }
		public bool		IsOffPercent			{ get; set; }
		public decimal	OffAmount				{ get; set; }
		public Enums.NzKindPrint KindPrint		{ get; set; }
		public short	PrintCountInBarcode		{ get; set; }
	}
}
