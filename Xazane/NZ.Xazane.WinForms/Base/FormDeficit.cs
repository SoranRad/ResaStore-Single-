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
using NZ.General.WinForms.Component;
using NZ.Xazane.Business;
using NZ.Xazane.Model;
using ShareLib;
using ShareLib.Utils;

namespace NZ.Xazane.WinForms.Base
{
    public partial class FormDeficit : Form_Mother_IRANSans
    {
        #region Logging

        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion
        #region Fields
        private Accounts                    _Deficet        = null;
        public event EventHandler           MS_Do_Save;
        private bool                        _Is_Edit        = false;
        private Enums.NzAccountKind         _Kind           = Enums.NzAccountKind.Deficit;
        private Manager                     _Manager;
        #endregion
        #region MyRegion
        public FormDeficit  (Manager Manager,Accounts Item, Enums.NzAccountKind Kind=Enums.NzAccountKind.Deficit)
        {
            InitializeComponent();
            _Kind       = Kind;
            _Deficet    = Item;
            _Manager    = Manager;
            NzTitle.Focus();
            NzCode.Enabled = true;
        }
        #endregion

        void InitForm()
        {
            this.TitleText = _Kind== Enums.NzAccountKind.Deficit ? "تعریف کسورات" : "تعریف اضافات";
            
        }
        private void LoadItem   ()
        {
            try
            {
                _Is_Edit = true;
                NzCode.MS_Decimal = _Deficet.Code;
                NzTitle.Text = _Deficet.title;
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private void Save   ()
        {
            if (_Deficet.ID == 0)
                _Deficet.Code = Convert.ToInt16(NzCode.MS_Decimal);
            
            _Deficet.title = NzTitle.Text;
            _Deficet.Kind = (byte)_Kind;
        }
        private void Reset  ()
        {
            try
            {
                NzTitle.Focus();
                _Is_Edit = false;
                _Deficet = new Accounts();
                NzCode.Text = (_Manager
                                   .GenerateCode<Accounts, short>
                                   (0, new { Kind = (byte)_Kind }) + 1)
                    .ToString();
                NzTitle.Text = "";
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

            if (_Deficet.ID == 0 || (_Deficet.ID > 0 && _Deficet.Code != NzCode.MS_Decimal))
            {
                var result = _Manager.IsCodeUnique<Accounts>
                (new
                {
                    Code = Convert.ToInt16(NzCode.MS_Decimal),
                    Kind = (byte)_Kind
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
        private void Init               ()
        {
            if (_Deficet != null && _Deficet.ID > 0)
                LoadItem();
            else
                Reset();
            InitForm();
        }
        private void ms_Save_Click      (object sender, EventArgs e)
        {
            try
            {
                if (!IsOK())
                    return;
                Save();
                _Manager.Save(_Deficet);
                MS_Do_Save?.Invoke(_Is_Edit, new AddingNewEventArgs(_Deficet.ID));

                new Form_Notify("ذخـیـره سـازی", "اطـلاعـات بـا مـوفـقـیـت ثـبـت شـــد.",
                        Form_Notify.FarsiMessageBoxIcon.اضافه)
                    .Popup(Form_Notify.Direction_Show.Right_To_Left, 500);

                Tag = _Deficet.ID;

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
        private void ms_Exit_Click      (object sender, EventArgs e)
        {
            Close();
        }
        private void FormDeficit_KeyUp  (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                ms_Save.PerformClick();
            if (e.KeyCode == Keys.Escape)
                ms_Exit.PerformClick();
        }
        private void FormDeficit_Shown  (object sender, EventArgs e)
        {
            Init();
        }
    }
}
