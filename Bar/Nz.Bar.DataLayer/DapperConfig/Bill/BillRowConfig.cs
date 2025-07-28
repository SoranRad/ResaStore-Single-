using ShareLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Bar.Model.Report;

namespace Nz.Bar.DataLayer.DapperConfig.Bill
{
	public class BillRowConfig :  DapperEntityConfiguration<BillRow>
	{
		public BillRowConfig()
		{
			SetList(@"
SELECT 

[tbf].[ID],
dd.PersianStr,
[tbf].[Serial],
[tbf].[Tarikh],
[tbf].[VaznKHales],
[tbf].[Nerkh],
[tbf].[Mablaq]


FROM                Bar.tbl_BarFactor       AS tbf
INNER JOIN          General.DimDate         AS dd       ON dd.GregorianDate     = tbf.tarikh

WHERE tbf.FK_Salmali = @Year  AND  tbf.FK_People = @People

");
		}
	}
}
