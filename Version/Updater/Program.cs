using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Updater
{
    internal static class Program
    {
        #region Logging
        private static readonly log4net.ILog _log =
            log4net
                .LogManager
                .GetLogger
                    (MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormMain());
            }
            catch (Exception ex)
            {
                _log.Error(ex);
            }
        }
    }
}
