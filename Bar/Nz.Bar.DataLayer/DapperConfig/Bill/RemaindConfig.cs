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
			SetItem(@"
DECLARE @Mahsul DECIMAL,@Ersal DECIMAL

SET @Mahsul = (

SELECT

-SUM(tbf.Mablaq) AS Balance  

FROM        Bar.tbl_BarFactor       AS tbf
 
WHERE

    (tbf.FK_Salmali  =  @Year     OR @Year IS NULL)
AND (tbf.FK_People   =  @People ) 

)

SET @Ersal = (

SELECT

SUM(tek.Mablaq) AS Balance  

FROM Bar.tbl_ErsalKarkhane          AS tek 
 
WHERE

    (tek.FK_Salmali		=  @Year     OR @Year IS NULL)
AND (tek.FK_Karkhane    =  @People ) 

)

SELECT @Mahsul + @Ersal  AS Balance
");
		}
	}
}
