using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Site.Model.Models;
using ShareLib.Interfaces;

namespace Nz.Site.DataLayer.DapperConfig.Report
{
	public class SyncObjectsInProductsConfig :  DapperEntityConfiguration<SyncObjectsInProducts>
	{
		public SyncObjectsInProductsConfig()
		{
			SetList(@"

SELECT 

tkx.Code,
LTRIM(RTRIM(tkx.title))		AS ObjectTitle,
LTRIM(RTRIM(tgk.title))		AS SubGroupTitle,  
tkx.nerkh_frosh,
tkx.nerkh_frosh1,
tkx.nerkh_frosh2,
tkx.nerkh_frosh3,

tkx.WebSiteProductKind,
tkx.WebSiteProductId1, 
tkx.WebSiteProductId2,

SUM( CASE WHEN tat.kind >= 11 AND tat.kind <  50 THEN tar.meqdar ELSE -tar.meqdar END)  AS Remain


FROM		Base.tbl_Kala_Xadamat	AS tkx
INNER JOIN	Anbar.tbl_Amaliat_Riz	AS tar	ON tkx.Code = tar.FK_Kala
INNER JOIN	Anbar.tbl_Amaliat_Title AS tat	ON tat.ID = tar.FK_Title
INNER JOIN	Base.tbl_GroupKala_2th	AS tgk	ON tgk.Code = tkx.FK_GroupKala_2th 

WHERE 
    tat.FK_Salmali = @Year
AND tat.kind >= 11 
AND tat.kind <= 100
AND tkx.WebSiteProductKind IS NOT NULL
AND tkx.WebSiteProductId1 IS NOT NULL


GROUP BY 
tkx.Code,
tkx.WebSiteProductId1,
LTRIM(RTRIM(tkx.title)),
LTRIM(RTRIM(tgk.title)),
tkx.nerkh_frosh,
tkx.nerkh_frosh1,
tkx.nerkh_frosh2,
tkx.nerkh_frosh3,
tkx.WebSiteProductKind,
tkx.WebSiteProductId1, 
tkx.WebSiteProductId2


");
		}
	}
}
