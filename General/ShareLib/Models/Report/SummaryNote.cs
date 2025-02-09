using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareLib.Models
{
    public class SummaryNote
    {
        public DateTime     GregorianDate           { get; set; }
        public string       PersianStr              { get; set; }
        public byte         PersianMonthNo          { get; set; }
        public string       PersianMonthName        { get; set; }
        public string       PersianDayOfWeekName    { get; set; }
        public byte         PersianDayOfWeekInt     { get; set; }
        public string       msg                     { get; set; }
    }
}
