using System; 
using System.Windows.Forms;
using MS_Control;
using NZ.Anbar.Business;
using Nz.Anbar.Model.Report;
using Nz.Anbar.WinForms.App;
using Nz.Anbar.WinForms.Base;
using Nz.Anbar.WinForms.Provider;
using Nz.Anbar.WinForms.Report;
using ShareLib;
using ShareLib.Utils;

namespace Nz.Bar.Winforms.Provider
{
    public partial class BarMenuItems : UserControl
    {
        public BarMenuItems()
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
            //ms_Storage.Visible     = false;
        }

        private void NzListHavale_Click(object sender, EventArgs e)
        {
			var frm = new Form_List_HavalehRasid();
			frm.MdiParent = BarProvider.MainForm;
			frm.Show();
		}

		private void InitialStock_Click(object sender, EventArgs e)
		{
			if(!ValidationDemoVersion())
				return;

			var frm         = new Form_InitialStock();
			frm.MdiParent   = BarProvider.MainForm;
			frm.Show();
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

		private void NzEnteqalAnbarHa_Click(object sender, EventArgs e)
		{
			if(!ValidationDemoVersion())
				return;

			var frm = new Form_Naql_Enteqal(0);
			frm.Show(StorageProvider.MainForm);
		}

		private void NzResid_Click(object sender, EventArgs e)
		{
			if(!ValidationDemoVersion())
				return;

			var frm = new Form_Havale_Resid(0,Enums.NzFactorKind.ResidVorud);
			frm.Show(StorageProvider.MainForm);
		}

		private void NzHavale_Click(object sender, EventArgs e)
		{
			if(!ValidationDemoVersion())
				return;

			var frm = new Form_Havale_Resid(0,Enums.NzFactorKind.HavaleXoruj);
			frm.Show(StorageProvider.MainForm);
		}



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
		private void NzAnalyze_Click(object sender, EventArgs e)
		{
			var frm = new FormAnalyze();
			frm.MdiParent = StorageProvider.MainForm;
			frm.Show();
		}
		private void NzAllCircular_Click(object sender, EventArgs e)
		{
			var frm = new FormAllCircular();
			frm.MdiParent = StorageProvider.MainForm;
			frm.Show();
		}
		private void NzPurchaceAnalyze_Click(object sender, EventArgs e)
		{
			var frm = new FormPurchaceAnalyze();
			frm.MdiParent = StorageProvider.MainForm;
			frm.Show();
		}
	}
}
