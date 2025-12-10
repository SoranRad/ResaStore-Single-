using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using MS_Control;
using MS_Control.Tarikh;
using MS_Print_Dialog;
using Nz.Anbar.Model.ViewModel;
using NZ.Anbar.Business;
using NZ.Anbar.Model;
using Nz.Anbar.Model.Model;
using Nz.Anbar.Model.Report;
using Nz.Anbar.WinForms.Component;
using Nz.Anbar.WinForms.Provider;
using Nz.Anbar.WinForms.Report;
using Nz.Anbar.WinForms.Settings;
using ShareLib;
using ShareLib.Interfaces;
using ShareLib.Models;
using ShareLib.Utils;
using ShareLib.ViewModel;

namespace Nz.Anbar.WinForms.App
{
    public partial class Form_BarCode : Form
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        NumberStyles sty =   NumberStyles.AllowDecimalPoint 
                           | NumberStyles.AllowThousands 
                           | NumberStyles.Currency;

        #endregion
        #region Fields
        private string              _SimpleText;
        private string              _Dot            = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
        private int                 _Pos            = 0;
        private int                 _Len            = 0; 
        private bool                _DoRefresh      = true;
        private FactorHead          _Factor;
        private BidingFactorItems   _Bind;
        private FactorManager       _Manager;
        private long                _ID;
        private int                 _Serial;
        private Enums.NzFactorKind  _Kind           = Enums.NzFactorKind.Frosh;

        private List<NzObject>      _ListObjects    = new List<NzObject>();
        private string              _FormatString = "0,0.##;(0,0.##); "; 
        #endregion
        public Form_BarCode(long ID = 0)
        {
            InitializeComponent();
            _Manager    = new FactorManager();
            _ID         = ID;
            nzBarcodeReader1.NzEnterPressed += NzBarcodeReader_KeyUp;
            NzBarcodePrice.NzEnterPressed   += NzEnterPressed;
        }

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
            byte KindCustomer = 2;

            NzCustomer.Refresh_Grid         (_Manager.Connection,KindCustomer);
            nzObjectPopup1.RefreshControl   (new Size(550, 210));
            nzObjectPopup1.NzSelectObject   += NzObjectPopup1OnNzSelectObject;
            nzObjectPopup1.NzEscapedPress   += NzObjectPopup1OnNzEscapedPress;
            NzGrid.FilterMode               = FilterMode.None;
            
            NzLocation.RefreshItems(_ID>0);
            LoadObjects();
            SubGroupsPanel.RefreshGroup();
            SubGroupsPanel.OnSubGroupChanged+=SubGroupsPanelOnOnSubGroupChanged;
            NsGridFavorites.DataSource = _ListObjects.Where(x => x.ShowInBarcodeForm).ToList();

            if(_ID==0)
                Reset();
            else 
                LoadItem();

            _Bind                           = new BidingFactorItems(_Factor);
            NzGrid.DataSource               = _Bind;

            LoadSettings();
            RefreshPrefactor                ();
            //AddPayment                      ();
            ValidationDemo                  ();
            NzKind.SelectedIndexChanged     += NzKind_SelectedIndexChanged;
        }

        private void SubGroupsPanelOnOnSubGroupChanged(object sender, SubGroupEventArgs e)
        {
	        NzGroupKala.DataSource = _ListObjects.Where(x => x.FK_GroupKala_2th == e.SubGroup.Code && !x.is_disabled).ToList();
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
                NzCustomer.MS_Set_Select    (_Factor.FK_AshXas_ID);
                _Kind                       = (Enums.NzFactorKind) _Factor.kind;
                _Bind                       = new BidingFactorItems(_Factor);
                NzGrid.DataSource           = _Bind;

                NzOffPercent.Text           = (_Factor?.FactorDetail?.Darsad_Takhfif ?? 0).ToString(_FormatString);
                NzOffPrice.Text             = (_Factor?.FactorDetail?.mablaq_takhfif ?? 0).ToString(_FormatString);
                NzKind.SelectedIndex        = _Factor.FK_Kind_Frosh??0;
                NzLocation.SetLocation      (_Factor.FK_Location);
                NzDescription.Text          = _Factor.sharh;
                RefreshFactorSum            ();

                _DoRefresh = true;
            }
            catch (Exception ex)
            {
                MS_Message.Show(ex.Message);
                log.Error(ex);
            }
        }
        private void Save                           (bool ShowPopup = false)
        {
            try
            {
                RemoveUnSavedRow();
                if (!IsOK())
                    return;

                if (_Factor.ID == 0)
                {
                    _Factor.FK_Salmali  = SystemConstant.ActiveYear.Salmali;
                    _Factor.FK_User_Add = SystemConstant.ActiveUser.ID;
                    _Factor.tarikh_add  = DateTime.Now;
                    _Factor.kind        = (byte) _Kind;
                }

                _Factor.Serial          = Convert.ToInt32(NzSerial.MS_Decimal);
                _Factor.FK_AshXas_ID    = (NzCustomer.MS_Get_Selected() as People).ID;
                _Factor.tarikh          = NzDate.MS_Tarikh.Value.ToDatetime().Date;
                _Factor.sharh           = NzDescription.Text;

                if (NzOffPrice.MS_Decimal > 0 )
                {
                    if (_Factor.FactorDetail == null)
                    {
                        _Factor.FactorDetail = new FactorDetail()
                        {
                            FactorHead      = _Factor,
                            State           = Enums.NzItemState.AddedNew,
                        };
                    }
                    else
                        _Factor.FactorDetail.State = Enums.NzItemState.Modified;
                     
                    _Factor.FactorDetail.Darsad_Takhfif =
                        NzOffPercent.MS_Decimal == 0 ? null : (decimal?) NzOffPercent.MS_Decimal;
                    _Factor.FactorDetail.mablaq_takhfif =
                        NzOffPrice.MS_Decimal   == 0 ? null : (decimal?) NzOffPrice.MS_Decimal; 
                }
                else if
                (
                    _Factor.ID > 0
                    && _Factor.FactorDetail != null
                    && ( 
                        NzOffPrice.MS_Decimal != _Factor.FactorDetail.mablaq_takhfif
                        || NzOffPercent.MS_Decimal != _Factor.FactorDetail.Darsad_Takhfif 
                    )
                )
                {
                    _Factor.FactorDetail.State = Enums.NzItemState.Modified;
                     
                    _Factor.FactorDetail.Darsad_Takhfif =
                        NzOffPercent.MS_Decimal == 0 ? null : (decimal?)NzOffPercent.MS_Decimal;
                    _Factor.FactorDetail.mablaq_takhfif =
                        NzOffPrice.MS_Decimal == 0 ? null : (decimal?)NzOffPrice.MS_Decimal; 
                }
                _Factor.mablaq          = NzSumFactor.MS_Decimal ?? 0;
                _Factor.FK_Location     = (NzLocation.SelectedItem?.DataRow as Location)?.ID;
                _Factor.FK_Kind_Frosh   = (short)NzKind.SelectedIndex;

                _Manager.Save(_Factor);
                
                if (ShowPopup)
                    new Form_Notify("ذخـیـره سـازی", "اطـلاعـات بـا مـوفـقـیـت ثـبـت شـــد.",
                            Form_Notify.FarsiMessageBoxIcon.اضافه)
                        .Popup(Form_Notify.Direction_Show.Right_To_Left, 1000);

                NzSerial.MS_Decimal = _Factor.Serial;
                SetItemsNoChanges();
                
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MS_Message.Show("خطا در برنامه", "", ex.Message, MessageBoxButtons.OK);
            }
        }
        private void LoadObjects                    ()
        {
            var mgr= new Manager();

                _ListObjects = mgr
                                .GetList<NzObject>(
                                    new{
                                        Year = SystemConstant.ActiveYear.Salmali
                                       })
                                .ToList();

        }
        private void Reset                          ()
        {
	        if (_Factor!=null && !_Factor.FactorItems.Any() && _Factor.ID > 0 )
	        {
		        if (HasPayment())
		        {
			         var r = MS_Message.Show(@"فاکتور مورد هیچ گونه ردیفی ندارد و شما برای آن مبالغی را دریافت کرده اید
 آیا مایلید به این فاکتور اقلامی را اضافه کنید؟
","فاکتور خالی",MessageBoxButtons.YesNo);

                     if(r == DialogResult.Yes)
                         return;
                     else
                     {
	                     r = MS_Message.Show(@"فاکتور خالی با وجوه دریافتی حذف شود؟","حذف فاکتور خالی",MessageBoxButtons.YesNo);

	                     if (r == DialogResult.Yes)
	                     {
		                     IEnumerable<FactorPaymentResolve> List = null;
		                     var Mgr = new FactorManager();
		                     var mgr = new ReportManager();
		                     List    = mgr.GetReport<FactorPaymentResolve>(new { ID = (long)_Factor.ID }, null);


		                     if (List != null && List.Any())
		                     {
			                     var whereClause = string.Join(" OR ", List.Select(x => "ID =" + x.ID));
			                     mgr.GetItem<FactorPaymentsDelete>(null, whereClause);
		                     }

		                     Mgr.Delete((long)_Factor.ID);

		                     new Form_Notify
			                     (
				                     "تـوجـه",
									 "حـذف فاکتور مـورد نـظر انـجـام شــد.",
				                     Form_Notify.FarsiMessageBoxIcon.چـک_باکس
			                     )
			                     .Popup(Form_Notify.Direction_Show.Down_To_Up, 500);
						 }
					 }
				}
	        }

			_DoRefresh                  = false; 


            GetMaxSerial                ();
            //LoadSettings();

            _ID                         = 0;
            _Factor                     = new FactorHead();
            _Bind                       = new BidingFactorItems(_Factor);
            NzGrid.DataSource           = _Bind;
            NzDate.MS_Tarikh            = new MS_Structure_Shamsi(DateTime.Now);


            NzOffPrice.MS_Decimal       = 0;
            NzOffPercent.MS_Decimal     = 0;
            NzSumFactor.MS_Decimal      = 0;
            NzKind.SelectedIndex        = 0;

            nzBarcodeReader1.Focus();
            NzDescription.Text = "";
          
            _DoRefresh                  = true;
        }
        private void ShowMenu                       ()
        {
            try
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
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void RemoveUnSavedRow               ()
        {
            try
            {
                _Factor
                        .FactorItems
                        .Where(x => x.meqdar == 0 || x.FK_Kala == 0 || x.mablaq == 0)
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
            try
            {
                _Serial = _Manager.GetMaxSerial(new
                {
                    Kind = (byte)_Kind,
                    Year = SystemConstant.ActiveYear.Salmali
                }) + 1;

                NzSerial.MS_Decimal = _Serial;
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private bool IsOK                           ()
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
            if (NzCustomer.MS_Get_Selected()==null)
            {
                NzCustomer.Focus();
                mS_Notify1.Show(NzCustomer);
                return false;
            }

            if (_ID > 0 && NzSumFactor.MS_Decimal > _Factor.mablaq)
            {
                var delta = NzSumFactor.MS_Decimal - _Factor.mablaq;
                if (NzCustomerRemain.IsUserBlocked(delta ?? 0))
                {
                    var result = MS_Message.Show("سقف اعتبار کاربر پرشده است. " +
                                    "آیا مایلید که فاکتور را ثبت کنید؟",
	                    "حد مجاز حساب کاربر",MessageBoxButtons.YesNo);
                    NzCustomerRemain.Focus();
                    mS_Notify1.Show(NzCustomerRemain);
                    return result == DialogResult.Yes;
                }
            }
            else
            {
                if (NzCustomerRemain.IsUserBlocked(_Factor.mablaq))
                {
	                var result = MS_Message.Show("سقف اعتبار کاربر پرشده است. " +
	                                             "آیا مایلید که فاکتور را ثبت کنید؟",
		                "حد مجاز حساب کاربر",MessageBoxButtons.YesNo);
	                NzCustomerRemain.Focus();
	                mS_Notify1.Show(NzCustomerRemain);
	                return result == DialogResult.Yes;
                }
            }

            try
            {
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
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }

            return true;
        }
        private void SetItemsNoChanges              ()
        {
            try
            {
                _Factor.FactorItems.MSZ_ForEach(x =>
                   {
                       x.State = Enums.NzItemState.NotChanged;
                   });
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
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
                //var tax = NzTaxPercent.MS_Decimal > 0
                //                ? NzTaxPercent.MS_Decimal / 100 * (sum - off)
                //                : 0;
                var tax = 0;
                var extend = 0;
                //=====
                NzOffPrice.MS_Decimal = decimal.Round(off);
                //NzTaxPrice.MS_Decimal = decimal.Round(tax);
                //=====

                NzSumFactor.MS_Decimal = decimal.Round(sum - off + tax + extend);
                //if (_PaymentControl is IPaymentCommand pay)
                //    pay.SetMount(_Factor.mablaq);
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void LoadSettings                   ()
        {
            Task.Run(() =>
            {
	            if (Form_Factory._Form_Factory_Anbar.GetSettings() is SettingItems Setting)
                {
                    //==================================================
                    if(NzCustomer.InvokeRequired)
                        NzCustomer.Invoke(new MethodInvoker(delegate
                        {
                            NzCustomer.MS_Set_Select(Setting.MiscID);
                        }));
                    else
                        NzCustomer.MS_Set_Select(Setting.MiscID);

                    if(NzCustomerRemain.InvokeRequired)
	                    NzCustomerRemain.Invoke(new MethodInvoker(delegate
	                    {
		                    NzCustomerRemain.NzSetCustoemr(Setting.MiscID);
	                    }));
                    else
	                    NzCustomerRemain.NzSetCustoemr(Setting.MiscID);

                    //==================================================
                    if(NzLocation.InvokeRequired)
                        NzLocation.Invoke(new MethodInvoker(delegate
                        {
                           NzLocation.SetLocation      (Setting.LocationID);
                        }));
                    else
                        NzLocation.SetLocation      (Setting.LocationID);
                    //==================================================
                    if (Setting.IsOffActive && Setting.OffAmount>0)
                    {
	                    if (Setting.IsOffPercent)
	                    {
		                    if (NzOffPercent.InvokeRequired)
			                    NzOffPercent.Invoke(new MethodInvoker(delegate
			                    {
				                    NzOffPercent.MS_Decimal =Setting.OffAmount;
			                    }));
		                    else
								NzOffPercent.MS_Decimal = Setting.OffAmount;
						}
	                    else
	                    {
		                    if (NzOffPrice.InvokeRequired)
			                    NzOffPrice.Invoke(new MethodInvoker(delegate
			                    {
				                    NzOffPrice.MS_Decimal = Setting.OffAmount;
			                    }));
		                    else
			                    NzOffPrice.MS_Decimal = Setting.OffAmount;
						}

                    }

                }
            });
        }
        private void NzDirecrPrint                  ()
        {
            var Co                  = SystemConstant.ActiveCompany;
            var Cu                  = NzCustomer.MS_Get_Selected() as People;
            var printerName         = "";
            short Copies            = 1;
            var Factors             = _Manager.GetPrintFactor(_Factor.ID);
            var factor              = Factors.FirstOrDefault();


            if (factor == null)
	            return;

            if (Form_Factory._Form_Factory_Anbar.GetSettings() is SettingItems Setting)
            {
	            printerName = Setting.FishPrinter;
	            Copies = Setting.PrintCountInBarcode <= 0 ? (short)1 : Setting.PrintCountInBarcode;
            }


            var dic = new Dictionary<string, object>()
            {
                {"txt"              , _Factor.sharh},
                {"noh_faktor"       , (_Kind).NzToString()},
                {"company"          , SystemConstant.ActiveCompany.title},
                {"serial"           ,_Factor.Serial.ToString()},
                {"tarikh"           ,new MS_Structure_Shamsi( _Factor.tarikh).ToShamsi()},
                {"mablaq"           ,_Factor.mablaq},

                {"name_2"           , Cu.title},
                {"code_meli_2"      , (Cu.codeEqtesadi?? "") + " " + (Cu.codeMeli ?? "")},
                {"tel_2"            , (Cu.tel??"") + " " + (Cu.telDowom??"")},
                {"fax_2"            , Cu.fax??""},
                {"mobile_2"         , (Cu.mobile??"") + " " + (Cu.mobDowom??"")},
                {"address_2"        , Cu.addressHome},

                {"name_1"           , Co.title},
                {"code_meli_1"      , Co.code_melli},
                {"code_eqtesadi_1"  , Co.code_eqtesadi},
                {"tel_1"            , (Co.tel??"")+" "+ (Co.tel2??"")},
                {"fax_1"            , Co.fax},
                {"mobile_1"         , (Co.mobile??"") + " " + (Co.mobile2??"")},
                {"address_1"        , Co.address},

                {"banki"            ,factor.Pos},
                {"naqdi"            ,factor.Cache},
                {"chak"             ,factor.Cheque},

                {"mablaq_takhfif"   ,_Factor.FactorDetail?.mablaq_takhfif},
                {"Darsad_Takhfif"   ,_Factor.FactorDetail?.Darsad_Takhfif},
                {"mablaq_Maliat"    ,_Factor.FactorDetail?.mablaq_Maliat},
                {"Darsad_Maliat"    ,_Factor.FactorDetail?.Darsad_Maliat},
                {"Ezafat"           ,_Factor.FactorDetail?.Ezafat},

                {"mab_kol_harf"     , MS_Util.num2str(_Factor.mablaq.ToString("F0")).Trim() + " ریال"},
                {"mola"             , Co.molahezat??""}
            };
            var prnFile = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            prnFile += "\\Print\\Anbar\\Pos_Print.mrt";
            var p = new DirectPrint(prnFile, new Dictionary<string, object>() {{"List", _Factor.FactorItems}}, dic,true,true,printerName,Copies);

        }
        private void RefreshPrefactor               ()
        {
            var mgr = new PrefactorManager();
            NzPrefactorGrid.DataSource = mgr.GetList(null).ToList();

        }
        private void AddPrefactor                   (int IdPrefactor)
        {
            var mgr         = new PrefactorManager();
            var prefactor   = mgr.GetItem(IdPrefactor);
            
            if (prefactor == null)
                return;

            foreach (var item in prefactor.Items)
            {
                var nzObject = _ListObjects.SingleOrDefault(x => x.ID == item.FK_Kala);
                if (nzObject == null)
                    continue;

                AddObject(nzObject, item.Count == 0 ? 1 : item.Count);
            }

        }
		private void CheckForItemExist              ()
		{
			if (!_Factor.FactorItems.Any() && _Factor.ID>0)
			{
                if(HasPayment())
                    return;

                var customer = NzCustomer.MS_Get_Selected() as People;
				_Manager.Delete(_Factor.ID);
                Reset();
                NzCustomer.MS_Set_Select(customer);
			}
		}
		private bool HasPayment                     ()
		{
			var mgr = new ReportManager();
			var payment = mgr.GetItem<FactorPayment>(new { _Factor.ID }, null);
			return payment != null;
		}
		#endregion
		#region Grid Events
		private void ms_grid_EditModeChanged        (object sender, EventArgs e)
        {
            try
            {
                if (
                        NzGrid.EditMode == EditMode.EditOn 
                    &&  NzGrid.EditTextBox != null
                    && (
                               NzGrid.CurrentRow.RowType == RowType.NewRecord 
                            || NzGrid.CurrentRow.RowType == RowType.Record
                        )
                )
                {

                    NzGrid.EditTextBox.KeyPress += EditTextBoxOnKeyPress;
                    NzGrid.EditTextBox.TextChanged += EditTextBoxOnTextChanged;
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
	            if (NzGrid.CurrentRow==null) 
		            return;

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
                if (NzGrid.CurrentRow == null)
                    return;

                var key = NzGrid.CurrentRow.DataRow as FactorItem;

                if (key?.meqdar == 0 || key?.FK_Kala == 0 || key?.nerkh==0)
                {
                    NzGrid.CancelCurrentEdit();
                    NzGrid.CurrentRow.CancelEdit();
                    e.Cancel = true;
                    _Bind.Remove(key);
                }

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
                if (NzGrid.CurrentRow == null)
                    return;

                var key = NzGrid.CurrentRow.DataRow as FactorItem;

                if (key?.meqdar == 0 || key?.FK_Kala == 0 || key?.nerkh==0)
                {
                    NzGrid.CancelCurrentEdit();
                    NzGrid.CurrentRow.CancelEdit();
                    e.Cancel = true;
                    _Bind.Remove(key);
                }
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
                    var key = NzGrid.CurrentColumn?.Key;
                    var type = Cur.RowType;

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
                                Save();
                            }
                        }
                    }
                    Cur?.CancelEdit();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void ms_grid_ColumnButtonClick      (object sender, ColumnActionEventArgs e)
        {
            try
            {
                if (e.Column.Key == "D")
                {
                    if (NzGrid.CurrentRow == null)
                        return;
                    if (NzGrid.CurrentRow.DataRow == null)
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
                    if (row.ID > 0)
                    {
                        var result = MS_Message
                            .Show("آیا برای حذف ردیف مورد نظر مطمئنید؟",
                            "حذف ردیف",
                            MessageBoxButtons.YesNo);
                        if (result != DialogResult.Yes)
                            return;
                    }
                    NzGrid.CurrentRow.Delete();
                    _DoRefresh = false;
                    RefreshFactorSum();
                    Save();
                    CheckForItemExist();
                    _DoRefresh = true;
                }
                else if (e.Column.Key == "E")
                {

                    NzGrid.CurrentColumn = NzGrid.RootTable.Columns["ObjectTitle"];
                    ShowMenu();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
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
                if (row?.ID > 0)
                    Save();
                _DoRefresh = true;
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void NzGrid_RecordAdded             (object sender, EventArgs e)
        {
            try
            {
                _DoRefresh = false;
                RefreshFactorSum();
                Save();
                _DoRefresh = true;
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
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
                    {
                        _Bind.Remove(row);
                        Save();
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void NzGrid_GetNewRow               (object sender, GetNewRowEventArgs e)
        {
	        try
	        {
		        _Bind.RemoveTempRow();
	        }
	        catch (Exception exception)
	        {


	        }
        }
        #endregion
        #region TextBox Events
        private void EditTextBoxOnKeyPress          (object sender, KeyPressEventArgs e)
        {
            try
            {
                char key = e.KeyChar;
                if (!(char.IsDigit(key) || key == '\b' || key == '.' || key == '+' || key == '-'))
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
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void EditTextBoxOnTextChanged       (object sender, EventArgs eventArgs)
        {
            try
            {
                if (!_DoRefresh)
                    return;
                _DoRefresh = false;

                var TextBox = NzGrid.EditTextBox;
                _SimpleText = TextBox.Text.Replace(",", string.Empty);

                var start = _SimpleText.Contains(_Dot)
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
            catch (Exception ex)
            { 
                log.Error(ex);
            }
        }
         
        private void Set_Cursor_Location            ()
        {
            try
            {
                int tm = NzGrid.EditTextBox.Text.Length - _Len;

                int x = _Pos + tm;
                x = x < 0 ? 0 : x;
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
            }
            catch (Exception ex)
            {
                log.Error(ex);
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
                                            out decimal num))
                {
                    var r = NzGrid.CurrentRow.DataRow as FactorItem;

                    var sum = num * (r?.meqdar ?? 0);

                    if (sum == 0)
                    {
                        RefreshCurrency(0, 0);
                        return;
                    }

                    var takhfif = (r?.takhfif_darsad ?? 0) > 0
                                        ? Math.Round((r?.takhfif_darsad ?? 0) / 100 * sum)
                                        : (r?.takhfif ?? 0);

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
                    var r = NzGrid.CurrentRow?.DataRow as FactorItem;

                    var cell = NzGrid.CurrentRow.Cells["nerkh"];


                    if ((r?.meqdar ?? 0) == 0)
                    {
                        RefreshCurrency(0, 0);
                        return;
                    }

                    var nerkh = decimal.Round((num + (r?.takhfif ?? 0)) / (r?.meqdar ?? 0));
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
        private void RefreshCurrency                (decimal Sum , decimal Off)
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
        #region Barcode
        private void FindObject                     ()
        {
            try
            {
                var str = nzBarcodeReader1.Text.Trim();
                if (string.IsNullOrEmpty(str))
                    return;

                var items = _ListObjects.Where(x => x.barcode.Equals(str));

                if (!items.Any())
                {
                    NzFindObject.ForeColor      = Color.Red;
                    nzBarcodeReader1.BackColor  = Color.Red;
                    NzFindObject.Text           = "یافت نشد";
                    SystemSounds.Beep.Play();
                    return;
                }

                if (items.Count() == 1)
                    AddObject(items.First());
                else
                    ShowMenuObject(items);
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void AddObject                      (NzObject Item,decimal Meqdar = 1)
        {
            _Bind.AddOrUpdate(Item,(Enums.NzSalingKind)((byte)NzKind.SelectedIndex),Meqdar,Item.IsOffPercent,Item.IsOffActive?Item.OffAmount:0);
            NzFindObject.ForeColor          = Color.DarkGreen;
            nzBarcodeReader1.BackColor      = Color.White;
            NzFindObject.Text               = Item.title;
            _DoRefresh = false;
            RefreshFactorSum();
            Save();
            _DoRefresh = true;
        }
        private void ShowMenuObject                 (IEnumerable<NzObject> List)
        {
            NzFindObject.Text = "?";
            if (List.Count() > 10)
                List = List.Take(10);

            var menues = List
                .Select(x => new ToolStripMenuItem
                {
                    Text =x.Code + " - " + x.title+ " - " + x.UnitTitle ,
                    Tag = x,
                });
            contextMenuStrip1.Items.Clear();
            contextMenuStrip1.Items.AddRange(menues.ToArray());
            contextMenuStrip1.Show(nzBarcodeReader1, new Point(nzBarcodeReader1.Width / 2, nzBarcodeReader1.Height), ToolStripDropDownDirection.Left);
            //contextMenuStrip1.Show(nzBarcodeReader1,ToolStripDropDownDirection.Left);
        }
        #endregion
        //====================================
        private void NzObjectPopup1OnNzSelectObject     (object sender, EventArgs eventArgs)
        {
            try
            {
                if (nzObjectPopup1.NzSelected == null || NzGrid.CurrentRow == null)
                    return;

                var obj = nzObjectPopup1.NzSelected;
                var Current = NzGrid.CurrentRow;

                Current?.BeginEdit();

                Current.Cells["ObjectTitle"].Value = obj.title;
                Current.Cells["FK_Kala"].Value = obj.Code;
                Current.Cells["UnitTitle"].Value = obj.UnitTitle;

                if(NzKind.SelectedIndex==0)
	                Current.Cells["nerkh"].Value = obj.nerkh_frosh;
                else if(NzKind.SelectedIndex==1)
	                Current.Cells["nerkh"].Value = obj.nerkh_frosh1;
                else if(NzKind.SelectedIndex==2)
	                Current.Cells["nerkh"].Value = obj.nerkh_frosh2;
                else if(NzKind.SelectedIndex==3)
	                Current.Cells["nerkh"].Value = obj.nerkh_frosh3;
                else
	                Current.Cells["nerkh"].Value = obj.nerkh_frosh;

                if (obj.IsOffActive && obj.OffAmount > 0)
	                Current.Cells
		                [
			                obj.IsOffPercent ? nameof(FactorItem.takhfif_darsad) : nameof(FactorItem.takhfif)
		                ]
		                .Value = obj.OffAmount;

				NzGrid.CurrentColumn = NzGrid.RootTable.Columns["meqdar"];
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void NzObjectPopup1OnNzEscapedPress     (object sender, EventArgs eventArgs)
        {
            try
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

                if (NzGrid.CurrentRow.RowType == RowType.NewRecord
                    && nzObjectPopup1.NzSelected == null)
                {
                    NzGrid.CancelCurrentEdit();
                    NzGrid.CurrentRow.CancelEdit();
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }

        private void NzOffPercent_TextChanged           (object sender, EventArgs e)
        {
            try
            {
                if (!_DoRefresh)
                    return;
                _DoRefresh = false;

                NzOffPrice.MS_Decimal = decimal.Round(NzOffPercent.MS_Decimal / 100 * (NzSumRows.MS_Decimal ?? 0));
                RefreshFactorSum();

                _DoRefresh = true;
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void NzOffPrice_TextChanged             (object sender, EventArgs e)
        {
            try
            {
                if (!_DoRefresh)
                    return;
                _DoRefresh = false;

                NzOffPercent.MS_Decimal = 0;
                RefreshFactorSum();

                _DoRefresh = true;
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        

        private void Form_Purchase_Shown                (object sender, EventArgs e)
        {
            Init();
        }
        private void Form_Purchase_KeyUp                (object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
	                NzFactorKinds.SelectedIndex = 2;
                    NzBarcodePrice.Focus();
                    break;
                case Keys.F3:
                    nzBarcodeReader1.Focus();
                    break;
                case Keys.F4:
                    NzGrid.Focus();
                    NzGrid.MoveToNewRecord();
                    break;
                case Keys.F6:
                    NzDirecrPrint();
                    break;
                case Keys.F8:
	                NzSave.PerformClick();
	                break;
                case Keys.F7:
                    NzPayment.PerformClick();
                    break;
                case Keys.F10:
                    NzNew.PerformClick();
                    break;
                case Keys.F12:
                    NzNewWindows.PerformClick();
                    break;
            }

            
        }

        private void NzPrintNormalA4_Click              (object sender, EventArgs e)
        {
            var prn = new Print.Print(_Manager, _Factor.ID, Enums.NzKindPrint.PaperA4);
            prn.Show(this);
        }
        private void NzPrintNormalA5_Click              (object sender, EventArgs e)
        {
            var prn = new Print.Print(_Manager, _Factor.ID, Enums.NzKindPrint.PaperA5);
            prn.Show(this);
        }
        private void NzPosPrint_Click                   (object sender, EventArgs e)
        {

            var prn = new Print.Print(_Manager, _Factor.ID, Enums.NzKindPrint.PosPrint);
            //prn.DirectPrint = true;

            if (Form_Factory._Form_Factory_Anbar.GetSettings() is SettingItems Setting)
	            prn.DefaultPrinter = Setting.FishPrinter;

            prn.Show(this);
        }

        private void NzSave_Click                       (object sender, EventArgs e)
        { 
            Save(true);
        }
        private void NzNew_Click                        (object sender, EventArgs e)
        {
            Reset();
            LoadSettings();
        }
        private void NzNewWindows_Click                 (object sender, EventArgs e)
        {
            var frm = new Form_BarCode();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
        
        
        private void contextMenuStrip1_ItemClicked      (object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Tag is NzObject Item)
            {
                AddObject(Item);
                nzBarcodeReader1.Focus();
            }
        }

        private void NzBarcodeReader_KeyUp              (object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                FindObject();
                nzBarcodeReader1.SelectAll();
            }
        }
        private void NzEnterPressed                     (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                try
                {
                    var str = NzBarcodePrice.Text.Trim();
                    if (string.IsNullOrEmpty(str))
                        return;

                    var items = _ListObjects.Where(x => x.barcode.Contains(str));

                    if (!items.Any())
                    {
                        NzFindObject.ForeColor = Color.Red;
                        NzBarcodePrice.BackColor = Color.Red;
                        NzFindObject.Text = "یافت نشد";
                        SystemSounds.Beep.Play();
                        return;
                    }

                    if (items.Count() == 1)
                    {
                        NzFindObject.ForeColor = Color.DarkGreen;
                        NzBarcodePrice.BackColor = Color.White;
                        var item = items.First();

                        NsPriceBarcodeTitle.Text    = item.title;
                        NsAdiPrice.MS_Decimal       = item.nerkh_frosh;
                        NsOmdePrice.MS_Decimal      = item.nerkh_frosh1;
                        NsHamkari.MS_Decimal        = item.nerkh_frosh2;
                        NsTakhfifPrice.MS_Decimal   = item.nerkh_frosh3;
                    }
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                }
            }
        }

        private void nzBarcodeReader1_Enter             (object sender, EventArgs e)
        {
            nzBarcodeReader1.SelectAll();
        }
        private void NzCustomer_MS_On_Row_Selected      (object sender, MS_Control.TSDD.On_Selected e)
        {
	        //if ((NzCustomer.MS_Get_Selected() is People custmer) && (_PaymentControl is IPaymentCommand cmd))
	        //{
		       // cmd.SetPerson(custmer.ID);
         //       //NzCustomerRemain.NzSetCustoemr(custmer.ID);
	        //}

	        if ((NzCustomer.MS_Get_Selected() is People custmer1))
	        {
		        NzCustomerRemain.NzSetCustoemr(custmer1.ID);
	        } 
        }
        
        private void NzPrefactorGrid_ColumnButtonClick  (object sender, ColumnActionEventArgs e)
        { 
            try
            {
                var current = NzPrefactorGrid.CurrentRow;
                if (current == null || current.RowType != RowType.Record)
                    return;

                if (current.DataRow is PreFactor item )
                    AddPrefactor(item.ID);
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }

        }
        private void NsGridFavorites_ColumnButtonClick(object sender, ColumnActionEventArgs e)
        {
	        try
	        {
		        var current = NsGridFavorites.CurrentRow;
		        if (current == null || current.RowType != RowType.Record)
			        return;

		        if (current.DataRow is NzObject item)
			        AddObject(item);

			}
			catch (Exception ex)
	        {
				log.Error(ex);
			}
		}

		private void NzPayment_Click                    (object sender, EventArgs e)
        {
            if (_Factor.ID > 0)
            {
                var kind = Enums.FormOperation.BarcodePayment;
                var Msg = new FactorPaymentMessage()
                {
                    Kind = (byte)_Kind < 50
                        ? Enums.NzPaymentOperatingKind.Pardaxt
                        : Enums.NzPaymentOperatingKind.Daryaft,
                    IDFactor = _Factor.ID,
                    IDPeople = _Factor.FK_AshXas_ID ?? 0,
                    Amount = _Factor.mablaq
                };

                var frm = Form_Factory._Form_Factory_Xazaneh.GetFormForEdit(kind, Msg);

                frm?.Set_Form_Param(Msg);
                (frm as Form)?.ShowDialog(this);

                var result = new FormBarCodeResult().ShowDialog(this.Parent);

                switch (result)
                {
	                case DialogResult.Retry:
                        NzDirecrPrint();
                        NzNew.PerformClick();
                        break;
	                case DialogResult.Yes:
		                NzNew.PerformClick();
		                break;
	                case DialogResult.No:
		                NzDirecrPrint();
		                break;
	                case DialogResult.Cancel:

		                break;
                }

            }
        }

		private void NzKind_SelectedIndexChanged        (object sender, EventArgs e)
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
		                var kala = _ListObjects.SingleOrDefault(x => x.Code == item.FK_Kala);
                        if (kala!=null)
		                    _Bind.AddOrUpdate(kala, (Enums.NzSalingKind)NzKind.SelectedIndex, 0);
	                });

                _DoRefresh = false;
                RefreshFactorSum();
                Save();
                _DoRefresh = true;
			}

			 
			NzGroupKala.RootTable.Columns[nameof(NzObject.nerkh_frosh)].DataMember = 
					NzKind.SelectedIndex == 0 
						? nameof(NzObject.nerkh_frosh)
                        : nameof(NzObject.nerkh_frosh) + NzKind.SelectedIndex;
            NzGroupKala.Refetch();

            NsGridFavorites.RootTable.Columns[nameof(NzObject.nerkh_frosh)].DataMember =
	            NzKind.SelectedIndex == 0
		            ? nameof(NzObject.nerkh_frosh)
		            : nameof(NzObject.nerkh_frosh) + NzKind.SelectedIndex;
            NsGridFavorites.Refetch();

		}
		private void NsCopyBarcode_Click                (object sender, EventArgs e)
		{
            nzBarcodeReader1.Text = NzBarcodePrice.Text;
            nzBarcodeReader1.Focus();
            SendKeys.Send("{ENTER}");
		}

		private void NzGroupKala_ColumnButtonClick      (object sender, ColumnActionEventArgs e)
		{
			var kala = NzGroupKala.CurrentRow.DataRow as NzObject;
			var item = _ListObjects.SingleOrDefault(x => x.ID== kala.ID);

			if(item!=null)
				AddObject(item);
		}

       
    }
}
