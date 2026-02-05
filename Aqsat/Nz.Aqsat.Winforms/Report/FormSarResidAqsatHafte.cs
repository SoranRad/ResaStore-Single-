using MS_Control;
using Nz.Aqsat.Business;
using Nz.Aqsat.Model.Report;
using Nz.Aqsat.Winforms.App;
using NZ.General.WinForms.Sms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nz.Aqsat.Winforms.sms;

namespace Nz.Aqsat.Winforms.Report
{
    public partial class FormSarResidAqsatHafte : Form
    {
	    private short WeekCount = 0;
        public FormSarResidAqsatHafte()
        {
            InitializeComponent();
        }

        public void RefreshList()
        {
	        var tarix = DateTime.Now.AddDays(WeekCount * 7).Date;
	        var mgr = new ReportManager();
	        var list = mgr.GetReport<SarResidAqsatHafte>(new { tarix }, null);

	        NzGridFuture.DataSource = list.ToList();
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
	        var qest = NzGridFuture.CurrentRow.DataRow as SarResidAqsatHafte;

	        if (e.Column.Key == "C")
	        {
		        new Form_TasviehAqsat(qest.FK_Main, qest.ID).ShowDialog(this);
		        RefreshList();
			}
	        else
	        { 
		        var cell	= NzGridFuture.CurrentRow.Cells["S"];
		        var msg		= new Messaging();

		        await msg.SendSarResidQest(
			        cell, 
			        Convert.ToInt64(qest.Mobile),
					qest.Shaxs ,
					qest.Radif.ToString(),
					qest.KindTitle,
					qest.TarixSarResid,
					qest.mablaqQest.ToString("N")
				);
			}

	       
        }

        private void NsNextWeek_Click(object sender, EventArgs e)
        {
	        WeekCount++;
            RefreshList();
        }

        private void NsPriorWeek_Click(object sender, EventArgs e)
        {
	        WeekCount--;
	        RefreshList();
		}
    }
}
