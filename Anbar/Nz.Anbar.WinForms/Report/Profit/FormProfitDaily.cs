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
    public partial class FormProfitDaily : Form
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        public FormProfitDaily      (int Month = 0)
        {
            InitializeComponent();
            this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
            if (Month > 0)
            {
                ms_mah.SelectedIndex = 13 - Month;
            }
            else
            {
                var mah = new MS_Structure_Shamsi(DateTime.Now)._Mah;
                ms_mah.SelectedIndex = 13 - mah;
            }

            ms_mah.SelectedTabChanged += (sender, args) => RefreshGrid();
        }

        private void RefreshGrid            ()
        {
            try
            {
                var Month = ms_mah.SelectedIndex == 0
                                ? (null)
                                : (int?) (13 - ms_mah.SelectedIndex);

                var Mgr     = new ReportManager();
                var List    = Mgr
                        .GetReport<ProfitDaily>
                            (new
                                {
                                    Year            = SystemConstant.ActiveYear.Salmali,
                                    KindSale        = (byte)Enums.NzFactorKind.Frosh,
                                    KindSaleBack    = (byte)Enums.NzFactorKind.BargshtFrosh,
                                    MonthNo         = Month,

                            }, null);

                if (List == null)
                    return;

                ms_Grid.DataSource = List.ToList();
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
            }

        }
        private void FormProfitDaily_Shown  (object sender, EventArgs e)
        {
            RefreshGrid();
            mS_Panel1.Height    = 50;
            ms_mah.Top          = mS_Panel1.Height - 28;
        }

        private void ms_Grid_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (ms_Grid.CurrentRow.DataRow is ProfitDaily row)
            {
                var frm = new FormProfitObject(row.tarikh);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
        }

        private void NzRefresh_Click(object sender, EventArgs e)
        {
            FormProfitDaily_Shown(sender, e);
        }
    }
}
