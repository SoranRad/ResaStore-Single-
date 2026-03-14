using Nz.Aqsat.Model.Report;
using ShareLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Aqsat.DataLayer.DapperConfig.Report
{
	public class AqsatHeadCountConfig : DapperEntityConfiguration<AqsatHeadCount>
	{
		public AqsatHeadCountConfig()
		{
			this.SetItem(@"SELECT COUNT(ID) AS ItemsCount FROM Aqsat.tbl_Aqsat_Main");
		}

		 
	}
}
