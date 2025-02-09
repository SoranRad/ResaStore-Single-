using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Nz.Anbar.Model.ViewModel;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.ViewModel
{
    public class AvailObjectConfig :DapperEntityConfiguration<AvailObject>
    {
        public AvailObjectConfig()
        {
            SetList(@"
SELECT tkx.ID ,
       tkx.FK_GroupKala_2th ,
       tkx.FK_Vahed ,
       tkx.kind ,
       tkx.Code ,
       Rtrim(Ltrim(tkx.title			)) AS title,
	   Balance.remaind,
       Rtrim(Ltrim(tkx.barcode			)) AS barcode,
       Rtrim(Ltrim(tkx.nameFani			)) AS nameFani,
       Rtrim(Ltrim(tkx.codeFani			)) AS codeFani,
       tkx.point_bohrani ,
       tkx.is_disabled ,
       tkx.nerkh_frosh ,
       tkx.nerkh_frosh1 ,
       tkx.nerkh_frosh2 ,
       tkx.nerkh_frosh3 ,
       tkx.FK_Image ,
       tkx.FK_Vahed_Fari,
	   tkx.Zarib,
       Rtrim(Ltrim(tkx.keshvarSazande   ))  AS keshvarSazande,
	   RTRIM(LTRIM(tv.title			    ))	AS UnitTitle,
	   RTRIM(LTRIM(tgk.title		    ))	AS SubGroupTitle,
	   RTRIM(LTRIM(tv2.title			    ))	AS Unit2Title

FROM				Base.tbl_Kala_Xadamat	AS tkx
INNER JOIN			Base.tbl_Vahed			AS tv	ON tv.ID		= tkx.FK_Vahed 
LEFT OUTER JOIN		Base.tbl_Vahed			AS tv2	ON tv2.ID		= tkx.FK_Vahed_Fari
INNER JOIN			Base.tbl_GroupKala_2th	AS tgk	ON tgk.Code		= tkx.FK_GroupKala_2th
LEFT OUTER JOIN (
                    SELECT 
                    tar.FK_Kala,
                    SUM(	CASE 
			                    WHEN tat.kind>=11 AND tat.kind<50	THEN tar.meqdar
			                    WHEN tat.kind>=50 AND tat.kind<100 then -tar.meqdar
		                    ELSE 0 END
	                   )  AS remaind

                    FROM			Anbar.tbl_Amaliat_Riz	AS tar
                    INNER JOIN		Anbar.tbl_Amaliat_Title AS tat	ON tat.ID = tar.FK_Title
                    WHERE tat.FK_Salmali = @Year
                    AND	  tat.kind >=11 AND tat.kind<=100
                    GROUP BY tar.FK_Kala
                )AS Balance ON Balance.FK_Kala = tkx.Code

");
        }
    }
}
