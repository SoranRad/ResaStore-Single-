using Janus.Windows.GridEX;
using MS_Control.TSDD;
using NZ.Anbar.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Anbar.WinForms.Component
{
	public partial class NzStorageComboChcek : MS_TextBox_ADC
	{
		public NzStorageComboChcek()
		{
			InitializeComponent();

			MS_List_Control = this.NzList ;
			NzList.SetParent( _DropDown);
		}

		public object MS_Get_Selected()
		{
			return NzList.MS_Get_Selected();
		}
		public override void    MS_Set_Select       (object             Item_to_Select)
		{
			_Do_Refresh = false;
			_Selected_Item = Item_to_Select;

			if (Item_to_Select == null)
				this.Text = "";
			else if (Item_to_Select is Storage[] storages)
			{
				Text = string.Join(" , ", storages.Select(x => x.Code + " )" + x.Title));
			}
			else if (Item_to_Select is short[] storageIDs)
			{
				NzList.MS_Set_Select(storageIDs);
				var storagesArr = NzList.MS_Get_Selected() as Storage[];
				Text = string.Join(" , ", storagesArr.Select(x => x.Code + " )" + x.Title));
			}

			_Do_Refresh = true;
			base.MS_Set_Select(Item_to_Select);
		}
		private void            NzList_Selected     (On_Item_Selected   e)
		{
			_Do_Refresh = false;
			
			var storagesArr = NzList.MS_Get_Selected() as Storage[];
			Text = string.Join(" , ", storagesArr.Select(x => x.Code + " )" + x.Title));

			_Do_Refresh = true;
			base.MS_On_Selected(e);
		}
		public void				Refresh_Anbar		()
		{
			Set_Control(_Control);
			NzList.Refresh_Grid(); 

		}


	}
}
