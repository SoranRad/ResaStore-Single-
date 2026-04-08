using Janus.Windows.GridEX;
using MS_Control;
using MS_Control.Tarikh;
using Nz.Anbar.Model.Report;
using Nz.Anbar.Model.Report.PishFrosh;
using Nz.Anbar.Model.ViewModel;
using NZ.Anbar.Business;
using NZ.Anbar.Model;
using ShareLib;
using ShareLib.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nz.Anbar.WinForms.App;
using static ShareLib.Enums;

namespace Nz.Anbar.WinForms.Report
{
    public partial class FormPurchaceAnalyze : Form
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
		private Enums.NzFactorKind _Kind;
		private bool _Do_Refresh = true;
		#endregion
		public FormPurchaceAnalyze()
        {
            InitializeComponent();
            this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
			_Manager = new ReportManager();
            Refresh_Anabrs();
            SetCurrentMonth();
			RefreshGrid();

        }

		#region Methods

		private void Refresh_Anabrs()
		{
			var manager = new Manager();
			var _List = manager.GetList<Storage>();

			NzAnbars.Items.AddRange(_List.ToArray());
			NzAnbars.SelectedIndex = 0;
		}
		private void SetCurrentMonth()
		{
			var mah = new MS_Structure_Shamsi(DateTime.Now)._Mah;
			ms_mah.SelectedIndex = 13 - mah;
			_Kind = NzFactorKind.Xarid;
		}
		private void RefreshGrid()
		{
			if(NzAnbars.SelectedItem == null)
				return;
			 
			var Month = 13 - ms_mah.SelectedIndex;
			var Anbar = (NzAnbars.SelectedItem as Storage).ID;

			 
			var list =
				_Manager.GetReport<GeneralFactor>(new
				{
					Year = SystemConstant.ActiveYear.Salmali,
					Kind = (byte)_Kind,
					Anbar,
					Month

				}, null);

			NzGridHeads.DataSource = list?.ToList();
			
			RefreshItem();

			NzGridHeads.MoveFirst();
		}
		private void RefreshItem()
		{
			if (!_Do_Refresh)
				return;

			if (NzGridHeads.CurrentRow == null || NzGridHeads.CurrentRow.RowType != RowType.Record)
				return;

			var data = NzGridHeads.CurrentRow.DataRow as GeneralFactor;

			var list =
				_Manager.GetReport<PurchaceAnalyze>(new
				{
					data.ID
				}, null);

			NzGridItems.DataSource = list?.OrderBy(x => x.radif)?.ToList();


			NzGridItems.FilterMode = NzGridItems.RowCount > 20
				? FilterMode.Automatic
				: FilterMode.None;
			 
		}
		private void EditFactor()
		{
			if (NzGridHeads.CurrentRow.RowType != RowType.Record)
				return;

			var ID = Convert.ToInt64(NzGridHeads.CurrentRow.Cells["ID"].Value);
			new Form_Purchase(Convert.ToInt64(ID), _Kind).ShowDialog(this);

		}
		#endregion

		#region Events

		private void NzAnbarsChanged					(object sender, EventArgs e)
		{
			RefreshGrid();
		}

		private void NzFactorKinds_SelectedTabChanged	(object sender, Janus.Windows.UI.Tab.TabEventArgs e)
		{
			_Do_Refresh = false;
			RefreshGrid();
			_Do_Refresh = true;
			RefreshItem();
		}
		private void NzGridHeads_SelectionChanged		(object sender, EventArgs e)
		{
			RefreshItem();
		}
		private void NzGridHeads_ColumnButtonClick		(object sender, ColumnActionEventArgs e)
		{
			 
			EditFactor();
					 
		}
		#endregion
	}
}
