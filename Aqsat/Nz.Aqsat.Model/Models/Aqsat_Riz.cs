using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Aqsat.Model.Models
{
	public class Aqsat_Riz
	{
		public long			ID					{ get; set; }
		public long			FK_Main				{ get; set; }
		public byte			Radif				{ get; set; }
		public DateTime		tarixQest			{ get; set; }
		public DateTime		tarixPardaxt		{ get; set; }
		public decimal		mablaqQest			{ get; set; }
		public bool			isPardaxt			{ get; set; }

		public Aqsat_Main	AqsatMain			{ get; set; }
	}
}
