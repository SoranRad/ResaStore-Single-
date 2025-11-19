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
using MS_Control.TSDD;
using Nz.Anbar.Model.Report;
using Nz.Anbar.WinForms.App;
using NZ.Anbar.Business;
using NZ.Anbar.Model;
using Nz.Anbar.Model.Report.Profit;
using ShareLib;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.Report.Profit
{
    public partial class FormProfitMonthly : Form
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        public FormProfitMonthly()
        {
            InitializeComponent();
            this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
            NzAnbar.Refresh_Anbar();
            NzAnbar.MS_On_Row_Selected += NzAnbarOnMS_On_Row_Selected;
        }
        
        private void NzAnbarOnMS_On_Row_Selected(object sender, On_Selected e)
        {
	        NzCirculr.PerformClick();
        }

        private void FormProfitMonthly_Load(object sender, EventArgs e)
        {
	        NzCirculr.PerformClick();
        }

        private void ms_Grid_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (ms_Grid.CurrentRow.DataRow is ProfitMonthly row)
            {
                var frm = new FormProfitDaily(row.PersianMonthNo);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
        }

        private void NzRefresh_Click(object sender, EventArgs e)
        {
            FormProfitMonthly_Load(sender, e);
        }

		private void NzCirculr_Click(object sender, EventArgs e)
		{
			try
			{
				if (NzAnbar.MS_Get_Selected() == null)
				{
					NzAnbar.Focus();
					return;
				}
				var storages= NzAnbar.MS_Get_Selected() as Storage[];
				var Anbars  = storages.Select(x => x.ID).ToArray();

				var Mgr     = new ReportManager();
				var List    = Mgr
					.GetReport<ProfitMonthly>
					(new
						{
							Year            = SystemConstant.ActiveYear.Salmali,
							KindSale        = (byte)Enums.NzFactorKind.Frosh,
							KindSaleBack    = (byte)Enums.NzFactorKind.BargshtFrosh,
							Anbars 
						}, 
						null);

				if(List == null)
					return;

				ms_Grid.DataSource = List.ToList();
			}
			catch (Exception ex)
			{
				log.Error(ex);
				MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
			}
		}
	}
}
