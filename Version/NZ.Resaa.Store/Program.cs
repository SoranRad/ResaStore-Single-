using System;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using MS_Control;
using ShareLib.Interfaces;
using ShareLib.Utils;

namespace NZ.Resaa.Store
{
    static class Program
    {
        public static string A = 
@"
 اللَّهُ لَا إِلَٰهَ إِلَّا هُوَ الْحَيُّ الْقَيُّومُ 
 لَا تَأْخُذُهُ سِنَةٌ وَلَا نَوْمٌ 
 لَّهُ مَا فِي السَّمَاوَاتِ وَمَا فِي الْأَرْضِ
 مَن ذَا الَّذِي يَشْفَعُ عِندَهُ إِلَّا بِإِذْنِهِ
 يَعْلَمُ مَا بَيْنَ أَيْدِيهِمْ وَمَا خَلْفَهُمْ
 وَلَا يُحِيطُونَ بِشَيْءٍ مِّنْ عِلْمِهِ إِلَّا بِمَا شَاءَ 
 وَسِعَ كُرْسِيُّهُ السَّمَاوَاتِ وَالْأَرْضَ 
 وَلَا يَئُودُهُ حِفْظُهُمَا 
 وَهُوَ الْعَلِيُّ الْعَظِيمُ
";

        #region Logging
        private static readonly log4net.ILog _log =
            log4net
                .LogManager
                .GetLogger
                    (MethodBase.GetCurrentMethod().DeclaringType);
        #endregion

        [STAThread]
        static void Main()
        {
            try
            {
                //_log.Info("===start===\n");



                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                //===================
                //_log.Info("===set visual===\n");

                DevComponents.DotNetBar.StyleManager.ColorTint          = System.Drawing.Color.RoyalBlue;
                DevComponents.DotNetBar.StyleManager.Style              = DevComponents.DotNetBar.eStyle.Office2010Blue;
                ToolStripManager.Renderer                               = new MS_Control.Office2007Renderer.Office2007Renderer();
                MS_Control.MainForms.Form_Mother_IRANSans.MS_Icon_Form  = global::MS_Resource.GlobalResources.Logo_Resaa;
                GetVersion();

                //_log.Info("===set persian numeric===\n");

                MS_Util.MS_Set_Lang_To_Farsi     ();
                MS_Util.MS_Set_Currency_Setting  ();

                //_log.Info("===Load general dll===\n");

                LoadGeneral();

                //_log.Info("===show loading forms===\n");

                if (Form_Factory.LoadingForm?.ShowDialog() == DialogResult.OK)
                    if(Form_Factory.LoginForm.ShowDialog() == DialogResult.OK)
                        Application.Run(new Form_Resaa_Store());
            }
            catch (Exception ex)
            {
                _log.Error(ex);
            }
        }
        private static void    GetVersion                  ()
        { 
            var assemblyLocation = Assembly.GetExecutingAssembly().Location;
            SystemConstant.Version = System.Diagnostics.FileVersionInfo.GetVersionInfo(assemblyLocation).FileVersion;
        }
        private static void LoadGeneral()
        {
            //SystemConstant.IsDemo = true;
            //SystemConstant.DemoCount = 140;
            SystemConstant.OurAccount = true;


            var asm         = Assembly.LoadFrom("NZ.General.WinForms.dll");
            var i           = asm
                                .GetTypes()
                                .FirstOrDefault(x => x.GetInterfaces().Contains(typeof(IEntryProvider)));

            var costruc     = i.GetConstructors();
            var item        = costruc.FirstOrDefault();
            object c        = item.Invoke(null);
            
            Form_Factory._Form_Factory_General = c as IEntryProvider;
            Form_Factory.SystemList.Add(Form_Factory._Form_Factory_General);

            

        }
    }
}
