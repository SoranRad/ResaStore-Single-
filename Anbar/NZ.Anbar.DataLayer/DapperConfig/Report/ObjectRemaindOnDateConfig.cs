
using Nz.Anbar.Model.Report;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.Report
{
    public class ObjectRemaindOnDateConfig : DapperEntityConfiguration<ObjectRemaindOnDate>
    {
        public ObjectRemaindOnDateConfig()
        {
            SetList($@"

SELECT 

		tgk.FK_GroupKala_1th,
		tkx.FK_GroupKala_2th,
		tkx.Code,
		LTRIM(RTRIM(tkx.title))		AS ObjectTitle,
		LTRIM(RTRIM(tgk.title))		AS SubGroupTitle,
		LTRIM(RTRIM(tgk2.title))	AS MainGroupTitle,

		SUM( CASE WHEN tat.kind =  11					        THEN ISNULL( tar.meqdar,0) ELSE 0 END)  AS Init,
		SUM( CASE WHEN tat.kind >= 12 AND tat.kind <  50		THEN ISNULL( tar.meqdar,0) ELSE 0 END)  AS Input,
		SUM( CASE WHEN tat.kind >= 50 AND tat.kind <= 100	    THEN ISNULL( tar.meqdar,0) ELSE 0 END)  AS Output,
		SUM(CASE WHEN tat.kind  =  13				  		    THEN tar.meqdar * tar.nerkh_2
					WHEN tat.kind  >= 50 AND tat.kind <=  100	THEN -tar.nerkh_2
					WHEN tat.kind  >= 11 AND tat.kind <  50		THEN tar.meqdar * tar.nerkh 
					ELSE 0 
			END) AS RemainMablaq

		FROM		Base.tbl_Kala_Xadamat	AS tkx
		INNER JOIN	Anbar.tbl_Amaliat_Riz	AS tar	ON tkx.Code = tar.FK_Kala
		INNER JOIN	Anbar.tbl_Amaliat_Title AS tat	ON tat.ID = tar.FK_Title
		INNER JOIN	Base.tbl_GroupKala_2th	AS tgk	ON tgk.Code = tkx.FK_GroupKala_2th
		INNER JOIN	Base.tbl_GroupKala_1th	AS tgk2 ON tgk2.Code = tgk.FK_GroupKala_1th

		WHERE 
			 
			tat.FK_Salmali = @Year
		AND tat.tarikh <= @Tarikh
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
