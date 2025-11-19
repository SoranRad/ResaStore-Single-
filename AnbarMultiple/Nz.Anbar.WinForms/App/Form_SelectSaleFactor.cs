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
using Nz.Anbar.WinForms.Provider;
using ShareLib;

namespace Nz.Anbar.WinForms.App
{
    public partial class Form_SelectSaleFactor : Form_Mother_IRANSans
    {
        private readonly long _id;

        public Form_SelectSaleFactor(long ID)
        {
            _id = ID;
            InitializeComponent();
        }

        private void NzSaveSetting_Click(object sender, EventArgs e)
        {
            new Form_Purchase(_id, Enums.NzFactorKind.Frosh).ShowDialog(this.Parent);
            DialogResult = DialogResult.OK;
        }

        private void mS_Button_GridX1_Click(object sender, EventArgs e)
        {
            var frm         = new Form_BarCode(_id);
            frm.MdiParent   = StorageProvider.MainForm;
            frm.Show();
            DialogResult = DialogResult.OK;
        }
    }
}
