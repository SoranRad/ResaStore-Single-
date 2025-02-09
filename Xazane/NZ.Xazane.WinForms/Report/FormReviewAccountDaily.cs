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
using MS_Control;
using MS_Control.Tarikh;
using NZ.Xazane.Business;
using NZ.Xazane.Model.Report;
using ShareLib;
using ShareLib.Utils;

namespace NZ.Xazane.WinForms.Report
{
    public partial class FormReviewAccountDaily : Form
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields

        private long _ID;
        #endregion
        public FormReviewAccountDaily(long ID)
        {
            InitializeComponent();
            this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;

            _ID = ID;
            SetCurrentMonth();
            ms_mah.SelectedTabChanged+=MsMahOnSelectedTabChanged;
            RefreshGrid();
        }

        private void SetCurrentMonth            ()
        {
            var mah = new MS_Structure_Shamsi(DateTime.Now)._Mah;
            ms_mah.SelectedIndex = 13 - mah;
        }
        private void RefreshGrid                ()
        {
            try
            {
                var Month = ms_mah.SelectedIndex==0 ?null:(int?)(13 - ms_mah.SelectedIndex);

                var mgr = new ReportManager();
                var list = mgr.GetReport<ReviewAccountDaily>(
                    new
                    {
                        Month,
                        ID = _ID,
                        Year = SystemConstant.ActiveYear.Salmali,
                        Kind = (byte)Enums.NzChequeStateFlag.Vosul
                    }, null);

                NzGrid.DataSource = list?.ToList();
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MS_Message.Show("خطا در خواندن اطلاعات",
                    "خطا",
                    ex.Message,
                    MessageBoxButtons.OK,
                    MSMessage.FarsiMessageBoxIcon.خطا);
            }
        }
        private void MsMahOnSelectedTabChanged  (object sender, TabEventArgs e)
        {
            RefreshGrid();
        }
        private void NzGrid_ColumnButtonClick   (object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (NzGrid.CurrentRow.DataRow is ReviewAccountDaily row)
            {
                var frm = new FormReviewAccountDetail(_ID,row.title,row.Date);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
        }
    }
}
