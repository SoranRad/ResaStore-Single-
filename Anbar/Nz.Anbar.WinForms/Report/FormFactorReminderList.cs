using MS_Control;
using MS_Control.Tarikh;
using Nz.Anbar.Model.Report;
using Nz.Anbar.Model.ViewModel;
using NZ.Anbar.Business;
using ShareLib;
using ShareLib.Utils;
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
using Nz.Anbar.WinForms.App;
using ShareLib.ViewModel;

namespace Nz.Anbar.WinForms.Report
{
    public partial class FormFactorReminderList : Form
    {
	    #region Logging
	    private static readonly log4net.ILog log =
		    log4net
			    .LogManager
			    .GetLogger
			    (System
				    .Reflection
				    .MethodBase
				    .GetCurrentMethod()
				    .DeclaringType);
	    #endregion
		public FormFactorReminderList()
        {
            InitializeComponent();
            NzDateFrom.MS_Tarikh = new MS_Structure_Shamsi(DateTime.Now);
        }

        private void RefreshGrid()
        {
	        try
	        {
		        var Mgr = new ReportManager();
		        NzGridHeads.DataSource = Mgr.GetReport<FactorReminderList>
		        (new
			        {
				        Year = SystemConstant.ActiveYear.Salmali,
				        Tarikh = NzDateFrom.MS_Tarikh.Value.ToDatetime().Date
			        }, null
		        );
	        }
	        catch (Exception ex)
	        {
		        log.Error(ex);
		        MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
	        }
		}

        private void FormFactorReminderList_Load(object sender, EventArgs e)
        {
	        RefreshGrid();
        }

        private void NzReport_Click(object sender, EventArgs e)
        {
	        RefreshGrid();

		}
        private void LoadPaymentList()
        {
			var row = NzGridHeads.CurrentRow.DataRow as FactorReminderList;
			var kid = ((Enums.NzFactorKind)row.kind);

			var kind = Enums.FormOperation.FactorPaymentList;
	        var Msg = new FactorPaymentMessage()
	        {
		        Kind = (byte)kid < 50
			        ? Enums.NzPaymentOperatingKind.Pardaxt
			        : Enums.NzPaymentOperatingKind.Daryaft,
		        Description = "بابت تسویه فاکتور " + row.Serial,
		        IDFactor = row.ID,
		        IDPeople = row.FK_AshXas_ID ?? 0,
		        Amount = row.mablaq,
	        };

	        var frm = Form_Factory._Form_Factory_Xazaneh.GetFormForEdit(kind, Msg);

	        frm?.Set_Form_Param(Msg);
	        (frm as Form)?.ShowDialog(this);

	        RefreshGrid();


        }
		private void EditFactor()
        {
	        if (NzGridHeads.CurrentRow.RowType != RowType.Record)
		        return;
	        var row = NzGridHeads.CurrentRow.DataRow as FactorReminderList;
	        var kid = ((Enums.NzFactorKind)row.kind);
			var ID = Convert.ToInt64(NzGridHeads.CurrentRow.Cells["ID"].Value);

	        if (   kid == Enums.NzFactorKind.PishFaktor
	            || kid == Enums.NzFactorKind.Xarid
	            || kid == Enums.NzFactorKind.BargashXarid
				|| kid == Enums.NzFactorKind.Frosh
			   )
			{
		       new Form_Purchase( ID , kid).ShowDialog(this);
	        }

	        else if (kid == Enums.NzFactorKind.BargshtFrosh)
		        new Form_SaleBack( ID , kid).ShowDialog(this);
	        

	       
	        RefreshGrid();

	        

        }
		private void NzGridHeads_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
			switch (e.Column.Key)
			{
				case "E":
					EditFactor();
					break;
				
				case "P":
					LoadPaymentList();
					break;
			}
		}
    }
}
