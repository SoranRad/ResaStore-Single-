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
using Janus.Windows.GridEX;
using MS_Control.TSDD;
using Nz.Anbar.Model.Model;
using Nz.Anbar.WinForms.Base;
using NZ.Anbar.Business;
using ShareLib;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.Component
{
    public partial class NzListMainGroup : MS_Base_GridPopup
    {
        #region Fields
        private Manager                     _Manager;
        private IEnumerable<MainGroup>      _ListAccounts;
        private Control                     _DropMenu;
        #endregion
        #region Constructor
        public                  NzListMainGroup ()
        {
            InitializeComponent();
            ms_grid.RootTable.ColumnHeaders = InheritableBoolean.False;
            ms_null.Visible                 = false;
            ms_Add.Click                    += NzAdd;
            ms_refresh.Click                += NzRefresh;
        }
        #endregion
        #region Methods
        private void            RefreshControl  ()
        {
            _ListAccounts       = _Manager
                                    .GetList<MainGroup>(new
                                        {
                                            Year = SystemConstant.ActiveYear.Salmali
                                        });
            ms_grid.DataSource  = _ListAccounts?.ToList();
        }
        public  override void   Refresh_Grid    (object Option)
        {
                if (Option is Manager)
                    _Manager = Option as Manager;
            try
            {
                _Manager        = _Manager ?? new Manager();
                RefreshControl      ();
            }
            catch (Exception )
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
                                        .Where(x =>     x.title.Contains(Str)
                                                    ||  x.Code.ToString().Contains(Str)
                                                    )
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
            else if (Item_to_Select is MainGroup)
            {
                var Tag_Row         = Item_to_Select as MainGroup;
                var row             = ms_grid.GetDataRows()
                                            .FirstOrDefault
                                            (x => ((MainGroup)x.DataRow).ID == Tag_Row.ID);
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
                var row             = _ListAccounts.FirstOrDefault(x => x.Code == IDRow);
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
            _ListAccounts   = _Manager.GetList<MainGroup>(SystemConstant.ActiveYear);
            RefreshControl();
        }
        private void    NzAdd          (object sender, EventArgs eventArgs)
        {
            var p   = _DropMenu as Popup_ToolStrip;
            p?.Close();
            var frm = new FormMainGroup(_Manager);
            frm.ShowDialog(this.FindForm());
            p?.Show();
            RefreshControl();
            var ID = Convert.ToInt32(frm.Tag);
            var row = ms_grid
                .GetDataRows()
                .SingleOrDefault(x =>
                    ((MainGroup)x.DataRow)?.ID == ID);
            if (row != null)
            {
                ms_grid.MoveTo(row);
                ms_grid.EnsureVisible(row.Position, ms_grid.RootTable.Columns[0]);
            }
        }
    }
}
