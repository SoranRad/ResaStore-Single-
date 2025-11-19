using System; 
using System.Linq; 
using System.Windows.Forms;
using MS_Control;
using MS_Control.MainForms;
using NZ.Anbar.Business;
using Nz.Anbar.Model.Model;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.Base
{
    public partial class FormListPreFactor : Form_Mother_IRANSans
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
        private PrefactorManager    _Manager; 
        #endregion
        public FormListPreFactor()
        {
            InitializeComponent();
            this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
            _Manager = new PrefactorManager();
            RefreshGrid();
        }

        #region Methods
          
        private void RefreshGrid            ()
        {
            try
            {
                ms_Grid.DataSource = _Manager.GetList(null)?.ToList();
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
         
        #endregion

        private void ms_Add_Click               (object sender, EventArgs e)
        {
            new FormPreFactor().ShowDialog(this);
            RefreshGrid();
        }
        private void ms_Grid_ColumnButtonClick  (object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            var Row = ms_Grid.CurrentRow.DataRow as PreFactor;
            if (e.Column.Key == "E")
            {
                new FormPreFactor(Row.ID).ShowDialog(this);
                RefreshGrid();
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
                    
                    _Manager = new PrefactorManager();

                    _Manager.Delete(Row.ID);

                    new Form_Notify("تـوجـه", "حـذف ردیــف مـورد نـظر انـجـام شــد.",
                            Form_Notify.FarsiMessageBoxIcon.چـک_باکس)
                        .Popup(Form_Notify.Direction_Show.Down_To_Up, 500);


                    var Spos = ms_Grid.VerticalScrollPosition;
                    var Rpos = ms_Grid.CurrentRow.Position;

                    RefreshGrid();

                    if (Rpos > 0 && Rpos >= ms_Grid.RowCount)
                        Rpos--;

                    ms_Grid.MoveTo(Rpos);
                    ms_Grid.EnsureVisible(Rpos);
                    ms_Grid.VerticalScrollPosition = Spos;

                }
                catch (Exception ex)
                {
                    MS_Message.Show("خطا در ثبت  اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                    log.Error(ex);
                }
            }
            else if (e.Column.Key == "A4")
            {
                var prn = new Print.PrintPrefactor(Row.ID); 
                prn.Show(this);
            }
        }
        private void FormListStorage_KeyUp      (object sender, KeyEventArgs e)
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
