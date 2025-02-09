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
using MS_Control.MainForms;
using Nz.Anbar.Model.Report;
using NZ.Anbar.Business;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.Report
{
    public partial class FormPeopleSummaryCircular : Form
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Constractor
        public FormPeopleSummaryCircular()
        {
            InitializeComponent();
            this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
        }
        #endregion

        private void ms_Grid_ColumnButtonClick      (object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (ms_Grid.CurrentRow.DataRow is CircularSummary row)
            {
                var frm         = new FormPepoleCircular(row.ID);
                frm.MdiParent   = this.MdiParent;
                frm.Show();
            }
        }
        private void mS_GridX_Setting1_MS_On_Print_Clicked(object sender, EventArgs e)
        {
            mS_GridX_Setting1.FillParametter(this.Text );
        }
        private void FormObjectRemaid_Shown         (object sender, EventArgs e)
        {

            try
            {
                var Mgr = new ReportManager();
                var List = Mgr.GetReport<CircularSummary>(new { Year = SystemConstant.ActiveYear.Salmali }, null);

                ms_Grid.DataSource = List?
                    .ToList();
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
            }
        }

        private void NzRefresh_Click(object sender, EventArgs e)
        {
            FormObjectRemaid_Shown(sender, e);
        }
    }
}
