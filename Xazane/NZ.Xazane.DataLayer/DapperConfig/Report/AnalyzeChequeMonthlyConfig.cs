using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Xazane.Model.Report;
using ShareLib.Interfaces;

namespace NZ.Xazane.DataLayer.DapperConfig.Report
{
    public class AnalyzeChequeMonthlyConfig : DapperEntityConfiguration<AnalyzeChequeMonthly>
    {
        public AnalyzeChequeMonthlyConfig()
        {
            SetList(@"
SELECT 
       pivotSub.SubKind ,
       pivotSub.MainKind ,
       pivotSub.[1]  As Farvardin ,
       pivotSub.[2]  AS Ordibehesht,
       pivotSub.[3]  AS Xordad,
       pivotSub.[4]  AS Tir,
       pivotSub.[5]  AS Mordad,
       pivotSub.[6]  AS Shahrivar,
       pivotSub.[7]  AS Mehr,
       pivotSub.[8]  AS Aban,
       pivotSub.[9]  AS Azar,
       pivotSub.[10] AS Dey,
       pivotSub.[11] AS Bahman,
       pivotSub.[12] AS Esfand

FROM (
SELECT 
dd.PersianMonthNo,
tad.kind								AS SubKind,
(1)										AS MainKind,
SUM(tac.mablaq)							AS Balance


FROM		Xazane.tbl_Amaliat_Check	AS tac
INNER JOIN	Xazane.tbl_Amaliat_DP		AS tad	ON tad.ID = tac.FK_DP
INNER JOIN General.DimDate				AS dd	ON dd.GregorianDate = tad.tarikh

WHERE       tad.FK_Salmali =@Year
GROUP BY    tad.kind ,dd.PersianMonthNo,dd.PersianMonthName

UNION ALL
SELECT 
	(CASE WHEN tac.Kind_Vaziat IS NULL 
		  THEN dd.PersianMonthNo 
		  ELSE ddVaziat.PersianMonthNo 
	END) AS PersianMonthNo,
	(CASE 
		WHEN tac.Kind_Vaziat IS NULL 
		THEN 10 
		ELSE tac.Kind_Vaziat 
	END )								AS SubKind,
	(2)									AS MainKind,
	SUM(tac.mablaq)						AS Balance

FROM		Xazane.tbl_Amaliat_Check	AS tac
INNER JOIN	Xazane.tbl_Amaliat_DP		AS tad		ON tad.ID = tac.FK_DP
INNER JOIN General.DimDate				AS dd		ON dd.GregorianDate = tad.tarikh
LEFT OUTER JOIN General.DimDate			AS ddVaziat ON tac.Tarix_Vaziat =ddVaziat.GregorianDate

WHERE       tac.FK_Salmali_Vaziat = @Year OR (tac.Kind_Vaziat IS NULL AND tad.FK_Salmali=@Year)
GROUP BY    tac.Kind_Vaziat,(CASE WHEN tac.Kind_Vaziat IS NULL THEN dd.PersianMonthNo ELSE ddVaziat.PersianMonthNo END)

) AS Sub
PIVOT 
(	SUM(Balance) 
	FOR PersianMonthNo IN ([1],[2],[3],[4],[5],[6],[7],[8],[9],[10],[11],[12])
) pivotSub


");
        }
    }
}
