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
    public partial class Form_Restore : Form_Mother_IRANSans
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        private UtilManage _Manager;

        public Form_Restore()
        {
            InitializeComponent();
            _Manager=new UtilManage();
        }

        private void ms_DataRestore_ButtonClick (object sender, EventArgs e)
        {
            var conn        = _Manager.Connection;
            var builder     = new SqlConnectionStringBuilder(conn.ConnectionString);


            var frm = new MS_Control.DataBase.SqlFolderBrowse.Form_Restore(builder.DataSource, builder.UserID, builder.Password);
            var result = frm.ShowDialog();

            if (result == DialogResult.OK)
                ms_DataRestore.Text = frm.SelectedPath;

        }
        private void ms_restor_datadb_Click     (object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ms_DataRestore.Text))
                {
                    MS_Message.Show("فابل پشـتیبان را انتخاب کنید");
                    return;
                }
                var r = MS_Message.Show("کاربر گرامی" +
                                        "\n اطلاعات فایل پشتیبان جایگزین اطلاعات فعلی سیستم می شود" +
                                        "\n  ممکن است برخی اطلاعات از دست برود " +
                                        "\n لذا توصیه می شود که از اطلاعات فعلی خود کپی پشتیبان تهیه فرماییید\n " +
                                        "\nآیا مایل به ادامه بازآوری اطلاعات هستید؟",
                    "هشــدار", String.Empty, MessageBoxButtons.YesNo, MSMessage.FarsiMessageBoxIcon.اخطار,
                    MessageBoxDefaultButton.Button2);
                if (r != DialogResult.Yes)
                    return;

                _Manager.RestoreDB(ms_DataRestore.Text);
                MS_Message.Show("بازآوری با موفقیت انجـام شد", 
                    "بازآوری", 
                    MessageBoxButtons.OK, 
                    MSMessage.FarsiMessageBoxIcon.چـک_باکس);
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در بازگردانی اطلاعات");
                log.Error(ex);
            }
        }
    }
}
