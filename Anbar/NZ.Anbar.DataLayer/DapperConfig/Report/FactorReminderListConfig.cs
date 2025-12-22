using Nz.Anbar.Model.Report;
using ShareLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ.Anbar.DataLayer.DapperConfig.Report
{
    public class FactorReminderListConfig : DapperEntityConfiguration<FactorReminderList>
	{
		public FactorReminderListConfig()
		{
			SetList(@"
SELECT tat.ID,
       tat.Serial,
	   tat.kind,
       tat.mablaq,
       dd.PersianStr,
       LTRIM(RTRIM(ta.title)) AS Customer,
	   tat.FK_AshXas_ID,
       Payment.Cache,
       Payment.Pos,
       ChequePayment.Cheque,
       Takhfif.OffAmount AS Takhfif,
	   ddMohlat.PersianStr AS MohlatPersianStr

FROM Anbar.tbl_Amaliat_Title AS tat
	
    INNER JOIN General.DimDate AS dd
        ON dd.GregorianDate = tat.tarikh
    LEFT OUTER JOIN Base.tbl_Ashxas AS ta
        ON ta.ID = tat.FK_AshXas_ID
    LEFT OUTER JOIN Anbar.tbl_Amaliat_Title_Detail AS tatd
        ON tatd.ID = tat.ID
	LEFT OUTER JOIN  General.DimDate AS ddMohlat 
		ON ddMohlat.GregorianDate = tatd.tarikh_etebar
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
        
    )AS Takhfif on Takhfif.FK_Faktor =tat.ID

WHERE tatd.tarikh_etebar IS NOT NULL AND tat.FK_Salmali = @Year 
AND tatd.tarikh_etebar <= @Tarikh
AND(tat.mablaq>(ISNULL( Payment.Cache,0)+ISNULL(Payment.Pos,0)+ ISNULL( ChequePayment.Cheque,0)))



");
		}
    }
}
