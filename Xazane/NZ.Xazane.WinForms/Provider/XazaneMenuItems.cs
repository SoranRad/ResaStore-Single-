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
using NZ.Xazane.Business;
using NZ.Xazane.Model.Report;
using NZ.Xazane.WinForms.App;
using NZ.Xazane.WinForms.Base;
using NZ.Xazane.WinForms.Operation;
using NZ.Xazane.WinForms.Report;
using ShareLib;
using ShareLib.Utils;

namespace NZ.Xazane.WinForms.Provider
{
    public partial class XazaneMenuItems : UserControl
    {
        public void SetMenu()
        {
            ms_baseinfo.DropDownItems.Remove(NzCheuqeBook);
            NzCheuqeBook.Visible = false;
        }

        public XazaneMenuItems()
        {
            InitializeComponent();
        }

        public bool ValidationDemoVersion()
        {
            if (!SystemConstant.IsDemo)
                return true;
            
            var Mgr     = new ReportManager();
            var count   = Mgr.GetItem<PaymentItems>(new{},null);

            if (count.ItemsCount >= SystemConstant.DemoCount)
            {
                MS_Message.Show("نسخه برنامه شما آزمایشی می باشد لطفا آن را ارتقا دهید", "خطا", MessageBoxButtons.OK);
                return false;
            }

            return true;
        } 


        //Base Info
        private void NzCache_Click              (object sender, EventArgs e)
        {
            var frm = new FormListCache();
            frm.MdiParent = XazaneProvider.MainForm;
            frm.Show();
        }
        private void NzBankAccountBase_Click    (object sender, EventArgs e)
        {
            var frm         = new FormListBankAccount();
            frm.MdiParent   = XazaneProvider.MainForm;
            frm.Show();
        }
        private void NzFundBase_Click           (object sender, EventArgs e)
        {
            var frm         = new FormListDeficit();
            frm.MdiParent   = XazaneProvider.MainForm;
            frm.Show();
        }
        //========
        private void NzCostBase_Click           (object sender, EventArgs e)
        {
            var frm         = new FormListCost();
            frm.MdiParent   = XazaneProvider.MainForm;
            frm.Show();
        }
        private void NzIncomeBase_Click         (object sender, EventArgs e)
        {
            var frm         = new FormListIncome();
            frm.MdiParent   = XazaneProvider.MainForm;
            frm.Show();
        }
        //========
        private void Addition_Click             (object sender, EventArgs e)
        {
            var frm = new Base.FormListDeficit(Enums.NzAccountKind.Addition);
            frm.Show(XazaneProvider.MainForm);
        }
        private void Deficit_Click              (object sender, EventArgs e)
        {
            var frm = new Base.FormListDeficit(Enums.NzAccountKind.Deficit);
            frm.Show(XazaneProvider.MainForm);

        }
        private void NzRemainPeople_Click       (object sender, EventArgs e)
        {
            var frm         = new FormListRemaind();
            frm.MdiParent   = XazaneProvider.MainForm;
            frm.Show();
        }
        private void NzCheuqeBook_Click         (object sender, EventArgs e)
        {
            var frm         = new FormListChequeBook();
            frm.MdiParent   = XazaneProvider.MainForm;
            frm.Show();
        }

        //===================================  Operation ============
        //===================================  
        //===================================

        private void ListCostIncome_Click       (object sender, EventArgs e)
        {
            if(!ValidationDemoVersion())
                return;

            var frm         = new FormListCostIncome();
            frm.MdiParent   = XazaneProvider.MainForm;
            frm.Show();
        }
        private void Income_Click               (object sender, EventArgs e)
        {
            if(!ValidationDemoVersion())
                return;

            var frm         = new App.FormIncome(null);
            frm.Show();
        }
        private void Cost_Click                 (object sender, EventArgs e)
        {
            if(!ValidationDemoVersion())
                return;

            var frm         = new App.FormCost(null);
            frm.Show();
        }
        //=========
        private void NzDeficit_Click            (object sender, EventArgs e)
        {
            if(!ValidationDemoVersion())
                return;

            var frm = new App.FormDeficit(null);
            frm.Show();
        }
        private void NzExtend_Click             (object sender, EventArgs e)
        {
            if(!ValidationDemoVersion())
                return;

            var frm = new App.FormDeficit(null,0,Enums.NzPaymentOperatingKind.Addition);
            frm.Show();
        }
        private void NzListDeficitExtend_Click  (object sender, EventArgs e)
        {
            var frm         = new App.FormListDeficitAddition();
            frm.MdiParent   = XazaneProvider.MainForm;
            frm.Show();
        }
        //==========
        private void NzRecive_Click             (object sender, EventArgs e)
        {
            if(!ValidationDemoVersion())
                return;

            new FormPayment().Show(XazaneProvider.MainForm);
        }
        private void NzPayment_Click            (object sender, EventArgs e)
        {
            if(!ValidationDemoVersion())
                return;

            new FormPayment(0,Enums.NzPaymentOperatingKind.Pardaxt).Show(XazaneProvider.MainForm);
        }
        private void NzListPayment_Click        (object sender, EventArgs e)
        {
            if(!ValidationDemoVersion())
                return;

            var frm         = new FormListPayment();
            frm.MdiParent   = XazaneProvider.MainForm;
            frm.Show();
        }
        //==========

        private void NzChequeList_Click         (object sender, EventArgs e)
        {
            if(!ValidationDemoVersion())
                return;
 
            var frm         = new FormListCheque();
            frm.MdiParent   = XazaneProvider.MainForm;
            frm.Show();
        }

        private void NzPeopleCircular_Click(object sender, EventArgs e)
        {
            var frm         = new FormCircularPeople();
            frm.MdiParent   = XazaneProvider.MainForm;
            frm.Show();
        }

        private void NzAnalyzeCheque_Click(object sender, EventArgs e)
        {
            var frm         = new FormAnalyzeCheque();
            frm.MdiParent   = XazaneProvider.MainForm;
            frm.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            var frm         = new FormAnalyzeChequeMonthly();
            frm.MdiParent   = XazaneProvider.MainForm;
            frm.Show();
        }

        private void NzUsentCheque_Click(object sender, EventArgs e)
        {
            var frm         = new FormChequeAlarm();
            frm.MdiParent   = XazaneProvider.MainForm;
            frm.Show();
        }

        private void NzReviewAccount_Click(object sender, EventArgs e)
        {
            var frm         = new FormReviewAccount();
            frm.MdiParent   = XazaneProvider.MainForm;
            frm.Show();
        }

        private void NzPayment1_Click(object sender, EventArgs e)
        {
            if(!ValidationDemoVersion())
                return;

            new FormPayment(0,Enums.NzPaymentOperatingKind.Pardaxt).Show(XazaneProvider.MainForm);
        }

        private void NzPayment2_Click(object sender, EventArgs e)
        {
            if(!ValidationDemoVersion())
                return;

            new FormPayment().Show(XazaneProvider.MainForm);
        }

        private void NzAccountTransfer_Click(object sender, EventArgs e)
        {
            if(!ValidationDemoVersion())
                return;

            var frm         = new FormListAccountTransfer();
            frm.MdiParent   = XazaneProvider.MainForm;
            frm.Show();
             
        }
    }
}