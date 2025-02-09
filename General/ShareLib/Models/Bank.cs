
using ShareLib.Interfaces;

namespace ShareLib.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    
    public class Bank : ISqlQueryMaker
    {
        public Bank()
        {
            Peoples = new HashSet<People>();
        }

        public short                        ID      { get; set; }
        [StringLength(200)]
        public string                       title   { get; set; }
        public ICollection<People>          Peoples { get; set; }

        public string GetItem()
        {
            return @"";
        }

        public string GetList()
        {
            return @"
SELECT  ID,
		RTRIM(LTRIM( title)) as title
FROM [Base].[tbl_Bank]";
        }
    }
}
