using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Anbar.Model;
using ShareLib.Interfaces;

namespace Nz.Anbar.Model.Model
{
    public class Brand : ISqlQueryMaker, IEntityUsage
    {
        public Brand()
        { 
            Objects = new HashSet<NzObject>();
        }

        [Required]
        [StringLength(100)]
        public string   Title       { get; set; }
        public short    ID          { get; set; }
        public bool     test        { get; set; }

        public ICollection<NzObject> Objects { get; set; }

        public string CircularQuery()
        {
            return @"
SELECT TOP(1) tkx.ID FROM 
Base.tbl_Kala_Xadamat AS tkx
WHERE tkx.FK_Brand = @ID

";
        }

        public string GetItem()
        {
            return @"
SELECT 
tb.ID, 
LTRIM(RTRIM(tb.Title)) AS Title 
FROM Base.tbl_Brand AS tb
WHERE tb.ID= @ID
";
        }
        public string GetList()
        {
            return @"
SELECT 
tb.ID, 
LTRIM(RTRIM(tb.Title)) AS Title 
FROM Base.tbl_Brand AS tb
";
        }
    }
}
