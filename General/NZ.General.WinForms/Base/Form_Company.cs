using System;
using System.ComponentModel; 
using System.Drawing;
using System.IO;
using System.Linq; 
using System.Windows.Forms;
using MS_Control;
using MS_Control.MainForms; 
using NZ.General.Business;
using ShareLib.Models; 

namespace NZ.General.WinForms.Base
{
    public partial class Form_Company : Form_Mother_IRANSans
    {
        #region Logging
        private static readonly log4net.ILog log =
                                log4net
                                    .LogManager
                                    .GetLogger
                                    (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        private         Company         _Company    = null;
        public event    EventHandler    MS_Do_Save;
        private         bool            _Is_Edit    = false;
        private         Manager         _Manager;
        #endregion
        #region Constructor
        public Form_Company     ()
        {
            InitializeComponent();
            _Manager = new Manager();
            Init();
        }
        #endregion
        #region Methods
        private void    LoadItem    ()
        {
            ms_Code.ReadOnly = ms_Title.ReadOnly = ms_Tarix.ReadOnly = !_Is_Edit;

            try
            {
                ms_Code.Text = _Company.OriginalCode;
                ms_Title.Text = _Company.OriginalTitle;
                ms_Tarix.Text = _Company.OriginalTarix;

            }
            catch (Exception ex)
            {
                MS_Message.Show("اطـلاعـات بـرنـامـه دچـار اشـکال شـده اسـت لـطـفا " +
                                "\n بـا پـشـتیـبانـی تـماس بـگـیریــد",
                    "تـوجــه", ex.Message, MessageBoxButtons.OK, MSMessage.FarsiMessageBoxIcon.اخطار);
            }
            ms_Adres.Text           = (_Company.address ?? "").Trim();
            ms_Tel.Text             = (_Company.tel ?? "").Trim();
            ms_Mob.Text             = (_Company.mobile ?? "").Trim();
            ms_Modir.Text           = (_Company.modir ?? "").Trim();
            ms_Fax.Text             = (_Company.fax ?? "").Trim();
            ms_Molahezat.Text       = (_Company.molahezat ?? "").Trim();

            ms_Email.Text           = (_Company.email ?? "").Trim();
            ms_Web.Text             = (_Company.website ?? "").Trim();
            ms_Tel2.Text            = (_Company.tel2 ?? "").Trim();
            ms_Mob2.Text            = (_Company.mobile2 ?? "").Trim();
            ms_Code_Posti.Text      = (_Company.code_posti ?? "").Trim();
            ms_Code_Meli.Text       = (_Company.code_melli ?? "").Trim();
            ms_Code_Eqtesadi.Text   = (_Company.code_eqtesadi ?? "").Trim();

            if (_Company.logo != null)
            {
                byte[]          arrImage    = (byte[])_Company.logo.ToArray();
                MemoryStream    ms          = new MemoryStream(arrImage);
                ms_Pic_Logo.Image           = Image.FromStream(ms);
            }

            if (_Company.mohr != null)
            {
                byte[] arrImage             = (byte[])_Company.mohr.ToArray();
                MemoryStream ms             = new MemoryStream(arrImage);
                ms_Pic_Mohr.Image           = Image.FromStream(ms);
            }

            ms_Title.Focus();

            NzCpuSys.Text   = MS_Control.Hardware.Hardware.cpu_id().Trim();
            NzMbSys.Text    = MS_Control.Hardware.Hardware.mb_serial_number().Trim();

            try
            {
                var Mgr = new ReportManager();
                var ListActive = Mgr.GetReport<Activation>(null, null);

                var regs = ListActive
                    .SelectMany
                        (x =>
                            x.OriginalActiveString.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                        )
                    .ToArray();

                NzCodeRegs.Lines = regs;
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }

        }
        private void    Save        ()
        {
            //if (!_Is_Edit)
            //{
            //    _Company.Code       = ms_Code.Text.Trim();
            //    _Company.title      = ms_Title.Text.Trim();
            //    _Company.tarikh     = ms_Tarix.Text.Trim();
            //}

            _Company.address        = ms_Adres.Text.Trim();
            _Company.tel            = ms_Tel.Text.Trim();
            _Company.mobile         = ms_Mob.Text.Trim();
            _Company.fax            = ms_Fax.Text.Trim();
            _Company.modir          = ms_Modir.Text.Trim();
            _Company.code_posti     = ms_Code_Posti.Text.Trim();
            _Company.code_melli     = ms_Code_Meli.Text.Trim();
            _Company.molahezat      = ms_Molahezat.Text.Trim();

            _Company.email          = ms_Email.Text.Trim();
            _Company.website        = ms_Web.Text.Trim();
            _Company.tel2           = ms_Tel2.Text.Trim();
            _Company.mobile2        = ms_Mob2.Text.Trim();
            _Company.code_eqtesadi  = ms_Code_Eqtesadi.Text.Trim();

            if (ms_Pic_Logo.Image != null)
            {
                MemoryStream ms         = new MemoryStream();
                ms_Pic_Logo.Image.Save  (ms, ms_Pic_Logo.Image.RawFormat);
                byte[] arrImage         = ms.GetBuffer();
                _Company.logo           = arrImage;
            }
            else
                _Company.logo           = null;

            if (ms_Pic_Mohr.Image != null)
            {
                MemoryStream ms         = new MemoryStream();
                ms_Pic_Mohr.Image.Save  (ms, ms_Pic_Mohr.Image.RawFormat);
                byte[] arrImage         = ms.GetBuffer();
                _Company.mohr           = arrImage;
            }
            else
                _Company.mohr           = null;
        }
        private bool    IsOK        ()
        {
            //if (ms_Code.MS_Decimal <= 0)
            //{
            //    mS_Notify1.Show(ms_Code);
            //    ms_Code.Focus();
            //    new Form_Notify("تـوجـه تـوجـه", "اطـلاعـات را صحـیح وارد کـنیــد.",
            //            Form_Notify.FarsiMessageBoxIcon.اخطار)
            //        .Popup(Form_Notify.Direction_Show.Right_To_Left, 500);
            //    return false;
            //}
            if (string.IsNullOrWhiteSpace(ms_Title.Text))
            {
                mS_Notify1.Show(ms_Title);
                ms_Title.Focus();
                new Form_Notify("تـوجـه تـوجـه", "اطـلاعـات را صحـیح وارد کـنیــد.",
                        Form_Notify.FarsiMessageBoxIcon.اخطار)
                    .Popup(Form_Notify.Direction_Show.Right_To_Left, 500);
                return false;
            }
            return true;

        }
        private void    Init        ()
        {
            try
            {
                var Mgr     = new ReportManager();
                _Company    = Mgr.GetItem<Company>(new {ID = true}, null);
                LoadItem();
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        #endregion

        private void    ms_Save_Click           (object sender, EventArgs e)
        {
            try
            {
                if (!IsOK())
                    return;

                Save();
                _Manager.Save(_Company);
                MS_Do_Save?.Invoke(_Is_Edit, new AddingNewEventArgs(_Company.Code));

                new Form_Notify("ذخـیـره سـازی", "اطـلاعـات بـا مـوفـقـیـت ثـبـت شـــد.",
                        Form_Notify.FarsiMessageBoxIcon.اضافه)
                    .Popup(Form_Notify.Direction_Show.Right_To_Left, 500);

                Close();
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
        private void    Form_KeyUp              (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
                ms_Save.PerformClick();
            //else if (e.KeyCode == Keys.F4)
                //ms_New.PerformClick();

        }

        private void    ms_Open_Pic_Click       (object sender, EventArgs e)
        {
            OpenFileDialog b = new OpenFileDialog();
            b.Filter = "image file|*.bmp;*.jpg;*.png;*.gif;*.tiff";
            DialogResult d = b.ShowDialog();
            if (d == DialogResult.Cancel)
                return;
            ms_Pic_Logo.Image = Image.FromFile(b.FileName);
        }
        private void    ms_Open_Stamp_Click     (object sender, EventArgs e)
        {
            OpenFileDialog b = new OpenFileDialog();
            b.Filter = "image file|*.bmp;*.jpg;*.png;*.gif;*.tiff";
            DialogResult d = b.ShowDialog();
            if (d == DialogResult.Cancel)
                return;
            ms_Pic_Mohr.Image = Image.FromFile(b.FileName);
        }
        private void    ms_Delete_Stamp_Click   (object sender, EventArgs e)
        {
            ms_Pic_Mohr.Image = null;
        }
        private void    ms_Delete_Pic_Click     (object sender, EventArgs e)
        {
            ms_Pic_Logo.Image = null;
        }
        private void    uiTabPage3_Click        (object sender, EventArgs e)
        {

        }
    }
}
