using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib;

namespace NZ.Xazane.Model.Report
{
    public class MoneyCircular
    {
        public long         IDSub               { get; set; }
        public long         FK_DP               { get; set; }
        public long?        serialPeygiri       { get; set; }
        public int          serial              { get; set; }
        public decimal      mablaq              { get; set; }
        public string       SubDesc             { get; set; }
        public string       MainDesc            { get; set; }
        public byte         SubKind             { get; set; }
        public byte         MainKind            { get; set; }
        public DateTime     tarikh              { get; set; }
        public string       DebitTitle          { get; set; }
        public string       CreditTitle         { get; set; }
        public string       PersianStr          { get; set; }


        

        public decimal  Balance     
        {
            get
            {
                switch ((Enums.NzPaymentOperatingKind)this.MainKind)
                {
                    case Enums.NzPaymentOperatingKind.Daryaft:
                        return -this.mablaq;
                    case Enums.NzPaymentOperatingKind.Pardaxt:
                        return this.mablaq;
                    case Enums.NzPaymentOperatingKind.Kosurat:
                        return this.mablaq;
                    case Enums.NzPaymentOperatingKind.Addition:
                        return -this.mablaq;
                }

                return this.mablaq;
            }
        }
        public string   Operation   
        {
            get
            {
                var Sub     = (Enums.NzPaymentOperatingKind) this.SubKind;
                var Main    = (Enums.NzPaymentOperatingKind) this.MainKind;

                switch (Main)
                {
                    case Enums.NzPaymentOperatingKind.Daryaft:
                        return " دریافت "+ Sub.NzToString();
                    case Enums.NzPaymentOperatingKind.Pardaxt:
                        return " پرداخت " + Sub.NzToString();
                    case Enums.NzPaymentOperatingKind.Kosurat:
                        return Sub.NzToString();
                    case Enums.NzPaymentOperatingKind.Addition:
                        return Sub.NzToString();
                }

                return Main.NzToString();
            }
        }

    }
}
