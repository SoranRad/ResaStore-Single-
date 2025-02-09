using ShareLib;
using ShareLib.Interfaces;

namespace NZ.Anbar.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class SaleKind : ISqlQueryMaker,IEntityUsage
    {
        public          SaleKind        ()
        {
            FactorHead       = new HashSet<FactorHead>();
        }
       
        [Required]
        [StringLength(100)]
        public string   Title           { get; set; }
        public bool     Is_Disable      { get; set; }
        public byte     Kind            { get; set; }
        public short    ID              { get; set; }
        public short    FK_Salmali      { get; set; }

        public ICollection
                <FactorHead> 
                        FactorHead      { get; set; }

        public string   KindTitle       => ((Enums.NzSalingKind) this.Kind).NzTostring();
        public string   StateTitle      => this.Is_Disable ? "غیر فعال " : "فعال";

        public string   CircularQuery   ()
        {
            return @"
SELECT TOP(1) tat.ID FROM Anbar.tbl_Amaliat_Title AS tat
WHERE tat.FK_Kind_Frosh=@ID
";
        }

        public string   GetItem         ()
        {
            return @"";
        }
        public string   GetList         ()
        {
            return @"
SELECT tkf.ID ,
       RTRIM(LTRIM(tkf.Title ))AS Title ,
       tkf.Is_Disable ,
       tkf.Kind 
FROM Base.tbl_Kind_Frosh AS tkf
";
        }
    }
}
