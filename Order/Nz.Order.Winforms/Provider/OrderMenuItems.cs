using MS_Control;
using ShareLib.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nz.Order.Winforms.App;

namespace Nz.Order.Winforms.Provider
{
	public partial class OrderMenuItems : UserControl
	{
		public OrderMenuItems()
		{
			InitializeComponent();
		}

		private void NsCategories_Click(object sender, EventArgs e)
		{
			var frm = new FormCategory();
			frm.MdiParent = OrderProvider.MainForm;
			frm.Show();
		}

		private void NsProducts_Click(object sender, EventArgs e)
		{
			var frm = new FormProducts();
			frm.MdiParent = OrderProvider.MainForm;
			frm.Show();
		}

		private void NsListOrders_Click(object sender, EventArgs e)
		{
			var frm = new FormOrders();
			frm.MdiParent = OrderProvider.MainForm;
			frm.Show();
		}
	}
}
