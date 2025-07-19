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
using ShareLib.Interfaces;

namespace Nz.Bar.Winforms.App
{
    public partial class FormBar : Form_Mother_IRANSans, IForm_Editor
    {
        public FormBar()
        {
            InitializeComponent();
        }

        public void Set_Form_Param(params object[] List_Parametter)
        {
            throw new NotImplementedException();
        }
    }
}
