using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.ViewModel;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.ViewModel
{
    public class GeneralFactorConfiguration : DapperEntityConfiguration<GeneralFactor>
    {
        public GeneralFactorConfiguration()
        {

	        SetList(@"


SELECT 
    tat.ID,
    tat.Serial,
    tat.mablaq,
    LTRIM(RTRIM(tat.sharh))        AS sharh,
    dd.PersianStr,
    dd.PersianMonthNo,
    dd.PersianDayInMonth,
    tatd.mablaq_takhfif,
    tatd.Darsad_Takhfif,
    tatd.mablaq_Maliat,
    tatd.Darsad_Maliat,
    tatd.Ezafat,
    LTRIM(RTRIM(ta.title))         AS Customer,
    tat.FK_AshXas_ID,
    Payment.Cache,
    Payment.Pos,
    ISNULL(ChequePayment.Cheque,0)+ISNULL(PeopleCheque.Cheque,0) AS Cheque,
    Takhfif.OffAmount              AS Takhfif,
    RTRIM(LTRIM(tbl.Title))        AS Location

FROM Anbar.tbl_Amaliat_Title                    AS tat
INNER JOIN General.DimDate                      AS dd       ON dd.GregorianDate = tat.tarikh
LEFT OUTER JOIN Base.tbl_Base_Location          AS tbl      ON tbl.ID = tat.FK_Location
LEFT OUTER JOIN Base.tbl_Ashxas                 AS ta       ON ta.ID = tat.FK_AshXas_ID
LEFT OUTER JOIN Anbar.tbl_Amaliat_Title_Detail  AS tatd     ON tatd.ID = tat.ID
OUTER APPLY (

    SELECT
        SUM(CASE WHEN tax.kind = 9  THEN tax.mablaq ELSE 0 END) AS Cache,
        SUM(CASE WHEN tax.kind = 10 THEN tax.mablaq ELSE 0 END) AS Pos
    FROM Xazane.tbl_Amaliat_Xazaneh  AS tax
    INNER JOIN Xazane.tbl_Amaliat_DP AS tad ON tad.ID = tax.FK_DP
    WHERE tad.FK_Faktor = tat.ID

) AS Payment
OUTER APPLY (
    
    SELECT SUM(tac.mablaq) AS Cheque
    FROM Xazane.tbl_Amaliat_Check AS tac
    INNER JOIN Xazane.tbl_Amaliat_DP AS tad2 ON tad2.ID = tac.FK_DP
    WHERE tad2.FK_Faktor = tat.ID  AND (tac.Kind_Vaziat <> 3 OR tac.Kind_Vaziat IS NULL)

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

WHERE
        tat.kind       = @Kind
    AND tat.FK_Salmali = @Year
    AND (@Month = 13 OR dd.PersianMonthNo = @Month)
 

");

        }
    }
}
