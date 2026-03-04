using Nz.Aqsat.Model.Report;
using ShareLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Aqsat.DataLayer.DapperConfig.Report
{
    public class SarResidAqsatHafte_DapperConfig : DapperEntityConfiguration<SarResidAqsatHafte>
    {
	    public SarResidAqsatHafte_DapperConfig()
	    {
		    SetList(@"
SELECT 

ddSarResid.PersianDayOfWeekName,
ddSarResid.PersianDayOfWeekInt,
tar.FK_Main,
tar.ID,
tam.Serial,
LTRIM(RTRIM(tak.Title))         AS KindTitle,
ddSodure.PersianStr             AS TarixSodur,
LTRIM(RTRIM(ta_shaxs.title))    AS Shaxs,
LTRIM(RTRIM(ta_shaxs.mobile))   AS Mobile,
LTRIM(RTRIM(ta_zamen.title))    AS ZamenTitle,
LTRIM(RTRIM(ta_zamen.mobile))   AS ZamenMobile,
ddSarResid.PersianStr           AS TarixSarResid,
tar.mablaqQest,
tar.Radif,
DATEDIFF(DAY,GETDATE() ,tar.tarixQest) AS DayRemaind

FROM                Aqsat.tbl_Aqsat_Riz     AS tar
INNER JOIN          Aqsat.tbl_Aqsat_Main    AS tam          ON  tar.FK_Main     = tam.ID
INNER JOIN          Aqsat.tbl_Aqsat_Kind    AS tak          ON  tak.ID          = tam.FK_Noh
INNER JOIN          Base.tbl_Ashxas         AS ta_shaxs     ON  ta_shaxs.ID     = tam.FK_Shaxs
LEFT OUTER JOIN     General.DimDate         AS ddSodure     ON  tam.Tarikh      = ddSodure.GregorianDate
LEFT OUTER JOIN     General.DimDate         AS ddSarResid   ON  tar.tarixQest   = ddSarResid.GregorianDate
LEFT OUTER JOIN     Base.tbl_Ashxas         AS ta_zamen     ON  ta_zamen.ID     = tam.FK_Zamen
LEFT OUTER JOIN     General.DimDate         AS ddWeek       ON  ddWeek.GregorianDate = @tarix

WHERE   
            tar.isPardaxt = 0 
        AND ddWeek.PersianWeekOfYearNo = ddSarResid.PersianWeekOfYearNo
        AND ddWeek.PersianYearInt = ddSarResid.PersianYearInt


");
	    }
    }
}
