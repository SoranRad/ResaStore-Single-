using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareLib.ViewModel
{
    public class CircularRowItem
    {
        public byte         SubSystem       { get; set; }
        public long         ID              { get; set; }
        public long         Serial          { get; set; }
        public string       PersianStr      { get; set; }
        public DateTime     Date            { get; set; }
        public byte         Kind            { get; set; }
        public string       Description     { get; set; }
        public string       Title           { get; set; }
        public decimal      Debit           { get; set; }
        public decimal      Credit          { get; set; }
        public decimal      Remaind         { get; set; }
        public string       RemaindTitle    => this.Remaind > 0 ? "بدهکار" : "بستانکار";
    }
}
