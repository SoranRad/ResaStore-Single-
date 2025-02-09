using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib;

namespace NZ.Xazane.Model.Report
{
    public class AnalyzeChequeMonthly
    {
        public byte     SubKind         { get; set; }
        public byte     MainKind        { get; set; }
        
        public decimal  Farvardin       { get; set; }
        public decimal  Ordibehesht     { get; set; }
        public decimal  Xordad          { get; set; }
        public decimal  Tir             { get; set; }
        public decimal  Mordad          { get; set; }
        public decimal  Shahrivar       { get; set; }
        public decimal  Mehr            { get; set; }
        public decimal  Aban            { get; set; }
        public decimal  Azar            { get; set; }
        public decimal  Dey             { get; set; }
        public decimal  Bahman          { get; set; }
        public decimal  Esfand          { get; set; }

        public string   Title           
        {
            get
            {
                if (MainKind == 1)
                    return ((Enums.NzPaymentOperatingKind)SubKind) == Enums.NzPaymentOperatingKind.Daryaft
                        ? " چـک دریافتی"
                        : " چک پرداختی";

                return ((Enums.NzChequeStateFlag)this.SubKind).NzToString();
            }
        }

        public string   GroupTitle      => MainKind == 1 ? "کلیه چکهای ثبت شده" : "وضعیـت چـک";

    }
}
