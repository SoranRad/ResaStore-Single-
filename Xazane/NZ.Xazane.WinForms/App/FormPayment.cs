using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using MS_Control;
using MS_Control.Controls;
using MS_Control.MainForms;
using MS_Control.Tarikh;
using NZ.Xazane.Business;
using NZ.Xazane.Model;
using NZ.Xazane.Model.Models;
using NZ.Xazane.Model.Report;
using NZ.Xazane.Model.ViewModel;
using ShareLib;
using ShareLib.Interfaces;
using ShareLib.Models;
using ShareLib.Utils;
using ShareLib.ViewModel;

namespace NZ.Xazane.WinForms.App
{
    public partial class FormPayment : Form_Mother_IRANSans, IForm_Editor
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion
        #region Fields
        private DPOperation                     _DP             = null;
        private bool                            _Is_Edit        = false;
        private Enums.NzPaymentOperatingKind    _Kind           = Enums.NzPaymentOperatingKind.Daryaft;
        private DpManager                       _Manager;
        private long                            _ID             = 0;
        private long?                           _FactorID       = null;
        private bool                            _CacheLoaded    = false;
        private bool                            _PosLoaded      = false;
        private bool                            _DoRefresh      = true;
        private string                          _SimpleText     = "";
        private string                          _Dot            = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
        private int                             _Pos            = 0;
        private int                             _Len            = 0;
        private BindChequeList                  _Bind;
        private int                             _Serial         = 0;
        private string                          _FormatString   = "0,0.##;(0,0.##); ";
        private FactorPaymentMessage            _FactorPaymnet  = null;
        public event EventHandler               MS_Do_Save;

        #endregion
        #region Constructor
        public FormPayment  (   long ID = 0, 
                                Enums.NzPaymentOperatingKind Kind = Enums.NzPaymentOperatingKind.Daryaft
                            )
        {
            InitializeComponent();
            _Manager    = new DpManager();
            _ID         = ID;
            _Kind       = Kind;
        }
        public FormPayment  (FactorPaymentMessage PaymentMessage)
        {
            InitializeComponent();
            _Manager        = new DpManager();
            _ID             = 0;
            _Kind           = PaymentMessage.Kind;
            _FactorID       = PaymentMessage.IDFactor;
            _FactorPaymnet  = PaymentMessage;
            NzFactorMablaq.Show();
            NzLableFactor.Show();
            NzFactorMablaq.MS_Decimal = PaymentMessage.Amount;
        }
        #endregion
        #region Methods
        public void     ValidationDemoVersion   ()
        {
            if (!SystemConstant.IsDemo)
                return  ;
            
            var Mgr     = new ReportManager();
            var count   = Mgr.GetItem<PaymentItems>(new{},null);

            if (count.ItemsCount >= SystemConstant.DemoCount)
            {
                MS_Message.Show("نسخه برنامه شما آزمایشی می باشد لطفا آن را ارتقا دهید", "خطا", MessageBoxButtons.OK);
                NzSave.Enabled = false;
            }
        } 
        private void    LoadItem                ()
        {
            try
            {
                _DP                 = _Manager.GetItem(_ID);
                _Is_Edit            = true;
                _Bind               = new BindChequeList(_DP);
                _Kind               = (Enums.NzPaymentOperatingKind) _DP.kind;
                var cache           = _DP.PayBoxOP.SingleOrDefault(x => x.kind == (byte) Enums.NzPaymentOperatingKind.Naqd);
                var pos             = _DP.PayBoxOP.SingleOrDefault(x => x.kind == (byte)Enums.NzPaymentOperatingKind.Bank_POS);

                #region Head
                NzSerial.MS_Decimal = _DP.serial;
                NzDate.MS_Tarikh    = new MS_Structure_Shamsi(_DP.tarikh);
                NzOff.Text          = (_DP.takhfif ?? 0).ToString(_FormatString);
                NzDescription.Text  = _DP.sharh;

                NzCustomer.MS_Set_Select        (_DP.FK_ShaXs);
                NzRemainCustomer.NzSetCustoemr  (_DP.FK_ShaXs??0);
                NzCustomer.Enabled  = _DP.FK_Faktor == null;
                NzOff.Enabled       = _DP.FK_Faktor == null;
                #endregion
                #region Grids
                if (_Kind == Enums.NzPaymentOperatingKind.Daryaft)
                    NzGridRecieve.DataSource = _Bind;
                else if (_Kind == Enums.NzPaymentOperatingKind.Pardaxt)
                    NzGridPayment.DataSource = _Bind;
                #endregion
                #region Cache

                if (cache != null)
                {
                    NzCache.Refresh_Grid        (_Manager.Connection, Enums.NzAccountKind.Cache);
                    _CacheLoaded                = true;
                    NzCache.MS_Set_Select       (_Kind == Enums.NzPaymentOperatingKind.Daryaft
                                                    ? cache.FK_Xazaneh_Bad
                                                    : cache.FK_Xazaneh_Bas);
                    NzCacheAmount.Text          = cache.mablaq.ToString(_FormatString);
                    NzCacheDescription.Text     = cache.sharh;
                }
                #endregion
                #region Pos Bank
                if (pos != null)
                {
                    NzBankAccount.Refresh_Grid  (_Manager.Connection, Enums.NzAccountKind.BankAccount);
                    _PosLoaded                  = true;
                    NzBankAccount.MS_Set_Select (_Kind == Enums.NzPaymentOperatingKind.Daryaft
                                                    ? pos.FK_Xazaneh_Bad
                                                    : pos.FK_Xazaneh_Bas);
                    NzBankAmount.Text           = pos.mablaq.ToString(_FormatString);
                    NzBankDecription.Text       = pos.sharh;
                    NzIdentifier.Text           = pos.serialPeygiri?.ToString();
                }
                #endregion

                RefreshSum();
                ChangeUI();
            }
            catch (Exception ex)
            {
                MS_Message.Show("سیستم قادر به خواندن اطلاعات نیست","خطا در خواندن اطلاعات"
                    ,ex.Message,MessageBoxButtons.OK);
                Reset();
            }
        }
        private void    Reset                   ()
        {
            _DP                         = new DPOperation();
            _DP.kind                    = (byte) _Kind;
            _Bind                       = new BindChequeList(_DP);
            NzGridRecieve.DataSource    = _Bind;

            #region Head
            NzCustomer.MS_Set_Select(null);
            NzRemainCustomer.Text       = "";
            NzCustomer.Focus();
            #endregion
            #region Grid
            if (_Kind == Enums.NzPaymentOperatingKind.Daryaft)
                NzGridRecieve.DataSource = _Bind;
            else if (_Kind == Enums.NzPaymentOperatingKind.Pardaxt)
                NzGridPayment.DataSource = _Bind;
            #endregion
            #region Cache
            if(_CacheLoaded)
                NzCache.MS_Set_Select   (null);
            NzCacheAmount.MS_Decimal    = 0;
            NzCacheDescription.Text     = "";
            #endregion
            #region POS
            if(_PosLoaded)
                NzBankAccount.MS_Set_Select(null);

            NzBankAmount.MS_Decimal     = 0;
            NzBankDecription.Text       = "";
            NzIdentifier.Text           = "";
            #endregion

            GetMaxSerial        ();
            RefreshSum          ();

            NzCustomer.Focus    ();
        }
        private void    Save                    ()
        {
            if      (_DP.ID == 0)
            {
                _DP.kind            = (byte) _Kind;
                _DP.FK_Salmali      = SystemConstant.ActiveYear.Salmali;
                _DP.FK_User_Add     = SystemConstant.ActiveUser.ID;
                _DP.tarikh_add      = DateTime.Now;

                if (_FactorPaymnet != null)
                    _DP.FK_Faktor   = _FactorPaymnet.IDFactor;
            }
            else if (_Is_Edit)
            {
                _DP.FK_User_Edit    = SystemConstant.ActiveUser.ID;
                _DP.tarikh_edit     = DateTime.Now;
            }

            _DP.tarikh              = NzDate.MS_Tarikh.Value.ToDatetime();
            _DP.serial              = Convert.ToInt32(NzSerial.MS_Decimal);
            _DP.FK_ShaXs            = (NzCustomer.MS_Get_Selected() as People).ID;
            _DP.sharh               = string.IsNullOrEmpty(NzDescription.Text.Trim())?null: NzDescription.Text;
            _DP.takhfif             = NzOff.MS_Decimal;
            
            #region Cache
            var cache           = _DP.PayBoxOP.SingleOrDefault(x => x.kind == (byte)Enums.NzPaymentOperatingKind.Naqd);
            var SelectedCache   = NzCache.MS_Get_Selected() as Accounts;

            if (SelectedCache == null && cache != null)
                cache.State = Enums.NzItemState.Deleted;
            else if (SelectedCache != null)
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

                if (_Kind == Enums.NzPaymentOperatingKind.Pardaxt)
                    cache.FK_Xazaneh_Bas = SelectedCache.ID;
                else if (_Kind == Enums.NzPaymentOperatingKind.Daryaft)
                    cache.FK_Xazaneh_Bad = SelectedCache.ID;

                cache.mablaq    = NzCacheAmount.MS_Decimal;
                cache.sharh     = string.IsNullOrEmpty(NzCacheDescription.Text.Trim())
                                        ? null
                                        : NzCacheDescription.Text.Trim();
            }
            #endregion
            #region POS
            var bank           = _DP.PayBoxOP.SingleOrDefault(x => x.kind == (byte)Enums.NzPaymentOperatingKind.Bank_POS);
            var SelectedBank   = NzBankAccount.MS_Get_Selected() as Accounts;

            if (SelectedBank == null && bank != null)
                bank.State = Enums.NzItemState.Deleted;
            else if (SelectedBank != null)
            {
                if (bank == null)
                {
                    bank = new PayBoxOperation()
                    {
                        State       = Enums.NzItemState.AddedNew,
                        kind        = (byte)Enums.NzPaymentOperatingKind.Bank_POS,
                        DpHead      = _DP,
                        FK_Salmali  = _DP.FK_Salmali,
                    };
                    _DP.PayBoxOP.Add(bank);
                }
                else
                    bank.State = Enums.NzItemState.Modified;

                if (_Kind == Enums.NzPaymentOperatingKind.Pardaxt)
                    bank.FK_Xazaneh_Bas = SelectedBank.ID;
                else if (_Kind == Enums.NzPaymentOperatingKind.Daryaft)
                    bank.FK_Xazaneh_Bad = SelectedBank.ID;

                bank.serialPeygiri  = Convert.ToInt64(NzIdentifier.MS_Decimal);
                bank.mablaq         = NzBankAmount.MS_Decimal;
                bank.sharh          = string.IsNullOrEmpty(NzBankDecription.Text.Trim())
                                            ? null
                                            : NzBankDecription.Text.Trim();
            }
            #endregion

            if (_Serial == NzSerial.MS_Decimal && _DP.ID == 0)
            {
                GetMaxSerial();
                _DP.serial = Convert.ToInt32(NzSerial.MS_Decimal);
            }
        }
        private bool    IsOk                    ()
        {
            if (SystemConstant.ActiveYear.is_close)
            {
                MS_Message.Show("سال مالی بسته شده است " +
                                "\n  نمی توانید ادامه دهید ");
                return false;
            }
            if (NzSerial.MS_Decimal == 0)
            {
                NzSerial.Focus();
                mS_Notify1.Show(NzSerial);
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

            if (NzCustomer.MS_Get_Selected() == null)
            {
                NzCustomer.Focus();
                mS_Notify1.Show(NzCustomer);
                return false;
            }
            var Customer = NzCustomer.MS_Get_Selected() as People;
            if (Customer.isBlock ?? false)
            {

            }
            if (    (NzSumCheque.MS_Decimal ?? 0) == 0 
                &&  (NzSumCache.MS_Decimal ?? 0) == 0 
                &&  (NzSumPos.MS_Decimal ?? 0) == 0)
            {
                MS_Message.Show("کاربر گرامی!\n" +
                                "شما هیچ مبلغی را وارد نکرده " +
                                "اید لذا نمی توانید اطلاعات را ذخیره کنید");
                mS_Notify1.Show(panel1);
                return false;
            }
            //================== صندوق
            var cache = NzCache.MS_Get_Selected() as Accounts;
            if (cache == null && NzCacheAmount.MS_Decimal > 0)
            {
                NzTabInfo.SelectedTab = NzTabCache;
                NzCache.Focus();
                mS_Notify1.Show(NzCache);
                return false;
            }
            //================= حساب بانکی 
            var pos = NzBankAccount.MS_Get_Selected() as Accounts;
            if (pos == null && NzBankAmount.MS_Decimal > 0)
            {
                NzTabInfo.SelectedTab = NzTabPos;
                NzBankAccount.Focus();
                mS_Notify1.Show(NzBankAccount);
                return false;
            }
            //================

            if (    (_DP.ID == 0 && _Serial    != NzSerial.MS_Decimal)
                ||  (_DP.ID > 0  && _DP.serial != NzSerial.MS_Decimal))
            {
                var r = _Manager.IsCodeUnique(new
                {
                    Year    = SystemConstant.ActiveYear.Salmali,
                    Kind    = (byte) _Kind,
                    Serial  = NzSerial.MS_Decimal,
                });

                if (!r)
                {
                    MS_Message.Show("شماره سریال تکراری است");
                    NzSerial.Focus();
                    mS_Notify1.Show(NzSerial);
                    return false;
                }
            }
            return true;
        }
        private void    Init                    ()
        {
            ChangeUI                    ();
            NzCustomer.Refresh_Grid     (_Manager, (byte)3);

            if (_Kind == Enums.NzPaymentOperatingKind.Daryaft)
                NzBankMenu.RefreshControl   (new Size(250, 150), _Manager.Connection);
            else
                NzAccountPopup.RefreshControl(new Size(450, 150), _Manager.Connection,Enums.NzAccountKind.BankAccount);

            NzDatePopup.NzSelected      = DateTime.Now;
            NzGridPayment.FilterMode    = FilterMode.None;
            NzGridRecieve.FilterMode    = FilterMode.None;
            NzDate.MS_Tarikh            = new MS_Structure_Shamsi(DateTime.Now);

            if (_ID > 0)
                LoadItem();
            else
                Reset();

            NzCustomer.MS_Next_Control = _Kind == Enums.NzPaymentOperatingKind.Daryaft 
                                            ? NzGridRecieve 
                                            : NzGridPayment;
            if (_FactorPaymnet != null )
            {
                if(_ID == 0)
                    NzCustomer.MS_Set_Select(_FactorPaymnet.IDPeople);

                NzCustomer.Enabled = false;
            }
            ValidationDemoVersion();
        }
        private void    ChangeUI                ()
        {
            NzTabInfo.TabPages.Remove (_Kind == Enums.NzPaymentOperatingKind.Daryaft 
                                            ? NzTabPayment 
                                            : NzTabRecieve
                                      );

            Text                    = _Kind.NzToString();
        }
        private void    GetMaxSerial            ()
        {
            try
            {
                _Serial  = _Manager.GetMaxSerial(new
                {
                    Kind = (byte)_Kind,
                    Year = SystemConstant.ActiveYear.Salmali,
                }) + 1;

                NzSerial.MS_Decimal = _Serial;
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در تولید کد سریال ", "خطا",ex.Message,MessageBoxButtons.OK);
            }
        }

        private void    ShowMenu                ()
        {
            if(_Kind==Enums.NzPaymentOperatingKind.Daryaft)
                ShowBankMenu();
            else
                ShowAccountMenu();
        }
        private void    ShowBankMenu            ()
        {
            if (NzGridRecieve.CurrentColumn == null || NzGridRecieve.CurrentRow==null)
                return;

            var key = NzGridRecieve.CurrentColumn.Key;
            if (key == "BankTitle")
            {
                var rec =
                    NzGridRecieve.CurrentRow == null ?
                        NzGridRecieve.Bounds
                        : NzGridRecieve.GetCellBounds
                            (NzGridRecieve.CurrentRow.Position, NzGridRecieve.RootTable.Columns["BankTitle"]);

                NzBankMenu.NzSelected = null;
                NzBankMenu.Show(NzGridRecieve, new Point(rec.X + rec.Width, rec.Y + rec.Height), ToolStripDropDownDirection.BelowLeft);
                SendKeys.Send("{TAB}");
            }
        }
        private void    ShowAccountMenu         ()
        {
            if (NzGridPayment.CurrentColumn == null || NzGridPayment.CurrentRow == null)
                return;

            var key = NzGridPayment.CurrentColumn.Key;
            if (key == "PayAccountTitle")
            {
                var rec =
                    NzGridPayment.CurrentRow == null ?
                        NzGridPayment.Bounds
                        : NzGridPayment.GetCellBounds(NzGridPayment.CurrentRow.Position, NzGridPayment.RootTable.Columns["PayAccountTitle"]);

                NzAccountPopup.NzSelected = null;
                NzAccountPopup.Show(NzGridPayment, new Point(rec.X + rec.Width, rec.Y + rec.Height), ToolStripDropDownDirection.BelowLeft);
                SendKeys.Send("{TAB}");
            }
        }

        private void    RemoveUnSavedRow        ()
        {
            try
            {
                if(_Kind == Enums.NzPaymentOperatingKind.Daryaft)
                _DP
                    .ChequeOP
                    .Where  (x=> x.ID == 0 
                            && (x.mablaq==null || x.FK_Bank==null  || x.mablaq == 0))
                    .ToList ()
                    .MSZ_ForEach(x =>
                    {
                        _Bind.Remove(x);
                    });
                else if(_Kind == Enums.NzPaymentOperatingKind.Pardaxt)
                    _DP
                        .ChequeOP
                        .Where(x => x.ID == 0
                                    && (x.mablaq == null || x.FK_Hesab_Pardaxtani == null || x.mablaq == 0))
                        .ToList()
                        .MSZ_ForEach(x =>
                        {
                            _Bind.Remove(x);
                        });
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void    SetItemsNoChanges       ()
        {
            _DP.ChequeOP.MSZ_ForEach(x =>
            {
                x.State = Enums.NzItemState.NotChanged;
            });
            _DP.PayBoxOP.MSZ_ForEach(x =>
            {
                x.State = Enums.NzItemState.NotChanged;
            });
        }
        private void    RefreshSum              ()
        {
            NzSumCache.MS_Decimal   = NzCacheAmount.MS_Decimal;
            NzSumPos.MS_Decimal     = NzBankAmount.MS_Decimal;
            NzSumCheque.MS_Decimal  = _DP
                                        .ChequeOP
                                        .Where(x => x.State != Enums.NzItemState.Deleted)
                                        .Sum(x => (decimal?)x.mablaq) ??0 ;

            NzLableCheque.Text = _DP
                                    .ChequeOP
                                    .Count(x => x.State != Enums.NzItemState.Deleted) 
                                    + @"   فقره چـک :";

            NzRemain.MS_Decimal =
                (NzSumCache.MS_Decimal  ?? 0) + 
                (NzSumPos.MS_Decimal    ?? 0) + 
                (NzSumCheque.MS_Decimal ?? 0) - NzOff.MS_Decimal;
        }

        private long?   GetIDPayment            (long IDFactor)
        {
            try
            {
                var mgr     = new ReportManager();
                var item    = mgr.GetItem<FactorPaymentID>(new {ID = IDFactor}, null);

                return item?.ID;
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MS_Message.Show(
                    "سیستم قادر به لود اطلاعات تسویه نیست",
                    "خطای تسویه",
                    ex.Message,
                    MessageBoxButtons.OK);
            }

            return null;
        }

        private void    Print                   (Enums.NzKindPrint KindPrint)
        {
            if (_DP.ID == 0)
            {
                var r = MS_Message.Show("کاربر گرامی ابتدا سند را ذخیره کنید" +
                                        "\n آیا مایلید آن را ذخیره کنید؟"
                    , "ذخیره", MessageBoxButtons.YesNo);
                if (r != DialogResult.Yes)
                    return;

                NzSave.PerformClick();
            }
            var Prn = new Print(new List<long>() { _DP.ID }, KindPrint, _Kind);
            Prn.Show(this);
        }
        #endregion
        #region Grid Recieve
        private void NzGridRecieve_EditModeChanged      (object sender, EventArgs e)
        {
            try
            {
                var Grid = sender as MS_GridX;
                var Row = Grid.CurrentRow;
                var Col = Grid.CurrentColumn;

                if (Row == null)
                    return;

                if (Grid.EditMode == EditMode.EditOn
                    && Grid.EditTextBox != null
                    && (Row.RowType == RowType.NewRecord || Row.RowType == RowType.Record)
                    && Col != null
                    && (Col.Key == "mablaq" || Col.Key == "shomare_check")
                )
                {
                    Grid.EditTextBox.KeyPress += EditTextBoxOnKeyPress;

                    if (Col.Key == "mablaq")
                        Grid.EditTextBox.TextChanged += EditTextBoxOnTextChanged;
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void NzGridRecieve_RowDoubleClick       (object sender, RowActionEventArgs e)
        {
            try
            {
                if (!(e.Row.RowType == RowType.Record || e.Row.RowType == RowType.NewRecord))
                    return;

                var Grid = sender as MS_GridX;

                if (Grid.CurrentColumn != null
                    && (Grid.CurrentColumn.Key == "BankTitle" || Grid.CurrentColumn.Key == "PayAccountTitle"))
                    ShowMenu();
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void NzGridRecieve_CurrentCellChanged   (object sender, EventArgs e)
        {
            try
            {
                var Grid = sender as MS_GridX;

                if (Grid?.CurrentRow?.RowType == RowType.NewRecord)
                    ShowMenu();
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void NzGridRecieve_AddingRecord         (object sender, CancelEventArgs e)
        {
            try
            {
                if (sender == NzGridRecieve)
                {
                    if (NzGridRecieve.CurrentRow == null)
                        return;

                    var key = NzGridRecieve.CurrentRow.DataRow as ChequeOperation;

                    if (key != null)

                        if (   key?.mablaq == null
                            || key?.FK_Bank == null
                            || key?.mablaq == 0
                            || key?.FK_Bank == 0)
                        {
                            NzGridRecieve.CancelCurrentEdit();
                            NzGridRecieve.CurrentRow.CancelEdit();
                            e.Cancel = true;
                            //_Bind.RemoveAt(_Bind.Count - 1);
                            _Bind.Remove(key);

                        }
                }
                else if (sender == NzGridPayment)
                {
                    if (NzGridPayment.CurrentRow == null)
                        return;
                    var key = NzGridPayment.CurrentRow.DataRow as ChequeOperation;

                    if (key != null)

                        if (   key?.mablaq == null
                            || key?.FK_Hesab_Pardaxtani == null
                            || key?.mablaq == 0
                            || key?.FK_Hesab_Pardaxtani == 0)
                        {

                            NzGridPayment.CancelCurrentEdit();
                            NzGridPayment.CurrentRow.CancelEdit();
                            e.Cancel = true;
                            _Bind.Remove(key);

                            //_Bind.RemoveAt(_Bind.Count - 1);
                        }
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void NzGridRecieve_KeyPress             (object sender, KeyPressEventArgs e)
        {
            try
            {
                var Grid = sender as MS_GridX;

                if (Grid?.CurrentRow == null)
                    return;

                if (char.IsLetterOrDigit(e.KeyChar) && Grid.CurrentRow != null)
                {
                    var key = Grid.CurrentColumn?.Key;
                    var type = Grid.CurrentRow?.RowType;

                    if ((key == "BankTitle" || key == "PayAccountTitle")
                         && (type == RowType.NewRecord || type == RowType.Record)
                       )
                        ShowMenu();
                }
                else if (e.KeyChar == (char)27)
                {
                    e.Handled = true;
                    Grid.CurrentRow?.CancelEdit();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void Grid_ColumnButtonClick             (object sender, ColumnActionEventArgs e)
        {
            try
            {
                if (!(sender is MS_GridX Grid))
                    return;

                if (e.Column.Key == "D")
                {
                    if (Grid.CurrentRow?.DataRow == null)
                        return;

                    if (Grid.CurrentRow.RowType == RowType.NewRecord)
                    {
                        Grid.CancelCurrentEdit();
                        Grid.CurrentRow.CancelEdit();
                        _Bind.RemoveAt(_Bind.Count - 1);
                        _DoRefresh = false;
                        RefreshSum();
                        _DoRefresh = true;
                        return;
                    }
                    var row = Grid.CurrentRow.DataRow as ChequeOperation;
                    if (row.ID > 0)
                    {
                        var result = MS_Message
                            .Show("آیا برای حذف ردیف مورد نظر مطمئنید؟",
                                "حذف ردیف",
                                MessageBoxButtons.YesNo);
                        if (result != DialogResult.Yes)
                            return;
                    }
                    Grid.CurrentRow.Delete();
                    _DoRefresh = false;
                    RefreshSum();
                    _DoRefresh = true;
                }
                else if (e.Column.Key == "E")
                {

                    Grid.CurrentColumn = Grid.RootTable.Columns["PersianUsanceStr"];
                    SendKeys.Send("{F2}");

                }
                else if (e.Column.Key == "PersianUsanceStr")
                {
                    var Current = Grid.CurrentRow;

                    if (Current == null)
                        return;

                    if (Current?.DataRow == null)
                        Current.BeginEdit();


                    var rec =
                        Grid.CurrentRow == null ?
                            Grid.Bounds
                            : Grid
                                .GetCellBounds(Grid.CurrentRow.Position, Grid.RootTable.Columns["PersianUsanceStr"]);


                    NzDatePopup.Show(Grid,
                                        new Point(rec.X + rec.Width, rec.Y + rec.Height),
                                        ToolStripDropDownDirection.BelowLeft);

                    SendKeys.Send("{TAB}");
                }

            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void NzGridRecieve_CellUpdated          (object sender, ColumnActionEventArgs e)
        {
            try
            {
                var Grid = sender as MS_GridX;

                var row = Grid?.CurrentRow?.DataRow as ChequeOperation;

                if (row == null)
                    return;

                if (string.IsNullOrEmpty(row.PersianUsanceStr))
                    row.tarikh_sar_resid = null;

                if (e.Column.Key == "PersianUsanceStr" && !string.IsNullOrEmpty(row.PersianUsanceStr))
                {
                    if (MS_Structure_Shamsi.Is_Tarikh_True(row.PersianUsanceStr))
                    {
                        var tt = new MS_Structure_Shamsi(row.PersianUsanceStr);
                        row.tarikh_sar_resid = tt.ToDatetime().Date;
                    }
                }

                if (row?.ID > 0)
                    row.State = Enums.NzItemState.Modified;

                _DoRefresh = false;
                RefreshSum();
                _DoRefresh = true;
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void NzGridRecieve_RecordAdded          (object sender, EventArgs e)
        {
            _DoRefresh = false;
            RefreshSum();
            _DoRefresh = true;
        }
        private void NzGridRecieve_CancelingRowEdit     (object sender, RowActionCancelEventArgs e)
        {
            try
            {
                var Grid = sender as MS_GridX;

                if (Grid == null)
                    return;

                var Cur = e.Row;
                if (Cur != null)
                {
                    var row = Cur.DataRow as ChequeOperation;
                    if (row?.ID == 0)
                        _Bind.Remove(row);
                }
                Grid.CurrentRow?.CancelEdit();
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        #endregion
        #region TetxBox Events
        private void EditTextBoxOnKeyPress              (object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            var Grid = _Kind == Enums.NzPaymentOperatingKind.Daryaft
                ? NzGridRecieve
                : NzGridPayment;


            if (!(char.IsDigit(key) || key == '\b' || key == '.' || key == '+' || key == '-'))
                e.Handled = true;
            if (key == '.' && Grid.EditTextBox.Text.Contains("."))
                e.Handled = true;
            if (key == '+')
            {
                Grid.EditTextBox.Text += @"000";
                e.Handled = true;
            }
            else if (key == '-')
            {
                Grid.EditTextBox.Text += @"00";
                e.Handled = true;
            }
        }
        private void EditTextBoxOnTextChanged           (object sender, EventArgs eventArgs)
        {
            if (!_DoRefresh)
                return;
            _DoRefresh = false;

            var Grid = _Kind == Enums.NzPaymentOperatingKind.Daryaft
                        ? NzGridRecieve
                        : NzGridPayment;

            if(Grid.EditTextBox ==null )
                return;

            var TextBox = Grid.EditTextBox;
            _SimpleText = TextBox.Text.Replace(",", string.Empty);

            var start = _SimpleText.Contains(_Dot)
                                ? _SimpleText.IndexOf(_Dot) - 3
                                : _SimpleText.Length - 3;

            for (int i = start; i > 0; i -= 3)
                _SimpleText = _SimpleText.Insert(i, ",");

            TextBox.Text = _SimpleText;
            Set_Cursor_Location();
            
            _DoRefresh = true;
        }

        private void Set_Cursor_Location                ()
        {
            var Grid = _Kind == Enums.NzPaymentOperatingKind.Daryaft
                ? NzGridRecieve
                : NzGridPayment;

            int tm = Grid.EditTextBox.Text.Length - _Len;

            int x = _Pos + tm;
            x = x < 0 ? 0 : x;
            if (tm > 0)// طول زیاد شده باشد
            {
                Grid.EditTextBox.Select(_Pos + tm, 0);
            }
            else if (tm < 0) //  اگر طول کم شده باشد
            {
                var i = Math.Max(0, _Pos + tm);
                Grid.EditTextBox.Select(i, 0);
            }
            else // طول 
            {
                Grid.EditTextBox.Select(_Pos, 0);
            }
            //_Len = ms_grid.EditTextBox.Text.Length;
            //if (tm < 0 && TextLength == 1)
            //    base.Select(TextLength, 0);
            //else if(TextLength>0 && tm==0)
            //    base.Select(TextLength, 0);
            //else
            //    base.Select(x, 0);
            //_Len = TextLength;
        }
        #endregion
        #region Recieve
        private void NzDatePopup_NzSelectObject         (object sender, EventArgs e)
        {
            try
            {
                var Grid = _Kind == Enums.NzPaymentOperatingKind.Daryaft
                        ? NzGridRecieve
                        : NzGridPayment;

                var current = Grid.CurrentRow;
                if (current == null)
                    return;

                if (current?.DataRow == null)
                    current.BeginEdit();

                if (Grid.CurrentRow?.DataRow is ChequeOperation row)
                {
                    row.tarikh_sar_resid    = NzDatePopup.NzSelected;
                    row.PersianUsanceStr    = NzDatePopup.NzPersinaDate;

                    var cell                = Grid.CurrentRow.Cells["PersianUsanceStr"];
                    cell.Value              = NzDatePopup.NzPersinaDate;
                    cell.Text               = NzDatePopup.NzPersinaDate;

                    Grid.CurrentColumn      = _Kind == Enums.NzPaymentOperatingKind.Daryaft
                                                    ? Grid.RootTable.Columns["BankTitle"]
                                                    : Grid.RootTable.Columns["PayAccountTitle"];
                    NzDatePopup.Hide();
                    if (row.ID > 0)
                        row.State = Enums.NzItemState.Modified;
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                throw;
            }
        }
        private void NzDatePopup_NzCancelClicked        (object sender, EventArgs e)
        {
            try
            {
                var Grid = _Kind == Enums.NzPaymentOperatingKind.Daryaft
                        ? NzGridRecieve
                        : NzGridPayment;

                var Current = Grid.CurrentRow;

                if (Current?.DataRow == null)
                    Current.BeginEdit();

                if (Grid.CurrentRow?.DataRow is ChequeOperation row)
                {
                    row.tarikh_sar_resid = null;
                    row.PersianUsanceStr = string.Empty;

                    var cell = Grid.CurrentRow.Cells["PersianUsanceStr"];
                    cell.Value = null;
                    cell.Text = string.Empty;

                    Grid.CurrentColumn = _Kind == Enums.NzPaymentOperatingKind.Daryaft ?
                                NzGridRecieve.RootTable.Columns["BankTitle"]
                                : NzGridRecieve.RootTable.Columns["PayAccountTitle"];

                    NzDatePopup.Hide();

                    if (row.ID > 0)
                        row.State = Enums.NzItemState.Modified;
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void NzBankMenu_NzSelectObject          (object sender, EventArgs e)
        {
            try
            {
                if (NzBankMenu.NzSelected == null || NzGridRecieve.CurrentRow == null)
                    return;

                var obj = NzBankMenu.NzSelected;
                var Current = NzGridRecieve.CurrentRow;


                if (Current?.DataRow == null)
                    Current.BeginEdit();

                if (NzGridRecieve.CurrentRow.DataRow is ChequeOperation row)
                {
                    Current.Cells["BankTitle"].Value = obj.title;

                    row.FK_Bank = obj.ID;
                    row.BankTitle = obj.title;

                    if (row.ID > 0)
                        row.State = Enums.NzItemState.Modified;

                    NzBankMenu.Hide();
                    NzGridRecieve.CurrentColumn = NzGridRecieve.RootTable.Columns["mablaq"];
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void NzBankMenu_NzEscapedPress          (object sender, EventArgs e)
        {
            try
            {
                if (NzGridRecieve.CurrentRow == null)
                {
                    NzGridRecieve.CancelCurrentEdit();
                    return;
                }

                if (!(NzGridRecieve.CurrentRow.DataRow is ChequeOperation row))
                {
                    NzGridRecieve.CancelCurrentEdit();
                    NzGridRecieve.CurrentRow.CancelEdit();
                    return;
                }

                if (row.FK_Hesab_Pardaxtani != 0
                    && (row.mablaq > 0 || string.IsNullOrWhiteSpace(row.shomare_check ?? "")))
                    return;

                if (NzGridRecieve.CurrentRow.RowType == RowType.NewRecord
                    && NzBankMenu.NzSelected == null)
                {
                    NzGridRecieve.CancelCurrentEdit();
                    NzGridRecieve.CurrentRow.CancelEdit();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        #endregion
        private void FormPayment_Shown                  (object sender, EventArgs e)
        {
            Init();
        }
        private void FormPayment_KeyUp                  (object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F4:
                    NzSave.PerformClick();
                    break;
                case Keys.F6:
                    NzDescription.Focus();
                    break;
                case Keys.F7:
                    NzOff.Focus();
                    break;
                case Keys.Insert:
                    MS_GridX Grid;
                    Grid = _Kind == Enums.NzPaymentOperatingKind.Daryaft ? NzGridRecieve : NzGridPayment;
                    Grid.Focus();
                    Grid.MoveToNewRecord();
                    Grid.CurrentColumn = Grid.RootTable.Columns["PersianUsanceStr"];
                    break;
            }
        }

        private void NzSave_Click                       (object sender, EventArgs e)
        {
            if (IsOk())
            {
                RemoveUnSavedRow();
                RefreshSum();
                Save();
                try
                {
                    _Manager.Save(_DP);
                    NzSerial.MS_Decimal = _DP.serial;
                    SetItemsNoChanges();

                    MS_Do_Save?.Invoke(_Is_Edit, new AddingNewEventArgs(_DP.ID));

                    new Form_Notify("ذخـیـره سـازی", "اطـلاعـات بـا مـوفـقـیـت ثـبـت شـــد.",
                            Form_Notify.FarsiMessageBoxIcon.اضافه)
                        .Popup(Form_Notify.Direction_Show.Right_To_Left, 1000);
                }
                catch (Exception ex)
                {
                    MS_Message.Show("خطا در ذخیره اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                    log.Error(ex);
                }

            }
        }
        private void NzNew_Click                        (object sender, EventArgs e)
        {
            Reset();
        }
        private void NzPrint_Click                      (object sender, EventArgs e)
        {
            NzPrint.ShowDropDown();
        }

        private void NzTabInfo_SelectedTabChanged       (object sender, Janus.Windows.UI.Tab.TabEventArgs e)
        {
            if (NzTabInfo.SelectedTab == NzTabCache)
            {
                if (!_CacheLoaded)
                {
                    _CacheLoaded = true;
                    NzCache.Refresh_Grid(_Manager.Connection,Enums.NzAccountKind.Cache);
                }
                NzCache.Focus();
            }
            else if (NzTabInfo.SelectedTab == NzTabPos)
            {
                if (!_PosLoaded)
                {
                    _PosLoaded = true;
                    NzBankAccount.Refresh_Grid(_Manager.Connection, Enums.NzAccountKind.BankAccount);
                }
                NzBankAccount.Focus();
            }
            else if (NzTabInfo.SelectedTab == NzTabPayment)
            {
                
            }
        }
        private void NzOff_TextChanged                  (object sender, EventArgs e)
        {
            RefreshSum();
        }

        private void NzAccountPopup_NzSelectObject      (object sender, EventArgs e)
        {
            if (NzAccountPopup.NzSelected == null)
                return;

            var obj         = NzAccountPopup.NzSelected;
            var Current     = NzGridPayment.CurrentRow;

            if (Current?.DataRow == null)
                Current.BeginEdit();

            if (NzGridPayment.CurrentRow.DataRow is ChequeOperation row)
            {
                Current.Cells["PayAccountTitle"].Value = obj.title;

                row.FK_Hesab_Pardaxtani = obj.ID;
                row.BankTitle           = obj.title;

                if (row.ID > 0)
                    row.State = Enums.NzItemState.Modified;

                NzAccountPopup.Hide();
                NzGridPayment.CurrentColumn = NzGridRecieve.RootTable.Columns["mablaq"];
            }
        }
        private void NzAccountPopup_NzEscapedPress      (object sender, EventArgs e)
        {
            if (NzGridPayment.CurrentRow == null)
            {
                NzGridPayment.CancelCurrentEdit();
                return;
            }


            if (!(NzGridPayment.CurrentRow.DataRow is ChequeOperation row))
            {
                NzGridPayment.CancelCurrentEdit();
                NzGridPayment.CurrentRow.CancelEdit();
                return;
            }

            if (row.FK_Hesab_Pardaxtani != 0 
                    && (row.mablaq > 0 || string.IsNullOrWhiteSpace(row.shomare_check??"")))
                return;

            if (NzGridPayment.CurrentRow.RowType == RowType.NewRecord
                && NzAccountPopup.NzSelected == null)
            {
                NzGridPayment.CancelCurrentEdit();
                NzGridPayment.CurrentRow.CancelEdit();
            }
        }

        private void NzCustomer_MS_On_Row_Selected      (object sender, MS_Control.TSDD.On_Selected e)
        {
            if (NzCustomer.MS_Get_Selected() == null)
                NzRemain.MS_Decimal = 0;
            else
            {
                var tmp = NzCustomer.MS_Get_Selected() as People;
                NzRemainCustomer.NzSetCustoemr(tmp?.ID ?? 0);
            }
        }
        public void  Set_Form_Param                     (params object[] List_Parametter)
        {
            //1- bool Edit OR Factor
            //2- long ID for Edit Or Factor
            //3- byte Kind  Recieve Or Payment
            //4- string For Description

            foreach (var Item in List_Parametter)
            {
                if (Item is FactorPaymentMessage row)
                {
                    _FactorPaymnet = row;
                    var ID = GetIDPayment(_FactorPaymnet.IDFactor);

                    if (ID == null)
                    {
                        _FactorID           = _FactorPaymnet.IDFactor;
                        NzDescription.Text  = _FactorPaymnet.Description;
                        _Kind               = _FactorPaymnet.Kind;
                    }
                    else
                    {
                        _ID                 = ID.Value;
                        _Kind               = _FactorPaymnet.Kind;
                        _Is_Edit            = true;
                    }

                    NzNew.Visible = false;
                    NzOff.Enabled = false;

                    NzFactorMablaq.Show();
                    NzLableFactor.Show();
                    NzFactorMablaq.MS_Decimal = _FactorPaymnet.Amount;
                }
                else if (Item is CircularBill row2)
                {
                    _ID         = row2.ID;
                    _Kind       = (Enums.NzPaymentOperatingKind) row2.Kind;
                    _Is_Edit    = true;

                }
            }
        }

        private void NzPrintA4_Click                    (object sender, EventArgs e)
        {
            Print(Enums.NzKindPrint.PaperA4);
        }
        private void NzPrintA5_Click                    (object sender, EventArgs e)
        {
            Print(Enums.NzKindPrint.PaperA5);

        }
       
    }
}
