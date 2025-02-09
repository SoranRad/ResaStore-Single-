using System; 
using System.ComponentModel; 
using System.Windows.Forms;
using MS_Control;
using MS_Control.MainForms;
using NZ.Xazane.Business;
using NZ.Xazane.Model;
using ShareLib;
using ShareLib.Utils;

namespace NZ.Xazane.WinForms.Base
{
    public partial class FormCost : Form_Mother_IRANSans
    {
        #region Logging

        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion
        #region Fields

        private Accounts _Cost = null;
        public event EventHandler MS_Do_Save;
        private bool _Is_Edit = false;
        private Enums.NzAccountKind _Kind = Enums.NzAccountKind.Cost;
        private Manager _Manager;

        #endregion
        #region Constractor

        public FormCost(Manager Manager, Accounts Cost)
        {
            InitializeComponent();
            _Cost = Cost;
            _Manager = Manager;
            NzTitle.Focus();
            NzCode.Enabled = true;
        }
        #endregion
        #region Methods

        private void LoadItem()
        {
            try
            {
                _Is_Edit = true;
                NzCode.MS_Decimal = _Cost.Code;
                NzTitle.Text = _Cost.title;
                NzState.SelectedIndex = _Cost.is_disable ? 1 : 0;
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }

        private void Save()
        {
            if (_Cost.ID == 0)
                _Cost.Code = Convert.ToInt16(NzCode.MS_Decimal);

            _Cost.title = NzTitle.Text;
            _Cost.is_disable = NzState.SelectedIndex == 1;
            _Cost.Kind = (byte) _Kind;
        }

        private void Reset()
        {
            try
            {
                NzTitle.Focus();
                _Is_Edit = false;
                _Cost = new Accounts();
                NzCode.Text = (_Manager
                                   .GenerateCode<Accounts, short>
                                   (0, new {Kind = (byte) _Kind}) + 1)
                    .ToString();
                NzTitle.Text = "";
                NzState.SelectedIndex = 0;
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
            if (SystemConstant.ActiveYear.is_close)
            {
                MS_Message.Show("سال مالی جاری بسته شده است " +
                                "\n نمی توانید ادامه دهید");
                return false;
            }

            if (string.IsNullOrWhiteSpace(NzTitle.Text))
            {
                mS_Notify1.Show(NzTitle);
                NzTitle.Focus();
                new Form_Notify("تـوجـه", "عنوان صندوق وارد کـنیــد.",
                        Form_Notify.FarsiMessageBoxIcon.اخطار)
                    .Popup(Form_Notify.Direction_Show.Right_To_Left, 1500);
                return false;
            }

            if (_Cost.ID == 0 || (_Cost.ID > 0 && _Cost.Code != NzCode.MS_Decimal))
            {
                var result = _Manager.IsCodeUnique<Accounts>
                (new
                {
                    Code = Convert.ToInt16(NzCode.MS_Decimal),
                    Kind = (byte) _Kind
                });
                if (!result)
                {
                    mS_Notify1.Show(NzCode);
                    NzCode.Focus();
                    new Form_Notify("تـوجـه تـوجـه", "کــد تکراری است.",
                            Form_Notify.FarsiMessageBoxIcon.اخطار)
                        .Popup(Form_Notify.Direction_Show.Down_To_Up, 500);
                    return false;
                }
            }
            return true;
        }

        private void Init()
        {
            NzState.SelectedIndex = 0;
            if (_Cost != null && _Cost.ID > 0)
                LoadItem();
            else
                Reset();
        }

        #endregion

        private void ms_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsOK())
                    return;
                Save();
                _Manager.Save(_Cost);
                MS_Do_Save?.Invoke(_Is_Edit, new AddingNewEventArgs(_Cost.ID));

                new Form_Notify("ذخـیـره سـازی", "اطـلاعـات بـا مـوفـقـیـت ثـبـت شـــد.",
                        Form_Notify.FarsiMessageBoxIcon.اضافه)
                    .Popup(Form_Notify.Direction_Show.Right_To_Left, 500);

                Tag = _Cost.ID;

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

        private void ms_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCost_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                ms_Save.PerformClick();
            if (e.KeyCode == Keys.Escape)
                ms_Exit.PerformClick();
        }

        private void FormCost_Shown(object sender, EventArgs e)
        {
            Init();
        }

    }
}
