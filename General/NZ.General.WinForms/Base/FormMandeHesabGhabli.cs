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
using ShareLib.Models;

namespace NZ.General.WinForms.Base
{
    public partial class FormMandeHesabGhabli : Form_Mother_IRANSans
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        private Form_People _FormPeople;
        private Manager _Manager;
        #endregion
        #region Constractor
        public FormMandeHesabGhabli()
        {
            InitializeComponent();
            this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
            _Manager = new Manager();
        }
        #endregion
        #region Methods
        private void Create_Form(People People)
        {
            _FormPeople?.Dispose();

            _FormPeople = new Form_People(_Manager, People);
            _FormPeople.MS_Do_Save += Frm_MS_Do_Save;
            _FormPeople.FormClosed += Frm_FormClosed;
        }
        private void Frm_MS_Do_Save(object sender, EventArgs e)
        {
            var pos = mS_GridX1.VerticalScrollPosition;
            RefreshGrid();
            var id = Convert.ToInt16(((AddingNewEventArgs)e).NewObject);
            var row = mS_GridX1.GetRows()
                .SingleOrDefault(x => (x.DataRow as People).ID == id);
            if (row == null) return;
            mS_GridX1.MoveTo(row);
            mS_GridX1.EnsureVisible(row.Position);
            if ((bool)sender)
                mS_GridX1.VerticalScrollPosition = pos;
        }
        private void Frm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Create_Form(null);
        }
        private void RefreshGrid()
        {
            try
            {
                mS_GridX1.DataSource = _Manager
                    .GetList<People>()
                    ?.ToList();
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private bool HaveCircular(People Item)
        {
            //if (_Manager
            //    .HaveCircular<People>
            //    (new
            //    {
            //        Code=Item.ID
            //    })
            //)
            //{
            //    MS_Message.Show("ردیف مورد نطر دارای گردش عملیاتی است" +
            //                    "\n نمی توانید آن را حذف کنید");
            //    return true;
            //}
            return false;
        }
        #endregion
        private void Form_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }
        private void mS_GridX1_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            var Row = mS_GridX1.CurrentRow.DataRow as People;
            if (e.Column.Key == "E")
            {
                Create_Form(Row);
                _FormPeople.Show(this);
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
                    RefreshGrid();
                }
                catch (Exception ex)
                {
                    MS_Message.Show("خطا در ثبت  اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                    log.Error(ex);
                }
            }

        }
        
    }
}
