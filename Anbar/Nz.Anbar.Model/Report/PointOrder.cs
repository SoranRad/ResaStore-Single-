using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Anbar.Model.Report
{
    public class PointOrder
    {
        public int          Code                   { get; set; }
        public short        FK_GroupKala_1th       { get; set; }
        public short        FK_GroupKala_2th       { get; set; }
        public string       ObjectTitle            { get; set; }
        public string       MainGroupTitle         { get; set; }
        public string       SubGroupTitle          { get; set; }
        public decimal      Remaind                { get; set; }
        public int          FK_Kala                { get; set; }
        public short        FK_Title               { get; set; }
        public decimal      point_bohrani          { get; set; }

    }
}
