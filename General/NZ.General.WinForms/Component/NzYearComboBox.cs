using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using MS_Control;
using MS_Control.Controls;
using NZ.General.Business;
using ShareLib.Models;

namespace NZ.General.WinForms.Component
{
    public partial class NzYearComboBox : MS_ComboBox_Janus
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        public NzYearComboBox()
        {
            InitializeComponent();
        }

        public void RefreshCombo()
        {
            try
            {
                var mgr = new Manager();
                var list = mgr.GetList<Year>();
                var arr = list
                    .Select(x => new UIComboBoxItem
                    {
                        Text = x.Salmali.ToString(),
                        DataRow = x,
                        Value = x,
                    })
                    .ToArray();

                this.Items.AddRange(arr);
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن لیست سال مالی", "خطا", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
    }
}
