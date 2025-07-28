using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Bar.Model.Report
{
	public class BillRow
	{
		public long			ID				{ get; set; }
		public string		PersianStr		{ get; set; }
		public int			Serial			{ get; set; }
		public DateTime		Tarikh			{ get; set; }
		public decimal		VaznKHales		{ get; set; }
		public decimal		Nerkh			{ get; set; }
		public decimal		Mablaq			{ get; set; }	
	}
}
