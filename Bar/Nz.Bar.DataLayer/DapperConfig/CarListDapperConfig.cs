using Nz.Bar.Model.Report;
using ShareLib.Interfaces;

namespace Nz.Bar.DataLayer.DapperConfig
{
	public class CarListDapperConfig :  DapperEntityConfiguration<CarList>
	{
		public CarListDapperConfig()
		{
			SetList(@"

SELECT    

 tc.[ID],
 tc.[Code],
 tc.[FK_People],
 LTRIM(RTRIM(tc.[Plak])) AS Plak,
 LTRIM(RTRIM(tc.[CarType])) AS CarType,
 tc.[IsDisable] ,  
 LTRIM(RTRIM(ta.title)) AS PeopleTitle

FROM [Bar].[tbl_Car] as tc
INNER JOIN Base.tbl_Ashxas AS ta on tc.FK_People = ta.ID

			");
		}
	}
}
