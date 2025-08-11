using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Interfaces;
using ShareLib.ViewModel;

namespace Nz.Aqsat.DataLayer.DapperConfig.Bill
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
LTRIM(RTRIM(tbf.Tozihat))  AS Description,
N'خـرید ' + FORMAT(tbf.VaznKHales, 'N0')+ N' کیلو ' +LTRIM(RTRIM(tkx.title)) AS Title,

(0)         AS Debit,
tbf.Mablaq  AS Credit, 

(0) AS Remaind

FROM        Bar.tbl_BarFactor       AS tbf
INNER JOIN  Base.tbl_Kala_Xadamat   AS tkx  ON  tkx.Code    = tbf.FK_Kala
LEFT OUTER JOIN General.DimDate     AS dd   ON  tbf.tarikh  = dd.GregorianDate 

WHERE

    (tbf.FK_Salmali  = @Year      OR @Year IS NULL)
AND (tbf.FK_People   = @People ) 
AND (tbf.tarikh     >= @DateFrom  OR @DateFrom IS NULL)
AND (tbf.tarikh     <= @DateTo    OR @DateTo   IS NULL)


UNION ALL

SELECT

(11)         AS SubSystem ,
tek.ID ,
dd.PersianStr,
tek.tarikh  AS Date,
(11)        AS kind,
LTRIM(RTRIM(tek.Tozihat))  AS Description,
N'ارسال ' + FORMAT(tek.VaznKHales, 'N0')+ N' کیلو به کارخانه به شماره قبض ' + CAST( tek.ShomareGhabz AS nvarchar) AS Title,

tek.Mablaq       AS Debit,
(0)              AS Credit, 

(0) AS Remaind 

FROM Bar.tbl_ErsalKarkhane          AS tek 
LEFT OUTER JOIN General.DimDate     AS dd   ON  tek.tarikh  = dd.GregorianDate 

WHERE

    (tek.FK_Salmali  = @Year      OR @Year IS NULL)
AND (tek.tarikh     >= @DateFrom  OR @DateFrom IS NULL)
AND (tek.tarikh     <= @DateTo    OR @DateTo   IS NULL)
AND (tek.FK_Karkhane = @People) 

");
		}
	}
}
