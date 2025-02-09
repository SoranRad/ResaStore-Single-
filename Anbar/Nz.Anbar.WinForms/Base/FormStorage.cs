using System; 
using System.ComponentModel; 
using System.Windows.Forms;
using MS_Control;
using MS_Control.MainForms;
using NZ.Anbar.Business;
using NZ.Anbar.Model;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.Base
{
    public partial class FormStorage : Form_Mother_IRANSans
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
        private Storage     _Item;
        private bool        _Is_Edit = false;
        public event EventHandler MS_Do_Save;
        #endregion
        public FormStorage(Manager Manager, Storage Row = null)
        {
            InitializeComponent();
            _Manager    = Manager;
            _Item       = Row;
        }

        #region Methods
        private void LoadItem   ()
        {
            try
            {
                _Is_Edit                = true;
                NzCode.Enabled =
                    !_Manager
                        .HaveCircular<Storage>
                            (new
                            {
                                Year = SystemConstant.ActiveYear.Salmali,
                                _Item.Code
                            });

                NzTitle.Text            = _Item.Title;
                NzCode.Text             = _Item.Code.ToString();
                NzKind.SelectedIndex    = _Item.Kind + 1;
                NzState.SelectedIndex   = _Item.Is_Disable ? 1 : 0;
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private void Save   ()
        {
            _Item.Title         = NzTitle.Text;
            _Item.Code          = Convert.ToByte(NzCode.MS_Decimal);
            _Item.Kind          = Convert.ToByte( NzKind.SelectedIndex + 1 );
            _Item.Is_Disable    = NzState.SelectedIndex == 1;
        }
        private void Reset  ()
        {
            try
            {
                _Item = new Storage();
                _Is_Edit = false;
                NzTitle.Text = "";
                NzCode.MS_Decimal = _Manager
                                    .GenerateCode<Storage, byte>
                                    (0, new {Year=SystemConstant.ActiveYear.Salmali})+1;

                NzTitle.Focus();
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
                MS_Message.Show("سال مالی بسته شده است \n " +
                                "نمی توانید ادامه دهید ");
                return false;
            }
            if (_Item.ID == 0 || (_Item.ID > 0 && _Item.Code != NzCode.MS_Decimal))
                if (!_Manager.IsCodeUnique<Storage>
                            (new{
                                    Year = SystemConstant.ActiveYear.Salmali,
                                    Code = NzCode.MS_Decimal
                                })
            )
            {
                MS_Message.Show("کد وارد شده تکراری است");
                mS_Notify1.Show(NzCode);
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
        private void Init   ()
        {
            NzKind.SelectedIndex    = 0;
            NzState.SelectedIndex   = 0;

            if (_Item != null && _Item.ID > 0)
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
                _Manager.Save(_Item);
                MS_Do_Save?.Invoke(_Is_Edit, new AddingNewEventArgs(_Item.ID));

                new Form_Notify("ذخـیـره سـازی", "اطـلاعـات بـا مـوفـقـیـت ثـبـت شـــد.",
                        Form_Notify.FarsiMessageBoxIcon.اضافه)
                    .Popup(Form_Notify.Direction_Show.Right_To_Left, 1000);

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
        private void FormStorage_Shown  (object sender, EventArgs e)
        {
            Init();
        }
        private void FormStorage_KeyUp  (object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F2)
                ms_Save.PerformClick();

        }
    }
}
