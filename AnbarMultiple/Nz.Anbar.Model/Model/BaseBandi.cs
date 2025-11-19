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
    public class BasteBandi : ISqlQueryMaker, IEntityUsage
    {
        public BasteBandi()
        {
            Objects = new HashSet<NzObject>();
        }

        [Required]
        [StringLength(50)]
        public string       Title       { get; set; }
        public short        ID          { get; set; }

        public ICollection<NzObject> Objects { get; set; }

        public string CircularQuery()
        {
            return @"
SELECT TOP(1) tkx.ID FROM 
Base.tbl_Kala_Xadamat AS tkx
WHERE tkx.FK_BasteBandi = @ID
";
        }

        public string GetItem()
        {
            return @"
SELECT 
tbb.ID, 
LTRIM(RTRIM(tbb.Title)) AS Title 
FROM Base.tbl_BasteBandi AS tbb
WHERE tbb.ID= @ID
";
        }
        public string GetList()
        {
            return @"
SELECT 
tbb.ID, 
LTRIM(RTRIM(tbb.Title)) AS Title 
FROM Base.tbl_BasteBandi AS tbb
";
        }
    }
}
