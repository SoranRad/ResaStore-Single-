using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Interfaces;
using ShareLib.ViewModel;

namespace NZ.Anbar.DataLayer.DapperConfig.ViewModel
{
    public class RemaindConfig: DapperEntityConfiguration<RemaindBalance>
    {
        public RemaindConfig()
        {
            SetItem(@"

SELECT 

SUM(SubQuery.Balance) AS Balance

from (

SELECT 
SUM((CASE WHEN tat.kind >=12 AND tat.kind<50 THEN -tat.mablaq ELSE tat.mablaq END)) AS Balance
FROM  Anbar.tbl_Amaliat_Title	AS tat 
WHERE 
	tat.FK_Salmali = @Year 
AND tat.FK_AshXas_ID = @ID 
AND (tat.kind>=12 AND tat.kind<=100)


UNION ALL

SELECT 

SUM(-ISNULL(tatd.Darsad_Porsant,0)*tat.mablaq/100) AS Balance


FROM Anbar.tbl_Amaliat_Title_Detail AS tatd
INNER JOIN Anbar.tbl_Amaliat_Title	AS tat ON tat.ID = tatd.ID

WHERE 
    tat.FK_Salmali = @Year  
AND tatd.FK_Vaset = @ID  
AND tat.kind = 50

GROUP BY tat.kind


) AS SubQuery

");
        }
    }
}
