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
using ShareLib;
using ShareLib.Models;
using ShareLib.Utils;

namespace NZ.General.WinForms.Base
{
    public partial class Form_PeopleGroup : Form_Mother_IRANSans
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        private         PeopleGroup     _PeopleGroup    = null;
        public event    EventHandler    MS_Do_Save;
        private bool                    _Is_Edit        = false;
        private         Manager         _Manager;
        #endregion
        #region Constractor
        public Form_PeopleGroup              (Manager Manager, PeopleGroup PeopleGroup)
        {
            InitializeComponent();
            _PeopleGroup    = PeopleGroup;
            _Manager        = Manager;
            Init();
        }
        #endregion
        #region Methods
        private void    Save                    ()
        {
            if (_PeopleGroup.ID == 0)
                _PeopleGroup.ID             = Convert.ToInt16(NzCode.MS_Decimal);
                _PeopleGroup.Title          = NzTitle.Text;

               
        }
        private void    LoadItem                    ()
        {
            try
            {
                _Is_Edit            = true;

                NzCode.MS_Decimal   = _PeopleGroup.ID;
                NzTitle.Text        = _PeopleGroup.Title;
                NzCode.Enabled      = !_Manager.HaveCircular<PeopleGroup>(new {Code = _PeopleGroup.ID});
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private void    Reset                   ()
        {
            try
            {
                _PeopleGroup    = new PeopleGroup();
                _Is_Edit        = false;
                NzTitle.Text    = "";
                NzCode.Text     = "";
                NzCode.Text = (_Manager.GenerateCode<PeopleGroup, short>(0) + 1).ToString();
                NzCode.Enabled = true;
                NzTitle.Focus();
            }
            catch (Exception ex)
            {
                MS_Message.Show("سیستم قادر به اتصال به بانک اطلاعاتی نیست",
                    "خطا در تولید کد", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private bool    IsOK                    ()
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
            if (NzCode.MS_Decimal == 0)
            {
                mS_Notify1.Show(NzCode);
                NzCode.Focus();
                return false;
            }

            if (_PeopleGroup.ID == 0 || (_PeopleGroup.ID > 0 && _PeopleGroup.ID != NzCode.MS_Decimal))
            {
                var result = _Manager.IsCodeUnique<PeopleGroup>(new {Code = NzCode.MS_Decimal});
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
        private void    Init                    ()
        {
            if (_PeopleGroup != null && _PeopleGroup.ID > 0)
                LoadItem();
            else
                Reset();
        }
        #endregion
        private void    ms_Save_Click           (object sender, EventArgs e)
        {
            try
            {
                if (!IsOK())
                    return;
                Save();
                _Manager.Save(_PeopleGroup);
                MS_Do_Save?.Invoke(_Is_Edit, new AddingNewEventArgs(_PeopleGroup.ID));

                new Form_Notify("ذخـیـره سـازی", "اطـلاعـات بـا مـوفـقـیـت ثـبـت شـــد.",
                        Form_Notify.FarsiMessageBoxIcon.اضافه)
                            .Popup(Form_Notify.Direction_Show.Right_To_Left, 1500);

                this.Tag = _PeopleGroup.ID;

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
        private void    ms_Exit_Click           (object sender, EventArgs e)
        {
            Close();
        }
        private void    FormPeopleGroup_KeyUp   (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                ms_Save.PerformClick();
        }
    }
}
