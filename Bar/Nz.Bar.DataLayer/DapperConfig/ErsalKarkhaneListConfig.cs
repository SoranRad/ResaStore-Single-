using Nz.Bar.Model.Report;
using ShareLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Bar.DataLayer.DapperConfig
{
	public class ErsalKarkhaneListConfig :  DapperEntityConfiguration<ErsalKarkhaneList>
	{
		public ErsalKarkhaneListConfig()
		{
			SetList(@"

SELECT 

[tek].[ID],
[tek].[FK_Salmali],
[tek].[is_ok],
[tek].[FK_Car],
[tek].[FK_Karkhane],
[tek].[Serial],
[tek].[Tarikh],
[tek].[ShomareGhabz],
LTRIM(RTRIM([tek].[Tozihat])) AS Tozihat  ,
[tek].[VaznNaKhales],
[tek].[VaznKHali],
[tek].[DarsadOft],
[tek].[VaznOft],
[tek].[VaznKHales],
[tek].[Nerkh],
[tek].[Mablaq],
[tek].[MablaqKeraye] ,

 dd.PersianStr,
 dd.PersianMonthNo,
 dd.PersianDayInMonth,

(CASE when tek.FK_Car IS NULL then null else  LTRIM(RTRIM(taCar.title))+N' '+LTRIM(RTRIM(tc.CarType))+N' '+LTRIM(RTRIM(tc.Plak)) END) AS CarTitle,
LTRIM(RTRIM(ta.title)) AS KarkhaneTitle

FROM				Bar.tbl_ErsalKarkhane	AS tek
LEFT OUTER JOIN     Bar.tbl_Car				AS tc       ON tc.ID                = tek.FK_Car
LEFT outer JOIN     Base.tbl_Ashxas			AS taCar    ON taCar.ID             = tc.FK_People
INNER JOIN          Base.tbl_Ashxas			AS ta       ON ta.ID                = tek.FK_Karkhane 
INNER JOIN          General.DimDate			AS dd       ON dd.GregorianDate     = tek.tarikh

WHERE  (tek.FK_Salmali =@Year AND (dd.PersianMonthNo=@Month OR @Month=13))


");
		}
	}
}
