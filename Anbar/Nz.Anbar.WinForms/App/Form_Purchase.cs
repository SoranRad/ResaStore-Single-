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
using MS_Control.MainForms;
using MS_Control.Tarikh;
using Nz.Anbar.Model.ViewModel;
using NZ.Anbar.Business;
using NZ.Anbar.Model;
using Nz.Anbar.Model.Model;
using Nz.Anbar.Model.Report;
using Nz.Anbar.WinForms.Report;
using ShareLib;
using ShareLib.Interfaces;
using ShareLib.Models;
using ShareLib.Utils;
using ShareLib.ViewModel;

namespace Nz.Anbar.WinForms.App
{
    public partial class Form_Purchase : Form_Mother_IRANSans,IForm_Editor
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        NumberStyles sty = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.Currency;

        #endregion
        #region Fields
        private string              _SimpleText;
        private string              _Dot            = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
        private int                 _Pos            = 0;
        private int                 _Len            = 0;
        private bool                _IsEdit         = false;
        private bool                _Is_Delete_Key  = false;
        private bool                _DoRefresh      = true;
        private FactorHead          _Factor;
        private BidingFactorItems   _Bind;
        private FactorManager       _Manager;
        private long                _ID;
        private int                 _Serial;
        private Enums.NzFactorKind  _Kind;
        private string              _FormatString = "0,0.##;(0,0.##); ";
        #endregion
        #region Constructor
        public Form_Purchase                        (long ID = 0,Enums.NzFactorKind Kind = Enums.NzFactorKind.Xarid)
        {
            InitializeComponent();

            _Kind       = Kind;
            _ID         = ID;
            _Manager    = new FactorManager();
        }
        #endregion
        #region Methods
        private void ValidationDemo                 ()
        {
            if(!SystemConstant.IsDemo)
                return;
            var mgr = new ReportManager();
            var count = mgr.GetItem<FactorItemsCount>(new{},null);
            if (count.ItemsCount >= SystemConstant.DemoCount)
            {
                MS_Message.Show("نسخه برنامه شما آزمایشی می باشد لطفا آن را ارتقا دهید", "خطا", MessageBoxButtons.OK);
                NzSave.Enabled = false;
            }
        }
        private void Init                           ()
        {
            byte KindCustomer = 1;

            var xaridar     = 
                              _Kind == Enums.NzFactorKind.Frosh || 
                              _Kind == Enums.NzFactorKind.BargshtFrosh || 
                              _Kind == Enums.NzFactorKind.PishFaktor;

            var froshande   = _Kind == Enums.NzFactorKind.Xarid || _Kind == Enums.NzFactorKind.BargashXarid;

            if (xaridar && froshande)
                KindCustomer = 3;
            else if (xaridar)
                KindCustomer = 2;
            else if (froshande)
                KindCustomer = 1;

            NzSumPayment.Text = xaridar ? @"کل دریافتی :" : @"کل پرداختی :";

            NzPayment.Visible               = Form_Factory.IsSystemValid(Enums.MS_System.Xazane);
            NzCustomer.Refresh_Grid         (_Manager.Connection,KindCustomer);

            

            nzObjectPopup1.RefreshControl   (new Size(550, 220));
            
            nzObjectPopup1.NzSelectObject   += NzObjectPopup1OnNzSelectObject;
            nzObjectPopup1.NzEscapedPress   += NzObjectPopup1OnNzEscapedPress;

            NzGrid.FilterMode               = FilterMode.None;

            if (_Kind == Enums.NzFactorKind.Frosh)
                NzLocation.Refresh_Grid();

            var FactorMabna     = SystemConstant.OurAccount && _Kind == Enums.NzFactorKind.Frosh;
            NzFactors.Visible   = FactorMabna;
            label14.Visible     = FactorMabna;

            if (FactorMabna)
                NzFactors.Refresh_Grid();

            if (_ID == 0)
                Reset();
            else
            {
                LoadItem();
                if(_Factor.FactorItems.Count>20)
                    NzGrid.FilterMode = FilterMode.Automatic;
            }

            if (_Kind == Enums.NzFactorKind.Frosh)
            {
                NzLocation.Refresh_Grid();

            }

            ChangeUIForm();
            _Bind                       = new BidingFactorItems(_Factor);
            NzGrid.DataSource           = _Bind;

            if ((_Kind == Enums.NzFactorKind.Frosh || _Kind == Enums.NzFactorKind.PishFaktor))
            {
	            NzKindSale.Visible          =
		        NzKindSaleLbl.Visible       = (_Kind == Enums.NzFactorKind.Frosh || _Kind == Enums.NzFactorKind.PishFaktor);
	            NzKindSale.SelectedIndexChanged     += NzKind_SelectedIndexChanged;
            }
           

            ValidationDemo();
        }
        private void ChangeUIForm                   ()
        {
            if (    _Kind == Enums.NzFactorKind.Xarid
                ||  _Kind == Enums.NzFactorKind.BargashXarid)
                NzCustomerLable.Text = @"فروشنده";
            else 
                NzCustomerLable.Text = @"خریدار";

            Text = _Kind.NzToString();

            panel1.Visible = _Kind != Enums.NzFactorKind.PishFaktor
                             && _Kind != Enums.NzFactorKind.SefareshXarid
                             && _Kind != Enums.NzFactorKind.SefarshFrosh;

            NzLocation.Visible      =
            NzLableLocation.Visible = _Kind == Enums.NzFactorKind.Frosh;

           

        }
        private void LoadItem                       ()
        {
            try
            {
                _Factor     = _Manager.GetItem(_ID);
                if (_Factor == null)
                {
                    MS_Message.Show("فاکتور مورد نظر یافت نشد");
                    Reset();
                }
                _DoRefresh = false;

                NzSerial.MS_Decimal         = _Factor.Serial;
                NzDate.MS_Tarikh            = new MS_Structure_Shamsi(_Factor.tarikh);
                NzKindSale.SelectedIndex    = _Factor.FK_Kind_Frosh ?? 0;
                NzDescription.Text          = _Factor.sharh;
                NzCustomer.MS_Set_Select    (_Factor.FK_AshXas_ID);
                NzCustomerRemain.NzSetCustoemr(_Factor.FK_AshXas_ID ?? 0);
                _Kind                       = (Enums.NzFactorKind) _Factor.kind;
                _Bind                       = new BidingFactorItems(_Factor);
                NzGrid.DataSource           = _Bind;

                NzOffPercent.Text           = (_Factor?.FactorDetail?.Darsad_Takhfif ?? 0).ToString(_FormatString);
                NzOffPrice.Text             = (_Factor?.FactorDetail?.mablaq_takhfif ?? 0).ToString(_FormatString);
                NzExtend.Text               = (_Factor?.FactorDetail?.Ezafat ?? 0       ).ToString(_FormatString);
                NzTaxPercent.Text           = (_Factor?.FactorDetail?.Darsad_Maliat ?? 0).ToString(_FormatString);
                NzTaxPrice.Text             = (_Factor?.FactorDetail?.mablaq_Maliat ?? 0).ToString(_FormatString);

                if(_Kind == Enums.NzFactorKind.Frosh)
                    NzLocation.MS_Set_Select    (_Factor.FK_Location);

                if (NzFactors.Visible)
                    NzFactors.MS_Set_Select(_Factor.FK_Mabna);

                RefreshFactorSum            ();
                ChangeUIForm                ();
                LoadPayment                 ();


                _DoRefresh = true;
            }
            catch (Exception ex)
            {
                MS_Message.Show(ex.Message);
                log.Error(ex);
            }
        }
        private void Save                           ()
        {
            try
            {
                long CustomerID = 0;

                if (_Factor.ID > 0)
                    CustomerID = _Factor.FK_AshXas_ID ?? 0;

                if (_Factor.ID == 0)
                {
                    _Factor.FK_Salmali = SystemConstant.ActiveYear.Salmali;
                    _Factor.FK_User_Add = SystemConstant.ActiveUser.ID;
                    _Factor.tarikh_add = DateTime.Now;
                    _Factor.kind = (byte) _Kind;
                }
                else if (_IsEdit)
                {
                    _Factor.FactorDetail = _Factor.FactorDetail ?? new FactorDetail()
                    {
                        FactorHead = _Factor,
                        State = Enums.NzItemState.AddedNew,
                    };

                    var Detail = _Factor.FactorDetail;
                    Detail.FK_User_Edit = SystemConstant.ActiveUser.ID;
                    Detail.tarikh_edit = DateTime.Now;
                }

                _Factor.Serial          = Convert.ToInt32(NzSerial.MS_Decimal);
                _Factor.FK_AshXas_ID    = (NzCustomer.MS_Get_Selected() as People)?.ID;
                _Factor.tarikh          = NzDate.MS_Tarikh.Value.ToDatetime().Date;
                _Factor.sharh           = string.IsNullOrEmpty(NzDescription.Text.Trim())
                                            ? null
                                            : NzDescription.Text.Trim();

                _Factor.FK_Kind_Frosh = (short)NzKindSale.SelectedIndex;

                if (
                        NzTaxPercent.MS_Decimal > 0 
                    ||  NzOffPrice.MS_Decimal   > 0
                    ||  NzOffPercent.MS_Decimal > 0 
                    ||  NzExtend.MS_Decimal     > 0
                   )
                {
                    if (_Factor.FactorDetail == null)
                    {
                        _Factor.FactorDetail = new FactorDetail()
                        {
                            FactorHead = _Factor,
                            State = Enums.NzItemState.AddedNew,
                        };
                    }
                    else
                        _Factor.FactorDetail.State = Enums.NzItemState.Modified;

                    _Factor.FactorDetail.Darsad_Maliat =
                        NzTaxPercent.MS_Decimal == 0 ? null : (decimal?) NzTaxPercent.MS_Decimal;
                    _Factor.FactorDetail.mablaq_Maliat =
                        NzTaxPrice.MS_Decimal == 0 ? null : (decimal?) NzTaxPrice.MS_Decimal;
                    _Factor.FactorDetail.Darsad_Takhfif =
                        NzOffPercent.MS_Decimal == 0 ? null : (decimal?) NzOffPercent.MS_Decimal;
                    _Factor.FactorDetail.mablaq_takhfif =
                        NzOffPrice.MS_Decimal == 0 ? null : (decimal?) NzOffPrice.MS_Decimal;
                    _Factor.FactorDetail.Ezafat = NzExtend.MS_Decimal == 0 ? null : (decimal?) NzExtend.MS_Decimal;
                }
                else if
                (
                    _Factor.ID > 0
                &&  _Factor.FactorDetail != null
                && (
                            NzTaxPercent.MS_Decimal != _Factor.FactorDetail.Darsad_Maliat
                        ||  NzOffPrice.MS_Decimal   != _Factor.FactorDetail.mablaq_takhfif
                        ||  NzOffPercent.MS_Decimal != _Factor.FactorDetail.Darsad_Takhfif
                        ||  NzExtend.MS_Decimal     != _Factor.FactorDetail.Ezafat
                    )
                )
                {
                    _Factor.FactorDetail.State = Enums.NzItemState.Modified;

                    _Factor.FactorDetail.Darsad_Maliat =
                        NzTaxPercent.MS_Decimal == 0 ? null : (decimal?)NzTaxPercent.MS_Decimal;
                    _Factor.FactorDetail.mablaq_Maliat =
                        NzTaxPrice.MS_Decimal == 0 ? null : (decimal?)NzTaxPrice.MS_Decimal;
                    _Factor.FactorDetail.Darsad_Takhfif =
                        NzOffPercent.MS_Decimal == 0 ? null : (decimal?)NzOffPercent.MS_Decimal;
                    _Factor.FactorDetail.mablaq_takhfif =
                        NzOffPrice.MS_Decimal == 0 ? null : (decimal?)NzOffPrice.MS_Decimal;
                    _Factor.FactorDetail.Ezafat = NzExtend.MS_Decimal == 0 ? null : (decimal?)NzExtend.MS_Decimal;
                }


                _Factor.mablaq          = NzSumFactor.MS_Decimal ?? 0;
                _Factor.FK_Location     = (NzLocation.MS_Get_Selected() as Location)?.ID;

                var fk_Manbna = (NzFactors.MS_Get_Selected() as FactorHeads)?.ID;

                if (_Factor.FK_Mabna != fk_Manbna)
                {
                    _Factor
                        .FactorItems
                        .Where(x => x.ID > 0 && x.State != Enums.NzItemState.Deleted)
                        .MSZ_ForEach(item => item.State = Enums.NzItemState.Modified);
                }

                _Factor.FK_Mabna        = fk_Manbna;

                var autoSerial = _ID == 0 && _Serial == NzSerial.MS_Decimal;

                

                _Manager.Save(_Factor,autoSerial);

                if (CustomerID > 0
                    && CustomerID != _Factor.FK_AshXas_ID
                    && NzSumMoney.MS_Decimal > 0)
                {
                    var mgr = new ReportManager();
                    mgr.GetReport<UpdatePaymentCustomer>(new
                    {
                        IDPeople = _Factor.FK_AshXas_ID,
                        IDFactor = _Factor.ID
                    }, null);
                }

                new Form_Notify("ذخـیـره سـازی", "اطـلاعـات بـا مـوفـقـیـت ثـبـت شـــد.",
                        Form_Notify.FarsiMessageBoxIcon.اضافه)
                    .Popup(Form_Notify.Direction_Show.Right_To_Left, 1000);

                NzSerial.MS_Decimal = _Factor.Serial;
                SetItemsNoChanges();
            }
            catch (Exception ex)
            {
                //log.Error(ex);
                MS_Message.Show("خطا در برنامه، فاکتور مورد نظر ذخیره نشد.لطفا فرم را ببندید و مجددا اقدام نمایید.", "خطا", ex.Message, MessageBoxButtons.OK);
            }
        }
        private void Reset                          ()
        {
            _DoRefresh                  = false;
            _IsEdit                     = false;

            GetMaxSerial                ();

            _ID                         = 0;
            _Factor                     = new FactorHead();
            _Bind                       = new BidingFactorItems(_Factor);
            NzGrid.DataSource           = _Bind;
            NzDate.MS_Tarikh            = new MS_Structure_Shamsi(DateTime.Now);
            NzRemain.MS_Decimal         = 0;
            NzDescription.Text          = "";

            NzTaxPercent.MS_Decimal     = 0;
            NzOffPrice.MS_Decimal       = 0;
            NzOffPercent.MS_Decimal     = 0;

            NzSumCash.MS_Decimal        = 0;
            NzSumPos.MS_Decimal         = 0;
            NzSumCheque.MS_Decimal      = 0;
            NzSumFactor.MS_Decimal      = 0;
            NzRemain.MS_Decimal         = 0;
            NzSerial.Focus();
            NzKindSale.SelectedIndex    = 0;

            _DoRefresh                  = true;
        }
        private void ShowMenu                       ()
        {
            if (NzGrid.CurrentColumn == null)
                return;

            var key = NzGrid.CurrentColumn.Key;
            if (key == "FK_Kala" || key == "UnitTitle" || key == "ObjectTitle")
            {
                var rec =
                    NzGrid.CurrentRow == null ?
                        NzGrid.Bounds
                        : NzGrid.GetCellBounds(NzGrid.CurrentRow.Position, NzGrid.RootTable.Columns["ObjectTitle"]);

                nzObjectPopup1.NzSelected = null;
                nzObjectPopup1.Show(NzGrid, new Point(rec.X + rec.Width, rec.Y + rec.Height), ToolStripDropDownDirection.BelowLeft);
                SendKeys.Send("{TAB}");
            }
        }
        private void RemoveUnSavedRow               ()
        {
            try
            {
                _Factor
                    .FactorItems
                    .Where(x => x.ID == 0 && (x.meqdar == 0 || x.FK_Kala == 0 || x.mablaq == 0))
                    .ToList()
                    .MSZ_ForEach(x =>
                    {
                        _Bind.Remove(x);
                    });

                 _Factor
                     .FactorItems
                     .Where(x => x.mablaq > 0 && x.nerkh == 0)
                     .MSZ_ForEach(x =>
                     {
                         x.nerkh = x.mablaq / x.meqdar;
                         x.State = Enums.NzItemState.Modified;
                     });
                
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void GetMaxSerial                   ()
        {
            _Serial = _Manager.GetMaxSerial
            (new{
                Kind = (byte)_Kind,
                Year = SystemConstant.ActiveYear.Salmali
            }) + 1;

            NzSerial.MS_Decimal = _Serial;
        }
        private bool IsOK                           ()
        {
            try
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
                    MS_Message.Show("تاریخ فاکتور در محدوده سال مالی نیست" +
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
                if (!_Factor.FactorItems.Any())
                {
                    MS_Message.Show("یک یا چند قلم کالا را وارد کنید.");
                    NzGrid.Focus();
                    mS_Notify1.Show(NzGrid);
                    return false;
                }
                var Customer = NzCustomer.MS_Get_Selected() as People;
                if (Customer.isBlock ?? false)
                {

                }
                if ((_Factor.ID == 0 && _Serial != NzSerial.MS_Decimal)
                    || (_Factor.ID > 0 && _Factor.Serial != NzSerial.MS_Decimal))
                {
                    var r = _Manager.IsCodeUnique(new
                    {
                        Year = SystemConstant.ActiveYear.Salmali,
                        Kind = (byte)_Kind,
                        Serial = NzSerial.MS_Decimal,
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
            catch (Exception ex)
            {
                log.Error(ex);
                MS_Message.Show("خطا در اعتبار سنجی");
                return false;
            }
        }
        private void SetItemsNoChanges              ()
        {
            _Factor.FactorItems.MSZ_ForEach(x =>
            {
                x.State = Enums.NzItemState.NotChanged;
            });
        }
        private void RefreshFactorSum               ()
        {
            try
            {
                var sum = _Factor
                               .FactorItems
                               .Where(x => x.State != Enums.NzItemState.Deleted)
                               .Sum(x => x.mablaq);

                NzSumRows.MS_Decimal = sum;

                var off = NzOffPercent.MS_Decimal > 0
                                ? NzOffPercent.MS_Decimal / 100 * sum
                                : NzOffPrice.MS_Decimal;
                var tax = NzTaxPercent.MS_Decimal > 0
                                ? NzTaxPercent.MS_Decimal / 100 * (sum - off)
                                : 0;
                //=====
                NzOffPrice.MS_Decimal = decimal.Round(off);
                NzTaxPrice.MS_Decimal = decimal.Round(tax);
                //=====

                NzSumFactor.MS_Decimal = decimal.Round(sum - off + tax + NzExtend.MS_Decimal);
                NzRemain.MS_Decimal = NzSumFactor.MS_Decimal - NzSumMoney.MS_Decimal;

                
            }
            catch (Exception ex)
            {
                log.Error(ex);
                new Form_Notify("خطا ", "خطا در بروز رسانی مبالغ.",
                        Form_Notify.FarsiMessageBoxIcon.خطا)
                    .Popup(Form_Notify.Direction_Show.Right_To_Left, 2000);
                throw;
            }
        }
        private void LoadPayment                    ()
        {
            try
            {
                var mgr = new ReportManager();
                var payment = mgr.GetItem<FactorPayment>(new {_Factor.ID}, null);
                if (payment == null) 
                    ResetPayment();
                else
                {
                    NzSumCash.MS_Decimal    = payment.Cache;
                    NzSumPos.MS_Decimal     = payment.POS;
                    NzSumCheque.MS_Decimal  = payment.Cheque;
                    NzlblCheque.Text        = payment.ChequeCount + @" فقره چـک : ";

                    NzSumMoney.MS_Decimal   = payment.Cache
                                            + payment.POS
                                            + payment.Cheque;

                    NzRemain.MS_Decimal = NzSumFactor.MS_Decimal - NzSumMoney.MS_Decimal;
                }                               
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void ResetPayment                   ()
        {
            NzSumCash.MS_Decimal    = 
            NzSumPos.MS_Decimal     =
            NzSumMoney.MS_Decimal   =
            NzRemain.MS_Decimal     =
            NzSumCheque.MS_Decimal  = 0;
            NzlblCheque.Text        =  @" 0 فقره چـک : ";
        }
        #endregion
        #region Grid Events
        private void ms_grid_EditModeChanged        (object sender, EventArgs e)
        {
            try
            {
                if (
                           NzGrid.EditMode == EditMode.EditOn
                        && NzGrid.EditTextBox != null
                        && (
                                   NzGrid.CurrentRow?.RowType == RowType.NewRecord
                                || NzGrid.CurrentRow?.RowType == RowType.Record
                            )
                    )
                {

                    NzGrid.EditTextBox.KeyPress += EditTextBoxOnKeyPress;
                    NzGrid.EditTextBox.TextChanged += EditTextBoxOnTextChanged;
                    //NzGrid.EditTextBox.
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void ms_grid_RowDoubleClick         (object sender, RowActionEventArgs e)
        {
            try
            {
                if (!(e.Row.RowType == RowType.Record || e.Row.RowType == RowType.NewRecord))
                    return;
                ShowMenu();
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void ms_grid_CurrentCellChanged     (object sender, EventArgs e)
        {
            try
            {
                if (NzGrid.CurrentRow?.RowType == RowType.NewRecord)
                    ShowMenu();
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void ms_grid_UpdatingRecord         (object sender, CancelEventArgs e)
        {
            try
            {
                if (!(NzGrid.CurrentRow?.DataRow is FactorItem key))
                    return;

                if (key?.meqdar == 0 || key?.FK_Kala == 0 || key?.nerkh==0)
                {
                    NzGrid.CancelCurrentEdit();
                    NzGrid.CurrentRow.CancelEdit();
                    e.Cancel = true;
                    _Bind.Remove(key);
                }

                if (key.mablaq > 0 && key.nerkh <= 0 && key.meqdar > 0)
                    key.nerkh = key.mablaq / key.meqdar;
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void ms_grid_AddingRecord           (object sender, CancelEventArgs e)
        {
            try
            {
                if (!(NzGrid.CurrentRow?.DataRow is FactorItem key))
                    return;

                if (key.meqdar == 0 || key.FK_Kala == 0 || key.nerkh==0)
                {
                    NzGrid.CancelCurrentEdit();
                    NzGrid.CurrentRow.CancelEdit();
                    e.Cancel = true;
                    _Bind.Remove(key);
                }

                if (key.mablaq > 0 && key.nerkh <= 0 && key.meqdar > 0)
                    key.nerkh = key.mablaq / key.meqdar;
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
            
        }
        private void ms_grid_KeyPress               (object sender, KeyPressEventArgs e)
        {
            try
            {
                var Cur = NzGrid.CurrentRow;

                if (char.IsLetterOrDigit(e.KeyChar) && Cur != null)
                {
                    var key     = NzGrid.CurrentColumn?.Key;
                    var type    = Cur.RowType;

                    if ((key == "FK_Kala" || key == "UnitTitle" || key == "ObjectTitle")
                            && (type == RowType.NewRecord || type == RowType.Record))
                    {
                        ShowMenu();
                    }
                }
                else if (e.KeyChar == (char)27)
                {
                    e.Handled = true;
                    if (Cur != null)
                    {
                        if (Cur.RowType == RowType.NewRecord)
                        {
                            Cur?.CancelEdit();
                            var row = Cur?.DataRow as FactorItem;
                            if (row?.ID > 0)
                            {
                                Cur?.Delete();
                                _DoRefresh = false;
                                RefreshFactorSum();
                                _DoRefresh = true;
                                //Save();
                            }
                        }
                    }
                    Cur?.CancelEdit();
                    NzGrid.CancelCurrentEdit();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void ms_grid_ColumnButtonClick      (object sender, ColumnActionEventArgs e)
        {
            if (e.Column.Key == "D")
            {
                if (NzGrid.CurrentRow?.DataRow == null)
                    return;

                if (NzGrid.CurrentRow.RowType == RowType.NewRecord)
                {
                    NzGrid.CancelCurrentEdit();
                    NzGrid.CurrentRow.CancelEdit();
                    _DoRefresh = false;
                    RefreshFactorSum();
                    _DoRefresh = true;
                    return;
                }
                var row = NzGrid.CurrentRow.DataRow as FactorItem;
                if (row?.ID > 0)
                {
                    var result = MS_Message
                        .Show("آیا برای حذف ردیف مورد نظر مطمئنید؟", 
                        "حذف ردیف",
                        MessageBoxButtons.YesNo);
                    if(result!=DialogResult.Yes)
                        return;
                }
                NzGrid.CurrentRow?.Delete();

                _DoRefresh = false;
                RefreshFactorSum();
                _DoRefresh = true;
            }
            else if (e.Column.Key == "E")
            {
                NzGrid.CurrentColumn = NzGrid.RootTable.Columns["ObjectTitle"];
                ShowMenu();
            }
        }
        private void ms_grid_CellUpdated            (object sender, ColumnActionEventArgs e)
        {

            try
            {
                var row = NzGrid.CurrentRow?.DataRow as FactorItem;
                if (row?.ID > 0)
                    row.State = Enums.NzItemState.Modified;

                _DoRefresh = false;
                RefreshFactorSum();
                _DoRefresh = true;
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void NzGrid_RecordAdded             (object sender, EventArgs e)
        {
            _DoRefresh = false;
                RefreshFactorSum();
            _DoRefresh = true;
        }
        private void NzGrid_CancelingRowEdit        (object sender, RowActionCancelEventArgs e)
        {
            try
            {
                var Cur = e.Row;
                if (Cur != null && Cur.RowType == RowType.NewRecord)
                {
                    var row = Cur.DataRow as FactorItem;
                    if (row != null)
                        _Bind.Remove(row);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void NzGrid_UpdatingCell            (object sender, UpdatingCellEventArgs e)
        {
            try
            {
                if (NzGrid.CurrentRow == null || e.Column.DataMember!="meqdar")
                    return;

                var key = NzGrid.CurrentRow.DataRow as FactorItem;

                if ((byte)_Kind >= 50)
                {
                    var objectItem      = nzObjectPopup1.GetAvailObject(key?.FK_Kala ?? 0);
                    var Value           = Convert.ToDecimal(e.Value);
                    var InitialValue    = Convert.ToDecimal(e.InitialValue);

                    if (
                           objectItem.kind      ==  (byte) Enums.NzObjectKind.Object
                        && objectItem?.remaind  <   Value
                        && Value                !=  InitialValue 
                    )
                    {
                        var result = MS_Message.Show(
                            "موجودی کالا از مقداری که وارد کرده اید کمـتر است" +
                            "\n آیا مایلید ردیف مورد نظر ثبت شود",
                            "هشدار",
                            MessageBoxButtons.YesNo,
                            MSMessage.FarsiMessageBoxIcon.اخطار
                        );

                        if (result == DialogResult.No)
                        {
                            e.Cancel = true;
                            e.Value = e.InitialValue;
                            //NzGrid.Refresh();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void NzGrid_CellEdited              (object sender, ColumnActionEventArgs e)
        {
            try
            {
                if (NzGrid.CurrentRow == null || e.Column.DataMember != "meqdar")
                    return;

                var key = NzGrid.CurrentRow.DataRow as FactorItem;

                if (key?.meqdar <= 0)
                {
                    NzGrid.Refresh();
                    NzGrid.CurrentColumn = e.Column;
                    MS_Message.Show("مقدار را وارد کنید. مقدار نباید صفر [ 0 ] باشد");
                    
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        #endregion
        #region TextBox Events
        private void EditTextBoxOnKeyPress          (object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (!(char.IsDigit(key) || key == '\b' || key == '.' || key=='+' || key == '-'))
                e.Handled = true;
            if (key == '.' && NzGrid.EditTextBox.Text.Contains("."))
                e.Handled = true;
            if (key == '+')
            {
                NzGrid.EditTextBox.Text += "000";
                e.Handled = true;
            }
            else if (key == '-')
            {
                NzGrid.EditTextBox.Text += "00";
                e.Handled = true;
            }
        }
        private void EditTextBoxOnTextChanged       (object sender, EventArgs eventArgs)
        {
            if(!_DoRefresh)
                return;
            _DoRefresh      = false;

            var TextBox     = NzGrid.EditTextBox;
            
            if (TextBox == null)
                return;

            _SimpleText     = TextBox.Text.Replace(",", string.Empty);
            
            var start       = _SimpleText.Contains(_Dot)
                                ? _SimpleText.IndexOf(_Dot) - 3
                                : _SimpleText.Length - 3;
           
            for (int i = start; i > 0; i -= 3)
                _SimpleText = _SimpleText.Insert(i, ",");

            TextBox.Text = _SimpleText;
            Set_Cursor_Location();
            //===============================
            //===============================
            var col = NzGrid.CurrentColumn.Key;
            if (col == "meqdar")
                RefreshCount();
            else if (col == "nerkh")
                RefreshPrice();
            else if (col == "takhfif")
                RefreshOffPrice();
            else if (col == "takhfif_darsad")
                RefreshOffPercent();
            else if (col == "mablaq")
                RefreshSum();
            //===============================
            //===============================
            _DoRefresh = true;
        }
        private void EditTextBoxOnGotFocus          (object sender, EventArgs eventArgs)
        {
            if (NzGrid.EditTextBox != null)
                NzGrid.EditTextBox.Text = NzGrid.CurrentRow.Cells[NzGrid.CurrentColumn].Text;
        }
        private void EditTextBoxOnKeyDown           (object sender, KeyEventArgs keyEventArgs)
        {
            if (NzGrid.EditTextBox != null)
            {
                _Pos            = NzGrid.EditTextBox.SelectionStart + NzGrid.EditTextBox.SelectionLength;
                _Len            = NzGrid.EditTextBox.Text.Length;
                _Is_Delete_Key  = keyEventArgs.KeyCode == Keys.Delete;
            }
        }

        private void Set_Cursor_Location            ()
        {
            if(NzGrid.EditTextBox==null) 
                return;

            int tm = NzGrid.EditTextBox.Text.Length - _Len;

            //int x = _Pos + tm;
            //x = x < 0 ? 0 : x;
            if (tm > 0)// طول زیاد شده باشد
            {
                NzGrid.EditTextBox.Select(_Pos + tm, 0);
            }
            else if (tm < 0) //  اگر طول کم شده باشد
            {
                var i = Math.Max(0, _Pos + tm);
                NzGrid.EditTextBox.Select(i, 0);
            }
            else // طول 
            {
                NzGrid.EditTextBox.Select(_Pos, 0);
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
        private void RefreshCount                   ()
        {
            try
            {
                if (NzGrid.CurrentRow == null)
                    return;

                var text = NzGrid.EditTextBox?.Text?.Trim();
                var Str = string.IsNullOrEmpty(text)
                                ? "0"
                                : text;

                if (decimal.TryParse(Str,
                                            sty,
                                            CultureInfo.CurrentCulture,
                                            out decimal num))
                {
                    var r = NzGrid.CurrentRow?.DataRow as FactorItem;

                    var sum = num * (r?.nerkh ?? 0);

                    if (sum == 0)
                    {
                        RefreshCurrency(0, 0);
                        return;
                    }

                    var takhfif = (r?.takhfif_darsad ?? 0) > 0
                                        ? Math.Round((r?.takhfif_darsad ?? 0) / 100 * sum)
                                        : (r?.takhfif);
                    RefreshCurrency(sum, takhfif ?? 0);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                RefreshCurrency(0, 0);
            }
        }
        private void RefreshPrice                   ()
        {
            try
            {
                if (NzGrid.CurrentRow == null)
                    return;

                var text = NzGrid.EditTextBox?.Text?.Trim();
                var Str = string.IsNullOrEmpty(text)
                    ? "0"
                    : text;

                if (decimal.TryParse(Str,
                                            sty,
                                            CultureInfo.CurrentCulture,
                                            out decimal nerx))
                {
                    if (!(NzGrid.CurrentRow.DataRow is FactorItem r))
                        return;

                    if (nerx == 0 && r.nerkh > 0)
                        nerx = r.nerkh;

                    var sum = nerx * r.meqdar ;

                    if (sum == 0)
                    {
                        RefreshCurrency(0, 0);
                        return;
                    }

                    var takhfif = (r.takhfif_darsad ) > 0
                                        ? Math.Round((r.takhfif_darsad ) / 100 * sum)
                                        : (r.takhfif );

                    RefreshCurrency(sum, takhfif);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                RefreshCurrency(0, 0);
            }
        }
        private void RefreshSum                     ()
        {
            try
            {
                if (NzGrid.CurrentRow == null)
                    return;

                var text = NzGrid.EditTextBox?.Text?.Trim();
                var Str = string.IsNullOrEmpty(text)
                    ? "0"
                    : text;

                if (decimal.TryParse(Str,
                                            sty,
                                            CultureInfo.CurrentCulture,
                                            out decimal num))
                {
                    if (!(NzGrid.CurrentRow?.DataRow is FactorItem r))
                        return;

                    var cell = NzGrid.CurrentRow.Cells["nerkh"];


                    if (r.meqdar == 0)
                    {
                        RefreshCurrency(0, 0);
                        return;
                    }

                    var nerkh = decimal.Round((num + r.takhfif ) / r.meqdar);
                    cell.Text = (nerkh).ToString(cell.Column.FormatString);
                    cell.Value = nerkh;
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                RefreshCurrency(0, 0);
            }
        }
        private void RefreshOffPercent              ()
        {
            try
            {
                if (NzGrid.CurrentRow == null)
                    return;

                var text = NzGrid.EditTextBox.Text.Trim();
                var Str = string.IsNullOrEmpty(text)
                    ? "0"
                    : text;

                if (decimal.TryParse(Str,
                                            sty,
                                            CultureInfo.CurrentCulture,
                                            out decimal num))
                {
                    var r = NzGrid.CurrentRow.DataRow as FactorItem;
                    var sum = (r?.nerkh ?? 0) * (r?.meqdar ?? 0);

                    if (sum == 0)
                    {
                        RefreshCurrency(0, 0);
                        return;
                    }

                    var takhfif = Math.Round(num / 100 * sum);

                    RefreshCurrency(sum, takhfif);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                RefreshCurrency(0, 0);
                throw;
            }
        }
        private void RefreshOffPrice                ()
        {
            try
            {
                if (NzGrid.CurrentRow == null)
                    return;

                var text = NzGrid.EditTextBox.Text.Trim();
                var Str = string.IsNullOrEmpty(text)
                    ? "0"
                    : text;

                if (decimal.TryParse(Str,
                                            sty,
                                            CultureInfo.CurrentCulture,
                                            out decimal num))
                {
                    var r = NzGrid.CurrentRow.DataRow as FactorItem;
                    var cellSum = NzGrid.CurrentRow.Cells["mablaq"];
                    var cellOff = NzGrid.CurrentRow.Cells["takhfif_darsad"];

                    var sum = (r?.nerkh ?? 0) * (r?.meqdar ?? 0);
                    var takhfif = num;

                    cellOff.Text = "0";
                    cellOff.Value = 0;

                    cellSum.Text = (sum - takhfif).ToString(cellSum.Column.FormatString);
                    cellSum.Value = sum - takhfif;
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                RefreshCurrency(0, 0);
            }
        }
        private void RefreshCurrency                (decimal Sum, decimal Off)
        {
            try
            {
                if (NzGrid.CurrentRow == null)
                    return;

                var cellSum = NzGrid.CurrentRow.Cells["mablaq"];
                var cellOff = NzGrid.CurrentRow.Cells["takhfif"];

                cellOff.Text = (Off).ToString(cellOff.Column.FormatString);
                cellOff.Value = Off;

                cellSum.Text = (Sum - Off).ToString(cellSum.Column.FormatString);
                cellSum.Value = Sum - Off;
            }
            catch (Exception ex)
            {
                log.Error(ex);
                RefreshCurrency(0, 0);
            }

        }
        #endregion
        //====================================
        private void NzObjectPopup1OnNzSelectObject     (object sender, EventArgs eventArgs)
        {
            if (nzObjectPopup1.NzSelected == null || NzGrid.CurrentRow == null )
                return;


            var obj                             = nzObjectPopup1.NzSelected;
            var Current                         = NzGrid.CurrentRow;

            Current?.BeginEdit();
            

            Current.Cells["ObjectTitle"].Value  = obj.title;
            Current.Cells["FK_Kala"].Value      = obj.Code;
            Current.Cells["UnitTitle"].Value    = obj.UnitTitle;

            if (Current != null && Current.DataRow!=null)
            {
                //var row = Current.DataRow as FactorItem;
                if (Current.DataRow is FactorItem row && row.ID > 0)
                    row.State = Enums.NzItemState.Modified;
            }

            if (   _Kind == Enums.NzFactorKind.Frosh
                || _Kind == Enums.NzFactorKind.BargshtFrosh
                || _Kind == Enums.NzFactorKind.PishFaktor)

            {
                if(NzKindSale.SelectedIndex==0)
                    Current.Cells["nerkh"].Value = obj.nerkh_frosh;
                else if(NzKindSale.SelectedIndex==1)
                    Current.Cells["nerkh"].Value = obj.nerkh_frosh1;
                else if(NzKindSale.SelectedIndex==2)
                    Current.Cells["nerkh"].Value = obj.nerkh_frosh2;
                else if(NzKindSale.SelectedIndex==3)
                    Current.Cells["nerkh"].Value = obj.nerkh_frosh3;
                else
                    Current.Cells["nerkh"].Value = obj.nerkh_frosh;

                RefreshPrice();
                RefreshFactorSum();
            }

            NzGrid.CurrentColumn = NzGrid.RootTable.Columns["meqdar"];
        }
        private void NzObjectPopup1OnNzEscapedPress     (object sender, EventArgs eventArgs)
        {
            if (NzGrid.CurrentRow == null)
            {
                NzGrid.CancelCurrentEdit();
                return;
            }


            if (!(NzGrid.CurrentRow.DataRow is FactorItem row))
            {
                NzGrid.CancelCurrentEdit();
                NzGrid.CurrentRow.CancelEdit();
                return;
            }

            if (row.FK_Kala != 0 && (row.meqdar > 0 || row.nerkh > 0 || row.mablaq > 0))
                return;

            if (    NzGrid.CurrentRow.RowType == RowType.NewRecord 
                &&  nzObjectPopup1.NzSelected == null)
            {
                NzGrid.CancelCurrentEdit();
                NzGrid.CurrentRow.CancelEdit();
            }
        }

        private void NzOffPercent_TextChanged           (object sender, EventArgs e)
        {
            if(!_DoRefresh)
                return;
            _DoRefresh = false;

            NzOffPrice.MS_Decimal = decimal.Round(NzOffPercent.MS_Decimal / 100 * (NzSumRows.MS_Decimal??0));
            RefreshFactorSum();

            _DoRefresh = true;
        }
        private void NzOffPrice_TextChanged             (object sender, EventArgs e)
        {
            if (!_DoRefresh)
                return;
            _DoRefresh = false;

            NzOffPercent.MS_Decimal = 0;
            RefreshFactorSum();

            _DoRefresh = true;
        }
        private void NzTaxPercent_TextChanged           (object sender, EventArgs e)
        {
            if (!_DoRefresh)
                return;
            _DoRefresh = false;

            var total               = (NzSumRows.MS_Decimal ??0)- NzOffPrice.MS_Decimal;
            var tax                 = decimal.Round(NzTaxPercent.MS_Decimal / 100 * total);
            NzTaxPrice.MS_Decimal   = tax;
            RefreshFactorSum();

            _DoRefresh = true;
        }
        private void NzExtend_TextChanged               (object sender, EventArgs e)
        {
            if (!_DoRefresh)
                return;

            _DoRefresh = false;
            RefreshFactorSum();
            _DoRefresh = true;
        }

        private void Form_Purchase_Shown                (object sender, EventArgs e)
        {
            Init();
        }
        private void Form_Purchase_KeyUp                (object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
	            case Keys.F3:
	            {
		            if(NzGrid.CurrentRow==null)
                        break;
                    
		            if(NzGrid.CurrentRow.RowType != RowType.Record && NzGrid.CurrentRow.RowType != RowType.NewRecord )
                        break;

		            var Current                         = NzGrid.CurrentRow;

		            var code = Convert.ToInt32( Current.Cells["FK_Kala"].Value);

		            new FormPriceChart(code).ShowDialog(this);

                    break;
	            }
                case Keys.F4:
                    NzSave.PerformClick();
                    break;
                case Keys.F6:
                    NzDescription.Focus();
                    break;
                case Keys.F7:
                    NzOffPercent.Focus();
                    break;
                case Keys.Insert:
                    NzGrid.Focus();
                    NzGrid.MoveToNewRecord();
                    NzGrid.CurrentColumn = NzGrid.RootTable.Columns["ObjectTitle"];
                    ShowMenu();
                    break;
                case Keys.P:
                    if(e.Control)
                        NzPrint.PerformButtonClick();
                    break;
            }
        }

        private void NzCustomer_Selected                (object sender, MS_Control.TSDD.On_Selected e)
        {
            if (NzCustomer.MS_Get_Selected() == null)
                NzRemain.MS_Decimal = 0;
            else
            {
                var tmp = NzCustomer.MS_Get_Selected() as People;
                NzCustomerRemain.NzSetCustoemr(tmp?.ID ?? 0);
            }

            NzGrid.Focus();
            NzGrid.CurrentColumn = NzGrid.RootTable.Columns["ObjectTitle"];
        }

        private void NzPrint_Click                      (object sender, EventArgs e)
        {
            NzPrint.ShowDropDown();
        }
        private void NzPrintNormalA4_Click              (object sender, EventArgs e)
        {
            var remaind = "";
            if (NzPeopleRemaind.Checked)
            {
                var tmp = NzCustomer.MS_Get_Selected() as People;
                NzCustomerRemain.NzSetCustoemr(tmp?.ID ?? 0);
                remaind = "مانده حساب شخص : " + NzCustomerRemain.Text;
            }
            var prn = new Print.Print(_Manager, _Factor.ID, Enums.NzKindPrint.PaperA4,remaind);
            prn.Show(this);
        }
        private void NzPrintNormalA5_Click              (object sender, EventArgs e)
        {
            var remaind = "";
            if (NzPeopleRemaind.Checked)
            {
                var tmp = NzCustomer.MS_Get_Selected() as People;
                NzCustomerRemain.NzSetCustoemr(tmp?.ID ?? 0);
                remaind = "مانده حساب شخص : " + NzCustomerRemain.Text;
            }
            var prn = new Print.Print(_Manager, _Factor.ID, Enums.NzKindPrint.PaperA5, remaind);
            prn.Show(this);
        }
        private void NzPosPrint_Click                   (object sender, EventArgs e)
        {
            var prn = new Print.Print(_Manager, _Factor.ID, Enums.NzKindPrint.PosPrint);
            prn.Show(this);
        }

        private void NzSave_Click                       (object sender, EventArgs e)
        {
            RemoveUnSavedRow();
            _DoRefresh = false;
            RefreshFactorSum();
            _DoRefresh = true;

            if (IsOK())
                Save();
        }
        private void NzNew_Click                        (object sender, EventArgs e)
        {
            Reset();
        }
        private void NzPayment_Click                    (object sender, EventArgs e)
        {
            if (_Factor.ID == 0 || _Factor.FactorItems.Any(x => x.State == Enums.NzItemState.NotChanged))
            {
                var result = MS_Message.Show("کاربر گرامی !" +
                                             "\n ابتدا تغییرات فاکتور را ذخیره کنید",
                                             "ذخیـره فاکتور",
                                             MessageBoxButtons.YesNo);
                if(result!=DialogResult.Yes)
                    return;
                NzSave.PerformClick();
            }

            if (_Factor.ID > 0)
            {
                //var kind = (byte) _Kind < 50
                //    ? Enums.FormOperation.Payment
                //    : Enums.FormOperation.Recieve;
                //var formKind= (byte)_Kind < 50
                //    ? Enums.NzPaymentOperatingKind.Pardaxt
                //    : Enums.NzPaymentOperatingKind.Daryaft;

                var kind        = Enums.FormOperation.FactorPaymentList;
                var Msg         = new FactorPaymentMessage()
                {
                    Kind        = (byte)_Kind < 50
                                       ? Enums.NzPaymentOperatingKind.Pardaxt
                                       : Enums.NzPaymentOperatingKind.Daryaft,
                    Description = "بابت تسویه فاکتور " + NzSerial.Text,
                    IDFactor    = _Factor.ID,
                    IDPeople    = _Factor.FK_AshXas_ID??0,
                    Amount      = _Factor.mablaq
                };

                var frm = Form_Factory._Form_Factory_Xazaneh.GetFormForEdit(kind,Msg);

                frm?.Set_Form_Param(Msg);
                (frm as Form)?.ShowDialog(this);
                if (frm != null)
                    LoadPayment();
            }
        }
        public  void Set_Form_Param                     (params object[] List_Parametter)
        {
            foreach (var Item in List_Parametter)
            {
                if (Item is long ItemID)
                    _ID     = (long) ItemID;
                else if (Item is byte ItemKind)
                    _Kind   = (Enums.NzFactorKind) ItemKind;
            }

            Init();
        }

        private void NzGrid_CellValueChanged            (object sender, ColumnActionEventArgs e)
        {

        }

        private void NzKind_SelectedIndexChanged(object sender, EventArgs e)
        {
	        if (NzGrid.GetDataRows().Any())
	        {
		        var result = 
			        MS_Message
				        .Show(
					        "نوع فروش تغییر کرده است. \n\r " +
					        "آیا مایلید تا نرخ ها را بروز رسانی کنیم؟"
					        , "بروز رسانی نرخ فروش"
					        , MessageBoxButtons.YesNo
					        , MSMessage.FarsiMessageBoxIcon.سوال
				        );

		        if (result != DialogResult.Yes)
			        return;


		        _Factor.FactorItems.Where(x=>x.State!=Enums.NzItemState.Deleted)
			        .MSZ_ForEach(item =>
			        {
				        var kala = nzObjectPopup1.GetAvailObject(item.FK_Kala);
				        if (kala != null)
				        {
					        var p = new NzObject()
					        {
						        Code = kala.Code,
						        nerkh_frosh = kala.nerkh_frosh,
						        nerkh_frosh1 = kala.nerkh_frosh1,
						        nerkh_frosh2 = kala.nerkh_frosh2,
						        nerkh_frosh3 = kala.nerkh_frosh3,

					        };
					        _Bind.AddOrUpdate(p, (Enums.NzSalingKind)NzKindSale.SelectedIndex, 0);
				        }
			        });

		        _DoRefresh = false;
		        RefreshFactorSum();
		        //Save();
		        _DoRefresh = true;
	        }
        }
	}
}
