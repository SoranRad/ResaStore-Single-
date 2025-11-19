using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.Report;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.Report
{
    public class GardeshKoliConfig:DapperEntityConfiguration<GardeshKoli>
    {
        public GardeshKoliConfig()
        {
            SetList(@"

SELECT
    pivotSub.FK_Kala ,
    pivotSub.FK_GroupKala_2th ,
    pivotSub.FK_GroupKala_1th ,
    pivotSub.ObjectTitle ,
    pivotSub.SubGroupTitle ,
    pivotSub.MainGroupTitle ,
    pivotSub.[11] AS Init,
    pivotSub.[12] AS Purchase,
    pivotSub.[13] AS SaleBack,
    pivotSub.[16] AS ResidVorud,
    pivotSub.[551]AS BeynAnbarVorud,
    pivotSub.[50] AS Sale,
    pivotSub.[51] AS PurchaseBack,
    pivotSub.[53] AS Transfer,
    pivotSub.[54] AS Usage,
    pivotSub.[55] AS BeynAnbarXoruj,
    pivotSub.[56] AS HavaleXoruj

FROM
(
    SELECT
            tar.FK_Kala,
            tkx.FK_GroupKala_2th,
            tgk.FK_GroupKala_1th,
            LTRIM(RTRIM(tkx.title))     AS ObjectTitle,
            LTRIM(RTRIM(tgk.title))     AS SubGroupTitle,
            LTRIM(RTRIM(tgk2.title))    AS MainGroupTitle,
            (case when tat.kind =55 and tat.FK_Anbar_Be = @Anbar then 551 else tat.kind end) as kind,
            SUM(case 
                    when tat.kind =55 AND tat.FK_Anbar_Be = @Anbar then tar.meqdar
                    when tat.kind>=11 AND tat.kind<50  AND tat.FK_Anbar_Az = @Anbar then tar.meqdar
                    when tat.kind>=50 AND tat.kind<100 AND tat.NoRemainEffect = 0 AND tat.FK_Anbar_Az = @Anbar then tar.meqdar
                    else 0
                end) AS Count

    FROM        Anbar.tbl_Amaliat_Riz       AS tar
    INNER JOIN  Anbar.tbl_Amaliat_Title     AS tat      ON tat.ID = tar.FK_Title
    INNER JOIN  Base.tbl_Kala_Xadamat       AS tkx      ON tkx.Code = tar.FK_Kala
    INNER JOIN  Base.tbl_GroupKala_2th      AS tgk      ON tgk.Code = tkx.FK_GroupKala_2th
    INNER JOIN  Base.tbl_GroupKala_1th      AS tgk2     ON tgk2.Code = tgk.FK_GroupKala_1th

    WHERE 
    tat.FK_Salmali = @Year
    AND (
            (tat.kind >= 11  AND tat.kind <= 100 AND tat.FK_Anbar_Az = @Anbar)
        OR (tat.kind =  55  AND tat.FK_Anbar_Be = @Anbar)
        )  

    GROUP BY
    (case when tat.kind =55 and tat.FK_Anbar_Be = @Anbar then 551 else tat.kind end),
    tar.FK_Kala,
    tkx.FK_GroupKala_2th,
    tgk.FK_GroupKala_1th,
    LTRIM(RTRIM(tkx.title)),
    LTRIM(RTRIM(tgk.title)),
    LTRIM(RTRIM(tgk2.title))
) Sub
PIVOT
(
    SUM(Count)
    FOR kind IN ([11],[12],[13],[16],[551],[50],[51],[53],[54],[55],[56])
) pivotSub

");
        }

    }
}
