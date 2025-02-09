using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ.Xazane.Model.ViewModel
{
    public class PrintDP
    {
        public long         ID                  { get; set; }
        public string       tarikh              { get; set; }
        public int          serial              { get; set; }
        public string       Name                { get; set; }
        public string       Address             { get; set; }
        public string       CodeMeli            { get; set; }
        public string       Mobile              { get; set; }
        public string       Tel                 { get; set; }
        public decimal      takhfif             { get; set; }
        public string       sharh               { get; set; }
        //=====نقد
        public decimal      Cache               { get; set; }
        public string       CacheDesc           { get; set; }
        //=====حواله بانکی
        public decimal      POS                 { get; set; }
        public long         SerialPeygiri       { get; set; }
        public string       POSDesc             { get; set; }
        public string       POSTitle            { get; set; }
        //========چـک
        public long?         IDCheque            { get; set; }
        public string       shomare_check       { get; set; }
        public string       tarikh_sar_resid    { get; set; }
        public decimal      mablaq              { get; set; }
        public string       NameBank            { get; set; }
        public string       ChequeDesc          { get; set; }


    }
}
