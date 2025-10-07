using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Site.Model.Models.Woocommerc
{
	public class OrderLineItem 
    {
        public ulong?       id                  { get; set; }
        public string       name                { get; set; }
		public ulong?       product_id          { get; set; }
		public ulong?       variation_id        { get; set; }
        public decimal?     quantity            { get; set; }
        public string       tax_class           { get; set; }
        public string       subtotal            { get; set; }
        public string       subtotal_tax        { get; set; }
        public string       total               { get; set; }
        public string       total_tax           { get; set; }
        public string       sku                 { get; set; }
        public decimal      price               { get; set; }
        public List<OrderMeta> meta_data { get; set; }
	

    }

}
