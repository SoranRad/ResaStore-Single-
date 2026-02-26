using Janus.Windows.GridEX;
using MS_Control;
using MS_Control.Tarikh;
using Nz.Anbar.Model.Report;
using Nz.Anbar.Model.ViewModel;
using NZ.Anbar.Business;
using ShareLib;
using ShareLib.Utils;
using ShareLib.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
		private Enums.NzFactorKind _Kind = NzFactorKind.Xarid;
		private bool _Do_Refresh = true;
		#endregion
		public FormPurchaceAnalyze()
        {
            InitializeComponent();
            this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
            _Manager = new ReportManager();
            SetCurrentMonth();

			ms_mah.SelectedTabChanged		+= NzFactorKinds_SelectedTabChanged;
			NzGridHeads.SelectionChanged	+= NzGridHeads_SelectionChanged;
			RefreshGridHead();

		}

		#region Fields
		private void SetCurrentMonth		()
		{
			var mah = new MS_Structure_Shamsi(DateTime.Now)._Mah;
			ms_mah.SelectedIndex = 13 - mah; 
		}
		private void RefreshGridHead		()
		{
			var Month = 13 - ms_mah.SelectedIndex;
		 
			var list =
				_Manager.GetReport<GeneralFactor>(new
				{
					Year = SystemConstant.ActiveYear.Salmali,
					Kind = (byte)_Kind,
					Month

				}, null);

			NzGridHeads.DataSource = list?.ToList();
			NzGridHeads.MoveFirst();
		}
		private void RefreshGridItems		()
		{
			try
			{
				if(!_Do_Refresh)
					return;

				if(NzGridHeads.CurrentRow==null)
					return;

				var factor = NzGridHeads.CurrentRow.DataRow as GeneralFactor;
				if (factor == null)
					return;

				var Mgr = new ReportManager();
				var List = Mgr
					.GetReport<PurchaceAnalyze>
					(new
					{
						factor.ID,

					}, null);

				NzGridItems.DataSource = List?.ToList();
			}
			catch (Exception ex)
			{
				log.Error(ex);
				MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
			}
		}
		private void LoadPaymentListHead	()
		{
			var row = NzGridHeads.CurrentRow.DataRow as GeneralFactor;

			var kind = Enums.FormOperation.FactorPaymentList;
			var Msg = new FactorPaymentMessage()
			{
				Kind = Enums.NzPaymentOperatingKind.Pardaxt,
				Description = "بابت تسویه فاکتور " + row.Serial,
				IDFactor = row.ID,
				IDPeople = row.FK_AshXas_ID ?? 0,
				Amount = row.mablaq,
			};

			var frm = Form_Factory._Form_Factory_Xazaneh.GetFormForEdit(kind, Msg);

			frm?.Set_Form_Param(Msg);
			(frm as Form)?.ShowDialog(this);

			var Spos = NzGridHeads.VerticalScrollPosition;
			var Rpos = NzGridHeads.CurrentRow.Position;

			_Do_Refresh = false;
			RefreshGridHead();
			_Do_Refresh = true;
			RefreshGridItems();

			NzGridHeads.MoveTo(Rpos);
			NzGridHeads.EnsureVisible(Rpos);
			NzGridHeads.VerticalScrollPosition = Spos;

		}
		private void LoadPaymentListRiz		()
		{
			var row = NzGridHeads.CurrentRow.DataRow as GeneralFactor;
			var riz = NzGridItems.CurrentRow.DataRow as PurchaceAnalyze;

			var kind = Enums.FormOperation.FactorPaymentList;
			var Msg = new FactorPaymentMessage()
			{
				Kind			=  Enums.NzPaymentOperatingKind.Pardaxt ,
				Description		= "بابت تسویه فاکتور " + row.Serial + " ردیف " + riz.radif +" "+ riz.ObjectTitle,
				IDFactorRiz		= riz.ID,
				IDFactor		= row.ID,
				IDPeople		= row.FK_AshXas_ID ?? 0,
				Amount			= row.mablaq,
			};

			var frm = Form_Factory._Form_Factory_Xazaneh.GetFormForEdit(kind, Msg);

			frm?.Set_Form_Param(Msg);
			(frm as Form)?.ShowDialog(this);

			var Spos = NzGridHeads.VerticalScrollPosition;
			var Rpos = NzGridHeads.CurrentRow.Position;

			_Do_Refresh = false;
			RefreshGridHead();
			_Do_Refresh = true;
			 

			NzGridHeads.MoveTo(Rpos);
			NzGridHeads.EnsureVisible(Rpos);
			NzGridHeads.VerticalScrollPosition = Spos;

			Spos = NzGridItems.VerticalScrollPosition;
			Rpos = NzGridItems.CurrentRow.Position;

			RefreshGridItems();

			NzGridItems.MoveTo(Rpos);
			NzGridItems.EnsureVisible(Rpos);
			NzGridItems.VerticalScrollPosition = Spos;

		}
		#endregion
		

		private void NzFactorKinds_SelectedTabChanged	(object sender, Janus.Windows.UI.Tab.TabEventArgs e)
		{
			_Do_Refresh = false;
			RefreshGridHead();
			_Do_Refresh = true;
			RefreshGridItems();

		}
		private void NzGridHeads_SelectionChanged		(object sender, EventArgs e)
		{
			RefreshGridItems();
		}

		private void NzGridHeads_ColumnButtonClick		(object sender, ColumnActionEventArgs e)
		{
			switch (e.Column.Key)
			{
				case "P":
					LoadPaymentListHead();
					break;
			}
		}
		private void ms_Grid_ColumnButtonClick			(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
		{
			switch (e.Column.Key)
			{
				case "E":
					var row = NzGridItems.CurrentRow.DataRow as PurchaceAnalyze;
					var frm = new FormCircularObject(row.FK_Kala);
					frm.MdiParent = this.MdiParent;
					frm.Show();
					break;
				case "P":
					LoadPaymentListRiz();
					break;
			}
			
		}
	}
}
