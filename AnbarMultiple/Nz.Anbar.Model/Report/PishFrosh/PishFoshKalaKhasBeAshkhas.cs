using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Anbar.Model.Report.PishFrosh
{
	public  class PishFoshKalaKhasBeAshkhas
	{
		public long			ID					{ get; set; } 
		public string		title				{ get; set; }
		public string		Mobile				{ get; set; }
		public string		CodeMelli			{ get; set; }
		public decimal		MeqdarPishFrosh		{ get; set; }
		public decimal		TedadFactor			{ get; set; }
		public decimal		MeqdarTahvili		{ get; set; }
		public decimal		TedadHavale			{ get; set; }

		public decimal Mande => MeqdarPishFrosh - MeqdarTahvili;

	}
}
