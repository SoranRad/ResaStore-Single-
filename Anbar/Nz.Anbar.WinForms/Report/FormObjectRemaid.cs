using System;
using System.Linq;
using System.Windows.Forms;
using MS_Control;
using Nz.Anbar.Model.Report;
using NZ.Anbar.Business;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.Report
{
    public partial class FormObjectRemaid : Form 
    {
                
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        private string _ObjectTitle = "";
        #region Constractor
        public FormObjectRemaid     ()
        {
            InitializeComponent();
            this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
        }
        #endregion

        private void ms_Grid_ColumnButtonClick    (object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (ms_Grid.CurrentRow.DataRow is ObjectRemaind row )
            {
                var frm         = new FormCircularObject(row.Code);
                frm.MdiParent   = this.MdiParent;
                frm.Show();
            }
            else if (ms_Grid.CurrentRow.DataRow is ObjectRemaindOnDate row1)
            {
                var frm = new FormCircularObject(row1.Code);
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
        }
        private void mS_GridX_Setting1_MS_On_Print_Clicked(object sender, EventArgs e)
        {
            mS_GridX_Setting1.FillParametter(this.Text + "(" + _ObjectTitle + ")");
        }
        private void FormObjectRemaid_Shown       (object sender, EventArgs e)
        {
            
            try
            {
                var Mgr = new ReportManager();
                var List = Mgr.GetReport<ObjectRemaind>(new {Year=SystemConstant.ActiveYear.Salmali},null);

                ms_Grid.DataSource = List?
                    .ToList();
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
            }
        }
        private void NzRefresh_Click              (object sender, EventArgs e)
      {
          FormObjectRemaid_Shown(sender, e);
      }
        private void NzCirculr_Click              (object sender, EventArgs e)
        {
            try
            {
                if (!NzDate.MS_Tarikh.HasValue)
                {
                    MSMessage.Show("تاریخ را وارد کنید");
                    NzDate.Focus();
                    return;
                }

                var date = NzDate.MS_Tarikh.Value.ToDatetime().Date;
                if (date > SystemConstant.ActiveYear.EndDate || date < SystemConstant.ActiveYear.StartDate)
                {
                    MSMessage.Show("تاریخ در بازه سال مالی فعال قرار ندارد"+"\n"
                    +"بازه درست بین "+ SystemConstant.ActiveYear.StartDateFa + " تا تاریخ "+
                    SystemConstant.ActiveYear.EndDateFa +" می باشد");
                    NzDate.Focus();
                    return;
                }

                var Mgr = new ReportManager();
                var List = Mgr.GetReport<ObjectRemaindOnDate>
                    (new
                    {
                        Year    = SystemConstant.ActiveYear.Salmali,
                        Tarikh  = date
                    }, null);

                ms_Grid.DataSource = List?.ToList();
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
            }
        }
    }
}
