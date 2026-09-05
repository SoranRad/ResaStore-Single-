using ShareLib.Interfaces;
using ShareLib.Models.Report;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ.General.DataLayer.DapperConfig
{
	public class KalaXadamatConfig : DapperEntityConfiguration<KalaXadamat>
	{
		public KalaXadamatConfig()
		{
			SetList(@"

SELECT tkx.ID ,
       tkx.FK_GroupKala_2th ,
       tkx.FK_Vahed ,
       tkx.kind ,
       tkx.Code ,
       Rtrim(Ltrim(tkx.title	)) AS title,
       Rtrim(Ltrim(tkx.barcode	)) AS barcode,
       Rtrim(Ltrim(tkx.nameFani )) AS nameFani,
       Rtrim(Ltrim(tkx.codeFani )) AS codeFani,
       tkx.point_bohrani ,
       tkx.is_disabled ,
       tkx.nerkh_frosh ,
       tkx.nerkh_frosh1 ,
       tkx.nerkh_frosh2 ,
       tkx.nerkh_frosh3 ,
       tkx.FK_Image ,
       Rtrim(Ltrim(tkx.keshvarSazande   ))  AS keshvarSazande,
	   RTRIM(LTRIM(tv.title			    ))	AS UnitTitle,
	   RTRIM(LTRIM(tgk2.title		    ))	AS MainGroupTitle,
	   RTRIM(LTRIM(tgk.title		    ))	AS SubGroupTitle,
       tkx.FK_Brand,
       tkx.FK_BasteBandi,
       tkx.Height,
       tkx.Width,
       tkx.Length,
	   tkx.nerkh_frosh,
       tkx.Season,
	   LTRIM(RTRIM(tkx.Size)) AS Size,
	   tkx.Color,
       tkx.Zarib,
       tkx.FK_Vahed_Fari,
       Rtrim(Ltrim(tkx.Gender)) AS Gender,
	   LTRIM(RTRIM(tb.Title))  AS BrandTitle,
	   LTRIM(RTRIM(tbb.Title)) AS BastebandiTitle,
       tkx.WebSiteProductKind,
       tkx.WebSiteProductId1, 
       tkx.WebSiteProductId2 ,
       tkx.IsOffActive,
       tkx.IsOffPercent,
       tkx.OffAmount,
       tkx.ShowInBarcodeForm

FROM Base.tbl_Kala_Xadamat              AS tkx
INNER JOIN Base.tbl_Vahed               AS tv       ON tv.ID        = tkx.FK_Vahed
INNER JOIN Base.tbl_GroupKala_2th       AS tgk      ON tgk.Code     = tkx.FK_GroupKala_2th
LEFT OUTER JOIN Base.tbl_GroupKala_1th  AS tgk2     ON tgk2.Code    = tgk.FK_GroupKala_1th
LEFT OUTER JOIN Base.tbl_Brand		    AS tb	    ON tb.ID	    = tkx.FK_Brand
LEFT OUTER JOIN Base.tbl_BasteBandi	    AS tbb	    ON tbb.ID	    = tkx.FK_BasteBandi

");

		}
	}
}
