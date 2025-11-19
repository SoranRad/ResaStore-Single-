using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.ViewModel;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.ViewModel
{
    public class FactorPaymentConfig:DapperEntityConfiguration<FactorPayment>
    {
        public FactorPaymentConfig()
        {
            SetItem(@"
SELECT 
	   Payment.Cache				AS Cache,
       Payment.Pos					AS Pos,
       ChequePayment.Mablaq			AS Cheque,
       ChequePayment.ChequeCount	AS ChequeCount

FROM Anbar.tbl_Amaliat_Title AS tat
    
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
				THEN tac.mablaq
				ELSE 0
				END
				) AS Mablaq,
				COUNT(DISTINCT tac.ID) AS ChequeCount

		FROM Xazane.tbl_Amaliat_Check		AS tac
		INNER JOIN Xazane.tbl_Amaliat_DP	AS tad2 ON tad2.ID = tac.FK_DP 
		GROUP BY tad2.FK_Faktor
	) AS ChequePayment ON ChequePayment.FK_Faktor = tat.ID
	WHERE  tat.ID = @ID;
");

           
        }
    }
}
