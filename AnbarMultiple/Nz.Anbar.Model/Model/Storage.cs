
using ShareLib;
using ShareLib.Interfaces;

namespace NZ.Anbar.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations; 


    public class Storage : ISqlQueryMaker,ICodeEntity,IEntityUsage
    {

        public short        ID              { get; set; }
        public byte         Code            { get; set; }
        [Required]
        [StringLength(100)]
        public string       Title           { get; set; }
        public byte         Kind            { get; set; }
        public bool         Is_Disable      { get; set; }

        public ICollection<FactorHead> FactorHead_Az { get; set; }
        public ICollection<FactorHead> FactorHead_Be { get; set; }
        
        public string       StateTitle      => this.Is_Disable ? "غیر فعال " : "فعال";
        public string       KindTitle       => ((Enums.NzStorageKind) this.Kind).NzToString();

        public string       CircularQuery   ()
        {
            return @"
SELECT TOP(1) tat.ID  FROM Anbar.tbl_Amaliat_Title AS tat
WHERE (tat.FK_Anbar_Az=@Code OR tat.FK_Anbar_Be=@Code)
";
        }
        public string       GenerateCode    ()
        {
            return @"SELECT MAX(tba.Code )
                        FROM Base.tbl_Base_Anbar AS tba";
        }
        public string       GetItem         ()
        {
	        return null;
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

        public override string ToString()
        {
	        return Code+ " ) " + Title;
        }


    }
}
