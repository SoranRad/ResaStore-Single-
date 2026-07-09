using ShareLib.Interfaces;
using ShareLib.Models.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ.Xazane.DataLayer.DapperConfig.Partner
{
	public class PartnerBardashtDapperConfig : DapperEntityConfiguration<PartnerBardasht>
	{
		public PartnerBardashtDapperConfig()
		{
			SetList(@"

SELECT 

ta.ID,
ta.code,
LTRIM(RTRIM(ta.title ))		AS title,
ta.PartnerPercent,
(
 ISNULL(CacheDeficit.Remaind,0)
+ISNULL(PreRemain.Remaind,0)
+ISNULL(Cheque.Remaind,0)
+ISNULL(ChequeBack.Remaind,0)
+ISNULL(Assign.Remaind,0)
+ISNULL(OFFAmount.Remaind,0)

) AS Balance


FROM Base.tbl_Ashxas AS ta
LEFT OUTER JOIN Base.tbl_Group_Ashxas AS tga ON tga.ID = ta.FK_Group

LEFT OUTER JOIN(

	SELECT 
		tad.FK_ShaXs,
		SUM(CASE WHEN tad.kind=1 OR tad.kind=7 
			THEN -tax.mablaq ELSE tax.mablaq END) AS Remaind
	FROM Xazane.tbl_Amaliat_Xazaneh		AS tax
	INNER JOIN Xazane.tbl_Amaliat_DP	AS tad ON tad.ID = tax.FK_DP

	WHERE tad.FK_ShaXs IS NOT NULL AND tad.FK_Salmali = @Year
	AND  (tad.tarikh >=@Start OR @Start IS NULL)
	AND  (tad.tarikh <=@End OR @End IS NULL)

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
    AND   tad.FK_ShaXs IS NOT NULL 
    AND   tad.FK_Salmali = @Year
	AND  (tad.tarikh >=@Start OR @Start IS NULL)
	AND  (tad.tarikh <=@End OR @End IS NULL)

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
	AND  (tad.tarikh >=@Start OR @Start IS NULL)
	AND  (tad.tarikh <=@End OR @End IS NULL)

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
	AND  (tad.tarikh >=@Start OR @Start IS NULL)
	AND  (tad.tarikh <=@End OR @End IS NULL)

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
		AND (tac.Tarix_Vaziat >= @Start OR @Start IS NULL)
		AND (tac.Tarix_Vaziat <= @End OR @End IS NULL)

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
	AND (tac.Tarix_Vaziat >= @Start OR @Start IS NULL)
	AND (tac.Tarix_Vaziat <= @End OR @End IS NULL)

	GROUP BY tac.FK_Shaxs_Vaziat

) AS Assign ON Assign.FK_Shaxs_Vaziat = ta.ID


WHERE 
    ta.IsPartner = 1 
   


");
		}
	}
}
