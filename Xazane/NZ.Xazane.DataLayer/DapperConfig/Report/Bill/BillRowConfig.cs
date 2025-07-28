using ShareLib.Interfaces;
using NZ.Xazane.Model.Report;

namespace NZ.Xazane.DataLayer.DapperConfig.Report.Bill
{
	public class BillRowConfig :  DapperEntityConfiguration<BillRow>
	{
		public BillRowConfig()
		{
			SetList(@"
SELECT 

tad.ID,
(case when tad.kind = 11  then N'مانده حساب بدهکاری قبلی' else N'مانده حساب بستانکاری قبلی' END) AS Title,
tad.takhfif AS mablaq,
tad.kind ,
LTRIM(RTRIM(tad.sharh)) AS Sharh,
N'' AS serialPeygiri,
dd.PersianStr

FROM	            Xazane.tbl_Amaliat_DP	AS tad  
LEFT OUTER JOIN     General.DimDate         AS dd   ON dd.GregorianDate = tad.tarikh

WHERE 	tad.FK_ShaXs = @People AND tad.FK_Salmali	= @Year AND (tad.kind=12 OR tad.kind=11)

UNION ALL

SELECT 
        tax.FK_DP AS ID ,
        (case tad.kind when 1  then N'دریافت وجوه ' when 2 then N'پرداخت وجوه ' when 6 then N'کسورات حساب' when 7 then N'اضافات حساب' else N'' END) +
        (case when tad.kind=1 OR tad.kind =2 then ( case when tax.kind = 9  then N'نقدی' else N'بانکی' END ) else N'' END )    AS Title,
        tax.mablaq,
        tad.kind,
        LTRIM(RTRIM(tax.sharh ))+ N' ' + LTRIM(RTRIM(tad.sharh ))	AS Sharh,
        tax.serialPeygiri ,
        dd.PersianStr

FROM				Xazane.tbl_Amaliat_Xazaneh		AS tax
INNER JOIN			Xazane.tbl_Amaliat_DP			AS tad		ON tad.ID		= tax.FK_DP
LEFT OUTER JOIN		General.DimDate					AS dd		ON tad.tarikh	= dd.GregorianDate

WHERE  tad.FK_ShaXs  = @People AND tad.FK_Salmali= @Year

UNION ALL


SELECT 

tac.ID,
(case when tad.kind =1  then N'دریافت چک ' else N'پرداخت چک ' END) AS Title,
tac.mablaq,
tad.kind,
LTRIM(RTRIM(tac.babat ))+ N' ' + LTRIM(RTRIM(tad.sharh ))	AS Sharh,
LTRIM(RTRIM(tac.shomare_check))		AS serialPeygiri,
dd.PersianStr
 

FROM			Xazane.tbl_Amaliat_Check	AS tac
INNER JOIN		Xazane.tbl_Amaliat_DP		AS tad			ON tad.ID					= tac.FK_DP
INNER JOIN		General.DimDate				AS dd			ON dd.GregorianDate			= tad.tarikh

WHERE tad.FK_ShaXs    = @People AND tad.FK_Salmali  = @Year

UNION ALL

SELECT 

tac.ID,
N'برگشت چک' AS Title,
tac.mablaq,
tad.kind, 
LTRIM(RTRIM(tac.Sharh_Vaziat))      AS Sharh ,
LTRIM(RTRIM(tac.shomare_check))		AS serialPeygiri,
ddVaziat.PersianStr					

FROM			Xazane.tbl_Amaliat_Check	AS tac
INNER JOIN		Xazane.tbl_Amaliat_DP		AS tad			ON tad.ID					= tac.FK_DP
LEFT OUTER JOIN General.DimDate				AS ddVaziat		ON tac.Tarix_Vaziat			= ddVaziat.GregorianDate

WHERE 
	tad.FK_ShaXs	    =  @People AND tad.FK_Salmali	    =  @Year AND tac.Kind_Vaziat     =  3

UNION ALL

SELECT

tac.ID,
N'واگذاری چک' AS Title,
tac.mablaq,
tad.kind,
LTRIM(RTRIM(tac.Sharh_Vaziat))		        AS Sharh,
LTRIM(RTRIM(tac.shomare_check))		        AS serialPeygiri,
ddSarResid.PersianStr				         

FROM			Xazane.tbl_Amaliat_Check	AS tac
INNER JOIN		Xazane.tbl_Amaliat_DP		AS tad			ON tad.ID					= tac.FK_DP
LEFT OUTER JOIN General.DimDate				AS ddSarResid	ON ddSarResid.GregorianDate = tac.tarikh_sar_resid

WHERE tac.FK_Salmali_Vaziat	=   @Year AND  tac.FK_Shaxs_Vaziat	=   @People AND	 tac.Kind_Vaziat		=   2

");
		}
	}
}
