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

SELECT tar.ID ,
       tar.FK_Kala ,
       tar.radif ,
       tar.meqdar ,
       tar.nerkh ,
       tar.takhfif ,
       tar.takhfif_darsad ,
       tar.mablaq ,
	   tar.Remain,
       RTRIM(LTRIM(tar.CostDescriptor)) AS CostDescriptor,
       RTRIM(LTRIM(tkx.title)) AS ObjectTitle,
	   RTRIM(LTRIM(tv.title)) AS UnitTitle,
  Payment.Cache,
  Payment.Pos,
  ChequePayment.Cheque

	   
FROM Anbar.tbl_Amaliat_Riz          AS tar
INNER JOIN Base.tbl_Kala_Xadamat    AS tkx  ON tkx.Code = tar.FK_Kala
INNER JOIN Base.tbl_Vahed           AS tv   ON tv.ID    = tkx.FK_Vahed


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
        WHERE tad.Fk_Factor_radif_Id IS NOT NULL
		GROUP BY tad.FK_Faktor,tad.Fk_Factor_radif_Id

	)  AS Payment ON Payment.FK_Faktor = tar.FK_Title AND Payment.Fk_Factor_radif_Id = tar.ID


    LEFT OUTER JOIN
(
	SELECT 
		tad2.FK_Faktor ,
        tad2.Fk_Factor_radif_Id,
		SUM(tac.mablaq) AS Cheque

	FROM Xazane.tbl_Amaliat_Check		AS tac
	INNER JOIN Xazane.tbl_Amaliat_DP	AS tad2 ON tad2.ID = tac.FK_DP

	WHERE tad2.Fk_Factor_radif_Id is NOT NULL AND (tac.Kind_Vaziat <> 3 OR tac.Kind_Vaziat IS NULL)
	GROUP BY tad2.FK_Faktor, tad2.Fk_Factor_radif_Id

) AS ChequePayment ON ChequePayment.FK_Faktor = tar.FK_Title AND ChequePayment.Fk_Factor_radif_Id = tar.ID


WHERE tar.FK_Title = @ID 


");
        }
    }
}
