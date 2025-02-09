using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.Report;
using ShareLib.Interfaces;

namespace NZ.Anbar.DataLayer.DapperConfig.Report
{
    public class XolaseTarakoneshConfig: DapperEntityConfiguration<CircularSummary>
    {
        public XolaseTarakoneshConfig()
        {
            SetList(@"
SELECT 
        pivotSub.ID,
        pivotSub.Title,
        pivotSub.code,
        pivotSub.[12] AS Purchase,
        pivotSub.[13] AS SaleBack,
        pivotSub.[50] AS Sale,
        pivotSub.[51] AS PurchaseBack
FROM
(
    SELECT 
        tat.kind,
        LTRIM(RTRIM(ta.title))  AS Title, 
        SUM(tat.mablaq)         AS Amount,
        ta.code,
        ta.ID

    FROM		Anbar.tbl_Amaliat_Title     AS tat 
    INNER JOIN	Base.tbl_Ashxas			    AS ta   ON ta.ID = tat.FK_AshXas_ID

    WHERE   tat.FK_Salmali=@Year
        AND tat.kind>=11 
        AND tat.kind <=100

    GROUP BY    tat.kind ,
                LTRIM(RTRIM(ta.title)), 
                ta.code,
                ta.ID
) sub 
PIVOT 
(	SUM(Amount) 
	FOR kind IN ([12],[13],[50],[51])
) pivotSub

");
        }
    }
}
