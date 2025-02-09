using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Anbar.Model.Report
{
    public class CircularSummary
    {
        public int      ID              { get; set; }
        public string   Title           { get; set; }
        public int      code            { get; set; }
        public decimal  Purchase        { get; set; }
        public decimal  SaleBack        { get; set; }
        public decimal  Sale            { get; set; }
        public decimal  PurchaseBack    { get; set; }
    
    }
}
