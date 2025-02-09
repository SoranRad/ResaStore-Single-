using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.Report;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.Report
{
    public class PepoleCircularDetailConfig : DapperEntityConfiguration<PeopleCircularDetail>
    {
        public PepoleCircularDetailConfig()
        {
            SetList(@"
SELECT  
tat.Serial,
dd.PersianStr,
tat.kind,
tat.ID AS IDTitle,
tar.ID,
tar.radif,
tar.FK_Kala,
LTRIM(RTRIM(tkx.title)) AS ObjectTitle,
LTRIM(RTRIM(tv.title))  AS UnitTitle,
tar.meqdar,
tar.nerkh,
tar.takhfif_darsad,
tar.takhfif,
tar.mablaq,
LTRIM(RTRIM(tbl.Title)) AS LocationTitle

FROM			Anbar.tbl_Amaliat_Riz	AS tar
INNER JOIN		Anbar.tbl_Amaliat_Title	AS tat	ON tat.ID = tar.FK_Title
INNER JOIN		Base.tbl_Kala_Xadamat	AS tkx	ON tkx.Code = tar.FK_Kala
INNER JOIN		Base.tbl_Vahed			AS tv	ON tv.ID = tkx.FK_Vahed
LEFT OUTER JOIN General.DimDate			AS dd	ON tat.tarikh = dd.GregorianDate
LEFT OUTER JOIN Base.tbl_Base_Location	AS tbl  ON tbl.ID = tat.FK_Location

WHERE 
	 tat.FK_Salmali		= @Year
AND  tat.FK_AshXas_ID   = @People	
AND  tat.kind >=11 AND tat.kind<=100
AND (tat.tarikh>=@DateFrom	OR @DateFrom	IS NULL)
AND (tat.tarikh<=@DateTo	OR @DateTo		IS NULL)

");
        }
    }
}
