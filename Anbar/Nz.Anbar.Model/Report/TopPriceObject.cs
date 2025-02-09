using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib;

namespace Nz.Anbar.Model.Report
{
	public  class TopPriceObject
	{
		public decimal		nerkh			{ get; set; }
		public byte			kind			{ get; set; }
		public DateTime		tarikh			{ get; set; }
		public string		PersianStr		{ get; set; }

		public string KindStr => ((Enums.NzFactorKind)this.kind).NzToString();

	}
}
