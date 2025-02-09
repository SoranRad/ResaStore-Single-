using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.Report;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.Report
{
    public class ObjectRemaindConfig : DapperEntityConfiguration<ObjectRemaind>
    {
        public ObjectRemaindConfig()
        {
            /*
SELECT 

tgk.FK_GroupKala_1th,
tkx.FK_GroupKala_2th,
tkx.Code,
RTRIM(RTRIM(tkx.title))		AS ObjectTitle,
RTRIM(RTRIM(tgk.title))		AS SubGroupTitle,
RTRIM(RTRIM(tgk2.title))	AS MainGroupTitle,

SUM( CASE WHEN tat.kind = 11					THEN tar.meqdar ELSE 0 END)  AS Init,
SUM( CASE WHEN tat.kind>=12 AND tat.kind<50		THEN tar.meqdar ELSE 0 END)  AS Input,
SUM( CASE WHEN tat.kind>=50 AND tat.kind<=100	THEN tar.meqdar ELSE 0 END)  AS Output,
SUM(CASE WHEN tat.kind>=11 AND tat.kind<50		THEN tar.Remain*tar.nerkh ELSE 0 END) AS RemainMablaq

FROM		Base.tbl_Kala_Xadamat	AS tkx
INNER JOIN	Anbar.tbl_Amaliat_Riz	AS tar	ON tkx.Code = tar.FK_Kala
INNER JOIN	Anbar.tbl_Amaliat_Title AS tat	ON tat.ID = tar.FK_Title
INNER JOIN	Base.tbl_GroupKala_2th	AS tgk	ON tgk.Code = tkx.FK_GroupKala_2th
INNER JOIN	Base.tbl_GroupKala_1th	AS tgk2 ON tgk2.Code = tgk.FK_GroupKala_1th

WHERE 
	tat.FK_Salmali=@Year
AND tat.kind >=11 
AND tat.kind<=100

GROUP BY 
tgk.FK_GroupKala_1th,
tkx.FK_GroupKala_2th,
tkx.Code,
RTRIM(RTRIM(tkx.title)),
RTRIM(RTRIM(tgk.title)),
RTRIM(RTRIM(tgk2.title))

             */
            SetList(@"

                    SELECT 

                    tgk.FK_GroupKala_1th,
                    tkx.FK_GroupKala_2th,
                    tkx.Code,
                    LTRIM(RTRIM(tkx.title))		AS ObjectTitle,
                    LTRIM(RTRIM(tgk.title))		AS SubGroupTitle,
                    LTRIM(RTRIM(tgk2.title))	AS MainGroupTitle,

                    SUM( CASE WHEN tat.kind =  11					        THEN tar.meqdar ELSE 0 END)  AS Init,
                    SUM( CASE WHEN tat.kind >= 12 AND tat.kind <  50		THEN tar.meqdar ELSE 0 END)  AS Input,
                    SUM( CASE WHEN tat.kind >= 50 AND tat.kind <= 100	    THEN tar.meqdar ELSE 0 END)  AS Output,
                    SUM(CASE WHEN tat.kind  =  13				  		    THEN tar.Remain * tar.nerkh_2
		                     WHEN tat.kind  >= 11 AND tat.kind <  50		THEN tar.Remain * tar.nerkh 
		                     ELSE 0 
	                    END) AS RemainMablaq

                    FROM		Base.tbl_Kala_Xadamat	AS tkx
                    INNER JOIN	Anbar.tbl_Amaliat_Riz	AS tar	ON tkx.Code = tar.FK_Kala
                    INNER JOIN	Anbar.tbl_Amaliat_Title AS tat	ON tat.ID = tar.FK_Title
                    INNER JOIN	Base.tbl_GroupKala_2th	AS tgk	ON tgk.Code = tkx.FK_GroupKala_2th
                    INNER JOIN	Base.tbl_GroupKala_1th	AS tgk2 ON tgk2.Code = tgk.FK_GroupKala_1th

                    WHERE 
	                    tat.FK_Salmali = @Year
                    AND tat.kind >= 11 
                    AND tat.kind <= 100

                    GROUP BY 
                    tgk.FK_GroupKala_1th,
                    tkx.FK_GroupKala_2th,
                    tkx.Code,
                    LTRIM(RTRIM(tkx.title)),
                    LTRIM(RTRIM(tgk.title)),
                    LTRIM(RTRIM(tgk2.title))

");
        }
    }
}
