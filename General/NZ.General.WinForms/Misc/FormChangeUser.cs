using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
using ShareLib.ViewModel;

namespace NZ.General.WinForms.Misc
{
    public partial class FormChangeUser : Form_Mother_IRANSans
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        private ReportManager _Manager;
        #endregion
        #region Constructor
        public    FormChangeUser    ()
        {
            InitializeComponent();
            _Manager = new ReportManager();
        }
        #endregion
        #region Methods
        private bool    IsOK               ()
        {
            if (string.IsNullOrEmpty(NzPass.Text))
            {
                mS_Notify1.Show(NzPass);
                NzPass.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(NzUserName.Text))
            {
                mS_Notify1.Show(NzUserName);
                NzUserName.Focus();
                return false;
            }
            return true;
        }
        private void    InitLogin          (long ID)
        {
            var Mgr         = new Manager(_Manager.Connection);
            var User        = Mgr.GetItem<User>(new { ID });
            SystemConstant
                .ActiveUser = User 
                                ?? throw new Exception("کاربر مورد نظر یافت نشد");
        }
        private void    SaveSetting        ()
        {
            var cfg         = Config.FromXML();
            cfg.UserName    = NzUserName.Text.Trim();
            cfg.ToXml();
        }
        #endregion
        private void    ms_login_Click     (object sender, EventArgs e)
        {
            if (!IsOK())
                return;
            try
            {
                var login = _Manager
                    .GetItem<UserLogin>
                    (new { User = NzUserName.Text.Trim() }, string.Empty);

                if (login == null)
                {
                    MS_Message.Show("نام کاربری یا کلمه عبور یافت نشد");
                    NzUserName.Focus();
                    return;
                }
                if (login.is_disable)
                {
                    MS_Message.Show("کاربر گرامی " +
                                    "\n نام کاربری شما موقتا غیر فعال شده است " +
                                    "\n لطفا با مدیریت تماس حاصل فرمایید");
                    NzUserName.Focus();
                    return;
                }

                var user = new User
                {
                    ID                  = login.ID, 
                    Code                = login.Code, 
                    user_name           = login.Username, 
                    OriginalPassword    = NzPass.Text.Trim(),
                };
                if (user.password != login.Password)
                {
                    MS_Message.Show("نام کاربری یا رمز عبور اشتباه است");
                    log.Warn("نام کاربری " + NzUserName.Text + " پسورد خود را اشتباه وارد کرده است");
                    NzUserName.Focus();
                    return;
                }

                if (login.Password == login.default_password)
                {
                    SystemConstant.ActiveUser       = user;
                    var frm = new FormNewPass();
                    if (frm.ShowDialog(this) != DialogResult.OK)
                        DialogResult = DialogResult.Cancel;
                }

                InitLogin(login.ID);
                SaveSetting();

                new Form_Notify2("تغییر کاربر","کاربر جاری تغییر کرد",
                            Form_Notify2.FarsiMessageBoxIcon.چـک_باکس)
                                .Popup(Form_Notify2.Direction_Show.Right_To_Left,1500);

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MS_Message.Show("خطا در ورود به سیستم", "خطا", ex.Message, MessageBoxButtons.OK);
            }
        }
    }
}
