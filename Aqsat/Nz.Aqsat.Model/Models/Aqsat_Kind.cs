using ShareLib.Interfaces;
using System.Collections.Generic;

namespace Nz.Aqsat.Model.Models
{
	public  class Aqsat_Kind : ISqlQueryMaker,IEntityUsage
	{
		public Aqsat_Kind()
		{
			AqsatMains = new HashSet<Aqsat_Main>();
		}

		public short		ID				{ get; set; } 
		public string		Title			{ get; set; }


		public virtual ICollection<Aqsat_Main> AqsatMains { get; set; }

		public string GetItem()
		{
			return @"
SELECT 
[ID], 
LTRIM(RTRIM(title)) AS title 
FROM Aqsat.tbl_Aqsat_Kind
WHERE ID = @Id
";
		}

		public string GetList()
		{
			return @"
SELECT 
[ID], 
LTRIM(RTRIM(title)) AS title 
FROM Aqsat.tbl_Aqsat_Kind
";
		}

		public string CircularQuery()
		{
			return @"
SELECT Top(1)ID FROM Aqsat.tbl_Aqsat_Main
WHERE FK_Noh = @Id
";
		}
	}
}
