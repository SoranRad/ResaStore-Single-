using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control.TSDD;
using NZ.General.Business;
using Janus.Windows.GridEX;
using ShareLib.Utils;
using NZ.General.WinForms.Base;
using ShareLib.Models;

namespace NZ.General.WinForms.Component
{
    public partial class NzListState : MS_Base_GridPopup
    {
         #region Fields
        private Manager                  _Manager;
        private IEnumerable<State>       _ListAccounts;
        private Control                  _DropMenu;
        #endregion

        public NzListState()
        {
            InitializeComponent();
             ms_grid.RootTable.ColumnHeaders    = InheritableBoolean.False;
            ms_null.Visible                     = false;
            ms_Add.Click                        += NzAdd;
            ms_refresh.Click                    += NzRefresh;
        }

        #region Methods
        private void            RefreshControl  ()
        {
            _ListAccounts       = _Manager
                                    .GetList<State>();
            ms_grid.DataSource  = _ListAccounts?.ToList();
        }
        public  override void   Refresh_Grid    ()
        {
            try
            {
                _Manager        =  new Manager();
                RefreshControl      ();
            }
            catch (Exception)
            {
                
            }
        }
        public  override void   Filter_Grid     (string Str)
        {
            Str = Str.Trim();
            if (string.IsNullOrWhiteSpace(Str))
            {
                ms_grid.DataSource = _ListAccounts?.ToList();
                return;
            }
            ms_grid.DataSource = _ListAccounts
                                        .Where(x => x.title.Contains(Str))
                                        .ToList();
        }
        public  override void   MS_Set_Select   (object Item_to_Select)
        {
            _Selected_Item = Item_to_Select;

            if (_Selected_Item == null)
            {
                ms_grid.SelectedItems.Clear();
                _Selected_Item      = null;
            }
            else if (Item_to_Select is State)
            {
                var Tag_Row         = Item_to_Select as State;
                var row             = ms_grid.GetDataRows()
                                            .FirstOrDefault
                                            (x => ((State)x.DataRow).ID == Tag_Row.ID);
                if (row != null)
                {
                    ms_grid.MoveTo(row);
                    _Selected_Item  = row.DataRow;
                }
                else
                    _Selected_Item  = null;
            }
            else if (Item_to_Select is short)
            {
                var IDRow           = (short)Item_to_Select;
                var row             = _ListAccounts.FirstOrDefault(x => x.ID == IDRow);
                _Selected_Item      = row;
            }
        }
        public  void            SetParent       (Control DropDownMenu)
        {
            _DropMenu = DropDownMenu;
        }
        #endregion

        private void    NzRefresh      (object sender, EventArgs eventArgs)
        {
            _ListAccounts = _Manager.GetList<State>();
            RefreshControl();
        }
        private void    NzAdd          (object sender, EventArgs eventArgs)
        {
            var p   = _DropMenu as Popup_ToolStrip;
            p?.Close();
            var frm = new Form_State(_Manager,null);
            frm.ShowDialog(this.FindForm());
            p?.Show();
            RefreshControl();
            var ID = Convert.ToInt32(frm.Tag);
            var row = ms_grid
                .GetDataRows()
                .SingleOrDefault(x =>
                    ((State)x.DataRow)?.ID == ID);
            if (row != null)
            {
                ms_grid.MoveTo(row);
                ms_grid.EnsureVisible(row.Position, ms_grid.RootTable.Columns[0]);
            }
        }
    }
}
