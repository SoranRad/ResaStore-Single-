using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control;
using MS_Control.Tarikh;
using NZ.Xazane.Business;
using NZ.Xazane.Model.Report;
using NZ.Xazane.WinForms.App;
using ShareLib;
using ShareLib.Utils;

namespace NZ.Xazane.WinForms.Report
{
    public partial class FormReviewAccountDetail : Form
    {

        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        
        private long _ID;
        #endregion
        public FormReviewAccountDetail(long ID , string Title,DateTime? Date)
        {
            InitializeComponent();
            this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
            _ID = ID;
            NzTitle.Text = Title;
            if(Date.HasValue)
                NzDate.MS_Tarikh =new MS_Structure_Shamsi(Date);

            RefreshGrid();
        }

        private void RefreshGrid        ()
        {
            try
            {
                var Date = NzDate.MS_Tarikh?.ToDatetime();

                var mgr     = new ReportManager();
                var list    = mgr.GetReport<ReviewAccountDetail>(
                    new
                    {
                        Date,
                        ID = _ID,
                        Year = SystemConstant.ActiveYear.Salmali,
                        Kind = (byte)Enums.NzChequeStateFlag.Vosul
                    }, null);

                NzGrid.DataSource = list?.ToList();
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
        private void NzReport_Click     (object sender, EventArgs e)
        {
            RefreshGrid();
        }
        private void NzGrid_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (NzGrid.CurrentRow.DataRow is ReviewAccountDetail row)
            {
                var subkind = (Enums.NzPaymentOperatingKind)row.SubKind;
                var mainkind = (Enums.NzPaymentOperatingKind)row.MainKind;

                if (row.RowKind == 1)
                {
                    
                    Form frm;

                    if (subkind == Enums.NzPaymentOperatingKind.Addition || subkind == Enums.NzPaymentOperatingKind.Kosurat)
                        frm = new FormDeficit(null,row.MainID,subkind);
                    else if(subkind == Enums.NzPaymentOperatingKind.Hazine)
                            frm = new FormCost(row.ID);
                    else if (subkind == Enums.NzPaymentOperatingKind.Daramad)
                        frm = new FormIncome(row.ID);
                    else if (subkind == Enums.NzPaymentOperatingKind.Naql_Enteqal)
                        frm = new FormAccountTransfer(row.ID);
                    else
                        frm = new FormPayment(row.MainID, mainkind);

                    frm?.Show();
                }
                else
                {
                    var frm = new FormPayment(row.MainID, mainkind);
                    frm.Show();
                }

            }
        }
    }
}
