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
using MS_Control.Tarikh;
using NZ.Xazane.Business;
using NZ.Xazane.Model.ViewModel;
using ShareLib;
using ShareLib.Models;
using ShareLib.Utils;

namespace NZ.Xazane.WinForms.Cheque
{
    public partial class FormAssign : Form_Mother_IRANSans
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        private ReportManager           _Manager;
        private List<ChequeList>        _ListCheque;
        #endregion
        public FormAssign(List<ChequeList> List)
        {
            InitializeComponent();
            _ListCheque     = List;
            _Manager        = new ReportManager();
        }
        #region Methods
        private void    SetLayout  ()
        {
            panel1.Visible  = _ListCheque.Count > 1;
            NzDate.Visible  = _ListCheque.Count == 1;
            if(panel1.Visible)
                this.Height     = 380;
        }
        private bool    IsOK       ()
        {
            if (SystemConstant.ActiveYear.is_close)
            {
                MS_Message.Show("سال مالی بسته شده است " +
                                "\n  نمی توانید ادامه دهید ");
                return false;
            }
            if (NzCustomer.MS_Get_Selected() == null)
            {
                mS_Notify1.Show(NzCustomer);
                NzCustomer.Focus();
                return false;
            }

            if (_ListCheque.Count == 1)
            {
                if (!NzDate.MS_Tarikh.HasValue)
                {
                    mS_Notify1.Show(NzDate);
                    NzDate.Focus();
                    return false;
                }
            }
            else
            {
                if (NzDateUsanc.Checked && !NzDateEmpty.MS_Tarikh.HasValue)
                {
                    mS_Notify1.Show(NzDateEmpty);
                    NzDateEmpty.Focus();
                    return false;
                }

                if (NzDateArrive.Checked && !NzDateBoxArrive.MS_Tarikh.HasValue)
                {
                    mS_Notify1.Show(NzDateBoxArrive);
                    NzDateBoxArrive.Focus();
                    return false;
                }

            }
            return true;
        }
        private void    Init       ()
        {
            SetLayout();
            NzCustomer.Refresh_Grid(_Manager.Connection, true, true);
            if (_ListCheque.Count == 1)
            {
                var cheque = _ListCheque.FirstOrDefault();
                NzDate.MS_Tarikh = new MS_Structure_Shamsi(cheque.tarikh_sar_resid ?? DateTime.Now);
            }
            else
            {
                NzDateBoxArrive.MS_Tarikh   = new MS_Structure_Shamsi(DateTime.Now);
                NzDateEmpty.MS_Tarikh       = new MS_Structure_Shamsi(DateTime.Now);
            }
        }
        #endregion

        private void FormAssign_Shown           (object sender, EventArgs e)
        {
            Init();
        }
        private void FormAssign_KeyUp           (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                ms_Save.PerformClick();
            else if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void ms_Save_Click              (object sender, EventArgs e)
        {
            try
            {
                if (!IsOK())
                    return;
                //==============
                DateTime Date;
                if (_ListCheque.Count == 1)
                    Date = NzDate.MS_Tarikh.Value.ToDatetime().Date;
                else
                    Date = NzDateArrive.Checked
                        ? NzDateBoxArrive.MS_Tarikh.Value.ToDatetime().Date
                        : NzDateEmpty.MS_Tarikh.Value.ToDatetime().Date;

                var People      = (NzCustomer.MS_Get_Selected() as People).ID;
                var WhereClause = string.Join(" OR ", _ListCheque.Select(x => " ID = " + x.ID));

                if (NzDateArrive.Checked || _ListCheque.Count == 1)
                {
                    _Manager.GetReport<AssignChequeInDate>(new
                    {
                        Kind = Enums.NzChequeStateFlag.Vagozari,
                        Date,
                        People,
                        User = SystemConstant.ActiveUser.ID,
                        Year = SystemConstant.ActiveYear.Salmali,
                        Desc = NzDescription.Text.Trim(),

                    }, WhereClause);
                }
                else
                {
                    _Manager.GetReport<AssignCheque>(new
                    {
                        Kind = Enums.NzChequeStateFlag.Vagozari,
                        People,
                        Date,
                        User = SystemConstant.ActiveUser.ID,
                        Desc = NzDescription.Text.Trim(),
                        Year = SystemConstant.ActiveYear.Salmali,
                    }, WhereClause);
                }

                new Form_Notify("ذخـیـره سـازی", "اطـلاعـات بـا مـوفـقـیـت ثـبـت شـــد.",
                        Form_Notify.FarsiMessageBoxIcon.اضافه)
                    .Popup(Form_Notify.Direction_Show.Right_To_Left, 1000);

                Close();

            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در ذخیره اطلاعات", "خطا ", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private void ms_Exit_Click              (object sender, EventArgs e)
        {
            Close();
        }

        private void NzDateUsanc_CheckedChanged (object sender, EventArgs e)
        {
            NzDateBoxArrive.Enabled = NzDateArrive.Checked;
            NzDateEmpty.Enabled     = NzDateUsanc.Checked;
        }

        
    }
}
