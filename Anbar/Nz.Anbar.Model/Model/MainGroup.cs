using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Interfaces;

namespace Nz.Anbar.Model.Model
{
    public class MainGroup : ISqlQueryMaker,ICodeEntity,IEntityUsage
    {

        public int      ID              { get; set; }
        public short    Code            { get; set; }
        [Required]
        [StringLength(200)]
        public string   title           { get; set; }

        [NotMapped]
        public int      CountSubGroup   { get; }

        public string   CircularQuery   ()
        {
            return @"
SELECT TOP(1) tgk2.ID FROM Base.tbl_GroupKala_2th AS tgk2
WHERE tgk2.FK_GroupKala_1th=@Code
";
        }
        public string   GenerateCode    ()
        {
            return @"
SELECT MAX(tgk.Code) FROM Base.tbl_GroupKala_1th AS tgk
";
        }
        public string   GetItem         ()
        {
            return @"
SELECT tgk.ID ,
       tgk.Code ,
       RTRIM(LTRIM( tgk.title )) AS title
FROM Base.tbl_GroupKala_1th AS tgk
WHERE tgk.ID=@ID
";
        }
        public string   GetList         ()
        {
            return @"
SELECT tgk.ID ,
       tgk.Code ,
       RTRIM(LTRIM( tgk.title )) AS title
	   ,COUNT(tgk2.ID ) AS CountSubGroup
FROM Base.tbl_GroupKala_1th AS tgk
LEFT OUTER JOIN Base.tbl_GroupKala_2th AS tgk2 ON tgk2.FK_GroupKala_1th = tgk.Code

GROUP BY tgk.ID ,
       tgk.Code ,
       tgk.title
";
        }
        public string   UniqueCode      ()
        {
            return @"

SELECT COUNT(tgk.ID )
FROM Base.tbl_GroupKala_1th AS tgk
WHERE tgk.Code=@Code

";
        }
    }
}
