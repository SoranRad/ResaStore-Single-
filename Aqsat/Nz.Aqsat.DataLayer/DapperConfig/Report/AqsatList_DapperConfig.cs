using Nz.Aqsat.Model.Models;
using Nz.Aqsat.Model.Report;
using ShareLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Aqsat.DataLayer.DapperConfig.Report
{
    public class AqsatList_DapperConfig : DapperEntityConfiguration<AqsatList>
	{
		public AqsatList_DapperConfig()
		{
			SetList(@"	
SELECT 

tam.ID,
tam.Serial,
dd_create.PersianStr,
LTRIM(RTRIM(ta_shaxs.title))    AS Shaxs,
LTRIM(RTRIM(ta_shaxs.mobile))   AS Mobile,
ta_shaxs.code                   AS ShaxsCode,
ta_shaxs.codeMeli ,
LTRIM(RTRIM(tak.Title))         AS KindTitle,
dd_start.PersianStr As StartPersianDate,
tam.MablaqFinalAqsat,
LTRIM(RTRIM(ta_zamen.title)) AS ZamenTitle,
LTRIM(RTRIM(ta_zamen.mobile)) AS ZamenMobile,
LTRIM(RTRIM(tam.Sharh)) AS Sharh,
tam.TedadAqsat,
Riz.Pardaxti AS TedadPardaxti,
Riz.MablaqPardaxti AS MablaqPardaxti

FROM                Aqsat.tbl_Aqsat_Main    AS tam 
INNER JOIN          Base.tbl_Ashxas         AS ta_shaxs     ON  ta_shaxs.ID     = tam.FK_Shaxs
LEFT OUTER JOIN     Base.tbl_Ashxas         AS ta_zamen     ON  ta_zamen.ID     = tam.FK_Zamen
INNER JOIN          Aqsat.tbl_Aqsat_Kind    AS tak          ON  tak.ID          = tam.FK_Noh
LEFT OUTER JOIN     General.DimDate         AS dd_create    ON  dd_create.GregorianDate  = tam.Tarikh
LEFT OUTER JOIN     General.DimDate         AS dd_start     ON  dd_start.GregorianDate   = tam.StartDate
INNER JOIN (

			SELECT
			tar.FK_Main,
			SUM( CASE WHEN tar.isPardaxt = 1 THEN 1 ELSE 0 END) AS Pardaxti,			
			SUM( CASE WHEN tar.isPardaxt = 1 THEN mablaqQest ELSE 0 END) AS MablaqPardaxti
			FROM Aqsat.tbl_Aqsat_Riz AS tar 
			GROUP BY tar.FK_Main

)AS Riz ON Riz.FK_Main = tam.ID

WHERE tam.FK_Salmali =@Year AND (dd_create.PersianMonthNo=@Month OR @Month=13)
");
		}
    }
}
