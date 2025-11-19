using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib;

namespace Nz.Anbar.Model.ViewModel
{
    public class FactorHeads
    {
        public long         ID                  { get; set; }
        public int          Serial              { get; set; }
        public string       PersianStr          { get; set; }
        public string       Customer            { get; set; }
        public decimal      mablaq              { get; set; }
        public string       sharh               { get; set; }
        public byte         Kind                { get; set; }
        public string       KindTitle           => ((Enums.NzFactorKind) this.Kind).NzToString();
    }
}
