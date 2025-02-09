using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib;

namespace NZ.Xazane.Model.Report
{
    public class AnalyzeChequeDetail
    {

        public long     ID                  { get; set; }
        public decimal  mablaq              { get; set; }
        public int      serial              { get; set; }
        public long     IDMain              { get; set; }
        public string   DpDate              { get; set; }
        public string   UsentDate           { get; set; }
        public string   StateDate           { get; set; }
        public string   People              { get; set; }
        public string   AssignPeople        { get; set; }
        public string   Sharh               { get; set; }
        public string   SharhVaziat         { get; set; }
        public string   BankTitle           { get; set; }
        public string   DPAccount           { get; set; }
        public string   StateAccount        { get; set; }
        public byte     Kind                { get; set; }
        public byte?    Kind_Vaziat         { get; set; }

        public string   AccountAction       => (Enums.NzPaymentOperatingKind)this.Kind==Enums.NzPaymentOperatingKind.Daryaft
                                                ?   BankTitle
                                                :   DPAccount;
        public string   AccountVaziat       
        {
            get
            {
                if (Kind_Vaziat == null)
                    return string.Empty;

                switch ((Enums.NzChequeStateFlag)this.Kind_Vaziat.Value)
                {
                    case Enums.NzChequeStateFlag.Vosul:
                    {
                        return (Enums.NzPaymentOperatingKind)this.Kind == Enums.NzPaymentOperatingKind.Daryaft
                                ? StateAccount
                                : string.Empty;
                    }
                    case Enums.NzChequeStateFlag.Vagozari:
                        return AssignPeople;
                    case Enums.NzChequeStateFlag.Bargasht:
                        return string.Empty;
                    case Enums.NzChequeStateFlag.Nazd_Sanduq:
                        return string.Empty;
                    default:
                        return string.Empty;
                }
            }
        }

        public string   DPTitle => (Enums.NzPaymentOperatingKind)this.Kind == Enums.NzPaymentOperatingKind.Daryaft
                                            ? "دریافت چـک"
                                            : "پرداخت چـک";
        public string   KindTitle           =>  this.Kind_Vaziat == null 
                                                 ? (Enums.NzChequeStateFlag.Nazd_Sanduq).NzToString() 
                                                 : ((Enums.NzChequeStateFlag) this.Kind_Vaziat).NzToString();

    }
}
