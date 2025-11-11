using ShareLib.Interfaces;
using System.Collections.Generic;

namespace Nz.Aqsat.Model.Models
{
	public  class Aqsat_Kind : ISqlQueryMaker,ICodeEntity,IEntityUsage
	{
		public Aqsat_Kind()
		{
			AqsatMains = new HashSet<Aqsat_Main>();
		}

		public short		ID				{ get; set; }
		public short		Code			{ get; set; }
		public string		Title			{ get; set; }


		public virtual ICollection<Aqsat_Main> AqsatMains { get; set; }

		public string GetItem()
		{
			return " ";
		}

		public string GetList()
		{
			return " ";
		}

		public string GenerateCode()
		{
			return " ";
		}

		public string UniqueCode()
		{
			return " ";
		}

		public string CircularQuery()
		{
			return " ";
		}
	}
}
