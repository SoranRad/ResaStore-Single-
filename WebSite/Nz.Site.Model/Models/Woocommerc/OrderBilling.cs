using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Site.Model.Models.Woocommerc
{
	public class OrderBilling
	{
		/// <summary>
		/// First name.
		/// </summary>
		
		public string first_name { get; set; }

		/// <summary>
		/// Last name.
		/// </summary>
		
		public string last_name { get; set; }

		/// <summary>
		/// Company name.
		/// </summary>
		
		public string company { get; set; }

		/// <summary>
		/// Address line 1
		/// </summary>
		
		public string address_1 { get; set; }

		/// <summary>
		/// Address line 2
		/// </summary>
		
		public string address_2 { get; set; }

		/// <summary>
		/// City name.
		/// </summary>
		
		public string city { get; set; }

		/// <summary>
		/// ISO code or name of the state, province or district.
		/// </summary>
		
		public string state { get; set; }

		/// <summary>
		/// Postal code.
		/// </summary>
		
		public string postcode { get; set; }

		/// <summary>
		/// Country code in ISO 3166-1 alpha-2 format.
		/// </summary>
		
		public string country { get; set; }

		/// <summary>
		/// Email address.
		/// </summary>
		
		public string email { get; set; }

		/// <summary>
		/// Phone number.
		/// </summary>
		
		public string phone { get; set; }
	}
}
