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
using MS_Control;
using NZ.Anbar.Business;
using Nz.Anbar.Model.Report;
using Nz.Anbar.WinForms.Provider;
using Nz.Anbar.WinForms.Report;
using ShareLib.Interfaces;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.Alarm
{
    public partial class StorageAlarm : UserControl
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

        private IEnumerable<PointOrder> _List;

        public StorageAlarm()
        {
            InitializeComponent();
        }

        public void         RefreshList     ()
        {
            try
            {
                var Mgr     = new ReportManager();
                _List       = Mgr.GetReport<PointOrder>
                (new
                    {
                        Year = SystemConstant.ActiveYear.Salmali
                    }, null
                );

                if (_List.Any())
                {
                    _List = _List.Where(x => x.Remaind <= x.point_bohrani).ToList();
                    NzTabAlarm.Text += " [ " + _List.Count() + " ]";
                }


            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        public bool         AnyAlarm        ()
        {
            //RefreshList();
            return _List.Any();
        }
        public UITabPage    GetTabPage      ()
        {
            NzGrid.DataSource = _List?.ToList();
            return NzTabAlarm;
        }

        private void NzGrid_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (NzGrid.CurrentRow.DataRow is PointOrder row)
            {
                var frm         = new FormCircularObject(row.Code);
                frm.MdiParent   =  StorageProvider.MainForm;
                frm.Show();
            }
        }
    }
}
