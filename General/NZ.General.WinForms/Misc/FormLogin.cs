using System; 
using System.Data.SqlClient;
using System.Diagnostics; 
using System.IO;
using System.Linq;
using System.Reflection; 
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
    public partial class FormLogin : Form_Mother_IRANSans
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        private ReportManager   _Manager;
        #endregion
        #region Constructor
        public FormLogin()
        {
            InitializeComponent();
        }
        #endregion
        #region Methods
        private void    LoadListYears          ()
        {
            try
            {
                var mgr     = new Manager(_Manager.Connection);
                var list    = mgr.GetList<Year>();
                var arr     = list.Select(x => new UIComboBoxItem
                {
                    Text    = x.Salmali.ToString(),
                    DataRow = x,
                    Value   = x,
                }).ToArray();

                NzSalmali.Items.Clear();
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
        private bool    IsOK                   ()
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
            if (NzSalmali.SelectedItem == null || NzSalmali.SelectedIndex < 0)
            {
                mS_Notify1.Show(NzSalmali);
                NzSalmali.Focus();
                return false;
            }
            return true;
        }
        private void    InitLogin              (long ID)
        {
            var Mgr     = new Manager(_Manager.Connection);
            var User    = Mgr.GetItem<User>(new {ID});

            if (User == null)
                throw new Exception("کاربر مورد نظر یافت نشد");

            SystemConstant.ActiveUser       = User;
            SystemConstant.ActiveYear       = NzSalmali.SelectedItem.DataRow as Year;
            
        }
        private Company GetCompany             ()
        {
            return _Manager.GetItem<Company>(new {ID = true},null);

        }
        private void    SaveCurrentSetting     ()
        {
            var cfg = Config.FromXML();
            cfg.UserName = NzUserName.Text.Trim();
            if (string.IsNullOrEmpty(cfg?.Location))
            {
                var path = Path
                               .GetDirectoryName(Assembly.GetExecutingAssembly().Location)
                           + "\\AutoBack" ;

                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                cfg.Location = path;
            }

            cfg.ToXml();
        }
        private void    InitCompanyList        ()
        {
            NzTitleCompany.Visible  = false;
            NzLabelCompany.Visible  = true;
            NzCompany.Visible       = true;

            var arr = SystemConstant
                .DBList
                .Select(x => new UIComboBoxItem
                {
                    DataRow = x,
                    Text    = x.Title,
                    Value   = x
                })
                .ToArray();
            NzCompany.Items.Clear();
            NzCompany.Items.AddRange(arr);
            NzCompany.SelectedIndex = -1;
            NzCompany.SelectedIndexChanged +=NzCompanyOnSelectedIndexChanged;
            NzCompany.Focus();
        }
        private void    CompanySelection       ()
        {
            //var Selection                   = NzCompany.SelectedValue as DataBaseList;
            //var ConStrBuilder               = new SqlConnectionStringBuilder(ConnectionManager.ConStr);
            //ConStrBuilder.InitialCatalog    = Selection.DbName;
            //ConnectionManager.ConStr        = ConStrBuilder.ToString();
            SetConectionString();
            NzLogin.Enabled = true;
            NzActivation.Hide();
            InitSingleCompany();
        }

        private void    SetConectionString      ()
        {
            var Selection                   = NzCompany.SelectedValue as DataBaseList;
            var ConStrBuilder               = new SqlConnectionStringBuilder(ConnectionManager.ConStr);
            ConStrBuilder.InitialCatalog    = Selection.DbName;
            ConnectionManager.ConStr        = ConStrBuilder.ToString();
        }
        private void    InitSingleCompany       ()
        {
            _Manager = new ReportManager();
            LoadListYears();
            SystemConstant.ActiveCompany = GetCompany();
            if (SystemConstant.ActiveCompany != null)
                SystemConstant.ActiveCompany.title = SystemConstant.ActiveCompany?.OriginalTitle;
            NzTitleCompany.Text = SystemConstant.ActiveCompany?.title;
            NzUserName.Focus();
        }
        private void    LoadSlide               ()
        {
            try
            {
                var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
                if (File.Exists(path + @"\Slide.gif" ))
                    pictureBox5.ImageLocation = path + @"\Slide.gif";
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        #endregion
        private void    NzLogin_Click          (object sender, EventArgs e)
        {
            if(!IsOK())
                return;
            try
            {
                var login = _Manager
                    .GetItem<UserLogin>
                    (new {User = NzUserName.Text.Trim()}, string.Empty);

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
                var user = new User()
                {
                    Code        = login.Code,
                    user_name   = login.Username,
                    ID          =  login.ID
                };
                user.OriginalPassword = NzPass.Text.Trim();
                if (user.password != login.Password)
                {
                    MS_Message.Show("نام کاربری یا رمز عبور اشتباه است");
                    log.Warn("نام کاربری "+ NzUserName.Text+" پسورد خود را اشتباه وارد کرده است");
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
                SaveCurrentSetting();

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MS_Message.Show("خطا در ورود به سیستم", "خطا", ex.Message, MessageBoxButtons.OK);
            }
        }
        private void    FormLogin_Shown        (object sender, EventArgs e)
        {
            LoadSlide();
            Application.DoEvents();
            if (SystemConstant.DBList != null && SystemConstant.DBList.Any())
                InitCompanyList();
            else
                InitSingleCompany();
        }

        private void    NzRestore_Click        (object sender, EventArgs e)
        {
            try
            {
                new MS_Sql_Manage.MainForm().ShowDialog();
            }
            catch { }
        }
        private void    NzInfo_Click           (object sender, EventArgs e)
        {
            try
            {
                ProcessStartInfo sInfo = new ProcessStartInfo("http://nikshaho.ir/");
                Process.Start(sInfo);
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MS_Message.Show("متاسفانه برنامه قادر به نمایش اطلاعات نیست","خطا ",ex.Message,MessageBoxButtons.OK);

            }
        }
        private void    NzSupport_Click        (object sender, EventArgs e)
        {
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            if (File.Exists(path + @"\Support\Support.exe"))
                Process.Start(path + @"\Support\Support.exe");
            else
                MS_Message.Show("متاسفانه برنامه پشـتیبانی یافت نشد" +
                                "\n با تیم پشتیبانی تماس حاصل نمایید");
        }

        private void    pictureBox4_MouseEnter (object sender, EventArgs e)
        {
            pictureBox4.Image = global::MS_Resource.GlobalResources._ms_Delete;
        }
        private void    pictureBox4_MouseLeave (object sender, EventArgs e)
        {
            pictureBox4.Image = null;
        }
        private void    pictureBox4_Click      (object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void    NzCompanyOnSelectedIndexChanged (object sender, EventArgs e)
        {
            var SelItem = NzCompany.SelectedValue as DataBaseList;
            if (SelItem.Registered || SystemConstant.OurAccount)
                CompanySelection();
            else
            {
                SetConectionString();

                NzLogin.Enabled = false;
                NzSalmali.Items.Clear();
                NzActivation.Show();
                NzActivation.Focus();
            }
        }
        private void    NzActivation_Click      (object sender, EventArgs e)
        {
            new FormActivation().ShowDialog(this);
            this.DialogResult = DialogResult.Abort;
        }

        private void    label4_Click            (object sender, EventArgs e)
        {
            NzUserName.Focus();
        }
        private void    label5_Click            (object sender, EventArgs e)
        {
            NzPass.Focus();
        }
    }
}
