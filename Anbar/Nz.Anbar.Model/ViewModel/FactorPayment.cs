using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Anbar.Model.ViewModel
{
    public class FactorPayment
    {
        public decimal      Cache           { get; set; }
        public decimal      POS             { get; set; }
        public decimal      Cheque          { get; set; }
        public int          ChequeCount     { get; set; }
    }
}
