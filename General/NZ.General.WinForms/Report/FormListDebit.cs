using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using MS_Control;
using NZ.General.Business;
using ShareLib.Models;
using ShareLib.Utils;
using ShareLib.ViewModel;

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
        }
        private void NzGrid_RowDoubleClick          (object sender, RowActionEventArgs e)
        {
            ShowDetail();
        }
        private void NzGrid_ColumnButtonClick       (object sender, ColumnActionEventArgs e)
        {
            ShowDetail();
        }
        private void ms_Save_Click                  (object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}
