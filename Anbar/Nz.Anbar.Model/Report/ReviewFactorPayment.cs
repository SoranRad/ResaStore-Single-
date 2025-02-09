using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Anbar.Model.Report
{
    public class ReviewFactorPayment
    {
        public long         ID                  { get; set; }

        public int          Serial              { get; set; }
        public string       PersianStr          { get; set; }
        public string       PersianMonthNo      { get; set; }
        public string       PersianDayInMonth   { get; set; }

        public string       Customer            { get; set; }
        public decimal      mablaq              { get; set; }
        public string       sharh               { get; set; }

        public decimal?     Cheque              { get; set; }
        public decimal?     Cache               { get; set; }
        public decimal?     Pos                 { get; set; }

        public decimal?     mablaq_takhfif      { get; set; }
        public decimal?     Darsad_Takhfif      { get; set; } 
        public decimal?     Ezafat              { get; set; }
        public long?        FK_AshXas_ID        { get; set; }

        public string       Description         { get; set; }
        public string       Location            { get; set; }
        public string       FactorItems         { get; set; }

        public bool         is_ok               { get; set; }

        public decimal      Remaind             =>mablaq-(Cheque??0)-(Cache??0)-(Pos??0);
    }
}
