using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Interfaces;
using ShareLib.ViewModel;

namespace Nz.Bar.DataLayer.DapperConfig.Bill
{
	public class CircularRowItemConfig  : DapperEntityConfiguration<CircularRowItem>
	{
		public CircularRowItemConfig()
		{
			SetList(@"
SELECT 
 
(9)         AS SubSystem ,
tbf.ID ,
dd.PersianStr,
tbf.tarikh  AS Date,
tbf.kind,
N'خـرید '   AS Description,
 FORMAT(tbf.VaznKHales, 'N0')+ N' کیلو ' +LTRIM(RTRIM(tkx.title)) AS Title,

(0)         AS Debit,
tbf.Mablaq  AS Credit, 

(0) AS Remaind

FROM        Bar.tbl_BarFactor       AS tbf
INNER JOIN  Base.tbl_Kala_Xadamat   AS tkx  ON  tkx.Code    = tbf.FK_Kala
LEFT OUTER JOIN General.DimDate     AS dd   ON  tbf.tarikh  = dd.GregorianDate 

WHERE

    (tbf.FK_Salmali  =  @Year     OR @Year IS NULL)
AND (tbf.FK_People   =  @People ) 
AND (tbf.tarikh     >= @DateFrom  OR @DateFrom IS NULL)
AND (tbf.tarikh     <= @DateTo    OR @DateTo   IS NULL)

");
		}
	}
}
