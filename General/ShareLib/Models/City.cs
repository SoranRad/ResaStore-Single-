
using ShareLib.Interfaces;

namespace ShareLib.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public class City : ISqlQueryMaker,IEntityUsage
    {
        public City()
        {
            Peoples = new HashSet<People>();
        }

        public short                  ID                { get; set; }
        [StringLength(150)]
        public string                 title             { get; set; }
        public short                  FK_Ostan          { get; set; }
        public ICollection<People>    Peoples           { get; set; }
        public State                  State             { get; set; }
        [NotMapped]
        public string                 StateTitle        { get; set; }


        public string   CircularQuery   ()
        {
            return @"
SELECT TOP(1) ta.ID FROM Base.tbl_Ashxas AS ta
WHERE ta.FK_Shahr = @ID
";
        }
        public string   GetItem         ()
        {
            return
                "SELECT "
                + "TS.ID , "
                + "TS.FK_Ostan ,"
                + "LTRIM(RTRIM(TS.title)) AS title, "
                + "LTRIM(RTRIM(TOS.title)) AS StateTitle "
                + "FROM Base.tbl_Shahr AS TS "
                + "INNER JOIN Base.tbl_Ostan AS TOS ON TOS.ID = TS.FK_Ostan "
                + "where ID=@ID";

        }
        public string   GetList         ()
        {
            return @"
            SELECT 
                TS.ID , 
                TS.FK_Ostan ,
                LTRIM(RTRIM(TS.title)) AS title , 
                LTRIM(RTRIM(TOS.title)) AS StateTitle 
                FROM Base.tbl_Shahr AS TS 
                INNER JOIN Base.tbl_Ostan AS TOS ON TOS.ID = TS.FK_Ostan ";
        }
     
    }
}
