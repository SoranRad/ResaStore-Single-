using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nz.Site.Winforms.App;

namespace Nz.Site.Winforms.Provider
{
    public partial class SiteMenuItems : UserControl
    {
        public SiteMenuItems()
        {
            InitializeComponent();
        }
        public void SetMenu()
        {
            //NzBrandMenu.Visible    = false;
            //ms_Storage.Visible     = false;
        }

		private void NsProducts_Click(object sender, EventArgs e)
		{
			var frm         = new FormProducts();
			frm.MdiParent   = SiteProvider.MainForm;
			frm.Show();
		}

		private void NsOrders_Click(object sender, EventArgs e)
		{
			var frm         = new FormOrders();
			frm.MdiParent   = SiteProvider.MainForm;
			frm.Show();
		}

		 
	}
}
