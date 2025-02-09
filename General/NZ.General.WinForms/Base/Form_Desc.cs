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
    public partial class Form_Desc : Form_Mother_IRANSans
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        private Description         _Desc       = null;
        public event EventHandler   MS_Do_Save;
        private bool                _Is_Edit    = false;
        private Manager             _Manager;
        #endregion

        #region Constructor
        public Form_Desc        (Manager Manager, Description Desc)
        {
            InitializeComponent();
            _Manager    = Manager;
            _Desc       = Desc;
        }
        #endregion
        #region Methods
        private void LoadItem   ()
        {
            try
            {
                _Is_Edit = true;
                ms_Desc.Text = _Desc.Text;
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private void Save   ()
        {
            _Desc.Text = ms_Desc.Text.Trim();
        }
        private void Reset  ()
        {
            try
            {
                _Desc           = new Description();
                _Is_Edit        = false;
                ms_Desc.Text    = "";
                ms_Desc.Focus();
            }
            catch (Exception ex)
            {
                MS_Message.Show("سیستم قادر به اتصال به بانک اطلاعاتی نیست",
                    "خطا در تولید کد", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private bool IsOK   ()
        {
            if (string.IsNullOrWhiteSpace(ms_Desc.Text))
            {
                mS_Notify1.Show(ms_Desc);
                ms_Desc.Focus();
                return false;
            }
            return true;
        }
        private void Init()
        {
            if (_Desc != null && _Desc.ID > 0)
                LoadItem();
            else
                Reset();
        }
        #endregion

        private void ms_Save_Click      (object sender, EventArgs e)
        {
            try
            {
                if (!IsOK())
                    return;
                Save();
                _Manager.Save(_Desc);
                MS_Do_Save?.Invoke(_Is_Edit, new AddingNewEventArgs(_Desc.ID));

                new Form_Notify("ذخـیـره سـازی", "اطـلاعـات بـا مـوفـقـیـت ثـبـت شـــد.",
                        Form_Notify.FarsiMessageBoxIcon.اضافه)
                    .Popup(Form_Notify.Direction_Show.Right_To_Left, 500);

                if (_Is_Edit)
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
        private void ms_Exit_Click      (object sender, EventArgs e)
        {
            Close();
        }
        private void Form_KeyUp         (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                ms_Save.PerformClick();
        }
        private void Form_Desc_Shown    (object sender, EventArgs e)
        {
            Init();
        }
    }
}
