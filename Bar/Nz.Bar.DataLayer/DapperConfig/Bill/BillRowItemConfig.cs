using ShareLib.Interfaces;
using ShareLib.Models;

namespace Nz.Bar.DataLayer.DapperConfig.Bill
{
	public class BillRowItemConfig : DapperEntityConfiguration<BillRowItem>
	{
		public BillRowItemConfig()
		{
			this.SetList(@"

SELECT 

(9)						AS  Subsystem,
tbf.kind				AS Kind,
N'خـرید محصول'			AS SubsystemTitle,

LTRIM(RTRIM(tkx.title)) AS Title,
SUM(tbf.VaznKHales)		AS Count,

(0)						AS Debit,
SUM(tbf.Mablaq)			AS Credit

FROM		Bar.tbl_BarFactor		AS tbf
INNER JOIN	Base.tbl_Kala_Xadamat	AS tkx ON tkx.Code = tbf.FK_Kala

WHERE

    (tbf.FK_Salmali  = @Year      OR @Year IS NULL)
AND (tbf.tarikh     >= @DateFrom  OR @DateFrom IS NULL)
AND (tbf.tarikh     <= @DateTo    OR @DateTo   IS NULL)
AND (tbf.FK_People   = @People) 

GROUP BY tbf.FK_Kala, tkx.title,tbf.kind

");
		}
	}
}
