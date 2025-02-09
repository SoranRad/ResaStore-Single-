using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Interfaces;
using ShareLib.ViewModel;

namespace NZ.Xazane.DataLayer.DapperConfig.ViewModel
{
    public class CircularRowItemConfig : DapperEntityConfiguration<CircularRowItem>
    {
        public CircularRowItemConfig()
        {
            SetList(@"
SELECT
(4)		AS SubSystem,
tad.ID ,
tad.tarikh AS Date,
LTRIM(RTRIM(tad.sharh)) AS Description,
dd.PersianStr,
tad.kind,
Xazane.GetDPDetail(tad.ID) AS Title,
(CASE WHEN tad.kind = 1 THEN 0 ELSE ISNULL(Cheque.mablaq,0)+ISNULL(CashPos.mablaq,0)-ISNULL(tad.takhfif,0) END) AS Debit,
(CASE WHEN tad.kind = 1 THEN ISNULL(Cheque.mablaq,0)+ISNULL(CashPos.mablaq,0)-ISNULL(tad.takhfif,0) ELSE 0 END ) AS Credit

FROM 
Xazane.tbl_Amaliat_DP AS tad
LEFT OUTER JOIN (
SELECT tax2.FK_DP,SUM(tax2.mablaq) AS Mablaq 
FROM Xazane.tbl_Amaliat_Xazaneh AS tax2
GROUP BY tax2.FK_DP
) AS CashPos ON CashPos.FK_DP = tad.ID

LEFT OUTER JOIN(
SELECT tac2.FK_DP,SUM(tac2.mablaq)AS Mablaq 
FROM Xazane.tbl_Amaliat_Check AS tac2
GROUP BY tac2.FK_DP
) AS Cheque ON Cheque.FK_DP = tad.ID
INNER JOIN General.DimDate					AS dd  ON dd.GregorianDate = tad.tarikh
WHERE 
	 (tad.FK_Salmali	= @Year OR @Year IS NULL)
AND  tad.FK_ShaXs	= @People
AND (tad.kind = 1		   OR tad.kind = 2)
AND (tad.tarikh>=@DateFrom OR @DateFrom IS NULL)
AND (tad.tarikh<=@DateTo   OR @DateTo   IS NULL)

UNION ALL 
--======= کسورات
SELECT 

(4)		AS SubSystem,
tad.ID ,
tad.tarikh AS Date,
LTRIM(RTRIM(tad.sharh)) AS Description,
dd.PersianStr,
tax.kind,
(CASE WHEN tax.kind = 6 THEN N'کسورات حساب شخص ' ELSE N'اضـافات حسـاب شخص ' END ) AS Title,
(CASE WHEN tax.kind = 7 THEN 0 ELSE tax.mablaq END )  AS Debit,
(CASE WHEN tax.kind = 7 THEN tax.mablaq ELSE 0 END )  AS Credit

FROM 
Xazane.tbl_Amaliat_Xazaneh  AS tax
LEFT OUTER JOIN Xazane.tbl_Amaliat_DP AS tad ON tax.FK_DP = tad.ID
INNER JOIN General.DimDate					AS dd  ON dd.GregorianDate = tad.tarikh
WHERE 
	 (tad.FK_Salmali	= @Year OR @Year IS NULL)
AND  tad.FK_ShaXs	= @People
AND (tax.kind = 6		   OR tax.kind = 7)
AND (tad.tarikh>=@DateFrom OR @DateFrom IS NULL)
AND (tad.tarikh<=@DateTo   OR @DateTo   IS NULL)

UNION ALL 
---=====واگذاری چک 
SELECT
(4)			AS SubSystem,
tad.ID ,
tad.tarikh	AS Date,
LTRIM(RTRIM(tac.Sharh_Vaziat)) AS Description,
dd.PersianStr,
15 AS Kind,
N' '+LTRIM(RTRIM(ta.title))	
			AS Title,
tac.mablaq	AS Debit,
(0)			AS Credit

FROM  Xazane.tbl_Amaliat_Check		AS tac
INNER JOIN Xazane.tbl_Amaliat_DP	AS tad ON tad.ID = tac.FK_DP
LEFT OUTER JOIN General.DimDate		AS dd  ON dd.GregorianDate = tad.tarikh 
INNER JOIN Base.tbl_Ashxas			AS ta  ON tad.FK_ShaXs = ta.ID
WHERE
	(tac.FK_Salmali_Vaziat	= @Year OR @Year IS NULL)
AND  tac.FK_Shaxs_Vaziat	= @People
AND (tac.Kind_Vaziat = 2)
AND (tac.Tarix_Vaziat>=@DateFrom OR @DateFrom IS NULL)
AND (tac.Tarix_Vaziat<=@DateTo   OR @DateTo   IS NULL)

--========================= برگشت چـک 
UNION ALL

SELECT
(4)			AS SubSystem,
tad.ID ,
tad.tarikh	AS Date,
LTRIM(RTRIM(tac.Sharh_Vaziat)) AS Description,
dd.PersianStr,
16 as kind,
N' به شماره '+ ltrim(rtrim(tac.shomare_check))
			AS Title,
(CASE WHEN tac.kind = 2 THEN 0 ELSE tac.mablaq END) AS Debit,
(CASE WHEN tac.kind = 2 THEN tac.mablaq ELSE 0 END )AS Credit

FROM  Xazane.tbl_Amaliat_Check		AS tac
INNER JOIN Xazane.tbl_Amaliat_DP	AS tad ON tad.ID = tac.FK_DP
LEFT OUTER JOIN General.DimDate		AS dd  ON dd.GregorianDate = tad.tarikh 
WHERE
	(tac.FK_Salmali_Vaziat	= @Year OR @Year IS NULL)
AND  tad.FK_ShaXs			= @People
AND  tac.Kind_Vaziat        = 3
AND (tac.Tarix_Vaziat>=@DateFrom OR @DateFrom IS NULL)
AND (tac.Tarix_Vaziat<=@DateTo   OR @DateTo   IS NULL)

UNION ALL

--================  مانده حساب قبلی 
SELECT 
(4)		AS SubSystem,
tad.ID ,
tad.tarikh AS Date,
LTRIM(RTRIM(tad.sharh)) AS Description,
dd.PersianStr,
tad.kind,
N'مانده حساب قبلی ' AS Title,
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
 
FROM 
Xazane.tbl_Amaliat_DP						AS tad
LEFT OUTER JOIN (
				SELECT 
					ts.Salmali,
					ROW_NUMBER() OVER (ORDER BY ts.Salmali) AS RowNumber
				FROM General.tbl_Salmali AS ts

				)							AS Years ON tad.FK_Salmali = Years.Salmali
LEFT OUTER JOIN Xazane.tbl_Amaliat_Xazaneh  AS tax ON tax.FK_DP = tad.ID
INNER JOIN General.DimDate					AS dd  ON dd.GregorianDate = tad.tarikh
WHERE 
	(tad.FK_Salmali	= @Year		OR @Year IS  NULL)
AND  tad.FK_ShaXs	= @People
AND (tad.kind		= 11		OR tad.kind = 12)
AND (tad.tarikh>=@DateFrom		OR @DateFrom IS NULL)
AND (tad.tarikh<=@DateTo		OR @DateTo   IS NULL)

");
        }

    }
}
