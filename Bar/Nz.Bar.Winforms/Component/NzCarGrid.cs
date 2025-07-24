using Janus.Windows.GridEX;
using MS_Control.TSDD;
using NZ.General.WinForms.Base;
using ShareLib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nz.Bar.Business;
using Nz.Bar.Bussiness;
using Nz.Bar.Model.Models;
using Nz.Bar.Model.Report;
using Nz.Bar.Winforms.App;

namespace Nz.Bar.Winforms.Component
{
	public partial class NzCarGrid : MS_Base_GridPopup
	{
		 #region Fields
        private ReportManager                   _Manager;
        private static IEnumerable<CarList>     _List;
        private Control                         _DropMenu;
        #endregion
        #region Constructor
        public NzCarGrid()
        {
	        InitializeComponent();
        
            ms_grid.RootTable.ColumnHeaders     = InheritableBoolean.False;
            ms_grid.FilterMode                  = FilterMode.None;
            ms_null.Visible                     = false;
            ms_Add.Click                        += NzAdd;
            ms_refresh.Click                    += NzRefresh;
        }
        #endregion
        #region Methods
        private void            RefreshControl  ()
        {
            var list = _List?.AsQueryable();

            if (ms_grid.InvokeRequired)
                ms_grid.Invoke(new MethodInvoker(delegate
                {
                    ms_grid.DataSource = list?.Where(x => !x.IsDisable).ToList();
                }));
            else
                    ms_grid.DataSource = list?.Where(x => !x.IsDisable).ToList();
        }

        public override void    Refresh_Grid    (params object[] List_Columns)
        {
            try
            {
                _Manager = _Manager ?? new ReportManager();

                if (_List == null)
                    _List = _Manager.GetReport<CarList>(null,null);

                RefreshControl();
            }
            catch (Exception)
            {

            }

        }
        public override void    Filter_Grid     (string Str)
        {
            Str = Str.Trim();
            if (string.IsNullOrWhiteSpace(Str))
            {
                RefreshControl();
                return;
            }
            var list    = _List?.AsQueryable();
             
            ms_grid.DataSource = list
                                ?.Where(x =>
                                               !x.IsDisable
                                            && (x.PeopleTitle           .Contains(Str)
                                            || (x.CarType ?? "")        .Contains(Str)
                                            || (x.Plak ?? "")           .Contains(Str)
                                               ))
                                .ToList();
        }
        public override void    MS_Set_Select   (object Item_to_Select)
        {
            _Selected_Item = Item_to_Select;

            if (_Selected_Item == null)
            {
                ms_grid.SelectedItems.Clear();
                _Selected_Item = null;
            }
            else if (Item_to_Select is Car tagRow)
            {
	            var row     = ms_grid.GetDataRows()
                                            .FirstOrDefault
                                            (x => ((CarList)x.DataRow).ID == tagRow.ID);
                if (row != null)
                {
                    ms_grid.MoveTo(row);
                    _Selected_Item = row.DataRow;
                }
                else
                    _Selected_Item = null;
            }
            else if (Item_to_Select is short idRow)
            {
	            var row = _List.FirstOrDefault(x => x.ID == idRow);
                _Selected_Item = row;
            }
        }
        public void             SetParent       (Control DropDownMenu)
        {
            _DropMenu = DropDownMenu;
        }
        #endregion

        private void            NzRefresh       (object sender, EventArgs eventArgs)
        {
            _List = _Manager.GetReport<CarList>(null,null);
            RefreshControl();
        }
        private void            NzAdd           (object sender, EventArgs eventArgs)
        {
            var p       = _DropMenu as Popup_ToolStrip;
            p?.Close();
            var frm     = new FormCar(0);
            frm.ShowDialog(this.FindForm());
            p?.Show();
            _List       = _Manager.GetReport<CarList>(null,null);
            RefreshControl();

            var ID      = Convert.ToInt16(frm.Tag);
            var row     = ms_grid
                                .GetDataRows()
                                .SingleOrDefault(x => ((CarList)x.DataRow)?.ID == ID);

            if (row != null)
            {
                ms_grid.MoveTo(row);
                ms_grid.EnsureVisible(row.Position, ms_grid.RootTable.Columns[0]);
            }
        }
		
	}
}
