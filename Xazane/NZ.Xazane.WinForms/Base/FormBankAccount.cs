using System; 
using System.ComponentModel; 
using System.Windows.Forms;
using MS_Control;
using MS_Control.MainForms; 
using NZ.Xazane.Business;
using NZ.Xazane.Model;
using ShareLib;
using ShareLib.Models;
using ShareLib.Utils;

namespace NZ.Xazane.WinForms.Base
{
    public partial class FormBankAccount : Form_Mother_IRANSans
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        private    Accounts             _BankAccount = null;
        public     event  EventHandler  MS_Do_Save;
        private    bool                 _Is_Edit = false;
        private    Manager             _Manager;

        #endregion
        public FormBankAccount(Manager Manager, Accounts BankAccount)
        {
            InitializeComponent();
            _BankAccount    = BankAccount;
            _Manager        = Manager ?? new Manager();
            NzComboBank.Refresh_Grid();
            NzTitle.Focus();
            NzCode.Enabled = true;
        }

        #region Methods
        private void LoadItem       ()
        {
            try
            {
                _Is_Edit                    =   true;
                NzCode.MS_Decimal           =   _BankAccount.Code;
                NzTitle.Text                =   _BankAccount.title;
                NzComboBank.MS_Set_Select(_BankAccount.FK_Bank);
                NzMojodeAvalie.Text         =   _BankAccount.mojudi_avalie.ToString("0,0.##"); 
                NzShobe.Text                =  _BankAccount.shobe;
                NzKartXan.SelectedIndex     =   _BankAccount.has_POS.HasValue ? 1 : 0;
                NzShHesab.Text              =   _BankAccount.Shomare_Hesab;
                NzKindHesab.Text            =   _BankAccount.Kind_Hesab ;
                NzState.SelectedIndex       =   _BankAccount.is_disable ? 1 : 0;
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private void Save       ()
        {
            if (_BankAccount.ID == 0)
                _BankAccount.Code            =  Convert.ToInt16(NzCode.MS_Decimal);

            _BankAccount.title           =  NzTitle.Text;
            _BankAccount.mojudi_avalie   =  NzMojodeAvalie.MS_Decimal;
            _BankAccount.shobe           =  NzShobe.Text;
            _BankAccount.FK_Bank         = (NzComboBank.MS_Get_Selected() as Bank).ID;
            _BankAccount.Shomare_Hesab   =  NzShHesab.Text;
            _BankAccount.Kind_Hesab      =  NzKindHesab.Text;
            _BankAccount.is_disable      =  NzState.SelectedIndex == 1;
            _BankAccount.Kind            =  (byte)Enums.NzAccountKind.BankAccount;
        }
        private void Reset      ()
        {
            try
            {
                NzTitle.Focus();
                _Is_Edit                = false;
                _BankAccount            = new Accounts();
                NzCode.Text             = (_Manager
                                               .GenerateCode<Accounts, short>
                                               (0, new { Kind = (byte)Enums.NzAccountKind.BankAccount }) + 1)
                                                .ToString();
                NzTitle.Text            = "";
                NzComboBank.Refresh_Grid();
                NzMojodeAvalie.MS_Decimal = 0;
                NzShobe.Text            = "";
                NzKartXan.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MS_Message.Show("سیستم قادر به اتصال به بانک اطلاعاتی نیست",
                    "خطا در تولید کد", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private bool IsOK       ()
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

            if (_BankAccount.ID == 0 || (_BankAccount.ID > 0 && _BankAccount.Code != NzCode.MS_Decimal))
            {
                var result = _Manager.IsCodeUnique<Accounts>
                            (new {
                                    Code = Convert.ToInt16(NzCode.MS_Decimal),
                                    Kind = (byte)Enums.NzAccountKind.BankAccount        
                            });
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
        private void Init       ()
        {
            NzState.SelectedIndex = 0;
            if (_BankAccount != null && _BankAccount.ID > 0)
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
                _Manager.Save(_BankAccount);

                Tag = _BankAccount.ID;
                MS_Do_Save?.Invoke(_Is_Edit, new AddingNewEventArgs(_BankAccount.ID));

                new Form_Notify("ذخـیـره سـازی", "اطـلاعـات بـا مـوفـقـیـت ثـبـت شـــد.",
                        Form_Notify.FarsiMessageBoxIcon.اضافه)
                    .Popup(Form_Notify.Direction_Show.Right_To_Left, 500);

                Tag = _BankAccount.ID;
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
        private void ms_Exit_Click          (object sender, EventArgs e)
        {
            Close();
        }
        private void FormBankAccount_KeyUp  (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                ms_Save.PerformClick();
        }
        private void FormBankAccount_Shown  (object sender, EventArgs e)
        {
            Init();
        }
    }
}
