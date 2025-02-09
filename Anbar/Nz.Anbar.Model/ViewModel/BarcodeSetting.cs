using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Utils;
using ShareLib.ViewModel;

namespace Nz.Anbar.Model.ViewModel
{
    public class BarcodeSetting
    {
        private static string   FileName    = "Barcode.Nz";
        public long             MiscID      { get; set; }

        public void ToXml()
        {
            var path    = Path
                           .GetDirectoryName(Assembly.GetExecutingAssembly().Location)
                            + "\\" + FileName;

            var Str     = this.ToXmlString();
            Str         = MS_Control.MS_Util.MS_Str_To_Hash(Str, SystemConstant.NzPasswordHash);
            File.WriteAllText(path, Str);
        }
        public static T FromXML<T>()
        {
            if (!FileExist())
                return default(T);

            var path    = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var str     = File.ReadAllText(path + "\\" + FileName);
            str         = MS_Control.MS_Util.MS_Hash_To_Str(str, SystemConstant.NzPasswordHash);
            return Extentions.FromXmlString<T>(str);
        }

        public static bool FileExist()
        {
            return File.Exists(Path
                                   .GetDirectoryName(Assembly.GetExecutingAssembly().Location)
                               + "\\" + FileName);
        }
    }
}
