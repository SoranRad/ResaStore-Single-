using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.ViewModel;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.Configure.ViewModel
{
    public class PrintFactorConfiguration : DapperEntityConfiguration<PrintFactor>
    {
        public PrintFactorConfiguration()
        {
            this.SetItem(@"
SELECT 

tat.Serial,
tat.tarikh,
tat.kind,
LTRIM(RTRIM(tat.sharh))	AS sharh,
dd.PersianInt			AS PersianTarix,
FORMAT(tat.tarikh_add,'HH:MM') AS Saat,

tatd.mablaq_takhfif ,
tatd.Darsad_Takhfif,
tatd.mablaq_Maliat ,
tatd.Darsad_Maliat ,
tatd.Ezafat,
tkx.nerkh_frosh,
tkx.nerkh_frosh1,
tkx.nerkh_frosh2,
tkx.nerkh_frosh3,

tar.FK_Kala ,
tar.radif ,
tar.meqdar ,
tar.nerkh ,
tar.takhfif ,
tar.takhfif_darsad ,
tar.mablaq,
LTRIM(RTRIM(tkx.title)) AS ObjectTitle,
LTRIM(RTRIM(tkx.barcode)) AS Barcode,
LTRIM(RTRIM(tv.title))	AS UnitTitle,

Ltrim(Rtrim(ta.title)) AS title,
Ltrim(Rtrim(ta.codeMeli)) AS codeMeli,
Ltrim(Rtrim(ta.codePosti)) AS codePosti,
Ltrim(Rtrim(ta.codeEqtesadi)) AS codeEqtesadi,
Ltrim(Rtrim(ta.tel)) AS tel,
Ltrim(Rtrim(ta.mobile)) AS mobile,
Ltrim(Rtrim(ta.fax)) AS fax,
Ltrim(Rtrim(ta.addressHome)) AS addressHome,
Ltrim(Rtrim(ta.telDowom)) AS telDowom,
Ltrim(Rtrim(ta.mobDowom)) AS mobDowom,
Ltrim(Rtrim(ta.addresswork)) AS addresswork,

Ltrim(Rtrim(taVisitor.title)) AS VisitorTitle,
Ltrim(Rtrim(taVisitor.mobile)) AS VisitorMobile,

RTRIM(LTRIM(tbb.Title)) AS BasteBandiTitle,
tar.MeqdarKolBaste,
tar.MeqdarKhordBaste
 
FROM Anbar.tbl_Amaliat_Title					AS tat
INNER JOIN General.DimDate						AS dd	ON dd.GregorianDate = tat.tarikh
INNER JOIN Anbar.tbl_Amaliat_Riz				AS tar	ON tar.FK_Title		= tat.ID
INNER JOIN Base.tbl_Kala_Xadamat				AS tkx	ON tkx.Code			= tar.FK_Kala
INNER JOIN Base.tbl_Vahed						AS tv	ON tv.ID			= tkx.FK_Vahed
LEFT OUTER JOIN Base.tbl_Ashxas					AS ta	ON ta.ID			= tat.FK_AshXas_ID 
LEFT OUTER JOIN Anbar.tbl_Amaliat_Title_Detail	AS tatd ON tatd.ID			= tat.ID
LEFT OUTER JOIN Base.tbl_BasteBandi				AS tbb  ON tbb.ID			= tkx.FK_BasteBandi
LEFT OUTER JOIN Base.tbl_Ashxas					AS taVisitor ON taVisitor.ID = tatd.FK_Vaset 


WHERE ta.ID=@ID

");
            this.SetList(@"

SELECT 
    tat.ID,
    tat.Serial,
    tat.tarikh,
    tat.kind,
    tat.mablaq                    AS mablaq_KOl,
    LTRIM(RTRIM(tat.sharh))       AS sharh,
    dd.PersianInt                 AS PersianTarix,
    CONVERT(VARCHAR(5), tat.tarikh_add, 108) AS Saat,   -- ← جایگزین FORMAT
    tatd.mablaq_takhfif,
    tatd.Darsad_Takhfif,
    tatd.mablaq_Maliat,
    tatd.Darsad_Maliat,
    tatd.Ezafat,
    tar.FK_Kala,
    tar.radif,
    tar.meqdar,
    tar.nerkh,
    tar.takhfif,
    tar.takhfif_darsad,
    tar.mablaq,
    LTRIM(RTRIM(tkx.title))       AS ObjectTitle,
    LTRIM(RTRIM(tv.title))        AS UnitTitle,
    LTRIM(RTRIM(tkx.barcode))     AS Barcode,
    LTRIM(RTRIM(ta.title))        AS title,
    LTRIM(RTRIM(ta.codeMeli))     AS codeMeli,
    LTRIM(RTRIM(ta.codePosti))    AS codePosti,
    LTRIM(RTRIM(ta.codeEqtesadi)) AS codeEqtesadi,
    LTRIM(RTRIM(ta.tel))          AS tel,
    LTRIM(RTRIM(ta.mobile))       AS mobile,
    LTRIM(RTRIM(ta.fax))          AS fax,
    LTRIM(RTRIM(ta.addressHome))  AS addressHome,
    LTRIM(RTRIM(ta.telDowom))     AS telDowom,
    LTRIM(RTRIM(ta.mobDowom))     AS mobDowom,
    LTRIM(RTRIM(ta.addresswork))  AS addresswork,
    Payment.Cache,
    Payment.Pos,
    ISNULL( ChequePayment.Cheque,0) + 
    ISNULL( PeopleCheque.Mablaq,0)AS Cheque,
    Takhfif.OffAmount             AS Takhfif_Tasvieh,
    LTRIM(RTRIM(taVisitor.title)) AS VisitorTitle,
    LTRIM(RTRIM(taVisitor.mobile))AS VisitorMobile,
    RTRIM(LTRIM(tbb.Title))       AS BasteBandiTitle,
    tar.MeqdarKolBaste,
    tar.MeqdarKhordBaste

FROM                Anbar.tbl_Amaliat_Title         AS tat   
INNER JOIN          General.DimDate                 AS dd           ON dd.GregorianDate = tat.tarikh
INNER JOIN          Anbar.tbl_Amaliat_Riz           AS tar          ON tar.FK_Title     = tat.ID
INNER JOIN          Base.tbl_Kala_Xadamat           AS tkx          ON tkx.Code         = tar.FK_Kala
INNER JOIN          Base.tbl_Vahed                  AS tv           ON tv.ID            = tkx.FK_Vahed
LEFT OUTER JOIN     Base.tbl_Ashxas                 AS ta           ON ta.ID            = tat.FK_AshXas_ID
LEFT OUTER JOIN     Anbar.tbl_Amaliat_Title_Detail  AS tatd         ON tatd.ID          = tat.ID
LEFT OUTER JOIN     Base.tbl_Ashxas                 AS taVisitor    ON taVisitor.ID     = tatd.FK_Vaset
LEFT OUTER JOIN     Base.tbl_BasteBandi             AS tbb          ON tbb.ID           = tkx.FK_BasteBandi

OUTER APPLY (
    SELECT
        SUM(CASE WHEN tax.kind = 9  THEN tax.mablaq ELSE 0 END) AS Cache,
        SUM(CASE WHEN tax.kind = 10 THEN tax.mablaq ELSE 0 END) AS Pos
    FROM Xazane.tbl_Amaliat_Xazaneh AS tax
    INNER JOIN Xazane.tbl_Amaliat_DP AS tad ON tad.ID = tax.FK_DP
    WHERE tad.FK_Faktor = tat.ID
) AS Payment

OUTER APPLY (
    SELECT SUM(ISNULL(tad.takhfif, 0)) AS OffAmount
    FROM Xazane.tbl_Amaliat_DP AS tad
    WHERE tad.FK_Faktor = tat.ID
) AS Takhfif

OUTER APPLY (

    SELECT SUM(tac2.mablaq) AS Mablaq
    FROM Xazane.tbl_Amaliat_Check AS tac2
    INNER JOIN Xazane.tbl_Amaliat_DP AS tad3 ON tad3.ID = tac2.FK_DP_Vagozari 
    WHERE tad3.FK_Faktor = tat.ID  
     
) AS PeopleCheque

OUTER APPLY (
    SELECT SUM(tac.mablaq) AS Cheque
    FROM Xazane.tbl_Amaliat_Check AS tac
    INNER JOIN Xazane.tbl_Amaliat_DP AS tad2 ON tad2.ID = tac.FK_DP
    WHERE tad2.FK_Faktor = tat.ID  AND (tac.Kind_Vaziat <> 3 OR tac.Kind_Vaziat IS NULL)
) AS ChequePayment


");
            
        }
    }
}