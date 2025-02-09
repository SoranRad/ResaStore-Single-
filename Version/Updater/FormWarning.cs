using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control.MainForms;

namespace Updater
{
    public partial class FormWarning : Form_Mother_IRANSans
    {
        public FormWarning(string CurrentVersion,string NewVersion)
        {
            InitializeComponent();
            this.Location = new Point
            (
                Screen.PrimaryScreen.WorkingArea.Right - this.Width,
                Screen.PrimaryScreen.WorkingArea.Bottom - this.Height
            );
            NzCurrentVersion.Text   = CurrentVersion;
            NzNewVersion.Text       = NewVersion;
        }

        private void Nz_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK; 
        }

        private void Nz_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
