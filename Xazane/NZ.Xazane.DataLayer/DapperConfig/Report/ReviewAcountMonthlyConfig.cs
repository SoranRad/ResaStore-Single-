using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Xazane.Model.Report;
using ShareLib.Interfaces;

namespace NZ.Xazane.DataLayer.DapperConfig.Report
{
    public class ReviewAcountMonthlyConfig : DapperEntityConfiguration<ReviewAcountMonthly>
    {
        public ReviewAcountMonthlyConfig()
        {
            SetList(@"

SELECT 
	 pivotSub.ID ,
     LTRIM(RTRIM(pivotSub.title )) as Title,
     pivotSub.mojudi_avalie ,
     pivotSub.Kind ,
     pivotSub.Code ,
	 pivotSub.[1]   As Farvardin ,
     pivotSub.[2]   AS Ordibehesht,
     pivotSub.[3]   AS Xordad,
     pivotSub.[4]   AS Tir,
     pivotSub.[5]   AS Mordad,
     pivotSub.[6]   AS Shahrivar,
     pivotSub.[7]   AS Mehr,
     pivotSub.[8]   AS Aban,
     pivotSub.[9]   AS Azar,
     pivotSub.[10]  AS Dey,
     pivotSub.[11]  AS Bahman,
     pivotSub.[12]  AS Esfand

FROM
(

SELECT 

thx.ID,
thx.title,
thx.mojudi_avalie,
thx.Kind,
thx.Code,
(CASE WHEN tax.tarikh IS NULL 
	  THEN dd2.PersianMonthNo 
	  ELSE dd.PersianMonthNo 
END) AS Month,
SUM(CASE WHEN thx.ID=tax.FK_Xazaneh_Bad 
		 THEN tax.mablaq 
		 ELSE -tax.mablaq 
END) AS Circular

FROM Xazane.tbl_Hesab_Xazaneh				AS thx
LEFT OUTER JOIN Xazane.tbl_Amaliat_Xazaneh	AS tax	ON tax.FK_Xazaneh_Bad = thx.ID OR tax.FK_Xazaneh_Bas = thx.ID
LEFT OUTER JOIN Xazane.tbl_Amaliat_DP		AS tad	ON tad.ID = tax.FK_DP
LEFT OUTER JOIN General.DimDate				AS dd	ON dd.GregorianDate = tax.tarikh
LEFT OUTER JOIN General.DimDate				AS dd2	ON tad.tarikh = dd2.GregorianDate

WHERE tax.FK_Salmali = @Year
GROUP BY	thx.ID,
			thx.title,
			thx.Code,
			thx.mojudi_avalie,
			thx.Kind,
			(CASE WHEN tax.tarikh IS NULL 
				  THEN dd2.PersianMonthNo 
				  ELSE dd.PersianMonthNo 
			END)

UNION ALL

SELECT 

thx.ID,
thx.title,
thx.mojudi_avalie,
thx.Kind,
thx.Code,
dd.PersianMonthNo AS Month,
SUM(CASE WHEN thx.ID = tac.FK_Hesab_Pardaxtani
		 THEN -tac.mablaq
		 ELSE tac.mablaq
END)  AS Circular

FROM Xazane.tbl_Hesab_Xazaneh				AS thx

LEFT OUTER JOIN Xazane.tbl_Amaliat_Check	AS tac	ON tac.FK_Hesab_Pardaxtani = thx.ID OR tac.FK_Xazaneh_Vaziat = thx.ID
LEFT OUTER JOIN General.DimDate				AS dd	ON tac.Tarix_Vaziat = dd.GregorianDate

WHERE tac.FK_Salmali_Vaziat =@Year AND tac.Kind_Vaziat =@Kind
GROUP BY	thx.ID,
			thx.title,
			thx.Code,
			thx.mojudi_avalie,
			thx.Kind,
			dd.PersianMonthNo

) AS Sub 

PIVOT 
(	
	SUM(Sub.Circular) 
	FOR Month IN ([1],[2],[3],[4],[5],[6],[7],[8],[9],[10],[11],[12])
) pivotSub


");
        }
    }
}
