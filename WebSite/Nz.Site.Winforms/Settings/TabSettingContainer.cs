using System.Windows.Forms;
using Nz.Anbar.Model.Model;
using Nz.Site.WinForms.Settings;
using NZ.Xazane.Model;
using ShareLib;
using ShareLib.Component;

namespace Nz.Site.Winforms.Settings
{
	public partial class TabSettingContainer : UserControl
	{
		public TabSettingContainer()
		{
			InitializeComponent();
			NzLocation.Refresh_Grid();
			NzBankAccount.Refresh_Grid(null, Enums.NzAccountKind.BankAccount);
			NsSiteSetting.SettingFunction += () => Settings;
		}

		public void LoadSetting(SettingItems settings)
		{
			NsWebSite.Text		= settings.WebSite;
			NsApiKey.Text		= settings.ApiKey;
			NsSecretKey.Text	= settings.SecretKey;

			if(settings.FK_Location.HasValue)
				NzLocation.MS_Set_Select(settings.FK_Location.Value);

			if(settings.KindFrosh.HasValue)
				NzKindSale.SelectedIndex = settings.KindFrosh.Value ;

			if(settings.FK_BankAccount.HasValue)
				NzBankAccount.MS_Set_Select(settings.FK_BankAccount.Value);
		}

		public NsSettingTabPage TabSetting => NsSiteSetting;

		public SettingItems		Settings =>
			new SettingItems()
			{
				 WebSite = NsWebSite.Text,
				 ApiKey = NsApiKey.Text,
				 SecretKey = NsSecretKey.Text,
				 FK_Location = (NzLocation.MS_Get_Selected() as Location)?.ID,
				 FK_BankAccount = (NzBankAccount.MS_Get_Selected() as Accounts)?.ID,
				 KindFrosh = NzKindSale.SelectedIndex>=0 ? (short?)NzKindSale.SelectedIndex : null,

			};
	}
}
