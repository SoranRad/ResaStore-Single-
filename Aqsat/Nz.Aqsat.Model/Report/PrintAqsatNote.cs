using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Aqsat.Model.Report
{
    public class PrintAqsatNote
    {

	    public long			ID					{ get; set; } 
		public string		ShaxsTitle			{ get; set; }
		public string		ShaxsMobile			{ get; set; }
		public string		ZamenTitle			{ get; set; }
		public string		ZamenMobile			{ get; set; }
		public string		NohTitle			{ get; set; }
		public string		PersianTarixSodur	{ get; set; }
		public string		PersianStartDate	{ get; set; }
		public long			Serial				{ get; set; }
	    public byte			DoreQest			{ get; set; }
	    public decimal		MablaqAqsat			{ get; set; }
	    public decimal		MablaqPishpardaxt	{ get; set; }
	    public decimal		MablaqMandeAqsat	{ get; set; }
	    public decimal		DarsadSoud			{ get; set; }
	    public decimal		MablaqSoud			{ get; set; }
	    public decimal		MablaqFinalAqsat	{ get; set; }
	    public byte			TedadAqsat			{ get; set; }
	    public string		Sharh				{ get; set; }

		public long			Id_Radif			{ get; set; } 
	    public byte			Radif				{ get; set; }
	    public string		PersianTarixQest		{ get; set; }
	    public decimal		mablaqQest			{ get; set; }
	}
}
