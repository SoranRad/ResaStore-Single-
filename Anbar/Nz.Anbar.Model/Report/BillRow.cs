using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib;

namespace Nz.Anbar.Model.Report
{
	public  class BillRow
	{
		public long				Id					{ get; set; }
		public string			ObjectTitle			{ get; set; }
		public decimal			meqdar				{ get; set; }
		public decimal			nerkh				{ get; set; }
		public decimal			mablaq				{ get; set; }
		public string			PersianStr			{ get; set; }
		public DateTime			tarikh				{ get; set; }
		public int				Serial				{ get; set; }
		public byte				kind				{ get; set; }

		public string			KindTitle			=> ((Enums.NzFactorKind)this.kind).NzToString();


	}
}
