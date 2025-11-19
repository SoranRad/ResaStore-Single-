using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Anbar.Model.Report.PishFrosh
{
	public class PishFoshKala
	{
		public int		Code			{ get; set; }
		public string	Title			{ get; set; }
		public decimal	PishFrosh		{ get; set; }
		public decimal	Tahvili			{ get; set; }
		public decimal	MandeTahvili	=> this.PishFrosh - this.Tahvili;
		public decimal	FroshXales		{ get; set; }
		public decimal	MojudiKol		{ get; set; }
		public decimal	Frosh			{ get; set; }
		public decimal	Mojudi			{ get; set; }
	}
}
