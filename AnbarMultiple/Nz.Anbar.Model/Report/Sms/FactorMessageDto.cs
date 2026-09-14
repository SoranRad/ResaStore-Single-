using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Anbar.Model.Report.Sms
{
	public class FactorMessageDto
	{
		public long			ID						{ get; set; }
		public int			Serial					{ get; set; }
		public string		Customer				{ get; set; }
		public string		Mobile					{ get; set; }
		public string		Date					{ get; set; }
		public string		Tasvieh					{ get; set; }
		public decimal		Price					{ get; set; }
	}
}
