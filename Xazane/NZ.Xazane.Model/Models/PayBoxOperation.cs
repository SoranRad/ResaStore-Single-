using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib;
using ShareLib.Interfaces;

namespace NZ.Xazane.Model.Models
{
    public class PayBoxOperation : ISqlQueryMaker,ICodeEntity
    {
        public long         ID              { get; set; }
        public short?       FK_Salmali      { get; set; }
        public int?         FK_Xazaneh_Bad  { get; set; }
        public int?         FK_Xazaneh_Bas  { get; set; }
        public long?        FK_DP           { get; set; }
        public short?       FK_User_Add     { get; set; }
        public short?       FK_User_Edit    { get; set; }
        public long?        serialPeygiri   { get; set; }
        public int          serial          { get; set; }
        public decimal      mablaq          { get; set; }
        [StringLength(200)]
        public string       sharh           { get; set; }
        public byte         kind            { get; set; }
        [Column(TypeName = "date")]
        public DateTime?    tarikh          { get; set; }
        public DateTime?    tarikh_add      { get; set; }
        public DateTime?    tarikh_edit     { get; set; }


        public DPOperation      DpHead          { get; set; }
        public Accounts         DebitAccount    { get; set; }
        public Accounts         CreditAccount   { get; set; }

        [NotMapped]
        public string       CreditAccountTitle  { get; set; }
        [NotMapped]
        public string       DebitAccountTitle   { get; set; }
        [NotMapped]
        public string       PersianStr          { get; set; }
        [NotMapped]
        public byte         PersianDayInMonth   { get; set; }
        [NotMapped]
        public byte         PersianMonthNo      { get; set; }
        [NotMapped]
        public byte         CreditKind          { get; set; }
        [NotMapped]
        public byte         DebitKind           { get; set; }
        [NotMapped]
        public Enums.NzItemState State          { get; set; }


        public string GenerateCode()
        {
            return @"
select max(serial) from Xazane.tbl_Amaliat_Xazaneh
where kind = @Kind  and FK_Salmali=@Year
";
        }

        public string GetItem()
        {
            return @"
select 
        tax.ID      ,
        tax.FK_Salmali     ,
        tax.FK_Xazaneh_Bad ,
        tax.FK_Xazaneh_Bas ,
        tax.FK_DP          ,
        tax.FK_User_Add    ,
        tax.FK_User_Edit   ,
        tax.serialPeygiri  ,
        tax.serial         ,
        tax.mablaq         ,
        RTRIM(Ltrim( tax.sharh ))as  sharh ,
        tax.kind           ,
        tax.tarikh         ,
        tax.tarikh_add     ,
        tax.tarikh_edit    ,

        RTRIM(Ltrim( thx_Bas.title ))as  CreditAccountTitle ,
        RTRIM(Ltrim( thx_Bad.title )) as  DebitAccountTitle ,
        thx_Bas.Kind as CreditKind,
        thx_Bad.Kind as DebitKind,
        dd.PersianStr,
        dd.PersianDayInMonth,
        dd.PersianMonthNo

FROM                    Xazane.tbl_Amaliat_Xazaneh  as tax
    left outer join     Xazane.tbl_Hesab_Xazaneh    as thx_Bad  on tax.FK_Xazaneh_Bad = thx_Bad.ID
    left outer join     Xazane.tbl_Hesab_Xazaneh    as thx_Bas  on tax.FK_Xazaneh_Bas = thx_Bas.ID
    inner join          General.DimDate             as dd       on tax.tarikh = dd.GregorianDate

WHERE  tax.ID = @ID;
";
        }

        public string GetList()
        {
            return @"
       select tax.ID      ,
	   tax.FK_Salmali     ,
	   tax.FK_Xazaneh_Bad ,
	   tax.FK_Xazaneh_Bas ,
	   tax.FK_DP          ,
	   tax.FK_User_Add    ,
	   tax.FK_User_Edit   ,
	   tax.serialPeygiri  ,
	   tax.serial         ,
	   tax.mablaq         ,
	   RTRIM(Ltrim( tax.sharh ))as  sharh ,
	   tax.kind           ,
	   tax.tarikh         ,
	   tax.tarikh_add     ,
	   tax.tarikh_edit    ,

	   RTRIM(Ltrim( thx_Bas.title ))as  CreditAccountTitle ,
	   RTRIM(Ltrim( thx_Bad.title )) as  DebitAccountTitle ,
       thx_Bas.Kind as CreditKind,
       thx_Bad.Kind as DebitKind,
	   dd.PersianStr,
	   dd.PersianDayInMonth,
	   dd.PersianMonthNo

       FROM Xazane.tbl_Amaliat_Xazaneh as tax
            left outer join Xazane.tbl_Hesab_Xazaneh as thx_Bad on tax.FK_Xazaneh_Bad = thx_Bad.ID
            left outer join Xazane.tbl_Hesab_Xazaneh as thx_Bas on tax.FK_Xazaneh_Bas = thx_Bas.ID
            inner join General.DimDate as dd on tax.tarikh = dd.GregorianDate

       WHERE tax.FK_Salmali=@Year and tax.kind=@Kind AND (dd.PersianMonthNo = @Month OR @Month=13)
";

        }

        public string UniqueCode()
        {
            return @"select Count(ID) from Xazane.tbl_Amaliat_Xazaneh
                    where kind =@Kind and serial=@Serial and FK_Salmali=@Year";
        }
    }
}
