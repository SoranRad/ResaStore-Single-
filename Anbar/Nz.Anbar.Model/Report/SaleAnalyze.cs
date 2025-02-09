using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib;

namespace Nz.Anbar.Model.Report
{
    public class SaleAnalyze
    {
        private decimal     _nerkh_2;

        public string       PersianStr              { get; set; }
        public byte         KindHead                { get; set; }

        public int          Code                    { get; set; }

        public string       ObjectTitle             { get; set; }
        public string       UnitTitle               { get; set; }

        public decimal      meqdar                  { get; set; }
        public decimal      nerkh                   { get; set; }

        public decimal nerkh_2
        {
            get => ((Enums.NzFactorKind)this.KindHead) == Enums.NzFactorKind.Frosh
                    ? _nerkh_2
                    : _nerkh_2 * meqdar;
            set => _nerkh_2 = value;
        }

        public decimal      nerkh_3                 => meqdar != 0 ? nerkh_2 / meqdar : 0;

        public decimal      takhfif                 { get; set; }
        public decimal      takhfif_darsad          { get; set; }
        public decimal      mablaq                  { get; set; }
        public decimal      Ezafat                  { get; set; }
        public decimal      Takhfif_Kol             { get; set; }
        public string       CostDescriptor          { get; set; }


        public long         IDItem                  { get; set; }
        public long         IDHead                  { get; set; }
        public int          radif                   { get; set; }
        public int          Serial                  { get; set; }
        public string       LocationTitle           { get; set; }
        public decimal      Profit                  => mablaq - nerkh_2;

         
        public string       sharh                   { get; set; } 
        public string       People                  { get; set; }

        public string       KindHeadTitle           => ((Enums.NzFactorKind) this.KindHead).NzToString();
    }
}
