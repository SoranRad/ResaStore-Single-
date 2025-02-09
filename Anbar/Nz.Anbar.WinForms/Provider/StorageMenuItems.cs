using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control;
using NZ.Anbar.Business;
using Nz.Anbar.Model.Report;
using Nz.Anbar.WinForms.Base;
using Nz.Anbar.WinForms.App;
using Nz.Anbar.WinForms.Report;
using Nz.Anbar.WinForms.Report.Profit;
using ShareLib;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.Provider
{
    public partial class StorageMenuItems : UserControl
    {

        public StorageMenuItems()
        {
            InitializeComponent();
        }

        public bool ValidationDemoVersion()
        {
            if (!SystemConstant.IsDemo)
                return true;
            
            var Mgr     = new ReportManager();
            var count   = Mgr.GetItem<FactorItemsCount>(new{},null);

            if (count.ItemsCount >= SystemConstant.DemoCount)
            {
                MS_Message.Show("نسخه برنامه شما آزمایشی می باشد لطفا آن را ارتقا دهید", "خطا", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        public void SetMenu()
        {
            //NzBrandMenu.Visible    = false;
            ms_Storage.Visible      = false;
        }

        private void    ms_Unit_Click              ( object sender, EventArgs e)
        {
            var frm         = new FormListUnit();
            frm.MdiParent   = StorageProvider.MainForm;
            frm.Show();
        }
        private void    ms_Storage_Click           (object sender, EventArgs e)
        {
            var frm         = new FormListStorage();
            frm.MdiParent   = StorageProvider.MainForm;
            frm.Show();
        }
        private void    ms_GroupMain_Click         (object sender, EventArgs e)
        {
            var frm         = new FormListMainGroup();
            frm.MdiParent   = StorageProvider.MainForm;
            frm.Show();
        }
        private void    ms_GroupSub_Click          (object sender, EventArgs e)
        {
            var frm         = new FormListSubGroup();
            frm.MdiParent   = StorageProvider.MainForm;
            frm.Show();
        }
        private void    ms_SalesKind_Click         (object sender, EventArgs e)
        {
            var frm         = new FormListSaleKind();
            frm.MdiParent   = StorageProvider.MainForm;
            frm.Show();
        }
        private void    ms_Object_Click            (object sender, EventArgs e)
        {
            var frm         = new FormListObject();
            frm.MdiParent   = StorageProvider.MainForm;
            frm.Show();
        }

        private void    InitialStock_Click         (object sender, EventArgs e)
        {
            if(!ValidationDemoVersion())
                return;

            var frm         = new Form_InitialStock();
            frm.MdiParent   = StorageProvider.MainForm;
            frm.Show();
        }
        private void    NzBuyFactor_Click          (object sender, EventArgs e)
        {
            if(!ValidationDemoVersion())
                return;

            var frm = new Form_Purchase();
            frm.Show(StorageProvider.MainForm);
        }
        private void    NzPurchaseBack_Click       (object sender, EventArgs e)
        {
            if(!ValidationDemoVersion())
                return;


            var frm = new Form_Purchase(0,Enums.NzFactorKind.BargashXarid);
            frm.Show(StorageProvider.MainForm);
        }
        private void    NzPreFactor_Click          (object sender, EventArgs e)
        {
            if(!ValidationDemoVersion())
                return;

            var frm = new Form_Purchase(0, Enums.NzFactorKind.PishFaktor);
            frm.Show(StorageProvider.MainForm);
        }
        private void    NzInvoice_Click            (object sender, EventArgs e)
        {
            if(!ValidationDemoVersion())
                return;

            var frm = new Form_Purchase(0, Enums.NzFactorKind.Frosh);
            frm.Show(StorageProvider.MainForm);
        }
        private void    NzInvoiceBack_Click        (object sender, EventArgs e)
        {
            if(!ValidationDemoVersion())
                return;

            var frm = new Form_SaleBack(0, Enums.NzFactorKind.BargshtFrosh);
            frm.Show(StorageProvider.MainForm);
        }
        private void    NzWaste_Click              (object sender, EventArgs e)
        {
            if(!ValidationDemoVersion())
                return;

            var frm = new Form_Transfer();
            frm.Show(StorageProvider.MainForm);
        }
        private void    NzConsum_Click             (object sender, EventArgs e)
        {
            if(!ValidationDemoVersion())
                return;

            var frm = new Form_Transfer(0,Enums.NzFactorKind.HavaleMasrafi);
            frm.Show(StorageProvider.MainForm);
        }
        private void    NzListFactors_Click        (object sender, EventArgs e)
        {
            var frm         = new Form_ListFactors();
            frm.MdiParent   = StorageProvider.MainForm;
            frm.Show();
        }
        private void    NzPrice_Click              (object sender, EventArgs e)
        {
            var frm         = new FormPriceList();
            frm.MdiParent   = StorageProvider.MainForm;
            frm.Show();
        }
        //=======Reports
        private void    NzObjectCircular_Click     (object sender, EventArgs e)
        {
            var frm         = new FormCircularObject();
            frm.MdiParent   = StorageProvider.MainForm;
            frm.Show();
        }

        private void موجودیکالاToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormObjectRemaid();
            frm.MdiParent = StorageProvider.MainForm;
            frm.Show();
        }

        private void PointOrder_Click(object sender, EventArgs e)
        {
            var frm = new FormPointOrder();
            frm.MdiParent = StorageProvider.MainForm;
            frm.Show();
        }

        private void CircularKala_Click(object sender, EventArgs e)
        {
            var frm = new FormGardeshKoli();
            frm.MdiParent = StorageProvider.MainForm;
            frm.Show();
        }

        private void XolaseTarakonesh_Click(object sender, EventArgs e)
        {
            var frm = new FormPeopleSummaryCircular();
            frm.MdiParent = StorageProvider.MainForm;
            frm.Show();
        }

        private void RizTarakonesh_Click(object sender, EventArgs e)
        {
            var frm = new FormPepoleCircular();
            frm.MdiParent = StorageProvider.MainForm;
            frm.Show();
        }

        private void NzAnalyze_Click(object sender, EventArgs e)
        {
            var frm = new FormAnalyze();
            frm.MdiParent = StorageProvider.MainForm;
            frm.Show();
        }

        private void NzBarcodeReader_Click(object sender, EventArgs e)
        {
            var frm = new Form_BarCode();
            frm.MdiParent = StorageProvider.MainForm;
            frm.Show();
        }

        private void NzProfitAll_Click(object sender, EventArgs e)
        {
            var frm = new FormObjectProfit();
            frm.MdiParent = StorageProvider.MainForm;
            frm.Show();
        }

        private void NzAllCircular_Click(object sender, EventArgs e)
        {
            var frm = new FormAllCircular();
            frm.MdiParent = StorageProvider.MainForm;
            frm.Show();
        }

        private void NzProfitMonthly_Click(object sender, EventArgs e)
        {
            var frm = new FormProfitMonthly();
            frm.MdiParent = StorageProvider.MainForm;
            frm.Show();
        }

        private void NzLocation_Click(object sender, EventArgs e)
        {
            var frm = new Form_ListLocation();
            frm.MdiParent = StorageProvider.MainForm;
            frm.Show();
        }

        private void NzCircularOfLocation_Click(object sender, EventArgs e)
        {
            var frm = new Form_CircularOfLocation();
            frm.MdiParent = StorageProvider.MainForm;
            frm.Show();
        }

        private void NzListPrefactor_Click(object sender, EventArgs e)
        {
            new FormListPreFactor().Show(StorageProvider.MainForm);
        }

        private void NzPrefactor_Click_1(object sender, EventArgs e)
        {
            new FormListPreFactor().Show(StorageProvider.MainForm);

        }

        private void NzObjectMenu_Click(object sender, EventArgs e)
        {
            var frm         = new FormListObject();
            frm.MdiParent   = StorageProvider.MainForm;
            frm.Show();
        }

        private void NzSalemenu_Click(object sender, EventArgs e)
        {
            if(!ValidationDemoVersion())
                return;

            var frm = new Form_Purchase(0, Enums.NzFactorKind.Frosh);
            frm.Show(StorageProvider.MainForm);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            var frm = new Form_BarCode();
            frm.MdiParent = StorageProvider.MainForm;
            frm.Show();
        }

        private void NzReviewFactorPayment_Click(object sender, EventArgs e)
        {
            var frm = new FormReviewFactorPayment();
            frm.MdiParent = StorageProvider.MainForm;
            frm.Show();
        }

        private void NzBrandMenu_Click(object sender, EventArgs e)
        {
            var frm = new FormBrand();
            frm.MdiParent = StorageProvider.MainForm;
            frm.Show();
        }

        private void NzBasteBandi_Click(object sender, EventArgs e)
        {
            var frm = new FormBasteBandi();
            frm.MdiParent = StorageProvider.MainForm;
            frm.Show();
        }

        private void NzSaleAnalyze_Click(object sender, EventArgs e)
        {
            var frm = new FormSaleAnalyze();
            frm.MdiParent = StorageProvider.MainForm;
            frm.Show();
        }

        private void NzPurchaceAnalyze_Click(object sender, EventArgs e)
        {
            var frm = new FormPurchaceAnalyze();
            frm.MdiParent = StorageProvider.MainForm;
            frm.Show();
        }

        private void NzMonthlyChart_Click(object sender, EventArgs e)
        {
            var frm = new FormMonthlySaleChart();
            frm.MdiParent = StorageProvider.MainForm;
            frm.Show();
        }

        private void NzReadyItems_Click(object sender, EventArgs e)
        {
            new FormListPreFactor().Show(StorageProvider.MainForm);
        }
    }
}
