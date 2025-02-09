using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Interfaces;
using ShareLib.ViewModel;

namespace NZ.Xazane.DataLayer.DapperConfig.Report
{
    public class DailyCircularConfig : DapperEntityConfiguration<DailyCircular>
    {
        public DailyCircularConfig()
        {
            SetList(@"
SELECT 

        dd.GregorianDate,
        dd.PersianStr,
        dd.PersianMonthName,
        dd.PersianMonthNo,

        Cache.Daryaft		AS DaryaftCache,
        Cache.Pardaxt		AS CachePardaxt,
        Pos.Daryaft			AS DaryaftPos,
        Pos.Pardaxt			AS POSPardaxt,
        Cheque.Daryaft		AS DaryaftCheck,
        Cheque.Pardaxt		AS ChequePardaxt,
        CostIncome.Hazine ,
        CostIncome.Daramad


FROM General.DimDate AS dd
LEFT OUTER JOIN (

			SELECT 
			tad.tarikh,
			SUM(CASE 
					WHEN tad.kind = @KindDaryaft  THEN tax.mablaq 
					WHEN tad.kind = @KindPardaxt  THEN 0 
					ELSE 0
				END) AS Daryaft,
			SUM(CASE 
					WHEN tad.kind = @KindDaryaft  THEN 0
					WHEN tad.kind = @KindPardaxt  THEN tax.mablaq 
					ELSE 0  
				END) AS Pardaxt

			FROM		Xazane.tbl_Amaliat_Xazaneh	AS tax
			INNER JOIN	Xazane.tbl_Amaliat_DP		AS tad ON tad.ID = tax.FK_DP

			WHERE 
						tax.kind = @KindCache
					AND tad.FK_Salmali = @Year
			GROUP BY 
					tad.tarikh

) AS Cache ON Cache.tarikh = dd.GregorianDate

LEFT OUTER JOIN (

			SELECT 
			tad.tarikh,
			SUM(CASE 
					WHEN tad.kind = @KindDaryaft  THEN tax.mablaq 
					WHEN tad.kind = @KindPardaxt  THEN 0 
					ELSE 0
				END) AS Daryaft,
			SUM(CASE 
					WHEN tad.kind = @KindDaryaft  THEN 0
					WHEN tad.kind = @KindPardaxt  THEN tax.mablaq 
					ELSE 0  
				END) AS Pardaxt

			FROM		Xazane.tbl_Amaliat_Xazaneh	AS tax
			INNER JOIN	Xazane.tbl_Amaliat_DP		AS tad ON tad.ID = tax.FK_DP

			WHERE 
						tax.kind = @kindPOS 
					AND tad.FK_Salmali = @Year

			GROUP BY 
					tad.tarikh

) AS Pos ON Pos.tarikh = dd.GregorianDate

LEFT OUTER  JOIN
(

		SELECT 

			tad.tarikh,

			SUM(CASE 
					WHEN tad.kind = @KindDaryaft  THEN tac.mablaq 
					WHEN tad.kind = @KindPardaxt  THEN 0 
					ELSE 0
				END) AS Daryaft,
			SUM(CASE 
					WHEN tad.kind = @KindDaryaft  THEN 0
					WHEN tad.kind = @KindPardaxt  THEN tac.mablaq  
					ELSE 0  
				END) AS Pardaxt


		FROM		Xazane.tbl_Amaliat_Check AS tac
		INNER JOIN	Xazane.tbl_Amaliat_DP AS tad ON tad.ID = tac.FK_DP

		WHERE 
				tad.FK_Salmali =@Year

		GROUP BY
				tad.tarikh
)AS Cheque ON Cheque.tarikh = dd.GregorianDate

LEFT OUTER JOIN (

		SELECT 
			tax.tarikh,
			SUM(CASE 
					WHEN tax.kind = @KindHazine  THEN tax.mablaq 
					ELSE 0
				END) AS Hazine,
			SUM(CASE 
					WHEN tax.kind = @KindDaramad  THEN tax.mablaq 
					ELSE 0
				END) AS Daramad



		FROM Xazane.tbl_Amaliat_Xazaneh AS tax 

		WHERE 
				tax.FK_Salmali = @Year
			AND (tax.kind = @KindHazine OR tax.kind = @KindDaramad)

		GROUP BY 
			tax.tarikh

) AS CostIncome ON CostIncome.tarikh = dd.GregorianDate

WHERE 
dd.PersianYearInt = @Year
AND ( dd.PersianMonthNo = @Month OR @Month = 13 )
AND (
		Cache.Daryaft > 0		OR Cache.Pardaxt > 0 
	OR  Pos.Daryaft > 0			OR Pos.Pardaxt > 0
	OR  Cheque.Daryaft > 0		OR Cheque.Pardaxt > 0
	OR  CostIncome.Hazine > 0	OR CostIncome.Daramad > 0
	)



");

        }
    }
}
