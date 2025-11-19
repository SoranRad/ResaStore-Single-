using Nz.Anbar.Model.Model;
using ShareLib.Models;

namespace NZ.Anbar.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
     
    public class FactorHead
    {
        public FactorHead()
        {
            FactorItems         = new HashSet<FactorItem>();
        }

        public long                         ID                  { get; set; }

        public short?                       FK_Location         { get; set; }
        public short                        FK_Salmali          { get; set; }
        public short                        FK_User_Add         { get; set; }
        public long?                        FK_AshXas_ID        { get; set; }
        public short?                       FK_Kind_Frosh       { get; set; }
        [DefaultValue(1)]
        public short?                       FK_Anbar_Az         { get; set; }
        public short?                       FK_Anbar_Be         { get; set; }

        public long?                        FK_Tahvil_Girande   { get; set; }
        public long?                        FK_Mabna            { get; set; }


        public int                          Serial              { get; set; }
        public byte                         kind                { get; set; }
        public bool                         is_ok               { get; set; }
        public DateTime                     tarikh_add          { get; set; }
        public decimal                      mablaq              { get; set; }
        [Column(TypeName = "date")]
        public DateTime                     tarikh              { get; set; }
        [StringLength(300)]
        public string                       sharh               { get; set; }
        public bool                         NoRemainEffect      { get; set; }

        
        public ICollection<FactorItem>      FactorItems         { get; set; }
        public FactorDetail                 FactorDetail        { get; set; } 
        public Location                     Location            { get; set; }

        public Storage                      Anbar_Az            { get; set; }
        public Storage                      Anbar_Be            { get; set; }

    }
}
