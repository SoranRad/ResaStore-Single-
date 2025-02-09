using System; 
using System.Windows.Forms;
using MS_Control;
using MS_Control.MainForms;
using MS_Control.Tarikh;
using NZ.Xazane.Business;
using NZ.Xazane.Model; 
using ShareLib.Utils;

namespace NZ.Xazane.WinForms.Base
{
    public partial class FormNewChequeBook : Form_Mother_IRANSans
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        private ChequeBook          _NewChequeBook = null; 
        #endregion
        #region Constractor
        public          FormNewChequeBook   (ChequeBook NewChequeBook)
            {
                InitializeComponent();
                _NewChequeBook = NewChequeBook;
                NzCode.Enabled = true;
            }
        #endregion
        #region Methods
        private void    LoadItem    ()
        {
            try
            { 
                NzCode.MS_Decimal           = _NewChequeBook.Code;
                NzComboAccount.MS_Set_Select(_NewChequeBook.FK_Xazaneh);
                NzTarikhTahvil.MS_Tarikh    = new MS_Structure_Shamsi(_NewChequeBook.Tarikh_Tahvil);
                NzTedadBarge.Text           = _NewChequeBook.Tedad_Barge.ToString();
                NzTozihat.Text              = _NewChequeBook.Sharh;
                NzStartSerial.Text          = _NewChequeBook.Start_Serial.ToString();
                NzState.SelectedIndex       = _NewChequeBook.Is_Disable ? 1 : 0;
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private void    Save    ()
        {
            if (_NewChequeBook.ID == 0)
                _NewChequeBook.Code         = Convert.ToInt16(NzCode.MS_Decimal);

            _NewChequeBook.FK_Xazaneh       = (NzComboAccount.MS_Get_Selected() as Accounts).ID;
            _NewChequeBook.Tarikh_Tahvil    = NzTarikhTahvil.MS_Tarikh.Value.ToDatetime();
            _NewChequeBook.Tedad_Barge      = Convert.ToByte(NzTedadBarge.MS_Decimal);
            _NewChequeBook.Is_Disable       = NzState.SelectedIndex == 1;
            _NewChequeBook.Sharh            = NzTozihat.Text;
        }
        private void    Reset   ()
        {
            try
            {
                NzComboAccount.Focus();
                //_Is_Edit = false;
                _NewChequeBook          = new ChequeBook();
                //var GenericMgr = new GenericManager();
                //NzCode.Text             = GenericMgr.(SystemConstant.ActiveYear).ToString();
                NzTozihat.Text          = "";
                NzState.SelectedIndex   = 0;
            }
            catch (Exception ex)
            {
                MS_Message.Show("سیستم قادر به اتصال به بانک اطلاعاتی نیست",
                    "خطا در تولید کد", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private bool    IsOK    (Manager AccountMgr)
        {
            if (SystemConstant.ActiveYear.is_close)
            {
                MS_Message.Show("سال مالی جاری بسته شده است " +
                                "\n نمی توانید ادامه دهید");
                return false;
            }

            if (string.IsNullOrWhiteSpace(NzTozihat.Text))
            {
                mS_Notify1.Show(NzTozihat);
                NzTozihat.Focus();
                new Form_Notify("تـوجـه", "عنوان صندوق وارد کـنیــد.",
                        Form_Notify.FarsiMessageBoxIcon.اخطار)
                    .Popup(Form_Notify.Direction_Show.Right_To_Left, 1500);
                return false;
            }

            //if (_Cost.ID == 0 || (_Cost.ID > 0 && _Cost.Code != NzCode.MS_Decimal))
            {
                //var result = AccountMgr.IsCodeUnique<ChequeBook>()();
                //if (!result)
                //{
                //    mS_Notify1.Show(NzCode);
                //    NzCode.Focus();
                //    new Form_Notify("تـوجـه تـوجـه", "کــد تکراری است.",
                //            Form_Notify.FarsiMessageBoxIcon.اخطار)
                //        .Popup(Form_Notify.Direction_Show.Down_To_Up, 500);
                //    return false;
                //}
            }
            return true;
        }
        private void    Init    ()
        {
            NzState.SelectedIndex = 0;
            //if (_Cost != null && _Cost.ID > 0)
                LoadItem();
            //else
                Reset();
        }

        #endregion

        private void ms_Save_Click(object sender, EventArgs e)
        {

        }
    }
}
