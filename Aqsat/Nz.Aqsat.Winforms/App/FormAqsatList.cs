using Janus.Windows.GridEX;
using MS_Control;
using MS_Control.Tarikh;
using Nz.Aqsat.Business;
using Nz.Aqsat.Model.Report;
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
using NZ.Aqsat.Business;
using Nz.Aqsat.Model.Models;
using static ShareLib.Enums;

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
		
		private void SetCurrentMonth()
		{
			var mah = new MS_Structure_Shamsi(DateTime.Now)._Mah;
			ms_mah.SelectedIndex = 13 - mah;
		}
		private void RefreshGrid()
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

			NzGridHeads.MoveFirst();
		}
		private void RefreshItem()
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
		private void EditItem()
		{
			if (NzGridHeads.CurrentRow.RowType != RowType.Record)
				return;
			var row = NzGridHeads.CurrentRow.DataRow as AqsatList;
			 
			new Form_Aqsat_Jadid(row.ID).ShowDialog(this);
				
			var Spos = NzGridHeads.VerticalScrollPosition;
			var Rpos = NzGridHeads.CurrentRow.Position;

			RefreshGrid();

			NzGridHeads.MoveTo(Rpos);
			NzGridHeads.EnsureVisible(Rpos);
			NzGridHeads.VerticalScrollPosition = Spos;

		}
		private void PrintAqsat()
		{
			//List<long> ListIDs;

			//if (NzGridHeads.GetCheckedRows().Any())
			//{
			//	ListIDs = NzGridHeads
			//		.GetCheckedRows()
			//		.Select(x =>
			//			Convert.ToInt64(x.Cells["ID"].Value)
			//		)
			//		.ToList();
			//}
			//else
			//{
			//	if (NzGridHeads.CurrentRow.RowType != RowType.Record)
			//		return;
			//	var ID = Convert.ToInt64(NzGridHeads.CurrentRow.Cells["ID"].Value);

			//	ListIDs = new List<long>() { ID };
			//}

			//new Print.Print(null, ListIDs, PrintKind).Show(this);
		}


		#endregion
		private void NzFactorKinds_SelectedTabChanged(object sender, Janus.Windows.UI.Tab.TabEventArgs e)
		{
			RefreshGrid();
		}

		private void NsPrint_Click					(object sender, EventArgs e)
        {

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



        private void NzGridItems_ColumnButtonClick(object sender, ColumnActionEventArgs e)
        {
	        var dataRow = NzGridItems.CurrentRow.DataRow as Aqsat_Riz;

	        new Form_TasviehAqsat(dataRow.FK_Main,dataRow.ID).ShowDialog(this);

	        RefreshGrid();

        }
    }
}
