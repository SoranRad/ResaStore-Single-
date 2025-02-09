using ShareLib.Interfaces;
using ShareLib.Models;

namespace ShareLib.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
 
    public class People : ISqlQueryMaker,ICodeEntity
    {
        public long                      ID                      { get; set; }
        public short?                    FK_Shahr                { get; set; }
        public short?                    FK_Bank                 { get; set; }
        public short                     FK_Group                { get; set; }
        public byte                      kind                    { get; set; }
        public int                       code                    { get; set; }
        [StringLength(250)]             
        public string                    title                   { get; set; }
        public byte                      sex                     { get; set; }
        public DateTime?                 tarix                   { get; set; }
        [StringLength(50)]
        public string                    namePedar               { get; set; }
        [StringLength(10)]
        public string                    codeMeli                { get; set; }
        [StringLength(10)]
        public string                    codePosti               { get; set; }
        [StringLength(50)]
        public string                    codeEqtesadi            { get; set; }
        [StringLength(50)]
        public string                    tel                     { get; set; }
        [StringLength(50)]
        public string                    mobile                  { get; set; }
        [StringLength(50)]
        public string                    fax                     { get; set; }
        [StringLength(400)]             
        public string                    addressHome             { get; set; }
        public bool                      is_disable              { get; set; }
        [StringLength(50)]
        public string                    telDowom                { get; set; }
        [StringLength(50)]
        public string                    mobDowom                { get; set; }
        [StringLength(400)]             
        public string                    addresswork             { get; set; }
        [StringLength(50)]
        public string                   shomareHesab             { get; set; }
        [StringLength(10)]
        public string                   shomareShenasname        { get; set; }
        
        public bool?                    isBlock                  { get; set; }
        public decimal?                 BlockMablaq              { get; set; }
        public long?                    FK_Image_Tasvir          { get; set; }
        public long?                    FK_Image_Zemanat         { get; set; }
        public long?                    FK_Image_Emza            { get; set; }
        public bool                     is_Froshande             { get; set; }
        public bool                     is_Xaridar               { get; set; }
        public decimal?                 Sarmaye_Avalie           { get; set; }
        public decimal?                 Sarmaye_Kol              { get; set; }
        public decimal?                 Sarmaye_Darsad           { get; set; }
        public decimal?                 Sood_Darsad              { get; set; }
        public string                   Plak                     { get; set; }

        public City                     City                     { get; set; }
        public Bank                     Bank                     { get; set; }
        public PeopleGroup              Group                    { get; set; }
        public ICollection<Dialog>      Dialogs                  { get; set; }


        public ImageDocument            ImageSign                { get; set; }
        public ImageDocument            ImagePicture             { get; set; }
        public ImageDocument            ImageWarranty            { get; set; }


        public string                   StateTitle               =>  this.is_disable    ? "غیر فعال "   : "فعال";
        public string                   CustomerState            => (this.is_Froshande  ? "فروشنده"     : String.Empty) + 
                                                                    (this.is_Xaridar    ? "خریدار"      : String.Empty);



        [NotMapped]
        public string                   GroupTitle               { get; set; }
        [NotMapped]
        public string                   CityTitle                { get; set; }
        [NotMapped]
        public string                   BankTitle                { get; set; }

        [NotMapped]
        public string                   SaleTitle                
        {
            get
            {
                var str1 = this.is_Froshande    ? "فروشنده" : null;
                var str2 = this.is_Xaridar      ? "خریدار"  : null;

                if (string.IsNullOrEmpty(str1) || string.IsNullOrEmpty(str2))
                    return str1 ?? str2;

                return str1 + " , " + str2;
            }

        }


        public string   GenerateCode    ()
        {
            return @"
SELECT MAX(ta.code) FROM Base.tbl_Ashxas AS ta
WHERE ta.FK_Group = @Code
";
        }
        public string   GetItem         ()
        {
            return @"";
        }
        public string   GetList         ()
        {
            return @"
SELECT ta.ID ,
       ta.FK_Shahr ,
       ta.FK_Bank ,
       ta.FK_Group ,
       ta.kind ,
       ta.code ,
       LTRIM(RTRIM(ta.title))           AS title ,
       ta.sex ,
       ta.tarix ,
       LTRIM(RTRIM(ta.namePedar))       AS  namePedar,
       LTRIM(RTRIM(ta.codeMeli ))       AS codeMeli,
       LTRIM(RTRIM(ta.codePosti))       AS codePosti ,
       LTRIM(RTRIM(ta.codeEqtesadi))    AS  codeEqtesadi,
       LTRIM(RTRIM(ta.tel ))            AS tel,
       LTRIM(RTRIM(ta.mobile))          AS mobile ,
       LTRIM(RTRIM(ta.fax ))            AS fax,
       LTRIM(RTRIM(ta.addressHome ))    AS addressHome,
       ta.is_disable ,
       LTRIM(RTRIM(ta.telDowom))        AS telDowom ,
       LTRIM(RTRIM(ta.mobDowom ))       AS mobDowom,
       LTRIM(RTRIM(ta.addresswork ))    AS addresswork,
       LTRIM(RTRIM(ta.shomareHesab ))   AS shomareHesab,
       LTRIM(RTRIM(ta.shomareShenasname )) AS shomareShenasname ,
       LTRIM(RTRIM(ta.Plak )) AS Plak ,
       ta.isBlock ,
       ta.BlockMablaq ,
       ta.FK_Image_Tasvir ,
       ta.FK_Image_Zemanat ,
       ta.FK_Image_Emza ,
       ta.is_Froshande ,
       ta.is_Xaridar ,
       ta.Sarmaye_Avalie ,
       ta.Sarmaye_Kol ,
       ta.Sarmaye_Darsad ,
       ta.Sood_Darsad ,

	   LTRIM(RTRIM(tga.Title))  AS GroupTitle,
	   LTRIM(RTRIM(ts.title))   AS CityTitle,
	   LTRIM(RTRIM(tb.title))   AS BankTitle

	   
FROM Base.tbl_Ashxas AS ta

LEFT OUTER JOIN Base.tbl_Group_Ashxas	AS tga	ON tga.ID = ta.FK_Group
LEFT OUTER JOIN Base.tbl_Bank			AS tb	ON tb.ID = ta.FK_Bank
LEFT OUTER JOIN Base.tbl_Shahr			AS ts	ON ts.ID = ta.FK_Shahr
";
        }
        public string   UniqueCode      ()
        {
            return @"
SELECT COUNT(ta.code) FROM Base.tbl_Ashxas AS ta
WHERE ta.code = @Code
";
        }
    }
}
