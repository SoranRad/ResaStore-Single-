using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Anbar.Model.Report.Profit
{
    public class ProfitDaily
    {
        public string       PersianDayOfWeekName    { get; set; }
        public string       PersianStr              { get; set; }
        public DateTime     tarikh                  { get; set; }
        public int          CountFactor             { get; set; }

        public decimal      MountSale               { get; set; }
        public decimal      MountSaleBack           { get; set; }

        public decimal      Profit                  { get; set; }
    }
}
