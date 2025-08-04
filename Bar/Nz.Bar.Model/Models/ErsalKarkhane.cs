using ShareLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Bar.Model.Models
{
	public class ErsalKarkhane : ISqlQueryMaker, ICodeEntity
	{

		public long                         ID						{ get; set; }
		public short                        FK_Salmali				{ get; set; }
		public bool                         is_ok					{ get; set; }

		public short?                       FK_Car					{ get; set; }
		public long                         FK_Karkhane				{ get; set; }

		public int                          Serial					{ get; set; }
		public DateTime                     Tarikh					{ get; set; }
		public int							ShomareGhabz			{ get; set; }
		public string                       Tozihat					{ get; set; }

		public decimal						VaznNaKhales			{ get; set; }
		public decimal						VaznKHali				{ get; set; }
		public decimal						DarsadOft				{ get; set; }
		public decimal						VaznOft					{ get; set; }
		public decimal						VaznKHales				{ get; set; }
		public decimal						Nerkh					{ get; set; }
		public decimal                      Mablaq					{ get; set; }
		public decimal                      MablaqKeraye			{ get; set; }


		public Car							Car						{ get; set; } 

		public string GenerateCode()
		{
			return @"SELECT MAX(tek.[Serial]) FROM Bar.tbl_ErsalKarkhane as tek WHERE tek.FK_Salmali = @Year";
		}

		public string GetItem()
		{
			return @"

SELECT 

[tek].[ID],
[tek].[FK_Salmali],
[tek].[is_ok],
[tek].[FK_Car],
[tek].[FK_Karkhane],
[tek].[Serial],
[tek].[Tarikh],
[tek].[ShomareGhabz],
LTRIM(RTRIM([tek].[Tozihat])) AS Tozihat,
[tek].[VaznNaKhales],
[tek].[VaznKHali],
[tek].[DarsadOft],
[tek].[VaznOft],
[tek].[VaznKHales],
[tek].[Nerkh],
[tek].[Mablaq],
[tek].[MablaqKeraye] 

FROM Bar.tbl_ErsalKarkhane as tek
WHERE tek.ID= @ID

";
		}

		public string GetList()
		{
			return @"";
		}

		public string UniqueCode()
		{
			return  @"SELECT COUNT(tek.ID)
                    FROM Bar.tbl_ErsalKarkhane as tek
                    WHERE tek.Serial = @Code";
		}
	}
}
