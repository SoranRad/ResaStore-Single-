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

namespace NZ.General.WinForms.Base
{
    public partial class FormDailyNoteEditor : Form_Mother_IRANSans
    {
        public          FormDailyNoteEditor         (string Text)
        {
            InitializeComponent();
            NzText.Text = Text;
        }
        public string   Nz_Text                     { get; set; }

        private void    FormDailyNoteEditor_KeyUp   (object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F2)
                ms_Save.PerformClick();
            else if(e.KeyCode==Keys.Escape)
                ms_Exit.PerformClick();
        }
        private void    ms_Save_Click               (object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NzText.Text))
            {
                mS_Notify1.Show     (NzText);
                NzText.Focus        ();
                return;
            }

            Nz_Text             = NzText.Text;
            this.DialogResult   = DialogResult.OK;
        }
        private void    ms_Exit_Click               (object sender, EventArgs e)
        {
            DialogResult        = DialogResult.Cancel;
        }
    }
}
