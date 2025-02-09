using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS_Control;
using ShareLib.Utils;

namespace ShareLib.Models
{
    public class Activation
    {

        public short    ID              { get; set; }
        [Required]
        public string   ActiveString    { get; set; }
        [Required]
        public string   LastVersion     { get; set; }
        [Required]
        public string   ModuleList      { get; set; }

        [NotMapped]
        public string   OriginalActiveString  => CryptographyHelper.Decrypt(ActiveString);
        [NotMapped]
        public string   OriginalLastVersion   
            {
            get => MS_Util.MS_Hash_To_Str               (this.LastVersion, SystemConstant.NzPasswordHash);
            set => LastVersion = MS_Util.MS_Str_To_Hash (value, SystemConstant.NzPasswordHash); 
        }


    }
}
