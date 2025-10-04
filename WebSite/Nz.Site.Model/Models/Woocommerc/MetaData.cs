using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Site.Model.Models.Woocommerc
{
	public class MetaData
	{
		/// <summary>
		/// Meta ID. 
		/// read-only
		/// </summary>
		
		public ulong? id { get; set; }

		/// <summary>
		/// Meta key.
		/// </summary>
		
		public string key { get; set; }

		/// <summary>
		/// Meta value.
		/// </summary>
		private object preValue;
		
		public object value
		{
			get
			{
				return preValue;
			}
			set
			{
				 
					preValue = value;
			}
		}

		/// <summary>
		/// Display key.
		/// </summary>
		
		public string display_key { get; set; }

		/// <summary>
		/// Display value.
		/// </summary>
		private object preDisplayValue;
		
		public object display_value 
		{
			get => preDisplayValue;
			set
			{
				 
					preDisplayValue = value;
			}
		}
	}

}
