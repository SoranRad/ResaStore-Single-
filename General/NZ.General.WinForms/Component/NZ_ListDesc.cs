using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.General.Business;
using ShareLib.Models;

namespace NZ.General.WinForms.Component
{
    public partial class NZ_ListDesc : MS_Control.TSDD.MS_Base_GridPopup
    {
        #region Filds
        IEnumerable<Description> _List = new List<Description>();
        #endregion

        public NZ_ListDesc()
        {
            InitializeComponent();
        }
    }
}
