using System; 
using System.ComponentModel; 
using System.Drawing;
using System.IO;
using System.Linq; 
using System.Windows.Forms;
using MS_Control;
using MS_Control.MainForms; 
using NZ.General.Business; 
using ShareLib.Models;
using System.Drawing.Imaging;

namespace NZ.General.WinForms.Base
{
    public partial class Form_User : Form_Mother_IRANSans
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        private User                _User = null;
        public event EventHandler   MS_Do_Save;
        private bool                _Is_Edit = false;
        private Manager             _Manager;
        #endregion
        #region Constructor
        public          Form_User           (Manager Manager, User User)
        {
            InitializeComponent();
            _User = User;
            _Manager = Manager;
            Init();
        }
        #endregion
        #region Methods
        private void    LoadItem            ()
        {
            try
            {
                _Is_Edit                        = true;
                ms_Code.ReadOnly                = true;
                ms_Code.MS_Decimal              = _User.Code;
                ms_Title.Text                   = _User.title;
                ms_User_Name.Text               = _User.user_name;
                ms_Pas_Def.Text                 = _User.OriginalDefaultPassword;
                ms_Is_Disable.SelectedIndex     = _User.is_disable ? 1 : 0;
                ms_Kind.SelectedIndex           = _User.kind-1;

                if (_User.picture != null)
                {
                    byte[] arrImage     = (byte[]) _User.picture.ToArray();
                    MemoryStream ms     = new MemoryStream(arrImage);
                    ms_Pic.Image        = Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private void    Save                ()
        {

            if (_User.ID == 0)
            {
                _User.Code                      = Convert.ToInt16(ms_Code.MS_Decimal);
                _User.OriginalAccess            = " ";
                _User.OriginalPassword          = ms_Pas_Def.Text.Trim();
                _User.OriginalDefaultPassword   = ms_Pas_Def.Text.Trim();
            }
            //else
            //{
            //    if (ms_Code.MS_Decimal != _User.Code)
            //        _User.OriginalPassword  = ms_Pas_Def.Text.Trim();
            //}
            _User.title                     = ms_Title.Text;
            _User.user_name                 = ms_User_Name.Text;
            _User.OriginalDefaultPassword   = ms_Pas_Def.Text;
            _User.is_disable                = ms_Is_Disable.SelectedIndex == 1;
            _User.kind                      = (short) (ms_Kind.SelectedIndex+1);
            if (ms_Pic.Image != null)
            {
                MemoryStream ms             = new MemoryStream();
                ms_Pic.Image.Save           (ms, ImageFormat.Jpeg);
                byte[] arrImage             = ms.GetBuffer();
                _User.picture               = arrImage;
            }
            else
                _User.picture = null;
        }
        private void    Reset               ()
        {
            try
            {
                _Is_Edit                    = false;
                _User                       = new User();
                ms_Code.ReadOnly            = false;
                ms_Code.MS_Decimal          = _Manager.GenerateCode<User,short>(0)+1;
                ms_Title.Text               = ms_User_Name.Text=ms_Pas_Def.Text = "";
                ms_Is_Disable.SelectedIndex = ms_Kind.SelectedIndex = 1;
                ms_Title.Focus();
            }
            catch (Exception ex)
            {
                MS_Message.Show("سیستم قادر به اتصال به بانک اطلاعاتی نیست",
                    "خطا در تولید کد", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private bool    IsOK                ()
        {
            if (ms_Code.MS_Decimal == 0)
            {
                mS_Notify1.Show(ms_Code);
                ms_Code.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(ms_Title.Text))
            {
                mS_Notify1.Show(ms_Title);
                ms_Title.Focus();
                return false;
            }
            if(string.IsNullOrEmpty(ms_Pas_Def.Text.Trim()))
            {
                mS_Notify1.Show(ms_Pas_Def);
                ms_Pas_Def.Focus();
                return false;
            }
            if (_User.ID == 0 || (_User.ID > 0 && _User.Code != ms_Code.MS_Decimal))
            {
                var result = _Manager.IsCodeUnique<User>(new { Code = ms_Code.MS_Decimal });
                if (!result)
                {

                    MS_Message.Show("کد کاربر تکراری است");
                    mS_Notify1.Show(ms_Code);
                    ms_Code.Focus();
                    return false;
                }
            }
            return true;
        }
        private void    Init                ()
        {
            ms_Kind.SelectedIndex           = 0;
            ms_Is_Disable.SelectedIndex     = 0;

            if (_User != null && _User.ID > 0)
                LoadItem();
            else
                Reset();
        }
        #endregion
        private void ms_Save_Click          (object sender, EventArgs e)
        {
            try
            {
                if (!IsOK())
                    return;
                Save();
                _Manager.Save<User>(_User);
                MS_Do_Save?.Invoke(_Is_Edit, new AddingNewEventArgs(_User.ID));

                new Form_Notify("ذخـیـره سـازی", "اطـلاعـات بـا مـوفـقـیـت ثـبـت شـــد.",
                        Form_Notify.FarsiMessageBoxIcon.اضافه)
                            .Popup(Form_Notify.Direction_Show.Right_To_Left, 500);

                if (_Is_Edit)
                    Close();
                else
                    Reset();
            }
            catch (Exception ex)
            {
                MS_Message.Show("سیستم قادر به ثبت اطلاعات نیست",
                    "خطا در ثبت", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private void ms_Exit_Click          (object sender, EventArgs e)
        {
            Close();
        }
        private void Form_KeyUp             (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                ms_Save.PerformClick();
        }
        private void ms_Open_Pic_Click      (object sender, EventArgs e)
        {
            OpenFileDialog b = new OpenFileDialog();
            
            b.Filter        = MS_Util.GetImageFilter();
            DialogResult d  = b.ShowDialog();
            if (d == DialogResult.Cancel)
                return;
            ms_Pic.Image    = Image.FromFile(b.FileName);
        }
        private void ms_Delete_Pic_Click    (object sender, EventArgs e)
        {
            ms_Pic.Image = null;
        }

    }
}
