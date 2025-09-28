using Nz.Anbar.Model.Report;
using ShareLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ.Anbar.DataLayer.DapperConfig.Report
{
	public class ObjectsOfActiveGroupConfig : DapperEntityConfiguration<ObjectsOfActiveGroup>
	{
		public ObjectsOfActiveGroupConfig()
		{
			SetList(@"
SELECT tkx.ID ,
       tkx.FK_GroupKala_2th ,
       tkx.kind ,
       tkx.Code ,
       Rtrim(Ltrim(tkx.title	))          AS title,
       tkx.is_disabled ,
       tkx.nerkh_frosh ,
       tkx.nerkh_frosh1 ,
       tkx.nerkh_frosh2 ,
       tkx.nerkh_frosh3 ,
	   RTRIM(LTRIM(tgk.title		    ))	AS SubGroupTitle

FROM Base.tbl_Kala_Xadamat              AS tkx
INNER JOIN Base.tbl_GroupKala_2th       AS tgk      ON tgk.Code     = tkx.FK_GroupKala_2th

WHERE tgk.ShowInBarcode = 1 AND tkx.is_disabled = 0

			");
		}
	}
}
