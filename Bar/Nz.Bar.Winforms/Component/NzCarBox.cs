using MS_Control.TSDD;
using System.ComponentModel;
using Janus.Windows.GridEX;
using Nz.Bar.Model.Models;
using Nz.Bar.Model.Report;
using ShareLib.Models;

namespace Nz.Bar.Winforms.Component
{
	public partial class NzCarBox : MS_TextBox_ADC
	{
		public NzCarBox()
		{
			InitializeComponent();
			
			MS_List_Control = NsGrid;
			NsGrid.SetParent(_DropDown);
		}

		public override void    MS_Set_Select       (object Item_to_Select)
		{
			_Do_Refresh = false;
			if (Item_to_Select == null)
				this.Text = "";
			else if (Item_to_Select is Car)
			{
				var item = Item_to_Select as Car;
				Text =  item.CarType +" " +item.Plak;
			}
			else if (Item_to_Select is short)
			{
				if (_Grid != null)
				{
					_Grid.MS_Set_Select(Item_to_Select);
					var item = _Grid.MS_Get_Selected() as CarList;
					_Selected_Item = item;
					if (item == null)
						this.Text = "";
					else
						Text = item.PeopleTitle.Trim() +" " + item.CarType +" " +item.Plak;
				}
			}
			_Do_Refresh = true;
			base.MS_Set_Select(Item_to_Select);
		}
		private void            NzList_Selected     (On_Item_Selected e)
		{
			_Do_Refresh = false;
			if (e.Data_Row is GridEXRow row)
			{
				var item = row.DataRow as People;
				Text = item.title.Trim();
				_Selected_Item = item;
				SelectAll();
			}
			_Do_Refresh = true;
			base.MS_On_Selected(e);
		}

		 
	}
}
