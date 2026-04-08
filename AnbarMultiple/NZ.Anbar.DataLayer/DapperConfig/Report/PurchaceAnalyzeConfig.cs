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
			tar.radif,
			tar.FK_Title,
			tar.FK_Kala,
			tar.nerkh,
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

	GROUP BY tar.FK_Title,tar.FK_Kala,tkx.title,tv.title,tar.radif, tar.nerkh
)
SELECT 

Riz.radif,
Riz.FK_Title,
Riz.FK_Kala,
Riz.ObjectTitle,
Riz.UnitTitle,
Riz.meqdar,
Riz.Remain,
Riz.RemainMablaq,
Riz.mablaq,
Riz.nerkh,
Frosh.MablaqFrosh,
Frosh.MeqdarFrosh,
Frosh.MablaqSoud

FROM Riz

LEFT OUTER JOIN(

		Select 
		
		tar.FK_Kala,
		SUM( tar.meqdar)	AS MeqdarFrosh, 
		SUM( tar.mablaq )	AS MablaqFrosh,
		SUM( tar.mablaq - tar.nerkh_2 )  AS MablaqSoud 
		

		FROM            Anbar.tbl_Amaliat_Riz          	    AS tar
		INNER JOIN      Anbar.tbl_Amaliat_Title 		    AS tat 		ON tar.FK_Title = tat.ID

		WHERE tat.kind = 50  AND tat.FK_Mabna = @ID

		GROUP BY tar.FK_Kala

)AS Frosh ON Frosh.FK_Kala = Riz.FK_Kala
 
");
        }
    }
}
