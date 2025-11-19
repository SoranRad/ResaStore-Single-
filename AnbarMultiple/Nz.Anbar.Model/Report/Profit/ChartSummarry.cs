using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib;

namespace Nz.Anbar.Model.Report.Profit
{
    public class ChartSummarry
    {
        public decimal  mablaq          { get; set; }
        public byte     kind            { get; set; }
        public string   KindString      => ((Enums.NzFactorKind)kind).NzToString();
    }


}
