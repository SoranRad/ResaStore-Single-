using Nz.Aqsat.Business;
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
using NZ.Aqsat.Business;
using Nz.Aqsat.Model.Models;
using Nz.Aqsat.Model.Report;
using Nz.Aqsat.Winforms.App;

namespace Nz.Aqsat.Winforms.Report
{
    public partial class FormAqsatMoedGozashteAshxas : Form
    {
	    private bool _DoRefresh = true;


		public FormAqsatMoedGozashteAshxas()
        {
            InitializeComponent();
        }

        private void RefreshGrid()
        {

	        var mgr = new ReportManager();

			var list =
				mgr.GetReport<AqsatMoedGozashteAshxas>(null, null);

	        _DoRefresh = false;
	        NzGridHeads.DataSource = list?.ToList();
	        _DoRefresh = true;

	        if (NzItems.Checked)
		        RefreshItem();

	        NzGridHeads.MoveFirst();
        }
        private void RefreshItem()
        {
	        if (!_DoRefresh)
		        return;

	        if (NzGridHeads.CurrentRow == null || NzGridHeads.CurrentRow.RowType != RowType.Record)
		        return;

	        var dataRow = NzGridHeads.CurrentRow.DataRow as AqsatMoedGozashteAshxas;

	        var mgr = new ReportManager();
	        var list = mgr.GetReport<AqsatMoedGozashte>(null, " AND tam.FK_Shaxs ="+ dataRow.FK_Shaxs);

			mS_GridX1.DataSource = list?.ToList();
		}

		private void NzItems_Click(object sender, EventArgs e)
        {
	        Splitter1.Visible = NzItems.Checked;
	        mS_Panel2.Visible = NzItems.Checked;

	        if (NzItems.Checked)
		        RefreshItem();
        }

        private void NzRefreshList_Click(object sender, EventArgs e)
        {
			RefreshGrid();
        }

        private void FormAqsatMoedGozashteAshxas_Load(object sender, EventArgs e)
        {
			RefreshGrid();
        }

        private void NzGridHeads_SelectionChanged(object sender, EventArgs e)
        {
			if (NzItems.Checked)
				RefreshItem();
		}

        private void mS_GridX1_ColumnButtonClick(object sender, ColumnActionEventArgs e)
        {
	        var dataRow = mS_GridX1.CurrentRow.DataRow as AqsatMoedGozashte;

	        new Form_TasviehAqsat(dataRow.FK_Main, dataRow.ID).ShowDialog(this);

	        RefreshGrid();

		}
	}
}
