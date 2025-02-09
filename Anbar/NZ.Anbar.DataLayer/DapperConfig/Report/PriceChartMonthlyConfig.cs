using Nz.Anbar.Model.Report;
using ShareLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ.Anbar.DataLayer.DapperConfig.Report
{
	public class PriceChartMonthlyConfig  : DapperEntityConfiguration<PriceChartMonthly>
	{
		public PriceChartMonthlyConfig()
		{
			SetList(@"
SELECT 

dd.PersianMonthName,
dd.PersianMonthNo,
ROUND(AVG(tar.nerkh),0) AS Price
 

FROM		Anbar.tbl_Amaliat_Riz    AS tar
INNER JOIN	Anbar.tbl_Amaliat_Title  AS tat on tat.ID		= tar .FK_Title
LEFT OUTER	JOIN General.DimDate     AS dd  on tat.tarikh	= dd.GregorianDate

WHERE tat.kind = @Kind AND tar.FK_Kala = @Kala  AND tar.FK_Salmali = @Year

GROUP BY dd.PersianMonthName,dd.PersianMonthNo


");
		}
	}
}
