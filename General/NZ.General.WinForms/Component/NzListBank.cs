using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control.TSDD;
using NZ.General.Business;
using ShareLib.Models;
using Janus.Windows.GridEX;
using NZ.General.WinForms.Base;

namespace NZ.General.WinForms.Component
{
    public partial class NzListBank : MS_Base_GridPopup
    {
        #region Fields
        private Manager                     _Manager;
        private IEnumerable<Bank>           _List;
        private Control                     _DropMenu;
        #endregion
        public NzListBank()
        {
            InitializeComponent();
            ms_grid.RootTable.ColumnHeaders     = InheritableBoolean.False;
            ms_null.Visible                     = false;
            ms_Add.Click                        += NzAdd;
            ms_refresh.Click                    += NzRefresh;
        }
        #region Methods
        private void            RefreshControl  ()
        {
            _List               = _Manager.GetList<Bank>();
            ms_grid.DataSource  = _List?.ToList();
        }
        public  override void   Refresh_Grid    ()
        {
            try
            {
                _Manager        = new Manager();
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
                ms_grid.DataSource = _List?.ToList();
                return;
            }
            ms_grid.DataSource = _List
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
            else if (Item_to_Select is Bank)
            {
                var Tag_Row         = Item_to_Select as Bank;
                var row             = ms_grid.GetDataRows()
                                            .FirstOrDefault
                                            (x => ((Bank)x.DataRow).ID == Tag_Row.ID);
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
                var row             = _List.FirstOrDefault(x => x.ID == IDRow);
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
            _List   = _Manager.GetList<Bank>();
            RefreshControl();
        }
        private void    NzAdd          (object sender, EventArgs eventArgs)
        {
            try
            {
                var p = _DropMenu as Popup_ToolStrip;
                p?.Close();
                var frm = new Form_Bank();
                frm.ShowDialog(this.FindForm());
                p?.Show();
                RefreshControl();
                var ID = Convert.ToInt32(frm.Tag);
                var row = ms_grid
                    .GetDataRows()
                    .SingleOrDefault(x =>
                        ((Bank)x.DataRow)?.ID == ID);
                if (row != null)
                {
                    ms_grid.MoveTo(row);
                    ms_grid.EnsureVisible(row.Position, ms_grid.RootTable.Columns[0]);
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
