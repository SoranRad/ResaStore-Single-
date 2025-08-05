using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nz.Bar.Winforms.App;
using Nz.Bar.Winforms.Report;

namespace Nz.Bar.Winforms.Provider
{
    public partial class BarMenuItems : UserControl
    {
        public BarMenuItems()
        {
            InitializeComponent();
        }
        public void SetMenu()
        {
            //NzBrandMenu.Visible    = false;
            //ms_Storage.Visible     = false;
        }
        private void NzXarid_Click(object sender, EventArgs e)
        {

            var frm = new FormBar(0);
            frm.Show(BarProvider.MainForm);
        }

        private void NzListFactor_Click(object sender, EventArgs e)
        {
            var frm = new FormListBar();
            frm.MdiParent = BarProvider.MainForm;
            frm.Show();
        }

		private void NsCar_Click(object sender, EventArgs e)
		{
			var frm         = new FormCarList();
			frm.MdiParent   = BarProvider.MainForm;
			frm.Show();
		}

		private void صورتحسابحامعکشاورزToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var frm         = new FormSuratHesabKeshavarz();
			frm.MdiParent   = BarProvider.MainForm;
			frm.Show();
		}

		private void NsFactory_Click(object sender, EventArgs e)
		{
			var frm = new FormErsalKarkhane(0);
			frm.Show(BarProvider.MainForm);
		}

		private void NsFactoryList_Click(object sender, EventArgs e)
		{
			var frm         = new FormErsalKarkhaneList();
			frm.MdiParent   = BarProvider.MainForm;
			frm.Show();
		}
	}
}
