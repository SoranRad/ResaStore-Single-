using ShareLib.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NZ.Anbar.Model
{
    public class Unit : ISqlQueryMaker,IEntityUsage
    {
        public Unit()
        {
            FactorItems     = new HashSet<FactorItem>();
            Objects         = new HashSet<NzObject>();
        }

        [Required]
        [StringLength(100)]
        public string       title       { get; set; }
        public short        ID          { get; set; }

        public ICollection<FactorItem>          FactorItems     { get; set; }
        public ICollection<NzObject>            Objects         { get; set; }

        public string CircularQuery()
        {
            return @"
SELECT TOP(1) tkx.ID FROM 
Base.tbl_Kala_Xadamat AS tkx
WHERE tkx.FK_Vahed = @ID
";
        }

        public string GetItem()
        {
            throw new NotImplementedException();
        }
        public string GetList()
        {
            return @"SELECT 
                        ID ,
                        LTRIM(RTRIM(title )) AS title 
                        FROM Base.tbl_Vahed";
        }
    }
}
