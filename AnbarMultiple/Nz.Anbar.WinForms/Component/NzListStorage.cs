using MS_Control.TSDD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using NZ.Anbar.Business;
using NZ.Anbar.Model; 
using Janus.Windows.GridEX;
using Nz.Anbar.WinForms.Base;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.Component
{
	public partial class NzListStorage : MS_Base_GridPopup
	{
		#region Fields
		private Manager                     _Manager;
		private IEnumerable<Storage>		_List;
		private Control                     _DropMenu;
		#endregion


		public NzListStorage()
		{
			InitializeComponent();
			ms_grid.RootTable.ColumnHeaders = InheritableBoolean.False;
			ms_null.Visible                 = false;
			ms_Add.Click                    += NzAdd;
			ms_refresh.Click                += NzRefresh;
		}

		#region Methods
        private void            RefreshControl  ()
        {
            _List       = _Manager
                            .GetList<Storage>(new
                                {
                                    Year = SystemConstant.ActiveYear.Salmali
                                });
           ms_grid.DataSource  = _List?.Where(x=>!x.Is_Disable).ToList();
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
            catch (Exception)
            {
                
            }
        }
        public  override void   Refresh_Grid    ()
        {
	        try
	        {
		        _Manager        = _Manager ?? new Manager();
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
                                        .Where(x =>     x.Title.Contains(Str)
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
            else if (Item_to_Select is Storage)
            {
                var Tag_Row         = Item_to_Select as Storage;
                var row             = ms_grid.GetDataRows()
                                            .FirstOrDefault
                                            (x => ((Storage)x.DataRow).ID == Tag_Row.ID);
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
                var row             = _List.FirstOrDefault(x => x.Code == IDRow);
                _Selected_Item      = row;
            }
        }
        public  void            SetParent       (Control DropDownMenu)
        {
            _DropMenu = DropDownMenu;
        }

        public Storage          GetFirst        ()
        {
	        return _List.FirstOrDefault();
        }
        #endregion

        private void    NzRefresh      (object sender, EventArgs eventArgs)
        {
            _List   = _Manager.GetList<Storage>(new
            {
                Year = SystemConstant.ActiveYear.Salmali
            });
            RefreshControl();
        }
        private void    NzAdd          (object sender, EventArgs eventArgs)
        {
            var p   = _DropMenu as Popup_ToolStrip;
            p?.Close();
            var frm = new FormStorage(_Manager);
            frm.ShowDialog(this.FindForm());
            p?.Show();
            RefreshControl();
            var ID = Convert.ToInt32(frm.Tag);
            var row = ms_grid
                .GetDataRows()
                .SingleOrDefault(x =>
                    ((Storage)x.DataRow)?.ID == ID);
            if (row != null)
            {
                ms_grid.MoveTo(row);
                ms_grid.EnsureVisible(row.Position, ms_grid.RootTable.Columns[0]);
            }
        }
	}
}
