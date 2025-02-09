using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.Report;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.Report
{
   public class PointOrderConfig:DapperEntityConfiguration<PointOrder>
    {
        public PointOrderConfig()
        {
            SetList(@"
SELECT 

tgk.FK_GroupKala_1th,
tkx.FK_GroupKala_2th,
tkx.Code,
RTRIM(RTRIM(tkx.title))		AS ObjectTitle,
RTRIM(RTRIM(tgk.title))		AS SubGroupTitle,
RTRIM(RTRIM(tgk2.title))	AS MainGroupTitle,
tkx.point_bohrani,

SUM(CASE WHEN tat.kind >=11 AND tat.kind<50 THEN tar.meqdar ELSE -tar.meqdar END) AS Remaind

FROM		Base.tbl_Kala_Xadamat	AS tkx
INNER JOIN	Anbar.tbl_Amaliat_Riz	AS tar	ON tkx.Code		= tar.FK_Kala
INNER JOIN	Anbar.tbl_Amaliat_Title AS tat	ON tat.ID		= tar.FK_Title
INNER JOIN	Base.tbl_GroupKala_2th	AS tgk	ON tgk.Code		= tkx.FK_GroupKala_2th
INNER JOIN	Base.tbl_GroupKala_1th	AS tgk2 ON tgk2.Code	= tgk.FK_GroupKala_1th

WHERE 
	        tat.FK_Salmali= @Year
        AND tat.kind >= 11 
        AND tat.kind <= 100
        AND tkx.point_bohrani > 0 
        AND tkx.kind = 1
GROUP BY 
tgk.FK_GroupKala_1th,
tkx.FK_GroupKala_2th,
tkx.Code,
RTRIM(RTRIM(tkx.title)) ,
RTRIM(RTRIM(tgk.title))  ,
RTRIM(RTRIM(tgk2.title)) ,

tkx.point_bohrani
");

        }
    }
}
