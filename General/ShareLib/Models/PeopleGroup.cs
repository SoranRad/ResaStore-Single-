using System.Runtime.Remoting;
using ShareLib.Interfaces;

namespace ShareLib.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public class PeopleGroup :ISqlQueryMaker,ICodeEntity,IEntityUsage
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short                ID          { get; set; }
        [Required]
        [StringLength(100)]
        public string               Title       { get; set; }
        [NotMapped]
        public int                  Child       { get; set; }
        public ICollection<People>  Peoples     { get; set; }

        public string CircularQuery     ()
        {
            return @"
SELECT TOP(1)ta.ID FROM Base.tbl_Ashxas AS ta 
WHERE ta.FK_Group=@Code
";
        }
        public string GenerateCode      ()
        {
            return @"
SELECT MAX(tga.ID) FROM Base.tbl_Group_Ashxas AS tga
";
        }
        public string GetItem           ()
        {
            return @"";
        }
        public string GetList           ()
        {
            return @"
SELECT tga.ID,
LTRIM(RTRIM(tga.Title ))  AS Title
,COUNT(ta.ID) AS Child
FROM Base.tbl_Group_Ashxas AS tga
LEFT OUTER JOIN Base.tbl_Ashxas AS ta ON ta.FK_Group = tga.ID
GROUP BY tga.ID,tga.Title
";
        }
        public string UniqueCode        ()
        {
            return @"
SELECT COUNT(tga.ID ) FROM Base.tbl_Group_Ashxas AS tga
WHERE tga.ID=@Code
";
        }
    }
}
