using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using MS_Control.TSDD;
using NZ.Anbar.Business;
using Nz.Anbar.Model.ViewModel;
using ShareLib;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.Component
{
    public partial class NzFactorsList : MS_Base_GridPopup
    {
         
        #region Fields
        private ReportManager _Manager;
        private IEnumerable<FactorHeads> _List;
        private Control _DropMenu;
        private Enums.NzFactorKind _Kind;
        #endregion
        public NzFactorsList()
        {
            InitializeComponent();
            ms_grid.RootTable.ColumnHeaders = InheritableBoolean.False;

            ms_null.Visible = false;
            ms_Add.Visible = false;
            ms_refresh.Click += NzRefresh;
        }
        #region Methods
        private void            RefreshControl      ()
        {
            _List = _Manager.GetReport<FactorHeads>(new
            {
                Year = SystemConstant.ActiveYear.Salmali

            },string.Empty);
            ms_grid.DataSource = _List?.ToList();
        }
        public override void    Refresh_Grid        ()
        {
            try
            {
                _Manager    = new ReportManager();
                ms_grid.RootTable.Caption = "لیست فاکتور";
                RefreshControl();
            }
            catch
            {
                // ignored
            }
        }
        public override void    Filter_Grid         (string Str)
        {
            Str = Str.Trim();
            if (string.IsNullOrWhiteSpace(Str))
            {
                ms_grid.DataSource = _List?.ToList();
                return;
            }
            ms_grid.DataSource = _List
                                    .Where(x => 
                                                (!string.IsNullOrEmpty(x.Customer) && x.Customer.Contains(Str) )
                                            ||  x.PersianStr.Contains(Str)
                                            ||  x.Serial.ToString().Contains(Str)
                                            ||  (!string.IsNullOrEmpty(x.sharh) && x.sharh.Contains(Str))

                                    )
                                    .ToList();
        }
        public override void    MS_Set_Select       (object Item_to_Select)
        {
            _Selected_Item = Item_to_Select;

            if (_Selected_Item == null)
            {
                ms_grid.SelectedItems.Clear();
                _Selected_Item = null;
            }
            else if (Item_to_Select is FactorHeads)
            {
                var Tag_Row = Item_to_Select as FactorHeads;
                var row = ms_grid.GetDataRows()
                                            .FirstOrDefault
                                            (x => ((FactorHeads)x.DataRow).ID == Tag_Row.ID);
                if (row != null)
                {
                    ms_grid.MoveTo(row);
                    _Selected_Item = row.DataRow;
                }
                else
                    _Selected_Item = null;
            }
            else if (Item_to_Select is long idRow)
            {
                _Selected_Item = _List.FirstOrDefault(x => x.ID == idRow);
            }
        }
        public void             SetParent           (Control DropDownMenu)
        {
            _DropMenu = DropDownMenu;
        }
        #endregion

        private void NzRefresh(object sender, EventArgs eventArgs)
        { 
            Refresh_Grid(_Kind);
        }
         
    }
}
