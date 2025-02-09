using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Interfaces;
using ShareLib.Models;

namespace NZ.Xazane.DataLayer.DapperConfig.ViewModel
{
    public class BillRowItemConfig: DapperEntityConfiguration<BillRowItem>
    {
        public BillRowItemConfig()
        {
            //DECLARE @People BIGINT = 86,@DateFrom DATE, @DateTo DATE ,@Year SMALLINT = 1397, @Group TINYINT = 1
            SetList(@"

SELECT 

N'خزانه داری(دریافت و پرداخت)' AS SubsystemTitle ,
(2)				AS Subsystem,
(CASE WHEN tad.kind =1 OR tad.kind =7 THEN 1 ELSE 2 END)		AS Kind,
NULL	        AS Count,
tax.kind		AS Code,
N''				AS Title,
SUM( CASE WHEN tad.kind = 1 OR tad.kind =7 THEN 0 ELSE tax.mablaq END ) AS Debit,
SUM( CASE WHEN tad.kind = 1 OR tad.kind =7 THEN tax.mablaq ELSE 0 END ) AS Credit

FROM Xazane.tbl_Amaliat_Xazaneh  AS tax
INNER JOIN Xazane.tbl_Amaliat_DP AS tad ON tad.ID = tax.FK_DP

WHERE 
    (tad.FK_Salmali = @Year OR @Year IS NULL)
AND tad.FK_ShaXs=@People
AND (tad.tarikh>=@DateFrom OR @DateFrom IS NULL)
AND (tad.tarikh<=@DateTo   OR @DateTo   IS NULL)


GROUP BY (CASE WHEN tad.kind =1 OR tad.kind =7 THEN 1 ELSE 2 END)
,tax.kind 

UNION ALL
 
SELECT 

N'خزانه داری(دریافت و پرداخت)' 
				AS SubsystemTitle , 
(2)				AS Subsystem,
tad.kind		AS Kind,
NULL 	        AS Count,
13				AS Code,
N''				AS Title,

SUM( CASE WHEN tad.kind = 2 THEN tac.mablaq ELSE 0 END ) AS Debit,
SUM( CASE WHEN tad.kind = 1	THEN tac.mablaq ELSE 0 END ) AS Credit

FROM Xazane.tbl_Amaliat_Check	 AS tac
INNER JOIN Xazane.tbl_Amaliat_DP AS tad ON tad.ID = tac.FK_DP

WHERE 
	(tad.FK_Salmali = @Year OR @Year IS NULL)
AND  tad.FK_ShaXs	= @People 
AND (tad.tarikh >= @DateFrom OR @DateFrom IS NULL)
AND (tad.tarikh <= @DateTo   OR @DateTo   IS NULL)

GROUP BY tad.kind

UNION ALL
 
SELECT 
N'خزانه داری(دریافت و پرداخت)' 
				AS SubsystemTitle,
(2)				AS Subsystem,
tad.kind		AS Kind,
NULL 	        AS Count,
16				AS Code,
N''				AS Title,

SUM( CASE WHEN tad.kind = 2 THEN 0 ELSE tac.mablaq END ) AS Debit,
SUM( CASE WHEN tad.kind = 2 THEN tac.mablaq ELSE 0 END ) AS Credit

FROM Xazane.tbl_Amaliat_Check	 AS tac
INNER JOIN Xazane.tbl_Amaliat_DP AS tad ON tad.ID = tac.FK_DP

WHERE 
	(tac.FK_Salmali_Vaziat	= @Year OR @Year IS NULL)
AND  tad.FK_ShaXs			= @People
AND  ISNULL(tac.Kind_Vaziat,100) = 3 
AND (tac.Tarix_Vaziat>=@DateFrom OR @DateFrom IS NULL)
AND (tac.Tarix_Vaziat<=@DateTo   OR @DateTo   IS NULL)


GROUP BY tad.kind

UNION ALL
 
SELECT 
N'خزانه داری(دریافت و پرداخت)' 
				AS SubsystemTitle,
(2)				AS Subsystem,
2				AS Kind,
NULL 	        AS Count,
15				AS Code,
N''				AS Title,

SUM(tac.mablaq) AS Debit,
0				AS Credit

FROM Xazane.tbl_Amaliat_Check	 AS tac
INNER JOIN Xazane.tbl_Amaliat_DP AS tad ON tad.ID = tac.FK_DP

WHERE 
	 (tac.FK_Salmali_Vaziat	= @Year OR @Year IS NULL)
AND  tac.FK_Shaxs_Vaziat	= @People
AND  ISNULL(tac.Kind_Vaziat,100) = 2 
AND (tac.Tarix_Vaziat>=@DateFrom OR @DateFrom IS NULL)
AND (tac.Tarix_Vaziat<=@DateTo   OR @DateTo   IS NULL)

UNION ALL 

SELECT 

N'خزانه داری(دریافت و پرداخت)' AS SubsystemTitle , 
(2)				AS Subsystem,
11				AS Kind,
(NULL)			AS Count,
11		        AS Code,
N''				AS Title,

(CASE	
		WHEN @Year IS NULL AND Years.RowNumber = 1 
		THEN (CASE WHEN tad.kind = 11 THEN ISNULL(tad.takhfif,0) ELSE 0 END) 
		WHEN @Year IS NOT NULL THEN (CASE WHEN tad.kind = 11 THEN ISNULL(tad.takhfif,0) ELSE 0 END) 
		ELSE 0 

 END ) AS Debit,
(CASE 
		WHEN @Year IS NULL AND Years.RowNumber =1 
		THEN (CASE WHEN tad.kind = 11 THEN 0 ELSE  ISNULL(tad.takhfif,0) END )
		WHEN @Year IS NOT NULL THEN (CASE WHEN tad.kind = 11 THEN 0 ELSE  ISNULL(tad.takhfif,0) END )
		ELSE 0 END 
) AS Credit  


FROM Xazane.tbl_Amaliat_DP AS tad
LEFT OUTER JOIN (
				SELECT 
					ts.Salmali,
					ROW_NUMBER() OVER (ORDER BY ts.Salmali) AS RowNumber
				FROM General.tbl_Salmali AS ts

				)							AS Years ON tad.FK_Salmali = Years.Salmali
LEFT OUTER JOIN Xazane.tbl_Amaliat_Xazaneh  AS tax ON tax.FK_DP = tad.ID
WHERE 

(tad.kind =11 OR tad.kind =12 ) 
AND tad.FK_ShaXs = @People
AND (tad.FK_Salmali = @Year OR @Year IS NULL)
AND (tad.tarikh >= @DateFrom OR @DateFrom IS NULL)
AND (tad.tarikh <= @DateTo   OR @DateTo   IS NULL)

UNION ALL 

SELECT 

N'خزانه داری(دریافت و پرداخت)' AS SubsystemTitle , 
(2)				AS Subsystem,
tad.kind		AS Kind,
(NULL)			AS Count,
14		        AS Code,
N''				AS Title,
SUM( CASE WHEN tad.kind = 1 THEN tad.takhfif ELSE 0 END ) AS Debit,
SUM( CASE WHEN tad.kind = 2 THEN tad.takhfif ELSE 0 END ) AS Credit

FROM Xazane.tbl_Amaliat_DP AS tad

WHERE 
(tad.kind = 1 OR tad.kind = 2 )
AND ISNULL(tad.takhfif,0)<>0 
AND tad.FK_ShaXs = @People
AND (tad.FK_Salmali = @Year OR @Year IS NULL)
AND (tad.tarikh >= @DateFrom OR @DateFrom IS NULL)
AND (tad.tarikh <= @DateTo   OR @DateTo   IS NULL)

GROUP BY tad.kind
");
        }
    }
}
