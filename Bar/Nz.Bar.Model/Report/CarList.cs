using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Bar.Model.Report
{
	public class CarList
	{
		public short        ID						{ get; set; }
		public short        Code					{ get; set; }
		public long			FK_People				{ get; set; }
		public string       Plak					{ get; set; }
		public string       CarType					{ get; set; }
		public bool			IsDisable				{ get; set; }
		public string		PeopleTitle				{ get; set; }
		public string		DisableTitle			=> this.IsDisable ? "غیرفعال" : "فعال";
	}
}
