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
using NZ.Anbar.Business;
using NZ.Anbar.Model;
using ShareLib;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.Report
{
    public partial class FormCircularObject : Form
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
        public FormCircularObject               (int  Code= 0)
        {
            InitializeComponent();
            this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
            NzObjectSelection.Refresh_Grid((object)null);

            if (Code != 0)
            {
                NzObjectSelection.MS_Set_Select(Code);
                NzReport.PerformClick();
            }
        }
        #endregion

        private void NzObjectRow_Selected       (object sender, MS_Control.TSDD.On_Selected e)
        {
            NzReport.PerformClick();
        }
        private void NzReport_Click             (object sender, EventArgs e)
        {
            if(NzObjectSelection.MS_Get_Selected()==null)
                return;

            DateTime? DateFrom = null, DateTo = null;

            if (NzDateFrom.MS_Tarikh.HasValue)
                DateFrom = NzDateFrom.MS_Tarikh.Value.ToDatetime().Date;

            if (NzDateTo.MS_Tarikh.HasValue)
                DateTo = NzDateTo.MS_Tarikh.Value.ToDatetime().Date;

            var NzObject = NzObjectSelection.MS_Get_Selected() as NzObject;
            _ObjectTitle = NzObject.title;
            try
            {
                var Mgr = new ReportManager();
                var List = Mgr.GetReport<CircularObject>(new
                {
                    Year = SystemConstant.ActiveYear.Salmali,
                    NzObject.Code,
                    DateFrom,
                    DateTo,

                },null);

                ms_Grid.DataSource = List?
                                        .OrderBy(x => x.tarikh)
                                        .ToList();
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
            }
        }

        private void FormCircularObject_Shown   (object sender, EventArgs e)
        {
            NzObjectSelection.Focus();
        }
        private void FormCircularObject_KeyUp   (object sender, KeyEventArgs e)
        {
            if(e.KeyCode== Keys.F4)
                NzReport.PerformClick();
        }

        private void ms_Grid_ColumnButtonClick  (object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (ms_Grid.CurrentRow.DataRow is CircularObject row)
            {
                var kind = (Enums.NzFactorKind) row.kind;

                if (kind == Enums.NzFactorKind.HavaleZayeat || kind == Enums.NzFactorKind.HavaleMasrafi)
                    new Form_Transfer(row.IDTitle, kind).ShowDialog();
                else if (kind == Enums.NzFactorKind.AvalDore)
                {
                    var frm = new Form_InitialStock(row.ID);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else if(kind==Enums.NzFactorKind.BargshtFrosh)
                    new Form_SaleBack(row.IDTitle, kind).ShowDialog(this);

                else if (kind == Enums.NzFactorKind.Frosh)
                    new Form_SelectSaleFactor(row.IDTitle).ShowDialog(this);
                else
                    new Form_Purchase(row.IDTitle, kind).ShowDialog();
            }
        }
        private void mS_GridX_Setting1_MS_On_Print_Clicked(object sender, EventArgs e)
        {
            mS_GridX_Setting1.FillParametter(this.Text+"("+_ObjectTitle+")");
        }
    }
}
