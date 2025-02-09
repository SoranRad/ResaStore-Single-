using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib;

namespace NZ.Xazane.Model.ViewModel
{
    public class RemaindList
    {
        

        public long         ID              { get; set; }
        public int          code            { get; set; }
        public string       title           { get; set; }
        public string       namePedar       { get; set; }
        public string       codeMeli        { get; set; }

        public long?        ID_DP           { get; set; }
        public short?       FK_Salmali      { get; set; }
        public short?       FK_User_Add     { get; set; }
        public short?       FK_User_Edit    { get; set; }
        
        public decimal?     takhfif         { get; set; }
        [StringLength(200)]
        public string       sharh           { get; set; }
        public byte?        kind            { get; set; }
        [Column(TypeName = "date")]
        public DateTime?    tarikh          { get; set; }
        public DateTime?    tarikh_add      { get; set; }
        public DateTime?    tarikh_edit     { get; set; }

        [NotMapped]
        public string StateTitle
        {
            get
            {
                if (this.kind == null)
                    return @"";

                switch ((Enums.NzPaymentOperatingKind) this.kind)
                {
                    case Enums.NzPaymentOperatingKind.RemaindDebit:
                        return @"بدهکار";
                    case Enums.NzPaymentOperatingKind.RemaindCredit:
                        return @"بستانکار";
                    default:
                        return @"";
                }
            }
        }  

       
    }
}
