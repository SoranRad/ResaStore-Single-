using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nz.Aqsat.Business;
using Nz.Aqsat.Model.Report;
using Nz.Aqsat.Winforms.App;
using Nz.Aqsat.Winforms.sms;

namespace Nz.Aqsat.Winforms.Report
{
    public partial class FormAqsatMoedGozashte : Form
    {
        public FormAqsatMoedGozashte()
        {
            InitializeComponent();
        }

        public void RefreshList()
        {
	        var mgr = new ReportManager();
	        var list = mgr.GetReport<AqsatMoedGozashte>(null, null);

	        mS_GridX1.DataSource = list.ToList();
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
	        var dataRow = mS_GridX1.CurrentRow.DataRow as AqsatMoedGozashte;
	        if (e.Column.Key == "C")
	        {
		        new Form_TasviehAqsat(dataRow.FK_Main, dataRow.ID).ShowDialog(this);

		        RefreshList();
	        }
	        else
	        {
		        var cell = mS_GridX1.CurrentRow.Cells["S"];

		        var msg = new Messaging();

		        await msg.SendAqsatMande(
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
	}
}
