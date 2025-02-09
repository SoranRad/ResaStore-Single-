using NZ.Anbar.Business;
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
using Nz.Anbar.Model.Report;
using Nz.Anbar.WinForms.App;
using ShareLib;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.Report
{
    public partial class Form_CircularOfLocation : Form
    {
       #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        private string _ObjectTitle = "";
        #region Constructor
        public Form_CircularOfLocation               ()
        {
            InitializeComponent();
            this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
            NzLocation.RefreshItems(true);
        }
        #endregion
        private void NzLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            NzReport.PerformClick();
        }
        private void NzReport_Click             (object sender, EventArgs e)
        {

            DateTime? TarixAz = null, TarixTa = null;

            if (NzDateFrom.MS_Tarikh.HasValue)
                TarixAz = NzDateFrom.MS_Tarikh.Value.ToDatetime().Date;

            if (NzDateTo.MS_Tarikh.HasValue)
                TarixTa = NzDateTo.MS_Tarikh.Value.ToDatetime().Date;


            var location = NzLocation.GetLocation();
            try
            {
                var Mgr     = new ReportManager();
                var List    = Mgr.GetReport<CircularOfLocation>(new
                {
                    Year        = SystemConstant.ActiveYear.Salmali,
                    Location    = location?.ID,
                    Kind        = (byte)Enums.NzFactorKind.Frosh,
                    TarixAz,
                    TarixTa,

                },null);

                ms_Grid.DataSource = List?
                                        .OrderBy(x => x.PersianStr)
                                        .ToList();
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
            }
        }


        private void ms_Grid_ColumnButtonClick  (object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (ms_Grid.CurrentRow.DataRow is CircularOfLocation row)
            {

                new Form_Purchase(row.IDTitle, Enums.NzFactorKind.Frosh).ShowDialog();
            }
        }
        private void mS_GridX_Setting1_MS_On_Print_Clicked(object sender, EventArgs e)
        {
            mS_GridX_Setting1.FillParametter(this.Text+"("+_ObjectTitle+")");
        }

       
    }
}
