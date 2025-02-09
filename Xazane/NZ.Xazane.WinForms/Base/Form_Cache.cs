using System; 
using System.ComponentModel; 
using System.Windows.Forms;
using MS_Control;
using MS_Control.MainForms;
using NZ.Xazane.Business;
using NZ.Xazane.Model;
using ShareLib;
using ShareLib.Utils;

namespace NZ.Xazane.WinForms.Base
{
    public partial class Form_Cache : Form_Mother_IRANSans
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        private          Accounts       _Cache = null;
        public  event    EventHandler    MS_Do_Save;
        private bool                    _Is_Edit = false;
        private          Manager        _Manager;
        #endregion
        public Form_Cache          (Manager Manager, Accounts Cache)
        {
            InitializeComponent();
            _Cache      = Cache;
            _Manager    = Manager;
            NzTitle.Focus();
            NzCode.Enabled = true;
        }
        #region Methods
        private void LoadItem           ()
        {
            try
            {
                _Is_Edit                = true;
                NzCode.MS_Decimal       = _Cache.Code;
                NzTitle.Text            = _Cache.title;
                NzInitValue.Text        = _Cache.mojudi_avalie.ToString("0,0.##");
                NzState.SelectedIndex   = _Cache.is_disable ? 1 : 0;
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private void Save           ()
        {
            if (_Cache.ID == 0)
                _Cache.Code         = Convert.ToInt16(NzCode.MS_Decimal);
           
            _Cache.title            = NzTitle.Text;
            _Cache.mojudi_avalie    = NzInitValue.MS_Decimal;
            _Cache.is_disable       = NzState.SelectedIndex == 1;

            _Cache.Kind             = (byte) Enums.NzAccountKind.Cache;
        }
        private void Reset          ()
        {
            try
            {
                NzTitle.Focus();
                _Is_Edit                = false;
                _Cache                  = new Accounts();
                NzCode.Text =
                    (_Manager
                    .GenerateCode<Accounts, short>
                            (0, new {Kind = (byte) Enums.NzAccountKind.Cache}) + 1)
                    .ToString();
                NzTitle.Text            = "";
                NzInitValue.MS_Decimal  = 0;
                NzState.SelectedIndex   = 0;
            }
            catch (Exception ex)
            {
                MS_Message.Show("سیستم قادر به اتصال به بانک اطلاعاتی نیست",
                    "خطا در تولید کد", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private bool IsOK           ()
        {
            if (SystemConstant.ActiveYear.is_close)
            {
                MS_Message.Show("سال مالی جاری بسته شده است " +
                                "\n نمی توانید ادامه دهید");
                return false;
            }

            if (string.IsNullOrWhiteSpace(NzTitle.Text))
            {
                mS_Notify1.Show(NzTitle);
                NzTitle.Focus();
                new Form_Notify("تـوجـه", "عنوان صندوق وارد کـنیــد.",
                        Form_Notify.FarsiMessageBoxIcon.اخطار)
                    .Popup(Form_Notify.Direction_Show.Right_To_Left, 1500);
                return false;
            }

            if (_Cache.ID == 0 || (_Cache.ID > 0 && _Cache.Code != NzCode.MS_Decimal))
            {
                var result = _Manager.IsCodeUnique<Accounts>
                    (new {Code = Convert.ToInt16(NzCode.MS_Decimal), Kind = (byte) Enums.NzAccountKind.Cache});
                if (!result)
                {
                    mS_Notify1.Show(NzCode);
                    NzCode.Focus();
                    new Form_Notify("تـوجـه تـوجـه", "کــد تکراری است.",
                            Form_Notify.FarsiMessageBoxIcon.اخطار)
                        .Popup(Form_Notify.Direction_Show.Down_To_Up, 500);
                    return false;
                }
            }
            return true;
        }
        private void Init           ()
        {
            NzState.SelectedIndex = 0;
            if (_Cache != null && _Cache.ID > 0)
                LoadItem();
            else
                Reset();
        }
        #endregion
        private void ms_Save_Click  (object sender, EventArgs e)
        {
            try
            {
                if (!IsOK())
                    return;
                Save();
                _Manager.Save(_Cache);
                MS_Do_Save?.Invoke(_Is_Edit, new AddingNewEventArgs(_Cache.ID));

                new Form_Notify("ذخـیـره سـازی", "اطـلاعـات بـا مـوفـقـیـت ثـبـت شـــد.",
                        Form_Notify.FarsiMessageBoxIcon.اضافه)
                    .Popup(Form_Notify.Direction_Show.Right_To_Left, 500);

                Tag = _Cache.ID;
                if (_Is_Edit)
                    Close();
                else
                    Reset();
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MS_Message.Show("سیستم قادر به ثبت اطلاعات نیست",
                    "خطا در ثبت", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private void ms_Exit_Click  (object sender, EventArgs e)
        {
            Close();
        }
        private void Form_KeyUp     (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                ms_Save.PerformClick();
        }
        private void Form_Cache_Shown(object sender, EventArgs e)
        {
            Init();
        }
    }
}
