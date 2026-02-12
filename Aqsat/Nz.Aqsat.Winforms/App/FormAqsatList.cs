using Janus.Windows.GridEX;
using MS_Control;
using MS_Control.Tarikh;
using Nz.Aqsat.Business;
using Nz.Aqsat.Model.Report; 
using ShareLib.Utils; 
using System;
using System.Collections.Generic; 
using System.Linq; 
using System.Windows.Forms;
using NZ.Aqsat.Business;
using Nz.Aqsat.Model.Models;
using Nz.Aqsat.Winforms.sms;
using NZ.General.WinForms.Sms;

namespace Nz.Aqsat.Winforms.App
{
    public partial class FormAqsatList : Form
    {
	    private ReportManager _Manager;
	    private bool _DoRefresh = true;

		public FormAqsatList()
        {
            InitializeComponent();
            _Manager = new ReportManager();
            this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
            SetCurrentMonth();
            ms_mah.SelectedTabChanged += NzFactorKinds_SelectedTabChanged;
            RefreshGrid();
		}
		#region Methods
		
		private void SetCurrentMonth				()
		{
			var mah = new MS_Structure_Shamsi(DateTime.Now)._Mah;
			ms_mah.SelectedIndex = 13 - mah;
		}
		private void RefreshGrid					()
		{
			var Month = 13 - ms_mah.SelectedIndex; 


			var list =
					_Manager.GetReport<AqsatList>(new
					{
						Year = SystemConstant.ActiveYear.Salmali,
						Month

					}, null);

				_DoRefresh = false;
				NzGridHeads.DataSource = list?.OrderByDescending(x=>x.Serial)?.ToList();
				_DoRefresh = true;

			if (NzItems.Checked)
				RefreshItem();

		
			//NzGridHeads.MoveFirst();
		}
		private void RefreshItem					()
		{
			if(!_DoRefresh)
				return;

			if (NzGridHeads.CurrentRow == null || NzGridHeads.CurrentRow.RowType != RowType.Record)
				return;

			var dataRow = NzGridHeads.CurrentRow.DataRow as AqsatList;

			var mgr = new AqsatManager();
			var aqsat = mgr.GetItem(dataRow.ID);

		 
			NzGridItems.DataSource = aqsat.AqsatRizs?.OrderBy(x=>x.Radif)?.ToList();
		}
		private void EditItem						()
		{
			if (NzGridHeads.CurrentRow.RowType != RowType.Record)
				return;
			var row = NzGridHeads.CurrentRow.DataRow as AqsatList;
			 
			new Form_Aqsat_Jadid(row.ID).ShowDialog(this);
				
			//var Spos = NzGridHeads.VerticalScrollPosition;
			var Rpos = NzGridHeads.CurrentRow.Position;

			RefreshGrid();

			NzGridHeads.MoveTo(Rpos);
			NzGridHeads.EnsureVisible(Rpos);
			//NzGridHeads.VerticalScrollPosition = Spos;

		}

		#endregion
		private void NzFactorKinds_SelectedTabChanged(object sender, Janus.Windows.UI.Tab.TabEventArgs e)
		{
			RefreshGrid();
		}

		private void NsPrint_Click					(object sender, EventArgs e)
        {
	        List<long> ListIDs;

	        if (NzGridHeads.GetCheckedRows().Any())
	        {
		        ListIDs = NzGridHeads
			        .GetCheckedRows()
			        .Select(x => (x.DataRow as AqsatList).ID)
			        .ToList();
	        }
	        else
	        {
		        if (NzGridHeads.CurrentRow.RowType != RowType.Record)
			        return;
		        var dataRow = NzGridHeads.CurrentRow.DataRow as AqsatList;

		        ListIDs = new List<long>() { dataRow.ID };
	        }

	        new Print.Print(ListIDs).Show(this);
		}
        private void NzItems_Click					(object sender, EventArgs e)
        {
	        Splitter1.Visible = NzItems.Checked;
	        mS_Panel2.Visible = NzItems.Checked;

	        if (NzItems.Checked)
		        RefreshItem();


        }
        private void NzRefreshList_Click			(object sender, EventArgs e)
        {
	        RefreshGrid();
        }
        private void NzAdd_Click					(object sender, EventArgs e)
        {
	        new Form_Aqsat_Jadid().ShowDialog(this);
	        RefreshGrid();
        }

		private void NzGridHeads_SelectionChanged	(object sender, EventArgs e)
		{
			if (NzItems.Checked)
				RefreshItem();
		}
		private void NzGridHeads_ColumnButtonClick	(object sender, ColumnActionEventArgs e)
		{
			switch (e.Column.Key)
			{
				case "E":
					EditItem();
					break;
				case "D":
					try
					{
						var ResultDel = MS_Message.Show("آیـا بـرای حــذف ردیـف مـورد نـظر مـطـمئـنـیـد؟"
							, "تـوجـه"
							, ""
							, MessageBoxButtons.YesNo
							, MSMessage.FarsiMessageBoxIcon.سوال);

						if (ResultDel != DialogResult.Yes)
							return;

						var row = NzGridHeads.CurrentRow.DataRow as AqsatList;

						var mgr = new AqsatManager();
						var aqsat = mgr.GetItem(row.ID);

						if (aqsat.AqsatRizs.Any(x => x.isPardaxt))
						{
							ResultDel = MS_Message.Show("قسط مورد نظر دارای تعدادی پرداختی می باشد، مایل به حذف هستید؟"
								, "تـوجـه"
								, ""
								, MessageBoxButtons.YesNo
								, MSMessage.FarsiMessageBoxIcon.سوال);

							if (ResultDel != DialogResult.Yes)
								return;
						}
						mgr.Delete(row.ID);
						
						new Form_Notify
							(
								"تـوجـه",
								"حـذف ردیــف مـورد نـظر انـجـام شــد.",
								Form_Notify.FarsiMessageBoxIcon.چـک_باکس
							)
							.Popup(Form_Notify.Direction_Show.Down_To_Up, 500);


						var Spos = NzGridHeads.VerticalScrollPosition;
						var Rpos = NzGridHeads.CurrentRow.Position;

						RefreshGrid();

						if (Rpos > 0 && Rpos >= NzGridHeads.RowCount)
							Rpos--;

						NzGridHeads.MoveTo(Rpos);
						NzGridHeads.EnsureVisible(Rpos);
						NzGridHeads.VerticalScrollPosition = Spos;

					}
					catch (Exception ex)
					{
						MS_Message.Show("خطا در حذف فاکتور ", "خطا", ex.Message, MessageBoxButtons.OK);
					}
					break;
				case "P":
					
					break;
			}
		}
		private void NzGridHeads_RowDoubleClick		(object sender, RowActionEventArgs e)
		{
			EditItem();
		}

        private async void NzGridItems_ColumnButtonClick	(object sender, ColumnActionEventArgs e)
        {
	        var dataRow = NzGridItems.CurrentRow.DataRow as Aqsat_Riz;

			if (e.Column.Key == "R")
	        {
		        new Form_TasviehAqsat(dataRow.FK_Main, dataRow.ID).ShowDialog(this);

		        var Rpos = NzGridHeads.CurrentRow.Position;

				RefreshGrid();

				NzGridHeads.MoveTo(Rpos);
				NzGridHeads.EnsureVisible(Rpos);
			}
			else if (e.Column.Key == "S")
			{
				if(dataRow.isPardaxt)
					return;

				var cell = NzGridItems.CurrentRow.Cells["S"];
				var qest = NzGridHeads.CurrentRow.DataRow as AqsatList;

				var msg = new Messaging();

				await msg.SendSarResidQest(
					cell,
					Convert.ToInt64(qest.Mobile),
					qest.Shaxs ,
					dataRow.Radif.ToString(),
					qest.KindTitle,
					dataRow.PersianTarixQest,
					dataRow.mablaqQest.ToString("N")
				);
			}
		}
    }
}
