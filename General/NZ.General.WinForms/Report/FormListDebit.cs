using Janus.Windows.GridEX;
using MS_Control;
using NZ.General.Business;
using NZ.General.WinForms.Sms;
using ShareLib.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace NZ.General.WinForms.Report
{
    public partial class FormListDebit : Form
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		#endregion
		#region Fields
		private bool _CancelJob = false;
		#endregion
		#region Constructor
		public FormListDebit()
        {
            InitializeComponent();
            this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
            NzTabKind.SelectedTab = NzTabDebit;
        }
        #endregion

        #region Methods
        private void RefreshGrid    ()
        {
            try
            {
                var AzTarikh = NzDateFrom.MS_Tarikh?.ToDatetime();
                var TaTarikh = NzDateTo.MS_Tarikh?.ToDatetime();

                var List = new List<RemaindPeople>();
                Form_Factory
                    .SystemList
                    .MSZ_ForEach(x =>
                    {
                        var list = x.GetListRemaind(AzTarikh,TaTarikh);

                        if (list != null)
                            List.InsertRange(0, list);
                    });

                List = List.GroupBy(x => new
                {
                    x.ID          ,
                    x.FK_Group    ,
                    x.kind        ,
                    x.code        ,
                    x.Title       ,
                    x.namePedar   ,
                    x.codeMeli    ,
                    x.tel         ,
                    x.mobile      ,
                    x.GroupTitle  ,
                }).Select(x => new RemaindPeople
                {
                    ID          = x.Key.ID        ,
                    FK_Group    = x.Key.FK_Group  ,
                    kind        = x.Key.kind      ,
                    code        = x.Key.code      ,
                    Title       = x.Key.Title     ,
                    namePedar   = x.Key.namePedar ,
                    codeMeli    = x.Key.codeMeli  ,
                    tel         = x.Key.tel       ,
                    mobile      = x.Key.mobile    ,
                    GroupTitle  = x.Key.GroupTitle,
                    Balance     = x.Sum(y=> y.Balance ),

                }).ToList();

                if (NzTabKind.SelectedTab == NzTabDebit)
                    List = List.Where(x => x.Balance > 0).ToList();
                else if (NzTabKind.SelectedTab == NzTabCredit)
                    List = List.Where(x => x.Balance < 0).ToList();
                else
                    List = List.Where(x => x.Balance == 0).ToList();

                NzGrid.DataSource = List;
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);

            }
        }
        private void ShowDetail     ()
        {
            if(NzGrid.CurrentRow==null || NzGrid.CurrentRow.RowType != RowType.Record)
                return;

            var Row = NzGrid.CurrentRow.DataRow as RemaindPeople;

            var frm = new FormBill(Row.ID);
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
        #endregion

        private void NzTabKind_SelectedTabChanged   (object sender, Janus.Windows.UI.Tab.TabEventArgs e)
        {
            RefreshGrid();
            NzGrid.RootTable.Columns["sel"].Visible = NzGrid.RootTable.Columns["S"].Visible = NsMessage.Visible = NzTabKind.SelectedTab ==  NzTabDebit;
		}
        private void NzGrid_RowDoubleClick          (object sender, RowActionEventArgs e)
        {
            ShowDetail();
        }
        private async void NzGrid_ColumnButtonClick       (object sender, ColumnActionEventArgs e)
        {
            if(e.Column.Key =="E")
                ShowDetail();
            else
            {
	            var cell    = NzGrid.CurrentRow.Cells["S"];
	            var dataRow = NzGrid.CurrentRow.DataRow as RemaindPeople;

	            var msg = new Messaging();

				await msg.SendSarResidQest(
					cell,
					Convert.ToInt64(dataRow.mobile),
					dataRow.Title,
					dataRow.Balance
				);
			}
        }
        private void ms_Save_Click                  (object sender, EventArgs e)
        {
            RefreshGrid();
        }

		private  async void NsMessage_Click(object sender, EventArgs e)
		{
			if (!NzGrid.GetCheckedRows().Any())
			{
				MS_Message.Show("یک یا چند ردیف را انتخاب کنید");
				return;
			}

			_CancelJob = false;
			NsMessage.Visible = false;
			NsProgress.Visible = NsProgressText.Visible = NsCancel.Visible = true;
			NsProgress.Maximum = NzGrid.GetCheckedRows().Count();
			NsProgress.Minimum = 0;
			NsProgress.Value = 0;
			NsProgressText.Text = @"0 \ " + NsProgress.Maximum;

			foreach (var row in NzGrid.GetCheckedRows())
			{
				var dataRow = row.DataRow as RemaindPeople;
				var cell = row.Cells["S"];
				var msg = new Messaging();


				await msg.SendSarResidQest(
					cell,
					Convert.ToInt64(dataRow.mobile),
					dataRow.Title,
                    dataRow.Balance
				);
				
				NsProgress.Value++;
				NsProgressText.Text = NsProgress.Value + @" \ " + NsProgress.Maximum;
				if (_CancelJob)
					break;
			}
		}

		private void NsCancel_Click(object sender, EventArgs e)
		{
			_CancelJob = true;
			NsProgress.Visible = NsProgressText.Visible = NsCancel.Visible = false;
			NsMessage.Visible = true;
		}
	}
}
