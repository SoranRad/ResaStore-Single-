using Nz.Bar.Model.Report;
using ShareLib.Interfaces;
using ShareLib.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Bar.DataLayer.DapperConfig.Report
{
	public class RemaindKarkhaneDapperConfig : DapperEntityConfiguration<RemaindKarkhane> 
	{
		public RemaindKarkhaneDapperConfig()
		{
			SetList(@"

				SELECT 

ta.ID,
ta.code,
LTRIM(RTRIM(ta.title ))		AS Title,
LTRIM(RTRIM(tga.Title))		AS GroupTitle,
ta.FK_Group ,
ta.kind ,
RTRIM(LTRIM(ta.namePedar))	AS  namePedar,
RTRIM(LTRIM(ta.codeMeli))	AS  codeMeli,
RTRIM(LTRIM(ta.tel))		AS tel ,
RTRIM(LTRIM(ta.mobile))		AS mobile,

 ISNULL(Bar.Balance,0)
+ISNULL(Ersal.Balance,0) 
+ISNULL(CacheDeficit.Remaind,0)
+ISNULL(PreRemain.Remaind,0)
+ISNULL(Cheque.Remaind,0)
+ISNULL(ChequeBack.Remaind,0)
+ISNULL(Assign.Remaind,0)
+ISNULL(OFFAmount.Remaind,0)

AS  Balance


FROM Base.tbl_Ashxas AS ta
LEFT OUTER JOIN Base.tbl_Group_Ashxas AS tga ON tga.ID = ta.FK_Group

LEFT OUTER JOIN(

SELECT 
tbf.FK_People ,
-SUM(tbf.Mablaq) AS Balance  

FROM        Bar.tbl_BarFactor       AS tbf 

WHERE tbf.FK_Salmali = @Year 
AND  (tbf.tarikh >=@AzTarikh OR @AzTarikh IS NULL)
AND  (tbf.tarikh <=@TaTarikh OR @TaTarikh IS NULL)

GROUP BY  tbf.FK_People

) AS Bar on Bar.FK_People = ta.ID

LEFT OUTER JOIN(

SELECT 
tek.FK_Karkhane ,
SUM(tek.Mablaq) AS Balance  

FROM Bar.tbl_ErsalKarkhane          AS tek 

WHERE tek.FK_Salmali = @Year 
AND  (tek.tarikh >=@AzTarikh OR @AzTarikh IS NULL)
AND  (tek.tarikh <=@TaTarikh OR @TaTarikh IS NULL)

GROUP BY  tek.FK_Karkhane

) AS Ersal on Ersal.FK_Karkhane = ta.ID

LEFT OUTER JOIN(

	SELECT 
		tad.FK_ShaXs,
		SUM(CASE WHEN tad.kind=1 OR tad.kind=7 
			THEN -tax.mablaq ELSE tax.mablaq END) AS Remaind
	FROM Xazane.tbl_Amaliat_Xazaneh		AS tax
	INNER JOIN Xazane.tbl_Amaliat_DP	AS tad ON tad.ID = tax.FK_DP

	WHERE tad.FK_ShaXs IS NOT NULL AND tad.FK_Salmali = @Year
	AND  (tad.tarikh >=@AzTarikh OR @AzTarikh IS NULL)
	AND  (tad.tarikh <=@TaTarikh OR @TaTarikh IS NULL)

	GROUP BY tad.FK_ShaXs 

) AS CacheDeficit ON ta.ID=CacheDeficit.FK_ShaXs

LEFT OUTER JOIN (
	SELECT
		tad.FK_ShaXs,
		SUM(CASE WHEN tad.kind = 12 
			THEN -tad.takhfif ELSE tad.takhfif END) AS Remaind
	FROM Xazane.tbl_Amaliat_DP AS tad

	WHERE 
         (tad.kind = 12 OR tad.kind = 11 )
    AND   tad.FK_ShaXs IS NOT NULL AND tad.FK_Salmali = @Year
	AND  (tad.tarikh >=@AzTarikh OR @AzTarikh IS NULL)
	AND  (tad.tarikh <=@TaTarikh OR @TaTarikh IS NULL)

	GROUP BY tad.FK_ShaXs 
) AS PreRemain ON  PreRemain.FK_ShaXs = ta.ID

LEFT OUTER JOIN (
	SELECT
		tad.FK_ShaXs,
		SUM(CASE WHEN tad.kind = 1 
			THEN -tad.takhfif ELSE tad.takhfif END) AS Remaind
	FROM Xazane.tbl_Amaliat_DP AS tad

	WHERE 
         (tad.kind = 1 OR tad.kind = 2 )
    AND   tad.takhfif IS NOT NULL  
    AND   tad.FK_ShaXs IS NOT NULL AND tad.FK_Salmali = @Year
	AND  (tad.tarikh >=@AzTarikh OR @AzTarikh IS NULL)
	AND  (tad.tarikh <=@TaTarikh OR @TaTarikh IS NULL)

	GROUP BY tad.FK_ShaXs 
) AS OFFAmount ON  OFFAmount.FK_ShaXs = ta.ID

LEFT OUTER JOIN
(
	SELECT 

		tad.FK_ShaXs,
		SUM(CASE WHEN tad.kind = 1 
			THEN -tac.mablaq ELSE tac.mablaq END) AS Remaind

	FROM Xazane.tbl_Amaliat_Check AS tac
	INNER JOIN Xazane.tbl_Amaliat_DP AS tad ON tad.ID = tac.FK_DP

	WHERE tad.FK_Salmali =@Year
	AND  (tad.tarikh >=@AzTarikh OR @AzTarikh IS NULL)
	AND  (tad.tarikh <=@TaTarikh OR @TaTarikh IS NULL)

	GROUP BY tad.FK_ShaXs 

)AS Cheque ON Cheque.FK_ShaXs = ta.ID

LEFT OUTER JOIN  (
	SELECT 
		tad.FK_ShaXs,
		SUM(CASE WHEN tad.kind = 2 
			THEN -tac.mablaq ELSE tac.mablaq END) AS Remaind

	FROM		Xazane.tbl_Amaliat_Check	AS tac
	INNER JOIN	Xazane.tbl_Amaliat_DP		AS tad ON tad.ID = tac.FK_DP

	WHERE 
			tac.FK_Salmali_Vaziat = @Year
		AND tac.Kind_Vaziat = 3
		AND (tac.Tarix_Vaziat >= @AzTarikh OR @AzTarikh IS NULL)
		AND (tac.Tarix_Vaziat <= @TaTarikh OR @TaTarikh IS NULL)

	GROUP BY tad.FK_ShaXs 

)AS ChequeBack ON ChequeBack.FK_ShaXs = ta.ID

LEFT OUTER JOIN 
(
	SELECT 
		tac.FK_Shaxs_Vaziat,
		SUM( tac.mablaq ) AS Remaind

	FROM Xazane.tbl_Amaliat_Check AS tac

	WHERE 
		tac.FK_Salmali_Vaziat = @Year
	AND tac.Kind_Vaziat = 2
	AND tac.FK_Shaxs_Vaziat IS NOT NULL
	AND (tac.Tarix_Vaziat >= @AzTarikh OR @AzTarikh IS NULL)
	AND (tac.Tarix_Vaziat <= @TaTarikh OR @TaTarikh IS NULL)

	GROUP BY tac.FK_Shaxs_Vaziat

) AS Assign ON Assign.FK_Shaxs_Vaziat = ta.ID

WHERE ta.FK_Group = @Group
			");
		}
	}
}
