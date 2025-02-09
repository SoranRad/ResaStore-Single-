using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nz.Machine.Winforms.Component
{
    public partial class BenzinStatus : UserControl
    {
        public BenzinStatus()
        {
            InitializeComponent();
        }

        public void Empty()
        {
            uiTrackBar1.Value = uiTrackBar1.Maximum;
        }

        public void SetValue(decimal value)
        {
            uiTrackBar1.Value =Convert.ToInt32(value);
        }

        public int GetValue()
        {
            return uiTrackBar1.Value;
        }

        public byte[] GetImage()
        {
            MemoryStream ms = new MemoryStream();
            this.Refresh();
            using (Bitmap newBitmap = new Bitmap(Width, Height))
            {
                newBitmap.SetResolution(100, 100);
                var rec = new Rectangle(0, 0, newBitmap.Width, newBitmap.Height);
                this.DrawToBitmap(newBitmap,rec);
                newBitmap.Save(ms, ImageFormat.Jpeg);
            }

            return ms.GetBuffer();
        }

        
    }
}
