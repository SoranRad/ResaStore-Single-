using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib;

namespace Nz.Anbar.Model.Report
{
    public class CircularObject
    {
        public long         ID              { get; set; }
        public long         IDTitle         { get; set; }
        public DateTime     tarikh          { get; set; }
        public string       PersianStr      { get; set; }
        public int          Serial          { get; set; }
        public byte         kind            { get; set; }

        public decimal      nerkh           { get; set; }
        public decimal      meqdar          { get; set; }
        public decimal      mablaq          { get; set; }

        public string       CustomerTitle   { get; set; }
        public string       UnitTitle       { get; set; }
        public int          radif           { get; set; }
        public string       LocationTitle   { get; set; }

        public string       KindTitle       => ((Enums.NzFactorKind) this.kind).NzToString();
    }
}
