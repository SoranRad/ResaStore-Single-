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
using NZ.General.Business;
using ShareLib.Interfaces;
using ShareLib.Models.Report;

namespace NZ.General.WinForms.Alarm
{
    public partial class NoteDailyAlarm : UserControl
    {
        private IEnumerable<NoteOfDate> _List;
        public NoteDailyAlarm   ()
        {
            InitializeComponent();
        }

        public void         RefreshList     ()
        {
            var mgr = new ReportManager();
            _List = mgr
                .GetReport<NoteOfDate>
                (new
                    {
                        DateTime.Now.Date
                    },null
                )?.ToList();

            NzTabAlarm.Text += @" [ " + _List.Count() + @" ]";
        }
        public bool         AnyAlarm        ()
        {
            return _List.Any();
        }
        public UITabPage    GetTabPage      ()
        {
            NzGrid.DataSource = _List?.ToList();
            return NzTabAlarm;
        }
    }
}
