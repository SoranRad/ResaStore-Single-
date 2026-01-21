using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Aqsat.Model.Report
{
    public class SarResidAqsatHafte
    {
	    public string			PersianDayOfWeekName	{ get; set; }
	    public long				FK_Main					{ get; set; }
	    public long				ID						{ get; set; }
	    public long				Serial					{ get; set; }
	    public string			Shaxs					{ get; set; }
	    public string			Mobile					{ get; set; }
	    public string			ZamenTitle				{ get; set; }
	    public string			ZamenMobile				{ get; set; }
	    public string			KindTitle				{ get; set; }
	    public string			TarixSodur				{ get; set; }
	    public string			TarixSarResid			{ get; set; }
	    public decimal			mablaqQest				{ get; set; }
	    public byte				Radif					{ get; set; }
	    public int				DayRemaind				{ get; set; }
	}
}
