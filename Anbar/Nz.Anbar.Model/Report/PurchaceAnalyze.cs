using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Anbar.Model.Report
{
    public class PurchaceAnalyze
    {
        public long         FK_Title             { get; set; } 
        public int          FK_Kala              { get; set; }
        public decimal      meqdar               { get; set; }
        public decimal      mablaq               { get; set; }
        public decimal      Remain               { get; set; }
        public decimal      RemainMablaq         { get; set; }

        public string       ObjectTitle          { get; set; }
        public string       UnitTitle            { get; set; }

        public decimal      MablaqFrosh          { get; set; }
        public decimal      MeqdarFrosh          { get; set; }
        public decimal      MeqdarBargash        { get; set; }
        public decimal      MablaqBargash        { get; set; }


        public decimal?     Cheque               { get; set; }
        public decimal?     Cache                { get; set; }
        public decimal?     Pos                  { get; set; }
        public decimal      PaymentSum          => (Cheque ?? 0) + (Cache ?? 0) + (Pos ?? 0);

        public decimal      MandeTasvieh        => MablaqFrosh - (Cheque ?? 0) - (Cache ?? 0) - (Pos ?? 0);

	}
}
