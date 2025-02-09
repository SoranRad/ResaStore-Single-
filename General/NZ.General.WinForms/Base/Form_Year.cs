using System;
using System.ComponentModel; 
using System.Windows.Forms;
using MS_Control;
using MS_Control.MainForms;
using MS_Control.Tarikh;
using NZ.General.Business; 
using ShareLib.Models;

namespace NZ.General.WinForms.Base
{
    public partial class Form_Year : Form_Mother_IRANSans
    {
        #region Logging
        private static readonly log4net.ILog log =
                        log4net
                        .LogManager
                        .GetLogger
                        (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        private     Year                _Year       = null;
        public      event EventHandler  MS_Do_Save;
        private     bool                _Is_Edit    = false;
        private     Manager             _Manager;
        #endregion
        #region Constructor
        public Form_Year(Manager Manager,Year Salmali)
        {
            InitializeComponent();
            _Year       = Salmali;
            _Manager    = Manager;
        }
        #endregion
        #region Methods
        private void    LoadItem                ()
        {
            try
            {
                _Is_Edit                    = true;
                ms_salmali.ReadOnly         = true;
                ms_salmali.MS_Decimal       = _Year.Salmali;
                ms_StartTarix.MS_Tarikh     = new MS_Structure_Shamsi(_Year.StartDate);
                ms_EndTarix.MS_Tarikh       = new MS_Structure_Shamsi(_Year.EndDate);
                ms_Arzesh_Afzude.MS_Decimal = _Year.darsad_arzesh_afzude;
                ms_Vahed.Text               = _Year.Money;
                ms_Is_Close.SelectedIndex   = _Year.is_close ? 1 : 0;
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private void    Save                ()
        {
            _Year.Salmali               = _Year.Salmali > 0 ? _Year.Salmali : Convert.ToInt16(ms_salmali.MS_Decimal);
            _Year.EndDate               = ms_EndTarix.MS_Tarikh.Value.ToDatetime();
            _Year.Money                 = ms_Vahed.Text;
            _Year.StartDate             = ms_StartTarix.MS_Tarikh.Value.ToDatetime();
            _Year.darsad_arzesh_afzude  = ms_Arzesh_Afzude.MS_Decimal;
            _Year.is_close              = ms_Is_Close.SelectedIndex==1;
        }
        private void    Reset               ()
        {
            try
            {
                _Is_Edit                    = false;
                _Year                       = new Year();
                ms_salmali.ReadOnly         = false;
                var NewSalmali              = _Manager.GenerateCode<Year,short>(0);
                NewSalmali                  = NewSalmali == 0
                                                    ? (short) new MS_Structure_Shamsi(DateTime.Now)._Sal
                                                    : (short) (NewSalmali + 1);
                ms_salmali.MS_Decimal       = NewSalmali;
                ms_Arzesh_Afzude.MS_Decimal = 0;
                ms_StartTarix.MS_Tarikh     = new MS_Structure_Shamsi(NewSalmali,1,1);
                ms_EndTarix.MS_Tarikh       = new MS_Structure_Shamsi(NewSalmali+1,1,1).AddDays(-1);
                ms_Vahed.Text               = "";
                ms_Is_Close.SelectedIndex   = 0;

                ms_salmali.Focus();

            }
            catch (Exception ex)
            {
                MS_Message.Show("سیستم قادر به اتصال به بانک اطلاعاتی نیست",
                                    "خطا در تولید کد",
                                        ex.Message,
                                            MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private bool    IsOK                ()
        {
            if (_Year.Salmali == 0)
            {
                if (!_Manager.IsCodeUnique<Year>(new {Year=ms_salmali.MS_Decimal }))
                {
                    MS_Message.Show("عدد سال مالی تکراری است");
                    mS_Notify1.Show(ms_salmali);
                    ms_salmali.Focus();
                    return false;
                }
            }
            if (!ms_StartTarix.MS_Tarikh.HasValue)
            {
                mS_Notify1.Show(ms_StartTarix);
                ms_StartTarix.Focus();
                return false;
            }
            if (!ms_EndTarix.MS_Tarikh.HasValue)
            {
                mS_Notify1.Show(ms_EndTarix);
                ms_EndTarix.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(ms_Vahed.Text))
            {
                mS_Notify1.Show(ms_Vahed);
                ms_Vahed.Focus();
                return false;
            }

            return true;
        }
        private void    Init                ()
        {
            ms_Is_Close.SelectedIndex = 0;

            if(_Year!=null && _Year.Salmali>0)
                LoadItem();
            else 
                Reset();
        }
        #endregion

        private void    ms_Save_Click       (object sender, EventArgs e)
        {
            try
            {
                if(!IsOK())
                    return;
                Save();
               _Manager.Save(_Year);
                MS_Do_Save?.Invoke(_Is_Edit, new AddingNewEventArgs(_Year.Salmali));

                new Form_Notify("ذخـیـره سـازی", "اطـلاعـات بـا مـوفـقـیـت ثـبـت شـــد.",
                         Form_Notify.FarsiMessageBoxIcon.اضافه)
                        .Popup(Form_Notify.Direction_Show.Right_To_Left, 500);

                if(_Is_Edit)
                    Close();
                else
                    Reset();
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
        private void    Form_Year_Shown     (object sender, EventArgs e)
        {
            Init();
        }
    }
}
