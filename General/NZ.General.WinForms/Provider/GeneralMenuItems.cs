using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control;
using NZ.General.WinForms.Base;
using NZ.General.WinForms.EndYear;
using NZ.General.WinForms.Misc;
using NZ.General.WinForms.Report;
using NZ.General.WinForms.Setting;
using ShareLib.Utils;
using ShareLib.ViewModel;

namespace NZ.General.WinForms.Provider
{
    public partial class GeneralMenuItems : UserControl
    {
        #region Logging
        private static readonly log4net.ILog _log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection
                    .MethodBase
                    .GetCurrentMethod()
                    .DeclaringType);
        #endregion


        public GeneralMenuItems                    ()
        {
            InitializeComponent();
        }

        public void     SetMenu                    ()
        {
            //NzActivation.Visible = false;
        }

        private void    ms_salmali_Click           (object sender, EventArgs e)
        {
            var frm         = new Form_ListYear();
            frm.MdiParent   = GeneralProvider.MainForm;
            frm.Show();
        }
        private void    ms_Description_Click       (object sender, EventArgs e)
        {
            var frm         = new Form_ListDesc();
            frm.MdiParent   = GeneralProvider.MainForm;
            frm.Show();
        }
        private void    ms_Users_Click             (object sender, EventArgs e)
        {
            var frm         = new Form_ListUser();
            frm.MdiParent   = GeneralProvider.MainForm;
            frm.Show();
        }
        private void    ms_CompanyInfo_Click       (object sender, EventArgs e)
        {
            var frm         = new Form_Company();
            frm.Show();
        }
        private void    ms_Backup_Click            (object sender, EventArgs e)
        {
            new Form_BackUp().Show(GeneralProvider.MainForm);
        }
        private void    ms_Restore_Click           (object sender, EventArgs e)
        {
            new Form_Restore().Show(GeneralProvider.MainForm);
        }
        private void    ms_State_Click             (object sender, EventArgs e)
        {
            var frm         = new Form_ListState();
            frm.MdiParent   = GeneralProvider.MainForm;
            frm.Show();
        }
        private void    ms_City_Click              (object sender, EventArgs e)
        {
            var frm         = new Form_ListCity();
            frm.MdiParent   = GeneralProvider.MainForm;
            frm.Show();
        }
        private void    ms_PeopleGroup_Click       (object sender, EventArgs e)
        {
            var frm         = new FormListpeopleGroup();
            frm.MdiParent   = GeneralProvider.MainForm;
            frm.Show();
        }
        private void    ms_People_Click            (object sender, EventArgs e)
        {
            var frm         = new Form_ListPeople();
            frm.MdiParent   = GeneralProvider.MainForm;
            frm.Show();
        }
        private void    ms_UserAccess_Click        (object sender, EventArgs e)
        {
            var frm         = new FormUserAccess(GeneralProvider.MainForm.MainMenuStrip);
            frm.MdiParent   = GeneralProvider.MainForm;
            frm.Show();
        }
        private void    ms_Background_Click        (object sender, EventArgs e)
        {
            var path            = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            Change_Pic.Filter   = MS_Util.GetImageFilter();

            if (Change_Pic.ShowDialog() == DialogResult.OK)
            {
                Image BK        = Image.FromFile(Change_Pic.FileName);
                BK.Save         (path + "\\" + SystemConstant.BkImageName, ImageFormat.Jpeg);
                
                new Form_Notify ("تصویر زمینه", "تصویر زمینه با موفقیت تغییر کرد")
                            .Popup(Form_Notify.Direction_Show.Right_To_Left, 1500);
            }
        }
        private void    ms_DatabaseService_Click   (object sender, EventArgs e)
        {
            try
            {
                new MS_Sql_Manage.MainForm().ShowDialog();
            }
            catch { }
        }
        private void    NzDailyNote_Click          (object sender, EventArgs e)
        {
            new FormDailyNote().Show(GeneralProvider.MainForm);
        }
        private void    ms_ChangePassword_Click    (object sender, EventArgs e)
        {
            new ChangePass().ShowDialog(GeneralProvider.MainForm);
        }

        private void    NzBill_Click                (object sender, EventArgs e)
        {
            var frm         = new FormBill();
            frm.MdiParent   = GeneralProvider.MainForm;
            frm.Show();
        }
        private void    NzSupport_Click             (object sender, EventArgs e)
        {
            var path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            if (File.Exists(path + @"\Support\Support.exe"))
                Process.Start(path + @"\Support\Support.exe");
            else
                MS_Message.Show("متاسفانه برنامه پشـتیبانی یافت نشد" +
                                "\n با تیم پشتیبانی تماس حاصل نمایید");

        }

        private void    NzDebitList_Click           (object sender, EventArgs e)
        {
            var frm         = new FormListDebit();
            frm.MdiParent   = GeneralProvider.MainForm;
            frm.Show();
        }
        private void    NzBank_Click                (object sender, EventArgs e)
        {
            var frm = new Form_Bank();
            frm.MdiParent = GeneralProvider.MainForm;
            frm.Show();
        }
        private void    NzCustomer_Click            (object sender, EventArgs e)
        {
            var frm         = new Form_ListPeople();
            frm.MdiParent   = GeneralProvider.MainForm;
            frm.Show();
        }
        private void    ms_EndYearOperations_Click  (object sender, EventArgs e)
        {
            var frm = new FormEndYear();
            frm.Show(GeneralProvider.MainForm);
        }

        private void    NzChartSummarry_Click       (object sender, EventArgs e)
        {
            var frm = new Form_ChartSummarry();
            frm.MdiParent = GeneralProvider.MainForm;
            frm.Show();
        }
        private void    NzDailyCircular_Click       (object sender, EventArgs e)
        {
            var frm         = new FormDialyCircular();
            frm.MdiParent   = GeneralProvider.MainForm;
            frm.Show();
        }
        private void    NzUpdateMenuItem_Click      (object sender, EventArgs e)
        {
            try
            {
                var app     = Path.GetDirectoryName(Application.ExecutablePath);
                app         = Path.Combine(app, "Updater.exe");

                if (File.Exists(app))
                {
                    Process p = new Process();
                    p.StartInfo.FileName = app;
                    p.Start();
                }
            }
            catch (Exception ex)
            {
                _log.Error(ex);
            }
           
        }
    }
}

