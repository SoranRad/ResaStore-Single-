using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janus.Windows.UI.Tab;
using MS_Control;
using MS_Control.MainForms;
using MS_Control.Tarikh;
using NZ.General.WinForms.Component;
using NZ.Xazane.Business;
using NZ.Xazane.Model;
using NZ.Xazane.Model.Models;
using NZ.Xazane.Model.ViewModel;
using NZ.Xazane.WinForms.Base;
using ShareLib;
using ShareLib.Utils;
using Stimulsoft.Report.Design.Dictionary;

namespace NZ.Xazane.WinForms.App
{
    public partial class FormListDeficitAddition : Form
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        private FormDeficit                     _Deficit;
        private DpManager                       _Manager;
        private Enums.NzPaymentOperatingKind    _Kind;
        #endregion

        #region Constractor
        public FormListDeficitAddition()
        {
            InitializeComponent();
            this.Icon                   = global::MS_Resource.GlobalResources.Logo_Resaa;
            _Manager                    = new DpManager();
            RefreshGrid();
            var mah                     = new MS_Structure_Shamsi(DateTime.Now)._Mah;
            ms_mah.SelectedIndex        = 13 - mah;
            ms_mah.SelectedTabChanged   += ms_mah_SelectedTabChanged;
            NzDeficitAdditionKind.SelectedTabChanged += ms_mah_SelectedTabChanged;
        }
        #endregion

        #region Methods

        private void SetLayout                      ()
        {
            NzGrid.LoadLayout(NzGrid.Layouts[_Kind==Enums.NzPaymentOperatingKind.Kosurat? "Deficit": "Addition"]);
        }
        private void RefreshGrid                    ()
        {
            try
            {
                _Kind = NzDeficitAdditionKind.SelectedTab==NzTabDeficit
                    ? Enums.NzPaymentOperatingKind.Kosurat
                    : Enums.NzPaymentOperatingKind.Addition;

                var Month = 13 - ms_mah.SelectedIndex;

                SetLayout();

                NzGrid.DataSource = _Manager
                    .GetView<DeficitAdditionList>(
                        new
                        {
                            Year = SystemConstant.ActiveYear.Salmali,
                            Kind = _Kind,
                            Month
                        })?
                    .ToList();
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }

        private void Create_FormDeficit             (long  ID)
        {
            _Deficit?.Dispose();

            _Deficit                = new FormDeficit(_Manager,ID,_Kind);
            _Deficit.MS_Do_Save     += Frm_MS_Do_Save;
            _Deficit.FormClosed     += Frm_FormClosed;
        }
        private void Frm_MS_Do_Save                 (object sender, EventArgs e)
        {
            var pos         = NzGrid.VerticalScrollPosition;
            RefreshGrid();
            var id          = Convert.ToInt16(((AddingNewEventArgs)e).NewObject);
            var row         = NzGrid.GetRows()
                                            .SingleOrDefault(x => (x.DataRow as DeficitAdditionList).ID == id);
            if (row == null) return;

            NzGrid.MoveTo(row);
            NzGrid.EnsureVisible(row.Position);

            if ((bool)sender)
                NzGrid.VerticalScrollPosition = pos;
        }
        private void Frm_FormClosed                 (object sender, FormClosedEventArgs e)
        {
            //Create_Form(0);
        }
        #endregion
        private void ms_Add_Click                   (object sender, EventArgs e)
        {
                Create_FormDeficit(0);
                _Deficit.ShowDialog(this);
        }
        private void FormListDeficit_Load           (object sender, EventArgs e)
        {
            RefreshGrid();
        }
        private void mS_GridX1_ColumnButtonClick    (object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            var Row = NzGrid.CurrentRow.DataRow as DeficitAdditionList;
            if (e.Column.Key == "E")
            {
                Create_FormDeficit(Row.ID);
                _Deficit.Show(this);
            }
            else if (e.Column.Key == "D")
            {
                try
                {
                    var ResultDel = MS_Message.Show("آیـا بـرای حــذف ردیـف مـورد نـظر مـطـمئـنـیـد؟",
                        "تـوجـه", "", MessageBoxButtons.OKCancel, MSMessage.FarsiMessageBoxIcon.سوال);

                    if (ResultDel != DialogResult.OK)
                        return;
                   
                    _Manager = new DpManager();
                    _Manager.Delete(Row.ID);
                    new Form_Notify("تـوجـه", "حـذف ردیــف مـورد نـظر انـجـام شــد.",
                            Form_Notify.FarsiMessageBoxIcon.چـک_باکس)
                        .Popup(Form_Notify.Direction_Show.Down_To_Up, 500);

                    var Spos    = NzGrid.VerticalScrollPosition;
                    var Rpos    = NzGrid.CurrentRow.Position;

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
        private void ms_mah_SelectedTabChanged      (object sender, TabEventArgs e)
        {
            RefreshGrid();
        }

        private void mS_GridX_Setting1_MS_On_Print_Clicked(object sender, EventArgs e)
        {
            mS_GridX_Setting1.FillParametter("");
        }
    }
}
