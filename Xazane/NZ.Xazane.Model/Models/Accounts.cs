using NZ.Xazane.Model.Models;
using ShareLib;
using ShareLib.Interfaces;

namespace NZ.Xazane.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    
    public partial class Accounts : ISqlQueryMaker ,ICodeEntity ,IEntityUsage
    {
        public Accounts() 
        {
            tbl_Daste_Chque     = new HashSet<ChequeBook>();
        }

        public int                  ID                  { get; set; }
        public short?               FK_Bank             { get; set; }
        public short                Code                { get; set; }
        public byte                 Kind                { get; set; }
        [StringLength(150)]
        public string               title               { get; set; }
        public decimal              mojudi_avalie       { get; set; }
        public bool                 is_disable          { get; set; }
        [StringLength(250)]
        public string               shobe               { get; set; }
        public bool?                has_POS             { get; set; }
        [StringLength(30)]
        public string               Shomare_Hesab       { get; set; }
        [StringLength(100)]
        public string               Kind_Hesab          { get; set; }

        public ICollection<ChequeBook>             tbl_Daste_Chque         { get; set; }
        public string                              StateTitle              => this.is_disable ? "غیر فعال" : "فعال";

        public ICollection<ChequeOperation>        ChequeOperations        { get; set; }
        public ICollection<PayBoxOperation>        DebitPayBoxes           { get; set; }
        public ICollection<PayBoxOperation>        CreditPayBoxes          { get; set; }
        public ICollection<ChequeBook>             Cheque_Book             { get; set; }
        public ICollection<ChequeOperation>        ChequeStateAccount      { get; set; }


        public string           CircularQuery       ()
        {
            return @"
                    SELECT TOP(1)tadx.ID FROM Xazane.tbl_Amaliat_Xazaneh AS tadx
                                WHERE tadx.FK_Xazaneh_Bad=@ID OR tadx.FK_Xazaneh_Bas=@ID
";
        }
        public string           GenerateCode        ()
        {
            return @" SELECT MAX(thx.Code) 
                                FROM Xazane.tbl_Hesab_Xazaneh AS thx
                                WHERE thx.Kind=@Kind";
        }
        public string           GetItem             ()
        {
            return @"";
        }
        public string           GetList             ()
        {
            return @"
                    SELECT  thx.ID ,
                            thx.FK_Bank ,
                            thx.Code ,
                            thx.Kind ,
                            Ltrim(Rtrim( thx.title)) as title,
                            thx.mojudi_avalie ,
                            thx.is_disable ,
                            Ltrim(Rtrim(thx.shobe))as shobe ,
                            thx.has_POS ,
                            thx.Shomare_Hesab ,
                            Ltrim(Rtrim(thx.Kind_Hesab))as Kind_Hesab

                        FROM Xazane.tbl_Hesab_Xazaneh AS thx
                        WHERE thx.Kind=@Kind ";
        }
        public string           UniqueCode          ()
        {
            return @"SELECT COUNT(thx.Code )
                                    FROM Xazane.tbl_Hesab_Xazaneh AS thx
                                    WHERE thx.Kind=@Kind And thx.Code=@Code";
        }
    }
}
