using Janus.Windows.GridEX;
using MS_Control;
using NZ.General.WinForms.Report;
using ShareLib.Utils;
using ShareLib.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nz.Bar.Business;
using Nz.Bar.Model.Report;
using ShareLib.Models;

namespace Nz.Bar.Winforms.Report
{
	public partial class FormKholaseVaziatKarxaneh : Form
	{
		#region Logging
		private static readonly log4net.ILog log =
			log4net
				.LogManager
				.GetLogger
					(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		#endregion
		#region Fields
        
		#endregion
		#region Constructor
		public FormKholaseVaziatKarxaneh()
		{
			InitializeComponent();
			this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
			NzGroup.Refresh_Grid((object)null);
		}
		#endregion
	 #region Methods
        private void RefreshGrid    ()
        {
            try
            {
	            var rpt         = new ReportManager();
                var AzTarikh    = NzDateFrom.MS_Tarikh?.ToDatetime();
                var TaTarikh    = NzDateTo.MS_Tarikh?.ToDatetime();
                var Group       = NzGroup.MS_Get_Selected() as PeopleGroup;
                var list        = rpt.GetReport<RemaindKarkhane>(new { AzTarikh,TaTarikh,Year = SystemConstant.ActiveYear.Salmali,Group = Group.ID}, null);

                NzGrid.DataSource = list;
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);

            }
        }
        private void ShowDetail     ()
        {
            if(NzGrid.CurrentRow==null || NzGrid.CurrentRow.RowType != RowType.Record)
                return;

            var Row = NzGrid.CurrentRow.DataRow as RemaindPeople;

            var frm = new FormBill(Row.ID);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
        #endregion

       
        private void NzGrid_RowDoubleClick          (object sender, RowActionEventArgs e)
        {
            ShowDetail();
        }
        private void NzGrid_ColumnButtonClick       (object sender, ColumnActionEventArgs e)
        {
            ShowDetail();
        }
        private void ms_Save_Click                  (object sender, EventArgs e)
        {
            RefreshGrid();
        }

		private void NzGroup_MS_On_Row_Selected(object sender, MS_Control.TSDD.On_Selected e)
		{

		}
	}
}
