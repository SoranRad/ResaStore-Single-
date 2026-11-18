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
    Payment.Cache               AS Cache,
    Payment.Pos                 AS Pos,
    ISNULL(ChequePayment.Mablaq,0)+ISNULL(PeopleCheque.Cheque,0) AS Cheque,
    ISNULL(ChequePayment.ChequeCount,0) + ISNULL(PeopleCheque.CountCheque,0)AS ChequeCount,
    Takhfif.OffAmount           AS Takhfif

FROM Anbar.tbl_Amaliat_Title AS tat
OUTER APPLY (
    
    SELECT
        SUM(CASE WHEN tax.kind = 9  THEN tax.mablaq ELSE 0 END) AS Cache,
        SUM(CASE WHEN tax.kind = 10 THEN tax.mablaq ELSE 0 END) AS Pos
    FROM Xazane.tbl_Amaliat_Xazaneh AS tax
    INNER JOIN Xazane.tbl_Amaliat_DP AS tad ON tad.ID = tax.FK_DP
    WHERE tad.FK_Faktor = tat.ID

) AS Payment
OUTER APPLY (
    
    SELECT
        SUM(CASE WHEN tac.Kind_Vaziat <> 3 OR tac.Kind_Vaziat IS NULL THEN tac.mablaq ELSE 0 END) AS Mablaq,
        NULLIF(COUNT_BIG(DISTINCT tac.ID), 0) AS ChequeCount
    FROM Xazane.tbl_Amaliat_Check AS tac
    INNER JOIN Xazane.tbl_Amaliat_DP AS tad2 ON tad2.ID = tac.FK_DP
    WHERE tad2.FK_Faktor = tat.ID

) AS ChequePayment
OUTER APPLY
(
        SELECT
            SUM(tac.mablaq)                                            AS Cheque,
            CASE WHEN COUNT_BIG(*) = 0 THEN NULL ELSE COUNT_BIG(*) END AS CountCheque
        FROM Xazane.tbl_Amaliat_Check AS tac
        INNER JOIN Xazane.tbl_Amaliat_DP AS tad3 ON tad3.ID = tac.FK_DP_Vagozari
        WHERE tad3.FK_Faktor = tat.ID AND tac.Kind_Vaziat = @KindAssign

)AS PeopleCheque
OUTER APPLY (
    
    SELECT SUM(ISNULL(tad.takhfif, 0)) AS OffAmount
    FROM Xazane.tbl_Amaliat_DP AS tad
    WHERE tad.FK_Faktor = tat.ID

) AS Takhfif

WHERE tat.ID = @ID

");

        }
    }
}
