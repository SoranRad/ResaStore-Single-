using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nz.Aqsat.Winforms.App;

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


        private void تعریفانواعقسطToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
	        var frm = new FormAqsatKind();
			frm.MdiParent = AqsatProvider.MainForm;
			frm.Show();
		}
    }
}
