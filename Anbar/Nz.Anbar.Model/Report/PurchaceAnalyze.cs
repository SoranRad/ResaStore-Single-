using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Anbar.Model.Report
{
    public class PurchaceAnalyze
    {
        public long         ID                   { get; set; } 
        public int          FK_Kala              { get; set; }
        public int          radif                { get; set; }
        public decimal      meqdar               { get; set; }
        public decimal      nerkh                { get; set; } 
        public decimal      takhfif              { get; set; }
        public decimal      takhfif_darsad       { get; set; }
        public decimal      mablaq               { get; set; }
        public decimal      Remain               { get; set; }
        public string       CostDescriptor       { get; set; }

        public string       ObjectTitle          { get; set; }
        public string       UnitTitle            { get; set; }

        public decimal      MablaqRemain         => Remain * nerkh;
        public decimal      PercentRemain        => 100 * Remain / meqdar;
        public decimal      PercentSale          => 100 - PercentRemain;

    }
}
