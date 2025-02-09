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
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control;
using MS_Control.DataBase.Con_Str;
using MS_Control.MainForms;
using NZ.General.Business;
using ShareLib.Models;
using ShareLib.Utils;
using ShareLib.ViewModel;

namespace NZ.General.WinForms.Misc
{
    public partial class FormLoading : Form_Mother_IRANSans
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        #endregion
        #region Fields
        private string                      ConStrDetail = ";Persist Security Info = True;MultipleActiveResultSets=true;App=NzResaaStore;";
        List<string> _ListSerial=new List<string>();
        #endregion
        #region Constructor
        public FormLoading()
        {
            InitializeComponent();
        }
        #endregion
        #region Methods
        private bool    FileExist              ()
        {
            if(!Config.FileExist())
                return InitFile();

            var config = Config.FromXML();

            ConnectionManager.ConStr = config.ConStr;
            SystemConstant.AllowMultipleDatabase = config.AllowMultipleDatabase;

            return true;
        }
        private bool    InitFile               ()
        {
            try
            {
                //var DbPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)
                //                + "\\Data\\ResaaStore_Primary.mdf";

                var path    = Path
                                .GetDirectoryName(Assembly.GetExecutingAssembly().Location)
                                + "\\AutoBack";

                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);

                MS_Message.Show("کاربر گرامی !" +
                                "\n فایل تنظیمات برنامه یافت نشد .لطفا تنضیمات را وارد کنید.");

                var Frm = new Form_Con_Str_New();
                if (Frm.ShowDialog() != DialogResult.OK)
                    return false;

                var Config = new Config()
                {
                    Location = path,
                    UserName = "1",
                    ConStr = Frm.MS_Con_str + ConStrDetail,
                    AllowMultipleDatabase = Frm.MultipleDatabase,
                };

                ConnectionManager.ConStr = Config.ConStr;
                SystemConstant.AllowMultipleDatabase = Config.AllowMultipleDatabase;
                Config.ToXml();
                //MS_Message.Show("تنظیمات ذخیره شده " +
                //                "\n\n " +
                //                "مجددا برنامه را اجرا کنید");

                return true;
                //if (File.Exists(DbPath))
                //{
                //    var attachedPath = "Server=.\\SQLNegin;AttachDbFilename=\""
                //                       + Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)
                //                       + "\\Data\\ResaaStore_Primary.mdf\";Database=DB_NzResaaStore;User ID=sa;Password=123456"
                //        ;

                //    var Config = new Config()
                //    {
                //        Location    = path,
                //        UserName    = "1",
                //        ConStr      = attachedPath + ConStrDetail,
                //    };

                //    ConnectionManager.ConStr = Config.ConStr;
                //    Config.ToXml();
                //    MS_Message.Show("تنظیمات ذخیره شده " +
                //                    "\n\n " +
                //                    "مجددا برنامه را اجرا کنید");
                //}
                //else
                //{


                //}
            }
            catch (Exception ex)
            {
                log.Error(ex);
                return false;
            }
        }
        private int     DataBaseExist          ()
        {
            try
            {
                //var Mgr = new UtilManage();
                //return Mgr.DataBaseExist();
                var listDb = GetDataBaseLists();
                if(listDb == null || !listDb.Any())
                {
                    MS_Message.Show("بانک اطلاعاتی یافت نشد", "خطا",null, MessageBoxButtons.OK);
                    return 0;
                }

                return listDb.Count();
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در لیست بانک اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
                return 0;
            }
        }
        private bool    Activation             ()
        {
            try
            {
                var Mgr         = new ReportManager();
                var ListActive  = Mgr.GetReport<Activation>(null, null);

                if (ListActive == null || !ListActive.Any())
                {
                    MS_Message.Show("کاربر گرامی " +
                                    "\n برنامه شما فعال سازی نشده است" +
                                    "\n لطفا اطلاعات فعال سازی خود را وارد کنید","فعال سازی برنامه");

                    new FormActivation().ShowDialog(this);
                    return false;
                }
                var Company = Mgr.GetItem<Company>(new {ID = true},null);

                if (Company == null)
                {
                    MS_Message.Show("کاربر گرامی !" +
                                    "\n اطلاعات فعال سازی برنامه شما ثبت نشده است" +
                                    "\n  با تیم پشتیبانی تماس بگیرید");
                    return false;
                }

                return CheckActivation(ListActive,Company);
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MS_Message.Show("خطا در روند بررسی صحت برنامه ",
                    "فعال سازی", 
                    ex.Message, 
                    MessageBoxButtons.OK);
                return false;
            }
        }
        private bool    CheckActivation        (IEnumerable<Activation> ListActive,Company Co)
        {
            try
            {
                var Cpu     = MS_Control.Hardware.Hardware.cpu_id().Trim();
                var MB      = MS_Control.Hardware.Hardware.mb_serial_number().Trim();
                var Serial  = Co.OriginalCode;

                foreach (var x in ListActive)
                {
                    var list =
                        x
                            .OriginalActiveString
                            .Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

                    if ((list.Contains(Cpu) || list.Contains(MB)) && list.Contains(Serial))
                        return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MS_Message.Show("خطا در خواندن اطلاعات سیستم ", 
                    "خطا", 
                    ex.Message, 
                    MessageBoxButtons.OK);
                return false;
            }
        }
        private IEnumerable<DataBaseList> 
                        GetDataBaseLists       ()
        {
            try
            {
                var Mgr = new ReportManager();
                return Mgr.GetReport<DataBaseList>(null, null);
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MS_Message.Show(" خطا در خواندن بانک اطلاعاتی",
                   "اطلاعات شرکت",
                   ex.Message,
                   MessageBoxButtons.OK);
                throw;
            }
        }
        private void    PopulateListDB         ()
        {
            SystemConstant.DBList.MSZ_ForEach(x => 
            {
                var ConStrBuilder               = new SqlConnectionStringBuilder(ConnectionManager.ConStr);
                ConStrBuilder.InitialCatalog    = x.DbName;
                ConnectionManager.ConStr        = ConStrBuilder.ToString();
                GetActive(x);
                //x.Registered = true;

            });
        }
        private void    GetActive              (DataBaseList Item)
        {
            //new ToolStripItemRenderEventArgs(this.CreateGraphics(),this.Menu.ite)

            try
            {
                var Mgr             = new ReportManager();
                var ListActive      = Mgr.GetReport<Activation>(null, null);

                if (ListActive == null || !ListActive.Any())
                {
                    Item.Registered     = false;
                    Item.Title          = "شرکت فعال سازی نشده";
                    return;
                }

                var Company = Mgr.GetItem<Company>(new { ID = true }, null);
                if (Company == null)
                    return;

                //var Cpu     = "BFEBFBFF000306A9";//MS_Control.Hardware.Hardware.cpu_id().Trim();
                //var MB      = "PCZUTA97V4S2WZ";//MS_Control.Hardware.Hardware.mb_serial_number().Trim();
                var Cpu     =  MS_Control.Hardware.Hardware.cpu_id().Trim();
                var MB      =  MS_Control.Hardware.Hardware.mb_serial_number().Trim();
                var Serial  = Company.OriginalCode;
                Item.Title  = Company.OriginalTitle;

                _ListSerial.Add(ListActive.First().OriginalActiveString);
                //string tmpSerial = "";
                foreach (var x in ListActive)
                {
                    var list =
                        x
                            .OriginalActiveString
                            .Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                    //tmpSerial = list[0];
                    //tmpSerial = x.OriginalActiveString;

                    if (list.Contains(Cpu) && list.Contains(MB) && list.Contains(Serial))
                        Item.Registered = true;
                }

                //_ListSerial.Add(tmpSerial);
            }
            catch (Exception ex)
            {
                log.Error(ex);
                Item.Registered = false;
            }

        }
        #endregion

        private void    FormLoading_Shown      (object sender, EventArgs e)
        {
            NzTitle.Text = @"بررسی تنظیمات برنامه ";
            NzProgress.Value = 30;
            Application.DoEvents();
            if (!FileExist())
            {
                DialogResult = DialogResult.Abort;
                return;
            }

            //=========================
            NzTitle.Text = @"اتصال به بانک اطلاعاتی";
            NzProgress.Value = 60;
            Application.DoEvents();
            SystemConstant.DbCount = DataBaseExist();
            if (SystemConstant.DbCount == 0)
            {
                DialogResult = DialogResult.Abort;
                return;
            }
            
            if (SystemConstant.DbCount > 1 && SystemConstant.AllowMultipleDatabase)
            {
                SystemConstant.DBList = GetDataBaseLists();
                PopulateListDB();
                if (_ListSerial.GroupBy(x => x).Any(x => x.Count() > 1) && !SystemConstant.OurAccount)
                {
                    MS_Message.Show("در سیستم شما تعدادی سریال تکراری وجود دارد" +
                                    "\n با تیم پشتیبانی تماس بگیرید.");
                    DialogResult = DialogResult.Abort;
                    return;
                }
            }
            else
            {
                NzTitle.Text = @"بررسی فعال سازی برنامه";
                NzProgress.Value = 100;

                if (!SystemConstant.IsDemo && !SystemConstant.OurAccount)
                    if (!Activation())
                    {
                        MS_Message.Show("کد فعال سازی شما نامعتبر است");
                        DialogResult = DialogResult.Abort;
                        return;
                    }
            }
            //=========================
            DialogResult = DialogResult.OK;
        }
    }
}
