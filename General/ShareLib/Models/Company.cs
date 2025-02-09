using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Utils;

namespace ShareLib.Models
{
    public class Company
    {
        public bool                     ID              { get;set; }

        [Required]
        public string                   Code            { get; set; }

        [Required]
        public string                   title           { get; set; }

        [Required]
        public string                   tarikh          { get; set; }
        [StringLength(100)]
        public string                   modir           { get; set; }
        [StringLength(500)]
        public string                   molahezat       { get; set; }
        [StringLength(500)]
        public string                   address         { get; set; }
        [StringLength(50)]
        public string                   tel             { get; set; }
        [StringLength(50)]
        public string                   mobile          { get; set; }
        [StringLength(50)]
        public string                   fax             { get; set; }
        [StringLength(10)]
        public string                   code_posti      { get; set; }
        [StringLength(10)]
        public string                   code_melli      { get; set; }
        [StringLength(50)]
        public string                   code_eqtesadi   { get; set; }
        [StringLength(50)]
        public string                   tel2            { get; set; }
        [StringLength(50)]
        public string                   mobile2         { get; set; }
        [StringLength(100)]
        public string                   email           { get; set; }
        [StringLength(100)]
        public string                   website         { get; set; }
        public byte[]                   logo            { get; set; }
        public byte[]                   mohr            { get; set; }

        [NotMapped]
        public string OriginalCode => CryptographyHelper.Decrypt(this.Code);
        [NotMapped]
        public string OriginalTitle => CryptographyHelper.Decrypt(this.title);
        [NotMapped]
        public string OriginalTarix => CryptographyHelper.Decrypt(this.tarikh);


    }
}
