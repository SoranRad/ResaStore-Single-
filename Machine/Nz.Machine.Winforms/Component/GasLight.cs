using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Machine.Winforms.Component
{
    public partial class GasLight : MS_Control.Controls.MS_Lable_Ex
    {
        public GasLight()
        {
            InitializeComponent();
        }

        public Color LightColor { get; set; }

        public void LightOn()
        {
            this.BackColor = LightColor;
        }
        public void LightOFF()
        {
            this.BackColor = Color.Transparent;
        }
    }
}
