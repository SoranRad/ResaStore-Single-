using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Utils;

namespace Nz.Aqsat.Model.Report
{
    public class AqsatMoedGozashteAshxas
    {
	    public long				FK_Shaxs					{ get; set; }
	    public string			Shaxs						{ get; set; }
	    public string			Mobile						{ get; set; }
	    public int				Code						{ get; set; }
	    public int				AqsatCount					{ get; set; }
	    public decimal			SumMablaqQest				{ get; set; }
	    public DateTime			MaxTarixQest				{ get; set; }
	    public DateTime			MinTarixQest				{ get; set; }
	    public string			PersianMaxTarixQest			=> this.MaxTarixQest.ToPersianDate();
	    public string			PersianMinTarixQest			=> this.MinTarixQest.ToPersianDate();

    }
}
