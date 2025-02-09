
using ShareLib.Interfaces;

namespace ShareLib.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public partial class State :ISqlQueryMaker ,IEntityUsage
    {
        public State()
        {
            City = new HashSet<City>();
        }

        public short                ID      { get; set; }
        [StringLength(150)]
        public string               title   { get; set; }
        public  ICollection<City>   City    { get; set; }   

        public string               CircularQuery   ()
        {
            return @"SELECT TOP(1)ts.ID FROM Base.tbl_Shahr AS ts
                        WHERE ts.FK_Ostan =@ID";
        }
        public string               GetItem         ()
        {
            return @"";
        }
        public string               GetList         ()
        {
            return   "select " +
                     "ID ," +
                     "Rtrim(Ltrim( title )) as title " +
                     "from Base.tbl_Ostan ";
        }
    }
}
