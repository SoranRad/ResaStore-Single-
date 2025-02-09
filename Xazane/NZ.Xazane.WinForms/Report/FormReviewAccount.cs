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
using NZ.Xazane.Business;
using NZ.Xazane.Model.Report;
using ShareLib;
using ShareLib.Utils;

namespace NZ.Xazane.WinForms.Report
{
    public partial class FormReviewAccount : Form
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        public FormReviewAccount()
        {
            InitializeComponent();
            this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            try
            {
                var mgr = new ReportManager();
                var list = mgr.GetReport<ReviewAccoutnSumarry>(
                    new
                    {
                        Year        = SystemConstant.ActiveYear.Salmali,
                        KindVosul   = (byte)Enums.NzChequeStateFlag.Vosul
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

        private void NzGrid_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            var frm = new FormReviewAccountMonthly();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void NzGrid_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
        {
            var frm = new FormReviewAccountMonthly();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }

        private void NzRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
