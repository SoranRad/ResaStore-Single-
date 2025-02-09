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
using Nz.Anbar.Model.Report;
using NZ.Anbar.Business;
using Nz.Anbar.Model.Report.Profit;
using ShareLib;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.Report.Profit
{
    public partial class FormProfitObject : Form
    {

        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        public FormProfitObject(DateTime? Date = null)
        {
            InitializeComponent();

            NzDateFrom.MS_Tarikh = Date.HasValue 
                                    ? new MS_Structure_Shamsi(Date.Value) 
                                    : new MS_Structure_Shamsi(DateTime.Now);
        }
        private void RefreshGrid()
        {
            try
            {
                if(!NzDateFrom.MS_Tarikh.HasValue)
                    return;

                var Day     = NzDateFrom.MS_Tarikh.Value.ToDatetime().Date;
                var Mgr     = new ReportManager();
                var List    = Mgr
                    .GetReport<ProfitObject>
                    (new
                        {
                            Year            = SystemConstant.ActiveYear.Salmali,
                            KindSale        = (byte)Enums.NzFactorKind.Frosh,
                            KindSaleBack    = (byte)Enums.NzFactorKind.BargshtFrosh,
                            tarikh          = Day,
                        }, null
                    );

                ms_Grid.DataSource = List?.ToList();
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
            }

        }
        private void FormProfitObject_Shown(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void NzReport_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void ms_Grid_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (ms_Grid.CurrentRow.DataRow is ProfitObject row)
            {
                var frm = new FormCircularObject(row.Code);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
        }
    }
}
