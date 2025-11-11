using Nz.Anbar.Model.Model;
using System.Linq;
using ShareLib;

namespace NZ.Anbar.Model
{
    using System;
    using System.Collections.Generic;
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
        public int                          Serial              { get; set; }
        public byte                         kind                { get; set; }
        public bool                         is_ok               { get; set; }
        public DateTime                     tarikh_add          { get; set; }
        public decimal                      mablaq              { get; set; }
        [Column(TypeName = "date")]
        public DateTime                     tarikh              { get; set; }
        [StringLength(300)]
        public string                       sharh               { get; set; }
        public long?                        FK_Mabna            { get; set; }

        //public object   this[int index]
        //{
        // get
        // {
        //  //var list = _Factor.FactorItems.Where(x => x.State != Enums.NzItemState.Deleted).OrderBy(x=>x.radif);
        //  //return index < list.Count() 
        //  //                ? list.ToList()[index] 
        //  //                : null;
        //  //FactorItems.Where(x => x.State != Enums.NzItemState.Deleted).OrderBy(x => x.radif).ToList()[index];
        //  return _orderedItemsList[index];
        // }
        // set
        // {
        //  //var list = _Factor.FactorItems.Where(x => x.State != Enums.NzItemState.Deleted).OrderBy(x=>x.radif);
        //  //if(index < list.Count())
        //  //    list.ToList()[index] = (FactorItem)value;
        //  _order
        // }
        // //=> _Factor.FactorItems.Where(x => x.State != Enums.NzItemState.Deleted).ToList()[index] =(FactorItem) value;
        //}
        //public List<FactorItem>             FactorItems         { get; set; }

        public ICollection<FactorItem> FactorItems { get; set; }
        public FactorDetail                 FactorDetail        { get; set; } 
        public Location                     Location            { get; set; }
    }
}
