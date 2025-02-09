using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control;
using MS_Control.MainForms;
using NZ.General.Business;
using ShareLib.Utils;
using ShareLib.Models;

namespace NZ.General.WinForms.Base
{
    public partial class Form_ListYear : Form_Mother_IRANSans
    {
        #region Logging
        private static readonly log4net.ILog log = 
                        log4net
                        .LogManager
                        .GetLogger
                        (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields

        private Form_Year   _FormYear;
        private Manager     _Manager;
        #endregion
        #region Consructor
        public       Form_ListYear      ()
        {
            InitializeComponent();
            this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
            _Manager = new Manager();
        }
        #endregion
        #region Methods
        private void Create_Form        (Year   Year)
        {
            if (_FormYear != null)
                _FormYear.Dispose();

            _FormYear               = new  Form_Year(_Manager,Year);
            _FormYear.MS_Do_Save    += Frm_MS_Do_Save;
            _FormYear.FormClosed    += Frm_FormClosed;
        }
        private void Frm_MS_Do_Save     (object sender, EventArgs           e)
        {
            var pos = mS_GridX1.VerticalScrollPosition;
            RefreshGrid();
            var id = Convert.ToInt16(((AddingNewEventArgs)e).NewObject);

            var row = mS_GridX1.GetRows()
                .SingleOrDefault(x => (x.DataRow as Year).Salmali == id);
            if (row == null) return;

            mS_GridX1.MoveTo(row);
            mS_GridX1.EnsureVisible(row.Position);
            if ((bool)sender)
                mS_GridX1.VerticalScrollPosition = pos;
        }
        private void Frm_FormClosed     (object sender, FormClosedEventArgs e)
        {
            Create_Form(null);
        }
        private void RefreshGrid        ()
        {
            try
            {
                mS_GridX1.DataSource = _Manager.GetList<Year>()?.ToList();
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن اطلاعات ","خطا",ex.Message,MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        #endregion
        private void Form_ListYear_Load     (object sender, EventArgs e)
        {
            RefreshGrid();
        }
        private void ms_Add_Click           (object sender, EventArgs e)
        {
            Create_Form(null);
            _FormYear.Show(this);
        }
        private void mS_GridX1_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            var Row = mS_GridX1.CurrentRow.DataRow as Year;
            if (e.Column.Key == "E")
            {
                Create_Form(Row);
                _FormYear.Show(this);
            }
            else if (e.Column.Key == "D")
            {
                try
                {
                    var ResultDel = MS_Message.Show("آیـا بـرای حــذف ردیـف مـورد نـظر مـطـمئـنـیـد؟",
                                "تـوجـه", "", MessageBoxButtons.OKCancel, MSMessage.FarsiMessageBoxIcon.سوال);
                    if (ResultDel != DialogResult.OK)
                        return;
                    _Manager = new Manager();

                    _Manager.Delete(Row);

                    new Form_Notify("تـوجـه", "حـذف ردیــف مـورد نـظر انـجـام شــد.",
                                 Form_Notify.FarsiMessageBoxIcon.چـک_باکس)
                                 .Popup(Form_Notify.Direction_Show.Down_To_Up, 500);

                    var Spos = mS_GridX1.VerticalScrollPosition;
                    var Rpos = mS_GridX1.CurrentRow.Position;

                    RefreshGrid();

                    if (Rpos > 0 && Rpos >= mS_GridX1.RowCount)
                        Rpos--;

                    mS_GridX1.MoveTo(Rpos);
                    mS_GridX1.EnsureVisible(Rpos);
                    mS_GridX1.VerticalScrollPosition = Spos;

                }
                catch (Exception ex)
                {
                    MS_Message.Show("خطا در ثبت  اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                    log.Error(ex);
                }
            }

        }
        private void Form_ListYear_KeyUp    (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
                ms_Add.PerformClick();
        }

        private void mS_GridX_Setting1_MS_On_Print_Clicked(object sender, EventArgs e)
        {
            mS_GridX_Setting1.FillParametter("");
        }
    }
}
