using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using MS_Control;
using MS_Control.MainForms;
using MS_Control.Tarikh;
using MS_Print_Dialog;
using NZ.Xazane.Business;
using NZ.Xazane.Model.Report;
using NZ.Xazane.WinForms.App;
using NZ.Xazane.WinForms.Base;
using ShareLib;
using ShareLib.Models;
using ShareLib.Utils;

namespace NZ.Xazane.WinForms.Report
{
    public partial class FormCircularPeople : Form
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private PeopleCircularModel _Circular;
        #endregion
        #region Constructor
        public FormCircularPeople()
        {
            InitializeComponent();
            NzCustomer.Refresh_Grid((byte)3, null, null);
            this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;

        }
        #endregion
        #region Methods
        private void RefreshGrid                ()
        {
            try
            {
                DateTime?   DateFrom    = null, 
                            DateTo      = null;
                var         people      = NzCustomer.MS_Get_Selected() as People;

                if (NzDateFrom.MS_Tarikh.HasValue)
                    DateFrom = NzDateFrom.MS_Tarikh.Value.ToDatetime().Date;
                if (NzDateTo.MS_Tarikh.HasValue)
                    DateTo  = NzDateTo.MS_Tarikh.Value.ToDatetime().Date;

                var mgr     = new ReportManager();
                var Items   = mgr.MultipleList<MoneyCircular, PeopleCircularModel,PeopleCheque,PeopleChequeBack,PeopleChequeAssign>
                (
                    Enums.NzMultipleReportKind.First,
                    new
                    {
                        People      = people.ID,
                        Year        = SystemConstant.ActiveYear.Salmali,
                        CRemain     = (byte)Enums.NzPaymentOperatingKind.RemaindCredit,
                        DRemain     = (byte)Enums.NzPaymentOperatingKind.RemaindDebit,
                        KindBack    = (byte)Enums.NzChequeStateFlag.Bargasht,
                        KindAssign  = (byte)Enums.NzChequeStateFlag.Vagozari,
                        DateFrom,
                        DateTo,
                    }
                );

                _Circular           = Items.Item2.FirstOrDefault();
                _Circular.People    = people;
                if (_Circular == null)
                {
                    NzGrid.DataSource = null;
                    return;
                }

                _Circular.Caches       = Items.Item1.Where(x => x.SubKind == (byte) Enums.NzPaymentOperatingKind.Naqd).ToList();
                _Circular.Pos          = Items.Item1.Where(x => x.SubKind == (byte) Enums.NzPaymentOperatingKind.Bank_POS).ToList();
                _Circular.Misc         = Items.Item1.Where(x => x.SubKind == (byte) Enums.NzPaymentOperatingKind.Addition || x.SubKind == (byte)Enums.NzPaymentOperatingKind.Kosurat).ToList();
                _Circular.Cheque       = Items.Item3.ToList();
                _Circular.ChequeBack   = Items.Item4.ToList();
                _Circular.ChequeAssign = Items.Item5.ToList();

                NzGrid.DataSource = new List<PeopleCircularModel>() { _Circular };
                NzGrid.ExpandRecords();
                NzGrid.FilterMode = FilterMode.None;
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MS_Message.Show("خطا در خواندن اطلاعات",
                    "خطا", 
                    ex.Message, 
                    MessageBoxButtons.OK,
                    MSMessage.FarsiMessageBoxIcon.خطا);
            }
        }
        #endregion
        private void NzReport_Click             (object sender, EventArgs e)
        {
            RefreshGrid();
        }
        private void NzGrid_ColumnButtonClick   (object sender, ColumnActionEventArgs e)
        {
            var Cur = NzGrid.CurrentRow;
            switch (e.Column.Table.Key)
            {
                case "Root":
                {
                    var row         = Cur.DataRow as PeopleCircularModel;
                    var frm         = new FormListRemaind();
                    frm.MdiParent   = this.MdiParent;
                    frm.Show();
                }
                    break;
                case "Caches":
                {
                    var row         = Cur.DataRow as MoneyCircular;
                    var frm         = new FormPayment(row.FK_DP, (Enums.NzPaymentOperatingKind)row.MainKind);
                    frm.Show();
                }
                    break;
                case "POS":
                {
                    var row         = Cur.DataRow as MoneyCircular;
                    var frm         = new FormPayment(row.FK_DP, (Enums.NzPaymentOperatingKind)row.MainKind);
                    frm.Show();
                }
                    break;
                case "Misc":
                {
                    var row         = Cur.DataRow as MoneyCircular;
                    var frm         = new App.FormDeficit(null,row.FK_DP);
                    frm.Show();
                }
                    break;
                case "Cheque":
                {
                    var row         = Cur.DataRow as PeopleCheque;
                    var frm         = new FormPayment(row.ID_DP,(Enums.NzPaymentOperatingKind)row.kind);
                    frm.Show();
                }
                    break;
                case "ChequeBack":
                {
                    var row         = Cur.DataRow as PeopleChequeBack;
                    var frm         = new FormPayment(row.ID_DP, (Enums.NzPaymentOperatingKind)row.kind);
                    frm.Show();
                }
                    break;
                case "ChequeAssign":
                {
                    var row         = Cur.DataRow as PeopleChequeAssign;
                    var frm         = new FormPayment(row.ID_DP,Enums.NzPaymentOperatingKind.Daryaft);
                    frm.Show();
                }
                    break;
            }
        }
        private void NzCustomer_OnRowSelected   (object sender, MS_Control.TSDD.On_Selected e)
        {
            if (NzCustomer.MS_Get_Selected() != null)
            {
                NzReport.PerformClick();
                var tmp = NzCustomer.MS_Get_Selected() as People;
                NzCustomerRemain.NzSetCustoemr(tmp?.ID ?? 0);
            }
            else
            {
                NzGrid.DataSource       = null;
                NzCustomerRemain.Text   = "";
            }
        }

        private void NzPrint_Click              (object sender, EventArgs e)
        {

            var people      = _Circular.People;
            var path        = Utility.GetPrintDirectory() + "\\DP\\PeopleCircular.mrt";
            var PrnDiag     = new Print_Dialog(path);
            PrnDiag.Set_DataSource("Caches",        _Circular.Caches);
            PrnDiag.Set_DataSource("Pos",           _Circular.Pos);
            PrnDiag.Set_DataSource("Misk",          _Circular.Misc);
            PrnDiag.Set_DataSource("Cheque",        _Circular.Cheque);
            PrnDiag.Set_DataSource("ChequeBack",    _Circular.ChequeBack);
            PrnDiag.Set_DataSource("ChequeAssign",  _Circular.ChequeAssign);

            PrnDiag.Set_Variable("tarikh"           , new MS_Structure_Shamsi(DateTime.Now).ToShamsi());
            PrnDiag.Set_Variable("User"             , SystemConstant.ActiveUser.title);
            PrnDiag.Set_Variable("Company"          , SystemConstant.ActiveCompany.title);
            PrnDiag.Set_Variable("Name"             , people?.title);
            PrnDiag.Set_Variable("Address"          , people?.addressHome);
            PrnDiag.Set_Variable("CodeMeli"         , people?.codeMeli);
            PrnDiag.Set_Variable("Mobile"           , people?.mobile);
            PrnDiag.Set_Variable("Tel"              , people?.tel);
            PrnDiag.Set_Variable("Remaind"          , _Circular.GetBalance());
            
            PrnDiag.ShowDialog(this);
        }

        private void NzGrid_FormattingRow       (object sender, RowLoadEventArgs e)
        {
            if (e.Row.RowType == RowType.TotalRow && e.Row.Table==NzGrid.RootTable)
            {
                var Balance = _Circular.GetBalance();

                e.Row.Cells["DRemaind"].Text            = Balance.ToString("0,0.##;(0,0.##); ");
                e.Row.Cells["codeMeli"].Text            = "مانده نهایی شخص";
                e.Row.Cells["DRemaind"].FormatStyle     = new GridEXFormatStyle()
                {
                    TextAlignment   = Balance   > 0 ? TextAlignment.Near : TextAlignment.Far,
                    ForeColor       = Balance   > 0 ? Color.Green        : Color.Maroon,
                };
            }
        }
    }
}
