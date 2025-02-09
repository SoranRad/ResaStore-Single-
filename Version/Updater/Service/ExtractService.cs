using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShareLib.ViewModel;

namespace Updater.Service
{
    public class ExtractService
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

        public MessageResult Extract(string FilePath)
        {
            try
            {
                Process p   = new Process();
                var ext     = Path.GetExtension(FilePath);

                if(ext.EndsWith("exe"))
                    p.StartInfo.FileName = FilePath;
                else
                {
                    p.StartInfo.FileName  = @"unrar";
                    p.StartInfo.Arguments = " e -y " + FilePath + " " + Path.GetDirectoryName(FilePath);
                }

                p.Start();
                return new MessageResult(true, ResultStatusCode.Success);
            }
            catch (Exception ex)
            {
                _log.Error(ex);
                return null;
            }
        }

        public static bool IsRunnig(string FileLocation)
        {
            var ProcessName = Path.GetFileNameWithoutExtension(FileLocation);
            var location    = Path.GetDirectoryName(FileLocation).ToLower();
            var isRunning   = Process
                                    .GetProcessesByName(ProcessName.ToLower().Trim())
                                    .Where(x => x.MainModule.FileName.ToLower().StartsWith(location.ToLower().Trim()))
                                    .FirstOrDefault();

            return isRunning != null;

        }
        
    }
}
