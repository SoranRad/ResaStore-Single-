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
using NZ.General.Business;
using NZ.General.WinForms.Base;
using ShareLib.Models;
using ShareLib.Utils;

namespace NZ.General.WinForms.Component
{
    public partial class NzListGroupPeople : MS_Base_GridPopup
    {
        #region Fields
        private Manager                     _Manager;
        private IEnumerable<PeopleGroup>    _List;
        private Control                     _DropMenu;
        #endregion
        public NzListGroupPeople        ()
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
            _List               = _Manager.GetList<PeopleGroup>();
            ms_grid.DataSource  = _List?.ToList();
        }
        public  override void   Refresh_Grid    (object Option)
        {
            if (Option is Manager)
                _Manager = Option as Manager;
            else if(Option is DbConnection)
                _Manager = new Manager((DbConnection)Option);
            try
            {
                _Manager        = _Manager ?? new Manager();
                RefreshControl  ();
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
                                        .Where(x =>     x.Title.Contains(Str)
                                                    ||  x.ID.ToString().Contains(Str)
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
            else if (Item_to_Select is PeopleGroup)
            {
                var Tag_Row         = Item_to_Select as PeopleGroup;
                var row             = ms_grid.GetDataRows()
                                            .FirstOrDefault
                                            (x => ((PeopleGroup)x.DataRow).ID == Tag_Row.ID);
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
            _List   = _Manager.GetList<PeopleGroup>();
            RefreshControl();
        }
        private void    NzAdd          (object sender, EventArgs eventArgs)
        {
            var p   = _DropMenu as Popup_ToolStrip;
            p?.Close();
            var frm = new Form_PeopleGroup(_Manager,null);
            frm.ShowDialog(this.FindForm());
            p?.Show();
            RefreshControl();
            var ID = Convert.ToInt32(frm.Tag);
            var row = ms_grid
                .GetDataRows()
                .SingleOrDefault(x =>
                    ((PeopleGroup)x.DataRow)?.ID == ID);
            if (row != null)
            {
                ms_grid.MoveTo(row);
                ms_grid.EnsureVisible(row.Position, ms_grid.RootTable.Columns[0]);
            }
        }
    }
}
