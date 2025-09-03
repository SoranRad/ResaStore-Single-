using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib;

namespace Nz.Aqsat.Model.Models
{
	public class Aqsat_Riz
	{
		public Aqsat_Riz()
		{
			AqsatSmsLogs = new HashSet<Aqsat_SmsLog>();
		}
		public long			ID					{ get; set; }
		public long			FK_Main				{ get; set; }
		public byte			Radif				{ get; set; }
		public DateTime		tarixQest			{ get; set; }
		public DateTime		tarixPardaxt		{ get; set; }
		public decimal		mablaqQest			{ get; set; }
		public bool			isPardaxt			{ get; set; }

		[NotMapped]
		public Enums.NzItemState					State				{ get; set; }

		public Aqsat_Main							AqsatMain			{ get; set; }
		public virtual ICollection<Aqsat_SmsLog>	AqsatSmsLogs		{ get; set; }
	}
}
