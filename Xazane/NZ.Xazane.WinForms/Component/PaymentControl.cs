using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control;
using NZ.Xazane.Business;
using NZ.Xazane.Model;
using NZ.Xazane.Model.Models;
using NZ.Xazane.Model.ViewModel;
using ShareLib;
using ShareLib.Interfaces;
using ShareLib.Utils;

namespace NZ.Xazane.WinForms.Component
{
    public partial class PaymentControl : UserControl,IPaymentCommand
    {
        #region Logging
        private static readonly log4net.ILog _log =
            log4net
                .LogManager
                .GetLogger
                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion
        #region Fields
        private decimal         _Price;
        private long            _FK_People, 
                                _FK_Factor;
        private DPOperation     _DP = null;
        private DpManager       _Manager;
        private PaymentBarcodeSetting _Setting;
        private string              _FormatString = "0,0.##;(0,0.##); ";

        #endregion
        #region Interface
        public void     ResetPay               ()
        {
            _DP             = new DPOperation();
            _Price          = 0;
            _FK_Factor      = 0;
            _FK_People      = 0;
            NzCachePrice.MS_Decimal     = 0;
            NzPosPrice.MS_Decimal       = 0;

            RefreshMounts   ();
        }
        public void     SetFactore             (long ID)
        {
            _FK_Factor = ID;
        }
        public void     SetMount               (decimal Price)
        {
            _Price = Price;
            RefreshMounts();
        }
        public void     SetPerson              (long ID)
        {
            _FK_People = ID;
        }
        public void     LoadComponent          (long IdFactor=0,decimal Mablaq=0)
        {
            _Price                      = Mablaq;
            _Manager                    = new DpManager();
            NzCache.Refresh_Grid        (Enums.NzAccountKind.Cache);
            NzPos.Refresh_Grid          (Enums.NzAccountKind.BankAccount);
            LoadSettings                ();

            if (IdFactor > 0)
                LoadPayment             (IdFactor);
        }
        public void     CachePayment           ()
        {

            NzPriceCache.PerformClick();
            NzPosClear.PerformClick();
            NzSavePayment.PerformClick();
        }
        public void     BankPayment            ()
        {
            NzPricePos.PerformClick();
            NzCacheClear.PerformClick();
            NzSavePayment.PerformClick();
        }
        public void     SendToPos              ()
        {
            MS_Message.Show("هیچ دستگاهی معرفی نشده است");
        }
        public decimal  GetPos                 ()
        {
            try
            {
                var pos = _DP.PayBoxOP.SingleOrDefault(x => x.kind == (byte)Enums.NzPaymentOperatingKind.Bank_POS);
                return pos?.mablaq ?? 0;
            }
            catch (Exception ex)
            {
                _log.Error(ex);
                return 0;
            }
        }
        public decimal  GetCache               ()
        {
            try
            {
                var cache = _DP.PayBoxOP.SingleOrDefault(x => x.kind == (byte)Enums.NzPaymentOperatingKind.Naqd);
                return cache?.mablaq ?? 0;
            }
            catch (Exception ex)
            {
                _log.Error(ex);
                return 0;
            }
        }
        #endregion                             
        public          PaymentControl         ()
        {
            InitializeComponent();
            _DP = new DPOperation();
        }
        #region Methods

        private void    LoadPayment            (long IdFactor )
        {
            var mgr = new DpManager();
            _DP = mgr.GetItemByFactor(IdFactor);
            if(_DP == null)
                return;

            _FK_Factor      = IdFactor;
            _FK_People      = _DP.FK_ShaXs ?? 0;
            LoadCache       ();
            LoadPos         ();
            RefreshMounts   ();

        }
        private void    LoadCache              ()
        {
            var cache = _DP.PayBoxOP.SingleOrDefault(x => x.kind == (byte)Enums.NzPaymentOperatingKind.Naqd);
            if(cache==null)
                return;
            NzCache.MS_Set_Select(cache.ID);
            NzCachePrice.Text = cache.mablaq.ToString(_FormatString);
        }
        private void    LoadPos                ()
        {
            var pos         = _DP.PayBoxOP.SingleOrDefault(x => x.kind == (byte)Enums.NzPaymentOperatingKind.Bank_POS);
            if (pos == null)
                return;
            NzPos.MS_Set_Select(pos.ID);
            NzPosPrice.Text = pos.mablaq.ToString(_FormatString);
        }
        private bool    IsOk                   ()
        {
            if (_FK_Factor == 0)
            {
                MS_Message.Show("فاکتوری وارد نشده است", "تسویه فاکتور");
                return false;
            }
            if (_FK_People == 0)
            {
                MS_Message.Show("شخصی را انتخاب کنید ", "تسویه فاکتور");
                return false;
            }
            if (_Price == 0)
            {
                MS_Message.Show("مبلغ فاکتور صفر است", "تسویه فاکتور");
                return false;
            }
            
            if (NzCachePrice.MS_Decimal > 0 && NzCache.MS_Get_Selected()    == null)
            {
                MS_Message.Show("صندوق را انتخاب کنید","تسویه فاکتور");
                NzCache.Focus();
                mS_Notify1.Show(NzCache);
                return false;
            }
            if (NzPosPrice.MS_Decimal > 0   && NzPos.MS_Get_Selected()      == null)
            {
                MS_Message.Show("حساب بانکی را انتخاب کنید", "تسویه فاکتور");
                NzPos.Focus();
                mS_Notify1.Show(NzPos);
                return false;
            }

            return true;
        }
        private int     GetMaxSerial           ()
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
                _log.Error(ex);
                return 1;
            }
        }
        private void    SetItemsNoChanges      ()
        {
            _DP.PayBoxOP.MSZ_ForEach(x =>
            {
                x.State = Enums.NzItemState.NotChanged;
            });
        }
        private void    SaveHead               ()
        {
            _DP                 = _DP ?? new DPOperation();
            _DP.FK_Faktor       = _FK_Factor;
            _DP.FK_Salmali      = SystemConstant.ActiveYear.Salmali;
            _DP.FK_ShaXs        = _FK_People;
            _DP.FK_User_Add     = SystemConstant.ActiveUser.ID;
            _DP.tarikh          = DateTime.Now.Date;
            _DP.tarikh_add      = DateTime.Now;
            _DP.kind            = (byte) Enums.NzPaymentOperatingKind.Daryaft;
            _DP.takhfif         = 0;
            _DP.sharh           = "تسویه فروش با بارکدخوان";

            if (_DP.ID == 0)
                _DP.serial = GetMaxSerial();
        }
        private void    SaveCache              ()
        {
            var cache           = _DP.PayBoxOP.SingleOrDefault(x => x.kind == (byte)Enums.NzPaymentOperatingKind.Naqd);
            var SelectedCache   = NzCache.MS_Get_Selected() as Accounts;

            if (NzCachePrice.MS_Decimal == 0 )
            {
                if(cache != null)
                    cache.State = Enums.NzItemState.Deleted;
            }
            else
            {
                if (cache == null)
                {
                    cache = new PayBoxOperation()
                    {
                        State       = Enums.NzItemState.AddedNew,
                        kind        = (byte)Enums.NzPaymentOperatingKind.Naqd,
                        DpHead      = _DP,
                        FK_Salmali  = _DP.FK_Salmali,
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
        private void    SavePOS                ()
        {
            var pos         = _DP.PayBoxOP.SingleOrDefault(x => x.kind == (byte)Enums.NzPaymentOperatingKind.Bank_POS);
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
                        State       = Enums.NzItemState.AddedNew,
                        kind        = (byte)Enums.NzPaymentOperatingKind.Bank_POS,
                        DpHead      = _DP,
                        FK_Salmali  = _DP.FK_Salmali,
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
        private void    Save                   ()
        {
            try
            {
                if(!IsOk())
                    return;

                SaveHead    ();
                SaveCache   ();
                SavePOS     ();

                if (_DP.ID > 0 && _DP.PayBoxOP.All(x => x.State == Enums.NzItemState.Deleted))
                {
                    _Manager.Delete     (_DP.ID);
                    _DP = new DPOperation();
                }
                else
                {
                    _Manager.Save       (_DP);
                    SetItemsNoChanges   ();
                }
                RefreshMounts();

                new Form_Notify("تسویه", "مبلغ تسویه بـا مـوفـقـیـت ثـبـت شـــد.",
                        Form_Notify.FarsiMessageBoxIcon.اضافه)
                    .Popup(Form_Notify.Direction_Show.Right_To_Left, 2500);
            }
            catch (Exception ex)
            {
                _log.Error(ex);
                MS_Message.Show("خطا در ذخیره اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
            }
        }
        private void    RefreshMounts          ()
        {
            NzSumCache.MS_Decimal =
                        _DP
                        .PayBoxOP
                        .SingleOrDefault
                                (x => x.kind == (byte) Enums.NzPaymentOperatingKind.Naqd)
                        ?.mablaq ?? 0;
            NzSumPos.MS_Decimal =
                     _DP
                    .PayBoxOP
                    .SingleOrDefault
                        (x => x.kind == (byte)Enums.NzPaymentOperatingKind.Bank_POS)
                    ?.mablaq ?? 0;

            NzSum.MS_Decimal        = NzSumCache.MS_Decimal + NzSumPos.MS_Decimal;
            NzRemaind.MS_Decimal    = _Price - NzSum.MS_Decimal;
        }
        private void    LoadSettings           ()
        {
             
            _Setting = PaymentBarcodeSetting.FromXML<PaymentBarcodeSetting>();
            if (_Setting != null)
            {
                if (NzCache.InvokeRequired)
                    NzCache.Invoke(new MethodInvoker(delegate
                    {
                        NzCache.MS_Set_Select(_Setting.Cache);
                    }));
                else
                    NzCache.MS_Set_Select(_Setting.Cache);
                //=========================================
                if (NzPos.InvokeRequired)
                    NzPos.Invoke(new MethodInvoker(delegate
                    {
                        NzPos.MS_Set_Select(_Setting.Pos);
                    }));
                else
                    NzPos.MS_Set_Select(_Setting.Pos);
            } 
        }
        private void    SaveSetting            ()
        {
            Task.Run(() =>
            {
                _Setting = _Setting ?? new PaymentBarcodeSetting();

                if (NzCache.MS_Get_Selected() is Accounts cache)
                    _Setting.Cache = cache.ID;

                if (NzPos.MS_Get_Selected() is Accounts pos)
                    _Setting.Pos = pos.ID;

                _Setting.ToXml();

            }).ConfigureAwait(false);
        }

        #endregion
        //================
        private void NzSaveSetting_Click        (object sender, EventArgs e)
        {
            SaveSetting();
        }
        private void NzSavePayment_Click        (object sender, EventArgs e)
        {
            Save();
        }

        private void NzRemaindCache_Click       (object sender, EventArgs e)
        {
            if(NzRemaind.MS_Decimal > 0)
                NzCachePrice.Text = (NzRemaind.MS_Decimal ?? 0).ToString(_FormatString);
        }
        private void NzPriceCache_Click         (object sender, EventArgs e)
        {
            NzCachePrice.Text = _Price.ToString(_FormatString);
        }
        private void NzCacheClear_Click         (object sender, EventArgs e)
        {
            NzCachePrice.MS_Decimal = 0;
        }

        private void NzPosRemind_Click          (object sender, EventArgs e)
        {
            if(NzRemaind.MS_Decimal > 0)
                NzPosPrice.Text = (NzRemaind.MS_Decimal ?? 0).ToString(_FormatString);
        }
        private void NzPricePos_Click           (object sender, EventArgs e)
        {
            NzPosPrice.Text = _Price.ToString(_FormatString);
        }
        private void NzPosClear_Click           (object sender, EventArgs e)
        {
            NzPosPrice.MS_Decimal = 0;
        }

      
    }
}
