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
using ShareLib.Utils;

namespace NZ.Resaa.Store
{
    public partial class Form_Alarm : Form_Mother_IRANSans
    {
        public Form_Alarm()
        {
            InitializeComponent();
        }

         

        private void Form_Alarm_Load(object sender, EventArgs e)
        {
            foreach (var system  in Form_Factory.SystemList)
                if (system.AnyAlaram())
                    NzTab.TabPages.Add(system.GeTabPage());
        }
    }
}
