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
				StorageActive			= true,
				PaymentsActive			= true,
				AllowMultipleDatabase	= false, 
				SmsActive				= false,
				ConStr					=  ConnectionManager.ConStr,
				LownActive				= false,
				ShowAlarm				= true,
				ShowBackupOnExit		= true,
				SmsActivation			= false,
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
		public bool     AllowMultipleDatabase   { get; set; }
		public bool		ShowAlarm				{ get; set; }
		public bool		ShowBackupOnExit		{ get; set; }
		public bool		SmsActivation			{ get; set; }
		public string	Username				{ get; set; }
		public string	Password				{ get; set; }
	}
}
