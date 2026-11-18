using Janus.Windows.GridEX;
using MS_Control.TSDD;
using NZ.Xazane.Model;
using NZ.Xazane.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ.Xazane.WinForms.Component
{
	public partial class NsPeopleChequePopup : MS_TextBox_ADC
	{
		public NsPeopleChequePopup()
		{
			InitializeComponent();
			MS_List_Control = NsList;
			NsList.Popup = this;
		}

		public override void MS_Set_Select(object Item_to_Select)
		{
			_Do_Refresh = false;
			if (Item_to_Select == null)
				this.Text = "";
			else if (Item_to_Select is PeopleChequePayment)
			{
				var item = Item_to_Select as PeopleChequePayment;
				Text = item.CustomerTitle + @" - " + item.mablaq.ToString("0,0.##;")+  @" - " + item.Shenase_Sayadi;
			}
			else if (Item_to_Select is int)
			{
				if (_Grid != null)
				{
					_Grid.MS_Set_Select(Item_to_Select);
					var item = _Grid.MS_Get_Selected() as PeopleChequePayment;
					_Selected_Item = item;
					if (item == null)
						this.Text = "";
					else
						Text = item.CustomerTitle + @" - " + item.mablaq.ToString("0,0.##;") + @" - " + item.Shenase_Sayadi;
				}
			}
			_Do_Refresh = true;
			base.MS_Set_Select(Item_to_Select);
		}
		private void NzList_Selected(MS_Control.TSDD.On_Item_Selected e)
		{
			_Do_Refresh = false;
			var row = e.Data_Row as GridEXRow;
			if (row != null)
			{
				var item = row.DataRow as PeopleChequePayment;
				Text = item.CustomerTitle + @" - " + item.mablaq.ToString("0,0.##;") + @" - " + item.Shenase_Sayadi;
				_Selected_Item = item;
				SelectAll();
			}
			_Do_Refresh = true;
			base.MS_On_Selected(e);
		}

	}
}
