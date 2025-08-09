using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ.Xazane.Model.Report
{
	public class BillRow
	{
		public long		ID						{ get; set; }
		public string	Title					{ get; set; }
		public decimal	mablaq					{ get; set; }
		public byte		kind					{ get; set; }
		public string	Sharh					{ get; set; }
		public string	serialPeygiri			{ get; set; }
		public string	PersianStr				{ get; set; }
		public string	Hesab					{ get; set; }
		public int?		Serial					{ get; set; }

	}
}
