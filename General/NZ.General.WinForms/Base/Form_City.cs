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
using NZ.General.Business;
using ShareLib.Models;
using ShareLib.Utils;


namespace NZ.General.WinForms.Base
{
    public partial class Form_City : Form_Mother_IRANSans
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        private         City                _City      = null;
        public event    EventHandler        MS_Do_Save;
        private         bool                _Is_Edit   = false;
        private         Manager             _Manager;
        #endregion
        #region Constructor
        public      Form_City   (Manager Manager, City City)
        {
            InitializeComponent();
            _Manager    = Manager;
            _City       = City;
        }
        #endregion
        #region Methods
        private void    LoadItem            ()
        {
            try
            {
                _Is_Edit = true;
                NzStates.MS_Set_Select(_City.FK_Ostan);
                NzTitle.Text = _City.title;

            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private void    Save                ()
        {
            _City.FK_Ostan  = (NzStates.MS_Get_Selected() as State).ID;
            _City.title     = NzTitle.Text;
        }
        private void    Reset               ()
        {
            try
            {
                _City = new City();
                _Is_Edit = false;
                NzTitle.Text = "";
                NzTitle.Focus();
            }
            catch (Exception ex)
            {
                MS_Message.Show("سیستم قادر به اتصال به بانک اطلاعاتی نیست",
                    "خطا در تولید کد", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private bool    IsOK                ()
        {
            if(NzStates.MS_Get_Selected() ==null)
            {
                mS_Notify1.Show(NzStates);
                NzStates.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(NzTitle.Text))
            {
                mS_Notify1.Show(NzTitle);
                NzTitle.Focus();
                return false;
            }

            return true;
        }
        private void    Init                ()
        {
            NzStates.Refresh_Grid();

            if (_City != null && _City.ID > 0)
                LoadItem();
            else
                Reset();
        }
        #endregion

        private void    ms_Save_Click       (object sender, EventArgs e)
        {
            try
            {
                if (!IsOK())
                    return;
                Save();
                _Manager.Save(_City);
                MS_Do_Save?.Invoke(_Is_Edit, new AddingNewEventArgs(_City.ID));

                new Form_Notify("ذخـیـره سـازی", "اطـلاعـات بـا مـوفـقـیـت ثـبـت شـــد.",
                        Form_Notify.FarsiMessageBoxIcon.اضافه)
                            .Popup(Form_Notify.Direction_Show.Right_To_Left, 500);
                Tag = _City.ID;

                if (_Is_Edit)
                    Close();
                else
                    Reset();

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MS_Message.Show("سیستم قادر به ثبت اطلاعات نیست",
                    "خطا در ثبت", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private void    ms_Exit_Click       (object sender, EventArgs e)
        {
            Close();
        }
        private void    Form_KeyUp          (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                ms_Save.PerformClick();
        }
        private void    Form_City_Shown     (object sender, EventArgs e)
        {
            Init();
        }
    }
}
