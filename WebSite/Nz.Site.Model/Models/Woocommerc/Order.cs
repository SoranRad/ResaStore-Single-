using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Site.Model.Models.Woocommerc
{
	public class Order 
	{
        public static string Endpoint { get { return "orders"; } }

        /// <summary>
        /// Unique identifier for the resource. 
        /// read-only
        /// </summary>
       
        public ulong? id { get; set; }

        /// <summary>
        /// Parent order ID.
        /// </summary>
       
        public ulong? parent_id { get; set; }

        /// <summary>
        /// Order number. 
        /// read-only
        /// </summary>
       
        public string number { get; set; }

        /// <summary>
        /// Order key. 
        /// read-only
        /// </summary>
       
        public string order_key { get; set; }

        /// <summary>
        /// Shows where the order was created. 
        /// read-only
        /// </summary>
       
        public string created_via { get; set; }

        /// <summary>
        /// Version of WooCommerce which last updated the order. 
        /// read-only
        /// </summary>
       
        public string version { get; set; }

        /// <summary>
        /// Order status. Options: pending, processing, on-hold, completed, cancelled, refunded and failed. Default is pending.
        /// </summary>
       
        public string status { get; set; }

        /// <summary>
        /// Currency the order was created with, in ISO format. Options: AED, AFN, ALL, AMD, ANG, AOA, ARS, AUD, AWG, AZN, BAM, BBD, BDT, BGN, BHD, BIF, BMD, BND, BOB, BRL, BSD, BTC, BTN, BWP, BYR, BZD, CAD, CDF, CHF, CLP, CNY, COP, CRC, CUC, CUP, CVE, CZK, DJF, DKK, DOP, DZD, EGP, ERN, ETB, EUR, FJD, FKP, GBP, GEL, GGP, GHS, GIP, GMD, GNF, GTQ, GYD, HKD, HNL, HRK, HTG, HUF, IDR, ILS, IMP, INR, IQD, IRR, IRT, ISK, JEP, JMD, JOD, JPY, KES, KGS, KHR, KMF, KPW, KRW, KWD, KYD, KZT, LAK, LBP, LKR, LRD, LSL, LYD, MAD, MDL, MGA, MKD, MMK, MNT, MOP, MRO, MUR, MVR, MWK, MXN, MYR, MZN, NAD, NGN, NIO, NOK, NPR, NZD, OMR, PAB, PEN, PGK, PHP, PKR, PLN, PRB, PYG, QAR, RON, RSD, RUB, RWF, SAR, SBD, SCR, SDG, SEK, SGD, SHP, SLL, SOS, SRD, SSP, STD, SYP, SZL, THB, TJS, TMT, TND, TOP, TRY, TTD, TWD, TZS, UAH, UGX, USD, UYU, UZS, VEF, VND, VUV, WST, XAF, XCD, XOF, XPF, YER, ZAR and ZMW. Default is USD.
        /// </summary>
       
        public string currency { get; set; }

        /// <summary>
        /// The date the order was created, in the site’s timezone. 
        /// read-only
        /// </summary>
       
        public DateTime? date_created { get; set; }

        /// <summary>
        /// The date the order was created, as GMT. 
        /// read-only
        /// </summary>
       
        public DateTime? date_created_gmt { get; set; }

        /// <summary>
        /// The date the order was last modified, in the site’s timezone. 
        /// read-only
        /// </summary>
       
        public DateTime? date_modified { get; set; }

        /// <summary>
        /// The date the order was last modified, as GMT. 
        /// read-only
        /// </summary>
       
        public DateTime? date_modified_gmt { get; set; }

        /// <summary>
        /// Total discount amount for the order. 
        /// read-only
        /// </summary>
       
        public string discount_total { get; set; }

        /// <summary>
        /// Total discount tax amount for the order. 
        /// read-only
        /// </summary>
       
        public string discount_tax { get; set; }

        /// <summary>
        /// Total shipping amount for the order. 
        /// read-only
        /// </summary>
       
        public string shipping_total { get; set; }

        /// <summary>
        /// Total shipping tax amount for the order. 
        /// read-only
        /// </summary>
       
        public string shipping_tax { get; set; }

        /// <summary>
        /// Sum of line item taxes only. 
        /// read-only
        /// </summary>
       
        public string cart_tax { get; set; }
 
        /// <summary>
        /// Grand total. 
        /// read-only
        /// </summary>
        public string total { get; set; }
 
        /// <summary>
        /// Sum of all taxes. 
        /// read-only
        /// </summary>
        public string total_tax { get; set; }

        /// <summary>
        /// True the prices included tax during checkout. 
        /// read-only
        /// </summary>
       
        public bool? prices_include_tax { get; set; }

        /// <summary>
        /// User ID who owns the order. 0 for guests. Default is 0.
        /// </summary>
       
        public ulong? customer_id { get; set; }

        /// <summary>
        /// Customer’s IP address. 
        /// read-only
        /// </summary>
       
        public string customer_ip_address { get; set; }

        /// <summary>
        /// User agent of the customer. 
        /// read-only
        /// </summary>
       
        public string customer_user_agent { get; set; }

        /// <summary>
        /// Note left by customer during checkout.
        /// </summary>
       
        public string customer_note { get; set; }

        /// <summary>
        /// Billing address. See Order - Billing properties
        /// </summary>
       
        public OrderBilling billing { get; set; }

        /// <summary>
        /// Shipping address. See Order - Shipping properties
        /// </summary>
       
        public OrderShipping shipping { get; set; }

        /// <summary>
        /// Payment method ID.
        /// </summary>
       
        public string payment_method { get; set; }

        /// <summary>
        /// Payment method title.
        /// </summary>
       
        public string payment_method_title { get; set; }

        /// <summary>
        /// Unique transaction ID.
        /// </summary>
       
        public string transaction_id { get; set; }

        /// <summary>
        /// The date the order was paid, in the site’s timezone. 
        /// read-only
        /// </summary>
       
        public DateTime? date_paid { get; set; }

        /// <summary>
        /// The date the order was paid, as GMT. 
        /// read-only
        /// </summary>
       
        public DateTime? date_paid_gmt { get; set; }

        /// <summary>
        /// The date the order was completed, in the site’s timezone. 
        /// read-only
        /// </summary>
       
        public DateTime? date_completed { get; set; }

        /// <summary>
        /// The date the order was completed, as GMT. 
        /// read-only
        /// </summary>
       
        public DateTime? date_completed_gmt { get; set; }

        /// <summary>
        /// MD5 hash of cart items to ensure orders are not modified. 
        /// read-only
        /// </summary>
       
        public string cart_hash { get; set; }

        /// <summary>
        /// Meta data. See Order - Meta data properties
        /// </summary>
       
        public List<OrderMeta> meta_data { get; set; }

        /// <summary>
        /// Line items data. See Order - Line items properties
        /// </summary>
       
        public List<OrderLineItem> line_items { get; set; }

        /// <summary>
        /// Tax lines data. See Order - Tax lines properties 
        /// read-only
        /// </summary>
       
        //public List<OrderTaxLine> tax_lines { get; set; }

        /// <summary>
        /// Shipping lines data. See Order - Shipping lines properties
        /// </summary>
       
        //public List<OrderShippingLine> shipping_lines { get; set; }

        /// <summary>
        /// Fee lines data. See Order - Fee lines properties
        /// </summary>
       
        //public List<OrderFeeLine> fee_lines { get; set; }

        /// <summary>
        /// Coupons line data. See Order - Coupon lines properties
        /// </summary>
       
        //public List<OrderCouponLine> coupon_lines { get; set; }

        /// <summary>
        /// List of refunds. See Order - Refunds properties 
        /// read-only
        /// </summary>
       
        //public List<OrderRefundLine> refunds { get; set; }

        /// <summary>
        /// Define if the order is paid. It will set the status to processing and reduce stock items. Default is false. 
        /// write-only
        /// </summary>
       
        public bool? set_paid { get; set; }
    }
}
