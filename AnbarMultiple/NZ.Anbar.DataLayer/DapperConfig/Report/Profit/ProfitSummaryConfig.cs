using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.Report;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.Report.Profit
{
    public class ProfitSummaryConfig : DapperEntityConfiguration<ProfitSummary>
    {
        public ProfitSummaryConfig()
        {
            SetList(@"
SELECT 
	   Sub.FK_Kala ,
       Sub.tarikh ,
       LTRIM(RTRIM(Sub.title)) AS ObjectTitle ,
       Sub.PersianStr ,
       Sub.PersianMonthNo ,
       Sub.PersianMonthName ,
       Sub.SaleMount ,
       Sub.SaleCount ,
       Purchasing.PurchaseMount ,
       Purchasing.PurchaseCount

FROM 
(
	SELECT 
			subtar.FK_Kala ,
			tat.tarikh,
			tkx.title,
			dd.PersianStr,
			dd.PersianMonthNo,
			dd.PersianMonthName,
			SUM(CASE WHEN tat.kind = 50 THEN subtar.mablaq  WHEN tat.kind = 13 THEN -subtar.mablaq ELSE 0 END)	AS SaleMount,
			SUM(CASE WHEN tat.kind = 50 THEN subtar.meqdar  WHEN tat.kind = 13 THEN -subtar.meqdar ELSE 0 END)	AS SaleCount

		FROM		Anbar.tbl_Amaliat_Riz		AS subtar
		INNER JOIN	Anbar.tbl_Amaliat_Title		AS tat		ON tat.ID = subtar.FK_Title
		INNER JOIN  Base.tbl_Kala_Xadamat		AS tkx2		ON tkx2.Code = subtar.FK_Kala
		INNER JOIN General.DimDate				AS dd		ON tat.tarikh = dd.GregorianDate
		INNER JOIN Base.tbl_Kala_Xadamat		AS tkx		ON tkx.Code = subtar.FK_Kala

		WHERE	(tat.kind >=11 OR tat.kind<=100) 
				AND subtar.FK_Salmali	= @Year 
				AND tkx2.kind			= @Kind
                AND (dd.PersianMonthNo = @Month OR @Month IS NULL)
                AND (tat.tarikh = @Day OR @Day IS NULL)

		GROUP BY  subtar.FK_Kala ,tat.tarikh,tkx.title,dd.PersianStr,dd.PersianMonthNo,dd.PersianMonthName
) AS Sub

LEFT OUTER JOIN 
(
	SELECT 
		subtar.FK_Kala, 
		SUM(CASE WHEN tat.kind = 12 OR tat.kind = 11   THEN subtar.mablaq  WHEN tat.kind = 51 THEN -subtar.mablaq ELSE 0 END)  AS PurchaseMount,
		SUM(CASE WHEN tat.kind = 12 OR tat.kind = 11   THEN subtar.meqdar  WHEN tat.kind = 51 THEN -subtar.meqdar ELSE 0 END)	AS PurchaseCount

	FROM		Anbar.tbl_Amaliat_Riz		AS subtar
	INNER JOIN	Anbar.tbl_Amaliat_Title		AS tat		ON tat.ID = subtar.FK_Title
	INNER JOIN  Base.tbl_Kala_Xadamat		AS tkx2		ON tkx2.Code = subtar.FK_Kala

	WHERE	(tat.kind >= 11 OR tat.kind <= 51) 
			AND subtar.FK_Salmali	= @Year 
			AND tkx2.kind			= @Kind

	GROUP BY  subtar.FK_Kala
)AS Purchasing ON Purchasing.FK_Kala = Sub.FK_Kala

");
        }
    }
}
