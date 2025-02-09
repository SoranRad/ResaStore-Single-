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
using NZ.General.Business;
using NZ.General.WinForms.Base;
using ShareLib;
using ShareLib.Utils;

namespace NZ.General.WinForms.EndYear
{
    public partial class FormEndYear : Form_Mother_IRANSans
    {
        public FormEndYear()
        {
            InitializeComponent();
            this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;

        }

        private void NzYear_Click(object sender, EventArgs e)
        {
            var frm = new Form_Year(new Manager(),null);
            frm.Show();
        }

        private void NzStorage_Click(object sender, EventArgs e)
        {

            var factor = Form_Factory
                .SystemList
                .FirstOrDefault
                    (x => x.GetSystemKind() == Enums.MS_System.Anbar);

            var frm = factor.GetFormForEdit(Enums.FormOperation.StorageEndYear);
            frm?.Set_Form_Param();

            (frm as Form).MdiParent = GeneralProvider.MainForm;
            (frm as Form).Show();
            this.WindowState = FormWindowState.Minimized;
            (frm as Form).Closing += (o, args) =>
            {
                this.WindowState = FormWindowState.Normal;
                this.Refresh();
            };
        }

        private void NzXazane_Click(object sender, EventArgs e)
        {
            var factor = Form_Factory
                .SystemList
                .FirstOrDefault
                    (x => x.GetSystemKind() == Enums.MS_System.Xazane);

            var frm = factor.GetFormForEdit(Enums.FormOperation.XazaneEndYear);
            frm?.Set_Form_Param();

            (frm as Form).MdiParent = GeneralProvider.MainForm;
            (frm as Form).Show();
            this.WindowState = FormWindowState.Minimized;
            (frm as Form).Closing += (o, args) =>
            {
                this.WindowState = FormWindowState.Normal;
                this.Refresh();
            };
        }
    }
}
