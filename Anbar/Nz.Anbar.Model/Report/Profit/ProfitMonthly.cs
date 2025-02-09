using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Anbar.Model.Report.Profit
{
    public class ProfitMonthly
    {
        public int      PersianMonthNo      { get; set; }
        public string   PersianMonthName    { get; set; }

        public int      CountFactor         { get; set; }

        public decimal  MountSale           { get; set; }
        public decimal  MountSaleBack       { get; set; }

        public decimal  Profit              { get; set; }
    }
}
