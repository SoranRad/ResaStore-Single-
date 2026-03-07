using Janus.Windows.GridEX;
using Nz.Aqsat.Business;
using Nz.Aqsat.Model.Models;
using Nz.Aqsat.Model.Report;
using Nz.Aqsat.Winforms.App;
using Nz.Aqsat.Winforms.sms;
using NZ.Aqsat.Business;
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

namespace Nz.Aqsat.Winforms.Report
{
    public partial class FormSarResidAqsat : Form
    {
	    private bool _DoRefresh = true;
	    private bool _CancelJob = false;

		public FormSarResidAqsat()
        {
            InitializeComponent();
        }
        public void RefreshList()
        {
	        var mgr = new ReportManager();
	        var list = mgr.GetReport<SarResidAqsat>(new { ruz = 0 }, null);

	        _DoRefresh = false;
			NzGridFuture.DataSource = list.ToList();
			_DoRefresh = true;

			if (NsDetail.Checked)
				RefreshItem();
		}
        private void RefreshItem()
        {
	        if (!_DoRefresh)
		        return;

	        if (NzGridFuture.CurrentRow == null || NzGridFuture.CurrentRow.RowType != RowType.Record)
		        return;

	        var dataRow = NzGridFuture.CurrentRow.DataRow as SarResidAqsat;

	        var mgr = new AqsatManager();
	        var aqsat = mgr.GetItem(dataRow.FK_Main);


	        NzGridItems.DataSource = aqsat.AqsatRizs?.OrderBy(x => x.Radif)?.ToList();
        }

		private void NsRefresh_Click(object sender, EventArgs e)
        {
	        RefreshList();
        }

        private void FormAqsatMoedGozashte_Load(object sender, EventArgs e)
        {
	        RefreshList();
        }

        private async void mS_GridX1_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
	        var dataRow = NzGridFuture.CurrentRow.DataRow as SarResidAqsat;

	        if (e.Column.Key == "C")
	        {
		        new Form_TasviehAqsat(dataRow.FK_Main, dataRow.ID).ShowDialog(this);
		        RefreshList();
			}
	        else
	        {
		        var cell = NzGridFuture.CurrentRow.Cells["S"]; 

		        var msg = new Messaging();

		        await msg.SendSarResidQest(
			        cell,
			        Convert.ToInt64(dataRow.Mobile),
			        dataRow.Shaxs,
			        dataRow.Radif.ToString(),
			        dataRow.KindTitle,
			        dataRow.TarixSarResid,
			        dataRow.mablaqQest.ToString("N")
		        );
			}
	        
        }

		private void NsDetail_CheckedChanged(object sender, EventArgs e)
		{
			NzGridItems.Visible = Splitter1.Visible = NsDetail.Checked;

			if (NsDetail.Checked)
				RefreshItem();
		}

		private void NzGridFuture_SelectionChanged(object sender, EventArgs e)
		{
			if (NsDetail.Checked)
				RefreshItem();
		}
		private async void NzGridItems_ColumnButtonClick(object sender, ColumnActionEventArgs e)
		{
			var dataRow = NzGridItems.CurrentRow.DataRow as Aqsat_Riz;

			if (e.Column.Key == "R")
			{
				new Form_TasviehAqsat(dataRow.FK_Main, dataRow.ID).ShowDialog(this);
				RefreshItem();
			}
			else if (e.Column.Key == "S")
			{
				if (dataRow.isPardaxt)
					return;

				var cell = NzGridItems.CurrentRow.Cells["S"];
				var qest = NzGridFuture.CurrentRow.DataRow as SarResidAqsat;

				var msg = new Messaging();

				await msg.SendSarResidQest(
					cell,
					Convert.ToInt64(qest.Mobile),
					qest.Shaxs,
					dataRow.Radif.ToString(),
					qest.KindTitle,
					dataRow.PersianTarixQest,
					dataRow.mablaqQest.ToString("N")
				);
			}
		}

		private async void NsMessage_Click(object sender, EventArgs e)
		{
			if (!NzGridFuture.GetCheckedRows().Any())
			{
				MS_Message.Show("یک یا چند ردیف را انتخاب کنید");
				return;
			}

			_CancelJob				= false;
			NsDetail.Checked		= NzGridFuture.Enabled = NsMessage.Visible = false ;
			NsProgress.Visible		= NsProgressText.Visible = NsCancel.Visible = true;
			NsProgress.Maximum		= NzGridFuture.GetCheckedRows().Count();
			NsProgress.Minimum		= 0;
			NsProgress.Value		= 0;
			NsProgressText.Text		= @"0 \ " + NsProgress.Maximum;

			foreach (var row in NzGridFuture.GetCheckedRows())
			{
				var dataRow			= row.DataRow as SarResidAqsat;
				var cell			= row.Cells["S"];
				var msg				= new Messaging();

				await msg.SendSarResidQest(
					cell,
					Convert.ToInt64(dataRow.Mobile),
					dataRow.Shaxs,
					dataRow.Radif.ToString(),
					dataRow.KindTitle,
					dataRow.TarixSarResid,
					dataRow.mablaqQest.ToString("N")
				);

				NsProgress.Value ++;
				NsProgressText.Text = NsProgress.Value+  @" \ " + NsProgress.Maximum;
				if(_CancelJob )
					break;
			}
		}

		private void NsCancel_Click(object sender, EventArgs e)
		{
			_CancelJob = true;

			NzGridFuture.Enabled = true;
			NsProgress.Visible = NsProgressText.Visible = NsCancel.Visible = false;
			NsMessage.Visible = true;

		}
	}
}
