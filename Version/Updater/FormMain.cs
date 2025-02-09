using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyHttp.Http;
using MS_Control.MainForms;
using ShareLib.Utils;
using ShareLib.ViewModel;
using Updater.Model;
using Updater.Service;

namespace Updater
{
    public partial class FormMain : Form_Mother_IRANSans
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
        private const string    APPLICATION_NAME    = "NZ.Resaa.Store.exe";
#if (DEBUG == true)
        private const string BASE_URL = "https://localhost:44391/api";
        private const short APPLICATION_CODE = 2;

#else
        private const string BASE_URL = "https://api.neginzagros.ir/api";
        private const short     APPLICATION_CODE    = 1;

#endif

        //private const string    BASE_URL            = "https://localhost:44391/api";
        //private const string BASE_URL = "https://api.neginzagros.ir/api";
        public FormMain()
        {
            InitializeComponent();
        }

        private void LoadSettings()
        {
            this.Location = new Point
            (
                Screen.PrimaryScreen.WorkingArea.Right - this.Width,
                Screen.PrimaryScreen.WorkingArea.Bottom - this.Height
            );

            if (!Config.FileExist())
                return;

            var config = Config.FromXML();

            ConnectionManager.ConStr = config.ConStr;

        }
        private async void FormMain_Shown(object sender, EventArgs e)
        {
            try
            {
                //https://localhost:44321/

                var form = new/* Nz.Domain.Model.ValueObject.SendSmsParametter()*/
                {
                    Mobile = 9148702984,
                    TemplateID = 8636,
                    UserName = "971219",
                    Password = "darolehsan_1#", 
                    TemplateParams = new List<object>()
                    {
                        new { Name =  "PersonName", Value = "فثسف"},
                        new { Name =  "Mount", Value = "20.22"},
                        new { Name =  "Date", Value = "13400/01011"},
                        new { Name =  "CharityName", Value = "آزمایش"},
                       
                    }
                };

                var http = new EasyHttp.Http.HttpClient();
                var response = http.Post($"https://localhost:44321/api/SmsService", form, HttpContentTypes.ApplicationJson);
                var result1 = response.StaticBody<MessageContract>();

                //return result;


                return;
                this.Validate();
                this.Refresh();
                //1.
                LoadSettings();

                //2.
                var service = new ResetService();

                //3.
                var serial  = service.GetSerial();
                if (string.IsNullOrWhiteSpace(serial))
                {
                    NzMessage.SafeSetProperty(nameof(NzMessage.Text),"امکان دریافت سریال برنامه وجود ندارد");
                    _log.Error("امکان دریافت سریال برنامه وجود ندارد");
                    
                    timer1.Start();
                    return;
                }

                //4.
                var versino = service.GetVersion();
                if (string.IsNullOrWhiteSpace(versino))
                {
                    NzMessage.SafeSetProperty(nameof(NzMessage.Text), "امکان دریافت نسخه برنامه وجود ندارد");
                    _log.Error("امکان دریافت نسخه برنامه وجود ندارد");
                    timer1.Start();
                    return;
                }

                //5. 
                var ChangeLogResult = service.GetChangeLog(APPLICATION_CODE, BASE_URL);
                if (ChangeLogResult == null)
                {
                    NzMessage.SafeSetProperty(nameof(NzMessage.Text), "امکان دریافت تغییرات برنامه وجود ندارد");
                    _log.Error("امکان دریافت تغییرات برنامه وجود ندارد");
                    timer1.Start();
                    return;
                }
                else if(!ChangeLogResult.IsSuccess)
                {
                    NzMessage.SafeSetProperty(nameof(NzMessage.Text),ChangeLogResult.Message);
                    _log.Error(ChangeLogResult.Message);
                    timer1.Start();
                    return;
                }

                //6.
                var hasUpdate = service.HasUpdate(ChangeLogResult.Data, versino);
                if (!hasUpdate)
                {
                    NzMessage.SafeSetProperty(nameof(NzMessage.Text), "برنامه شما شامل آخرین نسخه می باشد");
                    timer1.Start();
                    return;
                }

                //7.
                var hasCredit = service.HasCredit(BASE_URL,serial);
                if (hasCredit == null)
                {
                    NzMessage.SafeSetProperty(nameof(NzMessage.Text), "امکان بروزرسانی وجود ندارد");
                    _log.Info("بررسی وجود اعتبار وجود ندارد");
                    timer1.Start();
                    return;
                } 
                if (!hasCredit.IsSuccess)
                {
                    NzMessage.SafeSetProperty(nameof(NzMessage.Text), "بروزرسانی جدیدی از برنامه موجود است \n\r ولی مهلت پشتیبانی شما به پایان رسیده است");
                    _log.Info("مهلت پشتیبانی شما به پایان رسیده است");
                    timer1.Start();
                    return;
                }

                //8.
                var result = new FormWarning(versino, ChangeLogResult.Data.Version).ShowDialog(this);
                if (result != DialogResult.OK)
                {
                    _log.Info("انصراف کاربر از بروز رسانی");
                    timer1.Start();
                    return;
                }

                //9.
                NzMessage.SafeSetProperty(nameof(NzMessage.Text), "در حال دریافت فایل بروزرسانی");
                var download = new FileDownlaod();

                NzProgress.SafeSetProperty(nameof(NzProgress.Style), ProgressBarStyle.Continuous);
                NzProgress.SafeSetProperty(nameof(NzProgress.Value),0);
                
                download.DownloadFile
                (
                    $@"{BASE_URL}/UpdateApp/DownlaodFile?Code={APPLICATION_CODE}&Serial={serial}",
                    Path.GetDirectoryName(Application.ExecutablePath)
                );

                //10.
                download.DownloadProgressChangedEventHandler += (o, args) =>
                {
                    NzProgress.SafeSetProperty      (nameof(NzProgress.Value),args.ProgressPercentage);
                    NzPercentage.SafeSetProperty    (nameof(NzPercentage.Text),args.ProgressPercentage.ToString()+" % ");
                };
                //11.
                download.AsyncCompletedEventHandler += (o, args) =>
                {
                    var ApplicationLocation = Path.Combine(Path.GetDirectoryName(Application.ExecutablePath), APPLICATION_NAME);

                    if (ExtractService.IsRunnig(ApplicationLocation))
                    {
                        var r = new FormRunning(ApplicationLocation).ShowDialog(this);
                        if (r != DialogResult.OK)
                        {
                            NzMessage.SafeSetProperty(nameof(NzMessage.Text), "انصراف کاربر از بروزرسانی");
                            _log.Info("انصراف کاربر از بروزرسانی");
                            timer1.Start();
                            return;
                        }
                    }

                    //12.
                    var extract = new ExtractService();
                    var resultExtract = extract.Extract(download.FileLocation);

                    //13.
                    if (resultExtract == null)
                    {
                        NzMessage.SafeSetProperty(nameof(NzMessage.Text), "خطا بارگذاری فایل بروزرسانی رخ داده است");
                        _log.Info("خطا بارگذاری فایل بروزرسانی رخ داده است");
                        timer1.Start();
                        return;
                    }

                    if (!resultExtract.IsSuccess)
                    {
                        NzMessage.SafeSetProperty(nameof(NzMessage.Text), resultExtract.Message);
                        _log.Info(resultExtract.Message);
                        timer1.Start();
                        return;
                    }

                    NzMessage.SafeSetProperty(nameof(NzMessage.Text), "بروزرسانی با موفقیت انجام گرفت");
                    timer1.Start();
                };

            }
            catch (Exception ex)
            {
                _log.Error(ex);
                timer1.Start();

            }
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
