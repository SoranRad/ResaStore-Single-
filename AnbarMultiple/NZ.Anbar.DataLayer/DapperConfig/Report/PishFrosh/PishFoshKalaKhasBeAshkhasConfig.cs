using Nz.Anbar.Model.Report.PishFrosh;
using ShareLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ.Anbar.DataLayer.DapperConfig.Report.PishFrosh
{
	internal class PishFoshKalaKhasBeAshkhasConfig : DapperEntityConfiguration<PishFoshKalaKhasBeAshkhas>
	{
		public PishFoshKalaKhasBeAshkhasConfig()
		{
			SetList(@"
SELECT 

ta.ID,
LTRIM(RTRIM(ta.title)) AS title,
LTRIM(RTRIM(ta.mobile)) AS Mobile,
LTRIM(RTRIM(ta.codeMeli)) As CodeMelli,
PishFrosh.Meqdar AS MeqdarPishFrosh,
PishFrosh.TedadFactor ,
Tahvili.Meqdar AS MeqdarTahvili,
Tahvili.TedadHavale

FROM Base.tbl_Ashxas AS ta

LEFT OUTER JOIN (

        Select 

        tat.FK_AshXas_ID ,
        SUM(tar.meqdar) as Meqdar,
        COUNT(distinct tat.ID)  AS TedadFactor

        FROM        Anbar.tbl_Amaliat_Riz       AS tar
        INNER JOIN  Anbar.tbl_Amaliat_Title     AS tat      ON tar.FK_Title     = tat.ID

        WHERE 
                (tat.kind = 50 AND tat.NoRemainEffect = 1)
            AND tar.FK_Kala     = @Kala 
            AND (tat.FK_Salmali = @Year OR @Year IS NULL)
            AND tat.FK_Anbar_Az = @Anbar

        GROUP BY        
            tat.FK_AshXas_ID

)AS PishFrosh on PishFrosh.FK_AshXas_ID = ta.ID


LEFT OUTER JOIN (

        Select 

        tat_PishFrosh.FK_AshXas_ID,
        tat_Tahvil.FK_Tahvil_Girande,
        SUM(tar.meqdar) as Meqdar,
        COUNT(distinct tat_Tahvil.ID)  AS TedadHavale

        FROM        Anbar.tbl_Amaliat_Riz           AS tar
        INNER JOIN  Anbar.tbl_Amaliat_Title         AS tat_Tahvil      ON tar.FK_Title     = tat_Tahvil.ID
        LEFT OUTER JOIN  Anbar.tbl_Amaliat_Title    AS tat_PishFrosh   ON tat_PishFrosh.ID = tat_Tahvil.FK_Mabna 

        WHERE 
                (tat_Tahvil.kind = 56 )
            AND tar.FK_Kala             = @Kala 
            AND (tat_Tahvil.FK_Salmali  = @Year OR @Year IS NULL)
            AND tat_Tahvil.FK_Anbar_Az  = @Anbar

        GROUP BY        
           tat_PishFrosh.FK_AshXas_ID,
            tat_Tahvil.FK_Tahvil_Girande

) As Tahvili ON Tahvili.FK_AshXas_ID = ta.ID OR Tahvili.FK_Tahvil_Girande = ta.ID

WHERE Tahvili.Meqdar >0 OR PishFrosh.Meqdar >0

");
		}
	}
}
