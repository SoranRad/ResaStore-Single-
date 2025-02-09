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
using Nz.Anbar.Model.Report;
using Nz.Anbar.WinForms.App;
using NZ.Anbar.Business;
using ShareLib;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.Report
{
    public partial class FormAllCircular : Form
    {

        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        public FormAllCircular()
        {
            InitializeComponent();
            this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
        }

        private void FormAllCircular_Shown(object sender, EventArgs e)
        {
            try
            {
                var Mgr = new ReportManager();
                var List = Mgr
                    .GetReport<AllCircular>
                    (new
                    {
                        Year = SystemConstant.ActiveYear.Salmali,
                        Kind = (byte)Enums.NzObjectKind.Object,
                    }, null);

                ms_Grid.DataSource = List?.ToList();
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
            }
        }

        private void ms_Grid_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (ms_Grid.CurrentRow.DataRow is AllCircular row)
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

        private void mS_GridX_Setting1_MS_On_Print_Clicked(object sender, EventArgs e)
        {
            mS_GridX_Setting1.FillParametter(this.Text);
        }

        private void NzRefresh_Click(object sender, EventArgs e)
        {
            FormAllCircular_Shown(sender, e);
        }
    }
}
