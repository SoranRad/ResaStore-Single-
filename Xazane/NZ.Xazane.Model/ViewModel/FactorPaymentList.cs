using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ.Xazane.Model.ViewModel
{
    public class FactorPaymentList
    {
        public long         ID                  { get; set; }
        public int          serial              { get; set; }
        public decimal?     takhfif             { get; set; }
        public string       sharh               { get; set; }
        public byte         PersianMonthNo      { get; set; }
        public byte         PersianDayInMonth   { get; set; }
        public string       PersianStr          { get; set; }
        public string       CustomerTitle       { get; set; }
        public decimal      TotalMount          => Cache + Pos + (Cheque??0) - (takhfif??0);
        public decimal      Cache               { get; set; }
        public decimal      Pos                 { get; set; }
        public decimal?     Cheque              { get; set; }
        public decimal      CountCheque         { get; set; }

        public int          CountPayment        { get; set; }
    }
}
