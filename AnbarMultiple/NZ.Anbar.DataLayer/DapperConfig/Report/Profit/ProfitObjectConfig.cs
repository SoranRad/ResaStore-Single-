using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.Report.Profit;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.Report.Profit
{
    public class ProfitObjectConfig: DapperEntityConfiguration<ProfitObject>
    {
        public ProfitObjectConfig()
        {
            SetList(@"

SELECT 
			tkx.Code
			,RTRIM(LTRIM(tkx.title)) AS Title
			,LTRIM(RTRIM(tv.title)) AS UnitTitle
			,LTRIM(RTRIM(Anbar.Title))   AS Anbar_Title
			
			,SUM(CASE WHEN tat.kind=@KindSale		THEN tar.meqdar ELSE 0 end)		AS CountSale
			,SUM(CASE WHEN tat.kind=@KindSaleBack	THEN tar.meqdar ELSE 0 end)		AS CountSaleBack

			
			,SUM(CASE WHEN tat.kind=@KindSale		then tar.mablaq ELSE 0 end)		AS MountSale
			,SUM(CASE WHEN tat.kind=@KindSaleBack	then tar.mablaq ELSE 0 end)		AS MountSaleBack


			,SUM(
					CASE WHEN	tat.kind = @KindSale 
					THEN		tar.mablaq - tar.nerkh_2
					ELSE		-(tar.mablaq - tar.meqdar * tar.nerkh_2)  
					END
				) 
				AS Profit


FROM					Anbar.tbl_Amaliat_Riz		AS tar  
		LEFT OUTER JOIN Anbar.tbl_Amaliat_Title		AS tat		ON tat.ID		= tar.FK_Title
		INNER JOIN  Base.tbl_Base_Anbar				AS Anbar	ON Anbar.ID		= tat.FK_Anbar_Az
		INNER JOIN Base.tbl_Kala_Xadamat			AS tkx		ON tkx.Code		= tar.FK_Kala
		LEFT OUTER JOIN Base.tbl_Vahed				AS tv		ON tv.ID		= tkx.FK_Vahed

WHERE	
			(tat.FK_Anbar_Az in @Anbars)
        AND	(
				tat.kind	= @KindSale
				OR tat.kind = @KindSaleBack
			)			  	  
		  AND tat.FK_Salmali	= @Year 
          AND tat.tarikh		= @tarikh

GROUP BY tkx.Code,tkx.title,tv.title, tat.FK_Anbar_Az,Anbar.Title
HAVING SUM(CASE WHEN tat.kind = @KindSale then tar.meqdar ELSE 0 end) >0
ORDER BY tkx.Code

");

        }
    }
}
