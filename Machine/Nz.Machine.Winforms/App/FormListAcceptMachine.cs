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
using Nz.Machine.DataLayer.UnitOfWork;
using Nz.Machine.Model.Model;
using Nz.Machine.Winforms.Provider;
using ShareLib;
using ShareLib.Utils;

namespace Nz.Machine.Winforms.App
{
    public partial class FormListAcceptMachine : Form
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection
                    .MethodBase
                    .GetCurrentMethod()
                    .DeclaringType);
        #endregion
        #region Fields 
        private FormAcceptMachine _FormItem;
        #endregion
        public FormListAcceptMachine    ()
        {
            InitializeComponent();
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
        private void Create_Form        (Guid? ID)
        {
            _FormItem?.Dispose();

            _FormItem               = new FormAcceptMachine(ID);
            _FormItem.MS_Do_Save    += Frm_MS_Do_Save;
            _FormItem.FormClosed    += Frm_FormClosed;
        }
        private void Frm_MS_Do_Save     (object sender, EventArgs e)
        {
            var pos = NzGrid.VerticalScrollPosition;
            RefreshGrid();
            var id = (Guid)(((AddingNewEventArgs)e).NewObject);

            var row = NzGrid.GetRows()
                .SingleOrDefault(x => ((AcceptMachine)x.DataRow).ID == id);
            if (row == null) return;

            NzGrid.MoveTo(row);
            NzGrid.EnsureVisible(row.Position);
            if ((bool)sender)
                NzGrid.VerticalScrollPosition = pos;
        }
        private void Frm_FormClosed     (object sender, FormClosedEventArgs e)
        {
            Create_Form(null);
        }
        private void RefreshGrid        ()
        {
            try
            {
                var Month = 13 - ms_mah.SelectedIndex;
                var UnitOfWork      = new UnitOfWork(ConnectionManager.Create());
                var repo            = UnitOfWork.Repository<AcceptMachine>();
                NzGrid.DataSource   = repo.GetList(new { Year = SystemConstant.ActiveYear.Salmali, Month  })
                    ?.ToList();
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private void PrintFactor(Enums.NzKindPrint PrintKind)
        {
            List<Guid> ListIDs;

            if (NzGrid.GetCheckedRows().Any())
            {
                ListIDs = NzGrid
                            .GetCheckedRows()
                            .Select(x => ((AcceptMachine)x.DataRow).ID)
                            .ToList();
            }
            else
            {
                if (NzGrid.CurrentRow.RowType != RowType.Record)
                    return;
                var ID =  (NzGrid.CurrentRow.DataRow as AcceptMachine).ID;

                ListIDs = new List<Guid>() { ID };
            }

            new Print(ListIDs, PrintKind).Show(this);
        }
        #endregion
        private void NzFactorKinds_SelectedTabChanged(object sender, Janus.Windows.UI.Tab.TabEventArgs e)
        {
            RefreshGrid();
        }

        private void NzAddItem_Click(object sender, EventArgs e)
        {
            Create_Form(null);
            _FormItem.Show(this);
        }

        private void NzGrid_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            var Row = NzGrid.CurrentRow.DataRow as AcceptMachine;
            if (e.Column.Key == "E")
            {
                Create_Form(Row.ID);
                _FormItem.Show(this);
            }
            else if (e.Column.Key == "D")
            {
                try
                {
                    var ResultDel = MS_Message.Show("آیـا بـرای حــذف ردیـف مـورد نـظر مـطـمئـنـیـد؟"
                        , "تـوجـه"
                        , ""
                        , MessageBoxButtons.OKCancel
                        , MSMessage.FarsiMessageBoxIcon.سوال);

                    if (ResultDel != DialogResult.OK)
                        return;

                    var UnitOfWork  = new UnitOfWork(ConnectionManager.Create());
                    var repo        = UnitOfWork.Repository<AcceptMachine>();

                    repo.Delete(Row);

                    new Form_Notify("تـوجـه", "حـذف ردیــف مـورد نـظر انـجـام شــد.",
                            Form_Notify.FarsiMessageBoxIcon.چـک_باکس)
                        .Popup(Form_Notify.Direction_Show.Down_To_Up, 500);


                    var Spos = NzGrid.VerticalScrollPosition;
                    var Rpos = NzGrid.CurrentRow.Position;

                    RefreshGrid();

                    if (Rpos > 0 && Rpos >= NzGrid.RowCount)
                        Rpos--;

                    NzGrid.MoveTo(Rpos);
                    NzGrid.EnsureVisible(Rpos);
                    NzGrid.VerticalScrollPosition = Spos;

                }
                catch (Exception ex)
                {
                    MS_Message.Show("خطا در ثبت  اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                    log.Error(ex);
                }
            }
        }

        private void NzRefreshList_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void NzPrintA5_Click(object sender, EventArgs e)
        {
            PrintFactor(Enums.NzKindPrint.PaperA5);
        }

        private void NzPrintA4_Click(object sender, EventArgs e)
        {
            PrintFactor(Enums.NzKindPrint.PaperA4);

        }
    }
}
