using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyHttp.Http;
using NZ.General.Business;
using ShareLib.Models;
using ShareLib.Utils;
using ShareLib.ViewModel;
using Updater.Model;

namespace Updater.Service
{
    internal class ResetService
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
        public string                       GetSerial           ()
        {
            try
            {
                var Mgr     = new ReportManager();
                var Company = Mgr.GetItem<Company>(new { ID = true }, null);
                return Company.OriginalCode;
            }
            catch (Exception ex)
            {
                return string.Empty;
            }
        }
        public string                       GetVersion          ()
        {
            try
            {
                var dir         = Path.GetDirectoryName(Application.ExecutablePath);
                var filePath    = Path.Combine(dir, "NZ.Resaa.Store.exe");
                return System.Diagnostics.FileVersionInfo.GetVersionInfo(filePath).FileVersion;

            }
            catch (Exception e)
            {

                return string.Empty;
            }
        }
        public MessageResult<ChangeLog>     GetChangeLog        (short Code,string BaseUrl)
        {
            try
            {
                var data = new 
                {
                    Code,
                };
                var http        = new HttpClient();
                
                //var response    = http.Get($"{BaseUrl}/UpdateApp", data);
                var response    = http.Post($"{BaseUrl}/UpdateApp", data, HttpContentTypes.ApplicationXWwwFormUrlEncoded);
                var result      = response.StaticBody<MessageResult<ChangeLog>>();

                return result;
            }
            catch (Exception ex)
            {
                _log.Error(ex);
                return new MessageResult<ChangeLog>
                    (
                        false,
                        ResultStatusCode.ServerError,
                        null,
                        "امکان اتصال به سامانه بروزرسانی وجود ندارد"
                    );
            }

        }
        public bool                         HasUpdate           (ChangeLog log,string Version)
        {
            try
            {
                return string.CompareOrdinal(log.Version, Version) >= 1;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public MessageResult<bool>          HasCredit           (string BaseUrl,string Serial)
        {
            try
            {
                var data = new
                {
                    Serial,
                };
                var http            = new HttpClient(); 
                var response        = http.Get($"{BaseUrl}/UpdateApp/HasCredit", data);
                var result          = response.StaticBody<MessageResult<bool>>();
                return result;
            }
            catch (Exception ex)
            {
                _log.Error(ex);
                return null;
            }
        }
    }
}
