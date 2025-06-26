using NZ.Xazane.Model;
using ShareLib;
using ShareLib.Component;
using ShareLib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NZ.Xazane.WinForms.Setting
{
	public partial class TabSettingContainer : UserControl
	{
		public TabSettingContainer()
		{
			InitializeComponent();
			NsGeneralSetting.SettingFunction += () => Settings;
			NzCache.Refresh_Grid        (Enums.NzAccountKind.Cache);
			NzPos.Refresh_Grid          (Enums.NzAccountKind.BankAccount);
		}

		public void LoadSetting(SettingItems settings)
		{
			 
			if(settings.IdCache>0)
				NzCache.MS_Set_Select(settings.IdCache);
			if(settings.IdPos>0)
				NzPos.MS_Set_Select(settings.IdPos);
		}

		public NsSettingTabPage TabSetting => NsGeneralSetting;

		public SettingItems		Settings =>
			new SettingItems()
			{ 
				IdPos				= (NzPos.MS_Get_Selected() as Accounts)?.ID??0,
				IdCache				= (NzCache.MS_Get_Selected() as Accounts)?.ID??0,
			};
	}
}
