using NZ.Anbar.Model;
using ShareLib.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Bar.Model.Report;

namespace Nz.Bar.DataLayer.DapperConfig
{
	public class BarFactorListDapperConfig : DapperEntityConfiguration<BarFactorList>
	{
		public BarFactorListDapperConfig()
		{
			SetList($@"");
		}
	}
}
