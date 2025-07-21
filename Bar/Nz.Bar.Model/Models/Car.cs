using NZ.Anbar.Model;
using ShareLib.Interfaces;
using ShareLib.Models;
using System.Collections.Generic;

namespace Nz.Bar.Model.Models
{
	public class Car : ISqlQueryMaker, ICodeEntity, IEntityUsage
	{
		public Car()
		{
			BarFactors         = new HashSet<BarFactor>();
		}
		public short        ID						{ get; set; }
		public short        Code					{ get; set; }
		public long			FK_People				{ get; set; }
		public string       Plak					{ get; set; }
		public string       CarType					{ get; set; }
		public bool			IsDisable				{ get; set; }

		public virtual ICollection<BarFactor>      BarFactors         { get; set; }


		public string GetItem()
		{
			return $@"
SELECT    

 tc.[ID],
 tc.[Code],
 tc.[FK_People],
 LTRIM(RTRIM(tc.[Plak])) AS Plak,
 LTRIM(RTRIM(tc.[CarType])) AS CarType,
 tc.[IsDisable]    
  
FROM [Bar].[tbl_Car] as tc
WHERE tc.ID= @ID
";
		}

		public string GetList()
		{
			return $@"";
		}

		public string GenerateCode()
		{
			return @"SELECT MAX(tc.[Code]) FROM [Bar].[tbl_Car] as tc";
		}

		public string UniqueCode()
		{
			return @"SELECT COUNT(tc.ID)  FROM [Bar].[tbl_Car] as tc
                    WHERE tc.Code = @Code";
		}

		public string CircularQuery()
		{
			return @"
SELECT TOP(1) tbf.ID  FROM Bar.tbl_BarFactor as tbf 
WHERE tbf.FK_Car = @Code
";
		}
	}
}
