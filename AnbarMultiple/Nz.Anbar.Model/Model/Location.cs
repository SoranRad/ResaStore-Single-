using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Anbar.Model;
using ShareLib.Interfaces;

namespace Nz.Anbar.Model.Model
{
    public class Location :ISqlQueryMaker,IEntityUsage
    {
        public Location()
        {
            Factors = new HashSet<FactorHead>();
        }

        public              short        ID                 { get; set; }
        public              string       Title              { get; set; }
        public              bool         Is_Disable         { get; set; }

        
        public string StateTitle =>     this.Is_Disable ? "غیرفعال" : "فعال";

        public ICollection<FactorHead>   Factors            { get; set; }



        public string GetItem()
        {
            return @"
SELECT 
	   tbl.ID,
       LTRIM(RTRIM(tbl.Title)) AS Title,
       tbl.Is_Disable 

FROM Base.tbl_Base_Location AS tbl
WHERE tbl.ID = @ID 
";
        }

        public string GetList()
        {
            return @"
SELECT 
	   tbl.ID,
       LTRIM(RTRIM(tbl.Title)) AS Title,
       tbl.Is_Disable 

FROM Base.tbl_Base_Location AS tbl
";
        }

        public string CircularQuery()
        {
            return @"
                    SELECT 
                            TOP(1) tat.ID 

                            FROM Anbar.tbl_Amaliat_Title AS tat

                    WHERE tat.FK_Location = @ID
";
        }
    }
}
