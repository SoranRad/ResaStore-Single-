using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janus.Windows.UI.Tab;
using Nz.Aqsat.Business;
using Nz.Aqsat.Model.Models;
using Nz.Aqsat.Model.Report;
using Nz.Aqsat.Winforms.App;

namespace Nz.Aqsat.Winforms.Alarm
{
    public partial class AqsatAlarm : UserControl
    {
	    private IEnumerable<SarResidAqsat> _List;
	    private IEnumerable<AqsatMoedGozashte> _List2;

	    public AqsatAlarm()
        {
            InitializeComponent();
        }
        public void RefreshList()
        {
	        var mgr = new ReportManager();
            _List = mgr.GetReport<SarResidAqsat>(new { ruz = Convert.ToInt16(NzFutureDays.TextBox.Text ?? "0") },null);
            _List2 = mgr.GetReport<AqsatMoedGozashte>(null,null);

            if (_List != null && _List.Any())
				NzTabAlarm.Text += @" [ " + _List.Count() + @" ]";

            if (_List2 != null && _List2.Any())
	            NsMoedTab.Text += @" [ " + _List2.Count() + @" ]";
		}

        public bool AnyAlarm()
        {
	        return _List.Any();
        }

        public IEnumerable<UITabPage> GetTabPage()
        {
	        NzGridFuture.DataSource = _List?.ToList();
	        yield return NzTabAlarm;

	        if (_List2 != null && _List2.Any())
	        {
		        mS_GridX1.DataSource = _List2?.ToList();
		        yield return NsMoedTab;
	        }

		}

		private void NzRefresh_Click(object sender, EventArgs e)
		{
			RefreshList();
		}

        private void NzGridFuture_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
	        var dataRow = NzGridFuture.CurrentRow.DataRow as SarResidAqsat;

	        new Form_TasviehAqsat(dataRow.FK_Main, dataRow.ID).ShowDialog(this);

	        RefreshList();
        }

        private void mS_GridX1_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
	        var dataRow = mS_GridX1.CurrentRow.DataRow as AqsatMoedGozashte;

	        new Form_TasviehAqsat(dataRow.FK_Main, dataRow.ID).ShowDialog(this);

	        RefreshList();
		}
    }
}
