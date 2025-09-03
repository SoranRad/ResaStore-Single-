using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Aqsat.Model.Models
{
	public class Aqsat_SmsLog
	{
		public long				ID				{ get; set; }
		public long				FK_Riz			{ get; set; }
		public DateTime			Tarikh			{ get; set; }
		public bool				IsSuccess		{ get; set; }


		public Aqsat_Riz		AqsatRiz		{ get; set; }
	}
}
