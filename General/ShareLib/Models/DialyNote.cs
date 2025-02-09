using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Interfaces;

namespace ShareLib.Models
{
    public class DailyNote : ISqlQueryMaker
    {
        public long             ID              { get; set; }
        [Column(TypeName = "date")]
        public DateTime         Date            { get; set; }
        [Required]
        public string           Msg             { get; set; }
        public bool             IsChecked       { get; set; }

        public string   GetItem     ()
        {
            return @"";
        }
        public string   GetList     ()
        {
            return @"
select ID,Date,Ltrim(Rtrim(Msg)) as Msg,IsChecked
From General.tbl_DailyNote
where Date=@Date

";
        }
    }
}
