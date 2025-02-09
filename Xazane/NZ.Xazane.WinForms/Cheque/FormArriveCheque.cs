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
using NZ.Xazane.Model;
using NZ.Xazane.Model.ViewModel;
using ShareLib;
using ShareLib.Utils;

namespace NZ.Xazane.WinForms.Cheque
{
    public partial class FormArriveCheque : Form_Mother_IRANSans
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion
        #region Fieds
        private bool                    _CacheLoaded        = false,
                                        _BankAccountLoaded  = false,
                                        _FundLoaded         = false;

        private ReportManager                 _Manager;
        private List<ChequeList>        _ListCheque;
        #endregion
        #region Constructor
        public FormArriveCheque(List<ChequeList> List)
        {
            InitializeComponent();
            _ListCheque = List;
            _Manager    = new ReportManager();
        }
        #endregion
        #region Methods
        private void    SetLayout  ()
        {
            panel1.Visible  = _ListCheque.Count > 1;
            NzDate.Visible  = _ListCheque.Count == 1;
            if(panel1.Visible)
                this.Height     = 475;
        }
        private bool    IsOK       ()
        {
            if (SystemConstant.ActiveYear.is_close)
            {
                MS_Message.Show("سال مالی بسته شده است " +
                                "\n  نمی توانید ادامه دهید ");
                return false;
            }

            if (NzBankRadio.Checked  && NzComboBankAccount.MS_Get_Selected()    == null)
            {
                mS_Notify1.Show(NzComboBankAccount);
                NzComboBankAccount.Focus();
                return false;
            }
            if (NzCacheRadio.Checked && NzComboCache.MS_Get_Selected()          == null)
            {
                mS_Notify1.Show(NzComboCache);
                NzComboCache.Focus();
                return false;
            }
            if (NzFundRadio.Checked  && NzComboFund.MS_Get_Selected()           == null)
            {
                mS_Notify1.Show(NzComboFund);
                NzComboFund.Focus();
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
            NzComboBankAccount.Refresh_Grid(_Manager.Connection,Enums.NzAccountKind.BankAccount);
            _BankAccountLoaded = true;
            NzComboBankAccount.Focus();

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

        private long? GetAccount()
        {
            if (NzBankRadio.Checked)
                return ((Accounts) NzComboBankAccount.MS_Get_Selected()).ID;
            if (NzCacheRadio.Checked)
                return ((Accounts) NzComboCache.MS_Get_Selected()).ID;
            if (NzFundRadio.Checked )
                return ((Accounts) NzComboFund.MS_Get_Selected()).ID;

            return null;
        }
        #endregion
        private void        FormArriveCheque_Shown      (object sender, EventArgs e)
        {
            Init();
        }
        private void        FormArriveCheque_KeyUp      (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                ms_Save.PerformClick();
            else if (e.KeyCode == Keys.Escape)
                Close();
        }

        private void        ms_Exit_Click               (object sender, EventArgs e)
        {
            Close();
        }
        private void        ms_Save_Click               (object sender, EventArgs e)
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

                var WhereClause = string.Join(" OR ", _ListCheque.Select(x => " ID = " + x.ID));
                
                if (NzDateArrive.Checked || _ListCheque.Count == 1)
                {
                    _Manager.GetReport<RecieveChequeArriveInDate>(new
                    {
                        Kind    = (byte) Enums.NzChequeStateFlag.Vosul,
                        Date    ,
                        User    = SystemConstant.ActiveUser.ID,
                        Desc    = NzDescription.Text.Trim(),
                        Account = GetAccount(),
                        Year    = SystemConstant.ActiveYear.Salmali
                    },WhereClause);
                }
                else
                {
                    _Manager.GetReport<RecieveChequeArrive>(new
                    {
                        Kind    = (byte)Enums.NzChequeStateFlag.Vosul,
                        Date    ,
                        User    = SystemConstant.ActiveUser.ID,
                        Desc    = NzDescription.Text.Trim(),
                        Year    = SystemConstant.ActiveYear.Salmali,
                        Account = GetAccount(),
                    }, WhereClause);
                }

                new Form_Notify(@"ذخـیـره سـازی", @"اطـلاعـات بـا مـوفـقـیـت ثـبـت شـــد.",
                        Form_Notify.FarsiMessageBoxIcon.اضافه)
                    .Popup(Form_Notify.Direction_Show.Right_To_Left, 1000);
               
                Close();
                
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در ذخیره اطلاعات", "خطا ",ex.Message,MessageBoxButtons.OK);
                log.Error(ex);
            }
        }

        private void        NzCacheRadio_CheckedChanged (object sender, EventArgs e)
        {
            NzComboCache.Enabled        = NzCacheRadio.Checked;
            NzComboBankAccount.Enabled  = NzBankRadio.Checked;
            NzComboFund.Enabled         = NzFundRadio.Checked;

            if (NzCacheRadio.Checked && !_CacheLoaded)
            {
                NzComboCache.Refresh_Grid(_Manager.Connection,Enums.NzAccountKind.Cache);
                NzComboCache.Focus();
                _CacheLoaded = true;
            }
            else if (NzBankRadio.Checked && !_BankAccountLoaded)
            {
                NzComboBankAccount.Refresh_Grid(_Manager.Connection, Enums.NzAccountKind.BankAccount);
                NzComboBankAccount.Focus();
                _BankAccountLoaded = true;
            }
            else if (NzFundRadio.Checked && !_FundLoaded)
            {
                NzComboFund.Refresh_Grid(_Manager.Connection, Enums.NzAccountKind.Fund);
                NzComboFund.Focus();
                _FundLoaded = true;
            }
        }
        private void        NzDateUsanc_CheckedChanged  (object sender, EventArgs e)
        {
            NzDateBoxArrive.Enabled     = NzDateArrive.Checked;
            NzDateEmpty.Enabled         = NzDateUsanc.Checked;
        }
    }
}
