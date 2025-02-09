using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Xazane.Model.Report;
using ShareLib.Interfaces;

namespace NZ.Xazane.DataLayer.DapperConfig.Report
{
    public class PaymentsTransactionConfig : DapperEntityConfiguration<PaymentsTransaction>
    {
        public PaymentsTransactionConfig()
        {
            SetList(@"
SELECT  
	
	tad.kind as Kind,
	SUM(ISNULL(PosCache.mablaq,0)+ISNULL(Cheque.mablaq,0)) as Mablaq


FROM			Xazane.tbl_Amaliat_DP		AS tad  
LEFT OUTER JOIN 
(
		SELECT 
			tax.FK_DP, 
			SUM( tax.mablaq )  AS mablaq

		FROM  Xazane.tbl_Amaliat_Xazaneh	AS tax 
		WHERE tax.FK_Salmali=@Year
		GROUP BY tax.FK_DP

) AS PosCache ON PosCache.FK_DP = tad.ID

LEFT OUTER JOIN
(
		SELECT 
			tac.FK_DP,
			SUM(tac.mablaq) AS  mablaq

		FROM  Xazane.tbl_Amaliat_Check	AS tac 
		GROUP BY tac.FK_DP

 ) AS Cheque ON Cheque.FK_DP = tad.ID

 WHERE (tad.kind = @DaryaftKind OR tad.kind = @PardakhtKind) AND tad.FK_Salmali = @Year
 GROUP BY tad.kind

");
        }
    }
}
