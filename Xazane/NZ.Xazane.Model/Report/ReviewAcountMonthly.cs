using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib;

namespace NZ.Xazane.Model.Report
{
    public class ReviewAcountMonthly
    {

        public long     ID              { get; set; }
        public string   Title           { get; set; }
        public decimal  mojudi_avalie   { get; set; }
        public byte     Kind            { get; set; }
        public short    Code            { get; set; }

        public decimal  Farvardin       { get; set; }
        public decimal  Ordibehesht     { get; set; }
        public decimal  Xordad          { get; set; }
        public decimal  Tir             { get; set; }
        public decimal  Mordad          { get; set; }
        public decimal  Shahrivar       { get; set; }
        public decimal  Mehr            { get; set; }
        public decimal  Aban            { get; set; }
        public decimal  Azar            { get; set; }
        public decimal  Dey             { get; set; }
        public decimal  Bahman          { get; set; }
        public decimal  Esfand          { get; set; }

        public decimal  Balance         =>
                                        mojudi_avalie +
                                        Farvardin + Ordibehesht + Xordad +
                                        Tir + Mordad + Shahrivar +
                                        Mehr + Aban + Azar +
                                        Dey + Bahman + Esfand;

        public string   KindTitle       => ((Enums.NzAccountKind)Kind).NzToString();

    }
}
