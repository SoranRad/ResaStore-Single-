using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.Report;
using Nz.Anbar.Model.Report.PishFrosh;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.Report.PishFrosh
{
	public class PishFoshKalaConfig :   DapperEntityConfiguration<PishFoshKala>
	{
		public PishFoshKalaConfig()
		{
			SetList($@"
SELECT 

tkx.Code,
LTRIM(RTRIM(tkx.title)) as Title,
Gardesh.PishFrosh,
Gardesh.Tahvili,
Gardesh.FroshXales,
Gardesh.MojudiKol,
Gardesh.Frosh,
Gardesh.Mojudi
 
from        Base.tbl_Kala_Xadamat       AS tkx 

INNER JOIN (
 
    SELECT
        tar.FK_Kala,
        SUM(CASE WHEN tat.NoRemainEffect =1 AND tat.kind=50 then tar.meqdar else 0 end) AS PishFrosh,
        SUM(CASE WHEN tat.FK_Mabna is NOT NULL AND tat.kind=56 then tar.meqdar else 0 end) AS Tahvili,
        SUM(CASE WHEN tat.kind=50 then tar.meqdar WHEN tat.kind = 13 then -tar.meqdar else 0 end) AS FroshXales,
        SUM(CASE WHEN tat.kind >=11 AND tat.kind <50 then tar.meqdar 
                 WHEN tat.kind >=50 AND tat.kind <100  then -tar.meqdar else 0 end) MojudiKol,
        SUM(CASE WHEN tat.kind=50 AND tat.NoRemainEffect =0 then tar.meqdar WHEN tat.kind = 13 then -tar.meqdar else 0 end) AS Frosh,
        SUM(CASE WHEN tat.kind >=11 AND tat.kind <50 then tar.meqdar 
                 WHEN tat.kind >=50 AND tat.kind <100 AND tat.NoRemainEffect =0 then -tar.meqdar else 0 end) Mojudi

    FROM        Anbar.tbl_Amaliat_Riz       AS tar
    INNER JOIN  Anbar.tbl_Amaliat_Title     AS tat      ON tar.FK_Title     = tat.ID
    LEFT OUTER JOIN  Anbar.tbl_Amaliat_Title AS tat_Tahvil ON tat_tahvil.ID = tat.FK_Mabna AND tat.kind=56

    WHERE 
            (tat.kind >= 11 AND tat.kind <= 100)
        AND (tat.FK_Salmali = @Year OR @Year IS NULL)
        AND tat.FK_Anbar_Az = @Anbar
        AND (tat.FK_AshXas_ID = @People OR tat_tahvil.FK_AshXas_ID = @People OR @People IS NULL)

    GROUP BY        
        tar.FK_Kala

) AS Gardesh ON Gardesh.FK_Kala = tkx.Code

WHERE  tkx.kind = 1 and Gardesh.PishFrosh > 0
");
		}
	}
}
