using MS_Control.TSDD;
using NZ.Xazane.Business;
using NZ.Xazane.Model;
using NZ.Xazane.Model.ViewModel;
using NZ.Xazane.WinForms.Base;
using ShareLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NZ.Xazane.WinForms.Component
{
	public partial class NsPeopleChequeList : MS_Base_GridPopup
	{
		#region Logging
		private static readonly log4net.ILog log =
			log4net
				.LogManager
				.GetLogger
					(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

		#endregion
		#region Fields
		private ReportManager _Manager;
		private IEnumerable<PeopleChequePayment> _ListChequePayment;
		private Enums.NzAccountKind _Kind;
		#endregion
		public NsPeopleChequeList()
		{
			InitializeComponent();
			ms_null.Visible = false;
			ms_Add.Visible = false;
			ms_refresh.Click += NzRefresh;
		}

		#region Property
		public Control Popup { get; set; }
		#endregion
		#region Methods
		 
		private void RefreshControl()
		{
			ms_grid.DataSource = _ListChequePayment.ToList();
		}
		public override void Refresh_Grid()
		{
			try
			{
				_Manager = new ReportManager();
				_ListChequePayment = _Manager.GetReport<PeopleChequePayment>(new
				{
					KindVaziat = Enums.NzChequeStateFlag.Nazd_Sanduq,
					KindDaryaft = Enums.NzPaymentOperatingKind.Daryaft
				},null);
				 
				RefreshControl();
			}
			catch (Exception ex)
			{
				log.Error(ex);
			}
		}

		public override void Filter_Grid(string Str)
		{
			Str = Str.Trim();
			if (string.IsNullOrWhiteSpace(Str))
			{
				RefreshControl();
				return;
			}
			ms_grid.DataSource = _ListChequePayment
										.Where(x => 
														x.CustomerTitle.Contains(Str)
													||  x.shomare_check?.Contains(Str) == true
													||	x.Shenase_Sayadi?.Contains(Str) == true
													||	x.babat?.Contains(Str) == true
													||	x.BankTitle?.Contains(Str) == true
												)
										.ToList();

		}
		public override void MS_Set_Select(object Item_to_Select)
		{
			_Selected_Item = Item_to_Select;

			if (_Selected_Item == null)
			{
				ms_grid.SelectedItems.Clear();
				_Selected_Item = null;
			}
			else if (Item_to_Select is PeopleChequePayment)
			{
				var Tag_Row = Item_to_Select as PeopleChequePayment;
				var row = ms_grid.GetDataRows()
											.FirstOrDefault
											(x => ((PeopleChequePayment)x.DataRow).ID == Tag_Row.ID);
				if (row != null)
				{
					ms_grid.MoveTo(row);
					_Selected_Item = row.DataRow;
				}
				else
					_Selected_Item = null;
			}
			else if (Item_to_Select is long)
			{
				var IDRow = (int)Item_to_Select;
				var row = _ListChequePayment.FirstOrDefault(x => x.ID == IDRow);
				_Selected_Item = row;
			}
		}
		#endregion

		private void NzRefresh(object sender, EventArgs eventArgs)
		{
			Refresh_Grid();
		}

	}
}
