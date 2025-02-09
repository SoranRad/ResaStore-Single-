using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janus.Windows.UI.Tab;
using MS_Control;
using MS_Control.Controls;
using MS_Control.MainForms;
using NZ.Xazane.Business;
using NZ.Xazane.Model.Report;
using NZ.Xazane.Model.ViewModel;
using NZ.Xazane.WinForms.App;
using NZ.Xazane.WinForms.Cheque;
using ShareLib;
using ShareLib.Utils;

namespace NZ.Xazane.WinForms.Report
{
    public partial class FormChequeAlarm : Form
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion
        #region Fields
        
        #endregion
        public              FormChequeAlarm ()
        {
            InitializeComponent();
            NzTabTime.SelectedIndex = 1;
            NzTabTime.SelectedTabChanged+=NzTabTimeOnSelectedTabChanged;
            RefreshGrid();
        }
        #region Methods
        private MS_GridX    GetGrid         ()
        {
            if (NzTabTime.SelectedTab == NzLastTab)
                return NzGridLast;

            return NzTabTime.SelectedTab == NzNowTab 
                    ? NzGridNow 
                    : NzGridFuture;
        }
        private string      GetCondition    ()
        {
            if (NzTabTime.SelectedTab == NzLastTab)
                return "<0";

            return NzTabTime.SelectedTab == NzNowTab
                ? @"=0"
                : " < "+NzFutureDays.Text + @" AND DATEDIFF(DAY,GETDATE(),tac.tarikh_sar_resid)>0";
        }
        private void        RefreshGrid     ()
        {
            try
            {
                var Condition   = GetCondition();
                var Grid        = this.GetGrid();
                var mgr         = new ReportManager();
                var list        = mgr.GetReport<UsentCheque>(null,Condition);

                Grid.DataSource = list?.ToList();
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
        private void    NzTabTimeOnSelectedTabChanged   (object sender, TabEventArgs e)
        {
            if (NzTabTime.SelectedIndex >= 1)
                RefreshGrid();
        }
        private void    NzRefresh_Click                 (object sender, EventArgs e)
        {
            if(int.TryParse(NzFutureDays.Text,out int day))
                RefreshGrid();
        }

        private void    NzGridLast_ColumnButtonClick    (object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (e.Column.Table.GridEX.CurrentRow.DataRow is UsentCheque row)
            {
                new FormPayment(row.ID_DP, (Enums.NzPaymentOperatingKind)row.kind).ShowDialog(this);
            }
        }

        private void    NzArriveCheque_Click            (object sender, EventArgs e)
        {
            var Grid = GetGrid();

            if(!(Grid.CurrentRow?.DataRow is UsentCheque row))
                return;

            Form frm = (row.kind == (byte)Enums.NzPaymentOperatingKind.Daryaft)
                ? (Form)new FormArriveCheque(new List<ChequeList>(){new ChequeList(){ID = row.ID,ID_DP = row.ID_DP,tarikh_sar_resid = row.tarikh_sar_resid}})
                : (Form)new FormArrive_Back (Enums.NzChequeStateFlag.Vosul, new List<ChequeList>() { new ChequeList() { ID = row.ID, ID_DP = row.ID_DP, tarikh_sar_resid = row.tarikh_sar_resid } });

            frm.ShowDialog();

            RefreshGrid();
        }
        private void    NzGiveBackCheque_Click          (object sender, EventArgs e)
        {
            var Grid = GetGrid();

            if (!(Grid.CurrentRow?.DataRow is UsentCheque row))
                return;

            new FormArrive_Back
                    (Enums.NzChequeStateFlag.Bargasht, new List<ChequeList>() { new ChequeList() { ID = row.ID, ID_DP = row.ID_DP, tarikh_sar_resid = row.tarikh_sar_resid } })
                .ShowDialog(this);

            RefreshGrid();
        }
        private void    NzAssignToOther_Click           (object sender, EventArgs e)
        {
            var Grid = GetGrid();

            if (!(Grid.CurrentRow?.DataRow is UsentCheque row))
                return;

            if(row.kind != (byte)Enums.NzPaymentOperatingKind.Daryaft)
                return;

            new FormAssign(new List<ChequeList>() { new ChequeList() { ID = row.ID, ID_DP = row.ID_DP, tarikh_sar_resid = row.tarikh_sar_resid } })
                .ShowDialog(this);

            RefreshGrid();

        }
    }
}
