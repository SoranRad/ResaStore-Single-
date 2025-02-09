using Nz.Anbar.Model.Report;
using ShareLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ.Anbar.DataLayer.DapperConfig.Report
{
	public class TopPriceObjectConfig :   DapperEntityConfiguration<TopPriceObject>
	{
	public TopPriceObjectConfig()
	{
		SetList(@"
SELECT 

distinct Top(3)  
tar.nerkh,tat.kind, tat.tarikh,dd.PersianStr

FROM Anbar.tbl_Amaliat_Riz          AS tar
INNER JOIN Anbar.tbl_Amaliat_Title  AS tat on tat.ID = tar .FK_Title
LEFT OUTER JOIN General.DimDate     AS dd  on tat.tarikh = dd.GregorianDate

WHERE tat.kind = 50  AND tar.FK_Kala = @Kala  AND tar.FK_Salmali = @Year
 
UNION ALL

SELECT 

distinct Top(3)  
tar.nerkh,(12) AS kind, tat.tarikh,dd.PersianStr

FROM Anbar.tbl_Amaliat_Riz          AS tar
INNER JOIN Anbar.tbl_Amaliat_Title  AS tat on tat.ID = tar .FK_Title
LEFT OUTER JOIN General.DimDate     AS dd on tat.tarikh = dd.GregorianDate

WHERE (tat.kind = 12 OR tat.kind = 11)  AND tar.FK_Kala = @Kala  AND tar.FK_Salmali = @Year

ORDER by tat.tarikh DESC

");
	}

}
}
