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
	public class PishFoshShaxsConfig :   DapperEntityConfiguration<PishFroshShaxs>
	{
		public PishFoshShaxsConfig()
		{
			SetList($@"
SELECT 

tkx.Code,
LTRIM(RTRIM(tkx.title)) as Title,
Shaxs.PishFrosh,
ShaxTahvil.meqdar AS Tahvili,
Gardesh.MojudiKol,
Gardesh.Mojudi
 
FROM      Base.tbl_Kala_Xadamat       AS tkx 

INNER JOIN (

    Select 

    tar.FK_Kala ,
    SUM(tar.meqdar) as PishFrosh
    
    FROM        Anbar.tbl_Amaliat_Riz       AS tar
    INNER JOIN  Anbar.tbl_Amaliat_Title     AS tat      ON tar.FK_Title     = tat.ID

    WHERE 
            (tat.kind >= 50 AND tat.NoRemainEffect = 1)
        AND tat.FK_AshXas_ID = @People
        AND (tat.FK_Salmali = @Year OR @Year IS NULL)
        AND tat.FK_Anbar_Az = @Anbar

    GROUP BY        
        tar.FK_Kala 


)Shaxs ON Shaxs.FK_Kala = tkx.Code

LEFT OUTER JOIN (

    Select 

    tar.FK_Kala ,
    SUM(tar.meqdar) as meqdar
    
    FROM        Anbar.tbl_Amaliat_Riz       AS tar
    INNER JOIN  Anbar.tbl_Amaliat_Title     AS tat_Tahvil      ON tar.FK_Title     = tat_Tahvil.ID
    INNER JOIN  Anbar.tbl_Amaliat_Title     AS tat_PishFrosh   ON tat_PishFrosh.ID = tat_Tahvil.FK_Mabna 

    WHERE 
            (tat_Tahvil.kind = 56 )
        AND tat_PishFrosh.FK_AshXas_ID = @People
        AND (tat_Tahvil.FK_Salmali  = @Year OR @Year IS NULL)
        AND tat_Tahvil.FK_Anbar_Az  = @Anbar

    GROUP BY        
        tar.FK_Kala 


)ShaxTahvil ON ShaxTahvil.FK_Kala = tkx.Code



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

WHERE tkx.kind = 1 and Shaxs.PishFrosh > 0
");
		}
	}
}
