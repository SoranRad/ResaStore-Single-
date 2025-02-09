using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.Report.Profit;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.Report.Profit
{
    public class ProfitMonthlyConfig : DapperEntityConfiguration<ProfitMonthly>
    {
        public ProfitMonthlyConfig()
        {
            SetList(@"

SELECT 

	dd.PersianMonthNo
    ,dd.PersianMonthName
    ,COUNT(DISTINCT(tat.ID)) AS CountFactor

	,SUM(CASE WHEN tat.kind=@KindSale		then tar.mablaq ELSE 0 end)		AS MountSale
	,SUM(CASE WHEN tat.kind=@KindSaleBack	then tar.mablaq ELSE 0 end)		AS MountSaleBack


	,SUM(
			CASE WHEN	tat.kind = @KindSale 
			THEN		tar.mablaq - tar.nerkh_2
			ELSE		-(tar.mablaq - tar.meqdar * tar.nerkh_2)  
			END
		) 
		AS Profit

FROM					General.DimDate				AS dd		
		LEFT OUTER JOIN Anbar.tbl_Amaliat_Title		AS tat	ON tat.tarikh	= dd.GregorianDate
		LEFT OUTER JOIN Anbar.tbl_Amaliat_Riz		AS tar  ON tar.FK_Title = tat.ID		

		WHERE		
			  (
				tat.kind	= @KindSale
				OR tat.kind = @KindSaleBack
			  )
		  AND tat.FK_Salmali	= @Year 

		GROUP BY dd.PersianMonthNo, dd.PersianMonthName
		HAVING SUM(CASE WHEN tat.kind = @KindSale then tar.meqdar ELSE 0 end) >0
		ORDER BY dd.PersianMonthNo
");
        }
    }
}
//SELECT 

//	dd.PersianMonthNo,
//	dd.PersianMonthName
//	,COUNT(DISTINCT(tat.ID)) AS CountFactor
//	,SUM(tar.mablaq)AS Mablaq
//	,SUM(tar.mablaq - tar.nerkh_2) AS Profit

//FROM					General.DimDate				AS dd		
//		LEFT OUTER JOIN Anbar.tbl_Amaliat_Title		AS tat	ON tat.tarikh	= dd.GregorianDate	
//		LEFT OUTER JOIN Anbar.tbl_Amaliat_Riz		AS tar  ON tar.FK_Title = tat.ID		

//		WHERE		
//		            tat.kind          = 50  
//                AND dd.PersianYearInt = @Year 

//		GROUP BY dd.PersianMonthNo, dd.PersianMonthName
//		ORDER BY dd.PersianMonthNo