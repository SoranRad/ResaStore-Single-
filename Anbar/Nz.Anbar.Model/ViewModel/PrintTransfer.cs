using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Anbar.Model.ViewModel
{
    public class PrintTransfer
    {
        public long         ID                  { get; set; }
        public int          Serial              { get; set; }
        public string       PersianStr          { get; set; }
        public string       sharh               { get; set; }

        public int          radif               { get; set; }
        public int          FK_Kala             { get; set; }
        public decimal      meqdar              { get; set; }
        public string       ObjectTitle         { get; set; }
        public string       UnitTitle           { get; set; }
    }
}
