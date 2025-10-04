using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Site.Model.Models.Woocommerc
{
	public class OrderLineItem 
    {
        /// <summary>
        /// Item ID. 
        /// read-only
        /// </summary>
        
        public ulong? id { get; set; }

        /// <summary>
        /// Product name.
        /// </summary>
        
        public string name { get; set; }

        /// <summary>
        /// Product ID.
        /// </summary>
        
        public ulong? product_id { get; set; }

        /// <summary>
        /// Variation ID, if applicable.
        /// </summary>
        
        public ulong? variation_id { get; set; }

        /// <summary>
        /// Quantity ordered.
        /// </summary>
        
        public decimal? quantity { get; set; }

        /// <summary>
        /// Tax class of product.
        /// </summary>
        
        public string tax_class { get; set; }


        
        /// <summary>
        /// Line subtotal (before discounts).
        /// </summary>
        public string subtotal { get; set; }

        
        /// <summary>
        /// Line subtotal tax (before discounts). 
        /// read-only
        /// </summary>
        public string subtotal_tax { get; set; }

        
        /// <summary>
        /// Line total (after discounts).
        /// </summary>
        public string total { get; set; }

        
        /// <summary>
        /// Line total tax (after discounts). 
        /// read-only
        /// </summary>
        public string total_tax { get; set; }

        /// <summary>
        /// Line taxes. See Order - Taxes properties 
        /// read-only
        /// </summary>
        
        //public List<TaxItem> taxes { get; set; }

        /// <summary>
        /// Meta data. See Order - Meta data properties
        /// </summary>
        
        public List<OrderMeta> meta_data { get; set; }

        /// <summary>
        /// Product SKU. 
        /// read-only
        /// </summary>
        
        public string sku { get; set; }

        /// <summary>
        /// Product price. 
        /// read-only
        /// </summary>
        
        public decimal price { get; set; }

    }

}
