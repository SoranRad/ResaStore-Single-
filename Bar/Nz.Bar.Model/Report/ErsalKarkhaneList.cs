using ShareLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Bar.Model.Report
{
	public class ErsalKarkhaneList  
	{

		public long                         ID						{ get; set; }
		public short                        FK_Salmali				{ get; set; }
		public bool                         is_ok					{ get; set; }

		public short?                       FK_Car					{ get; set; }
		public long                         FK_Karkhane				{ get; set; }

		public int                          Serial					{ get; set; }
		public DateTime                     Tarikh					{ get; set; }
		public int							ShomareGhabz			{ get; set; }
		public string                       Tozihat					{ get; set; }

		public decimal						VaznNaKhales			{ get; set; }
		public decimal						VaznKHali				{ get; set; }
		public decimal						DarsadOft				{ get; set; }
		public decimal						VaznOft					{ get; set; }
		public decimal						VaznKHales				{ get; set; }
		public decimal						Nerkh					{ get; set; }
		public decimal                      Mablaq					{ get; set; }
		public decimal                      MablaqKeraye			{ get; set; }

		public string						CarTitle				{ get; set; }
		public string						KarkhaneTitle			{ get; set; }

		public string						PersianStr				{ get; set; }
		public string						PersianMonthNo			{ get; set; }
		public string						PersianDayInMonth		{ get; set; }

		 
		 
	}
}
