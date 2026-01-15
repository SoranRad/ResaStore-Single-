using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Aqsat.Model.Report
{
    public class AqsatList 
    {
	    public long			ID						{ get; set; }
		public long			Serial					{ get; set; }
		public string		PersianStr				{ get; set; }
		public string		Shaxs					{ get; set; }
		public string		Mobile					{ get; set; }
		public int			code					{ get; set; }
		public string		codeMeli				{ get; set; }
		public string		KindTitle				{ get; set; }
		public string		StartPersianDate		{ get; set; }
		public string		ZamenTitle				{ get; set; }
		public string		ZamenMobile				{ get; set; }
		public string		Sharh					{ get; set; }

		public byte			TedadAqsat				{ get; set; }
		public byte			TedadPardaxti			{ get; set; }
		public int			TedadMande				=> TedadAqsat - TedadPardaxti;

		public decimal		MablaqFinalAqsat		{ get; set; }
		public decimal		MablaqPardaxti			{ get; set; }
		public decimal		MablaqMande				=> MablaqFinalAqsat - MablaqPardaxti ;
    }
}
