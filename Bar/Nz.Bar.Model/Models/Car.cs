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
		//public People		People					{ get; set; }


		public string GetItem()
		{
			return $@"
SELECT 
tbb.ID, 
LTRIM(RTRIM(tbb.Title)) AS Title 
FROM Base.tbl_BasteBandi AS tbb
WHERE tbb.ID= @ID
";
		}

		public string GetList()
		{
			return $@"
SELECT 
tbb.ID, 
LTRIM(RTRIM(tbb.Title)) AS Title 
FROM Base.tbl_BasteBandi AS tbb
WHERE tbb.ID= @ID
";
		}

		public string GenerateCode()
		{
			return @"SELECT MAX(tba.Code )
                        FROM Base.tbl_Base_Anbar AS tba";
		}

		public string UniqueCode()
		{
			return @"SELECT COUNT(tba.ID)
                    FROM Base.tbl_Base_Anbar AS tba
                    WHERE tba.Code = @Code";
		}

		public string CircularQuery()
		{
			return @"
SELECT TOP(1) tar.ID  FROM Anbar.tbl_Amaliat_Riz AS tar
WHERE (tar.FK_Anbar_Az=@Code OR tar.FK_Anbar_Be=@Code)
";
		}
	}
}
