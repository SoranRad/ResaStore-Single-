using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nz.Machine.Winforms.Component
{
    public partial class GasStatusLight : UserControl
    {
        private List<GasLight>      Lights;
        private byte                _Level = 0;

        public GasStatusLight()
        {
            InitializeComponent();
            Lights = new List<GasLight>()
            {
                NzLight1,
                NzLight2,
                NzLight3,
                NzLight4,
                NzLight5,
                NzLight6,
            };

            foreach (var light in Lights)
            {
                light.MouseEnter += LightOnMouseHover;
                light.Click+=LightOnClick;
            }
        }

        public void     SetLevel        (byte Level)
        {
            _Level = Level;
            RefreshLigh();
        }
        public byte     GetLevel        ()
        {
            return _Level;
        }
        public void     RefreshLigh     ()
        {
            OffAllLight();
            for (int i = 0; i < _Level; i++)
                Lights[i].LightOn();
        }
        public void     OffAllLight     ()
        {
            foreach (var light in Lights)
                light.LightOFF();
        }
        
        private void    GasStatusLight_MouseLeave   (object sender, EventArgs e)
        {
            RefreshLigh();
        }
        private void    LightOnClick                (object sender, EventArgs e)
        {
            var CurrentIndex = Lights.IndexOf(sender as GasLight);
            if (CurrentIndex != -1)
            {
                OffAllLight();
                _Level = Convert.ToByte(CurrentIndex + 1);
                RefreshLigh();
            }
        }
        private void    LightOnMouseHover           (object sender, EventArgs e)
        {
            OffAllLight();
            var CurrentIndex = Lights.IndexOf(sender as GasLight);
            if (CurrentIndex != -1)
                for (int i = CurrentIndex; i >= 0; i--)
                    Lights[i].LightOn();
        }

        private void GasEmpty_Click(object sender, EventArgs e)
        {
            SetLevel(0);
        }
    }
}
