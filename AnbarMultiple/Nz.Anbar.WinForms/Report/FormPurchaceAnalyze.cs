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
using Nz.Anbar.Model.ViewModel;
using ShareLib;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.Report
{
    public partial class FormPurchaceAnalyze : Form
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        public FormPurchaceAnalyze()
        {
            InitializeComponent();
            this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
            NzFactors.Refresh_Grid();
        }

        private void RefreshGrid()
        {
            try
            {
                var factor = NzFactors.MS_Get_Selected() as FactorHeads;
                if(factor ==  null)
                    return;

                var Mgr = new ReportManager();
                var List = Mgr
                    .GetReport<PurchaceAnalyze>
                    (new
                    {
                        factor.ID,

                    }, null);

                ms_Grid.DataSource = List?.ToList();
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
            }
        }

        private void NzReport_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void NzFactors_MS_On_Row_Selected(object sender, MS_Control.TSDD.On_Selected e)
        {
            RefreshGrid();
        }

        private void NzRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
