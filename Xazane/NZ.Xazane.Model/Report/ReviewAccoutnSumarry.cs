using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib;

namespace NZ.Xazane.Model.Report
{
    public class ReviewAccoutnSumarry
    {
        public long         ID              { get; set; }
        public string       Title           { get; set; }
        public decimal      Mojudi_avalie   { get; set; }
        public byte         Kind            { get; set; }
        public short        Code            { get; set; }
        public decimal      DebitCircular   { get; set; }
        public decimal      CreditCircular  { get; set; }
        public decimal      PayAccount      { get; set; }
        public decimal      ArriveAccount   { get; set; }

        public decimal      Debit           => DebitCircular + ArriveAccount;
        public decimal      Credit          => CreditCircular + PayAccount;
        public decimal      Balance         => Mojudi_avalie + Debit - Credit;

        public string       KindTitle       => ((Enums.NzAccountKind) Kind).NzToString();
    }
}
