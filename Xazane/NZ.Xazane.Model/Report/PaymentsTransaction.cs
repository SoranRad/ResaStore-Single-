using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib;

namespace NZ.Xazane.Model.Report
{
    public class PaymentsTransaction
    {
        public byte     Kind        { get; set; }
        public decimal  Mablaq      { get; set; }

        public string   KindString  => ((Enums.NzPaymentOperatingKind)Kind).NzToString();
    }
}
