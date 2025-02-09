
using ShareLib;
using ShareLib.Interfaces;

namespace NZ.Anbar.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;


    public class Storage : ISqlQueryMaker,ICodeEntity,IEntityUsage
    {

        public short        ID              { get; set; }
        public byte         Code            { get; set; }
        [Required]
        [StringLength(100)]
        public string       Title           { get; set; }
        public byte         Kind            { get; set; }
        public bool         Is_Disable      { get; set; }
        
        public string       StateTitle      => this.Is_Disable ? "غیر فعال " : "فعال";
        public string       KindTitle       => ((Enums.NzStorageKind) this.Kind).NzToString();

        public string       CircularQuery   ()
        {
            return @"
SELECT TOP(1) tar.ID  FROM Anbar.tbl_Amaliat_Riz AS tar
WHERE (tar.FK_Anbar_Az=@Code OR tar.FK_Anbar_Be=@Code)
";
        }
        public string       GenerateCode    ()
        {
            return @"SELECT MAX(tba.Code )
                        FROM Base.tbl_Base_Anbar AS tba";
        }
        public string       GetItem         ()
        {
            throw new NotImplementedException();
        }
        public string       GetList         ()
        {
            return @"SELECT    tba.ID ,
                               tba.Code ,
                               RTRIM(LTRIM(tba.Title)) AS  Title ,
                               tba.Kind ,
                               tba.Is_Disable 
                        FROM Base.tbl_Base_Anbar AS tba";
        }
        public string       UniqueCode      ()
        {
            return @"SELECT COUNT(tba.ID)
                    FROM Base.tbl_Base_Anbar AS tba
                    WHERE tba.Code = @Code";
        }
    }
}
