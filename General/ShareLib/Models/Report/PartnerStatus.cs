using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareLib.Models.Report
{
	public class PartnerStatus
	{
		public decimal		SumFroshKalaAmani		{ get; set; }
		public decimal		SumFroshKalaAdi			{ get; set; }
		public decimal		SumSoodKala				{ get; set; }
		public decimal		MandeKalaAdi			{ get; set; }
		public decimal		MandeKalaAmani			{ get; set; }
	}

	public class HazineHa
	{
		public decimal		SumHazineHa				{ get; set; }
	}

	public class PartnerBardasht
	{
		public long			ID						{ get; set; }
		public int			code					{ get; set; }
		public string		title					{ get; set; }
		public decimal		Balance					{ get; set; }
		public decimal		PartnerPercent			{ get; set; }
		public decimal		MalaqSahm				{ get; set; }
		public decimal		Mande					{ get; set; }
	}

	public class Hazine
	{
		public long			ID			{ get; set; }
		public short		Code		{ get; set; }
		public string		title		{ get; set; }
	}
}
