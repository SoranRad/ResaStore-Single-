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

            var frm = new FormBar();
            frm.Show(BarProvider.MainForm);
        }

        private void NzListFactor_Click(object sender, EventArgs e)
        {
            var frm = new FormListBar();
            frm.MdiParent = BarProvider.MainForm;
            frm.Show();
        }
    }
}
