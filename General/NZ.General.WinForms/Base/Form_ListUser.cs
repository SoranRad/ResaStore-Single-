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
    public partial class Form_ListUser : Form 
    {

        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        private Form_User   _FormUser;
        private Manager     _Manager;
        #endregion
        #region Constructor
        public Form_ListUser()
        {
            InitializeComponent();
            this.Icon   = global::MS_Resource.GlobalResources.Logo_Resaa;
            _Manager    = new Manager();
            RefreshGrid();
        }
        #endregion
        #region Methods
        private void        Create_Form            (User User)
        {
            if (_FormUser != null)
                _FormUser.Dispose();

            _FormUser = new Form_User(_Manager, User);
            _FormUser.MS_Do_Save += Frm_MS_Do_Save;
            _FormUser.FormClosed += Frm_FormClosed;
        }
        private void        Frm_MS_Do_Save         (object sender, EventArgs e)
        {
            var pos = mS_GridX1.VerticalScrollPosition;
            RefreshGrid();
            var id = Convert.ToInt16(((AddingNewEventArgs)e).NewObject);

            var row = mS_GridX1.GetRows()
                .SingleOrDefault(x => (x.DataRow as User).ID == id);
            if (row == null) return;

            mS_GridX1.MoveTo(row);
            mS_GridX1.EnsureVisible(row.Position);
            if ((bool)sender)
                mS_GridX1.VerticalScrollPosition = pos;
        }
        private void        Frm_FormClosed         (object sender, FormClosedEventArgs e)
        {
            Create_Form(null);
        }
        private void        RefreshGrid            ()
        {
            try
            {
                var list =
                   _Manager
                           .GetList<User>()
                           ?.ToList();
                mS_GridX1.DataSource = list;

            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        #endregion
        private void ms_Add_Click                  (object sender, EventArgs e)
        {
            Create_Form(null);
            _FormUser.Show(this);
        }
        private void mS_GridX1_ColumnButtonClick   (object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            var Row = mS_GridX1.CurrentRow.DataRow as User;
            if (e.Column.Key == "E")
            {
                Create_Form(Row);
                _FormUser.Show(this);
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

                    _Manager.Delete<User>(Row);
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
            else if (e.Column.Key == "R")
            {
                try
                {
                    Row.password = Row.default_password;
                    _Manager.Save(Row);

                    new Form_Notify2("تغییر کلمه عبور", "کلمه عبور با موفقیت تغییر کرد",
                            Form_Notify2.FarsiMessageBoxIcon.چـک_باکس)
                        .Popup(Form_Notify2.Direction_Show.Right_To_Left, 1500);
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                    MS_Message.Show("خطا در ثبت اطلاعات", "خطای ثبت اطلاعات",
                        ex.Message,
                        MessageBoxButtons.OK);
                }
            }

        }

        private void mS_GridX_Setting1_MS_On_Print_Clicked(object sender, EventArgs e)
        {
            mS_GridX_Setting1.FillParametter("");
        }
    }
}
