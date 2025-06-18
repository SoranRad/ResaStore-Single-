using ShareLib.Interfaces;
using System.Xml.Serialization;
using ShareLib.Utils;

namespace NZ.General.WinForms.Setting
{
	public class SettingItems : ISettingItems
	{
		public static readonly string KeyName = "General";

		public static SettingItems GetDefault()
		{
			return new SettingItems()
			{
				StorageActive = true,
				PaymentsActive = true,
				AllowMultipleDatabase = false,
				AqsatActive = false,
				SmsActive = false,
				ConStr =  ConnectionManager.ConStr
			};
		}

		public SettingItems()
		{
			Name = KeyName;
		}
		public string	ConStr					{ get; set; }
		public bool		StorageActive			{ get; set; }
		public bool		PaymentsActive			{ get; set; }
		public bool		SmsActive				{ get; set; }
		public bool		LownActive				{ get; set; }
		public bool		AqsatActive				{ get; set; }
		public bool     AllowMultipleDatabase   { get; set; }

	}
}
