using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.Report;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.Report
{
    public class PeopleMiscMountConfig : DapperEntityConfiguration<PeopleMiscMount>
    {
        public PeopleMiscMountConfig()
        {
            SetList(@"

SELECT 

tat.Serial,
dd.PersianStr,
tat.kind,
(1)                     AS kindMisc,
tat.ID,
N'تخفیف '				AS ObjectTitle,
tatd.Darsad_Takhfif		AS darsad,
tatd.mablaq_takhfif		AS mablaq

FROM				Anbar.tbl_Amaliat_Title_Detail	AS tatd
INNER JOIN			Anbar.tbl_Amaliat_Title			AS tat  ON tatd.ID = tat.ID
LEFT OUTER JOIN		General.DimDate					AS dd	ON tat.tarikh = dd.GregorianDate

WHERE 
	 tat.FK_Salmali		= @Year
AND  tat.FK_AshXas_ID   = @People	
AND  tat.kind >=11 AND tat.kind<=100
AND	 tatd.mablaq_takhfif >0
AND (tat.tarikh>=@DateFrom	OR @DateFrom	IS NULL)
AND (tat.tarikh<=@DateTo	OR @DateTo		IS NULL)

UNION ALL 

SELECT 

tat.Serial,
dd.PersianStr,
tat.kind,
(2)             AS kindMisc,
tat.ID,
N'اضافات '		AS ObjectTitle,
(NULL)			AS darsad,
tatd.Ezafat		AS mablaq

FROM				Anbar.tbl_Amaliat_Title_Detail	AS tatd
INNER JOIN			Anbar.tbl_Amaliat_Title			AS tat  ON tatd.ID = tat.ID
LEFT OUTER JOIN		General.DimDate					AS dd	ON tat.tarikh = dd.GregorianDate

WHERE 
	 tat.FK_Salmali		= @Year
AND  tat.FK_AshXas_ID   = @People	
AND  tat.kind >=11 AND tat.kind<=100
AND  tatd.Ezafat > 0
AND (tat.tarikh>=@DateFrom	OR @DateFrom	IS NULL)
AND (tat.tarikh<=@DateTo	OR @DateTo		IS NULL)

UNION ALL 

SELECT 

tat.Serial,
dd.PersianStr,
tat.kind,
(3)                     AS kindMisc,
tat.ID,
N'مالیات '				AS ObjectTitle,
(tatd.Darsad_Maliat)	AS darsad,
tatd.mablaq_Maliat		AS mablaq

FROM				Anbar.tbl_Amaliat_Title_Detail	AS tatd
INNER JOIN			Anbar.tbl_Amaliat_Title			AS tat  ON tatd.ID = tat.ID
LEFT OUTER JOIN		General.DimDate					AS dd	ON tat.tarikh = dd.GregorianDate

WHERE 
	 tat.FK_Salmali		= @Year
AND  tat.FK_AshXas_ID   = @People	
AND  tat.kind >=11 AND tat.kind<=100
AND  tatd.mablaq_Maliat > 0
AND (tat.tarikh>=@DateFrom	OR @DateFrom	IS NULL)
AND (tat.tarikh<=@DateTo	OR @DateTo		IS NULL)

");
        }
    }
}
