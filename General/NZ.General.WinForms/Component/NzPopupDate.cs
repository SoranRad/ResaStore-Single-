using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control.Tarikh;
using NZ.General.Business;

namespace NZ.General.WinForms.Component
{
    public partial class NzPopupDate : ToolStripDropDown
    {
        #region Fields
        //private Size                    tileSize        = new Size(24, 24);
        //private int                     _StripSize      = 25;
        //====
        private ToolStripControlHost    NzHost;

        private int                     NzWidth         = 208;
        private int                     NzHeight        = 252;
        //====
        private DateTime                _SelectObject;
        private string                  _SelectPersianDate;
        //====
        public event EventHandler       NzSelectObject,
                                        NzCancelClicked;
        #endregion
        public          NzPopupDate     ()
        {
            InitializeComponent();
            Capture                     = true;
            DoubleBuffered              = true;
            ResizeRedraw                = true;
            RightToLeft                 = RightToLeft.Yes;
            AutoClose                   = true;
            Padding                     = new Padding(0);
            Margin                      = new Padding(0);
            DropShadowEnabled           = false;
            AddGrid();
        }
        #region Property
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public DateTime NzSelected      
        {
            get => _SelectObject;
            set
            {
                NzGrid.MS_Tarikh    =new MS_Structure_Shamsi(value);
                _SelectObject       = value;
            }
        }
        public string NzPersinaDate
        {
            get => _SelectPersianDate;
            set => _SelectPersianDate = value;
        }
        #endregion
        #region Methods
        private void AddGrid                ()
        {
            NzHost = new ToolStripControlHost(NzGrid)
            {
                Margin              = Padding.Empty,
                Padding             = Padding.Empty,
                AutoSize            = false,
                AutoToolTip         = false,
                DoubleClickEnabled  = true,
            };
            NzHost.Size = new Size(NzWidth, NzHeight);
            Items.Add(NzHost);
        }
        private void NzGrid_CancelClicked   ()
        {
            NzCancelClicked?.Invoke(this, null);
        }
        private void NzGrid_OKClicked       ()
        {
            _SelectObject       = NzGrid.MS_Tarikh.ToDatetime();
            _SelectPersianDate  = NzGrid.MS_Tarikh.ToShamsi();

            NzSelectObject?.Invoke(this,null);
        }
        #endregion
    }
}
