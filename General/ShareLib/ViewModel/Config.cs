using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ShareLib.Utils;

namespace ShareLib.ViewModel
{
    public class Config
    {
        private static string FileName = "Setting.Nz";

        public string UserName      { get; set; }
        public string Location      { get; set; }
        public string ConStr        { get; set; }
        public bool   AllowMultipleDatabase { get; set; }


        public void             ToXml       ()
        {
            var path = Path
                        .GetDirectoryName(Assembly.GetExecutingAssembly().Location)
                        + "\\" + FileName;

            var Str = this.ToXmlString();
            Str     = MS_Control.MS_Util.MS_Str_To_Hash(Str, SystemConstant.NzPasswordHash);
            File.WriteAllText(path, Str);
        }
        public static Config    FromXML     ()
        {
            var path    = Path.GetDirectoryName (Assembly.GetExecutingAssembly().Location);
            var str     = File.ReadAllText      (path + "\\" + FileName);
            str         = MS_Control.MS_Util.MS_Hash_To_Str(str, SystemConstant.NzPasswordHash);
            return Extentions.FromXmlString<Config>(str);
        }
        public static bool      FileExist   ()
        {
            return File.Exists(Path
                                   .GetDirectoryName(Assembly.GetExecutingAssembly().Location)
                               + "\\" + FileName);
        }

    }
}
