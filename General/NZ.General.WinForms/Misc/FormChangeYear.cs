using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using MS_Control;
using MS_Control.MainForms;
using NZ.General.Business;
using ShareLib.Models;
using ShareLib.Utils;
using ShareLib.ViewModel;

namespace NZ.General.WinForms.Misc
{
    public partial class FormChangeYear : Form_Mother_IRANSans
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Methods
        private void    LoadListYears       ()
        {
            try
            {
                var mgr     = new Manager();
                var list    = mgr.GetList<Year>();
                var arr = list
                    .Where(x => x.Salmali != SystemConstant.ActiveYear.Salmali)
                    .Select(x => new UIComboBoxItem
                    {
                        Text = x.Salmali.ToString(),
                        DataRow = x,
                        Value = x,
                    })
                    .ToArray();

                NzSalmali.Items.AddRange(arr);
                if (NzSalmali.Items.Count > 0)
                    NzSalmali.SelectedIndex = NzSalmali.Items.Count - 1;
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن لیست سال مالی", "خطا", ex.Message,MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        #endregion

        public FormChangeYear()
        {
            InitializeComponent();
            NzCurrentYear.Text = SystemConstant.ActiveYear.Salmali.ToString();
            LoadListYears();
        }

        private void ms_login_Click(object sender, EventArgs e)
        {
            if (NzSalmali.SelectedItem != null)
                SystemConstant.ActiveYear = NzSalmali.SelectedItem.DataRow as Year;

            new Form_Notify2("تغییر سال مالی", "سال مالی جاری تغییر کرد",
                    Form_Notify2.FarsiMessageBoxIcon.چـک_باکس)
                        .Popup(Form_Notify2.Direction_Show.Right_To_Left, 1500);

            DialogResult = DialogResult.OK;
        }
    }
}
