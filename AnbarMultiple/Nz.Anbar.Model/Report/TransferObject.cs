using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib;

namespace Nz.Anbar.Model.Report
{
    public class TransferObject
    {
        public string       PersianStr              { get; set; }
        public byte         KindHead                { get; set; }

        public int          Code                    { get; set; }

        public string       ObjectTitle             { get; set; }
        public string       UnitTitle               { get; set; }
         
        public decimal      nerkh                   { get; set; }
        public decimal      mablaq                  => Remain * nerkh;
        public decimal      Remain                  { get; set; }

        public long         IDItem                  { get; set; }
        public long         IDHead                  { get; set; }
        public int          radif                   { get; set; }
        public int          Serial                  { get; set; }


        public DateTime     tarikh                  { get; set; }
        public string       sharh                   { get; set; }
        public string       People                  { get; set; }

        public string       KindHeadTitle           => ((Enums.NzFactorKind) this.KindHead).NzToString();
    }
}
