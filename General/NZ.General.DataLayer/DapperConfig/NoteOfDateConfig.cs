using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Interfaces;
using ShareLib.Models;
using ShareLib.Models.Report;

namespace NZ.General.DataLayer.DapperConfig
{
    public class NoteOfDateConfig : DapperEntityConfiguration<NoteOfDate>
    {
        public NoteOfDateConfig()
        {
            SetList(@"
SELECT 

 dd.PersianStr           
,dd.PersianDayOfWeekName 
,tdn.Msg                  

FROM 
				General.tbl_DailyNote	AS tdn
LEFT OUTER JOIN General.DimDate			AS dd	ON dd.GregorianDate = tdn.Date

WHERE tdn.Date = @Date 

");
        }
    }
}
