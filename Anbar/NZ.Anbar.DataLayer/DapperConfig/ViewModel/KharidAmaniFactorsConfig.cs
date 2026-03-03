using Nz.Anbar.Model.Report;
using Nz.Anbar.Model.ViewModel;
using ShareLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ.Anbar.DataLayer.DapperConfig.ViewModel
{
	public class KharidAmaniFactorsConfig : DapperEntityConfiguration<KharidAmaniFactors>
	{
		public KharidAmaniFactorsConfig()
		{
			SetList(@"
SELECT 

       tat.ID,
       tat.Serial,
       LTRIM(RTRIM(tat.sharh)) AS sharh,
       dd.PersianStr,
       dd.PersianMonthNo,
       dd.PersianDayInMonth,
       tatd.mablaq_takhfif,
       tatd.Darsad_Takhfif,
       tatd.mablaq_Maliat,
       tatd.Darsad_Maliat,
       tatd.Ezafat,
       LTRIM(RTRIM(ta.title)) AS Customer,
	   tat.FK_AshXas_ID ,
       tat.mablaq,
       Khoroj.MablaqFrosh,
       Khoroj.MablaqBargash,
       Payment.Cache,
       Payment.Pos,
       ChequePayment.Cheque,
       Takhfif.OffAmount AS Takhfif

FROM            Anbar.tbl_Amaliat_Title             AS tat
INNER JOIN      General.DimDate                     AS dd           ON dd.GregorianDate     = tat.tarikh 
LEFT OUTER JOIN Base.tbl_Ashxas                     AS ta           ON ta.ID                = tat.FK_AshXas_ID
LEFT OUTER JOIN Anbar.tbl_Amaliat_Title_Detail      AS tatd         ON tatd.ID              = tat.ID

LEFT OUTER JOIN
(
    Select 
		
        tat.FK_Mabna,
		SUM(case when tat.kind =50 then tar.nerkh_2 else 0 end ) AS MablaqFrosh,
		SUM(case when tat.kind =51 then tar.nerkh_2 else 0 end ) AS MablaqBargash
		

		FROM Anbar.tbl_Amaliat_Riz          	AS tar
		INNER JOIN Anbar.tbl_Amaliat_Title 		AS tat 		ON tar.FK_Title = tat.ID

		WHERE (tat.kind = 50 OR tat.kind = 51)   

        GROUP BY 
        tat.FK_Mabna

) AS Khoroj ON Khoroj.FK_Mabna = tat.ID 

    LEFT OUTER JOIN 
	(
		SELECT 
			tad.FK_Faktor,
			SUM(   CASE
						WHEN tax.kind = 9 THEN
							tax.mablaq
						ELSE
							0
					END
				) AS Cache,
			SUM(   CASE
						WHEN tax.kind = 10 THEN
							tax.mablaq
						ELSE
							0
					END
				) AS Pos
	 
		FROM Xazane.tbl_Amaliat_Xazaneh		AS tax
		INNER JOIN Xazane.tbl_Amaliat_DP	AS tad ON tad.ID = tax.FK_DP
		GROUP BY tad.FK_Faktor

	)  AS Payment ON Payment.FK_Faktor = tat.ID



	LEFT OUTER JOIN
	(
		SELECT 
			tad2.FK_Faktor ,
			SUM(tac.mablaq) AS Cheque

		FROM Xazane.tbl_Amaliat_Check		AS tac
		INNER JOIN Xazane.tbl_Amaliat_DP	AS tad2 ON tad2.ID = tac.FK_DP

		WHERE tac.Kind_Vaziat <> 3 OR tac.Kind_Vaziat IS NULL
		GROUP BY tad2.FK_Faktor

	) AS ChequePayment ON ChequePayment.FK_Faktor = tat.ID

LEFT OUTER JOIN
    ( 
        SELECT 
            
            tad.FK_Faktor,
            SUM(ISNULL(tad.takhfif,0)) as OffAmount

        FROM  Xazane.tbl_Amaliat_DP AS tad
        Group BY tad.FK_Faktor
        
    )AS Takhfif on Takhfif.FK_Faktor = tat.ID


WHERE tat.kind = @Kind AND tat.FK_Salmali = @Year AND (dd.PersianMonthNo = @Month OR @Month = 13)

ORDER BY tat.Serial


");
		}
	}
}
