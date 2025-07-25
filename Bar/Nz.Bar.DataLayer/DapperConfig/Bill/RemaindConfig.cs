using ShareLib.Interfaces;
using ShareLib.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Bar.DataLayer.DapperConfig.Bill
{
	public class RemaindConfig: DapperEntityConfiguration<RemaindBalance>
	{
		public RemaindConfig()
		{
			SetList(@"
SELECT 
 
-SUM(tbf.Mablaq) AS Balance  

FROM        Bar.tbl_BarFactor       AS tbf
 
WHERE

    (tbf.FK_Salmali  =  @Year     OR @Year IS NULL)
AND (tbf.FK_People   =  @People ) 

");
		}
	}
}
