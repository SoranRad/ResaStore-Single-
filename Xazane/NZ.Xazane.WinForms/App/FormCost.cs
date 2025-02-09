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
using MS_Control.MS_Print_GridEX;
using MS_Control.Tarikh;
using NZ.General.WinForms.Component;
using NZ.Xazane.Business;
using NZ.Xazane.Model;
using NZ.Xazane.Model.Models;
using NZ.Xazane.Model.Report;
using ShareLib;
using ShareLib.Utils;

namespace NZ.Xazane.WinForms.App
{
    public partial class FormCost : Form_Mother_IRANSans
    {
        #region Logging

        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion
        #region Fields
        private PayBoxOperation         _Cost               = null;
        //private FormCost                _FormCost;
        public event EventHandler       MS_Do_Save;
        private bool                    _Is_Edit            = false,
                                        _CacheLoaded        = false,
                                        _BankAccountLoaded  = false,
                                        _FundLoaded         = false;

        private Enums.NzPaymentOperatingKind _Kind = Enums.NzPaymentOperatingKind.Hazine;
        private Manager                 _Manager;
        #endregion
        #region Constractor
        public FormCost(PayBoxOperation Cost)
        {
            InitializeComponent();
            _Is_Edit            = Cost != null;
            _Cost               = Cost ?? new PayBoxOperation();
            _Manager            = new Manager();
            NzDate.MS_Tarikh    = new MS_Structure_Shamsi(DateTime.Now);
        }
        public FormCost(long ID)
        {
            InitializeComponent();
            _Is_Edit            = ID>0;
            _Manager            = new Manager();
            _Cost               = _Manager.GetItem<PayBoxOperation>(new {ID}) ?? new PayBoxOperation();
            NzDate.MS_Tarikh    = new MS_Structure_Shamsi(DateTime.Now);
        }
        #endregion
        #region Methods
        public void     ValidationDemoVersion      ()
        {
            if (!SystemConstant.IsDemo)
                return  ;
            
            var Mgr     = new ReportManager();
            var count   = Mgr.GetItem<PaymentItems>(new{},null);

            if (count.ItemsCount >= SystemConstant.DemoCount)
            {
                MS_Message.Show("نسخه برنامه شما آزمایشی می باشد لطفا آن را ارتقا دهید", "خطا", MessageBoxButtons.OK);
                ms_Save.Enabled = false;
            }
        } 
        private void    LoadItem                   ()
        {
            try
            {
                _Is_Edit                        = true;

                switch ((Enums.NzAccountKind)_Cost.CreditKind)
                {
                    case Enums.NzAccountKind.Cache:
                        NzComboSandogh.Refresh_Grid         (_Manager.Connection,Enums.NzAccountKind.Cache);
                        NzComboSandogh.MS_Set_Select        (_Cost.FK_Xazaneh_Bas);
                        _CacheLoaded            = true;
                        NzCacheRadio.Checked    = true;
                        break;
                    case Enums.NzAccountKind.BankAccount:
                        NzComboHesabBanki.Refresh_Grid      (_Manager.Connection, Enums.NzAccountKind.BankAccount);
                        NzComboHesabBanki.MS_Set_Select     (_Cost.FK_Xazaneh_Bas);
                        _BankAccountLoaded      = true;
                        NzBankRadio.Checked     = true;
                        break;
                    case Enums.NzAccountKind.Fund:
                        NzComboTanxah.Refresh_Grid          (_Manager.Connection, Enums.NzAccountKind.Fund);
                        NzComboTanxah.MS_Set_Select         (_Cost.FK_Xazaneh_Bas);
                        _FundLoaded             = true;
                        NzFundRadio.Checked     = true;
                        break;
                    
                }

                NzComboHazine.MS_Set_Select     (_Cost.FK_Xazaneh_Bad);
                NzDate.MS_Tarikh                = new MS_Structure_Shamsi(_Cost.tarikh);
                NzSerial.Text                   = _Cost.serial.ToString();
                NzMab.Text                      = _Cost.mablaq.ToString("0,0.##");
                NzBabat.Text                    = _Cost.sharh;
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private void    Save                       ()
        {
            if (_Is_Edit)
            {
                _Cost.FK_User_Edit      = SystemConstant.ActiveUser.ID;
                _Cost.tarikh_edit       = DateTime.Now;

            }
            else
            {
                _Cost.FK_Salmali        = SystemConstant.ActiveYear.Salmali;
                _Cost.FK_User_Add       = SystemConstant.ActiveUser.ID;
                _Cost.tarikh_add        = DateTime.Now;
            }

            if(NzCacheRadio.Checked)
                _Cost.FK_Xazaneh_Bas        = (NzComboSandogh.MS_Get_Selected()as Accounts).ID;
            else if(NzBankRadio.Checked)
                _Cost.FK_Xazaneh_Bas        = (NzComboHesabBanki.MS_Get_Selected() as Accounts).ID;
            else if (NzFundRadio.Checked)
                _Cost.FK_Xazaneh_Bas        = (NzComboTanxah.MS_Get_Selected() as Accounts).ID;

            _Cost.FK_Xazaneh_Bad            = (NzComboHazine.MS_Get_Selected() as Accounts).ID;
            _Cost.tarikh                    = NzDate.MS_Tarikh.Value.ToDatetime();
            _Cost.serial                    = Convert.ToInt32(NzSerial.Text);
            _Cost.mablaq                    = NzMab.MS_Decimal;
            _Cost.sharh                     = NzBabat.Text;
            _Cost.kind = (byte) _Kind;

        }
        private void    Reset                      ()
        {
            try
            {
                NzComboHazine.Focus();
                _Is_Edit = false;
                _Cost = new PayBoxOperation();
                NzSerial.Text = (_Manager
                                 .GenerateCode<PayBoxOperation, int>
                                 (0, 
                                    new {
                                        Kind = (byte) _Kind,
                                        Year = SystemConstant.ActiveYear.Salmali
                                        }) + 1)
                    .ToString();
                NzMab.MS_Decimal = 0;
                NzBabat.Text                = "";
            }
            catch (Exception ex)
            {
                MS_Message.Show("سیستم قادر به اتصال به بانک اطلاعاتی نیست",
                    "خطا در تولید کد", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private bool    IsOK                       ()
        {
            if (SystemConstant.ActiveYear.is_close)
            {
                MS_Message.Show("سال مالی جاری بسته شده است " +
                                "\n نمی توانید ادامه دهید");
                return false;
            }
            if (NzMab.MS_Decimal == 0)
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
            var date = NzDate.MS_Tarikh.Value.ToDatetime().Date;
            var salmali = SystemConstant.ActiveYear;
            if (date > salmali.EndDate || date < salmali.StartDate)
            {
                MS_Message.Show("تاریخ سند در محدوده سال مالی نیست" +
                                "\n\n" +
                                "از تاریخ " + new MS_Structure_Shamsi(salmali.StartDate).ToShamsi() +
                                " تا تاریخ " + new MS_Structure_Shamsi(salmali.StartDate).ToShamsi());
                NzDate.Focus();
                mS_Notify1.Show(NzDate);
                return false;
            }
            if (!NzCacheRadio.Checked&&!NzBankRadio.Checked&&!NzFundRadio.Checked)
            {
                MS_Message.Show("یکی از نحوه پرداخت هزینه را انتخاب کنید.");
            }
            if (NzComboHazine.MS_Get_Selected()==null)
            {
                mS_Notify1.Show(NzComboHazine);
                NzComboHazine.Focus();
                new Form_Notify("تـوجـه", "نوع هزینه را وارد کـنیــد.",
                        Form_Notify.FarsiMessageBoxIcon.اخطار)
                    .Popup(Form_Notify.Direction_Show.Right_To_Left, 1500);
                return false;
            }
            if (_Cost.ID == 0 || (_Cost.ID > 0 && _Cost.serial != NzSerial.MS_Decimal))
            {
                var result = _Manager.IsCodeUnique<PayBoxOperation>
                (new
                {
                    Serial  = NzSerial.MS_Decimal,
                    Kind    = (byte)_Kind,
                    Year    = SystemConstant.ActiveYear.Salmali
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

            if (NzCacheRadio.Checked && NzComboSandogh.MS_Get_Selected() == null)
            {
                mS_Notify1.Show         (NzComboSandogh);
                NzComboSandogh.Focus    ();
                return false;
            }
            if (NzBankRadio.Checked && NzComboHesabBanki.MS_Get_Selected() == null)
            {
                mS_Notify1.Show(NzComboHesabBanki);
                NzComboHesabBanki.Focus();
                return false;
            }
            if (NzFundRadio.Checked && NzComboTanxah.MS_Get_Selected() == null)
            {
                mS_Notify1.Show(NzComboTanxah);
                NzComboTanxah.Focus();
                return false;
            }

            return true;
        }
        private void    Init                       ()
        {
            NzComboHazine.Refresh_Grid(_Manager.Connection,Enums.NzAccountKind.Cost);
            NzDate.MS_Tarikh= new MS_Structure_Shamsi(DateTime.Now);
            if (_Cost != null && _Cost.ID > 0)
                LoadItem();
            else
                Reset();
            NzCacheRadio.Focus();
            ValidationDemoVersion();
        }
        #endregion

        private void    ms_Save_Click              (object sender, EventArgs e)
        {
            try
            {
                if (!IsOK())
                    return;
                Save();
                _Manager.Save(_Cost);
                MS_Do_Save?.Invoke(_Is_Edit, new AddingNewEventArgs(_Cost.ID));

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
        private void    FormCost_KeyUp             (object sender, KeyEventArgs e)
        {

        }
        private void    ms_Exit_Click              (object sender, EventArgs e)
        {
            Close();
        }
        private void    FormCost_Shown             (object sender, EventArgs e)
        {
            Init();
        }
        private void    NzRadioes_CheckedChanged   (object sender, EventArgs e)
        {
            if (NzCacheRadio.Checked)
            {
                if (!_CacheLoaded)
                {
                    NzComboSandogh.Refresh_Grid(_Manager.Connection,Enums.NzAccountKind.Cache);
                    _CacheLoaded = true;
                }
                NzComboSandogh.Focus();
            }
            if (NzBankRadio.Checked)
            {
                if (!_BankAccountLoaded)
                {
                    NzComboHesabBanki.Refresh_Grid(_Manager.Connection, Enums.NzAccountKind.BankAccount);
                    _BankAccountLoaded = true;
                }
                NzComboHesabBanki.Focus();
            }
            if (NzFundRadio.Checked)
            {
                if (!_FundLoaded)
                {
                    NzComboTanxah.Refresh_Grid(_Manager.Connection, Enums.NzAccountKind.Fund);
                    _FundLoaded = true;
                }
                NzComboTanxah.Focus();
            }

            NzComboSandogh.Enabled      = NzCacheRadio.Checked;
            NzComboHesabBanki.Enabled   = NzBankRadio.Checked;
            NzComboTanxah.Enabled       = NzFundRadio.Checked;

        }

    }
}
