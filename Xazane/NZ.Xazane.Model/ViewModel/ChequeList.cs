using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib;

namespace NZ.Xazane.Model.ViewModel
{
    public class ChequeList
    {
        public long         ID                  { get; set; }
        public long         ID_DP               { get; set; }
        public string       shomare_check       { get; set; }
        public decimal      mablaq              { get; set; }
        public string       PersianUsanceStr    { get; set; }
        public string       babat               { get; set; }
        public DateTime?    tarikh_sar_resid    { get; set; }
        public string       PersianStr          { get; set; }
        public byte         PersianDayInMonth   { get; set; }
        public byte         PersianMonthNo      { get; set; }
        public string       BankTitle           { get; set; }
        public string       PayAccountTitle     { get; set; }
        public string       CustomerTitle       { get; set; }
        public byte?        Kind_Vaziat         { get; set; }
        public string       StateDate           { get; set; }   

        public string       StateTitle          => Kind_Vaziat == null 
                                                    ? @"نزد صندوق" 
                                                    : ((Enums.NzChequeStateFlag)this.Kind_Vaziat)
                                                            .NzToString();
    }
}
