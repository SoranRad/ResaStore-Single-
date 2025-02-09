using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareLib.Models
{
    public class Dialog
    {
        public long             ID                  { get; set; }
        public long             FK_Shaxs_ID         { get; set; }
        public short            FK_User_Add         { get; set; }
        public short?           FK_User_Edit        { get; set; }
        [Column(TypeName = "date")]
        public DateTime         tarix               { get; set; }
        [StringLength(5)]
        public string           saat                { get; set; }
        [StringLength(500)]
        public string           userTell            { get; set; }
        [StringLength(500)]
        public string           shaxsTell           { get; set; }
        public bool             vaziat              { get; set; }
        public DateTime         tarikh_add          { get; set; }
        public DateTime?        tarikh_edit         { get; set; }

        public People           Customer            { get; set; }
        public User             UserEdit            { get; set; }
        public User             UserInsert          { get; set; }
    }
}
