using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Interfaces;
using ShareLib.ViewModel;

namespace NZ.Anbar.DataLayer.DapperConfig.Report
{
    public class DailyCircularConfig : DapperEntityConfiguration<DailyCircular>
    {
        public DailyCircularConfig()
        {
            SetList(@"
SELECT

tat.tarikh as GregorianDate,
dd.PersianStr,
dd.PersianMonthName,
dd.PersianMonthNo,

SUM(CASE WHEN tat.kind = @KindXarid		THEN tat.mablaq ELSE 0 END)		AS Xarid,
SUM(CASE WHEN tat.kind = @KindFrosh		THEN tat.mablaq ELSE 0 END)		AS Frosh,
SUM(CASE WHEN tat.kind = @KindBarFrosh	THEN tat.mablaq ELSE 0 END)		AS BargashtFrosh,
SUM(CASE WHEN tat.kind = @KindBarXarid	THEN tat.mablaq ELSE 0 END)		AS BargashtXarid,
SUM(CASE WHEN tat.kind = @KinZayeat		THEN tat.mablaq ELSE 0 END)		AS Zayat,
SUM(CASE WHEN tat.kind = @KindMasraf	THEN tat.mablaq ELSE 0 END)		AS Masraf


FROM		Anbar.tbl_Amaliat_Title		AS tat
INNER JOIN	General.DimDate				AS dd	ON tat.tarikh = dd.GregorianDate

WHERE   
        tat.FK_Salmali = @Year 
	    AND (tat.kind > 11 AND tat.kind <= 100)
        AND (dd.PersianMonthNo = @Month OR @Month = 13)

GROUP BY 

tat.tarikh,
dd.PersianStr,
dd.PersianMonthName,
dd.PersianMonthNo


");
        }

    }
}
