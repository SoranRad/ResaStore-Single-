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
using ShareLib.Interfaces;
using ShareLib.Models;
using ShareLib.Utils;
using ShareLib.ViewModel;

namespace NZ.Xazane.WinForms.App
{
    public partial class FormDeficit : Form_Mother_IRANSans,IForm_Editor
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion
        #region Fields

        private long _ID;
        private         DPOperation         _DP                 =null;
        public event    EventHandler        MS_Do_Save;
        private bool                        _Is_Edit            = false;
        private DpManager                   _Manager;
        private Enums.NzPaymentOperatingKind _Kind = Enums.NzPaymentOperatingKind.Kosurat;
      
        #endregion
        #region Constractor
        public FormDeficit  (DpManager Manager, long ID =0, Enums.NzPaymentOperatingKind Kind = Enums.NzPaymentOperatingKind.Kosurat)
        {
            InitializeComponent();

            _ID                 = ID;
            _Manager            = new DpManager();
            NzDate.MS_Tarikh  = new MS_Structure_Shamsi(DateTime.Now);
            _Kind               = Kind;
        }
        #endregion
        void InitForm()
        {
            if (_Kind == Enums.NzPaymentOperatingKind.Kosurat)
            {
                this.TitleText               = @"ثبت کسورات";
                lblNoh.Text             = @"انتخاب نوع کسورات :";
                LineSeperator.BackColor = Color.Maroon;

            }
            else 
            {
                this.TitleText = @"ثبت اضافات";
                lblNoh.Text               = @"انتخاب نوع اضافات :";
                LineSeperator.BackColor = Color.DarkCyan;

            }
        }
        #region Method
        public void ValidationDemoVersion()
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
        private void    LoadItem   ()
        {
            try
            {
                _DP                     = _Manager.GetItem(_ID);
                _Is_Edit                = true;
                var PayBox              = _DP.PayBoxOP.SingleOrDefault();
                NzComboShaxs.MS_Set_Select(_DP.FK_ShaXs);
                NzComboDeficit.MS_Set_Select(PayBox.FK_Xazaneh_Bad);
                NzDate.MS_Tarikh      = new MS_Structure_Shamsi(_DP.tarikh);
                NzSerial.Text           = _DP.serial.ToString();
                //NzMab.MS_Decimal        = PayBox.mablaq;
                NzMab.Text              = PayBox.mablaq.ToString("0,0.##");
                NzBabat.Text            = _DP.sharh;
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private void    Save   ()
        {
            var Paybox              = _DP.PayBoxOP.SingleOrDefault();
            if (Paybox == null)
            {
                Paybox              = new PayBoxOperation()
                {
                    DpHead          = _DP,
                    State           = Enums.NzItemState.AddedNew,
                };
                _DP.PayBoxOP.Add(Paybox);
            }
            if (_Is_Edit)
            {
                _DP.FK_User_Edit    = SystemConstant.ActiveUser.ID;
                _DP.tarikh_edit     = DateTime.Now;
                Paybox.State        = Enums.NzItemState.Modified;
            }
            else
            {
                _DP.FK_Salmali      = SystemConstant.ActiveYear.Salmali;
                _DP.FK_User_Add     = SystemConstant.ActiveUser.ID;
                _DP.tarikh_add      = DateTime.Now;

                _DP.kind            = (byte) _Kind;
                Paybox.kind         = (byte) _Kind;
                Paybox.FK_Salmali   = _DP.FK_Salmali;
            }
            
            _DP.FK_ShaXs            = (NzComboShaxs.MS_Get_Selected() as People).ID;
            if(_Kind == Enums.NzPaymentOperatingKind.Kosurat)
                Paybox.FK_Xazaneh_Bad   = (NzComboDeficit.MS_Get_Selected() as Accounts).ID;
            else 
                Paybox.FK_Xazaneh_Bas   = (NzComboDeficit.MS_Get_Selected() as Accounts).ID;

            _DP.tarikh              = NzDate.MS_Tarikh.Value.ToDatetime();
            _DP.serial              = Convert.ToInt32(NzSerial.Text);
            Paybox.mablaq           = NzMab.MS_Decimal;
            _DP.sharh               = NzBabat.Text;

        }
        private void    Reset  ()
        {
            try
            {
                NzComboShaxs.Focus();
                _Is_Edit                = false;
                _DP                     = new DPOperation();
                NzSerial.Text           = (_Manager.
                        GetMaxSerial
                                     (
                                         new
                                         {
                                             Year = SystemConstant.ActiveYear.Salmali,
                                             Kind = (byte)_Kind
                                         }) + 1)
                    .ToString();
                NzMab.MS_Decimal        = 0;
                NzBabat.Text            = "";
            }
            catch (Exception ex)
            {
                MS_Message.Show("سیستم قادر به اتصال به بانک اطلاعاتی نیست",
                    "خطا در تولید کد", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private bool    IsOK   ()
        {
            if (SystemConstant.ActiveYear.is_close)
            {
                MS_Message.Show("سال مالی جاری بسته شده است " +
                                "\n نمی توانید ادامه دهید");
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
            if (NzComboShaxs.MS_Get_Selected() == null)
            {
                mS_Notify1.Show(NzComboShaxs);
                NzComboShaxs.Focus();
                new Form_Notify("تـوجـه", "شـخص را وارد کـنیــد.",
                        Form_Notify.FarsiMessageBoxIcon.اخطار)
                    .Popup(Form_Notify.Direction_Show.Right_To_Left, 1500);
                return false;
            }
            if (NzComboDeficit.MS_Get_Selected() == null)
            {
                mS_Notify1.Show(NzComboDeficit);
                NzComboShaxs.Focus();
                new Form_Notify("تـوجـه", "شـخص را وارد کـنیــد.",
                        Form_Notify.FarsiMessageBoxIcon.اخطار)
                    .Popup(Form_Notify.Direction_Show.Right_To_Left, 1500);
                return false;
            }
            if (_DP.ID == 0 || (_DP.ID > 0 && _DP.serial != NzSerial.MS_Decimal))
            {
                var result      = _Manager.IsCodeUnique
                (new
                {
                    Serial      = NzSerial.MS_Decimal,
                    Year        = SystemConstant.ActiveYear.Salmali,
                    Kind        = _Kind
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
        private void    Init   ()
        {
            NzComboDeficit.Refresh_Grid     (_Manager.Connection,_Kind==Enums.NzPaymentOperatingKind.Kosurat ? Enums.NzAccountKind.Deficit
                                                                                                             : Enums.NzAccountKind.Addition);
            NzComboShaxs.Refresh_Grid       (_Manager.Connection,true,true);
            NzDate.MS_Tarikh              = new MS_Structure_Shamsi(DateTime.Now);
            if (_ID > 0)
                LoadItem();
            else
                Reset();

            InitForm();
            ValidationDemoVersion();
        }
        #endregion

        private void ms_Save_Click      (object sender, EventArgs e)
        {
            try
            {
                if (!IsOK())
                    return;
                Save();
                _Manager.Save(_DP);
                MS_Do_Save?.Invoke(_Is_Edit, new AddingNewEventArgs(_DP.ID));

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
        private void ms_Exit_Click      (object sender, EventArgs e)
        {
            Close();
        }
        private void FormDeficit_Shown  (object sender, EventArgs e)
        {
            Init();
        }
        private void FormDeficit_KeyUp  (object sender, KeyEventArgs e)
        {
            if   (e.KeyCode == Keys.F2)
                     ms_Save.PerformClick();
            if   (e.KeyCode == Keys.Escape)
                     ms_Exit.PerformClick();
        }

        public void Set_Form_Param(params object[] List_Parametter)
        {
            foreach (var Item in List_Parametter)
                if (Item is CircularBill row2)
                {
                    _ID = row2.ID;
                    _Kind = (Enums.NzPaymentOperatingKind)row2.Kind;
                    _Is_Edit = true;
                }
        }
    }
}
