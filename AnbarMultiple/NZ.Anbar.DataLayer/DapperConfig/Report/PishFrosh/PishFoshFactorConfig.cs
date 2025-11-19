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
	public class PishFoshFactorConfig :   DapperEntityConfiguration<PishFoshFactor>
	{
		public PishFoshFactorConfig()
		{
			SetList($@"
SELECT 
tar.radif,
tar.FK_Kala ,
tar.radif ,
tar.meqdar ,
tar.nerkh ,
tar.takhfif ,
tar.takhfif_darsad ,
tar.mablaq ,
RTRIM(LTRIM(tkx.title)) AS ObjectTitle,
RTRIM(LTRIM(tv.title)) AS UnitTitle,
tkx.Code,
LTRIM(RTRIM(tkx.title)) AS Title,
tar.meqdar              AS PishFrosh,
Tahvil.meqdar           AS Tahvili,
Gardesh.Mojudi,
Gardesh.MojudiKol

FROM        Anbar.tbl_Amaliat_Riz       AS tar
INNER JOIN  base.tbl_Kala_Xadamat       AS tkx  on tar.FK_Kala = tkx.Code
INNER JOIN Base.tbl_Vahed AS tv ON tv.ID = tkx.FK_Vahed


LEFT OUTER JOIN (
    Select 
    tar.FK_Kala ,
    SUM(tar.meqdar) as meqdar
    
    FROM        Anbar.tbl_Amaliat_Riz       AS tar
    INNER JOIN  Anbar.tbl_Amaliat_Title     AS tat_Tahvil      ON tar.FK_Title     = tat_Tahvil.ID
    
    WHERE 
            (tat_Tahvil.kind = 56 )
        AND tat_Tahvil.FK_Mabna = @Factor 

    GROUP BY        
        tar.FK_Kala 
)Tahvil ON Tahvil.FK_Kala = tar.FK_Kala

LEFT OUTER JOIN (
     SELECT
        tar.FK_Kala,
        
        SUM(CASE WHEN tat.kind >=11 AND tat.kind <50 then tar.meqdar 
                 WHEN tat.kind >=50 AND tat.kind <100  then -tar.meqdar else 0 end) MojudiKol,
        SUM(CASE WHEN tat.kind >=11 AND tat.kind <50 then tar.meqdar 
                 WHEN tat.kind >=50 AND tat.kind <100 AND tat.NoRemainEffect =0 then -tar.meqdar else 0 end) Mojudi

    FROM        Anbar.tbl_Amaliat_Riz       AS tar
    INNER JOIN  Anbar.tbl_Amaliat_Title     AS tat      ON tar.FK_Title     = tat.ID

    WHERE 
            (tat.kind >= 11 AND tat.kind <= 100)
        AND (tat.FK_Salmali = @Year OR @Year IS NULL)
        AND tat.FK_Anbar_Az = @Anbar

    GROUP BY        
        tar.FK_Kala
) AS Gardesh ON Gardesh.FK_Kala = tkx.Code

WHERE  tar.FK_Title = @Factor
");
		}
	}
}
