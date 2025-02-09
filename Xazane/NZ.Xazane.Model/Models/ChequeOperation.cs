using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using MS_Control.Tarikh;
using ShareLib;
using ShareLib.Models;

namespace NZ.Xazane.Model.Models
{
    public class ChequeOperation
    {



        public long             ID                      { get; set; }
        public short?           FK_Bank                 { get; set; }
        public int?             FK_Hesab_Pardaxtani     { get; set; }
        public long?            FK_Daste_Cheque         { get; set; }
        public long             FK_DP                   { get; set; }
        public short            FK_User_Add             { get; set; }
        public short?           FK_User_Edit            { get; set; }
        [Column(TypeName = "date")]
        public DateTime?        tarikh_sar_resid        { get; set; }
        public byte?            kind                    { get; set; }
        public decimal?         mablaq                  { get; set; }
        [StringLength(50)]
        public string           shomare_check           { get; set; }
        [StringLength(150)]
        public string           babat                   { get; set; }
        public DateTime         tarikh_add              { get; set; }
        public DateTime?        tarikh_edit             { get; set; }
        public bool             is_ok                   { get; set; }
        public short?           FK_Salmali_Vaziat       { get; set; }
        public int?             FK_Xazaneh_Vaziat       { get; set; }
        public long?            FK_Shaxs_Vaziat         { get; set; }
        public long?            FK_DP_Vagozari          { get; set; }
        public short?           FK_User_Add_Vaziat      { get; set; }
        public short?           FK_User_Edit_Vaziat     { get; set; }
        public byte?            Kind_Vaziat             { get; set; }
        [Column(TypeName = "date")]
        public DateTime?        Tarix_Vaziat            { get; set; }
        public DateTime?        Tarix_Edit_Vaziat       { get; set; }
        public DateTime?        Tarix_Add_Vaziat        { get; set; }
        [StringLength(100)]
        public string           Sharh_Vaziat            { get; set; }
        

        public DPOperation          DpHead              { get; set; }
        public Accounts             PayAccount          { get; set; }
        public ChequeBookDetail     ChequeBookDetail    { get; set; }
        public Accounts             StateAccount        { get; set; }

        [NotMapped]
        public Enums.NzItemState    State               { get; set; }
        [NotMapped]
        public string               BankTitle           { get; set; }
        [NotMapped]
        public string               PersianUsanceStr    { get; set; }
        [NotMapped]
        public string               PayAccountTitle     { get; set; }
    }
}
