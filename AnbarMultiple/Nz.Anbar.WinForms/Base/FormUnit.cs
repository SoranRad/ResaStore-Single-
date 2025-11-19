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
using NZ.Anbar.Business;
using NZ.Anbar.Model;

namespace Nz.Anbar.WinForms.Base
{
    public partial class FormUnit : Form_Mother_IRANSans
    {
        #region Logging
        private static readonly log4net.ILog log =
                                log4net
                                    .LogManager
                                    .GetLogger
                                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields

        private Manager     _Manager;
        private Unit        _Item;
        private bool        _Is_Edit = false;
        public event EventHandler MS_Do_Save;
        #endregion
        #region Constructor
        public FormUnit(Manager Manager, Unit Row = null)
        {
            InitializeComponent();
            _Manager    = Manager;
            _Item       = Row;
        }
        #endregion
        #region Methods
        private void LoadItem()
        {
            try
            {
                _Is_Edit        = true;
                NzTitle.Text    = _Item.title;
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private void Save()
        {
            _Item.title = NzTitle.Text.Trim();
        }
        private void Reset()
        {
            try
            {
                _Item           = new Unit();
                _Is_Edit        = false;
                NzTitle.Text    = "";
                NzTitle.Focus();
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
            if (string.IsNullOrWhiteSpace(NzTitle.Text))
            {
                mS_Notify1.Show(NzTitle);
                NzTitle.Focus();
                return false;
            }
            return true;
        }
        private void Init()
        {
            if (_Item != null && _Item.ID > 0)
                LoadItem();
            else
                Reset();
        }
        #endregion

        private void NzSave_Click       (object sender, EventArgs e)
        {
            try
            {
                if (!IsOK())
                    return;
                Save();
                _Manager.Save(_Item);
                MS_Do_Save?.Invoke(_Is_Edit, new AddingNewEventArgs(_Item.ID));

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
        private void NzCancel_Click     (object sender, EventArgs e)
        {
            Close();
        }
        private void FormUnit_KeyUp     (object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F2)
                NzSave.PerformClick();
            if(e.KeyCode==Keys.Escape)
                NzCancel.PerformClick();
        }

        private void FormUnit_Shown(object sender, EventArgs e)
        {
            Init();
        }
    }
}
