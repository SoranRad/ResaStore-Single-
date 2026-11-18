using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Xazane.Model.ViewModel;
using ShareLib.Interfaces;

namespace NZ.Xazane.DataLayer.DapperConfig.ViewModel
{
    public class PrintDPConfig : DapperEntityConfiguration<PrintDP>
    {
        public PrintDPConfig()
        {
	        SetList(@"
SELECT 
    tad.id,
    ddTitle.PersianStr              AS tarikh,
    tad.serial,
    tad.takhfif,
    LTRIM(RTRIM(tad.sharh))         AS sharh,
    LTRIM(RTRIM(ta.title))          AS Name,
    LTRIM(RTRIM(ta.addressHome))    AS Address,
    LTRIM(RTRIM(ta.codeMeli))       AS CodeMeli,
    LTRIM(RTRIM(ta.mobile))         AS Mobile,
    LTRIM(RTRIM(ta.tel))            AS Tel,
    TaxCache.mablaq                 AS Cache,
    LTRIM(RTRIM(TaxCache.sharh))    AS CacheDesc,
    TaxPOS.mablaq                   AS POS,
    TaxPOS.serialPeygiri            AS SerialPeygiri,
    LTRIM(RTRIM(TaxPOS.sharh))      AS POSDesc,
    (CASE WHEN tad.kind = 1
          THEN LTRIM(RTRIM(thxPOSBed.title))
          ELSE LTRIM(RTRIM(thxPOSBes.title)) 
    END) AS POSTitle,
    cheque.mablaq,
    cheque.IDCheque,
    cheque.shomare_check,
    cheque.tarikh_sar_resid,
    cheque.ChequeDesc,
    cheque.NameBank

FROM                Xazane.tbl_Amaliat_DP       AS tad 
LEFT OUTER JOIN     Xazane.tbl_Amaliat_Xazaneh  AS TaxCache     ON TaxCache.FK_DP   = tad.ID AND TaxCache.kind = 9
LEFT OUTER JOIN     Xazane.tbl_Amaliat_Xazaneh  AS TaxPOS       ON TaxPOS.FK_DP     = tad.ID AND TaxPOS.kind = 10
LEFT OUTER JOIN     General.DimDate             AS ddTitle      ON ddTitle.GregorianDate = tad.tarikh
INNER JOIN          Base.tbl_Ashxas             AS ta           ON ta.ID            = tad.FK_ShaXs
LEFT OUTER JOIN     Xazane.tbl_Hesab_Xazaneh    AS thxPOSBed    ON thxPOSBed.ID     = TaxPOS.FK_Xazaneh_Bad
LEFT OUTER JOIN     Xazane.tbl_Hesab_Xazaneh    AS thxPOSBes    ON thxPOSBes.ID     = TaxPOS.FK_Xazaneh_Bas

OUTER APPLY (
-- شاخه ۱: چک‌هایی که مستقیماً روی همین DP صادر شده‌اند
SELECT
    tac.mablaq,
    tac.ID                          AS IDCheque,
    LTRIM(RTRIM(tac.shomare_check)) AS shomare_check,
    ddCheque.PersianStr             AS tarikh_sar_resid,
    LTRIM(RTRIM(tac.babat))         AS ChequeDesc,
    (CASE WHEN tad.kind = 1
            THEN LTRIM(RTRIM(tb.title))
            ELSE LTRIM(RTRIM(thx.title)) END) AS NameBank

FROM Xazane.tbl_Amaliat_Check               AS tac
LEFT OUTER JOIN General.DimDate             AS ddCheque  ON ddCheque.GregorianDate = tac.tarikh_sar_resid
LEFT OUTER JOIN Xazane.tbl_Hesab_Xazaneh    AS thx ON thx.ID = tac.FK_Hesab_Pardaxtani
LEFT OUTER JOIN Base.tbl_Bank               AS tb ON tb.ID = tac.FK_Bank

WHERE tac.FK_DP = tad.ID

UNION ALL

-- شاخه ۲: چک‌های واگذارشده به همین DP
SELECT
    tac.mablaq,
    tac.ID                          AS IDCheque,
    LTRIM(RTRIM(tac.shomare_check)) AS shomare_check,
    ddCheque.PersianStr             AS tarikh_sar_resid,
    LTRIM(RTRIM(tac.Sharh_Vaziat))  AS ChequeDesc ,
    N' واگذاری چک ' + LTRIM(RTRIM(taHead.title))
    + N' نزد ' + LTRIM(RTRIM(tb.title)) AS NameBank

FROM Xazane.tbl_Amaliat_Check       AS tac
INNER JOIN Xazane.tbl_Amaliat_DP    AS tadHead   ON tadHead.ID = tac.FK_DP
INNER JOIN Base.tbl_Ashxas          AS taHead    ON taHead.ID = tadHead.FK_ShaXs
LEFT OUTER JOIN General.DimDate     AS ddCheque  ON ddCheque.GregorianDate = tac.tarikh_sar_resid
LEFT OUTER JOIN Base.tbl_Bank       AS tb        ON tb.ID = tac.FK_Bank

WHERE tac.FK_DP_Vagozari = tad.ID   AND tac.Kind_Vaziat = 2

) AS cheque

WHERE tad.kind IN (1, 2)


");

	        /*SetList(@"
SELECT
tad.id,
ddTitle.PersianStr				AS tarikh,
tad.serial,
tad.takhfif ,
LTRIM(RTRIM(tad.sharh))			AS sharh,
LTRIM(RTRIM(ta.title))			AS Name,
LTRIM(RTRIM(ta.addressHome))	AS Address,
LTRIM(RTRIM(ta.codeMeli))		AS CodeMeli,
LTRIM(RTRIM(ta.mobile))			AS Mobile,
LTRIM(RTRIM(ta.tel))			AS Tel,

TaxCache.mablaq					AS Cache,
LTRIM(RTRIM(TaxCache.sharh))	AS CacheDesc ,
TaxPOS.mablaq					AS POS,
TaxPOS.serialPeygiri			AS SerialPeygiri,
LTRIM(RTRIM(TaxPOS.sharh))		AS POSDesc,
(CASE WHEN tad.kind= 1 THEN LTRIM(RTRIM(thxPOSBed.title)) ELSE LTRIM(RTRIM(thxPOSBes.title)) END)
AS POSTitle,


tac.mablaq,
tac.ID							AS IDCheque,
LTRIM(RTRIM(tac.shomare_check)) AS shomare_check,
ddCheque.PersianStr             AS tarikh_sar_resid ,
LTRIM(RTRIM(tac.babat))         AS ChequeDesc,

(CASE WHEN tad.kind = 1 THEN LTRIM(RTRIM(tb.title)) ELSE LTRIM(RTRIM(thx.title)) END)
AS NameBank

FROM Xazane.tbl_Amaliat_DP AS tad
LEFT OUTER JOIN Xazane.tbl_Amaliat_Xazaneh	AS TaxCache		ON TaxCache.FK_DP	= tad.ID AND TaxCache.kind	= 9
LEFT OUTER JOIN Xazane.tbl_Amaliat_Xazaneh	AS TaxPOS		ON TaxPOS.FK_DP		= tad.ID AND TaxPOS.kind	= 10
LEFT OUTER JOIN Xazane.tbl_Amaliat_Check	AS tac			ON tac.FK_DP		= tad.ID

LEFT OUTER JOIN General.DimDate				AS ddTitle		ON ddTitle.GregorianDate = tad.tarikh
INNER JOIN Base.tbl_Ashxas					AS ta			ON tad.FK_ShaXs = ta.ID

LEFT OUTER JOIN Xazane.tbl_Hesab_Xazaneh	AS thxPOSBed	ON thxPOSBed.ID = TaxPOS.FK_Xazaneh_Bad
LEFT OUTER JOIN Xazane.tbl_Hesab_Xazaneh	AS thxPOSBes	ON thxPOSBes.ID = TaxPOS.FK_Xazaneh_Bas

LEFT OUTER JOIN General.DimDate				AS ddCheque		ON ddCheque.GregorianDate = tac.tarikh_sar_resid
LEFT OUTER JOIN Xazane.tbl_Hesab_Xazaneh	AS thx			ON thx.ID = tac.FK_Hesab_Pardaxtani
LEFT OUTER JOIN Base.tbl_Bank				AS tb			ON tb.ID = tac.FK_Bank

WHERE (tad.kind = 1 OR tad.kind = 2)

");*/
        }
    }
}
