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
    public class SubGroup : ISqlQueryMaker,IEntityUsage,ICodeEntity
    {
        public int      ID                  { get; set; }
        public short?   FK_GroupKala_1th    { get; set; }
        public short    Code                { get; set; }
        [Required]
        [StringLength(200)]
        public string   title               { get; set; }

        [NotMapped]
        public string   MainGroup           { get; set; }
        [NotMapped]
        public int      ObjectCount         { get; set; }


        public string CircularQuery     ()
        {
            return @"
SELECT TOP(1)tkx.ID FROM Base.tbl_Kala_Xadamat AS tkx
WHERE tkx.FK_GroupKala_2th=@Code
";
        }
        public string GenerateCode      ()
        {
            return @"
SELECT MAX(tgk.Code) FROM Base.tbl_GroupKala_2th AS tgk
WHERE tgk.FK_GroupKala_1th=@Code
";
        }
        public string GetItem           ()
        {
            return @"
SELECT tgk.ID ,
       tgk.FK_GroupKala_1th ,
       tgk.Code ,
       LTRIM(RTRIM(tgk.title )) AS title
FROM Base.tbl_GroupKala_2th AS tgk
WHERE tgk.ID = @ID

";
        }
        public string GetList           ()
        {
            return @"
SELECT tgk.ID ,
       tgk.FK_GroupKala_1th ,
       tgk.Code ,
       LTRIM(RTRIM(tgk.title )) AS title ,
	   LTRIM(RTRIM(tgk2.title)) AS MainGroup,
	   COUNT(tkx.ID)			AS ObjectCount
FROM Base.tbl_GroupKala_2th AS tgk
LEFT OUTER JOIN Base.tbl_GroupKala_1th	AS tgk2 ON tgk2.Code = tgk.FK_GroupKala_1th
LEFT OUTER JOIN Base.tbl_Kala_Xadamat	AS tkx	ON tkx.FK_GroupKala_2th = tgk.Code	
GROUP BY tgk.ID ,
       tgk.FK_GroupKala_1th ,
       tgk.Code ,
       tgk.title ,
	   tgk2.title 
";
        }
        public string UniqueCode        ()
        {
            return @"
SELECT  COUNT(tgk.ID)
FROM Base.tbl_GroupKala_2th AS tgk
WHERE tgk.Code=@Code
";
        }
    }
}
