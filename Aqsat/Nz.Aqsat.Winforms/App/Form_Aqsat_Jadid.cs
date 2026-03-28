using Janus.Windows.GridEX;
using MS_Control;
using MS_Control.Controls;
using MS_Control.MainForms;
using MS_Control.Tarikh;
using Nz.Aqsat.Model.Models;
using NZ.Aqsat.Business;
using ShareLib;
using ShareLib.Models;
using ShareLib.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Nz.Aqsat.Business;
using Nz.Aqsat.Model.Report;

namespace Nz.Aqsat.Winforms.App
{
    public partial class Form_Aqsat_Jadid : Form_Mother_IRANSans
	{
		private readonly long _id;

		#region Logging
		private static readonly log4net.ILog log =
			log4net
				.LogManager
				.GetLogger
					(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		#endregion
		#region Fields
		private bool	_DoRefresh = true;
        private string	_SimpleText = "";
        private string	_Dot = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
        private int		_Pos = 0;
        private int		_Len = 0;
        private int		_Serial;
        private bool	_IsEdit;
		private Aqsat_Main _Aqsat;
		private AqsatManager _Manager;
		private AqsatMainBinding _Bind;
		#endregion
		#region Constructor

		public Form_Aqsat_Jadid(long Id = 0)
        {
	        _id = Id;
	        _IsEdit = Id > 0;
	        InitializeComponent();
		}

        #endregion
        #region Methods
        private void Init									()
        {
            NsKind.RefreshKinds();
			NzCustomer.Refresh_Grid((byte)3, null);
			NsZamen.Refresh_Grid((byte)3, null);
			NsGridRizAdd.FilterMode = FilterMode.None;

			_Manager = new AqsatManager();

			if (_IsEdit)
				LoadAqsat();
			else
				Reset();
		}
        public bool ValidationDemoVersion()
        {
	        if (!SystemConstant.IsDemo)
		        return true;

	        var Mgr = new ReportManager();
	        var count = Mgr.GetItem<AqsatHeadCount>(new { }, null);

	        if (count.ItemsCount >= SystemConstant.DemoCount)
	        {
		        MS_Message.Show("نسخه برنامه شما آزمایشی می باشد لطفا آن را ارتقا دهید", "خطا", MessageBoxButtons.OK);
		        return false;
	        }

	        return true;
        }
		private void Reset									()
        {
	        _DoRefresh = false;
	        _IsEdit = false;

			_Aqsat = new Aqsat_Main();
	        GetMaxSerial();
	        NsGridRizAdd.DataSource		= null;
	        NzTarikh.MS_Tarikh			= new MS_Structure_Shamsi(DateTime.Now);
	        NsStartDate.MS_Tarikh		= new MS_Structure_Shamsi(DateTime.Now);
			NzCustomer.MS_Set_Select	(null);

			NsMablaqAqsat.Text			= 
			NsMablaqPishpardaxt.Text	= 
			NsMablaqMandeAqsat.Text		= 
			NsDarsadSud.Text			= 
			NsMablaqSoud.Text			= 
			NsMablaqFinalAqsat.Text		= 
			 "";

			NsZamen.MS_Set_Select		(null);
			NsSharh.Text				= "";

			NsGridRizAdd.DataSource = null;

			NsGridEdit.Hide();
			NsGridRizAdd.Show();
			panel1.Show();

			NzSerial.Focus();
	        _DoRefresh = true;
        }
		private void LoadAqsat								()
		{
			try
			{

				_Aqsat = _Manager.GetItem(_id);
				if (_Aqsat == null)
				{
					MS_Message.Show("برنامه قادر به خواندن اطلاعات اقساط نیست", "خطا",  MessageBoxButtons.OK);
					Reset();
					return;
				}

				_DoRefresh = false;

				NzSerial.MS_Decimal				= _Aqsat.Serial;
				NsStartDate.MS_Tarikh			= new MS_Structure_Shamsi(_Aqsat.StartDate);
				NzTarikh.MS_Tarikh				= new MS_Structure_Shamsi(_Aqsat.Tarikh);
				NsKind.SetValue					(_Aqsat.FK_Noh);
				NzCustomer.MS_Set_Select		(_Aqsat.FK_Shaxs);

				NsMablaqAqsat.MS_Decimal		= _Aqsat.MablaqAqsat;
				NsMablaqPishpardaxt.MS_Decimal	= _Aqsat.MablaqPishpardaxt;
				NsMablaqMandeAqsat.MS_Decimal	= _Aqsat.MablaqMandeAqsat;
				NsDarsadSud.MS_Decimal			= _Aqsat.DarsadSoud;
				NsMablaqSoud.MS_Decimal			= _Aqsat.MablaqSoud;
				NsMablaqFinalAqsat.MS_Decimal	= _Aqsat.MablaqFinalAqsat;


				NsDoreQest.MS_Decimal			= _Aqsat.DoreQest;
				NsStartDate.MS_Tarikh			= new MS_Structure_Shamsi(_Aqsat.StartDate);
				NsTedadAqsat.MS_Decimal			= _Aqsat.TedadAqsat;
				NsRoundMablaq.MS_Decimal		= _Aqsat.RoundMablaq;


				NsZamen.MS_Set_Select			(_Aqsat.FK_Zamen);
				NsSharh.Text					= _Aqsat.Sharh?.Trim();
				_Bind = new AqsatMainBinding(_Aqsat);
				NsGridEdit.DataSource = _Bind;



				NsGridEdit.Show();
				NsGridRizAdd.Hide();
				//panel1.Hide();

				var AnyConfirmed = _Aqsat.AqsatRizs.Any(x => x.isPardaxt);
				NsDoreQest.Enabled = !AnyConfirmed;
				NsStartDate.Enabled = !AnyConfirmed;
				NsTedadAqsat.Enabled = false;
				//NsRoundMablaq.Enabled = !AnyConfirmed;


				NzSerial.Focus();
				_DoRefresh = true;
			}
			catch (Exception ex)
			{
				log.Error(ex);
				MS_Message.Show("خطا در خواندن اطلاعات", "خطا", ex.Message, MessageBoxButtons.OK);
				Reset();
			}
		}
		private bool IsOK									()
        {
			try
			{
				if (SystemConstant.ActiveYear.is_close)
				{
					MS_Message.Show("سال مالی بسته شده است " +
									"\n  نمی توانید ادامه دهید ");
					return false;
				}

				if (!ValidationDemoVersion())
					return false;

				if (NzSerial.MS_Decimal == 0)
				{
					NzSerial.Focus();
					mS_Notify1.Show(NzSerial);
					return false;
				}
				if (!NzTarikh.MS_Tarikh.HasValue)
				{
					NzTarikh.Focus();
					mS_Notify1.Show(NzTarikh);
					return false;
				}

				var date = NzTarikh.MS_Tarikh.Value.ToDatetime().Date;
				var salmali = SystemConstant.ActiveYear;
				if (date > salmali.EndDate || date < salmali.StartDate)
				{
					MS_Message.Show("تاریخ اقساط در محدوده سال مالی نیست" +
					                "\n\n" +
					                "از تاریخ " + new MS_Structure_Shamsi(salmali.StartDate).ToShamsi() +
					                " تا تاریخ " + new MS_Structure_Shamsi(salmali.StartDate).ToShamsi());
					NzTarikh.Focus();
					mS_Notify1.Show(NzTarikh);
					return false;
				}
				if (NzCustomer.MS_Get_Selected() == null)
				{
					NzCustomer.Focus();
					mS_Notify1.Show(NzCustomer);
					return false;
				}
				var Customer = NzCustomer.MS_Get_Selected() as People;
				if ((Customer.isBlock ?? false ) && _Aqsat.ID == 0)
				{
					MS_Message.Show("حساب مشتری بلوکه شده است");
					NzCustomer.Focus();
					mS_Notify1.Show(NzCustomer);
					return false;
				}

				if (NsKind.GetValue() == null)
				{
					NsKind.Focus();
					mS_Notify1.Show(NsKind);
					return false;
				}

				if (!_Aqsat.AqsatRizs.Any())
				{
					MS_Message.Show("یک یا چند قسط را وارد کنید.");
					NsTedadAqsat.Focus();
					mS_Notify1.Show(NsTedadAqsat);
					return false;
				}

				if ((_Aqsat.ID == 0 &&  _Serial != NzSerial.MS_Decimal)
				    || (_Aqsat.ID > 0 && _Aqsat.Serial != NzSerial.MS_Decimal))
				{
					var r = _Manager.IsCodeUnique(new
					{
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

				if (NsMablaqAqsat.MS_Decimal <= 0)
				{
					NsMablaqAqsat.Focus();
					mS_Notify1.Show(NsMablaqAqsat);
					return false;
				}

				if (NsDoreQest.MS_Decimal <= 0)
				{
					NsDoreQest.Focus();
					mS_Notify1.Show(NsDoreQest);
					return false;
				}

				if (!NsStartDate.MS_Tarikh.HasValue)
				{
					NsStartDate.Focus();
					mS_Notify1.Show(NsStartDate);
					return false;
				}
				if (NsTedadAqsat.MS_Decimal <= 0)
				{
					NsTedadAqsat.Focus();
					mS_Notify1.Show(NsTedadAqsat);
					return false;
				}
			}
			catch (Exception ex )
			{
				log.Error(ex);
				MS_Message.Show("خطا در برنامه", "", ex.Message, MessageBoxButtons.OK);
				return false;
			}

			return true;
		}
        private void Save									()
        {
			try
			{
				RemoveUnSavedRow();

				if (!IsOK())
					return;



				if (_Aqsat.ID == 0)
					_Aqsat.FK_Salmali = SystemConstant.ActiveYear.Salmali;

				_Aqsat.Serial					= Convert.ToInt32(NzSerial.MS_Decimal);
				_Aqsat.FK_Shaxs					= (NzCustomer.MS_Get_Selected() as People).ID;
				_Aqsat.Tarikh					= NzTarikh.MS_Tarikh.Value.ToDatetime().Date;
				_Aqsat.FK_Noh					= (NsKind.SelectedValue as Aqsat_Kind).ID;

				_Aqsat.MablaqAqsat				= NsMablaqAqsat.MS_Decimal;
				_Aqsat.MablaqPishpardaxt		= NsMablaqPishpardaxt.MS_Decimal;
				_Aqsat.MablaqMandeAqsat			= NsMablaqMandeAqsat.MS_Decimal;
				_Aqsat.DarsadSoud				= NsDarsadSud.MS_Decimal;
				_Aqsat.MablaqSoud				= NsMablaqSoud.MS_Decimal;
				_Aqsat.MablaqFinalAqsat			= NsMablaqFinalAqsat.MS_Decimal;

				_Aqsat.TedadAqsat = (byte)NsTedadAqsat.MS_Decimal;

				var zamen						= NsZamen.MS_Get_Selected() as People;
				_Aqsat.FK_Zamen					= zamen?.ID;
				_Aqsat.Sharh					= NsSharh.Text;

				if (!_IsEdit)
				{
					_Aqsat.DoreQest				= Convert.ToByte( NsDoreQest.MS_Decimal);
					_Aqsat.StartDate			= NsStartDate.MS_Tarikh.Value.ToDatetime().Date;
					_Aqsat.RoundMablaq			= (byte)NsRoundMablaq.MS_Decimal;
				}
				
				RemoveUnSavedRow();

				bool autoSerial = false;

				if (_IsEdit)
					autoSerial = false;
				else
					autoSerial = _Serial == NzSerial.MS_Decimal;

				_Manager.Save(_Aqsat, autoSerial);
				new Form_Notify("ذخـیـره سـازی", "اطـلاعـات بـا مـوفـقـیـت ثـبـت شـــد.",
						Form_Notify.FarsiMessageBoxIcon.اضافه)
					.Popup(Form_Notify.Direction_Show.Right_To_Left, 1000);
				SetItemsNoChanges();
				if (_IsEdit)
				{
					SetItemsNoChanges();
				}
				else
				{

					var result = new FormAqsatSaveResult().ShowDialog(this);
					if (result == DialogResult.Retry)
					{
						NsPrint.PerformClick();
						NzNew.PerformClick();
					} else if (result == DialogResult.Yes)
					{
						NzNew.PerformClick();
					}
					else if(result == DialogResult.No)
					{
						NsPrint.PerformClick();
					}
					else if (result == DialogResult.Cancel)
					{
						this.Close();
					}
					else
					{
						this.Close();
					}
				}
			}
			catch (Exception ex)
			{
				log.Error(ex);
				MS_Message.Show("خطا در برنامه", "", ex.Message, MessageBoxButtons.OK);
			}
		}
		private void RefreshAmounts							()
        {
	        NsMablaqMandeAqsat.MS_Decimal = NsMablaqAqsat.MS_Decimal - NsMablaqPishpardaxt.MS_Decimal;
	        if (NsDarsadSud.MS_Decimal > 0)
                NsMablaqSoud.MS_Decimal = decimal.Round((NsMablaqAqsat.MS_Decimal * NsDarsadSud.MS_Decimal) / 100,MidpointRounding.AwayFromZero);

	        NsMablaqFinalAqsat.MS_Decimal = NsMablaqMandeAqsat.MS_Decimal + NsMablaqSoud.MS_Decimal;
            RefreshItems();
        }
        private void RefreshItems							()
        {
	        try
	        {
				if(_IsEdit)
					RefreshItemsEdit();
				else
					RefreshItemsAdd();
	        }
	        catch (Exception ex)
	        {
				MS_Message.Show("خطا در برنامه", "", ex.Message, MessageBoxButtons.OK);
				log.Error(ex);
	        }

	        
        }
        private void RefreshItemsAdd						()
        {
	        ClearItems();

	        if (NsTedadAqsat.MS_Decimal > 0 && NsStartDate.MS_Tarikh.HasValue)
	        {
		        var startDate		= NsStartDate.MS_Tarikh.Value.ToDatetime().Date;
		        var mablaqQest		= decimal.Round(NsMablaqFinalAqsat.MS_Decimal / NsTedadAqsat.MS_Decimal);
		        var pCalendar		= new PersianCalendar();
		        var roz				= NsStartDate.MS_Tarikh.Value._Roz;
				if (NsRoundMablaq.MS_Decimal > 0)
		        {
			        mablaqQest -= (mablaqQest % ((decimal)Math.Pow(10, (double)NsRoundMablaq.MS_Decimal)));
		        }

		        for (int i = 0; i < NsTedadAqsat.MS_Decimal; i++)
		        {
			        DateTime tarix;
			        if (NsDoreQest.MS_Decimal == 30)
			        {
				        var start	= new MS_Structure_Shamsi( startDate).AddMonths(i);

				        if (NsLastDay.Visible && NsLastDay.Checked)
				        {
					        if (pCalendar.IsLeapYear(start._Sal))
						        tarix = new MS_Structure_Shamsi(start._Sal, start._Mah, 30).ToDatetime().Date;
					        else
					        {
						        tarix = start._Mah == 12
							        ? new MS_Structure_Shamsi(start._Sal, start._Mah, 29).ToDatetime().Date
							        : new MS_Structure_Shamsi(start._Sal, start._Mah, 30).ToDatetime().Date;
							}
				        }
						else if (roz == 30 && start._Mah == 12)
				        {
					       
						    tarix = pCalendar.IsLeapYear(start._Sal)
							    ? new MS_Structure_Shamsi(start._Sal, start._Mah, roz).ToDatetime().Date
							    : new MS_Structure_Shamsi(start._Sal, start._Mah, 29).ToDatetime().Date;
				        }
						else
							tarix = new MS_Structure_Shamsi(start._Sal, start._Mah , roz).ToDatetime().Date;
					}
					else
			        {
				        tarix = startDate.AddDays(i  * (double)NsDoreQest.MS_Decimal);
					}

						
			        var persianTarix	= tarix.ToPersianDate();
			        _Aqsat.AqsatRizs.Add(new Aqsat_Riz()
			        {
				        Radif = (byte)(i + 1),
				        tarixQest = tarix,
				        PersianTarixQest = persianTarix,
				        mablaqQest = mablaqQest,
						AqsatMain = _Aqsat
			        });
		        }

		        var sum = _Aqsat.AqsatRizs.Sum(x => x.mablaqQest);

		        if (sum != NsMablaqFinalAqsat.MS_Decimal)
		        {
			        var mande = NsMablaqFinalAqsat.MS_Decimal - sum;

			        var riz = NsRoundFirst.Checked
				        ? _Aqsat.AqsatRizs.FirstOrDefault()
				        : _Aqsat.AqsatRizs.LastOrDefault();

			        if (riz != null)
				        riz.mablaqQest += mande;
		        }

		        NsGridRizAdd.DataSource = new AqsatMainBinding(_Aqsat); //_Aqsat.AqsatRizs.ToList();
			}
		}
        private void RefreshItemsEdit						()
        {
	        var startDate = NsStartDate.MS_Tarikh.Value.ToDatetime().Date;
			var tedadAqsat = _Aqsat.AqsatRizs.Count(x=>!x.isPardaxt && x.State != Enums.NzItemState.Deleted);
	        var mablaqQest = decimal.Round(NsMablaqFinalAqsat.MS_Decimal / tedadAqsat);
	        var IsConfirmed = _Aqsat.AqsatRizs.Any(x => x.isPardaxt);

	        if (NsRoundMablaq.MS_Decimal > 0)
		        mablaqQest -= (mablaqQest % ((decimal)Math.Pow(10, (double)NsRoundMablaq.MS_Decimal)));


	        int i=0;
	        foreach (var riz in _Aqsat.AqsatRizs.Where(x => !x.isPardaxt && x.State != Enums.NzItemState.Deleted))
	        {
		        if (riz.mablaqQest != mablaqQest)
		        {
			        riz.mablaqQest = mablaqQest;
			        riz.State = Enums.NzItemState.Modified;
				}

		        if (!IsConfirmed)
		        {
					DateTime tarix;
					if (NsDoreQest.MS_Decimal == 30)
					{
						var start = new MS_Structure_Shamsi(startDate.AddMonths(i ));
						tarix = new MS_Structure_Shamsi(start._Sal, start._Mah, NsStartDate.MS_Tarikh.Value._Roz).ToDatetime().Date;

					}
					else
					{
						tarix = startDate.AddDays((i + 1) * (double)NsDoreQest.MS_Decimal);
					}

					var persianTarix = tarix.ToPersianDate();
			        riz.tarixQest = tarix;
			        riz.PersianTarixQest = persianTarix;
			        riz.State = Enums.NzItemState.Modified;

				}

				i++;
	        }

			var sum = _Aqsat.AqsatRizs.Where(x => x.State != Enums.NzItemState.Deleted).Sum(x => x.mablaqQest);

			if (sum != NsMablaqFinalAqsat.MS_Decimal)
			{
				var mande = NsMablaqFinalAqsat.MS_Decimal - sum;

				var riz = NsRoundFirst.Checked
					? _Aqsat.AqsatRizs.FirstOrDefault(x=>!x.isPardaxt && x.State != Enums.NzItemState.Deleted)
					: _Aqsat.AqsatRizs.LastOrDefault(x => !x.isPardaxt && x.State != Enums.NzItemState.Deleted);

				if (riz != null)
				{
					riz.mablaqQest += mande;
					riz.State = Enums.NzItemState.Modified;
				}
			}

			NsGridEdit.Refetch();
		}
		private void ClearItems								()
        {
            _Aqsat.AqsatRizs.Clear();
        }
        private void SetItemsNoChanges						()
        {
	        try
	        {
		        _Aqsat.AqsatRizs.MSZ_ForEach(x =>
		        {
			        x.State = Enums.NzItemState.NotChanged;
		        });
	        }
	        catch (Exception ex)
	        {
		        log.Error(ex);
	        }
        }
		private void RefreshMablaqFinal						()
        {
	        NsMablaqFinalAqsat.MS_Decimal = _Aqsat.AqsatRizs.Where(x=>x.State!=Enums.NzItemState.Deleted).Sum(x => x.mablaqQest);
        }
        private void RemoveUnSavedRow						()
        {
	        try
	        {
		        _Aqsat
			        .AqsatRizs
			        .Where(x => x.tarixQest == DateTime.MinValue || x.mablaqQest== 0 || x.Radif == 0 )
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
        private void GetMaxSerial							()
        {
	        _Serial = _Manager.GetMaxSerial(null) + 1;

	        NzSerial.MS_Decimal = _Serial;
        }
        private void RefreshTedadAqsat						()
        {
	        _DoRefresh = false;
	        NsTedadAqsat.MS_Decimal = _Bind.Count;
	        _DoRefresh = true;
        }
        #endregion
		private void Form_Aqsat_Jadid_Load					(object sender, EventArgs e) 
		{
			Init();
		}
		private void NsMablaqAqsat_TextChanged				(object sender, EventArgs e)
        {
            if(!_DoRefresh)
                return;
            _DoRefresh = false;

            RefreshAmounts();

            _DoRefresh = true;
		}
        private void NsMablaqSoud_TextChanged				(object sender, EventArgs e)
        {
            if(!_DoRefresh) return;

            _DoRefresh = false;

            NsDarsadSud.MS_Decimal = 0;

            RefreshAmounts();

            _DoRefresh = true;
		}
        private void NzCustomer_MS_On_Row_Selected			(object sender, MS_Control.TSDD.On_Selected e)
        {

        }
        private void NsZamen_MS_On_Row_Selected				(object sender, MS_Control.TSDD.On_Selected e)
        {

        }
        private void NsRoundMablaq_TextChanged				(object sender, EventArgs e)
        {
			if(!_DoRefresh) 
				return;

            RefreshItems();
        }
        private void NsIsOffPercent_CheckedChanged			(object sender, EventArgs e)
        {
	        if (!_DoRefresh) 
		        return;

			RefreshItems();
		}
        private void NsStartDate_TextChanged				(object sender, EventArgs e)
        {
	        if (!_DoRefresh)
		        return;

	        if (NsStartDate.MS_Tarikh.HasValue)
	        {
		        RefreshItems();
		        var jm = new PersianCalendar();

		        if (
			        !jm.IsLeapYear(NsStartDate.MS_Tarikh.Value._Sal) 
			        && NsStartDate.MS_Tarikh.Value._Mah == 12
				)
			        NsLastDay.Visible = true;
		        else
			        NsLastDay.Visible = false;
	        }
		}

		private void NzSave_Click							(object sender, EventArgs e)
        {
	        Save();
        }
        private void NzNew_Click							(object sender, EventArgs e)
        {
			Reset();
        }
        private void NsPrint_Click							(object sender, EventArgs e)
        {
	        if (_Aqsat.ID <= 0)
	        {
		        MS_Message.Show("");
		        return;
	        }

	        new Print.Print(new List<long>() { _Aqsat.ID }).Show(this);
        }

		private void NzDatePopup_NzCancelClicked			(object sender, EventArgs e)
        {
	        try
	        {
				//var Grid = NsGridRiz;


				//var Current = Grid.CurrentRow;

		  //      if (Current?.DataRow == null)
			 //       Current.BeginEdit();

		  //      if (Grid.CurrentRow?.DataRow is Aqsat_Riz row)
		  //      {
			 //       row.tarixQest = null;
			 //       row.PersianUsanceStr = string.Empty;

			 //       var cell = Grid.CurrentRow.Cells["PersianUsanceStr"];
			 //       cell.Value = null;
			 //       cell.Text = string.Empty;

			 //       Grid.CurrentColumn = _Kind == Enums.NzPaymentOperatingKind.Daryaft ?
				//        NzGridRecieve.RootTable.Columns["BankTitle"]
				//        : NzGridRecieve.RootTable.Columns["PayAccountTitle"];

			 //       NzDatePopup.Hide();

			 //       if (row.ID > 0)
				//        row.State = Enums.NzItemState.Modified;
		  //      }
	        }
	        catch (Exception ex)
	        {
		        log.Error(ex);
	        }
		}
        private void NzDatePopup_NzSelectObject				(object sender, EventArgs e)
        {
	        try
	        {
		        var Grid = _IsEdit ?NsGridEdit : NsGridRizAdd;

		        var current = Grid.CurrentRow;
		        if (current == null)
			        return;

		        if (current?.DataRow == null)
			        current.BeginEdit();

		        if (Grid.CurrentRow?.DataRow is Aqsat_Riz row)
		        {
			        row.tarixQest = NzDatePopup.NzSelected;
			        row.PersianTarixQest = NzDatePopup.NzPersinaDate;

			        var cell = Grid.CurrentRow.Cells[nameof(Aqsat_Riz.PersianTarixQest)];
			        cell.Value = NzDatePopup.NzPersinaDate;
			        cell.Text = NzDatePopup.NzPersinaDate;

			        Grid.CurrentColumn = Grid.RootTable.Columns[nameof(Aqsat_Riz.mablaqQest)];

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

		#region Grid New

		private void NsGridRiz_EditModeChanged				(object sender, EventArgs e)
		{
			try
			{
				var Grid = sender as MS_GridX;
				var Row = Grid.CurrentRow;
				var Col = Grid.CurrentColumn;

				if (Row == null)
					return;

				if (   Grid.EditMode	== EditMode.EditOn
				    && Grid.EditTextBox != null
				    && (Row.RowType		== RowType.Record || Row.RowType == RowType.NewRecord)
				    && Col				!= null
				    && Col.Key			== nameof(Aqsat_Riz.mablaqQest)
				   )
				{
					Grid.EditTextBox.KeyPress += EditTextBoxOnKeyPress;
					Grid.EditTextBox.TextChanged += EditTextBoxOnTextChanged;
				}
			}
			catch (Exception ex)
			{
				log.Error(ex);
			}
		}
		private void NsGridRiz_KeyPress						(object sender, KeyPressEventArgs e)
		{
			try
			{
				var Grid = sender as MS_GridX;

				if (Grid?.CurrentRow == null)
					return;

				if (e.KeyChar == (char)27)
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
		private void NsGridRiz_ColumnButtonClick			(object sender, ColumnActionEventArgs e)
		{
			try
			{
				if (!(sender is MS_GridX Grid))
					return;

				
				if (e.Column.Key == nameof(Aqsat_Riz.PersianTarixQest))
				{
					var Current = Grid.CurrentRow;

					if (Current == null)
						return;

					if (Current?.DataRow != null)
						Current.BeginEdit();

					var rec = Grid.GetCellBounds(Grid.CurrentRow.Position, Grid.RootTable.Columns[nameof(Aqsat_Riz.PersianTarixQest)]);

					if (Current?.DataRow is Aqsat_Riz riz)
						NzDatePopup.NzSelected = riz.tarixQest;

					NzDatePopup.Show(Grid, new Point(rec.X + rec.Width, rec.Y + rec.Height), ToolStripDropDownDirection.BelowLeft);

					SendKeys.Send("{TAB}");
				}

			}
			catch (Exception ex)
			{
				log.Error(ex);
			}
		}
		private void NsGridRiz_CellUpdated					(object sender, ColumnActionEventArgs e)
		{
			try
			{
				var Grid	= sender as MS_GridX;
				var row		= Grid?.CurrentRow?.DataRow as Aqsat_Riz;
				
				if (row == null)
					return;

				if (string.IsNullOrEmpty(row.PersianTarixQest))
					row.tarixQest = DateTime.Now.Date;

				if (
					e.Column.Key == nameof(Aqsat_Riz.PersianTarixQest) 
				    && !string.IsNullOrEmpty(row.PersianTarixQest)
					)
				{
					if (MS_Structure_Shamsi.Is_Tarikh_True(row.PersianTarixQest))
					{
						var tt = new MS_Structure_Shamsi(row.PersianTarixQest);
						row.tarixQest = tt.ToDatetime().Date;
					}
				}
				else if (e.Column.Key == nameof(Aqsat_Riz.mablaqQest))
				{
					_DoRefresh = false;
					RefreshMablaqFinal();
					_DoRefresh = true;
				}


				if (row?.ID > 0)
					row.State = Enums.NzItemState.Modified;

				
			}
			catch (Exception ex)
			{
				log.Error(ex);
			}
		}
		private void NsGridRiz_CancelingRowEdit				(object sender, RowActionCancelEventArgs e)
		{
			try
			{
				var Grid = sender as MS_GridX;

				if (Grid == null)
					return;
				
				Grid.CurrentRow?.CancelEdit();

				var Cur = e.Row;
				if (Cur != null && Cur.RowType == RowType.NewRecord)
				{
					var row = Cur.DataRow as Aqsat_Riz;
					if (row != null)
						_Bind.Remove(row);
				}
			}
			catch (Exception ex)
			{
				log.Error(ex);
			}
		}

		#endregion

		#region Edit

        private void NsGridEdit_ColumnButtonClick			(object sender, ColumnActionEventArgs e)
        {
	        var row		= NsGridEdit.CurrentRow;
	        var data	= row.DataRow as Aqsat_Riz;

			if(data == null)
				return;

			if (data.isPardaxt)
			{
				MS_Message.Show("کاربر گرامی؛ قسط مورد نظر شما پرداخت شده است. لذا نمی توانید آن را ویرایش یا خذف کنید.");
				return;
			}


			if (e.Column.Key == "E")
	        {
		        NsGridEdit.AllowEdit = InheritableBoolean.True;
		        NsGridEdit.RootTable.AllowEdit = InheritableBoolean.True;
		        NsGridEdit.CurrentColumn = NsGridEdit.RootTable.Columns[nameof(Aqsat_Riz.PersianTarixQest)];
				NsGridEdit.CurrentRow.BeginEdit();

			} else if (e.Column.Key == "D")
	        {

		        if (NsGridEdit.CurrentRow.RowType == RowType.NewRecord)
		        {
			        NsGridEdit.CancelCurrentEdit();
					NsGridEdit.CurrentRow.CancelEdit();
			        
					_DoRefresh = false;
			        RefreshMablaqFinal();
			        RefreshTedadAqsat();
					_DoRefresh = true;
			        return;
		        }
		         
		        if (data.ID > 0)
		        {
			        var result = MS_Message
				        .Show("آیا برای حذف ردیف مورد نظر مطمئنید؟",
					        "حذف ردیف",
					        MessageBoxButtons.YesNo);
			        if (result != DialogResult.Yes)
				        return;
		        }
		        NsGridEdit.CurrentRow?.Delete();

		        _DoRefresh = false;
				RefreshMablaqFinal();
				RefreshTedadAqsat();
				_DoRefresh = true;

			} else if (e.Column.Key == nameof(Aqsat_Riz.PersianTarixQest))
	        {
		        var rec =
			        NsGridEdit.CurrentRow == null ?
				        NsGridEdit.Bounds
				        : NsGridEdit
							.GetCellBounds(NsGridEdit.CurrentRow.Position, NsGridEdit.RootTable.Columns[nameof(Aqsat_Riz.PersianTarixQest)]);

		        if (NsGridEdit.CurrentRow?.DataRow is Aqsat_Riz riz)
			        NzDatePopup.NzSelected = riz.tarixQest;

		        NzDatePopup.Show(NsGridEdit,
			        new Point(rec.X + rec.Width, rec.Y + rec.Height),
			        ToolStripDropDownDirection.BelowLeft);

		        SendKeys.Send("{TAB}");
			}
        }
		private void NsGridEdit_UpdatingCell				(object sender, UpdatingCellEventArgs e)
        {
	        try
	        {
		        var grid = e.Column.GridEX;
		        if (!(grid.CurrentRow?.DataRow is Aqsat_Riz key))
			        return;

		        if (e.Column.Key == nameof(Aqsat_Riz.PersianTarixQest))
		        {
			        var persianDate = e.Value?.ToString();
			        if (!persianDate.IsPersianDate())
			        {
				        e.Cancel = true;
				        e.Value = e.InitialValue;
					}
		        }
				else if (e.Column.Key == nameof(Aqsat_Riz.mablaqQest))
				{
					var mablaq = Convert.ToDecimal(e.Value ?? 0);
					if (mablaq <= 0)
					{
						MS_Message.Show(
							"مبلغ قسط نباید صفر یا کمتر باشد",
							"هشدار",
							MessageBoxButtons.OK,
							MSMessage.FarsiMessageBoxIcon.اخطار
						);

						e.Cancel = true;
						e.Value = e.InitialValue;
							 
					}
				}
		        //if (key?.PersianTarixPardaxt?.IsPersianDate() == false || key?.mablaqQest == 0)
		        //{
			       // grid.CancelCurrentEdit();
			       // grid.CurrentRow.CancelEdit();
			       // e.Cancel = true;
			       // _Bind.Remove(key);

			       // _DoRefresh = false;
			       // RefreshMablaqFinal();
			       // _DoRefresh = true;
		        //}

	        }
	        catch (Exception ex)
	        {
		        log.Error(ex);
	        }
		}
		private void NsGridEdit_UpdatingRecord				(object sender, CancelEventArgs e)
		{
			try
			{
				var grid = sender as MS_GridX;
				if (!(grid.CurrentRow?.DataRow is Aqsat_Riz key))
					return;

				if (key?.PersianTarixPardaxt?.IsPersianDate() == false || key?.mablaqQest == 0)
				{
					grid.CancelCurrentEdit();
					grid.CurrentRow.CancelEdit();
					e.Cancel = true;
					_Bind.Remove(key);

					_DoRefresh = false;
					RefreshMablaqFinal();
					RefreshTedadAqsat();
					_DoRefresh = true;
				}

			}
			catch (Exception ex)
			{
				log.Error(ex);
			}
		}
		private void NsGridEdit_AddingRecord				(object sender, CancelEventArgs e)
        {
	        try
	        {
		        if (!(NsGridEdit.CurrentRow?.DataRow is Aqsat_Riz key))
			        return;

				if (key?.PersianTarixPardaxt?.IsPersianDate() == false || key?.mablaqQest == 0)
				{
					NsGridEdit.CancelCurrentEdit();
					NsGridEdit.CurrentRow.CancelEdit();
					e.Cancel = true;
					_Bind.Remove(key);
				}

	        }
	        catch (Exception ex)
	        {
		        log.Error(ex);
	        }
		}
		private void NsGridEdit_RecordAdded					(object sender, EventArgs e)
        {
	        _DoRefresh = false;
	        RefreshMablaqFinal	();
			RefreshTedadAqsat	();
	        _DoRefresh = true;
		}
		private void NsGridEdit_CellEdited					(object sender, ColumnActionEventArgs e)
        {
	        try
	        {
		        var grid = e.Column.GridEX;
		        if (grid.CurrentRow == null || e.Column.DataMember != nameof(Aqsat_Riz.mablaqQest))
			        return;

		        var data = grid.CurrentRow.DataRow as Aqsat_Riz;

		        if (data?.mablaqQest <= 0)
		        {
			        grid.Refresh();
					grid.CurrentColumn = e.Column;
			        MS_Message.Show("مبلغ قسط را وارد کنید. مقدار نباید صفر [ 0 ] باشد");
		        }
	        }
	        catch (Exception ex)
	        {
		        log.Error(ex);
	        }
		}
		private void NsGridEdit_GetNewRow					(object sender, GetNewRowEventArgs e)
        {
	        try
	        {
		        _Bind.RemoveTempRow();
	        }
	        catch (Exception exception)
	        {


	        }
		}
		private void NsGridEdit_RecordUpdated				(object sender, EventArgs e)
		{
			try
			{
				NsGridEdit.AllowEdit = InheritableBoolean.False;
				NsGridEdit.RootTable.AllowEdit = InheritableBoolean.False;
			}
			catch (Exception ex)
			{
				log.Error(ex);

			}
		}
		private void NsGridEdit_RowEditCanceled				(object sender, RowActionEventArgs e)
		{
			try
			{
				NsGridEdit.AllowEdit = InheritableBoolean.False;
				NsGridEdit.RootTable.AllowEdit = InheritableBoolean.False;
			}
			catch (Exception ex)
			{
				log.Error(ex);

			}
		}
		private void NsGridEdit_SelectionChanged			(object sender, EventArgs e)
		{
			try
			{
				NsGridEdit.AllowEdit = InheritableBoolean.False;
				NsGridEdit.RootTable.AllowEdit = InheritableBoolean.False;
			}
			catch (Exception ex)
			{
				log.Error(ex);

			}
		}
		#endregion

		#region TetxBox Events

		private void EditTextBoxOnKeyPress					(object sender, KeyPressEventArgs e)
		{
			char key = e.KeyChar;
			var textBox = sender as TextBox;

			if (textBox == null)
				return;

			if (!(char.IsDigit(key) || key == '\b' || key == '.' || key == '+' || key == '-'))
				e.Handled = true;
			if (key == '.' && textBox.Text.Contains("."))
				e.Handled = true;
			if (key == '+')
			{
				textBox.Text += @"000";
				e.Handled = true;
			}
			else if (key == '-')
			{
				textBox.Text += @"00";
				e.Handled = true;
			}
		}
		private void EditTextBoxOnTextChanged				(object sender, EventArgs eventArgs)
		{
			if (!_DoRefresh)
				return;
			_DoRefresh = false;

			var textBox = sender as TextBox;

			if (textBox == null)
				return;


			_SimpleText = textBox.Text.Replace(",", string.Empty);

			var start = _SimpleText.Contains(_Dot)
								? _SimpleText.IndexOf(_Dot) - 3
								: _SimpleText.Length - 3;

			for (int i = start; i > 0; i -= 3)
				_SimpleText = _SimpleText.Insert(i, ",");

			textBox.Text = _SimpleText;
			Set_Cursor_Location(textBox);

			_DoRefresh = true;
		}
		private void Set_Cursor_Location					(TextBox textBox)
		{
			int tm = textBox.Text.Length - _Len;

			int x = _Pos + tm;
			x = x < 0 ? 0 : x;
			if (tm > 0)// طول زیاد شده باشد
			{
				textBox.Select(_Pos + tm, 0);
			}
			else if (tm < 0) //  اگر طول کم شده باشد
			{
				var i = Math.Max(0, _Pos + tm);
				textBox.Select(i, 0);
			}
			else // طول 
			{
				textBox.Select(_Pos, 0);
			}
			
		}


        #endregion

       
    }
}
