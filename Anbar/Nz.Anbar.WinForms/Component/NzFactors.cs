using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Janus.Windows.GridEX;
using MS_Control.TSDD;
using Nz.Anbar.Model.Model;
using Nz.Anbar.Model.ViewModel;
using ShareLib;

namespace Nz.Anbar.WinForms.Component
{
    public partial class NzFactors : MS_TextBox_ADC
    {
        public NzFactors()
        {
            InitializeComponent();
            MS_List_Control = NzList;
            NzList.SetParent(_DropDown);
        }
        public override void MS_Set_Select(object Item_to_Select)
        {
            _Do_Refresh = false;
            if (Item_to_Select == null)
                this.Text = "";
            else if (Item_to_Select is FactorHeads)
            {
                var item = Item_to_Select as FactorHeads;
                Text =((Enums.NzFactorKind)item.Kind ).NzToString() + " | "+ item.Serial + " | " + item.PersianStr + " | " + item.Customer  ;
            }
            else if (Item_to_Select is long)
            {
                if (_Grid != null)
                {
                    _Grid.MS_Set_Select(Item_to_Select);
                    var item = _Grid.MS_Get_Selected() as FactorHeads;
                    _Selected_Item = item;
                    if (item == null)
                        this.Text = "";
                    else
                        Text = ((Enums.NzFactorKind)item.Kind).NzToString() + item.Serial + " | " + item.PersianStr + " | " + item.Customer ;
                }
            }
            _Do_Refresh = true;
            base.MS_Set_Select(Item_to_Select);
        }
        private void NzList_Selected(On_Item_Selected e)
        {
            _Do_Refresh = false;
            var row = e.Data_Row as GridEXRow;
            if (row != null)
            {
                var item = row.DataRow as FactorHeads;
                Text = ((Enums.NzFactorKind)item.Kind).NzToString() + item.Serial + " | " + item.PersianStr + " | " + item.Customer ;
                _Selected_Item = item;
                SelectAll();
            }
            _Do_Refresh = true;
            base.MS_On_Selected(e);
        }
    }
}
