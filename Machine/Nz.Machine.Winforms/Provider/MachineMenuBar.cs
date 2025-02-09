using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nz.Machine.Winforms.App;

namespace Nz.Machine.Winforms.Provider
{
    public partial class MachineMenuBar : UserControl
    {
        public MachineMenuBar()
        {
            InitializeComponent();
        }

        private void NzNewMachine_Click(object sender, EventArgs e)
        {
            var frm = new FormAcceptMachine(null);
            frm.Show(MachineProvider.MainForm);
        }

        private void NzListMachine_Click(object sender, EventArgs e)
        {
            var frm         = new FormListAcceptMachine();
            frm.MdiParent   = MachineProvider.MainForm;
            frm.Show();
        }
    }
}
