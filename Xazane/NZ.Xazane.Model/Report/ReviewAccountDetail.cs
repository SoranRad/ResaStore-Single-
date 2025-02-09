using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib;

namespace NZ.Xazane.Model.Report
{
    public class ReviewAccountDetail
    {
        public long     ID              { get; set; }
        public decimal  mablaq          { get; set; }
        public long     MainID          { get; set; }
        public byte     RowKind         { get; set; }
        public byte     SubKind         { get; set; }
        public byte     MainKind        { get; set; }
        public string   SubText         { get; set; }
        public string   MainText        { get; set; }
        public string   AccountTitle    { get; set; }
        public string   People          { get; set; }
        public string   PersianStr      { get; set; }

        public int      Serial          { get; set; }
        public string   Serial2         { get; set; }

        public string   Action          
        {
            get
            {
                if (RowKind == 1)
                {
                    var kind = (Enums.NzPaymentOperatingKind) MainKind;
                    switch ((Enums.NzPaymentOperatingKind)SubKind)
                    {
                        case Enums.NzPaymentOperatingKind.Daramad:
                            return "ثبت درآمد";
                        case Enums.NzPaymentOperatingKind.Hazine:
                            return "ثبت هزینه";
                        case Enums.NzPaymentOperatingKind.Kosurat:
                            return "کسورات حساب شخص";
                        case Enums.NzPaymentOperatingKind.Addition:
                            return "اضافات حساب شخص";
                        case Enums.NzPaymentOperatingKind.Naql_Enteqal:
                            return "انتقال وجوه بین منابع";
                        case Enums.NzPaymentOperatingKind.Naqd:
                            return kind == Enums.NzPaymentOperatingKind.Daryaft ?"دریافت وجه نقد":"پرداخت وجه نقد";
                        case Enums.NzPaymentOperatingKind.Bank_POS:
                            return kind == Enums.NzPaymentOperatingKind.Daryaft ? "دریافت حواله بانکی POS" : "پرداخت حواله بانکی POS";
                        default:
                            return string.Empty;
                    }
                }
                return ((Enums.NzChequeStateFlag) SubKind).NzToString();
            }
        }

        public string   ActAccount      
        {
            get
            {
                if (RowKind == 2)
                    return People;
                else
                {
                    var subkind = (Enums.NzPaymentOperatingKind) SubKind;

                    if (subkind == Enums.NzPaymentOperatingKind.Naqd ||
                        subkind == Enums.NzPaymentOperatingKind.Bank_POS)
                        return People;

                    return AccountTitle;

                }
            }
        }
    }
}
