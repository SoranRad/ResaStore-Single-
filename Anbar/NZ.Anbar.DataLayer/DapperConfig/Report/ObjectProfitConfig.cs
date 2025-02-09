using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.Report;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.Report
{
    public class ObjectProfitConfig : DapperEntityConfiguration<ObjectProfit>
    {
        public ObjectProfitConfig()
        {
            SetList(@"


SELECT 
			LTRIM(RTRIM(tgk.title))		AS GroupTitle
			,tkx.Code
            ,RTRIM(LTRIM(tkx.title))	AS Title
			,LTRIM(RTRIM(tv.title))		AS UnitTitle

			,SUM(CASE WHEN tat.kind=@KindSale		then tar.meqdar ELSE 0 end)		AS CountSale
			,SUM(CASE WHEN tat.kind=@KindSaleBack	then tar.meqdar ELSE 0 end)		AS CountSaleBack

			,SUM(CASE WHEN tat.kind=@KindSale		then tar.mablaq ELSE 0 end)		AS MountSale
			,SUM(CASE WHEN tat.kind=@KindSaleBack	then tar.mablaq ELSE 0 end)		AS MountSaleBack


			,SUM(
					CASE WHEN	tat.kind=@KindSale 
					THEN		tar.mablaq - tar.nerkh_2
					ELSE		-(tar.mablaq - tar.meqdar * tar.nerkh_2)  
					END
				) 
				AS Profit


FROM				Anbar.tbl_Amaliat_Riz		AS tar  
		INNER JOIN	Anbar.tbl_Amaliat_Title		AS tat	ON tat.ID		= tar.FK_Title
		INNER JOIN	Base.tbl_Kala_Xadamat		AS tkx	ON tkx.Code		= tar.FK_Kala
		INNER JOIN	Base.tbl_Vahed				AS tv	ON tv.ID		= tkx.FK_Vahed
		INNER JOIN	Base.tbl_GroupKala_2th		AS tgk	ON tgk.Code		= tkx.FK_GroupKala_2th

		WHERE		
			  (
				tat.kind	= @KindSale
				OR tat.kind = @KindSaleBack
			  )
		  AND tat.FK_Salmali	= @Year 


		GROUP BY tkx.Code, tkx.title ,tv.title,tgk.title
		HAVING SUM(CASE WHEN tat.kind = @KindSale then tar.meqdar ELSE 0 end) >0
		ORDER BY tkx.Code



");
        }
    }
}


//SELECT 
//			LTRIM(RTRIM(tgk.title)) AS GroupTitle,
//			tkx.Code,
//			RTRIM(LTRIM(tkx.title)) AS Title
//			,SUM(tar.meqdar) AS CountSale
//			,LTRIM(RTRIM(tv.title)) AS UnitTitle
//			,SUM(tar.mablaq)AS Mablaq
//			,SUM(tar.mablaq - tar.nerkh_2) AS Profit


//FROM					Anbar.tbl_Amaliat_Riz		AS tar  
//		LEFT OUTER JOIN Anbar.tbl_Amaliat_Title		AS tat	ON tat.ID		= tar.FK_Title
//		INNER JOIN Base.tbl_Kala_Xadamat			AS tkx	ON tkx.Code		= tar.FK_Kala
//		LEFT OUTER JOIN Base.tbl_Vahed				AS tv	ON tv.ID		= tkx.FK_Vahed
//		LEFT OUTER JOIN Base.tbl_GroupKala_2th		AS tgk	ON tgk.Code		= tkx.FK_GroupKala_2th

//		WHERE		
//			  tat.kind			= 50  				  
//		  AND tat.FK_Salmali	= @Year 


//		GROUP BY tkx.Code, tkx.title ,tv.title,tgk.title
//		ORDER BY tkx.Code

