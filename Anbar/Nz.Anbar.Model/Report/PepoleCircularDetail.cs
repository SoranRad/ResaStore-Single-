using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib;

namespace Nz.Anbar.Model.Report
{
    public class PeopleCircularDetail
    {
        public int          Serial              { get; set; }
        public string       PersianStr          { get; set; }
        public byte         kind                { get; set; }
        public long         IDTitle             { get; set; }
        public long?        ID                  { get; set; }
        public int          radif               { get; set; }
        public int          FK_Kala             { get; set; }
        public string       ObjectTitle         { get; set; }
        public string       UnitTitle           { get; set; }
        public decimal      meqdar              { get; set; }
        public decimal      nerkh               { get; set; }
        public decimal      takhfif_darsad      { get; set; }
        public decimal      takhfif             { get; set; }
        public decimal      mablaq              { get; set; }
        public string       LocationTitle       { get; set; }

        public string       KindTitle           => ((Enums.NzFactorKind) kind).NzToString();
        public decimal      Mount               => kind < 50 ? -mablaq : mablaq;
    }
}
