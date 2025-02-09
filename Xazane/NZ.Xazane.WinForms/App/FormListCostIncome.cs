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
using MS_Control.Tarikh;
using NZ.Xazane.Business;
using NZ.Xazane.Model;
using NZ.Xazane.Model.Models;
using NZ.Xazane.WinForms.Base;
using ShareLib;
using ShareLib.Utils;

namespace NZ.Xazane.WinForms.App
{
    public partial class FormListCostIncome : Form
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        private Manager                         _Manager;
        private FormCost                        _CostForm;
        private FormIncome                      _FormIncome;
        #endregion
        #region Constractor
        public      FormListCostIncome  ()
        {
            InitializeComponent();
            var mah                             = new MS_Structure_Shamsi(DateTime.Now)._Mah;
            ms_mah.SelectedIndex                = 13 - mah;
            this.Icon                           = global::MS_Resource.GlobalResources.Logo_Resaa;
            _Manager                            = new Manager();
            ms_mah.SelectedTabChanged           += ms_mah_SelectedTabChanged;
            NzCostIncomeKind.SelectedTabChanged += ms_mah_SelectedTabChanged;
            
        }
        #endregion
        #region Method
        private void SetLayout          (Enums.NzPaymentOperatingKind Kind)
        {
            mS_GridX1.LoadLayout(mS_GridX1.Layouts[Kind == Enums.NzPaymentOperatingKind.Daramad
                ? "Income" : "Cost"]);
        }
        private void RefreshGrid        ()
        {
            try
            {
                var Kind = NzCostIncomeKind.SelectedTab==NzCostTab
                            ? Enums.NzPaymentOperatingKind.Hazine 
                            : Enums.NzPaymentOperatingKind.Daramad;
                //========

                var Month =  13 - ms_mah.SelectedIndex;

                SetLayout(Kind);

                mS_GridX1.DataSource = _Manager
                    .GetList<PayBoxOperation>(
                    new
                    {
                        Year = SystemConstant.ActiveYear.Salmali,
                        Kind ,
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
        private void CreateFormCost     (PayBoxOperation Payment)
        {
            _CostForm?.Dispose();
            
            _CostForm               = new FormCost(Payment);
            _CostForm.MS_Do_Save    += Frm_MS_Do_Save;
            _CostForm.FormClosed    += Frm_FormClosed;
        }
        private void CreateFormIncome   (PayBoxOperation Payment)
        {
            _FormIncome?.Dispose();

            _FormIncome             = new FormIncome(Payment);
            _FormIncome.MS_Do_Save  += Frm_MS_Do_Save;
            _FormIncome.FormClosed  += Frm_FormClosed;
        }
        private void Frm_MS_Do_Save     (object sender, EventArgs e)
        {
            var pos                 = mS_GridX1.VerticalScrollPosition;
            RefreshGrid();
            var id                  = Convert.ToInt64(((AddingNewEventArgs)e).NewObject);

            var row = mS_GridX1.GetRows()
                .SingleOrDefault(x => (x.DataRow as PayBoxOperation).ID == id);
            if (row == null) return;

            mS_GridX1.MoveTo(row);
            mS_GridX1.EnsureVisible(row.Position);

            if ((bool)sender)
                mS_GridX1.VerticalScrollPosition = pos;
        }
        private void Frm_FormClosed     (object sender, FormClosedEventArgs e)
        {
            _CostForm?.Dispose();

        }
        #endregion
        private void ms_mah_SelectedTabChanged      (object sender, Janus.Windows.UI.Tab.TabEventArgs e)
        {
            RefreshGrid();
        }
        
        private void mS_GridX1_ColumnButtonClick    (object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            var Row = mS_GridX1.CurrentRow.DataRow as PayBoxOperation;
             if( e.Column.Key == "E")
            {
                if ((Enums.NzPaymentOperatingKind) Row.kind == Enums.NzPaymentOperatingKind.Daramad)
                {
                    CreateFormIncome(Row);
                    _FormIncome.Show(this);
                }
                else
                {
                    CreateFormCost(Row);
                    _CostForm.Show(this);
                }
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
        private void ms_Add_Click                   (object sender, EventArgs e)
        {
            if (NzCostIncomeKind.SelectedTab==NzCostTab)
            {
                CreateFormCost(null);
                _CostForm.Show(this);
            }
            else if(NzCostIncomeKind.SelectedTab==NzDeficitTab)
            {
                CreateFormIncome(null);
                _FormIncome.Show(this);
            }

        }

        private void FormListCostIncome_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void mS_GridX_Setting1_MS_On_Print_Clicked(object sender, EventArgs e)
        {
            mS_GridX_Setting1.FillParametter("");
        }
    }
}
