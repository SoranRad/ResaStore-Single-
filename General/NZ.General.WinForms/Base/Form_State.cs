using System; 
using System.ComponentModel; 
using System.Windows.Forms;
using MS_Control;
using MS_Control.MainForms; 
using NZ.General.Business;
using ShareLib.Models; 

namespace NZ.General.WinForms.Base
{
    public partial class Form_State : Form_Mother_IRANSans
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        private         State           _State          = null;
        private         Manager         _Manager;
        public event    EventHandler    MS_Do_Save;
        private bool                    _Is_Edit        = false;
        #endregion

        #region Constructor
       
        public Form_State(Manager Manager, State State)
        {
            InitializeComponent();
            _Manager    = Manager;
            _State      = State;
        }
        #endregion
        #region Methods
        private void LoadItem()
        {
            try
            {
                _Is_Edit = true;
                ms_Title.Text = _State.title;
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private void Save()
        {
            _State.title = ms_Title.Text.Trim();
        }
        private void Reset()
        {
            try
            {
                _State = new State();
                _Is_Edit = false;
                ms_Title.Text = "";
                ms_Title.Focus();
            }
            catch (Exception ex)
            {
                MS_Message.Show("سیستم قادر به اتصال به بانک اطلاعاتی نیست",
                    "خطا در تولید کد", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private bool IsOK()
        {

            if (string.IsNullOrWhiteSpace(ms_Title.Text))
            {
                mS_Notify1.Show(ms_Title);
                ms_Title.Focus();
                return false;
            }

            return true;
        }
        private void Init()
        {
            if (_State != null && _State.ID > 0)
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
                _Manager.Save(_State);
                MS_Do_Save?.Invoke(_Is_Edit, new AddingNewEventArgs(_State.ID));

                new Form_Notify("ذخـیـره سـازی", "اطـلاعـات بـا مـوفـقـیـت ثـبـت شـــد.",
                        Form_Notify.FarsiMessageBoxIcon.اضافه)
                            .Popup(Form_Notify.Direction_Show.Right_To_Left, 1500);
                this.Tag = _State.ID;
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
        private void Form_State_Shown   (object sender, EventArgs e)
        {
            Init();
        }
    }
}
