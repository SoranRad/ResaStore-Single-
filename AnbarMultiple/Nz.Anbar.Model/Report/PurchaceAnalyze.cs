using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Anbar.Model.Report
{
    public class PurchaceAnalyze
    {
	    public int		radif				{ get; set; }	
	    public long		FK_Title			{ get; set; }
	    public int		FK_Kala				{ get; set; }
	    public decimal	meqdar				{ get; set; }
	    public decimal	nerkh				{ get; set; }
	    public decimal	mablaq				{ get; set; }
	    public decimal	Remain				{ get; set; }
	    public decimal	RemainMablaq		{ get; set; }

	    public string	ObjectTitle			{ get; set; }
	    public string	UnitTitle			{ get; set; }

	    public decimal	MeqdarFrosh			{ get; set; }
	    public decimal	MablaqFrosh			{ get; set; }
	    public decimal	MablaqSoud			{ get; set; }
	    public decimal	OutMablaq			=> Remain * nerkh;


		public decimal	PercentRemain		=> 100 * Remain / meqdar;
	    public decimal	PercentSale			=> 100 - PercentRemain;
	}
}
