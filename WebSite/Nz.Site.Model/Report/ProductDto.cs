using ShareLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Utils;

namespace Nz.Site.Model.Report
{
	public class ProductDto
	{
		public ulong?			id						{ get; set; }
		public string			name					{ get; set; }
		public string			type					{ get; set; }
		public string			typeTitle				=> type.NzWebsiteProductTypeToPersian();
		public string			status					{ get; set; }
		public string			statusTitle				=> stock_status.NzWebsiteStockStatusToPersian();
		public decimal?			price					{ get; set; } 
		public int?				stock_quantity			{ get; set; }
		public string			stock_status			{ get; set; } 
		public string			stock_statusTitle		=>stock_status.NzWebsiteStockStatusToPersian();
		public ulong?			VariationId				{ get; set; }
		public string			VariationAttributes		{ get; set; }


		public long?			IdObject				{ get; set; }
		public int?				Code					{ get; set; }
		public decimal?			nerkh_frosh				{ get; set; }
		public decimal?			nerkh_frosh1			{ get; set; }
		public decimal?			nerkh_frosh2			{ get; set; }
		public decimal?			nerkh_frosh3			{ get; set; }
		public string			TitleObject				{ get; set; }
		public string			SubGroupTitle			{ get; set; }
		public decimal?			Remain					{ get; set; }

		public decimal defference => (((decimal?)this.stock_quantity) ?? 0) - (Remain ?? 0);


		public string IdTitle => type == "simple" ? (this.id.ToString()) : (this.id+" - " + this.VariationId);
		public string Title =>  type == "simple" ? name : (this.name+" - " + this.VariationAttributes);
	}
}
