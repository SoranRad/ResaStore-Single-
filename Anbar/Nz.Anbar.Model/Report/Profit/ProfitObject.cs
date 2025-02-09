using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Anbar.Model.Report.Profit
{
    public class ProfitObject
    {
        public int          Code                { get; set; }
        public string       Title               { get; set; }
        public string       UnitTitle           { get; set; }

        public decimal      CountSale           { get; set; }
        public decimal      CountSaleBack       { get; set; }

        public decimal      MountSale           { get; set; }
        public decimal      MountSaleBack       { get; set; }

        public decimal      TotalCount          => CountSale - CountSaleBack;

        public decimal      Profit              { get; set; }

    }
}
