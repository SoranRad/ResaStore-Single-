using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MS_Control.Tarikh;

namespace Nz.Anbar.Model.Report
{
    public class ProfitSummary
    {
        public int          FK_Kala              { get; set; }
        public DateTime     tarikh               { get; set; }
        public string       ObjectTitle          { get; set; }
        public string       PersianStr           { get; set; }
        public short        PersianMonthNo       { get; set; }
        public string       PersianMonthName     { get; set; }
        public decimal      SaleMount            { get; set; }
        public decimal      SaleCount            { get; set; }
        public decimal      PurchaseMount        { get; set; }
        public decimal      PurchaseCount        { get; set; }

        public decimal      Profit2              { get; set; }

        public decimal      Profit              => this.SaleCount <= 0 || PurchaseCount <= 0
                                                ? 0
                                                : decimal.Round(SaleMount - (SaleCount * (PurchaseMount / PurchaseCount)));

        public string DayName                 => new MS_Structure_Shamsi(this.tarikh).RozOfHafteh();

    }
}
