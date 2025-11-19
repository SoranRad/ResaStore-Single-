using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Anbar.Model.Report.PishFrosh
{
	public class PishFoshFactor
	{

		public decimal      meqdar               { get; set; }
		public decimal      nerkh                { get; set; }
		public decimal      nerkh_2              { get; set; }
		public decimal      takhfif              { get; set; }
		public decimal      takhfif_darsad       { get; set; }
		public decimal      mablaq               { get; set; }
		public int          FK_Kala              { get; set; }
		public string       ObjectTitle			 { get; set; }
		public string       UnitTitle			 { get; set; }
		public int			radif				 { get; set; }
		public int			Code				 { get; set; }
		public string		Title				 { get; set; }
		public decimal		PishFrosh			 { get; set; }
		public decimal		Tahvili				 { get; set; }
		public decimal		MandeTahvili		 => this.PishFrosh - this.Tahvili;
		public decimal		MojudiKol			 { get; set; }
		public decimal		Mojudi				 { get; set; }
	}
}
