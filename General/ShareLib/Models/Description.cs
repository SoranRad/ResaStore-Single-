

using ShareLib.Interfaces;

namespace ShareLib.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public partial class Description : ISqlQueryMaker
    {
        public int      ID          { get; set; }
        public byte     System      { get; set; }
        [Required]
        [StringLength(500)]
        public string   Text        { get; set; }

        public string GetItem()
        {
            return @"";
        }
        public string GetList()
        {
            return @"SELECT 
ts.ID ,
ts.System ,
RTRIM(LTRIM(ts.Text )) AS Text 
FROM General.tbl_Sharh AS ts
";
        }
    }
}
