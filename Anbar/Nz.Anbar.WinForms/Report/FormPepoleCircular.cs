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
using MS_Control.MainForms;
using MS_Control.Tarikh;
using MS_Print_Dialog;
using Nz.Anbar.Model.Report;
using Nz.Anbar.WinForms.App;
using NZ.Anbar.Business;
using ShareLib;
using ShareLib.Models;
using ShareLib.Utils;
using ShareLib.ViewModel;

namespace Nz.Anbar.WinForms.Report
{
    public partial class FormPepoleCircular : Form
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        private IEnumerable<PeopleCircularDetail>   _ListDetail;
        private IEnumerable<PeopleMiscMount>        _ListMisc;
        private People                              _Customer;
        #endregion
        #region Constructor
        public FormPepoleCircular   (long ID=0)
        {
            InitializeComponent();
            NzCustomer.Refresh_Grid((byte)3,null, null);
            if (ID > 0)
            {
                NzCustomer.MS_Set_Select(ID);
                NzReport.PerformClick();
            }
        }
        #endregion
        #region Methods
        private bool    IsOK                            ()
        {
            if (NzCustomer.MS_Get_Selected() == null)
            {
                mS_Notify1.Show(NzCustomer);
                return false;
            }
            if (NzDateFrom.MS_Tarikh.HasValue)
            {
                var date = NzDateFrom.MS_Tarikh.Value.ToDatetime().Date;
                if (!Utility.IsDateTruth(date, SystemConstant.ActiveYear))
                {
                    MS_Message.Show("تاریخ شروع مورد نظر در محدوده سال مالی نیست");
                    mS_Notify1.Show(NzDateFrom);
                    return false;
                }
            }

            return true;
        }
        #endregion
        
        private void    NzReport_Click                  (object sender, EventArgs e)
        {
            try
            {
                if(!IsOK())
                    return;

                DateTime? DateFrom  = null;
                DateTime? DateTo    = null;

                if (NzDateFrom.MS_Tarikh.HasValue)
                    DateFrom    = NzDateFrom.MS_Tarikh.Value.ToDatetime().Date;

                if (NzDateTo.MS_Tarikh.HasValue)
                    DateTo      = NzDateTo.MS_Tarikh.Value.ToDatetime().Date;

                _Customer       = ((People) NzCustomer.MS_Get_Selected());


                var Mgr         = new ReportManager();



                _ListDetail     = Mgr.GetReport<PeopleCircularDetail>(new
                {
                    People      =_Customer.ID,
                    Year        = SystemConstant.ActiveYear.Salmali,
                    DateFrom    ,
                    DateTo      ,

                }, null);

                _ListMisc       = Mgr.GetReport<PeopleMiscMount>(new
                {
                    People      = _Customer.ID,
                    Year        = SystemConstant.ActiveYear.Salmali,
                    DateFrom    ,
                    DateTo      ,

                }, null);


                NzGrid.DataSource   = _ListDetail.ToList();
                NzGridMisc.Visible  =  
                Splitter1.Visible   = _ListMisc.Any();

                //if (NzGridMisc.Visible)
                    NzGridMisc.DataSource = _ListMisc.ToList();

            }
            catch (Exception ex)
            {
                log.Error(ex);
                MS_Message.Show("خطا در خواندن اطلاعات", "خطا", ex.Message, MessageBoxButtons.OK);
            }
        }
        private void    NzGrid_ColumnButtonClick        (object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (NzGrid.CurrentRow.DataRow is PeopleCircularDetail row)
            {
                var kind = (Enums.NzFactorKind)row.kind;

                if (kind == Enums.NzFactorKind.HavaleZayeat || kind == Enums.NzFactorKind.HavaleMasrafi)
                    new Form_Transfer(row.IDTitle, kind).ShowDialog();
                else if (kind == Enums.NzFactorKind.AvalDore)
                {
                    var frm         = new Form_InitialStock(row.ID);
                    frm.MdiParent   = this.MdiParent;
                    frm.Show();
                }
                else
                    new Form_Purchase(row.IDTitle, kind).ShowDialog();
            }
        }
        private void    NzCustomer_MSOnRowSelected      (object sender, MS_Control.TSDD.On_Selected e)
        {
            NzReport.PerformClick();
            if (NzCustomer.MS_Get_Selected() == null)
                NzCustomerRemain.Text = "";
            else
            {
                var tmp = NzCustomer.MS_Get_Selected() as People;
                NzCustomerRemain.NzSetCustoemr(tmp?.ID ?? 0);
            }
        }
        private void    NzGridMisc_ColumnButtonClick    (object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            if (NzGridMisc.CurrentRow.DataRow is PeopleMiscMount row)
            {
                var kind = (Enums.NzFactorKind)row.kind;

                if (kind == Enums.NzFactorKind.HavaleZayeat || kind == Enums.NzFactorKind.HavaleMasrafi)
                    new Form_Transfer(row.ID, kind).ShowDialog();
                else if (kind == Enums.NzFactorKind.AvalDore)
                {
                    var frm = new Form_InitialStock(row.ID);
                    frm.MdiParent = this.MdiParent;
                    frm.Show();
                }
                else
                    new Form_Purchase(row.ID, kind).ShowDialog();
            }
        }
        private void    NzPrint_Click                   (object sender, EventArgs e)
        {
            var path        = Utility.GetPrintDirectory()+ "\\Anbar\\PeopleCircular.mrt";
            var PrnDiag     = new Print_Dialog(path, "List1", _ListDetail);
            PrnDiag.Set_DataSource("List2",_ListMisc);
            var people      = _Customer;

            PrnDiag.Set_Variable("tarikh"           , new MS_Structure_Shamsi(DateTime.Now).ToShamsi());
            PrnDiag.Set_Variable("User"             , SystemConstant.ActiveUser.title);
            PrnDiag.Set_Variable("Company"          , SystemConstant.ActiveCompany.title);
            PrnDiag.Set_Variable("Name"             , people?.title);
            PrnDiag.Set_Variable("Address"          , people?.addressHome);
            PrnDiag.Set_Variable("CodeMeli"         , people?.codeMeli);
            PrnDiag.Set_Variable("Mobile"           , people?.mobile);
            PrnDiag.Set_Variable("Tel"              , people?.tel);

            PrnDiag.ShowDialog(this);
        }

    }
}
