using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using MS_Control;
using MS_Control.Tarikh;
using MS_Control.TSDD;
using Nz.Anbar.Model.ViewModel;
using NZ.Anbar.Business;
using NZ.Anbar.Model;
using Nz.Anbar.Model.Report;
using Nz.Anbar.Model.Report.PishFrosh;
using Nz.Anbar.WinForms.Provider;
using ShareLib;
using ShareLib.Utils;
using ShareLib.ViewModel;

namespace Nz.Anbar.WinForms.App
{
    public partial class Form_ListFactors : Form
    {
        #region Fields
        private ReportManager       _Manager;
        private Enums.NzFactorKind  _Kind;
        #endregion
        #region Constructor
        public      Form_ListFactors        ()
        {
            InitializeComponent();
            _Manager                            = new ReportManager();
            this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
            SetCurrentMonth();
            NzFactorKinds.SelectedTabChanged    += NzFactorKinds_SelectedTabChanged;
            ms_mah.SelectedTabChanged           += NzFactorKinds_SelectedTabChanged;
            Refresh_Anabrs();
            RefreshGrid();
            NzAnbars.SelectedIndexChanged       +=NzAnbarsChanged;
        }
        #endregion
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
                case Enums.NzFactorKind.PishFaktor:
	                if (NzGridHeads.CurrentLayout != NzGridHeads.Layouts["PreFactor"])
	                {
		                NzGridHeads.LoadLayout(NzGridHeads.Layouts["PreFactor"]);
		                NzGridItems.LoadLayout(NzGridItems.Layouts["Items"]);
		                NzGridHeads.CurrentLayout = NzGridHeads.Layouts["PreFactor"];
	                }
                    break;
                case Enums.NzFactorKind.Xarid:
                case Enums.NzFactorKind.BargshtFrosh:
                case Enums.NzFactorKind.Frosh:
                case Enums.NzFactorKind.BargashXarid:
	                if (NzGridHeads.CurrentLayout != NzGridHeads.Layouts["General"])
	                {
		                NzGridHeads.LoadLayout(NzGridHeads.Layouts["General"]);
		                NzGridItems.LoadLayout(NzGridItems.Layouts["Items"]);
		                NzGridHeads.CurrentLayout = NzGridHeads.Layouts["General"];

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

            NzPrintTransfer.Visible =   _Kind == Enums.NzFactorKind.HavaleZayeat 
                                    ||  _Kind == Enums.NzFactorKind.HavaleMasrafi;

            NzPrint.Visible         = !NzPrintTransfer.Visible;
            NzChangeToSale.Visible  = _Kind == Enums.NzFactorKind.PishFaktor || _Kind == Enums.NzFactorKind.Frosh;
        }
        private void SetCurrentMonth                    ()
        {
            var mah                 = new MS_Structure_Shamsi(DateTime.Now)._Mah;
            ms_mah.SelectedIndex    = 13 - mah;
            NzFactorKinds.SelectedTab = NzTabPurchase;
        }
        private void SetFactorKind                      ()
        {
            if (NzFactorKinds.SelectedTab == NzTabPurchase)
                _Kind = Enums.NzFactorKind.Xarid;
            else if (NzFactorKinds.SelectedTab == NzTabPurchaseBack)
                _Kind = Enums.NzFactorKind.BargashXarid;
            else if (NzFactorKinds.SelectedTab == NzTabSale)
                _Kind = Enums.NzFactorKind.Frosh;
            else if (NzFactorKinds.SelectedTab == NzTabSaleBack)
                _Kind = Enums.NzFactorKind.BargshtFrosh;
            else if(NzFactorKinds.SelectedTab == NzTabPreSale)
                _Kind = Enums.NzFactorKind.PishFaktor;
        }
        private void RefreshGrid                        ()
        {
            SetFactorKind();
            var Month = 13 - ms_mah.SelectedIndex;
            SetLayout();
            var Anbar = (NzAnbars.SelectedItem as Storage).ID;

            if (   _Kind == Enums.NzFactorKind.Xarid
                || _Kind == Enums.NzFactorKind.BargashXarid
                || _Kind == Enums.NzFactorKind.Frosh
                || _Kind == Enums.NzFactorKind.BargshtFrosh
            )
            {
                var list =
                    _Manager.GetReport<GeneralFactor>(new
                    {
                        Year = SystemConstant.ActiveYear.Salmali,
                        Kind = (byte) _Kind,
                        Anbar ,
                        Month

                    }, null);

                NzGridHeads.DataSource = list?.ToList();
            }
            else if (_Kind == Enums.NzFactorKind.PishFaktor)
            {
                var list= 
                    _Manager.GetReport<PreSaleFactor>(new
                    {
                        Year = SystemConstant.ActiveYear.Salmali,
                        Kind = (byte) _Kind,
                        Anbar ,
                        Month

                    }, null);
                NzGridHeads.DataSource = list?.ToList();
            }
            else // ضایعات و مصرف
            {
                var list =
                    _Manager.GetReport<TransferFactor>(new
                    {
                        Year = SystemConstant.ActiveYear.Salmali,
                        Kind = (byte)_Kind,
                        Anbar ,
                        Month

                    }, null);

                NzGridHeads.DataSource = list?.ToList();
            }

            if(NzItems.Checked)
                RefreshItem();

            NzGridHeads.MoveFirst();
        }
        private void RefreshItem                        ()
        {
            if(NzGridHeads.CurrentRow==null || NzGridHeads.CurrentRow.RowType!=RowType.Record)
                return;

            NzGridItems.CurrentLayout = NzGridItems.Layouts["Items"];

            var ID = NzGridHeads.CurrentRow.Cells["ID"].Value;
            var Anbar = (NzAnbars.SelectedItem as Storage).ID;

            if (_Kind == Enums.NzFactorKind.Frosh)
            {
	            var dataRow = NzGridHeads.CurrentRow.DataRow as GeneralFactor;
	            if (dataRow?.NoRemainEffect == true)
	            {
		            NzGridItems.CurrentLayout = NzGridItems.Layouts["PishFrosh"];

		            var Mgr = new ReportManager();
		            var List = Mgr
			            .GetReport<PishFoshFactor>
			            (new
			            {
				            Year = (short?)SystemConstant.ActiveYear.Salmali , 
				            Anbar,
				            Factor = ID
			            }, null);

		            NzGridItems.DataSource = List?.ToList().OrderBy(x=>x.radif)?.ToList();

	            }
	            else
	            {
		            var list =
			            _Manager.GetReport<FactorItem>(new
			            {
				            ID
			            }, null);

		            NzGridItems.DataSource = list?.OrderBy(x=>x.radif)?.ToList();
	            }

            }
            else
            {
	            var list =
		            _Manager.GetReport<FactorItem>(new
		            {
			            ID
		            }, null);

	            NzGridItems.DataSource = list?.OrderBy(x=>x.radif)?.ToList();
            }

           
            NzGridItems.FilterMode = NzGridItems.RowCount > 20 
	            ? FilterMode.Automatic 
	            : FilterMode.None;


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

            if (NzFactorKinds.SelectedTab == NzTabPreSale
                || NzFactorKinds.SelectedTab == NzTabPurchase
                || NzFactorKinds.SelectedTab == NzTabPurchaseBack
                || NzFactorKinds.SelectedTab == NzTabSale
            )
            {
                if (_Kind == Enums.NzFactorKind.Frosh)
                    new Form_SelectSaleFactor(ID).ShowDialog(this);
                else
                    new Form_Purchase(Convert.ToInt64(ID), _Kind).ShowDialog(this);
            }

            else if(NzFactorKinds.SelectedTab == NzTabSaleBack)

                new Form_SaleBack(Convert.ToInt64(ID),_Kind).ShowDialog(this);
            else
                new Form_Transfer(Convert.ToInt64(ID),_Kind).ShowDialog(this);

            var Spos = NzGridHeads.VerticalScrollPosition;
            var Rpos = NzGridHeads.CurrentRow.Position;

            RefreshGrid();

            NzGridHeads.MoveTo(Rpos);
            NzGridHeads.EnsureVisible(Rpos);
            NzGridHeads.VerticalScrollPosition = Spos;

        }
        private void PrintFactor                        (Enums.NzKindPrint PrintKind)
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
                if(NzGridHeads.CurrentRow.RowType!=RowType.Record)
                    return;
                var ID =Convert.ToInt64(NzGridHeads.CurrentRow.Cells["ID"].Value);

                ListIDs = new List<long>(){ID};
            }

            new Print.Print(null,ListIDs,PrintKind).Show(this);
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
        private void LoadPaymentList                    ()
        {
            var row = NzGridHeads.CurrentRow.DataRow as GeneralFactor;

            var kind        = Enums.FormOperation.FactorPaymentList;
            var Msg         = new FactorPaymentMessage()
            {
                Kind        = (byte)_Kind < 50
                    ? Enums.NzPaymentOperatingKind.Pardaxt
                    : Enums.NzPaymentOperatingKind.Daryaft,
                Description = "بابت تسویه فاکتور " + row.Serial,
                IDFactor    = row.ID,
                IDPeople    = row.FK_AshXas_ID??0,
                Amount      = row.mablaq,
            };

            var frm = Form_Factory._Form_Factory_Xazaneh.GetFormForEdit(kind,Msg);

            frm?.Set_Form_Param(Msg);
            (frm as Form)?.ShowDialog(this);

            var Spos = NzGridHeads.VerticalScrollPosition;
            var Rpos = NzGridHeads.CurrentRow.Position;

            RefreshGrid();

            NzGridHeads.MoveTo(Rpos);
            NzGridHeads.EnsureVisible(Rpos);
            NzGridHeads.VerticalScrollPosition = Spos;

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
            mS_Panel2.Visible = NzItems.Checked;

            if (NzItems.Checked)
                RefreshItem();
        }

        private void NzPrint_Click                      (object sender, EventArgs e)
        {
            NzPrint.ShowDropDown();
        }
        private void NzPrintA4_Click                    (object sender, EventArgs e)
        {
           PrintFactor(Enums.NzKindPrint.PaperA4);
        }
        private void NzPrintA5_Click                    (object sender, EventArgs e)
        {
            PrintFactor(Enums.NzKindPrint.PaperA5);

        }
        private void NzPosPrint_Click                   (object sender, EventArgs e)
        {
            PrintFactor(Enums.NzKindPrint.PosPrint);

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
                case "P":
                    LoadPaymentList(); 
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
                case Enums.NzFactorKind.AvalDore:
                    break;
                case Enums.NzFactorKind.BargshtFrosh:
                    frm = new Form_SaleBack(0, _Kind);
                break;
                case Enums.NzFactorKind.PishFaktor:
                case Enums.NzFactorKind.Xarid:
                case Enums.NzFactorKind.Frosh:
                case Enums.NzFactorKind.BargashXarid:
                    frm = new Form_Purchase(0,_Kind);
                    break;
                case Enums.NzFactorKind.HavaleZayeat:
                case Enums.NzFactorKind.HavaleMasrafi:
                    frm = new Form_Transfer(0,_Kind);
                    break;
            }
            frm.ShowDialog(this);
            RefreshGrid();

        }

        private void mS_GridX_Setting2_MS_On_Print_Clicked(object sender, EventArgs e)
        {
            mS_GridX_Setting2.FillParametter(" لیست "+ _Kind.NzToString());
        }
        private void NzChangeToSale_Click               (object sender, EventArgs e)
        {
            if(NzGridHeads.CurrentRow?.RowType!=RowType.Record)
                return;

			//var item = NzGridHeads.CurrentRow.DataRow as PreSaleFactor;

			long Id = Convert.ToInt64(NzGridHeads.CurrentRow.Cells["ID"].Value);

			var kind = _Kind == Enums.NzFactorKind.PishFaktor
	            ? Enums.NzFactorKind.Frosh
	            : Enums.NzFactorKind.PishFaktor;


			var r = new ConvertToFactor().Convert(Id, kind);

            if(r)
                new Form_Notify2("فاکتور با موفقیت ذخیره شد")
                    .Popup(Form_Notify2.Direction_Show.Right_To_Left,1500);
		}

		private void ms_Save_Click                      (object sender, EventArgs e)
        {
            var mgr = new FactorManager();
            
            //mgr.FixRemain();
            mgr.FixFifo();
        }
        private void uiTabPage14_KeyUp                  (object sender, KeyEventArgs e)
        {
            
        }
        
        private void Form_ListFactors_KeyUp             (object sender, KeyEventArgs e)
        {
            if(e.Alt && e.Control && e.Shift && e.KeyCode==Keys.F12)
                ms_Save.Show();
        }
        private void Form_ListFactors_Shown             (object sender, EventArgs e)
        {
        }

		private void NsCopy_Click                       (object sender, EventArgs e)
		{
			if(NzGridHeads.CurrentRow?.RowType!=RowType.Record)
				return;

			long Id = Convert.ToInt64( NzGridHeads.CurrentRow.Cells["ID"].Value);

			var frm = new FormCopyToYear();

			frm.IdFactor = Id;
			frm.ShowDialog(StorageProvider.MainForm);

			
		}
	}
}
