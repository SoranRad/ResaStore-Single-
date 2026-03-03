using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Anbar.Model;
using Nz.Anbar.Model.Report;
using ShareLib;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.Report
{
    public class PurchaceAnalyzeConfig :  DapperEntityConfiguration<PurchaceAnalyze>
    {
        public PurchaceAnalyzeConfig()
        {
            SetList(@"


WITH Riz AS (

	SELECT 
			
			tar.FK_Title,
			tar.FK_Kala,
			RTRIM(LTRIM(tkx.title)) AS ObjectTitle,
			RTRIM(LTRIM(tv.title)) AS UnitTitle,
			SUM(tar.meqdar ) AS meqdar,
			SUM(tar.mablaq ) AS mablaq,
			SUM(tar.Remain ) AS Remain,
			SUM(tar.Remain * tar.nerkh) AS RemainMablaq

	FROM Anbar.tbl_Amaliat_Riz          AS tar
	INNER JOIN Base.tbl_Kala_Xadamat    AS tkx  ON tkx.Code = tar.FK_Kala
	INNER JOIN Base.tbl_Vahed           AS tv   ON tv.ID    = tkx.FK_Vahed

	Where  tar.FK_Title =   @ID

	GROUP BY tar.FK_Title,tar.FK_Kala,tkx.title,tv.title
)
SELECT 

Riz.FK_Title,
Riz.FK_Kala,
Riz.ObjectTitle,
Riz.UnitTitle,
Riz.meqdar,
Riz.Remain,
Riz.RemainMablaq,
Riz.mablaq,
Khroj.MablaqFrosh,
Khroj.MeqdarFrosh,
Khroj.MeqdarBargash,
Khroj.MablaqBargash,
Payment.Cache,
Payment.Pos,
ChequePayment.Cheque


FROM Riz

LEFT OUTER JOIN(

		Select 
		
		tar.FK_Kala,
		SUM(case when tat.kind =50 then tar.meqdar else 0 end ) AS MeqdarFrosh,
		SUM(case when tat.kind =51 then tar.meqdar else 0 end ) AS MeqdarBargash,

		SUM(case when tat.kind =50 then tar.nerkh_2 else 0 end ) AS MablaqFrosh,
		SUM(case when tat.kind =51 then tar.nerkh_2 else 0 end ) AS MablaqBargash
		

		FROM Anbar.tbl_Amaliat_Riz          	AS tar
		INNER JOIN Anbar.tbl_Amaliat_Title 		AS tat 		ON tar.FK_Title = tat.ID

		WHERE (tat.kind = 50 OR tat.kind = 51) AND tat.FK_Mabna = @ID

		GROUP BY tar.FK_Kala

)AS Khroj ON Khroj.FK_Kala = Riz.FK_Kala
 
 LEFT OUTER JOIN 
	(
		SELECT 
				tad.FK_Faktor,
				tad.Fk_Factor_radif_Id,
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
        
		WHERE tad.Fk_Factor_radif_Id IS NOT NULL AND tad.FK_Faktor =@ID
		
		GROUP BY tad.FK_Faktor,tad.Fk_Factor_radif_Id

	)  AS Payment ON Payment.FK_Faktor = Riz.FK_Title AND Payment.Fk_Factor_radif_Id = Riz.FK_Kala


LEFT OUTER JOIN
(
	SELECT 
		tad2.FK_Faktor ,
        tad2.Fk_Factor_radif_Id,
		SUM(tac.mablaq) AS Cheque

	FROM Xazane.tbl_Amaliat_Check		AS tac
	INNER JOIN Xazane.tbl_Amaliat_DP	AS tad2 ON tad2.ID = tac.FK_DP

	WHERE tad2.Fk_Factor_radif_Id is NOT NULL AND (tac.Kind_Vaziat <> 3 OR tac.Kind_Vaziat IS NULL) AND tad2.FK_Faktor =@ID
	GROUP BY tad2.FK_Faktor, tad2.Fk_Factor_radif_Id

) AS ChequePayment ON ChequePayment.FK_Faktor = Riz.FK_Title AND ChequePayment.Fk_Factor_radif_Id = Riz.FK_Kala

 

");
        }
    }
}
