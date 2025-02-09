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
using NZ.General.Business;
using ShareLib.Models;
using ShareLib.Utils;

namespace NZ.General.WinForms.Base
{
    public partial class Form_ListState : Form_Mother_IRANSans
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        private Form_State  _FormItem;
        private Manager     _Manager;
        #endregion
        #region Constructor
        public Form_ListState()
        {
            InitializeComponent();
            this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
            _Manager = new Manager();
        }
        #endregion
        #region Method
        private void   Create_Form                   (State  State)
        {
            if (_FormItem != null)
                _FormItem.Dispose();

            _FormItem               = new Form_State(_Manager, State);
            _FormItem.MS_Do_Save    += _Frm_MS_Do_Save;
            _FormItem.FormClosed    += _Frm_FormClosed;
        }
        private void   _Frm_MS_Do_Save               (object sender, EventArgs e)
        {
            var pos = mS_GridX1.VerticalScrollPosition;
            Refresh_Grid();
            var id = Convert.ToInt16(((AddingNewEventArgs)e).NewObject);

            var row = mS_GridX1.GetRows()
                .SingleOrDefault(x => (x.DataRow as State).ID == id);
            if (row == null) return;

            mS_GridX1.MoveTo(row);
            mS_GridX1.EnsureVisible(row.Position);

            if ((bool)sender)
                mS_GridX1.VerticalScrollPosition = pos;
        }
        void           _Frm_FormClosed               (object sender, FormClosedEventArgs e)
        {
            Create_Form(null);
        }
        void           Refresh_Grid                  ()
        {
            try
            {
                mS_GridX1.DataSource = _Manager.GetList<State>()?.ToList();
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private bool   HaveCircular                  (State Item)
        {
            if (_Manager
                        .HaveCircular<State>
                            (new
                            {
                                Year = SystemConstant.ActiveYear.Salmali,
                                Item.ID
                            })
            )
            {
                MS_Message.Show("ردیف مورد نطر دارای تعدادی شهر است" +
                    "\n نمی توانید آن را حذف کنید");
                return true;
            }
            return false;
        }
        #endregion
        private void    Form_Load                    (object sender, EventArgs e)
        {
            Refresh_Grid();
        }
        private void    mS_GridX1_ColumnButtonClick  (object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            var Row = mS_GridX1.CurrentRow.DataRow as State;
            if (e.Column.Key == "E")
            {
                Create_Form(Row);
                _FormItem.Show(this);
            }
            else if (e.Column.Key == "D")
            {
                try
                {
                    var ResultDel = MS_Message.Show("آیـا بـرای حــذف ردیـف مـورد نـظر مـطـمئـنـیـد؟",
                        "تـوجـه", "", MessageBoxButtons.OKCancel, MSMessage.FarsiMessageBoxIcon.سوال);

                    if (ResultDel != DialogResult.OK)
                        return;
                    if (HaveCircular(Row))
                        return;

                    _Manager.Delete(Row);

                    new Form_Notify("تـوجـه", "حـذف ردیــف مـورد نـظر انـجـام شــد.",
                            Form_Notify.FarsiMessageBoxIcon.چـک_باکس)
                        .Popup(Form_Notify.Direction_Show.Down_To_Up, 500);

                    var Spos = mS_GridX1.VerticalScrollPosition;
                    var Rpos = mS_GridX1.CurrentRow.Position;

                    Refresh_Grid();

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
        private void    ms_Add_Click                 (object sender, EventArgs e)
        {
            Create_Form(null);
            _FormItem.Show(this);
        }
        private void    Form_KeyUp                   (object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Insert:
                    ms_Add.PerformClick();
                    break;
            }
        }

        private void mS_GridX_Setting1_MS_On_Print_Clicked(object sender, EventArgs e)
        {
            mS_GridX_Setting1.FillParametter("");
        }
    }
}
