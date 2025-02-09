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
    public partial class NzListPeople : MS_Base_GridPopup
    {
        #region Fields
        private Manager                 _Manager;
        private static IEnumerable<People>     _List;
        private Control                 _DropMenu;


        private byte                    _KindCustomer;
        #endregion
        #region Constructor
        public NzListPeople()
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

            if (_KindCustomer == 1)
                list = list?.Where(x => x.is_Froshande);
            else if (_KindCustomer == 2)
                list = list?.Where(x => x.is_Xaridar);

            if (ms_grid.InvokeRequired)
                ms_grid.Invoke(new MethodInvoker(delegate
                {
                    ms_grid.DataSource = list?.Where(x => !x.is_disable).ToList();
                }));
            else
                    ms_grid.DataSource = list?.Where(x => !x.is_disable).ToList();
        }

        public override void    Refresh_Grid    (params object[] List_Columns)
        {

            foreach (var Option in List_Columns)
            {
                switch (Option)
                {
                    case Manager _:
                        _Manager = Option as Manager;
                        break;
                    case DbConnection _:
                        _Manager = new Manager((DbConnection) Option);
                        break;
                    case byte _:
                        _KindCustomer = (byte)Option;
                        break;
                }
            }

            try
            {

                //Task.Run(() =>
                //{
                    _Manager = _Manager ?? new Manager();
                if (_List == null)
                    _List = _Manager.GetList<People>();
                    RefreshControl();
                //});
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

            if (_KindCustomer == 1)
                list = list?.Where(x => x.is_Froshande);
            else if (_KindCustomer == 2)
                list = list?.Where(x => x.is_Xaridar);

            ms_grid.DataSource = list
                                ?.Where(x =>
                                               !x.is_disable
                                            && (x.title                 .Contains(Str)
                                            ||  x.code.ToString()       .Contains(Str)
                                            || (x.GroupTitle ?? "")     .Contains(Str)
                                            || (x.codeMeli ?? "")       .Contains(Str)
                                            || (x.codePosti ?? "")      .Contains(Str)
                                            || (x.fax ?? "")            .Contains(Str)
                                            || (x.addressHome ?? "")    .Contains(Str)
                                            || (x.addresswork ?? "")    .Contains(Str)
                                            || (x.mobile ?? "")         .Contains(Str)
                                            || (x.CityTitle ?? "")      .Contains(Str)
                                            || (x.tel ?? "")            .Contains(Str)
                                            || (x.telDowom ?? "")       .Contains(Str)
                                            || (x.mobDowom ?? "")       .Contains(Str)
                                            || (x.Plak ?? "")           .Contains(Str)
                                               ))
                                .ToList();

            //if (_Customer || _Buyer)
            //    list    = list?.Where(x => x.is_Froshande == _Buyer && x.is_Xaridar == _Customer).AsQueryable();
            //ms_grid.DataSource = list
            //                            ?.Where(x =>
            //                                             !x.is_disable
            //                                        &&(  x.title                  .Contains(Str)
            //                                        ||   x.code.ToString()        .Contains(Str)
            //                                        ||  (x.GroupTitle        ??"").Contains(Str)
            //                                        ||  (x.codeMeli          ??"").Contains(Str)
            //                                        ||  (x.codePosti         ??"").Contains(Str)
            //                                        ||  (x.fax               ??"").Contains(Str)
            //                                        ||  (x.addressHome       ??"").Contains(Str)
            //                                        ||  (x.addresswork       ??"").Contains(Str)
            //                                        ||  (x.mobile            ??"").Contains(Str)
            //                                        ||  (x.CityTitle         ??"").Contains(Str)
            //                                        ||  (x.tel               ??"").Contains(Str)
            //                                        ||  (x.telDowom          ??"").Contains(Str)
            //                                        ||  (x.mobDowom          ??"").Contains(Str)
            //                                        ))
            //                            .ToList();
        }
        public override void    MS_Set_Select   (object Item_to_Select)
        {
            _Selected_Item = Item_to_Select;

            if (_Selected_Item == null)
            {
                ms_grid.SelectedItems.Clear();
                _Selected_Item = null;
            }
            else if (Item_to_Select is People)
            {
                var Tag_Row = Item_to_Select as People;
                var row     = ms_grid.GetDataRows()
                                            .FirstOrDefault
                                            (x => ((People)x.DataRow).ID == Tag_Row.ID);
                if (row != null)
                {
                    ms_grid.MoveTo(row);
                    _Selected_Item = row.DataRow;
                }
                else
                    _Selected_Item = null;
            }
            else if (Item_to_Select is long)
            {
                var IDRow = (long)Item_to_Select;
                var row = _List.FirstOrDefault(x => x.ID == IDRow);
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
            _List = _Manager.GetList<People>();
            RefreshControl();
        }
        private void            NzAdd           (object sender, EventArgs eventArgs)
        {
            var p       = _DropMenu as Popup_ToolStrip;
            p?.Close();
            var frm     = new Form_People(_Manager, null);
            frm.ShowDialog(this.FindForm());
            p?.Show();
            _List       = _Manager.GetList<People>();
            RefreshControl();

            var ID      = Convert.ToInt64(frm.Tag);
            var row     = ms_grid
                .GetDataRows()
                .SingleOrDefault(x =>
                    ((People)x.DataRow)?.ID == ID);
            if (row != null)
            {
                ms_grid.MoveTo(row);
                ms_grid.EnsureVisible(row.Position, ms_grid.RootTable.Columns[0]);
            }
        }

    }
}
