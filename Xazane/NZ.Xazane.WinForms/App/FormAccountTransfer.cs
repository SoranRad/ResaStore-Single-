using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control;
using MS_Control.MainForms;
using MS_Control.Tarikh;
using NZ.Xazane.Business;
using NZ.Xazane.Model;
using NZ.Xazane.Model.Models;
using NZ.Xazane.Model.Report;
using ShareLib;
using ShareLib.Utils;

namespace NZ.Xazane.WinForms.App
{
    public partial class FormAccountTransfer : Form_Mother_IRANSans
    {

        #region Logging

        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion
        #region Fields
        public event EventHandler               MS_Do_Save;
        private PayBoxOperation                 _Transfer       = null;
        private bool                            _Is_Edit        = false;
        private Enums.NzPaymentOperatingKind    _Kind           = Enums.NzPaymentOperatingKind.Naql_Enteqal;
        private Manager                         _Manager;
        #endregion
        #region Constractor
        public          FormAccountTransfer  (PayBoxOperation Transfer)
        {
            InitializeComponent();

            _Is_Edit            = Transfer != null;
            _Transfer           = Transfer ?? new PayBoxOperation();
            _Manager            = new Manager();
            NzDate.MS_Tarikh    = new MS_Structure_Shamsi(DateTime.Now);
        }
        public FormAccountTransfer(long ID)
        {
            InitializeComponent();

            _Is_Edit            = ID > 0;
            _Manager            = new Manager();
            _Transfer           = _Manager.GetItem<PayBoxOperation>(new { ID }) ?? new PayBoxOperation();
            NzDate.MS_Tarikh    = new MS_Structure_Shamsi(DateTime.Now);
        }
        #endregion
        #region Methods
        public void ValidationDemoVersion()
        {
            if (!SystemConstant.IsDemo)
                return;
            
            var Mgr     = new ReportManager();
            var count   = Mgr.GetItem<PaymentItems>(new{},null);

            if (count.ItemsCount >= SystemConstant.DemoCount)
            {
                MS_Message.Show("نسخه برنامه شما آزمایشی می باشد لطفا آن را ارتقا دهید", "خطا", MessageBoxButtons.OK);
                ms_Save.Enabled = false;
            }
        } 
        private void    LoadItem   ()
        {
            try
            {
                _Is_Edit = true;

                switch ((Enums.NzAccountKind)_Transfer.CreditKind)
                {
                    case Enums.NzAccountKind.Cache:
                        NzAccountAz.Refresh_Grid     (_Manager.Connection, Enums.NzAccountKind.Cache);
                        NzAccountAz.MS_Set_Select    (_Transfer.FK_Xazaneh_Bas);
                        NzSanduqAz.Checked         = true;
                        break;
                    case Enums.NzAccountKind.BankAccount:
                        NzAccountAz.Refresh_Grid  (_Manager.Connection, Enums.NzAccountKind.BankAccount);
                        NzAccountAz.MS_Set_Select (_Transfer.FK_Xazaneh_Bas);
                        NzBankAz.Checked            = true;
                        break;
                    case Enums.NzAccountKind.Fund:
                        NzAccountAz.Refresh_Grid      (_Manager.Connection, Enums.NzAccountKind.Fund);
                        NzAccountAz.MS_Set_Select     (_Transfer.FK_Xazaneh_Bas);
                        NzTanxahAz.Checked         = true;
                        break;

                }

                switch ((Enums.NzAccountKind)_Transfer.DebitKind)
                {
                    case Enums.NzAccountKind.Cache:
                        NzAccountBe.Refresh_Grid     (_Manager.Connection, Enums.NzAccountKind.Cache);
                        NzAccountBe.MS_Set_Select    (_Transfer.FK_Xazaneh_Bad);
                        NzSanduqBe.Checked         = true;
                        break;
                    case Enums.NzAccountKind.BankAccount:
                        NzAccountBe.Refresh_Grid  (_Manager.Connection, Enums.NzAccountKind.BankAccount);
                        NzAccountBe.MS_Set_Select (_Transfer.FK_Xazaneh_Bad);
                        NzBankBe.Checked            = true;
                        break;
                    case Enums.NzAccountKind.Fund:
                        NzAccountBe.Refresh_Grid      (_Manager.Connection, Enums.NzAccountKind.Fund);
                        NzAccountBe.MS_Set_Select     (_Transfer.FK_Xazaneh_Bad);
                        NzTanxahBe.Checked         = true;
                        break;

                }
                 
                NzDate.MS_Tarikh        = new MS_Structure_Shamsi(_Transfer.tarikh);
                NzSerial.Text           = _Transfer.serial.ToString();
                NzMab.Text              = _Transfer.mablaq.ToString("0,0.##");
                NzBabat.Text            = _Transfer.sharh;
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private void    Save       ()
        {
            if (_Is_Edit)
            {
                _Transfer.FK_User_Edit        = SystemConstant.ActiveUser.ID;
                _Transfer.tarikh_edit         = DateTime.Now;

            }
            else
            {
                _Transfer.FK_Salmali          = SystemConstant.ActiveYear.Salmali;
                _Transfer.FK_User_Add         = SystemConstant.ActiveUser.ID;
                _Transfer.tarikh_add          = DateTime.Now;
            }


            if (NzSanduqAz.Checked)
                _Transfer.FK_Xazaneh_Bas      = (NzAccountAz.MS_Get_Selected() as Accounts).ID;
            else if (NzBankAz.Checked)
                _Transfer.FK_Xazaneh_Bas      = (NzAccountAz.MS_Get_Selected() as Accounts).ID;
            else if (NzTanxahAz.Checked)
                _Transfer.FK_Xazaneh_Bas      = (NzAccountAz.MS_Get_Selected() as Accounts).ID;

            if (NzSanduqBe.Checked)
                _Transfer.FK_Xazaneh_Bad      = (NzAccountBe.MS_Get_Selected() as Accounts).ID;
            else if (NzBankBe.Checked)
                _Transfer.FK_Xazaneh_Bad      = (NzAccountBe.MS_Get_Selected() as Accounts).ID;
            else if (NzTanxahBe.Checked)
                _Transfer.FK_Xazaneh_Bad      = (NzAccountBe.MS_Get_Selected() as Accounts).ID;

             
            _Transfer.tarikh                  = NzDate.MS_Tarikh.Value.ToDatetime();
            _Transfer.serial                  = Convert.ToInt32(NzSerial.Text);
            _Transfer.mablaq                  = NzMab.MS_Decimal;
            _Transfer.sharh                   = NzBabat.Text;
            _Transfer.kind                    = (byte)_Kind;

        }
        private void    Reset      ()
        {
            try
            {
                NzAccountAz.Focus();
                _Is_Edit                    = false;
                _Transfer                     = new PayBoxOperation();
                NzSerial.Text               = (_Manager
                                                    .GenerateCode<PayBoxOperation, int>
                                                    (0,
                                                        new
                                                        {
                                             Kind = (byte)_Kind,
                                             Year = SystemConstant.ActiveYear.Salmali
                                         }) + 1)
                    .ToString();
                NzMab.MS_Decimal    = 0;
                NzBabat.Text        = "";
            }
            catch (Exception ex)
            {
                MS_Message.Show("سیستم قادر به اتصال به بانک اطلاعاتی نیست",
                    "خطا در تولید کد", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private bool    IsOK       ()
        {
            if (SystemConstant.ActiveYear.is_close)
            {
                MS_Message.Show("سال مالی جاری بسته شده است " +
                                "\n نمی توانید ادامه دهید");
                return false;
            }
            if (NzAccountAz.MS_Get_Selected() == null)
            {
                mS_Notify1.Show(NzAccountAz);
                NzAccountAz.Focus();
                new Form_Notify("تـوجـه", "حساب مبدا را وارد کنید.",
                        Form_Notify.FarsiMessageBoxIcon.اخطار)
                    .Popup(Form_Notify.Direction_Show.Right_To_Left, 1500);
                return false;
            }
            if (NzAccountBe.MS_Get_Selected() == null)
            {
                mS_Notify1.Show(NzAccountBe);
                NzAccountBe.Focus();
                new Form_Notify("تـوجـه", "حساب مقصد را وارد کنید.",
                        Form_Notify.FarsiMessageBoxIcon.اخطار)
                    .Popup(Form_Notify.Direction_Show.Right_To_Left, 1500);
                return false;
            }

            if (NzAccountBe.MS_Get_Selected() == NzAccountAz.MS_Get_Selected())
            {
                MS_Message.Show("حساب مبدا و مقصد نباید یکی باشد","هشدار",MessageBoxButtons.OK,MSMessage.FarsiMessageBoxIcon.خطا);
                return false;
            }


            if (NzMab.MS_Decimal ==0)
            {
                NzMab.Focus();
                mS_Notify1.Show(NzMab);
                return false;
            }

            if (!NzDate.MS_Tarikh.HasValue)
            {
                NzDate.Focus();
                mS_Notify1.Show(NzDate);
                return false;
            }
            var date    = NzDate.MS_Tarikh.Value.ToDatetime().Date;
            var salmali = SystemConstant.ActiveYear;
            if (date > salmali.EndDate || date < salmali.StartDate)
            {
                MS_Message.Show(
                                    "تاریخ سند در محدوده سال مالی نیست" +
                                    "\n\n" +
                                    "از تاریخ " + new MS_Structure_Shamsi(salmali.StartDate).ToShamsi() +
                                    " تا تاریخ " + new MS_Structure_Shamsi(salmali.StartDate).ToShamsi()
                                );
                NzDate.Focus();
                mS_Notify1.Show(NzDate);
                return false;
            }

           
            
            if (_Transfer.ID == 0 || (_Transfer.ID > 0 && _Transfer.serial != NzSerial.MS_Decimal))
            {
                var result = _Manager.IsCodeUnique<PayBoxOperation>
                (new
                {
                    Serial      = NzSerial.MS_Decimal,
                    Kind        = (byte)_Kind,
                    Year        = SystemConstant.ActiveYear.Salmali
                });
                if (!result)
                {
                    mS_Notify1.Show(NzSerial);
                    NzSerial.Focus();
                    new Form_Notify("تـوجـه تـوجـه", "سریال تکراری است.",
                            Form_Notify.FarsiMessageBoxIcon.اخطار)
                        .Popup(Form_Notify.Direction_Show.Down_To_Up, 1000);
                    return false;
                }
            }
           
            return true;
        }
        private void    Init       ()
        {
           
            if (_Transfer != null && _Transfer.ID > 0)
                LoadItem();
            else
            {
                NzAccountAz.Refresh_Grid      (Enums.NzAccountKind.Cache);
                NzAccountBe.Refresh_Grid      (Enums.NzAccountKind.BankAccount);
                NzDate.MS_Tarikh              = new MS_Structure_Shamsi(DateTime.Now);

                Reset();
            }

            ValidationDemoVersion();
        }

        #endregion
        private void ms_Save_Click              (object sender, EventArgs e)
        {
            try
            {
                if (!IsOK())
                    return;
                Save();
                _Manager.Save(_Transfer);
                MS_Do_Save?.Invoke(_Is_Edit, new AddingNewEventArgs(_Transfer.ID));

                new Form_Notify("ذخـیـره سـازی", "اطـلاعـات بـا مـوفـقـیـت ثـبـت شـــد.",
                        Form_Notify.FarsiMessageBoxIcon.اضافه)
                    .Popup(Form_Notify.Direction_Show.Right_To_Left, 500);

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
        private void ms_Exit_Click              (object sender, EventArgs e)
        {
            Close();
        }

        private void Form_Shown                 (object sender, EventArgs e)
        {
            Init();
        }
        private void FormAccountTransfer_KeyUp  (object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F2)
                ms_Save.PerformClick();
            else if(e.KeyCode == Keys.Escape)
                ms_Exit.PerformClick();
        }

        private void NzSanduqAz_CheckedChanged  (object sender, EventArgs e)
        {
            if (NzSanduqAz.Checked)
                NzAccountAz.Refresh_Grid     (_Manager.Connection, Enums.NzAccountKind.Cache);
            else if (NzBankAz.Checked)
                NzAccountAz.Refresh_Grid     (_Manager.Connection, Enums.NzAccountKind.BankAccount);
            else if (NzTanxahAz.Checked)
                NzAccountAz.Refresh_Grid     (_Manager.Connection, Enums.NzAccountKind.Fund);

            NzAccountAz.MS_Set_Select(null);
        }
        private void NzSanduqBe_CheckedChanged  (object sender, EventArgs e)
        {
            if (NzSanduqBe.Checked)
                NzAccountBe.Refresh_Grid     (_Manager.Connection, Enums.NzAccountKind.Cache);
            else if (NzBankBe.Checked)
                NzAccountBe.Refresh_Grid     (_Manager.Connection, Enums.NzAccountKind.BankAccount);
            else if (NzTanxahBe.Checked)
                NzAccountBe.Refresh_Grid     (_Manager.Connection, Enums.NzAccountKind.Fund);

            NzAccountBe.MS_Set_Select(null);
        }

    }
}
