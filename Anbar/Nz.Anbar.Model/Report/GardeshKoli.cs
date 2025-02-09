using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Anbar.Model.Report
{
    public class GardeshKoli
    {
        public int      FK_Kala             { get; set; }
        public int      FK_GroupKala_2th    { get; set; }
        public int      FK_GroupKala_1th    { get; set; }
        public string   ObjectTitle         { get; set; }
        public string   SubGroupTitle       { get; set; }
        public string   MainGroupTitle      { get; set; }
        public decimal  Init                { get; set; }
        public decimal  Purchase            { get; set; }
        public decimal  SaleBack            { get; set; }
        public decimal  Sale                { get; set; }
        public decimal  PurchaseBack        { get; set; }
        public decimal  Transfer            { get; set; }
        public decimal  Usage               { get; set; }
        public int      Count               { get; set; }
        

    }
}
