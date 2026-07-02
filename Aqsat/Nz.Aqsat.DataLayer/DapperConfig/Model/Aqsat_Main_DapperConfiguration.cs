using Nz.Aqsat.Model.Models;
using ShareLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Aqsat.DataLayer.DapperConfig.Model
{
	public class Aqsat_Main_DapperConfiguration :DapperEntityConfiguration<Aqsat_Main>
	{
		public Aqsat_Main_DapperConfiguration()
		{
			SetMaxSerial(@"
SELECT MAX(Serial) from Aqsat.tbl_Aqsat_Main 
");

			SetCodeUnique(@"
SELECT Count(ID) from Aqsat.tbl_Aqsat_Main AS tam WHERE tam.Serial = @Serial AND tam.FK_Salmali =@Year
");
		}
	}
}
