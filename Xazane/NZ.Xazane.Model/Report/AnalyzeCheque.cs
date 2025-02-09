using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib;

namespace NZ.Xazane.Model.Report
{
    public class AnalyzeCheque
    {
        public byte     SubKind         { get; set; }
        public byte     MainKind        { get; set; }
        public int      ChequeCount     { get; set; }
        public decimal  Balance         { get; set; }
        public int      PeopeleCount    { get; set; }


        public string Title
        {
            get
            {
                if (MainKind == 1)
                    return ((Enums.NzPaymentOperatingKind) SubKind) == Enums.NzPaymentOperatingKind.Daryaft
                        ? " چـک دریافتی"
                        : " چک پرداختی";

                return ((Enums.NzChequeStateFlag)this.SubKind).NzToString();
            }
        }

        public string GroupTitle => MainKind == 1 ? "کلیه چکهای ثبت شده" : "وضعیـت چـک";
    }
}
