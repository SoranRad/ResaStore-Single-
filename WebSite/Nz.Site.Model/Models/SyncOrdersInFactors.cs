using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Site.Model.Models
{
	public class SyncOrdersInFactors
	{
		public long			ID			{ get; set; }
		public int			Serial		{ get; set; }
		public DateTime		tarikh		{ get; set; }
		public long?		WebSiteId	{ get; set; }
	}
}
