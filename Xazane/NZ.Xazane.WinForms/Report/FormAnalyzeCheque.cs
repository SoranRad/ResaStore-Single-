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
using NZ.Xazane.Business;
using NZ.Xazane.Model.Report;
using ShareLib;
using ShareLib.Models;
using ShareLib.Utils;

namespace NZ.Xazane.WinForms.Report
{
    public partial class FormAnalyzeCheque : Form
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        //private PeopleCircularModel _Circular;
        #endregion
        public FormAnalyzeCheque()
        {
            InitializeComponent();
            this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            try
            {
                var mgr         = new ReportManager();
                var list        = mgr.GetReport<AnalyzeCheque>(
                    new
                    {
                        Year = SystemConstant.ActiveYear.Salmali
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

        private void ms_Grid_ColumnButtonClick(object sender, ColumnActionEventArgs e)
        {
            if (NzGrid.CurrentRow.DataRow is AnalyzeCheque row)
            {
                Form Frm = row.MainKind ==1
                            ? new FormAnalyzeChequeDetail((Enums.NzPaymentOperatingKind)row.SubKind)
                            : new FormAnalyzeChequeDetail((Enums.NzChequeStateFlag)row.SubKind);
                Frm.MdiParent = this.MdiParent;
                Frm.Show();
            }
        }
    }
}
