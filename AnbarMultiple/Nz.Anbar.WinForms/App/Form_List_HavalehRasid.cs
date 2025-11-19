using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using MS_Control;
using MS_Control.Tarikh;
using MS_Control.TSDD;
using Nz.Anbar.Model.Report;
using Nz.Anbar.Model.ViewModel;
using NZ.Anbar.Business;
using NZ.Anbar.Model;
using ShareLib;
using ShareLib.Utils;
using ShareLib.ViewModel;

namespace Nz.Anbar.WinForms.App
{
	public partial class Form_List_HavalehRasid : Form
	{
		#region Fields
		private ReportManager       _Manager;
		private Enums.NzFactorKind  _Kind;
		#endregion

		public Form_List_HavalehRasid()
		{
			InitializeComponent();
			_Manager                            = new ReportManager();
			this.Icon                           = global::MS_Resource.GlobalResources.Logo_Resaa;
			SetCurrentMonth();
			NzFactorKinds.SelectedTabChanged    += NzFactorKinds_SelectedTabChanged;
			ms_mah.SelectedTabChanged           += NzFactorKinds_SelectedTabChanged;
			Refresh_Anabrs();
			RefreshGrid();
			NzAnbars.SelectedIndexChanged       +=NzAnbarsChanged;
		}

		#region Methods
        private void Refresh_Anabrs                     ()
        {
	        var manager = new Manager();
            var _List       = manager.GetList<Storage>();

            NzAnbars.Items.AddRange(_List.ToArray());
            NzAnbars.SelectedIndex = 0;
        }
        private void SetLayout                          ()
        {
            switch (_Kind)
            {
                case Enums.NzFactorKind.EnteqalBeynAnbar:
	                if (NzGridHeads.CurrentLayout != NzGridHeads.Layouts["Entegal"])
	                {
		                NzGridHeads.LoadLayout(NzGridHeads.Layouts["Entegal"]);
		                NzGridItems.LoadLayout(NzGridItems.Layouts["Items"]);
		                NzGridHeads.CurrentLayout = NzGridHeads.Layouts["Entegal"];
	                } 
                    break;
                case Enums.NzFactorKind.HavaleXoruj:
                case Enums.NzFactorKind.ResidVorud: 
	                if (NzGridHeads.CurrentLayout != NzGridHeads.Layouts["Havale"])
	                {
		                NzGridHeads.LoadLayout(NzGridHeads.Layouts["Havale"]);
		                NzGridItems.LoadLayout(NzGridItems.Layouts["Items"]);
		                NzGridHeads.CurrentLayout = NzGridHeads.Layouts["Havale"];
	                } 
                  
                    break;
                case Enums.NzFactorKind.HavaleZayeat:
                case Enums.NzFactorKind.HavaleMasrafi:
	                if (NzGridHeads.CurrentLayout != NzGridHeads.Layouts["Transfer"])
	                {
		                NzGridHeads.LoadLayout(NzGridHeads.Layouts["Transfer"]);
		                NzGridItems.LoadLayout(NzGridItems.Layouts["TransferItems"]);
		                NzGridHeads.CurrentLayout = NzGridHeads.Layouts["Transfer"];
	                } 
                    break;
            }
        }
        private void SetCurrentMonth                    ()
        {
            var mah                 = new MS_Structure_Shamsi(DateTime.Now)._Mah;
            ms_mah.SelectedIndex    = 13 - mah;
            NzFactorKinds.SelectedTab = NzZayeat;
        }
        private void SetFactorKind                      ()
        {
            if (NzFactorKinds.SelectedTab == NzZayeat)
                _Kind = Enums.NzFactorKind.HavaleZayeat;
            else if (NzFactorKinds.SelectedTab == NzMasraf)
                _Kind = Enums.NzFactorKind.HavaleMasrafi;
            else if (NzFactorKinds.SelectedTab == NzResid)
                _Kind = Enums.NzFactorKind.ResidVorud;
            else if (NzFactorKinds.SelectedTab == NzNaqlVaEnteqal)
                _Kind = Enums.NzFactorKind.EnteqalBeynAnbar;
            else if(NzFactorKinds.SelectedTab == NzHavaleh)
                _Kind = Enums.NzFactorKind.HavaleXoruj;
        }
        private void RefreshGrid                        ()
        {
            SetFactorKind();
            var Month = 13 - ms_mah.SelectedIndex;
            SetLayout();
            var Anbar = (NzAnbars.SelectedItem as Storage).ID;
                
            var list =
                    _Manager.GetReport<TransferFactor>(new
                    {
                        Year = SystemConstant.ActiveYear.Salmali,
                        Kind = (byte)_Kind,
                        Anbar ,
                        Month

                    }, null);

            NzGridHeads.DataSource = list?.ToList();

            if(NzItems.Checked)
                RefreshItem();

            NzGridHeads.MoveFirst();
        }
        private void RefreshItem                        ()
        {
            if(NzGridHeads.CurrentRow==null || NzGridHeads.CurrentRow.RowType!=RowType.Record)
                return;
            var ID = NzGridHeads.CurrentRow.Cells["ID"].Value;
            var list =
                _Manager.GetReport<FactorItem>(new
                {
                    ID
                }, null);

            NzGridItems.DataSource = list?.ToList();
            if (list != null && list.Count() > 20)
                NzGridItems.FilterMode = FilterMode.Automatic;
            else
                NzGridItems.FilterMode = FilterMode.None;

            var detail = _Manager.GetItem<FactorDetails>(new { ID },null);

            if (detail != null)
            {
	            NsTarikhCreate.Text = detail.tarikh_add.ToPersianDate();
	            NsTarikhEdit.Text   = detail.tarikh_edit?.ToPersianDate();
	            NsUserCreate.Text   = detail.UserCreate;
	            NsUserEdit.Text     = detail.UserEdit;
            }

        }
        private void EditFactor                         ()
        {
            if(NzGridHeads.CurrentRow.RowType!=RowType.Record)
                return;
            var ID =Convert.ToInt64( NzGridHeads.CurrentRow.Cells["ID"].Value);

            if (NzFactorKinds.SelectedTab == NzHavaleh || NzFactorKinds.SelectedTab == NzResid)
                new Form_Havale_Resid(ID).ShowDialog(this);
            else if(NzFactorKinds.SelectedTab == NzNaqlVaEnteqal)
                new Form_Naql_Enteqal(Convert.ToInt64(ID)).ShowDialog(this);
            else
                new Form_Transfer(Convert.ToInt64(ID),_Kind).ShowDialog(this);

            var Spos = NzGridHeads.VerticalScrollPosition;
            var Rpos = NzGridHeads.CurrentRow.Position;

            RefreshGrid();

            NzGridHeads.MoveTo(Rpos);
            NzGridHeads.EnsureVisible(Rpos);
            NzGridHeads.VerticalScrollPosition = Spos;
        }
        private void PrintTransform                     ()
        {
            List<long> ListIDs;

            if (NzGridHeads.GetCheckedRows().Any())
            {
                ListIDs = NzGridHeads
                    .GetCheckedRows()
                    .Select(x =>
                        Convert.ToInt64(x.Cells["ID"].Value)
                    )
                    .ToList();
            }
            else
            {
                if (NzGridHeads.CurrentRow.RowType != RowType.Record)
                    return;
                var ID = Convert.ToInt64(NzGridHeads.CurrentRow.Cells["ID"].Value);

                ListIDs = new List<long>() { ID };
            }
            new Print.PrintTransfers( ListIDs, _Kind).Show(this);

        }
        #endregion
        private void NzAnbarsChanged                    (object sender, EventArgs e)
        {
	        RefreshGrid();
        }
        private void NzFactorKinds_SelectedTabChanged   (object sender, Janus.Windows.UI.Tab.TabEventArgs e)
        {
            RefreshGrid();
        }
        private void NzItems_Click                      (object sender, EventArgs e)
        {
            Splitter1.Visible   = NzItems.Checked;
            mS_Panel2.Visible   = NzItems.Checked;

            if (NzItems.Checked)
                RefreshItem();
        }

        private void NzGridHeads_SelectionChanged       (object sender, EventArgs e)
        {
            if(NzItems.Checked)
                RefreshItem();
        }
        private void NzGridHeads_ColumnButtonClick      (object sender, ColumnActionEventArgs e)
        {
            switch (e.Column.Key)
            {
                case "E":
                    EditFactor();
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

                        var Payment = false;

                        if (NzGridHeads.CurrentRow.DataRow is GeneralFactor row)
                        {
                            if ((_Kind == Enums.NzFactorKind.Xarid
                                 || _Kind == Enums.NzFactorKind.BargashXarid
                                 || _Kind == Enums.NzFactorKind.Frosh
                                 || _Kind == Enums.NzFactorKind.BargshtFrosh
                                )
                                &&
                                (row.Cache > 0 || row.Cheque > 0 || row.Pos > 0)
                            )
                            {
                                var r = MS_Message.Show(
                                    "فاکتور مورد نظر دارای تعدادی وجوه تسویه می باشد" +
                                    "\n آیا مایلید که به همراه فاکتور آنهـا نیز حذف شوند؟",
                                    "حذف وجوه تسویه",
                                    MessageBoxButtons.YesNo, 
                                    MSMessage.FarsiMessageBoxIcon.سوال);

                                Payment = r == DialogResult.Yes;
                            }

                        }

                        var ID  = NzGridHeads.CurrentRow.Cells["ID"].Value;
                        IEnumerable<FactorPaymentResolve> List = null;
                        var Mgr = new FactorManager();
                        var mgr = new ReportManager();

                        if (Payment)
                            List =  mgr.GetReport<FactorPaymentResolve>(new {ID = (long) ID}, null);

                        Mgr.Delete((long)ID);

                        if (Payment && List != null && List.Any())
                        {
                            var whereClause = string.Join(" OR ", List.Select(x => "ID =" + x.ID));
                            mgr.GetItem<FactorPaymentsDelete>(null, whereClause);
                        }


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
                        MS_Message.Show("خطا در حذف فاکتور ","خطا",ex.Message,MessageBoxButtons.OK);
                    }
                    break;
            }
        }
        private void NzGridHeads_RowDoubleClick         (object sender, RowActionEventArgs e)
        {
            EditFactor();
        }

        private void NzPrintTransfer_ButtonClick        (object sender, EventArgs e)
        {
            NzPrintTransfer.ShowDropDown();
        }
        private void NzPrintTransferA5_Click            (object sender, EventArgs e)
        {
            PrintTransform();
        }

        private void NzRefreshList_Click                (object sender, EventArgs e)
        {
            RefreshGrid();
        }
        private void NzAdd_Click                        (object sender, EventArgs e)
        {
            Form frm = null;
            switch (_Kind)
            {
                case Enums.NzFactorKind.HavaleXoruj:
                case Enums.NzFactorKind.ResidVorud:
                    frm = new Form_Havale_Resid(0,_Kind);
                    break;
                case Enums.NzFactorKind.EnteqalBeynAnbar:
                    frm = new Form_Naql_Enteqal(0);
                    break;
                case Enums.NzFactorKind.HavaleZayeat:
                case Enums.NzFactorKind.HavaleMasrafi:
                    frm = new Form_Transfer(0,_Kind);
                    break;
            }
            frm?.ShowDialog(this);
            RefreshGrid();

        }

        private void mS_GridX_Setting2_MS_On_Print_Clicked(object sender, EventArgs e)
        {
            mS_GridX_Setting2.FillParametter(" لیست "+ _Kind.NzToString());
        }
        
        private void Form_ListFactors_KeyUp             (object sender, KeyEventArgs e)
        {
            if(e.Alt && e.Control && e.Shift && e.KeyCode==Keys.F12)
                ms_Save.Show();
        }
        private void Form_ListFactors_Shown             (object sender, EventArgs e)
        {
            //NzGridHeads.Focus();
            //NzGridHeads.MoveTo(NzGridHeads.FilterRow);
            //NzGridHeads.CurrentColumn = NzGridHeads.RootTable.Columns[5];
            
            //NzGridHeads.FilterRow.BeginEdit();
        }
	}
}
