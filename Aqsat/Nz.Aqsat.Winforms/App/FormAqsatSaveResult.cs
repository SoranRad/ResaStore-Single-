using MS_Control.MainForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nz.Aqsat.Winforms.App
{
    public partial class FormAqsatSaveResult : Form_Mother_IRANSans
	{
        public FormAqsatSaveResult()
        {
            InitializeComponent();
        }

        private void FormBarCodeResult_KeyUp(object sender, KeyEventArgs e)
        {
	        switch (e.KeyCode)
	        {
		        case Keys.F4:
			        NsPrint_New.PerformClick();
			        break;
		        case Keys.F3:
			        NsNew.PerformClick();
			        break;
		        case Keys.F2:
			        NsPrint.PerformClick();
			        break;
	        }
	        e.SuppressKeyPress = true;
        }

		private void FormBarCodeResult_KeyPress(object sender, KeyPressEventArgs e)
        {
	        if (e.KeyChar == (char)27)
		        NsCancel.PerformClick();
        }

        private void NsPrint_New_Click(object sender, EventArgs e)
        {
	        this.DialogResult = DialogResult.Retry;
        }

        private void NsNew_Click(object sender, EventArgs e)
        {
	        this.DialogResult = DialogResult.Yes;
        }

        private void NsPrint_Click(object sender, EventArgs e)
        {
	        this.DialogResult = DialogResult.No;
        }

        private void NsCancel_Click(object sender, EventArgs e)
        {
	        this.DialogResult = DialogResult.Cancel;
        }
	}

}
