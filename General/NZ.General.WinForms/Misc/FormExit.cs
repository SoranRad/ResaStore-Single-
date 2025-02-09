using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control;
using MS_Control.MainForms;
using MS_Control.Tarikh;
using NZ.General.Business;
using ShareLib.Utils;
using ShareLib.ViewModel;

namespace NZ.General.WinForms.Misc
{
    public partial class FormExit : Form_Mother_IRANSans
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        private UtilManage      _Manager;
        #endregion
        public FormExit()
        {
            InitializeComponent();
            
        }
        #region Methods
        private void LoadAddress    ()
        {
            var cfg         = Config.FromXML();
            if (string.IsNullOrEmpty(cfg?.Location))
            {
                var path    = Path
                               .GetDirectoryName(Assembly.GetExecutingAssembly().Location)
                                + "\\AutoBack";

                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                cfg.Location = path;
                cfg.ToXml();
            }
            NzDataAddress.Text = cfg.Location;

        }
        private void SaveAddress    ()
        {
            var cfg         = Config.FromXML();
            cfg.Location    = NzDataAddress.Text;
            cfg.ToXml();
        }
        private void CreateBackUp   ()
        {
            bool    _Create = true, 
                    _Zip    = true;
            var     now     = new MS_Structure_Shamsi(DateTime.Now);
            var     str     = "BackData_" + now.ToLongShamsi() + "_" +
                                DateTime.Now.Hour.ToString("D2") + "_" +
                                DateTime.Now.Minute.ToString("D2") +
                                ".bak";

            var path = NzDataAddress.Text + "\\" + str;

            var frm = new MSWait();
            frm.Show(this);
            Application.DoEvents();
            _Manager.CreateBackUp(path, out _Create, out _Zip);

            frm.Close();
            MS_Message.Show(
                "فـایـل پـشـیـبـان بـا مـوفـقـیـت ایــجـاد شــد." +
                            "\n\nدر حـفـظ و نـگـهـداری آن کــوشـا بـاشـیــد.",
                "پشـتیبان",
                MessageBoxButtons.OK,
                MSMessage.FarsiMessageBoxIcon.چـک_باکس
            );
        }
        #endregion
        private void NzBackRadio_CheckedChanged (object sender, EventArgs e)
        {
            NzDataAddress.Enabled = NzBackRadio.Checked;
        }
        private void NzDataAddress_ButtonClick  (object sender, EventArgs e)
        {
            var conn        = ConnectionManager.ConStr;
            var builder     = new SqlConnectionStringBuilder(conn);

            var frm         = new MS_Control.DataBase.SqlFolderBrowse
                                .Form_Add_Back_Up(builder.DataSource, builder.UserID, builder.Password);
            var result      = frm.ShowDialog(this);

            if (result == DialogResult.OK)
            {
                NzDataAddress.Text = frm.SelectedPath;
                SaveAddress();
            }

            NzExit.Focus();
        }

        private void NzExit_Click               (object sender, EventArgs e)
        {
            try
            {
                if (NzBackRadio.Checked)
                    CreateBackUp();
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MS_Message.Show("خطا در ساخت فایل پشتیبان", "خطای پشتیبان گیری",
                    ex.Message,
                    MessageBoxButtons.OK);
            }

            DialogResult = DialogResult.OK;
        }
        private void NzCancel_Click             (object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FormExit_Shown             (object sender, EventArgs e)
        {
            _Manager = new UtilManage();
            LoadAddress();
        }
    }
}
