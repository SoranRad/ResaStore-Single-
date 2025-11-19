using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib;

namespace Nz.Anbar.Model.Report.PishFrosh
{
	public class FactorVaHavalePishFroshYekShaxs
	{
		public long				ID				{ get; set; }
		public int				Serial			{ get; set; }
		public string			PersianStr		{ get; set; }
		public byte				kind			{ get; set; }
		public decimal			mablaq			{ get; set; }
		public string			sharh			{ get; set; }
		public string			KindStr			=> ((Enums.NzFactorKind)kind).NzToString();
	}
}
