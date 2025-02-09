using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareLib.Models
{
    public class BillRowItem
    {
        #region Methods

        public byte     Subsystem       { get; set; }
        public byte     Kind            { get; set; }
        public string   SubsystemTitle  { get; set; }
        public string   KindTitle       { get; set; }
        public int?     Code            { get; set; }
        public string   Title           { get; set; }
        public decimal  Count           { get; set; }
        public decimal  Debit           { get; set; }
        public decimal  Credit          { get; set; }

        #endregion
    }
}
