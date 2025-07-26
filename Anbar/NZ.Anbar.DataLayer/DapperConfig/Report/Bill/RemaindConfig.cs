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
SUM((CASE WHEN tat.kind >=12 AND tat.kind<50 THEN -tat.mablaq ELSE tat.mablaq END)) AS Balance
FROM  Anbar.tbl_Amaliat_Title	AS tat 
WHERE 
	tat.FK_Salmali = @Year 
AND tat.FK_AshXas_ID = @ID 
AND (tat.kind>=12 AND tat.kind<=100)

");
        }
    }
}
