using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nz.Anbar.WinForms.Component
{
    public partial class NzBarcodeReader : TextBox
    {
        public KeyEventHandler NzEnterPressed;
        #region فیلد
        private Color               _Back_Color; 
        private Color               _borderColor    = Color.Silver, _old_border_color;
        private ButtonBorderStyle   _borderStyle    = ButtonBorderStyle.Solid;
        private static int          WM_PAINT        = 0x000F;
        #endregion

        public NzBarcodeReader()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey       (ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Down || keyData == Keys.Up || keyData == Keys.Enter )
            {
                NzEnterPressed?.Invoke(this,new KeyEventArgs(keyData));
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        protected override void WndProc             (ref Message m)
        {
            try
            {
                base.WndProc(ref m);

                if (m.Msg == WM_PAINT)
                {
                    Graphics g = Graphics.FromHwnd(Handle);
                    Rectangle bounds = new Rectangle(0, 0, Width, Height);
                    ControlPaint.DrawBorder(g, bounds, _borderColor, _borderStyle);
                }
            }
            catch 
            {
                
            }
        }

        public bool     MS_Change_Color_On_Enter    { set; get; }
        public Color    MS_Enter_Color              { get; set; }

        public bool     MS_Change_Border_Color_On_Enter { set; get; }
        public Color    MS_Enter_Border_Color       { get; set; }

        public Color                MS_BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                Invalidate(); // causes control to be redrawn
            }
        }
        public ButtonBorderStyle    MS_BorderStyle
        {
            get { return _borderStyle; }
            set
            {
                _borderStyle = value;
                Invalidate();
            }
        }
        
        protected override void OnEnter         (EventArgs e)
        {
            if (MS_Change_Color_On_Enter && MS_Enter_Color != null)
            {
                _Back_Color = this.BackColor;
                this.BackColor = MS_Enter_Color;
            }
            if (MS_Change_Border_Color_On_Enter && MS_Enter_Border_Color != null)
            {
                _old_border_color = MS_BorderColor;
                MS_BorderColor = MS_Enter_Border_Color;
            }
            base.OnEnter(e);
        }
        protected override void OnLeave         (EventArgs e)
        {
            if (MS_Change_Color_On_Enter && MS_Enter_Color != null)
            {
                this.BackColor = _Back_Color;
            }
            if (MS_Change_Border_Color_On_Enter && MS_Enter_Border_Color != null)
            {
                MS_BorderColor = _old_border_color;
            }
            base.OnLeave(e);
        }

    }
}
