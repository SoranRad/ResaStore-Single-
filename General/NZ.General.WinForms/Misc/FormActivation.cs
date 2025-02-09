using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
//using System.ServiceModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyHttp.Http;
using MS_Control;
using MS_Control.MainForms;
using MS_Control.Tarikh;
using NZ.General.Business;
//using RestSharp;
using ShareLib.Models;
using ShareLib.Utils;
using ShareLib.ViewModel;

namespace NZ.General.WinForms.Misc
{
    public partial class FormActivation : Form_Mother_IRANSans
    {

        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private const string BASE_URL = "https://api.neginzagros.ir";
        #endregion
        #region Constructor
        public FormActivation       ()
        {
            InitializeComponent();
        }
        #endregion
        #region Methods
        private bool IsOK               ()
        {
            if (string.IsNullOrEmpty(NzSerial.Text.Trim()))
            {
                mS_Notify1.Show(NzSerial);
                NzSerial.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(NzTitle.Text.Trim()))
            {
                mS_Notify1.Show(NzTitle);
                NzTitle.Focus();
                return false;
            }
            if (!NzStartTarix.MS_Tarikh.HasValue)
            {
                mS_Notify1.Show(NzStartTarix);
                NzStartTarix.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(NzMobile.Text.Trim()))
            {
                mS_Notify1.Show(NzMobile);
                NzMobile.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(NzEmail.Text.Trim()))
            {
                mS_Notify1.Show(NzEmail);
                NzEmail.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(NzAddress.Text.Trim()))
            {
                mS_Notify1.Show(NzAddress);
                NzAddress.Focus();
                return false;
            }
            //try
            //{
            //    using (var client = new WebClient())
            //    using (client.OpenRead("http://clients3.google.com/generate_204"))
            //    {
            //        //return true;
            //    }
            //}
            //catch
            //{
            //    MS_Message.Show("ارتباط اینترنت شما برقرار نیست" +
            //                    "\n اینترنت خود را چک کنید ");
            //    return false;
            //}
            return true;
        }

        private void Init               (ActivationResultDto Msg)
        {
            try
            {
                SaveActivation  (Msg);
                AddInitTables   (Msg);

                MS_Message.Show("کاربر گرامی !" +
                                "\n برنامه شما با موفقیت فعال سازی شد " +
                                "\n\n با نام کاربری : 1 " +
                                "\n کلمه عبور : 1" +
                                "\n\n می توانید وارد سیستم شوید");

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MS_Message.Show("خطا در ثبت فعال سازی برنامه", "خطای ثبت",
                    ex.Message,
                    MessageBoxButtons.OK);
            }
        }
        private void SaveActivation     (ActivationResultDto Msg)
        {
                var Mgr = new Manager();
                var Act = new Activation()
                {
                     ActiveString   = Msg.MSG,
                     LastVersion    = "1.0.0",
                     ModuleList     = "1,2,4,5,6",
                };

                Mgr.Save(Act);
        }
        private void AddInitTables      (ActivationResultDto Msg)
        {
                var Year        = NzStartTarix.MS_Tarikh.Value._Sal;
                var StartYear   = new MS_Structure_Shamsi(Year, 1, 1).ToDatetime().Date;
                var EndYear     = StartYear.AddYears(1).AddDays(-1).Date;
                var Mgr         = new ReportManager();
                Mgr.GetItem<InitRegister>(new
                {
                    Msg.Serial,
                    Msg.StartDate,
                    Msg.Title,

                    Address = NzAddress.Text.Trim(),
                    Mobile  = NzMobile.Text.Trim().Replace(" ", string.Empty),
                    Email   = NzEmail.Text.Trim(),

                    Year,
                    StartYear,
                    EndYear,
                }, null);
        }

        private void        SaveActivateRequest         (IEnumerable<ActivationResultDto> ActiveList)
        {
            if (ActiveList == null || !ActiveList.Any())
            {
                MS_Message.Show("کد وارد شده معتبر نمی باشد", "خطا", MessageBoxButtons.OK);
                return;
            }
            var Mgr     = new Manager();
            var RMgr    = new ReportManager();
            var List    = RMgr.GetReport<Activation>(null, null);

            foreach (var activation in List.ToList())
                Mgr.Delete(activation);

            ActiveList.MSZ_ForEach(x =>
            {
                var Act = new Activation()
                {
                    ActiveString = x.MSG,
                    LastVersion = "1.0.0",
                    ModuleList = "1,2,4,5,6",
                };

                Mgr.Save(Act);
            });

            var item    = ActiveList.FirstOrDefault();
            var Company     = RMgr.GetItem<Company>(new { ID = true }, null);

            if (Company == null)
            {
                var newCompany = new Company()
                {
                    ID      = true,
                    Code    = item.Serial?.Trim(),
                    tarikh  = item.StartDate,
                    title   = item.Title?.Trim(),
                    address = item.Address?.Trim(),
                    email   = item.Email?.Trim(),
                    mobile  = item.Mobile?.Trim(),
                };

                Mgr.Save(newCompany);
            }
            //============================
            var listUser = Mgr.GetList<User>();
            if (!listUser.Any())
            {
                var user  = new User()
                {
                    Code                    = 1,
                    kind                    = 2,
                    is_disable              = false,
                    picture                 = null,
                    title                   = "مدیر سیستم",
                    user_name               = "1",
                    dastressi               = "pJPjwGrN+M8PG2x98iPnBCiLnvi+0v4rU7xmzWJ6Hgc=",
                    OriginalPassword        = "1",
                    OriginalDefaultPassword = "123",
                };
                Mgr.Save(user);
            }
            //============================
            var ListYear = Mgr.GetList<Year>();
            if (!ListYear.Any())
            {
                var Co      = RMgr.GetItem<Company>(new { ID = true }, null);
                var StrDate = new MS_Structure_Shamsi(Co.OriginalTarix);
                var Sal     = Convert.ToInt16(StrDate._Sal);

                var Year = new Year()
                {
                    Salmali     = Convert.ToInt16(StrDate._Sal),
                    StartDate   = new MS_Structure_Shamsi(Sal,1,1).ToDatetime().Date,
                    EndDate     = new MS_Structure_Shamsi(Sal+1, 1, 1).AddDays(-1).ToDatetime().Date,
                    is_close    = false,
                    Money       = "ریال",
                    darsad_arzesh_afzude = 0,
                };

                Mgr.Save(Year);
            }
            
            MS_Message.Show("کاربر گرامی !" + "\n برنامه شما با موفقیت فعال سازی شد ");
            DialogResult = DialogResult.OK;
        }
        #endregion
        private async void  NzActive_Click              (object sender, EventArgs e)
        {
            try
            {
                if (!IsOK())
                    return;

                NzActive.SafeSetProperty            (nameof(NzActive.Enabled), false);
                NzGetActive.SafeSetProperty         (nameof(NzGetActive.Enabled), false);
                ms_restor_datadb.SafeSetProperty    (nameof(ms_restor_datadb.Enabled), false);
                NzLoading1.SafeSetProperty          (nameof(NzLoading1.Visible), true);
                NzLoading2.SafeSetProperty          (nameof(NzLoading1.Visible), false);

                var data = new RegisterDto
                {
                    Serial      = NzSerial.Text.Trim().Replace(" ", string.Empty),
                    Address     = NzAddress.Text.Trim(),
                    CPU         = MS_Control.Hardware.Hardware.cpu_id().Trim(),
                    DateStart   = NzStartTarix.MS_Tarikh.Value.ToDatetime().Date,
                    Email       = NzEmail.Text.Trim(),
                    MB          = MS_Control.Hardware.Hardware.mb_serial_number().Trim(),
                    Mobile      = NzMobile.Text.Trim().Replace(" ", string.Empty),
                    Title       = NzTitle.Text.Trim()
                };
                var http = new HttpClient();

                //var response = http.Post("https://localhost:44391/api/Activation", data, HttpContentTypes.ApplicationXWwwFormUrlEncoded);
                var response = http.Post($"{BASE_URL}/api/Activation", data, HttpContentTypes.ApplicationXWwwFormUrlEncoded);
                var result      = response.StaticBody<MessageResult<ActivationResultDto>>();

                if (result == null)
                {
                    MS_Message.Show("خطا در فعال سازی برنامه  رخ داده است با مدیریت تماس بگیرید", "خطا", MessageBoxButtons.OK);
                    return;
                }

                if(!result.IsSuccess)
                    MS_Message.Show(result.Message, "خطا", MessageBoxButtons.OK);
                else
                {
                    Init(result.Data);

                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MS_Message.Show("خطا در فعال سازی برنامه ", "خطا", ex.Message, MessageBoxButtons.OK);

            }
            finally
            {
                NzActive.SafeSetProperty            (nameof(NzActive.Enabled), true);
                NzGetActive.SafeSetProperty         (nameof(NzGetActive.Enabled), true);
                ms_restor_datadb.SafeSetProperty    (nameof(ms_restor_datadb.Enabled), true);
                
                NzLoading1.SafeSetProperty          (nameof(NzLoading1.Visible), false);
                NzLoading2.SafeSetProperty          (nameof(NzLoading1.Visible), false);

            }
        }
        private void        NzSerial_Enter              (object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(NzSerial.Text.Trim()))
            {
                NzSerial.TextBox.SelectionStart = 0;
            }
        }

        private async void  NzGetActive_Click           (object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(NzSerial2.Text.Trim()))
                {
                    mS_Notify1.Show(NzSerial2);
                    NzSerial2.Focus();
                    return;
                }

                NzActive.SafeSetProperty(nameof(NzActive.Enabled), false);
                NzGetActive.SafeSetProperty(nameof(NzGetActive.Enabled), false);
                ms_restor_datadb.SafeSetProperty(nameof(ms_restor_datadb.Enabled), false);

                NzLoading1.SafeSetProperty(nameof(NzLoading1.Visible), false);
                NzLoading2.SafeSetProperty(nameof(NzLoading1.Visible), true);

                //var rest = RefitExtention.GetRestService<IActivationService>();
                var data = new SerialActivatedDto
                {
                    Cpu         = MS_Control.Hardware.Hardware.cpu_id().Trim(),
                    MB          = MS_Control.Hardware.Hardware.mb_serial_number().Trim(),
                    Serial      = NzSerial2.Text.Trim().Replace(" ", string.Empty),
                };

                var http        = new HttpClient();
                var response    = http.Get($"{BASE_URL}/api/Activation", data);
                //var response    = http.Get("https://localhost:44391/api/Activation", data);
                var result      = response.StaticBody<MessageResult<IEnumerable<ActivationResultDto>>>();


                if (result == null)
                {
                    MS_Message.Show("خطا در فعال سازی برنامه رخ داده است با مدیریت تماس بگیرید", "خطا", MessageBoxButtons.OK);
                    return;
                }

                if (!result.IsSuccess)
                    MS_Message.Show(result.Message, "خطا", MessageBoxButtons.OK);
                else
                    SaveActivateRequest(result.Data);

                MS_Message.Show("کاربر گرامی !" + "\n برنامه شما با موفقیت فعال سازی شد ");

                DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                log.Error(ex);
                MS_Message.Show(
                    "خطا در فعال سازی برنامه",
                    "خطا",
                    ex.Message,
                    MessageBoxButtons.OK);
            }
            finally
            {
                NzActive.SafeSetProperty            (nameof(NzActive.Enabled),          true);
                NzGetActive.SafeSetProperty         (nameof(NzGetActive.Enabled),       true);
                ms_restor_datadb.SafeSetProperty    (nameof(ms_restor_datadb.Enabled),  true);

                NzLoading1.SafeSetProperty          (nameof(NzLoading1.Visible),        false);
                NzLoading2.SafeSetProperty          (nameof(NzLoading1.Visible),        false);

            }
            //BasicHttpBinding basicHttpbinding = new BasicHttpBinding(BasicHttpSecurityMode.None);
            //basicHttpbinding.Name = "DockersWSPortBinding";
            //basicHttpbinding.Security.Transport.ClientCredentialType = HttpClientCredentialType.None;
            //basicHttpbinding.Security.Message.ClientCredentialType = BasicHttpMessageCredentialType.UserName;
            //EndpointAddress endpointAddress = new EndpointAddress(@"http://register.neginzagros.ir/Activation.asmx");
            ////EndpointAddress endpointAddress = new EndpointAddress(@"http://localhost:60249/Activation.asmx");


            //using (var Service = new ActivationSoapClient(basicHttpbinding, endpointAddress))
            //{
            //var msg = Service.GetCode
            //            (   NzSerial2.Text.Trim().Replace(" ", string.Empty),
            //                MS_Control.Hardware.Hardware.cpu_id(),
            //                MS_Control.Hardware.Hardware.mb_serial_number()
            //            );



            //if (msg == null)
            //{
            //    MS_Message.Show(
            //        "کد وارد شده معتبر نمی باشد",
            //        "خطا",
            //        MessageBoxButtons.OK);
            //    return;
            //}

            //if (msg.Length <= 0)
            //{
            //    MS_Message.Show(
            //        "کد وارد شده معتبر نمی باشد",
            //        "خطا",
            //        MessageBoxButtons.OK);
            //    return;
            //}

            //var item = msg.FirstOrDefault();
            //if (!item.Result)
            //{
            //    MS_Message.Show(
            //        item.MSG,
            //        "خطا",
            //        MessageBoxButtons.OK);
            //    return;
            //}
            ////================================

            //var Mgr     = new Manager();
            //var RMgr    = new ReportManager();
            //var List    = RMgr.GetReport<Activation>(null, null);

            //foreach (var activation in List.ToList())
            //    Mgr.Delete(activation);

            //msg.MSZ_ForEach(x =>
            //{
            //    //if (List.Any(y => y.ActiveString == x.MSG))
            //    //    return;


            //    var Act = new Activation()
            //    {
            //        ActiveString    = x.MSG,
            //        LastVersion     = "1.0.0",
            //        ModuleList      = "1,2,4,5,6",
            //    };

            //    Mgr.Save(Act);
            //});

            //var Com = RMgr.GetItem<Company>(new {ID = true}, null);
            //if (Com == null)
            //{
            //    var Co = new Company()
            //    {
            //        ID      = true,
            //        Code    = item.Serial,
            //        tarikh  = item.StartDate,
            //        title   = item.Title,
            //        address = item.Address,
            //        email   = item.Email,
            //        mobile  = item.Mobile,
            //    };

            //    Mgr.Save(Co);
            //}
            ////============================
            //var listUser = Mgr.GetList<User>();
            //if (!listUser.Any())
            //{
            //    var user  = new User()
            //    {
            //        Code                    = 1,
            //        kind                    = 2,
            //        is_disable              = false,
            //        picture                 = null,
            //        title                   = "مدیر سیستم",
            //        user_name               = "1",
            //        dastressi               = //"X0woB2qleyjjky2aajyXpvC2Oq3AtyDoW/tJdZ0kfyI=",
            //                                    "pJPjwGrN+M8PG2x98iPnBCiLnvi+0v4rU7xmzWJ6Hgc=",
            //        OriginalPassword        = "1",
            //        OriginalDefaultPassword = "123",
            //    };
            //    Mgr.Save(user);
            //}
            ////============================
            //var ListYear = Mgr.GetList<Year>();
            //if (!ListYear.Any())
            //{
            //    var Co      = RMgr.GetItem<Company>(new { ID = true }, null);
            //    var StrDate = new MS_Structure_Shamsi(Co.OriginalTarix);
            //    var Sal     = Convert.ToInt16(StrDate._Sal);

            //    var Year= new Year()
            //    {
            //        Salmali     = Convert.ToInt16(StrDate._Sal),
            //        StartDate   = new MS_Structure_Shamsi(Sal,1,1).ToDatetime().Date,
            //        EndDate     = new MS_Structure_Shamsi(Sal+1, 1, 1).AddDays(-1).ToDatetime().Date,
            //        is_close    = false,
            //        Money       = "ریال",
            //        darsad_arzesh_afzude = 0,
            //    };

            //    Mgr.Save(Year);
            //}
            //============================
            //        MS_Message.Show("کاربر گرامی !" +
            //                        "\n برنامه شما با موفقیت فعال سازی شد ");

            //        DialogResult = DialogResult.OK;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    log.Error(ex);
            //    MS_Message.Show(
            //        "خطا در فعال سازی برنامه", 
            //        "خطا", 
            //        ex.Message, 
            //        MessageBoxButtons.OK);
            //}
        }
        private void        NzSerial2_Click             (object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NzSerial2.Text.Trim()))
            {
                NzSerial2.TextBox.SelectionStart = 0;
            }
        }

        private void        ms_DataRestore_ButtonClick  (object sender, EventArgs e)
        {
            var conn = new Manager().Connection;
            var builder = new SqlConnectionStringBuilder(conn.ConnectionString);


            var frm = new MS_Control.DataBase.SqlFolderBrowse.Form_Restore(builder.DataSource, builder.UserID, builder.Password);
            var result = frm.ShowDialog();

            if (result == DialogResult.OK)
                ms_DataRestore.Text = frm.SelectedPath;
        }
        private void        ms_restor_datadb_Click      (object sender, EventArgs e)
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

                new UtilManage().RestoreDB(ms_DataRestore.Text);
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

        private void        NzMobile_Click              (object sender, EventArgs e)
        {
            if(NzMobile.Text.Trim()=="09")
                NzMobile.TextBox.SelectionStart = 2;
        }

        private void        FormActivation_KeyUp        (object sender, KeyEventArgs e)
        {
            if (e.Alt && e.Control && e.Shift && e.KeyCode == Keys.F10)
            {
                nzCpu.Text  = MS_Control.Hardware.Hardware.cpu_id();
                NzMB.Text   = MS_Control.Hardware.Hardware.mb_serial_number();
            }
        }
        private void        FormActivation_Load         (object sender, EventArgs e)
        {
            Tab_Control_Main.SelectedIndex = 2;
        }
    }
}
