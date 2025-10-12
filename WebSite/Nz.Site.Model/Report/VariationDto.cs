using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Site.Model.Report
{
	public class VariationDto
	{
		public long?			id						{ get; set; }
		public decimal?			price					{ get; set; }
		public decimal?			sale_price				{ get; set; }
		public string			status					{ get; set; }
		public int?				stock_quantity			{ get; set; }
	}
}
