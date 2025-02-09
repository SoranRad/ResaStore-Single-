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
using MS_Control.Tarikh;
using NZ.Xazane.Business;
using NZ.Xazane.Model.Models;
using NZ.Xazane.Model.ViewModel;
using NZ.Xazane.WinForms.Cheque;
using ShareLib;
using ShareLib.Utils;

namespace NZ.Xazane.WinForms.App
{
    public partial class FormListCheque : Form
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion
        #region Fields
        private ReportManager                   _Manager;
        private Enums.NzPaymentOperatingKind    _Kind;
        #endregion
        #region Constructor
        public       FormListCheque         ()
        {
            InitializeComponent();
            this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
            _Manager = new ReportManager();
            SetCurrentMonth();
            NzKinds.SelectedTabChanged  += NzKinds_SelectedTabChanged;
            ms_mah.SelectedTabChanged   += NzKinds_SelectedTabChanged;
        }
        #endregion
        #region Methods
        private void SetCurrentMonth        ()
        {
            var mah                 = new MS_Structure_Shamsi(DateTime.Now)._Mah;
            ms_mah.SelectedIndex    = 13 - mah;
        }
        private void SetKind                ()
        {
            _Kind = NzKinds.SelectedTab == NzTabPayment 
                    ? Enums.NzPaymentOperatingKind.Pardaxt 
                    : Enums.NzPaymentOperatingKind.Daryaft;

            NzGridHeads.RootTable.Columns["BankTitle"].Visible          = _Kind == Enums.NzPaymentOperatingKind.Daryaft;
            NzGridHeads.RootTable.Columns["PayAccountTitle"].Visible    = _Kind != Enums.NzPaymentOperatingKind.Daryaft;
        }
        private void RefreshGrid            ()
        {
            try
            {
                SetKind();
                //===================
                //===================
                var Month           = 14 - ms_mah.SelectedIndex;
                string WhereClause  = "";
                if (Month == 1)
                    WhereClause = @"    (tac.Kind_Vaziat is NULL AND tad.kind = @Kind AND tad.FK_Salmali < @Year)
OR  (tad.FK_Salmali < @Year AND tac.FK_Salmali_Vaziat = @Year AND tad.kind = @Kind)";

                else if (Month >= 2 && Month <= 13)
                    WhereClause = @" tad.FK_Salmali = @Year AND dd.PersianMonthNo = @Month AND tad.kind = @Kind";
                else
                    WhereClause = @" 
    (tac.Kind_Vaziat is NULL AND tad.kind = @Kind AND tad.FK_Salmali < @Year)
OR  (tad.FK_Salmali < @Year AND tac.FK_Salmali_Vaziat = @Year AND tad.kind = @Kind)
OR  (tad.FK_Salmali  =   @Year AND tad.kind = @Kind)
";
                //===================
                //===================
                Month -- ;
                var list =
                    _Manager.GetReport<ChequeList>(new
                    {
                        Year = SystemConstant.ActiveYear.Salmali,
                        Kind = (byte)_Kind,
                        Month

                    },WhereClause);
                NzGridHeads.DataSource = list?.ToList();

                if (NzGridHeads.RowCount > 0)
                    NzGridHeads.MoveFirst();

                if (NzItems.Checked)
                    RefreshItem();
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن اطلاعات", "خطا", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private void RefreshItem            ()
        {
            if(NzGridHeads.CurrentRow==null || NzGridHeads.CurrentRow.RowType!=RowType.Record)
                return;

            if(!NzItems.Checked)
                return;

            if(NzGridHeads.CurrentRow.DataRow is ChequeList row)
                NzDetails.SetCheque(row.ID);
        }
        
        private void Edit                   ()
        {
            if(NzGridHeads.CurrentRow.RowType != RowType.Record)
                return;
            if (NzGridHeads.CurrentRow.DataRow is ChequeList row)
            {
                if (row.Kind_Vaziat != null)
                    MS_Message.Show("کاربر گرامی" +
                                    "\n چـک مورد نظر شما دارای وضعیت "+ row.StateTitle +"  می باشد " +
                                    "\n در ویرایش آن دقت کافی را لحاط بفرمایید " 
                                    ,"اخطار");

                new FormPayment(row.ID_DP, _Kind).ShowDialog(this);
            }
            else 
                return;

            Refresh_Restore_Grid();
        }
        private List<ChequeList>    GetSelection            ()
        {
            var  list   = new List<ChequeList>();
            var checks  = NzGridHeads.GetCheckedRows();

            if (checks.Length > 0)
                return checks.Select(x => (ChequeList)x.DataRow).ToList();
            else if (NzGridHeads.CurrentRow?.RowType == RowType.Record)
            {
                var item = NzGridHeads.CurrentRow.DataRow as ChequeList;
                return new List<ChequeList>() { item };
            }
            else
                return null;
        }
        private void                Refresh_Restore_Grid    ()
        {
            var Spos = NzGridHeads.VerticalScrollPosition;
            var Rpos = NzGridHeads.CurrentRow.Position;

            RefreshGrid();

            if (Rpos > 0 && Rpos >= NzGridHeads.RowCount)
                Rpos--;

            NzGridHeads.MoveTo(Rpos);
            NzGridHeads.EnsureVisible(Rpos);
            NzGridHeads.VerticalScrollPosition = Spos;
        }
        #endregion

        private void FormListCheque_Shown               (object sender, EventArgs e)
        {
            RefreshGrid();
        }
        private void NzArriveCheque_Click               (object sender, EventArgs e)
        {
            IEnumerable<ChequeList> list = GetSelection();

            if (list == null)
                return;

            var frm =
                _Kind == Enums.NzPaymentOperatingKind.Daryaft
                    ? (Form)new FormArriveCheque    (list.ToList())
                    : (Form)new FormArrive_Back     (Enums.NzChequeStateFlag.Vosul, list.ToList());

            frm.ShowDialog(this);
            Refresh_Restore_Grid();
        }
        private void NzGiveBackCheque_Click             (object sender, EventArgs e)
        {
            IEnumerable<ChequeList> list = GetSelection();

            if (list == null)
                return;

            new FormArrive_Back
                (Enums.NzChequeStateFlag.Bargasht, list.ToList())
                .ShowDialog(this);

            Refresh_Restore_Grid();

        }
        private void NzAssignToOther_Click              (object sender, EventArgs e)
        {
            if(_Kind==Enums.NzPaymentOperatingKind.Pardaxt)
                return;

            IEnumerable<ChequeList> list = GetSelection();

            if(list==null)
                return;

            new FormAssign(list.ToList())
                .ShowDialog(this);

            Refresh_Restore_Grid();

        }
        private void NzBackToCache_Click                (object sender, EventArgs e)
        {
            var ResultDel = MS_Message.Show("وضعیت چـک های انتخابی حذف خواهد شد " +
                                            "\n  و به حالت نزد صندوق تبدیل می شود " +
                                            "\n\n  آیا برای حذف وضعیت اطمینان دارید؟"
                , "تـوجـه"
                , ""
                , MessageBoxButtons.YesNo
                , MSMessage.FarsiMessageBoxIcon.سوال);

            if (ResultDel != DialogResult.Yes)
                return;
            try
            {
                IEnumerable<ChequeList> list = GetSelection();

                if (list == null)
                    return;

                var WhereClause = string.Join(" OR ", list.Select(x => " ID = " + x.ID));

                _Manager.GetReport<RemoveChequeState>(new
                {
                    User  = SystemConstant.ActiveUser.ID,
                }, WhereClause);
                Refresh_Restore_Grid();
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در حذف", "خطا", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }

        private void NzKinds_SelectedTabChanged         (object sender, Janus.Windows.UI.Tab.TabEventArgs e)
        {
            RefreshGrid();
        }

        private void NzGridHeads_ColumnButtonClick      (object sender, ColumnActionEventArgs e)
        {
            switch (e.Column.Key)
            {
                case "E":
                    Edit();
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

                        var Mgr = new Manager(_Manager.Connection);

                        if (NzGridHeads.CurrentRow.DataRow is ChequeList row)
                        {
                            var Item= new ChequeOperation(){ID = row.ID};
                            Mgr.Delete<ChequeOperation>(Item);
                        }

                        new Form_Notify("تـوجـه", "حـذف ردیــف مـورد نـظر انـجـام شــد.",
                                Form_Notify.FarsiMessageBoxIcon.چـک_باکس)
                            .Popup(Form_Notify.Direction_Show.Right_To_Left, 1500);

                        Refresh_Restore_Grid();
                    }
                    catch (Exception ex)
                    {
                        MS_Message.Show("خطا در حذف", "خطا", ex.Message, MessageBoxButtons.OK);
                        log.Error(ex);
                    }
                    break;
            }
        }
        private void NzGridHeads_RowDoubleClick         (object sender, RowActionEventArgs e)
        {
            Edit();
        }
        private void NzGridHeads_SelectionChanged       (object sender, EventArgs e)
        {
            RefreshItem();
        }

        private void NzItems_Click                      (object sender, EventArgs e)
        {
            Splitter1.Visible = NzItems.Checked;
            NzDetails.Visible = NzItems.Checked;
            RefreshItem();
        }

        private void mS_GridX_Setting2_MS_On_Print_Clicked(object sender, EventArgs e)
        {
            mS_GridX_Setting2.FillParametter("لیست"+_Kind);
        }
    }
}
