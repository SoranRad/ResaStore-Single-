using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.Report.Profit;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.Report.Profit
{
    public class ProfitDialyConfig : DapperEntityConfiguration<ProfitDaily>
    {
        public ProfitDialyConfig()
        {
SetList(@"

SELECT 
            dd.PersianDayOfWeekName
            ,dd.PersianStr
			,tat.tarikh
			,COUNT(DISTINCT(tat.ID))		AS CountFactor
			,LTRIM(RTRIM(Anbar.Title))		AS Anbar_Title
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
		LEFT OUTER JOIN Anbar.tbl_Amaliat_Title		AS tat		ON tat.tarikh	= dd.GregorianDate	
		INNER JOIN  Base.tbl_Base_Anbar				AS Anbar    ON Anbar.ID		= tat.FK_Anbar_Az
		LEFT OUTER JOIN Anbar.tbl_Amaliat_Riz		AS tar		ON tar.FK_Title = tat.ID		

WHERE		 (tat.FK_Anbar_Az in @Anbars)
          AND(
				tat.kind	= @KindSale
				OR tat.kind = @KindSaleBack
			 )			  
		  AND dd.PersianYearInt	 = @Year 
          AND (dd.PersianMonthNo = @MonthNo OR @MonthNo IS NULL)

GROUP BY	dd.PersianStr,tat.tarikh,dd.PersianDayOfWeekName,tat.FK_Anbar_Az,Anbar.Title
HAVING		SUM(CASE WHEN tat.kind = @KindSale then tar.meqdar ELSE 0 end) >0
ORDER BY	tat.tarikh


");
        }
    }
}