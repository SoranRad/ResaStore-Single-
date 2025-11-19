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
using MS_Control;
using Nz.Anbar.WinForms.Base;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.Component
{
	public partial class NzStorageCheckBox : MS_Base_GridPopup
	{
		#region Fields
		private Manager                     _Manager;
		private IEnumerable<Storage>		_List;
		private Control                     _DropMenu;
		#endregion

		public NzStorageCheckBox()
		{
			InitializeComponent();
			ms_grid.RootTable.ColumnHeaders = InheritableBoolean.False;
			ms_null.Visible                 = false;
			ms_Add.Visible					= false;
			ms_filter.Visible               = false;
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
            else if (Item_to_Select is Storage[] StorageArrays)
            {
	            ms_grid.GetRows().MSZ_ForEach(row =>
                {
	                var data        = row.DataRow as Storage;
	                row.IsChecked   = StorageArrays.Any(x => x.ID == data.ID);
                });
            }
            else if (Item_to_Select is short[] storageIdArray)
            {
	            ms_grid.GetRows().MSZ_ForEach(row =>
	            {
		            var data        = row.DataRow as Storage;
		            row.IsChecked   = storageIdArray.Any(x => x == data.ID);
	            });
            }
        }
        public  void            SetParent       (Control DropDownMenu)
        {
            _DropMenu = DropDownMenu;
        }
        public Storage          GetFirst        ()
        {
	        var first = ms_grid.GetRows().FirstOrDefault();
	        if (first != null)
		        first.IsChecked = true;

	        return _List.FirstOrDefault();
        }
        public override object  MS_Get_Selected ()
        {
	        return ms_grid.GetCheckedRows().Select(x => x.DataRow as Storage).ToArray();
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
	}
}
