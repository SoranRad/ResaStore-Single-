using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib;

namespace NZ.Xazane.Model.Report
{
    public class UsentCheque
    {
        public long         ID                      { get; set; }
        public byte         kind                    { get; set; }
        public decimal      mablaq                  { get; set; }
        public string       PersianStr              { get; set; }
        public int          serial                  { get; set; }
        public long         ID_DP                   { get; set; }
        public string       PersianUsanceStr        { get; set; }
        public string       shomare_check           { get; set; }
        public string       babat                   { get; set; }
        public string       CustomerTitle           { get; set; }
        public string       BankTitle               { get; set; }
        public string       PayAccountTitle         { get; set; }
        public DateTime     tarikh_sar_resid        { get; set; }

        public string       AccountAction           => 
            (Enums.NzPaymentOperatingKind)kind == Enums.NzPaymentOperatingKind.Daryaft
                    ? BankTitle
                    : PayAccountTitle;
        public string Title =>
            (Enums.NzPaymentOperatingKind)kind == Enums.NzPaymentOperatingKind.Daryaft
                ? "دریافت چـک"
                : "پرداخت چـک";
    }
}
