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
using Nz.Aqsat.Business;
using Nz.Aqsat.Model.Report;
using Nz.Aqsat.Winforms.App;
using Nz.Aqsat.Winforms.Report;
using ShareLib.Utils;

namespace Nz.Bar.Winforms.Provider
{
    public partial class AqsatMenuItems : UserControl
    {
        public AqsatMenuItems()
        {
            InitializeComponent();
        }
        public void SetMenu()
        {
            //NzBrandMenu.Visible    = false;
            //ms_Storage.Visible     = false;
        }

        public bool ValidationDemoVersion()
        {
	        if (!SystemConstant.IsDemo)
		        return true;

	        var Mgr = new ReportManager();
	        var count = Mgr.GetItem<AqsatHeadCount>(new { }, null);

	        if (count.ItemsCount >= SystemConstant.DemoCount)
	        {
		        MS_Message.Show("نسخه برنامه شما آزمایشی می باشد لطفا آن را ارتقا دهید", "خطا", MessageBoxButtons.OK);
		        return false;
	        }

	        return true;
        }

		private void تعریفانواعقسطToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
	        if (!ValidationDemoVersion())
		        return;

			var frm = new FormAqsatKind();
			frm.MdiParent = AqsatProvider.MainForm;
			frm.Show();
		}

        private void NsCreateAqsat_Click(object sender, EventArgs e)
        {
	        if (!ValidationDemoVersion())
		        return;

			var frm = new Form_Aqsat_Jadid();
	        frm.Show(AqsatProvider.MainForm);
		}

        private void لیستاقساطToolStripMenuItem_Click(object sender, EventArgs e)
        {
	        if (!ValidationDemoVersion())
		        return;

			var frm = new FormAqsatList();
	        frm.MdiParent = AqsatProvider.MainForm;
	        frm.Show();
		}

        private void NsMoedGozashteh_Click(object sender, EventArgs e)
        {
	        var frm = new FormAqsatMoedGozashte();
	        frm.MdiParent = AqsatProvider.MainForm;
	        frm.Show();
		}

        private void NsSarResidAqsat_Click(object sender, EventArgs e)
        {
	        var frm = new FormSarResidAqsat();
	        frm.MdiParent = AqsatProvider.MainForm;
	        frm.Show();
		}

        private void NsAqsatMoedGozashteAshxas_Click(object sender, EventArgs e)
        {
	        var frm = new FormAqsatMoedGozashteAshxas();
	        frm.MdiParent = AqsatProvider.MainForm;
	        frm.Show();
		}

        private void NsSarResidHafte_Click(object sender, EventArgs e)
        {
	        var frm = new FormSarResidAqsatHafte();
	        frm.MdiParent = AqsatProvider.MainForm;
	        frm.Show();
		}

		private void NsAnnualAqsat_Click(object sender, EventArgs e)
		{
			var frm = new FormRememberAnnual();
			frm.Show(AqsatProvider.MainForm);
		}
	}
}
