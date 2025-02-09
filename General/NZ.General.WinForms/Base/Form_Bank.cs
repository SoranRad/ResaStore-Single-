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
using NZ.General.WinForms.Setting;
using ShareLib.Models;

namespace NZ.General.WinForms.Base
{
    public partial class Form_Bank : Form
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        private Manager _Manager;
        private BankBinding _Bind;
        private List<Bank> _List;
        #endregion

        #region Constractor
        public Form_Bank()
        {
            InitializeComponent();
            _Manager = new Manager();
            NzGrid.FilterMode = FilterMode.None;
        }
        #endregion
        #region Methods
        private void RefreshGrid()
        {
            try
            {
                _List = _Manager
                            .GetList<Bank>(null)?.ToList();

                _Bind = new BankBinding(_List);
                NzGrid.DataSource = _Bind;
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        #endregion
        private void FormBank_Load                  (object sender, EventArgs e)
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
        private void NzGrid_AddingRecord            (object sender, CancelEventArgs e)
        {
            var Row     = NzGrid.CurrentRow?.DataRow as Bank;
            e.Cancel    = string.IsNullOrWhiteSpace(Row?.title?.Trim());

        }
        private void NzGrid_RecordAdded             (object sender, EventArgs e)
        {
            //var Row = NzGrid.CurrentRow.DataRow as Bank;
            //try
            //{
            //    var Mgr = new Manager();
            //    Mgr.Save(Row);
            //    new Form_Notify("تـوجـه", "ردیــف مـورد نـظر بروز رسانی شــد.",
            //            Form_Notify.FarsiMessageBoxIcon.چـک_باکس)
            //        .Popup(Form_Notify.Direction_Show.Down_To_Up, 500);
            //}
            //catch (Exception ex)
            //{
            //    new Form_Notify("تـوجـه", "بروز رسانی با موفقیت انجام شد.",
            //            Form_Notify.FarsiMessageBoxIcon.چـک_باکس)
            //        .Popup(Form_Notify.Direction_Show.Down_To_Up, 500);
            //}
        }
        private void NzGrid_CellUpdated             (object sender, ColumnActionEventArgs e)
        {
            var Row = NzGrid.CurrentRow.DataRow as Bank;
            try
            {
                var Mgr = new Manager();
                Mgr.Save(Row);
                this.Tag = Row.ID;
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
    }
}
