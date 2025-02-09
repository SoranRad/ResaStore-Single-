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
//            this.SetList(@"
//SELECT 
//tat.ID,
//tat.Serial,
//tat.mablaq				,
//LTRIM(RTRIM(tat.sharh))	AS sharh,
//dd.PersianStr,
//dd.PersianMonthNo,
//dd.PersianDayInMonth,

//tatd.mablaq_takhfif ,
//tatd.Darsad_Takhfif,
//tatd.mablaq_Maliat ,
//tatd.Darsad_Maliat ,
//tatd.Ezafat,
//Ltrim(Rtrim(ta.title)) AS Customer,
//Payment.Cache,
//Payment.Pos,
//Payment.Cheque
 
//FROM Anbar.tbl_Amaliat_Title		AS tat
//INNER JOIN General.DimDate			AS dd	ON dd.GregorianDate = tat.tarikh
//LEFT OUTER JOIN Base.tbl_Ashxas		AS ta	ON ta.ID			= tat.FK_AshXas_ID 
//LEFT OUTER JOIN Anbar.tbl_Amaliat_Title_Detail AS tatd ON tatd.ID = tat.ID
//LEFT OUTER JOIN (
//    SELECT 
//    tad.FK_Faktor ,
//    cache.Cache   AS Cache,
//    cache.Pos     AS Pos,
//    cheque.Mablaq AS Cheque
//    FROM 
//    Xazane.tbl_Amaliat_DP AS tad

//    LEFT OUTER JOIN (
//        SELECT 
//            tax.FK_DP,
//            SUM(CASE WHEN tax.kind=9  THEN tax.mablaq ELSE 0 END )	AS Cache,
//            SUM(CASE WHEN tax.kind=10 THEN tax.mablaq ELSE 0 END )	AS Pos
//        FROM Xazane.tbl_Amaliat_Xazaneh AS tax
//        INNER JOIN Xazane.tbl_Amaliat_DP AS tad2 ON tad2.ID = tax.FK_DP

//        GROUP BY tad2.FK_Faktor
//    ) AS cache ON cache.FK_DP = tad.ID

//    LEFT OUTER JOIN(
//        SELECT 
//            tac.FK_DP,
//            SUM(tac.mablaq) AS Mablaq
//        FROM Xazane.tbl_Amaliat_Check AS tac
//        INNER JOIN Xazane.tbl_Amaliat_DP AS tad3 ON tad3.ID = tac.FK_DP

//        GROUP BY tad3.FK_Faktor
//    )AS cheque ON cheque.FK_DP = tad.ID

//    WHERE tad.FK_Faktor IS NOT NULL 

//    GROUP BY 
//            tad.FK_Faktor,
//            cache.Cache,
//            cache.Pos,
//            cheque.Mablaq

//    ) AS Payment ON Payment.FK_Faktor = tat.ID

//WHERE tat.kind = @Kind AND tat.FK_Salmali =@Year AND (dd.PersianMonthNo=@Month OR @Month=13)
//");

            this.SetList(@"

SELECT tat.ID,
       tat.Serial,
       tat.mablaq,
       LTRIM(RTRIM(tat.sharh)) AS sharh,
       dd.PersianStr,
       dd.PersianMonthNo,
       dd.PersianDayInMonth,
       tatd.mablaq_takhfif,
       tatd.Darsad_Takhfif,
       tatd.mablaq_Maliat,
       tatd.Darsad_Maliat,
       tatd.Ezafat,
       LTRIM(RTRIM(ta.title)) AS Customer,
	   tat.FK_AshXas_ID,
       Payment.Cache,
       Payment.Pos,
       ChequePayment.Cheque,
       RTRIM(LTRIM(tbl.Title)) AS Location

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
			SUM(tac.mablaq) AS Cheque

		FROM Xazane.tbl_Amaliat_Check		AS tac
		INNER JOIN Xazane.tbl_Amaliat_DP	AS tad2 ON tad2.ID = tac.FK_DP

		WHERE tac.Kind_Vaziat <> 3 OR tac.Kind_Vaziat IS NULL
		GROUP BY tad2.FK_Faktor

	) AS ChequePayment ON ChequePayment.FK_Faktor = tat.ID

WHERE tat.kind = @Kind AND tat.FK_Salmali =@Year AND (dd.PersianMonthNo=@Month OR @Month=13)
");



        }
    }
}
