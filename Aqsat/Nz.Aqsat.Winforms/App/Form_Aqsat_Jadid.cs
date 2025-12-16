using Janus.Windows.GridEX;
using MS_Control;
using MS_Control.Controls;
using MS_Control.MainForms;
using MS_Control.Tarikh;
using Nz.Aqsat.Model.Models;
using NZ.Aqsat.Business;
using NZ.General.WinForms.Component;
using ShareLib;
using ShareLib.Models;
using ShareLib.Utils;
using Stimulsoft.Base.Excel;
using Stimulsoft.Database;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

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
	        InitializeComponent();
            _Aqsat = new Aqsat_Main();
		}

        #endregion
        #region Methods
        private void Init									()
        {
            NsKind.RefreshKinds();
			NzCustomer.Refresh_Grid((byte)3, null);
			NsZamen.Refresh_Grid((byte)3, null);
			NsGridRizAdd.FilterMode = FilterMode.None;
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

				if (NsKind.SelectedIndex < 0)
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


				var zamen						= NsZamen.MS_Get_Selected() as People;
				_Aqsat.FK_Zamen					= zamen?.ID;
				_Aqsat.Sharh					= NsSharh.Text;

				if (!_IsEdit)
				{
					_Aqsat.DoreQest				= Convert.ToByte( NsDoreQest.MS_Decimal);
					_Aqsat.StartDate			= NsStartDate.MS_Tarikh.Value.ToDatetime().Date;
					_Aqsat.TedadAqsat			= (byte)NsTedadAqsat.MS_Decimal;
					_Aqsat.RoundMablaq			= (byte)NsRoundMablaq.MS_Decimal;
				}
				else
				{
					//_Aqsat.TedadAqsat = 
				
				}

				_Manager.Save(_Aqsat,!_IsEdit);
				new Form_Notify("ذخـیـره سـازی", "اطـلاعـات بـا مـوفـقـیـت ثـبـت شـــد.",
						Form_Notify.FarsiMessageBoxIcon.اضافه)
					.Popup(Form_Notify.Direction_Show.Right_To_Left, 1000);

				if (_IsEdit)
				{
					SetItemsNoChanges();
				}
				else
				{

					var result = new FormAqsatSaveResult().ShowDialog(this);
					if (result == DialogResult.Retry)
					{

					} else if (result == DialogResult.Yes)
					{

					}
					else if(result == DialogResult.No)
					{
						
					}
					else if (result == DialogResult.Cancel)
					{

					}
					else
					{

					}
				}


				//if (ShowPopup)
				//	new Form_Notify("ذخـیـره سـازی", "اطـلاعـات بـا مـوفـقـیـت ثـبـت شـــد.",
				//			Form_Notify.FarsiMessageBoxIcon.اضافه)
				//		.Popup(Form_Notify.Direction_Show.Right_To_Left, 1000);

				//NzSerial.MS_Decimal = _Aqsat.Serial;
				//SetItemsNoChanges();

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
	        ClearItems();

	        if (NsTedadAqsat.MS_Decimal > 0 && NsStartDate.MS_Tarikh.HasValue)
	        {
		        var startDate   = NsStartDate.MS_Tarikh.Value.ToDatetime().Date;
                var mablaqQest  = decimal.Round(NsMablaqFinalAqsat.MS_Decimal/NsTedadAqsat.MS_Decimal);

                if (NsRoundMablaq.MS_Decimal > 0)
                {
	                mablaqQest -= (mablaqQest % ((decimal)Math.Pow(10, (double)NsRoundMablaq.MS_Decimal)));
                }

		        for (int i = 0; i < NsTedadAqsat.MS_Decimal; i++)
		        {
			        var tarix = startDate.AddDays((i+1)*(double)NsDoreQest.MS_Decimal);
			        var persianTarix = tarix.ToPersianDate();
					_Aqsat.AqsatRizs.Add(new Aqsat_Riz()
                    {
	                    Radif = (byte)(i + 1), 
	                    tarixQest = tarix,
						PersianTarixQest = persianTarix,
						mablaqQest = mablaqQest
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

				NsGridRizAdd.DataSource = _Aqsat.AqsatRizs.ToList();
	        }
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
	        NsMablaqFinalAqsat.MS_Decimal = _Aqsat.AqsatRizs.Sum(x => x.mablaqQest);
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
            RefreshItems();
        }
        private void NsIsOffPercent_CheckedChanged			(object sender, EventArgs e)
        {
	        RefreshItems();
		}

        private void NzSave_Click							(object sender, EventArgs e)
        {
	        if (!IsOK())
		        return;
	        Save();
        }
        private void NzNew_Click							(object sender, EventArgs e)
        {

        }
        private void NsPrint_Click							(object sender, EventArgs e)
        {

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
		        var Grid = NsGridRizAdd;

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

		#region Grid

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
				    && Row.RowType		== RowType.Record
				    && Col				!= null
				    && Col.Key			== nameof(Aqsat_Riz.mablaqQest)
				   )
				{
					Grid.EditTextBox.KeyPress += EditTextBoxOnKeyPress;

					if (Col.Key == nameof(Aqsat_Riz.mablaqQest))
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

					if (Current?.DataRow == null)
						Current.BeginEdit();

					var rec =
						Grid.CurrentRow == null ?
							Grid.Bounds
							: Grid
								.GetCellBounds(Grid.CurrentRow.Position, Grid.RootTable.Columns[nameof(Aqsat_Riz.PersianTarixQest)]);

					if (Current?.DataRow is Aqsat_Riz riz)
						NzDatePopup.NzSelected = riz.tarixQest;

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
		private void NsGridRiz_CellUpdated					(object sender, ColumnActionEventArgs e)
		{
			try
			{
				var Grid = sender as MS_GridX;

				var row = Grid?.CurrentRow?.DataRow as Aqsat_Riz;

				if (row == null)
					return;

				if (string.IsNullOrEmpty(row.PersianTarixQest))
					row.tarixQest = DateTime.Now.Date;

				if (e.Column.Key == nameof(Aqsat_Riz.PersianTarixQest) 
				    && !string.IsNullOrEmpty(row.PersianTarixQest))
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
			var Grid = NsGridRizAdd;

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
		private void EditTextBoxOnTextChanged				(object sender, EventArgs eventArgs)
		{
			if (!_DoRefresh)
				return;
			_DoRefresh = false;

			var Grid  = NsGridRizAdd;


			if (Grid.EditTextBox == null)
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
		private void Set_Cursor_Location					()
		{
			var Grid = NsGridRizAdd;

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

        
    }
}
