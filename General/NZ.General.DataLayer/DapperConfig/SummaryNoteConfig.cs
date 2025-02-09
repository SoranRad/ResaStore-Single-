using ShareLib.Interfaces;
using ShareLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ.General.DataLayer.DapperConfig
{
    public class SummaryNoteConfig : DapperEntityConfiguration<SummaryNote>
    {
        public SummaryNoteConfig()
        {
            SetList(@"
SELECT 
dd.GregorianDate,
dd.PersianStr,
dd.PersianMonthNo,
dd.PersianMonthName,
dd.PersianDayOfWeekName,
dd.PersianDayOfWeekInt,
(
    SELECT  
    (
	    SELECT ' ( ' + Messages.Msg + ' ) '
	    FROM (
			    SELECT 
				    LTRIM(RTRIM(tdn.Msg)) AS Msg
			    FROM General.tbl_DailyNote AS tdn
			    WHERE tdn.Date =dd.GregorianDate
	    ) AS Messages
	    FOR XML PATH(''), TYPE
    ).value('.', 'NVARCHAR(Max)')
)AS msg

FROM General.DimDate AS dd
LEFT OUTER JOIN General.tbl_DailyNote AS tdn ON dd.GregorianDate = tdn.Date

WHERE dd.PersianYearInt=@Year

GROUP BY 

dd.GregorianDate,
dd.PersianStr,
dd.PersianMonthNo,
dd.PersianMonthName,
dd.PersianDayOfWeekName,
dd.PersianDayOfWeekInt
");
        }
    }

    public class YearNoteListConfig : DapperEntityConfiguration<YearNoteList>
    {
        public YearNoteListConfig()
        {
            SetList(@"
SELECT 
dd.PersianYearInt

FROM General.tbl_DailyNote AS tdn
INNER JOIN General.DimDate AS dd ON dd.GregorianDate = tdn.Date

GROUP BY 
dd.PersianYearInt

");
        }
    }


}
