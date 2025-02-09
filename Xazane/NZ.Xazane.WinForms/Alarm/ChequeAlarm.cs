using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janus.Windows.UI.Tab;
using NZ.Xazane.Business;
using NZ.Xazane.Model.Report;
using ShareLib.Interfaces;

namespace NZ.Xazane.WinForms.Alarm
{
    public partial class ChequeAlarm : UserControl
    {
        private IEnumerable<UsentCheque> _List;
        public ChequeAlarm()
        {
            InitializeComponent();
        }

        public void RefreshList()
        {
            var mgr = new ReportManager();
            _List =  mgr.GetReport<UsentCheque>(null,"=0");

            NzTabAlarm.Text += @" [ " + _List.Count() + @" ]";

        }

        public bool AnyAlarm()
        {
            return _List.Any();
        }

        public UITabPage GetTabPage()
        {
            NzGridFuture.DataSource = _List?.ToList();
            return NzTabAlarm;
        }

        private void NzRefresh_Click(object sender, EventArgs e)
        {
            var mgr     = new ReportManager();
            _List       = mgr.GetReport<UsentCheque>(null, " <= " + NzFutureDays.Text + @" AND DATEDIFF(DAY,GETDATE(),tac.tarikh_sar_resid)>=0");
            NzGridFuture.DataSource = _List?.ToList();
        }
    }
}
