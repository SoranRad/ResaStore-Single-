using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib;

namespace NZ.Xazane.Model.Report
{
    public class PeopleChequeAssign
    {
        public long         ID                      { get; set; }
        public long         ID_DP                   { get; set; }
        public string       PersianUsanceStr        { get; set; }
        public string       VaziatPersianStr        { get; set; }
        public string       shomare_check           { get; set; }
        public string       SharhVaziat             { get; set; }
        public string       BankTitle               { get; set; }
        public byte         kind                    { get; set; }
        public decimal      mablaq                  { get; set; }
        public string       PeopleTitle             { get; set; }
        

        public string       Operation               => "واگذاری چک به شخص";

    }
}
