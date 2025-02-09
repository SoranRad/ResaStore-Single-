using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Xazane.Model.Report;
using ShareLib.Interfaces;

namespace NZ.Xazane.DataLayer.DapperConfig.Report
{
    public class AnalyzeChequeConfig : DapperEntityConfiguration<AnalyzeCheque>
    {
        public AnalyzeChequeConfig()
        {
            SetList(@"
SELECT 

tad.kind								AS SubKind,
(1)										AS MainKind,
COUNT(tac.ID)							AS ChequeCount,
SUM(tac.mablaq)							AS Balance,
COUNT(DISTINCT tad.FK_ShaXs)			AS PeopeleCount

FROM		Xazane.tbl_Amaliat_Check	AS tac
INNER JOIN	Xazane.tbl_Amaliat_DP		AS tad ON tad.ID = tac.FK_DP

WHERE       tad.FK_Salmali =@Year
GROUP BY    tad.kind

UNION ALL
SELECT 

(CASE 
WHEN tac.Kind_Vaziat IS NULL 
THEN 10 
ELSE tac.Kind_Vaziat END )				AS SubKind,
(2)										AS MainKind,
COUNT(tac.ID)							AS ChequeCount,
SUM(tac.mablaq)							AS Balance,
COUNT(DISTINCT tad.FK_ShaXs)			AS PeopeleCount

FROM		Xazane.tbl_Amaliat_Check	AS tac
INNER JOIN	Xazane.tbl_Amaliat_DP		AS tad ON tad.ID = tac.FK_DP

WHERE       tac.FK_Salmali_Vaziat = @Year OR (tac.Kind_Vaziat IS NULL AND tad.FK_Salmali=@Year)
GROUP BY    tac.Kind_Vaziat
");
        }
    }
}
