using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NZ.Xazane.Business;
using NZ.Xazane.Model.ViewModel;
using ShareLib;

namespace NZ.Xazane.WinForms.Component
{
    public partial class NzChequeStateShow : UserControl
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion
        #region Fields
        private long            _ID;
        private ChequeState     _State;
        #endregion
        public NzChequeStateShow()
        {
            InitializeComponent();
        }
        #region Methods
        public void  SetCheque  (long IDCheque)
        {
            _ID     = IDCheque;
            _State  = null;
            ResetForm();
            GetCheque();

            if(_State!= null)
                ShowCheque();
        }

        private void GetCheque  ()
        {
            try
            {
                var mgr = new ReportManager();
                _State  = mgr.GetItem<ChequeState>(new {ID = _ID}, null);
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void ShowCheque ()
        {
            NzAddDate.Text      = _State.DateAdd;
            NzEditDate.Text     = _State.DateEdit;

            NzUserAdd.Text      = _State.UserAdd;
            NzEditUser.Text     = _State.UserEdit;

            NzDate.Text         = _State.Date;
            NzDescription.Text  = _State.Description;

            if (_State.Kind == (byte) Enums.NzChequeStateFlag.Vagozari)
            {
                NzPeople.Text       = _State.PeopleAssign;
                NzlblPeople.Text    = "شخص واگذار شده :";
                NzPeople.Visible    = NzlblPeople.Visible = true;
            }
            else if (   _State.Kind     == (byte) Enums.NzChequeStateFlag.Vosul
                     && _State.MainKind == (byte) Enums.NzPaymentOperatingKind.Daryaft)
            {
                NzPeople.Text       = _State.AccountAct;
                NzlblPeople.Text    = "حساب وصول :";
                NzPeople.Visible    = NzlblPeople.Visible = true;
            }
            else
                NzPeople.Visible    = NzlblPeople.Visible = false;
        }
        private void ResetForm  ()
        {
            NzAddDate.Text      = 
            NzEditDate.Text     = 

            NzUserAdd.Text      = 
            NzEditUser.Text     = 

            NzDate.Text         = 
            NzPeople.Text       = 
            NzDescription.Text  = "";
        }
        #endregion
    }
}
