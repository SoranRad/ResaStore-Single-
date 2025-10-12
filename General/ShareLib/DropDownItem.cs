using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareLib
{
	public class DropDownItem
	{
		public object Value { get; set; }
		public string Text { get; set; }

		public override string ToString()
		{
			return Text;
		}
	}
}
