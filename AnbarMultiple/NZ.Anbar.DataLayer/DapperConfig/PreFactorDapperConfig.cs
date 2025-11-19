using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Anbar.Model;
using Nz.Anbar.Model.Model;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig
{
    public class PreFactorDapperConfig : DapperEntityConfiguration<PreFactor>
    {
        public PreFactorDapperConfig()
        {
            SetItem(@"

SELECT 
	tp.ID,
    LTRIM(RTRIM(tp.Title )) AS Title
	   
FROM Base.tbl_Prefactor     AS tp
WHERE tp.ID = @ID;


SELECT tpfi.ID,
       tpfi.FK_Title,
       tpfi.FK_Kala ,
	   tpfi.Count,
	   tkx.Code					AS ObjectCode,
	   LTRIM(RTRIM(tkx.title))  AS ObjectTitle,
	   LTRIM(RTRIM(tv.title))   AS UnitTitle

FROM Base.tbl_PreFactorItems		AS tpfi
INNER JOIN Base.tbl_Kala_Xadamat	AS tkx	ON tpfi.FK_Kala		= tkx.ID
INNER JOIN Base.tbl_Vahed			AS tv	ON tv.ID			= tkx.FK_Vahed
WHERE tpfi.FK_Title = @ID

");

            SetList(@"
SELECT 
	tp.ID,
    LTRIM(RTRIM(tp.Title )) AS Title
	   
FROM Base.tbl_Prefactor AS tp

");
        }
    }
}
