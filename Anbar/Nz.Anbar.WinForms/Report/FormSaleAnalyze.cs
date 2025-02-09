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
using NZ.Anbar.Business;
using Nz.Anbar.Model.Report;
using Nz.Anbar.WinForms.App;
using ShareLib;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.Report
{
    public partial class FormSaleAnalyze : Form
    {

        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        private bool _DoRefresh = true;
        public FormSaleAnalyze()
        {
            InitializeComponent();
            this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
        }

        private void    FormAllCircular_Shown                   (object sender, EventArgs e)
        {
            try
            {
                var Mgr = new ReportManager();
                var Year = NzCurrentYear.Checked
                    ? (short?) SystemConstant.ActiveYear.Salmali
                    : null;

                var List = Mgr
                    .GetReport<SaleAnalyze>
                    (new
                    {
                        Year,
                        KindFrosh           = (byte)Enums.NzFactorKind.Frosh,
                        KindBargashtFrosh   = (byte)Enums.NzFactorKind.BargshtFrosh,
                    }, null);

                ms_Grid.DataSource = List?.ToList();
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
            }
        }
        private void    ms_Grid_ColumnButtonClick               (object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (ms_Grid.CurrentRow.DataRow is SaleAnalyze row)
            {
                var kind = (Enums.NzFactorKind)row.KindHead;

                if (kind == Enums.NzFactorKind.HavaleZayeat || kind == Enums.NzFactorKind.HavaleMasrafi)
                    new Form_Transfer(row.IDHead, kind).ShowDialog();
                else if (kind == Enums.NzFactorKind.AvalDore)
                {
                    var frm = new Form_InitialStock(row.IDItem);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else if (kind == Enums.NzFactorKind.BargshtFrosh)
                    new Form_SaleBack(row.IDHead, kind).ShowDialog(this);

                else if (kind == Enums.NzFactorKind.Frosh)
                    new Form_SelectSaleFactor(row.IDHead).ShowDialog(this);
                else
                    new Form_Purchase(row.IDHead, kind).ShowDialog();
            }
        }
        private void    mS_GridX_Setting1_MS_On_Print_Clicked   (object sender, EventArgs e)
        {
            mS_GridX_Setting1.FillParametter(this.Text);
        }
        private void    NzRefresh_Click                         (object sender, EventArgs e)
        {
            FormAllCircular_Shown(sender, e);
        }

        private void NzCurrentYear_CheckedChanged_1 (object sender, EventArgs e)
        {
            if(!_DoRefresh)
                return;
            _DoRefresh = false;

            NzAllYears.Checked = !NzCurrentYear.Checked;

            _DoRefresh = true;
            FormAllCircular_Shown(sender, e);
        }
        private void NzAllYears_CheckedChanged      (object sender, EventArgs e)
        {
            if (!_DoRefresh)
                return;
            _DoRefresh = false;

            NzCurrentYear.Checked = !NzAllYears.Checked;

            _DoRefresh = true;
            FormAllCircular_Shown(sender, e);
        }
    }
}
