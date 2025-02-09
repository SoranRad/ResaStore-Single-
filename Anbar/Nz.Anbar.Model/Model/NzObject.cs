using Nz.Anbar.Model.Model;
using ShareLib;
using ShareLib.Interfaces;
using ShareLib.Models;

namespace NZ.Anbar.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    

    public class NzObject :ISqlQueryMaker,IEntityUsage,ICodeEntity
    {
        public NzObject()
        {
            PreFactorItemses = new HashSet<PreFactorItems>();
        }



        public long         ID                  { get; set; }
        public short        FK_GroupKala_2th    { get; set; }
        public short        FK_Vahed            { get; set; }
        public byte         kind                { get; set; }
        public int          Code                { get; set; }
        public decimal?     point_bohrani       { get; set; }
        public bool         is_disabled         { get; set; }
        public decimal      nerkh_frosh         { get; set; }
        public decimal?     nerkh_frosh1        { get; set; }
        public decimal?     nerkh_frosh2        { get; set; }
        public decimal?     nerkh_frosh3        { get; set; }
        public long?        FK_Image            { get; set; }

       
         


        [Required]
        [StringLength(500)]
        public string       title               { get; set; }
        [StringLength(50)]
        public string       barcode             { get; set; }
        [StringLength(150)]
        public string       nameFani            { get; set; }
        [StringLength(50)]
        public string       codeFani            { get; set; }
        [StringLength(150)]
        public string       keshvarSazande      { get; set; }

        public short?        FK_Brand            { get; set; }
        public short?        FK_BasteBandi       { get; set; }
        public decimal?      Height              { get; set; }
        public decimal?      Width               { get; set; }
        public decimal?      Length              { get; set; }
        public byte?         Season              { get; set; }
        [StringLength(200)]
        public string        Gender              { get; set; }
        public int?          Color               { get; set; }
        [StringLength(20)]
        public string        Size                { get; set; }

        public decimal       Zarib               { get; set; }
        public short?        FK_Vahed_Fari       { get; set; }

        //==== ارتیاط با سایر مدلهای دیگر 
        public Unit                         tbl_Vahed               { get; set; }
        public Brand                        tbl_Brand               { get; set; }
        public BasteBandi                   tbl_BasteBandi          { get; set; }
        public ObjectImages                 tbl_Images              { get; set; }
        public ICollection<PreFactorItems>  PreFactorItemses        { get; set; }



        [NotMapped]
        public string       UnitTitle           { get; set; }
        [NotMapped]
        public string       MainGroupTitle      { get; set; }
        [NotMapped]
        public string       SubGroupTitle       { get; set; }

        [NotMapped]
        public string       KindTitle           => ((Enums.NzObjectKind)this.kind).NzTostring();
        [NotMapped]
        public string       StateTitle          => this.is_disabled ? "غیر فعال " : "فعال";
        [NotMapped]
        public string       BrandTitle          { get; set; }
        [NotMapped]
        public string       BastebandiTitle     { get; set; }
        [NotMapped]
        public string       SeasonTitle         => Season == null ? string.Empty : ((Enums.NzObjectSeason)this.kind).NzTostring();

         

        public string       CircularQuery       ()
        {
            return
                    @"
                        SELECT TOP (1) tar.ID FROM Anbar.tbl_Amaliat_Riz AS tar
                        WHERE tar.FK_Kala = @Code
                    ";
        }
        public string       GenerateCode        ()
        {
            return
                @"
                SELECT MAX(tkx.Code) FROM Base.tbl_Kala_Xadamat AS tkx
                WHERE  tkx.FK_GroupKala_2th=@Code
                ";
        }
        public string       GetItem             ()
        {
            return @"
SELECT tkx.ID ,
       tkx.FK_GroupKala_2th ,
       tkx.FK_Vahed ,
       tkx.kind ,
       tkx.Code ,
       Rtrim(Ltrim(tkx.title	))          AS title,
       Rtrim(Ltrim(tkx.barcode	))          AS barcode,
       Rtrim(Ltrim(tkx.nameFani ))          AS nameFani,
       Rtrim(Ltrim(tkx.codeFani ))          AS codeFani,
       tkx.point_bohrani ,
       tkx.is_disabled ,
       tkx.nerkh_frosh ,
       tkx.nerkh_frosh1 ,
       tkx.nerkh_frosh2 ,
       tkx.nerkh_frosh3 ,
       tkx.FK_Image ,
       Rtrim(Ltrim(tkx.keshvarSazande   ))  AS keshvarSazande,
	   RTRIM(LTRIM(tv.title			    ))	AS UnitTitle,
	   RTRIM(LTRIM(tgk2.title		    ))	AS MainGroupTitle,
	   RTRIM(LTRIM(tgk.title		    ))	AS SubGroupTitle,
       tkx.FK_Brand,
       tkx.FK_BasteBandi,
       tkx.Height,
       tkx.Width,
       tkx.Length,
	   tkx.nerkh_frosh,
       tkx.Season,
	   LTRIM(RTRIM(tkx.Size)) AS Size,
	   tkx.Color,
       tkx.Zarib,
       tkx.FK_Vahed_Fari,
       Rtrim(Ltrim(tkx.Gender))             AS Gender ,
	   LTRIM(RTRIM(tb.Title))               AS BrandTitle,
	   LTRIM(RTRIM(tbb.Title))              AS BastebandiTitle

FROM Base.tbl_Kala_Xadamat              AS tkx
INNER JOIN Base.tbl_Vahed               AS tv       ON tv.ID        = tkx.FK_Vahed
INNER JOIN Base.tbl_GroupKala_2th       AS tgk      ON tgk.Code     = tkx.FK_GroupKala_2th
LEFT OUTER JOIN Base.tbl_GroupKala_1th  AS tgk2     ON tgk2.Code    = tgk.FK_GroupKala_1th
LEFT OUTER JOIN Base.tbl_Brand		    AS tb	    ON tb.ID	    = tkx.FK_Brand
LEFT OUTER JOIN Base.tbl_BasteBandi	    AS tbb	    ON tbb.ID	    = tkx.FK_BasteBandi

WHERE tkx.ID=@ID

";
        }
        public string       GetList             ()
        {
            return @"
SELECT tkx.ID ,
       tkx.FK_GroupKala_2th ,
       tkx.FK_Vahed ,
       tkx.kind ,
       tkx.Code ,
       Rtrim(Ltrim(tkx.title	)) AS title,
       Rtrim(Ltrim(tkx.barcode	)) AS barcode,
       Rtrim(Ltrim(tkx.nameFani )) AS nameFani,
       Rtrim(Ltrim(tkx.codeFani )) AS codeFani,
       tkx.point_bohrani ,
       tkx.is_disabled ,
       tkx.nerkh_frosh ,
       tkx.nerkh_frosh1 ,
       tkx.nerkh_frosh2 ,
       tkx.nerkh_frosh3 ,
       tkx.FK_Image ,
       Rtrim(Ltrim(tkx.keshvarSazande   ))  AS keshvarSazande,
	   RTRIM(LTRIM(tv.title			    ))	AS UnitTitle,
	   RTRIM(LTRIM(tgk2.title		    ))	AS MainGroupTitle,
	   RTRIM(LTRIM(tgk.title		    ))	AS SubGroupTitle,
       tkx.FK_Brand,
       tkx.FK_BasteBandi,
       tkx.Height,
       tkx.Width,
       tkx.Length,
	   tkx.nerkh_frosh,
       tkx.Season,
	   LTRIM(RTRIM(tkx.Size)) AS Size,
	   tkx.Color,
       tkx.Zarib,
       tkx.FK_Vahed_Fari,
       Rtrim(Ltrim(tkx.Gender)) AS Gender,
	   LTRIM(RTRIM(tb.Title))  AS BrandTitle,
	   LTRIM(RTRIM(tbb.Title)) AS BastebandiTitle

FROM Base.tbl_Kala_Xadamat              AS tkx
INNER JOIN Base.tbl_Vahed               AS tv       ON tv.ID        = tkx.FK_Vahed
INNER JOIN Base.tbl_GroupKala_2th       AS tgk      ON tgk.Code     = tkx.FK_GroupKala_2th
LEFT OUTER JOIN Base.tbl_GroupKala_1th  AS tgk2     ON tgk2.Code    = tgk.FK_GroupKala_1th
LEFT OUTER JOIN Base.tbl_Brand		    AS tb	    ON tb.ID	    = tkx.FK_Brand
LEFT OUTER JOIN Base.tbl_BasteBandi	    AS tbb	    ON tbb.ID	    = tkx.FK_BasteBandi
";
        }
        public string       UniqueCode          ()
        {
            return @"
SELECT  COUNT(tkx.ID)
FROM Base.tbl_Kala_Xadamat AS tkx
WHERE  tkx.Code = @Code
";
        }
    }
}
