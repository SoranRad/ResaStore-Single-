using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ.Xazane.Model.Models
{
   public class DPOperation
    {

        public DPOperation()
        {
            PayBoxOP  = new HashSet<PayBoxOperation>();
            ChequeOP  = new HashSet<ChequeOperation>();
        }

        public long         ID                  { get; set; }
        public short        FK_Salmali          { get; set; }
        public short        FK_User_Add         { get; set; }
        public short?       FK_User_Edit        { get; set; }
        public long?        FK_Faktor           { get; set; }
        public long?        FK_ShaXs            { get; set; }
        public long?        FK_ShaXs_Enteqal    { get; set; }
        public long?        FK_Qest_Main        { get; set; }
        public long?        FK_Qest_Riz         { get; set; }
        public int          serial              { get; set; }
        public decimal?     takhfif             { get; set; }
        public byte         kind                { get; set; }
        [Column(TypeName = "date")]
        public DateTime     tarikh              { get; set; }
        public DateTime     tarikh_add          { get; set; }
        public DateTime?    tarikh_edit         { get; set; }
        [StringLength(300)]
        public string       sharh               { get; set; }
        public bool         is_ok               { get; set; }

        public ICollection<ChequeOperation>             ChequeOP          { get; set; }  
        public ICollection<PayBoxOperation>             PayBoxOP          { get; set; }


    }
}
