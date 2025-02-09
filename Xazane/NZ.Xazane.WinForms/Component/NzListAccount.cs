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
using MS_Control;
using MS_Control.TSDD;
using NZ.Xazane.Business;
using NZ.Xazane.Model;
using NZ.Xazane.WinForms.Base;
using ShareLib;
using ShareLib.Utils;

namespace NZ.Xazane.WinForms.Component
{
    public partial class NzListAccount : MS_Base_GridPopup
    {
        #region Fields
        private Manager          _Manager;
        private IEnumerable<Accounts>   _ListAccounts;
        private Enums.NzAccountKind     _Kind;
        #endregion
        #region Constructor
        public NzListAccount()
        {
            InitializeComponent();
            ms_null.Visible     = false;
            ms_Add.Click        +=NzAdd;
            ms_refresh.Click    +=NzRefresh;

        }
        #endregion
        #region Property

        public Control Popup { get; set; }
        #endregion
        #region Methods
        private void            SetLayout       ()
        {
            switch (_Kind)
            {
                case Enums.NzAccountKind.Cache:
                    ms_grid.LoadLayout(ms_grid.Layouts["Cache"]);
                    break;
                case Enums.NzAccountKind.BankAccount:
                    ms_grid.LoadLayout(ms_grid.Layouts["BankAccount"]);
                    break;
                case Enums.NzAccountKind.Income:
                    ms_grid.LoadLayout(ms_grid.Layouts["Income"]);
                    break;
                case Enums.NzAccountKind.Cost:
                    ms_grid.LoadLayout(ms_grid.Layouts["Cost"]);
                    break;
                case Enums.NzAccountKind.Deficit:
                    ms_grid.LoadLayout(ms_grid.Layouts["Deficit"]);
                    break;
            }
        }
        private void            RefreshControl  ()
        {
            ms_grid.DataSource = _ListAccounts
                                        .Where(x=>!x.is_disable)
                                        .ToList();
        }
        public  override void   Refresh_Grid    (params object[] List_Columns)
        {
            foreach (var item in List_Columns)
            {
                if (item is Enums.NzAccountKind)
                    _Kind = (Enums.NzAccountKind) item;
                
            }
            try
            {
                _Manager        = new Manager ();
                _ListAccounts   = _Manager.GetList<Accounts>(new {Kind = _Kind});
                SetLayout           ();
                RefreshControl      ();
            }
            catch (Exception)
            {
                
            }
        }

        public  override void   Refresh_Grid    (object Parameter)
        {
                if (Parameter is Enums.NzAccountKind)
                    _Kind = (Enums.NzAccountKind)Parameter;

            try
            {
                _Manager = new Manager();
                _ListAccounts = _Manager.GetList<Accounts>(new { Kind = _Kind });
                SetLayout();
                RefreshControl();
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
                RefreshControl();
                return;
            }
            ms_grid.DataSource = _ListAccounts
                                        .Where(x => (x.title.Contains(Str)
                                                    || x.Code.ToString().Contains(Str)
                                                    )
                                                    && !x.is_disable
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
            else if (Item_to_Select is Accounts)
            {
                var Tag_Row         = Item_to_Select as Accounts;
                var row             = ms_grid.GetDataRows()
                                            .FirstOrDefault
                                            (x => ((Accounts)x.DataRow).ID == Tag_Row.ID);
                if (row != null)
                {
                    ms_grid.MoveTo(row);
                    _Selected_Item  = row.DataRow;
                }
                else
                    _Selected_Item  = null;
            }
            else if (Item_to_Select is int)
            {
                var IDRow           = (int)Item_to_Select;
                var row             = _ListAccounts.FirstOrDefault(x => x.ID == IDRow);
                _Selected_Item      = row;
            }
        }
        #endregion

        private void    NzRefresh      (object sender, EventArgs eventArgs)
        {
            _ListAccounts   = _Manager.GetList<Accounts>(new { Kind = _Kind });
            RefreshControl();
        }
        private void    NzAdd          (object sender, EventArgs eventArgs)
        {
            Form frm=null;
            switch (_Kind)
            {
                case Enums.NzAccountKind.Cache:
                    frm=new Form_Cache(_Manager, null);
                    break;
                case Enums.NzAccountKind.BankAccount:
                    frm=new FormBankAccount(_Manager,null);
                    break;
                case Enums.NzAccountKind.Income:
                    frm = new FormIncome(_Manager, null);
                    break;
                case Enums.NzAccountKind.Cost:
                    frm = new FormCost(_Manager, null);
                    break;
                case Enums.NzAccountKind.Fund:
                    frm = new FormFund(_Manager, null);
                    break;
                case Enums.NzAccountKind.Deficit:
                    frm = new FormDeficit(_Manager, null);
                    break;
                case Enums.NzAccountKind.Addition:
                    frm = new FormDeficit(_Manager, null,Enums.NzAccountKind.Addition);
                    break;

                default:
                    frm = null;
                    break;
            }
            if (Popup != null)
            {
                var p = Popup as MS_TextBox_ADC;
                p?.HideMenu();
            }
            frm?.ShowDialog();
            //====عملیات مربوط به انتخاب مورد جدید اضافه شده
            try
            {
                _ListAccounts = _Manager.GetList<Accounts>(new { Kind = _Kind });
                RefreshControl();
                if (Popup != null)
                {
                    var p = Popup as MS_TextBox_ADC;
                    p?.ShowMenu();
                }

                var ID = Convert.ToInt64(frm.Tag);
                var row= ms_grid.GetDataRows().FirstOrDefault(x => (x.DataRow as Accounts).ID == ID);
                ms_grid.MoveTo(row);
                
                ms_select.PerformClick();
            }
            catch (Exception )
            {
                
            }
        }

    }
}
