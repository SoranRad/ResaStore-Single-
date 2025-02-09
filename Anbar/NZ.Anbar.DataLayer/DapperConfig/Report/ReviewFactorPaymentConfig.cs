using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.Report;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.Report
{
    public class ReviewFactorPaymentConfig : DapperEntityConfiguration<ReviewFactorPayment>
    {
        public ReviewFactorPaymentConfig()
        {
            SetList(@"

    SELECT 
       
       tat.ID,
       tat.Serial,
       tat.mablaq,
       LTRIM(RTRIM(tat.sharh)) AS sharh,
       dd.PersianStr,
      
       tatd.mablaq_takhfif,
       tatd.Darsad_Takhfif,
      
       tatd.Ezafat,
       LTRIM(RTRIM(ta.title)) AS Customer,
	   tat.FK_AshXas_ID,
	   Anbar.GetFactorDetail(tat.ID,10) AS FactorItems,

       Payment.Cache,
       Payment.Pos,
       ChequePayment.Mablaq  AS Cheque,
	   ChequePayment.ChequeCount,

	   LTRIM(RTRIM(tat.sharh)) AS Description,
	   RTRIM(LTRIM(tbl.Title)) AS Location,
	   tat.is_ok

    FROM Anbar.tbl_Amaliat_Title AS tat

    INNER JOIN General.DimDate AS dd
        ON dd.GregorianDate = tat.tarikh
	LEFT OUTER JOIN Base.tbl_Base_Location AS tbl 
		ON tbl.ID = tat.FK_Location
    LEFT OUTER JOIN Base.tbl_Ashxas AS ta
        ON ta.ID = tat.FK_AshXas_ID
    LEFT OUTER JOIN Anbar.tbl_Amaliat_Title_Detail AS tatd
        ON tatd.ID = tat.ID

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
			SUM(
				CASE WHEN tac.Kind_Vaziat <> 3 OR tac.Kind_Vaziat IS NULL
				THEN tac.mablaq ELSE 0 END			
			) AS Mablaq,
			COUNT( DISTINCT tac.ID) AS ChequeCount

		FROM Xazane.tbl_Amaliat_Check		AS tac
		INNER JOIN Xazane.tbl_Amaliat_DP	AS tad2 ON tad2.ID = tac.FK_DP

		WHERE tac.Kind_Vaziat <> 3 OR tac.Kind_Vaziat IS NULL
		GROUP BY tad2.FK_Faktor

	) AS ChequePayment ON ChequePayment.FK_Faktor = tat.ID

	WHERE tat.kind = @Kind AND tat.FK_Salmali =@Year

            ");
        }
    }
}
