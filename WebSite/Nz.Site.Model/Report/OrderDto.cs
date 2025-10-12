using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Site.Model.Report
{
	public class OrderDto
	{
		public ulong?		id					{ get; set; }
		public string		number				{ get; set; }
		public string		statusTitle			{ get; set; }
		public string		date_created		{ get; set; }
		public decimal?		discount_total		{ get; set; }
		public decimal?		shipping_total		{ get; set; }
		public decimal?		total				{ get; set; }
		public string		date_paid			{ get; set; }
		public bool?		set_paid			{ get; set; }
		public string		Customer			{ get; set; }
		public string		Address				{ get; set; }
		public long?		FactorId			{ get; set; }
		public string		FactorDate			{ get; set; }
		public int?			Serial				{ get; set; }
	}
}
