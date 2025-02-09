using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib;

namespace NZ.Xazane.Model.Report
{
    public class PeopleChequeBack
    {
        public long         ID                      { get; set; }
        public long         ID_DP                   { get; set; }
        public string       PersianUsanceStr        { get; set; }
        public string       VaziatPersianStr        { get; set; }
        public string       shomare_check           { get; set; }
        public string       SharhVaziat             { get; set; }
        public string       BankTitle               { get; set; }
        public string       PayAccountTitle         { get; set; }
        public byte         kind                    { get; set; }
        public decimal      mablaq                  { get; set; }


        public decimal      Balance                 => (Enums.NzPaymentOperatingKind) this.kind == Enums.NzPaymentOperatingKind.Daryaft
                                                                ? mablaq
                                                                : -mablaq;
        public string       Account                 => (Enums.NzPaymentOperatingKind)this.kind == Enums.NzPaymentOperatingKind.Daryaft
                                                                ? this.BankTitle
                                                                : this.PayAccountTitle;
        public string       Operation               
        {
            get
            {
                switch ((Enums.NzPaymentOperatingKind)this.kind)
                {
                    case Enums.NzPaymentOperatingKind.Daryaft:
                        return " برگشت چک دریافتی";
                    case Enums.NzPaymentOperatingKind.Pardaxt:
                        return "برگشت چک پرداختی";
                    default:
                        return ((Enums.NzPaymentOperatingKind)this.kind).NzToString();
                }
            }
        }
    }
}
