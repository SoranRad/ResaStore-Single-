using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ.Xazane.Model.ViewModel
{
    public class DeficitAdditionList
    {
        public long             ID                  { get; set; }
        public int              serial              { get; set; }
        public string           sharh               { get; set; }
        public decimal          mablaq              { get; set; }
        public byte             PersianMonthNo      { get; set; }
        public byte             PersianDayInMonth   { get; set; }
        public string           PersianStr          { get; set; }
        public string           DebitTitle          { get; set; }
        public string           CreditTitle         { get; set; }
        public string           CustomerTitle       { get; set; }
    }
}
