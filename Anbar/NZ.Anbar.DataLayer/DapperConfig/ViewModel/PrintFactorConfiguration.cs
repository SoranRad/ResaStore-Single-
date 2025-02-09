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
Ltrim(Rtrim(ta.addresswork)) AS addresswork
 
FROM Anbar.tbl_Amaliat_Title		AS tat
INNER JOIN General.DimDate			AS dd	ON dd.GregorianDate = tat.tarikh
INNER JOIN Anbar.tbl_Amaliat_Riz	AS tar	ON tar.FK_Title		= tat.ID
INNER JOIN Base.tbl_Kala_Xadamat	AS tkx	ON tkx.Code			= tar.FK_Kala
INNER JOIN Base.tbl_Vahed			AS tv	ON tv.ID			= tkx.FK_Vahed
LEFT OUTER JOIN Base.tbl_Ashxas		AS ta	ON ta.ID			= tat.FK_AshXas_ID 
LEFT OUTER JOIN Anbar.tbl_Amaliat_Title_Detail AS tatd ON tatd.ID = tat.ID

WHERE ta.ID=@ID

");
            this.SetList(@"

SELECT 
tat.ID,
tat.Serial,
tat.tarikh,
tat.kind,
tat.mablaq AS mablaq_KOl,
LTRIM(RTRIM(tat.sharh))	AS sharh,
dd.PersianInt			AS PersianTarix,

tatd.mablaq_takhfif ,
tatd.Darsad_Takhfif,
tatd.mablaq_Maliat ,
tatd.Darsad_Maliat ,
tatd.Ezafat,

tar.FK_Kala ,
tar.radif ,
tar.meqdar ,
tar.nerkh ,
tar.takhfif ,
tar.takhfif_darsad ,
tar.mablaq,
LTRIM(RTRIM(tkx.title)) AS ObjectTitle,
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
Payment.Cache,
Payment.Pos,
ChequePayment.Cheque
 
FROM Anbar.tbl_Amaliat_Title		AS tat
INNER JOIN General.DimDate			AS dd	ON dd.GregorianDate = tat.tarikh
INNER JOIN Anbar.tbl_Amaliat_Riz	AS tar	ON tar.FK_Title		= tat.ID
INNER JOIN Base.tbl_Kala_Xadamat	AS tkx	ON tkx.Code			= tar.FK_Kala
INNER JOIN Base.tbl_Vahed			AS tv	ON tv.ID			= tkx.FK_Vahed
LEFT OUTER JOIN Base.tbl_Ashxas		AS ta	ON ta.ID			= tat.FK_AshXas_ID 
LEFT OUTER JOIN Anbar.tbl_Amaliat_Title_Detail AS tatd ON tatd.ID = tat.ID

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


");
        }
    }
}

/*
 * SELECT 
tat.ID,
tat.Serial,
tat.tarikh,
tat.kind,
tat.mablaq AS mablaq_KOl,
LTRIM(RTRIM(tat.sharh))	AS sharh,
dd.PersianInt			AS PersianTarix,

tatd.mablaq_takhfif ,
tatd.Darsad_Takhfif,
tatd.mablaq_Maliat ,
tatd.Darsad_Maliat ,
tatd.Ezafat,

tar.FK_Kala ,
tar.radif ,
tar.meqdar ,
tar.nerkh ,
tar.takhfif ,
tar.takhfif_darsad ,
tar.mablaq,
LTRIM(RTRIM(tkx.title)) AS ObjectTitle,
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
Payment.Cache,
Payment.Pos,
Payment.Cheque
 
FROM Anbar.tbl_Amaliat_Title		AS tat
INNER JOIN General.DimDate			AS dd	ON dd.GregorianDate = tat.tarikh
INNER JOIN Anbar.tbl_Amaliat_Riz	AS tar	ON tar.FK_Title		= tat.ID
INNER JOIN Base.tbl_Kala_Xadamat	AS tkx	ON tkx.Code			= tar.FK_Kala
INNER JOIN Base.tbl_Vahed			AS tv	ON tv.ID			= tkx.FK_Vahed
LEFT OUTER JOIN Base.tbl_Ashxas		AS ta	ON ta.ID			= tat.FK_AshXas_ID 
LEFT OUTER JOIN Anbar.tbl_Amaliat_Title_Detail AS tatd ON tatd.ID = tat.ID

LEFT OUTER JOIN (
    SELECT 
    tad.FK_Faktor ,
    cache.Cache   AS Cache,
    cache.Pos     AS Pos,
    cheque.Mablaq AS Cheque
    FROM 
    Xazane.tbl_Amaliat_DP AS tad

    LEFT OUTER JOIN (
    SELECT 
    tax.FK_DP,
    SUM(CASE WHEN tax.kind=9  THEN tax.mablaq ELSE 0 END )	AS Cache,
    SUM(CASE WHEN tax.kind=10 THEN tax.mablaq ELSE 0 END )	AS Pos
    FROM Xazane.tbl_Amaliat_Xazaneh AS tax
    GROUP BY tax.FK_DP
    ) AS cache ON cache.FK_DP = tad.ID

    LEFT OUTER JOIN(
    SELECT tac.FK_DP,SUM(tac.mablaq) AS Mablaq
    FROM Xazane.tbl_Amaliat_Check	AS tac 
    GROUP BY tac.FK_DP
    )AS cheque ON cheque.FK_DP = tad.ID

    WHERE tad.FK_Faktor IS NOT NULL 
    GROUP BY tad.FK_Faktor,cache.Cache,cache.Pos,cheque.Mablaq
    ) AS Payment ON Payment.FK_Faktor = tat.ID

 */