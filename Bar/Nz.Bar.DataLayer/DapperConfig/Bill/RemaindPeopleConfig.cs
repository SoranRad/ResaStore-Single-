using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Interfaces;
using ShareLib.ViewModel;

namespace Nz.Bar.DataLayer.DapperConfig.Bill
{
	public class RemaindPeopleConfig: DapperEntityConfiguration<RemaindPeople>
	{
		public RemaindPeopleConfig()
		{
			SetList(@"

SELECT 

ta.ID,
ta.code,
LTRIM(RTRIM(ta.title ))		AS Title,
LTRIM(RTRIM(tga.Title))		AS GroupTitle,
ta.FK_Group ,
ta.kind ,
RTRIM(LTRIM(ta.namePedar))	AS  namePedar,
RTRIM(LTRIM(ta.codeMeli))	AS  codeMeli,
RTRIM(LTRIM(ta.tel))		AS tel ,
RTRIM(LTRIM(ta.mobile))		AS mobile,
Bar.Balance


FROM Base.tbl_Ashxas AS ta
LEFT OUTER JOIN Base.tbl_Group_Ashxas AS tga ON tga.ID = ta.FK_Group

LEFT OUTER JOIN(

SELECT 
tbf.FK_People ,
-SUM(tbf.Mablaq) AS Balance  

FROM        Bar.tbl_BarFactor       AS tbf 

WHERE tbf.FK_Salmali = @Year 
AND  (tbf.tarikh >=@AzTarikh OR @AzTarikh IS NULL)
AND  (tbf.tarikh <=@TaTarikh OR @TaTarikh IS NULL)

GROUP BY  tbf.FK_People

) AS Bar on Bar.FK_People = ta.ID

");
		}
	}
}
