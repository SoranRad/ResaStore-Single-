using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareLib.ViewModel
{
    public class DailyCircular 
    {
        public DateTime     GregorianDate           { get; set; }
        public short        PersianMonthInt         { get; set; }
        public string       PersianStr              { get; set; }
        public DateTime     Day                     { get; set; }

        public decimal?      Xarid                   { get; set; }
        public decimal?      Frosh                   { get; set; }
        public decimal?      BargashtXarid           { get; set; }
        public decimal?      BargashtFrosh           { get; set; }
        public decimal?      Zayat                   { get; set; }
        public decimal?      Masraf                  { get; set; }


        public decimal?      DaryaftCache            { get; set; }
        public decimal?      DaryaftPos              { get; set; }
        public decimal?      DaryaftCheck            { get; set; }

        public decimal?      PardaxtCache            { get; set; }
        public decimal?      PardaxtPos              { get; set; }
        public decimal?      PardaxtCheck            { get; set; }

        public decimal?      Hazineh                 { get; set; }
        public decimal?      Daramad                 { get; set; }

    }
}
