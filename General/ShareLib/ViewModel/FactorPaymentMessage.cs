using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareLib.ViewModel
{
    public class FactorPaymentMessage
    {
        public long                 IDFactor        { get; set; }
        public long                 IDPeople        { get; set; }
        public string               Description     { get; set; }
        public Enums.NzPaymentOperatingKind Kind    { get; set; }
        public decimal              Amount          { get; set; }
    }
}
