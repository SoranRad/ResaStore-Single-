using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control;
using MS_Control.MainForms;
using NZ.General.Business;
using ShareLib.Models;
using ShareLib.Utils;

namespace NZ.General.WinForms.Misc
{
    public partial class ChangePass : Form_Mother_IRANSans
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields

        #endregion
        #region Constructor
        public ChangePass()
        {
            InitializeComponent();
        }
        #endregion
        #region Methods
        private bool IsOK()
        {
            if (string.IsNullOrWhiteSpace(NzCurrentPass.Text))
            {
                NzCurrentPass.Focus();
                mS_Notify1.Show(NzCurrentPass);
                return false;
            }

            if (NzCurrentPass.Text.Trim() != SystemConstant.ActiveUser.OriginalPassword.Trim())
            {
                MS_Message.Show("کلمه عبور فعلی شمـا اشتباه است ");
                NzCurrentPass.Focus();
                mS_Notify1.Show(NzCurrentPass);
                return false;
            }
            if (string.IsNullOrWhiteSpace(NzPass.Text))
            {
                NzPass.Focus();
                mS_Notify1.Show(NzPass);
                return false;
            }
            if (string.IsNullOrWhiteSpace(NzPassConfirm.Text))
            {
                NzPassConfirm.Focus();
                mS_Notify1.Show(NzPassConfirm);
                return false;
            }
            if (NzPass.Text.Trim() != NzPassConfirm.Text.Trim())
            {
                MS_Message.Show("کلمه عبور جدید با کلمه عبور تکراری برابر نیست" +
                                "\n مجددا آنهـا را وارد کنید");
                NzPassConfirm.Focus();
                mS_Notify1.Show(NzPassConfirm);
                return false;
            }
            if (NzPass.Text.Trim() == SystemConstant.ActiveUser.OriginalDefaultPassword.Trim())
            {
                MS_Message.Show("کلمه عبور وارده با کلمه عبور پیش فرض برابر است" +
                                "\n کلمه عبور دیگری را وارد کنید");
                NzPass.Focus();
                mS_Notify1.Show(NzPass);
                return false;
            }
            return true;
        }
        #endregion

        private void ms_save_Click(object sender, EventArgs e)
        {
            if(!IsOK())
                return;
            try
            {
                var mgr                 = new Manager();
                var User                = SystemConstant.ActiveUser;
                User.OriginalPassword   = NzPassConfirm.Text;

                mgr.Save(User);

                new Form_Notify2("تغییر کلمه عبور", "کلمه عبور با موفقیت تغییر کرد",
                        Form_Notify2.FarsiMessageBoxIcon.چـک_باکس)
                            .Popup(Form_Notify2.Direction_Show.Right_To_Left, 1500);

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MS_Message.Show("خطا در ثبت اطلاعات", "خطای ثبت اطلاعات",
                    ex.Message,
                    MessageBoxButtons.OK);
            }

        }
    }
}
