using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.Report.Profit;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.Report
{
    public class ChartSummarryConfig : DapperEntityConfiguration<ChartSummarry>
    {
        public ChartSummarryConfig()
        {
            SetList(@"

select 

tat.kind,
SUM(tat.mablaq) as mablaq

FROM Anbar.tbl_Amaliat_Title AS tat

WHERE tat.FK_Salmali = @Year
GROUP BY tat.kind

");
        }
    }
}
