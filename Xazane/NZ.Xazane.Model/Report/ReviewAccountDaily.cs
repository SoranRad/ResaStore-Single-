using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ.Xazane.Model.Report
{
    public class ReviewAccountDaily 
    {
        public long         ID                  { get; set; }
        public string       title               { get; set; }
        public decimal      mojudi_avalie       { get; set; }
        public byte         Kind                { get; set; }
        public short        Code                { get; set; }
        public string       Day                 { get; set; }
        public DateTime     Date                { get; set; }
        public int          DayOfWeekInt        { get; set; }
        public string       WeekName            { get; set; }
        public decimal      DebitCircular       { get; set; }
        public decimal      CreditCircular      { get; set; }

        public decimal      Balance             => DebitCircular - CreditCircular;
    }
}
