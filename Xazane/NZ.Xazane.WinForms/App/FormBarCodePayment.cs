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
using NZ.Xazane.Business;
using NZ.Xazane.Model;
using NZ.Xazane.Model.Models;
using NZ.Xazane.Model.ViewModel;
using ShareLib;
using ShareLib.Interfaces;
using ShareLib.Utils;
using ShareLib.ViewModel;

namespace NZ.Xazane.WinForms.App
{
    public partial class FormBarCodePayment : Form_Mother_IRANSans, IForm_Editor
    {
        #region Logging
        private static readonly log4net.ILog  log =
            log4net
                .LogManager
                .GetLogger
                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion
        #region Fields
        //private decimal         _Price;
        //private long            _FK_People,
        //                        _FK_Factor,
        //                        _ID_Dp;
        private DPOperation             _DP = null;
        private DpManager               _Manager;
        private PaymentBarcodeSetting   _Setting;
        private FactorPaymentMessage    _FactorPaymnet;
        private string                  _FormatString = "0,0.##;(0,0.##); ";

        #endregion
        public FormBarCodePayment       ()
        {
            InitializeComponent();
        }
        #region Interface Implementation
        public void Set_Form_Param      (params object[] List_Parametter)
        {
            foreach (var Item in List_Parametter)
            {
                if (Item is FactorPaymentMessage row)
                    _FactorPaymnet  = row;
            }
        }
        #endregion

        #region Methods
        private void    Init            ()
        { 
            _Manager                    = new DpManager();
            NzCache.Refresh_Grid        (Enums.NzAccountKind.Cache);
            NzPos.Refresh_Grid          (Enums.NzAccountKind.BankAccount);
            NzFactorPrice.MS_Decimal    = _FactorPaymnet.Amount;
            LoadSettings                ();
            LoadPayment                 (_FactorPaymnet.IDFactor);
            DefaultSetting              ();
            RefreshMounts               ();
        }

        private void    DefaultSetting  ()
        {
            if (_Setting!= null)
            {
                if (NzCache.MS_Get_Selected() == null)
                {
                    if (NzCache.InvokeRequired)
                        NzCache.Invoke(new MethodInvoker(delegate
                        {
                            NzCache.MS_Set_Select(_Setting.Cache);
                        }));
                    else
                        NzCache.MS_Set_Select(_Setting.Cache);
                }

                if (NzPos.MS_Get_Selected() == null)
                {
                    if (NzPos.InvokeRequired)
                        NzPos.Invoke(new MethodInvoker(delegate
                        {
                            NzPos.MS_Set_Select(_Setting.Pos);
                        }));
                    else
                        NzPos.MS_Set_Select(_Setting.Pos);
                }
            }
        }
        private void    RefreshMounts   ()
        {
            NzSum.MS_Decimal        = NzCachePrice.MS_Decimal+ NzPosPrice.MS_Decimal;
            NzRemaind.MS_Decimal    = NzFactorPrice.MS_Decimal - NzSum.MS_Decimal;
        }
        private void    LoadSettings    ()
        {
            //Task.Run(() =>
            //{
            _Setting = PaymentBarcodeSetting.FromXML<PaymentBarcodeSetting>();
            //if (_Setting != null)
            //{
            //    if (NzCache.InvokeRequired)
            //        NzCache.Invoke(new MethodInvoker(delegate
            //        {
            //            NzCache.MS_Set_Select(_Setting.Cache);
            //        }));
            //    else
            //        NzCache.MS_Set_Select(_Setting.Cache);
            //    //=========================================
            //    if (NzPos.InvokeRequired)
            //        NzPos.Invoke(new MethodInvoker(delegate
            //        {
            //            NzPos.MS_Set_Select(_Setting.Pos);
            //        }));
            //    else
            //        NzPos.MS_Set_Select(_Setting.Pos);
            //    //========================================
            //}
            //}).ConfigureAwait(false); ;
        }
        private void    SaveSetting     ()
        {
            Task.Run(() =>
            {
                _Setting = _Setting ?? new PaymentBarcodeSetting();

                if (NzCache.MS_Get_Selected() is Accounts cache)
                    _Setting.Cache = cache.ID;

                if (NzPos.MS_Get_Selected() is Accounts pos)
                    _Setting.Pos = pos.ID;

                _Setting.ToXml();
                new Form_Notify("تسویه", "تنظیمات  بـا مـوفـقـیـت ثـبـت شـــد.",
                        Form_Notify.FarsiMessageBoxIcon.اضافه)
                    .Popup(Form_Notify.Direction_Show.Right_To_Left, 2500);

            }).ConfigureAwait(false);
        }
        private void    LoadPayment     (long IdFactor)
        {
            var mgr = new DpManager();
            _DP     = mgr.GetItemByFactor(IdFactor);
            if (_DP == null)
                return;

            LoadCache();
            LoadPos();
            RefreshMounts();

        }
        private void    LoadCache       ()
        {
            var cache = _DP.PayBoxOP.SingleOrDefault(x => x.kind == (byte)Enums.NzPaymentOperatingKind.Naqd);
            if (cache == null)
                return;
            NzCache.MS_Set_Select   (cache.ID);
            NzCachePrice.Text       = cache.mablaq.ToString(_FormatString);
            NzNaqdi_Checked.Checked = true;

        }
        private void    LoadPos         ()
        {
            var pos = _DP.PayBoxOP.SingleOrDefault(x => x.kind == (byte)Enums.NzPaymentOperatingKind.Bank_POS);
            if (pos == null)
                return;
            NzPos.MS_Set_Select     (pos.ID);
            NzPosPrice.Text         = pos.mablaq.ToString(_FormatString);
            NzPos_Checked.Checked   = true;
        }

        private bool    IsOk            ()
        {
            if (!NzNaqdi_Checked.Checked && !NzPos_Checked.Checked)
            {
                MS_Message.Show("هیج مبلغی برای ثبت تسویه انتخاب نشده است");
                mS_Notify1.Show(NzGroupCache);
                mS_Notify1.Show(NzGroupPos);
                return false;
            }

            if (NzCachePrice.MS_Decimal <= 0 && NzNaqdi_Checked.Checked)
            {
                MS_Message.Show("مبلغ صندوق را انتخاب کنید ", "تسویه فاکتور");
                NzCachePrice.Focus();
                mS_Notify1.Show(NzCachePrice);
                return false;
            }
            if (NzPosPrice.MS_Decimal <= 0 && NzPos_Checked.Checked)
            {
                MS_Message.Show("مبلغ حساب بانکی را انتخاب کنید  ", "تسویه فاکتور");
                NzPosPrice.Focus();
                mS_Notify1.Show(NzPosPrice);
                return false;
            }
            if (NzCache.MS_Get_Selected() == null && NzNaqdi_Checked.Checked)
            {
                MS_Message.Show("  صندوق را انتخاب کنید ", "تسویه فاکتور");
                NzCache.Focus();
                mS_Notify1.Show(NzCache);
                return false;
            }
            if (NzPos.MS_Get_Selected() == null &&   NzPos_Checked.Checked)
            {
                MS_Message.Show("  حساب بانکی را انتخاب کنید  ", "تسویه فاکتور");
                NzPos.Focus();
                mS_Notify1.Show(NzPos);
                return false;
            }
            return true;
        }
        private void    SaveHead        ()
        {
            _DP             = _DP ?? new DPOperation();
            _DP.FK_Faktor   = _FactorPaymnet.IDFactor;
            _DP.FK_Salmali  = SystemConstant.ActiveYear.Salmali;
            _DP.FK_ShaXs    = _FactorPaymnet.IDPeople;
            _DP.FK_User_Add = SystemConstant.ActiveUser.ID;
            _DP.tarikh      = DateTime.Now.Date;
            _DP.tarikh_add  = DateTime.Now;
            _DP.kind        = (byte)Enums.NzPaymentOperatingKind.Daryaft;
            _DP.takhfif     = 0;
            _DP.sharh       = "تسویه فروش با بارکدخوان";

            if (_DP.ID == 0)
                _DP.serial = GetMaxSerial();
        }
        private void    SaveCache       ()
        {
            var cache           = _DP.PayBoxOP.SingleOrDefault(x => x.kind == (byte)Enums.NzPaymentOperatingKind.Naqd);
            var SelectedCache   = NzCache.MS_Get_Selected() as Accounts;

            if (NzCachePrice.MS_Decimal == 0)
            {
                if (cache != null)
                    cache.State = Enums.NzItemState.Deleted;
            }
            else
            {
                if (cache == null)
                {
                    cache = new PayBoxOperation()
                    {
                        State = Enums.NzItemState.AddedNew,
                        kind = (byte)Enums.NzPaymentOperatingKind.Naqd,
                        DpHead = _DP,
                        FK_Salmali = _DP.FK_Salmali,
                    };
                    _DP.PayBoxOP.Add(cache);
                }
                else
                    cache.State = Enums.NzItemState.Modified;

                cache.FK_Xazaneh_Bad = SelectedCache.ID;

                cache.mablaq = NzCachePrice.MS_Decimal;
                cache.sharh = null;
            }
        }
        private void    SavePOS         ()
        {
            var pos = _DP.PayBoxOP.SingleOrDefault(x => x.kind == (byte)Enums.NzPaymentOperatingKind.Bank_POS);
            var SelectedPOS = NzPos.MS_Get_Selected() as Accounts;

            if (NzPosPrice.MS_Decimal == 0)
            {
                if (pos != null)
                    pos.State = Enums.NzItemState.Deleted;
            }
            else
            {
                if (pos == null)
                {
                    pos = new PayBoxOperation()
                    {
                        State = Enums.NzItemState.AddedNew,
                        kind = (byte)Enums.NzPaymentOperatingKind.Bank_POS,
                        DpHead = _DP,
                        FK_Salmali = _DP.FK_Salmali,
                    };
                    _DP.PayBoxOP.Add(pos);
                }
                else
                    pos.State = Enums.NzItemState.Modified;

                pos.FK_Xazaneh_Bad = SelectedPOS.ID;

                pos.mablaq = NzPosPrice.MS_Decimal;
                pos.sharh = null;
            }
        }
        private void    Save            ()
        {
            try
            {
                if (!IsOk())
                    return;

                SaveHead();
                SaveCache();
                SavePOS();

                if (_DP.ID > 0 && _DP.PayBoxOP.All(x => x.State == Enums.NzItemState.Deleted))
                {
                    _Manager.Delete(_DP.ID);
                    //_DP = new DPOperation();
                }
                else
                {
                    _Manager.Save(_DP);
                }

                //RefreshMounts();
                new Form_Notify("تسویه", "مبلغ تسویه بـا مـوفـقـیـت ثـبـت شـــد.",
                        Form_Notify.FarsiMessageBoxIcon.اضافه)
                    .Popup(Form_Notify.Direction_Show.Right_To_Left, 2500);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MS_Message.Show("خطا در ذخیره اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
            }
        }
        private int     GetMaxSerial    ()
        {
            try
            {
                return _Manager.GetMaxSerial(new
                {
                    Kind = (byte)Enums.NzPaymentOperatingKind.Daryaft,
                    Year = SystemConstant.ActiveYear.Salmali,
                }) + 1;

            }
            catch (Exception ex)
            {
                log.Error(ex);
                return 1;
            }
        }
        #endregion

        private void NzNaqdi_Checked_CheckedChanged     (object sender, EventArgs e)
        {
            NzCache.Enabled = NzCachePrice.Enabled = NzNaqdi_Checked.Checked;
            
            if (NzNaqdi_Checked.Checked)
                NzCachePrice.MS_Decimal = NzRemaind.MS_Decimal ?? 0;
            else
                NzCachePrice.MS_Decimal = 0;
        }
        private void NzCachePrice_TextChanged           (object sender, EventArgs e)
        {
            RefreshMounts();
        }
        private void NzPos_Checked_CheckedChanged       (object sender, EventArgs e)
        {
            NzPos.Enabled = NzPosPrice.Enabled = NzPos_Checked.Checked;

            if (NzPos_Checked.Checked)
                NzPosPrice.MS_Decimal = NzRemaind.MS_Decimal ?? 0;
            else
                NzPosPrice.MS_Decimal = 0;
        }
        private void NzPosPrice_TextChanged             (object sender, EventArgs e)
        {
            RefreshMounts();
        }
        
        private void FormBarCodePayment_Shown           (object sender, EventArgs e)
        {
            Init();
        }

        private void NzSaveSetting_Click                (object sender, EventArgs e)
        {
            SaveSetting();
        }
        private void NzSavePayment_Click                (object sender, EventArgs e)
        {
            Save();
        }
        private void NzDeleteDp_Click                   (object sender, EventArgs e)
        {
            try
            {
                if (_DP!=null && _DP.ID > 0 )
                    _Manager.Delete(_DP.ID);

                new Form_Notify("تسویه", "فاکتور به صورت   نسـیه   ثـبـت شـــد.",
                        Form_Notify.FarsiMessageBoxIcon.اضافه)
                    .Popup(Form_Notify.Direction_Show.Right_To_Left, 2500);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                log.Error(ex); 
            }
        }

        private void FormBarCodePayment_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                DialogResult = DialogResult.Cancel;
            else if(e.KeyCode == Keys.F2)
                NzSavePayment.PerformClick();
            else if (e.KeyCode == Keys.F5)
                NzDeleteDp.PerformClick();
            else if (e.KeyCode == Keys.F8)
                NzPos_Checked.Checked = !NzPos_Checked.Checked;
            else if (e.KeyCode == Keys.F9)
                NzNaqdi_Checked.Checked = !NzNaqdi_Checked.Checked;
        }
    }
}
