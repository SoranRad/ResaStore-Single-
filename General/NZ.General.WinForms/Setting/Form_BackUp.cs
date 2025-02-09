using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control;
using MS_Control.MainForms;
using MS_Control.Tarikh;
using NZ.General.Business;
using ShareLib.Utils;

namespace NZ.General.WinForms.Setting
{
    public partial class Form_BackUp : Form_Mother_IRANSans
    {
        #region Fileds
        private UtilManage _Manager;

        #endregion
        #region Constructor
        public Form_BackUp()
        {
            InitializeComponent();
            _Manager = new UtilManage();
        } 
        #endregion
        #region Address
        private void ms_DataDddress_ButtonClick(object sender, EventArgs e)
        {
            var conn        = ConnectionManager.ConStr;
            var builder     = new SqlConnectionStringBuilder(conn);

            var frm = new MS_Control.DataBase.SqlFolderBrowse
                            .Form_Add_Back_Up(builder.DataSource, builder.UserID, builder.Password);
            var result      = frm.ShowDialog();

            if (result == DialogResult.OK)
                ms_DataDddress.Text = frm.SelectedPath;

            if (result == DialogResult.OK && string.IsNullOrWhiteSpace(ms_NameBakData.Text))
            {
                var now = new MS_Structure_Shamsi(DateTime.Now);
                var str = "BackData_" + now.ToLongShamsi() + "_" +
                          DateTime.Now.Hour.ToString("D2") + "_" +
                          DateTime.Now.Minute.ToString("D2") +
                          ".bak";
                ms_NameBakData.Text = str;
            }
            ms_NameBakData.Focus();

        }
        private void ms_AoutoData_ButtonClick(object sender, EventArgs e)
        {
            var conn        = ConnectionManager.ConStr;
            var builder     = new SqlConnectionStringBuilder(conn);
            var frm         = new MS_Control.DataBase.SqlFolderBrowse
                                .Form_Add_Back_Up(builder.DataSource, builder.UserID, builder.Password);
            var result      = frm.ShowDialog();

            if (result == DialogResult.OK)
                ms_AoutoData.Text = frm.SelectedPath;
        }
        #endregion
        #region Button
        private void ms_SaveData_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ms_DataDddress.Text))
            {
                MS_Message.Show("آدرس محل ذخیره فایل پشتیبان را مشخص کنید");
                ms_DataDddress.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(ms_NameBakData.Text))
            {
                MS_Message.Show("نام فایل پشتیبان را مشخص کنید");
                ms_NameBakData.Focus();
                return;
            }
            try
            {

                bool _Create = true, _Zip = true;

                var path = ms_DataDddress.Text + "\\" + ms_NameBakData.Text;
                var ext = Path.GetExtension(path);

                if (ext.ToLower() != ".bak")
                    path += ".bak";

                _Manager.CreateBackUp(path, out _Create, out _Zip);

                MS_Message.Show("فـایـل پـشـیـبـان بـا مـوفـقـیـت ایــجـاد شــد.\n\nدر حـفـظ و نـگـهـداری آن کــوشـا بـاشـیــد.",
                    "تـوجـه", "", MessageBoxButtons.OK, MSMessage.FarsiMessageBoxIcon.چـک_باکس);

            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در ساخت فایل پشتیبان", "خطای پشتیبان گیری", 
                    ex.Message, 
                    MessageBoxButtons.OK);
            }
        }
        #endregion

        private void ms_Save_Click(object sender, EventArgs e)
        {

        }

        private void ms_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
