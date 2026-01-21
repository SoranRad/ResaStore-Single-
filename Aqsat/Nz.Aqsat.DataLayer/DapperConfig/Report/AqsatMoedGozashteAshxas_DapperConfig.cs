using Nz.Aqsat.Model.Report;
using ShareLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Aqsat.DataLayer.DapperConfig.Report
{
    public class AqsatMoedGozashteAshxas_DapperConfig : DapperEntityConfiguration<AqsatMoedGozashteAshxas>
	{
		public AqsatMoedGozashteAshxas_DapperConfig()
		{
			SetList(@"


SELECT 
tam.FK_Shaxs,
LTRIM(RTRIM(ta_shaxs.title))    AS Shaxs,
LTRIM(RTRIM(ta_shaxs.mobile))   AS Mobile,
LTRIM(RTRIM(ta_shaxs.code))     AS Code,
COUNT( DISTINCT tar.ID)         AS AqsatCount,
SUM(tar.mablaqQest)             AS SumMablaqQest,
Max(tar.tarixQest)              AS MaxTarixQest,
MIN(tar.tarixQest)              AS MinTarixQest

FROM                Aqsat.tbl_Aqsat_Riz     AS tar
INNER JOIN          Aqsat.tbl_Aqsat_Main    AS tam          ON  tar.FK_Main     = tam.ID
INNER JOIN          Base.tbl_Ashxas         AS ta_shaxs     ON  ta_shaxs.ID     = tam.FK_Shaxs

WHERE   

            tar.isPardaxt = 0 
        AND cast (GETDATE()  as date)>= tar.tarixQest 
        
GROUP BY
tam.FK_Shaxs,
ta_shaxs.title,
ta_shaxs.mobile,
ta_shaxs.code


");
		}
    }
}
