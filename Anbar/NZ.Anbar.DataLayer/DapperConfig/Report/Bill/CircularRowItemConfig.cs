using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Interfaces;
using ShareLib.ViewModel;

namespace NZ.Anbar.DataLayer.DapperConfig.ViewModel
{
    public class CircularRowItemConfig : DapperEntityConfiguration<CircularRowItem>
    {
        public CircularRowItemConfig()
        {
            SetList(@"
SELECT 

(2) AS SubSystem ,
tat.ID ,
dd.PersianStr,
tat.tarikh AS Date,
tat.kind,
LTRIM(RTRIM(tat.sharh)) AS Description,

Anbar.GetFactorDetail(tat.ID,@TopCount) AS Title,

(CASE WHEN tat.kind >=12 AND tat.kind<50 THEN 0 ELSE tat.mablaq END) AS Debit,
(CASE WHEN tat.kind >=12 AND tat.kind<50 THEN tat.mablaq ELSE 0 END) AS Credit,

(0) AS Remaind

FROM Anbar.tbl_Amaliat_Title AS tat
LEFT OUTER JOIN General.DimDate AS dd ON tat.tarikh= dd.GregorianDate

WHERE 
	(tat.FK_Salmali=@Year  OR @Year IS NULL)
AND tat.FK_AshXas_ID=@People 
AND (tat.tarikh>=@DateFrom OR @DateFrom IS NULL)
AND (tat.tarikh<=@DateTo   OR @DateTo   IS NULL)
AND (tat.kind>=11 AND tat.kind<=55)

");
        }
    }
}
