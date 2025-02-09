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
using Nz.Anbar.Model.ViewModel;
using NZ.Anbar.Business;

namespace Nz.Anbar.WinForms.Base
{
    public partial class FormPriceChange : Form_Mother_IRANSans
    {
        #region Logging
        private static readonly log4net.ILog
            log =
                log4net
                    .LogManager
                    .GetLogger
                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion
        #region FIelds
        private List<PriceList>     _List;
        private ReportManager       _Manager;
        #endregion
        #region Constructor
        public FormPriceChange(List<PriceList> List)
        {
            InitializeComponent();
            _Manager = new ReportManager();
            _List = List;
        }
        #endregion
        #region Methods
        private bool IsOK()
        {
            if (NzAmountRadio.Checked && NzAmount.MS_Decimal == 0)
            {
                mS_Notify1.Show(NzAmount);
                NzAmount.Focus();
                return false;
            }
            if (NzPercentRadio.Checked && NzPercent.MS_Decimal == 0)
            {
                mS_Notify1.Show(NzPercent);
                NzPercent.Focus();
                return false;
            }

            if (!_List.Any())
            {
                MS_Message.Show("هیج ردیفی انتخـاب نشده است");
                return false;
            }
            return true;
        }
        #endregion

        private void NzPercentRadio_CheckedChanged  (object sender, EventArgs e)
        {
            NzPercent.Enabled   = NzPercentRadio.Checked;
            NzAmount.Enabled    = NzAmountRadio.Checked;
        }

        private void NzSave_Click                   (object sender, EventArgs e)
        {
            if(!IsOK())
                return;
            try
            {
                var WhereClause     = "("+string.Join(" OR ", _List.Select(x => " ID=" + x.ID + " "))+")";
                var Percent         = NzAmountRadio.Checked
                    ? NzAmount.MS_Decimal
                    : NzPercent.MS_Decimal / 100;

                var nerx  = NzNerx.Checked;
                var nerx1 = NzNerx1.Checked;
                var nerx2 = NzNerx2.Checked;
                var nerx3 = NzNerx3.Checked;


                if (NzDecrease.Checked)
                {
                    
                    if (NzAmountRadio.Checked)
                        _Manager.GetItem<DecreasePrice>(new
                        {
                            Percent,
                            nerx,
                            nerx1,
                            nerx2,
                            nerx3,

                        }, WhereClause);
                    else
                        _Manager.GetReport<DecreasePrice>(new
                        {
                            Percent,
                            nerx,
                            nerx1,
                            nerx2,
                            nerx3,
                        }, WhereClause);

                }
                else
                {
                    if (NzAmountRadio.Checked)
                        _Manager.GetItem<IncreasePrice>(new
                        {
                            Percent,
                            nerx,
                            nerx1,
                            nerx2,
                            nerx3,

                        }, WhereClause);
                    else
                        _Manager.GetReport<IncreasePrice>(new
                        {
                            Percent,
                            nerx,
                            nerx1,
                            nerx2,
                            nerx3,

                        }, WhereClause);
                }

                new Form_Notify("تغییر قیمت فروش","بروزرسانی با موفقیت انجام شد",Form_Notify.FarsiMessageBoxIcon.چـک_باکس)
                    .Popup(Form_Notify.Direction_Show.Right_To_Left,1500);
                DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در ذخیره اطلاعات", "خطا",
                    ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private void NzExit_Click                   (object sender, EventArgs e)
        {
            Close();
        }

        private void FormPriceChange_KeyUp          (object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F2)
                NzSave.PerformClick();
            else if(e.KeyCode== Keys.Escape)
                NzExit.PerformClick();
        }
    }
}
