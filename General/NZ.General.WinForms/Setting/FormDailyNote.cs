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
using MS_Control.MainForms;
using MS_Control.Tarikh;
using NZ.General.Business;
using NZ.General.WinForms.Base;
using ShareLib.Models;

namespace NZ.General.WinForms.Setting
{
    public partial class FormDailyNote : Form_Mother_IRANSans
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        private Manager         _Manager;
        private BindingNoteList _Bind;
        private List<DailyNote> _List;
        #endregion
        #region Constructor
        public FormDailyNote    ()
        {
            InitializeComponent();
            _Manager                    = new Manager();
            NzGrid.FilterMode        = FilterMode.None;
            NzCurrentDate.MS_Tarikh   = new MS_Structure_Shamsi(DateTime.Now);
        }
        #endregion

        #region Methods
        private void RefreshGrid()
        {
            try
            {
                var Date    = NzCurrentDate.MS_CurrentTarikh.ToDatetime().Date;

               _List        = _Manager
                                .GetList<DailyNote>
                                        (new
                                            {
                                                Date
                                            })
                                ?.ToList();

                _Bind               = new BindingNoteList(_List, Date);
                NzGrid.DataSource   = _Bind;
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        #endregion

        private void FormDailyNote_KeyUp            (object sender, KeyEventArgs e)
        {
        }
        private void FormDailyNote_Load             (object sender, EventArgs e)
        {
            RefreshGrid();
        }
        private void mS_Tatikh_View1_NzDateChanged  (object sender, EventArgs e)
        {
            RefreshGrid();
        }
        private void mS_GridX1_ColumnButtonClick    (object sender, ColumnActionEventArgs e)
        {
            if (e.Column.Key == "D")
            {
                try
                {
                    var ResultDel = MS_Message.Show("آیـا بـرای حــذف ردیـف مـورد نـظر مـطـمئـنـیـد؟",
                        "تـوجـه", "", MessageBoxButtons.OKCancel, MSMessage.FarsiMessageBoxIcon.سوال);
                    if (ResultDel != DialogResult.OK)
                        return;

                    NzGrid.CurrentRow.Delete();

                    new Form_Notify("تـوجـه", "حـذف ردیــف مـورد نـظر انـجـام شــد.",
                            Form_Notify.FarsiMessageBoxIcon.چـک_باکس)
                        .Popup(Form_Notify.Direction_Show.Down_To_Up, 500);
                }
                catch (Exception ex)
                {
                    MS_Message.Show("خطا در ثبت  اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                    log.Error(ex);
                }
            }
        }

        private void NzGrid_RecordUpdated   (object sender, EventArgs e)
        {
            var Row = NzGrid.CurrentRow.DataRow as DailyNote;
            try
            {
                var Mgr = new Manager();
                Mgr.Save(Row);
                new Form_Notify("تـوجـه", "ردیــف مـورد نـظر بروز رسانی شــد.",
                        Form_Notify.FarsiMessageBoxIcon.چـک_باکس)
                    .Popup(Form_Notify.Direction_Show.Down_To_Up, 500);
            }
            catch (Exception ex)
            {
                log.Error(ex);
                new Form_Notify("تـوجـه", "بروز رسانی با موفقیت انجام شد.",
                        Form_Notify.FarsiMessageBoxIcon.چـک_باکس)
                    .Popup(Form_Notify.Direction_Show.Down_To_Up, 500);
            }
        }
        private void NzGrid_AddingRecord    (object sender, CancelEventArgs e)
        {
            var Row = NzGrid.CurrentRow.DataRow as DailyNote;
            e.Cancel = string.IsNullOrWhiteSpace(Row.Msg);

        }
        private void NzGrid_RecordAdded     (object sender, EventArgs e)
        {
            NzGrid_RecordUpdated(sender, e);
        }

        private void NzSummaryNote_Click(object sender, EventArgs e)
        {
            new Form_SummaryNotes().Show();
        }
    }
}
