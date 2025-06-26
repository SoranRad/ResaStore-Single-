using ShareLib.Interfaces;
using ShareLib.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ.Xazane.WinForms.Setting
{
	public class SettingItems: ISettingItems
	{
		public static readonly string KeyName = "Xazaneh";

		public static SettingItems GetDefault()
		{
			return new SettingItems()
			{
				IdCache = 0,
				IdPos = 0,
			};
		}


		public SettingItems()
		{
			Name = KeyName;
		}

		public int IdCache { get; set; }
		public int IdPos { get; set; }


	}
}
