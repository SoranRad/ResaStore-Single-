using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Bar.Model.Report
{
	public class BarFactorList
	{
		public long                         ID						{ get; set; }
		public short                        FK_Salmali				{ get; set; }
		public byte                         kind					{ get; set; }
		public bool                         is_ok					{ get; set; }


		public short?                       FK_Car					{ get; set; }
		public long                         FK_People				{ get; set; }
		public int							FK_Kala					{ get; set; }
		public int                          Serial					{ get; set; }
		public DateTime                     Tarikh					{ get; set; }
		public string                       Tozihat					{ get; set; }

		 
		public decimal						VaznPorMachine			{ get; set; }
		public decimal						VaznKHaliMachine		{ get; set; }
		public decimal						TedadBox				{ get; set; }
		public decimal						VaznKhaliBox			{ get; set; }
		public decimal						SumKhaliBox				{ get; set; }
		
		public decimal						DarsadOft				{ get; set; }
		public decimal						VaznOft					{ get; set; }
		public decimal						VaznKHales				{ get; set; }
		public decimal						Nerkh					{ get; set; }
		public decimal                      Mablaq					{ get; set; }
		public decimal                      MablaqKeraye			{ get; set; }

		public string						PersianStr				{ get; set; }
		public string						PersianMonthNo			{ get; set; }
		public string						PersianDayInMonth		{ get; set; }

		public short                        FK_User_Add				{ get; set; }
		public short?                       FK_User_Edit			{ get; set; } 
		public DateTime                     Tarikh_add				{ get; set; }
		public DateTime?                    Tarikh_edit				{ get; set; }


		public string						CarTitle				{ get; set; }
		public string						PeopleTitle				{ get; set; }
		public string						KalaTitle				{ get; set; }
		public string						UserAddTitle			{ get; set; }
		public string						UserEditTitle			{ get; set; }

	}
}
