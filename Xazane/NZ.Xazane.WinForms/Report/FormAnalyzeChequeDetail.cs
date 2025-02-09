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
using MS_Control.Tarikh;
using NZ.Xazane.Business;
using NZ.Xazane.Model.Report;
using NZ.Xazane.Model.ViewModel;
using NZ.Xazane.WinForms.App;
using ShareLib;
using ShareLib.Utils;

namespace NZ.Xazane.WinForms.Report
{
    public partial class FormAnalyzeChequeDetail : Form
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion
        #region Fields
        private bool                            _HasState = false;
        private Enums.NzPaymentOperatingKind    _KindDP;
        private Enums.NzChequeStateFlag         _KindState;
        private ReportManager _Manager;

        #endregion
        #region Constructor
        public  FormAnalyzeChequeDetail (Enums.NzPaymentOperatingKind Kind)
        {
            InitializeComponent();
            this.Icon   = global::MS_Resource.GlobalResources.Logo_Resaa;
            _HasState   = false;
            _KindDP     = Kind;
            SetCurrentMonth();
            ms_mah.SelectedTabChanged += NzKinds_SelectedTabChanged;
            RefreshGrid();
            Text += @" - " + (Kind == Enums.NzPaymentOperatingKind.Daryaft ? "چک های دریافتی" : "چک های پرداختی");
        }
        public  FormAnalyzeChequeDetail (Enums.NzChequeStateFlag Kind)
        {
            InitializeComponent();
            this.Icon   = global::MS_Resource.GlobalResources.Logo_Resaa;
            _HasState   = true;
            _KindState  = Kind;
            SetCurrentMonth();
            ms_mah.SelectedTabChanged += NzKinds_SelectedTabChanged;
            RefreshGrid();
            Text += @" - چـک های " + _KindState.NzToString();
        }
        #endregion
        #region Methods
        private void    SetCurrentMonth     ()
        {
            var mah = new MS_Structure_Shamsi(DateTime.Now)._Mah;
            ms_mah.SelectedIndex = 13 - mah;
        }
        private string  GetCondition        ()
        {
            var Month = 14 - ms_mah.SelectedIndex;
            var WhereClause = "";
            if (_HasState)
            {
                
                if (Month == 1)
                    WhereClause =
                        @"  (@Kind IS NULL AND tac.Kind_Vaziat IS NULL AND tad.FK_Salmali < @Year)
                        OR  (tad.FK_Salmali < @Year AND tac.FK_Salmali_Vaziat = @Year AND tac.Kind_Vaziat = @Kind)";

                else if (Month >= 2 && Month <= 13)
                    WhereClause = @" 
                            (tac.FK_Salmali_Vaziat = @Year AND ddVaziat.PersianMonthNo = @Month AND tac.Kind_Vaziat = @Kind)
                            OR (@Kind IS NULL AND tac.Kind_Vaziat IS NULL AND tad.FK_Salmali =@Year AND ddDP.PersianMonthNo = @Month)";
                else
                    WhereClause =
                        @" (@Kind IS NULL AND tac.Kind_Vaziat IS NULL AND tad.FK_Salmali < @Year)
                        OR (tad.FK_Salmali < @Year AND tac.FK_Salmali_Vaziat = @Year AND tac.Kind_Vaziat = @Kind)
                        OR (tac.FK_Salmali_Vaziat = @Year AND tac.Kind_Vaziat = @Kind)
                        OR (@Kind IS NULL AND tac.Kind_Vaziat IS NULL AND tad.FK_Salmali =@Year )";
            }
            else
            {
                if (Month == 1)
                    WhereClause =
                        @"  (tac.Kind_Vaziat is NULL AND tad.kind = @Kind AND tad.FK_Salmali < @Year)
                        OR  (tad.FK_Salmali < @Year AND tac.FK_Salmali_Vaziat = @Year AND tad.kind = @Kind)";

                else if (Month >= 2 && Month <= 13)
                    WhereClause = @" tad.FK_Salmali = @Year AND ddDP.PersianMonthNo = @Month AND tad.kind = @Kind";
                else
                    WhereClause = 
                        @"  (tac.Kind_Vaziat is NULL AND tad.kind = @Kind AND tad.FK_Salmali < @Year)
                        OR  (tad.FK_Salmali < @Year AND tac.FK_Salmali_Vaziat = @Year AND tad.kind = @Kind)
                        OR  (tad.FK_Salmali  =   @Year AND tad.kind = @Kind)";

            }
            return WhereClause;

        }
        private void    RefreshGrid         ()
        {
            try
            {
                var Kind            = _HasState ? (byte?) _KindState : (byte?) _KindDP;
                var WhereClause     = GetCondition();
                var Month           = 14 - ms_mah.SelectedIndex;
                _Manager            = new ReportManager();
                if (_HasState && _KindState == Enums.NzChequeStateFlag.Nazd_Sanduq)
                    Kind = null;

                Month--;
                var list =
                    _Manager.GetReport<AnalyzeChequeDetail>(new
                    {
                        Year = SystemConstant.ActiveYear.Salmali ,
                        Kind ,
                        Month
                    }, WhereClause);

                NzGridHeads.DataSource = list?.ToList();

                if (NzGridHeads.RowCount > 0)
                    NzGridHeads.MoveFirst();

                if (NzItems.Checked)
                    RefreshItem();
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا",ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private void    RefreshItem         ()
        {
            if (NzGridHeads.CurrentRow == null || NzGridHeads.CurrentRow.RowType != RowType.Record)
                return;

            if (!NzItems.Checked)
                return;

            if (NzGridHeads.CurrentRow.DataRow is AnalyzeChequeDetail row)
                NzDetails.SetCheque(row.ID);
        }
    
        #endregion

        private void    NzItems_Click                   (object sender, EventArgs e)
        {
            Splitter1.Visible = NzItems.Checked;
            NzDetails.Visible = NzItems.Checked;
            RefreshItem();
        }
        private void    NzKinds_SelectedTabChanged      (object sender, Janus.Windows.UI.Tab.TabEventArgs e)
        {
            RefreshGrid();
        }
        private void    NzGridHeads_SelectionChanged    (object sender, EventArgs e)
        {
            RefreshItem();
        }

        private void NzGridHeads_ColumnButtonClick(object sender, ColumnActionEventArgs e)
        {
            if (NzGridHeads.CurrentRow?.DataRow is AnalyzeChequeDetail row)
            {
                new FormPayment(row.IDMain, (Enums.NzPaymentOperatingKind)row.Kind).ShowDialog(this);
            }
        }
    }
}
