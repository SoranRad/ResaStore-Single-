using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Site.Model.Models
{
	public class SyncObjectsInProducts
	{
		public long         ID						 { get; set; }
		public int          Code					 { get; set; }
		public decimal      nerkh_frosh				 { get; set; }
		public decimal?     nerkh_frosh1			 { get; set; }
		public decimal?     nerkh_frosh2			 { get; set; }
		public decimal?     nerkh_frosh3			 { get; set; }
		public string       ObjectTitle				 { get; set; }
		public string       SubGroupTitle			 { get; set; }

		public string       WebSiteProductKind       { get; set; }
		public long?        WebSiteProductId1        { get; set; }
		public long?        WebSiteProductId2        { get; set; }
		public decimal?		Remain					 { get; set; }

	}
}
