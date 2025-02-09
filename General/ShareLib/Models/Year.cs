//using System.Data.Entity.Migrations.Builders;

using MS_Control.Tarikh;
using ShareLib.Interfaces;

namespace ShareLib.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public partial class Year : ISqlQueryMaker,ICodeEntity
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short            Salmali                     { get; set; }
        public decimal          darsad_arzesh_afzude        { get; set; }
        public bool             is_close                    { get; set; }
        [StringLength(50)]
        public string           Money                       { get; set; }
        public DateTime         StartDate                   { get; set; }
        public DateTime         EndDate                     { get; set; }
        //======================================================================
        //========================  User Property ==============================
        //======================================================================
        [NotMapped]
        public string           StartDateFa   =>  new MS_Structure_Shamsi(this.StartDate).ToShamsi();
        [NotMapped]
        public string           EndDateFa     =>  new MS_Structure_Shamsi(this.EndDate).ToShamsi();
        [NotMapped]
        public string           CloseTitle    =>  this.is_close ? "بسـته" : "بـاز";

        public string   GenerateCode    ()
        {
            return @"SELECT MAX(ts.Salmali) FROM General.tbl_Salmali AS ts";
        }
        public string   GetItem         ()
        {
            return @"";
        }
        public string   GetList         ()
        {
            return @"select    ts.Salmali ,
                               ts.darsad_arzesh_afzude ,
                               ts.is_close ,
                               Rtrim(Ltrim(ts.Money)) as Money ,
                               ts.StartDate , 
                               ts.EndDate from General.tbl_Salmali as ts ";
        }
        public string   UniqueCode      ()
        {
            return @"
SELECT COUNT(ts.Salmali) FROM General.tbl_Salmali AS ts
WHERE ts.Salmali=@Year
";
        }
    }
}
