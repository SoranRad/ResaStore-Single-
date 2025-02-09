using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShareLib.Interfaces
{
    //Fluent API 
    public abstract class DapperEntityConfiguration<T>
    {
        public string   GetList         { get; set; }
        public string   GetItem         { get; set; }
        public string   GetMaxSerial    { get; set; }
        public string   IsCodeUnique    { get; set; }

        public DapperEntityConfiguration<T>     SetList         (string SqlStr)
        {
            this.GetList = SqlStr;
            return this;
        }
        public DapperEntityConfiguration<T>     SetItem         (string SqlStr)
        {
            this.GetItem = SqlStr;
            return this;
        }
        public DapperEntityConfiguration<T>     SetMaxSerial    (string SqlStr)
        {
            this.GetMaxSerial = SqlStr;
            return this;
        }
        public DapperEntityConfiguration<T>     SetCodeUnique   (string SqlStr)
        {
            this.IsCodeUnique = SqlStr;
            return this;
        }
    }
}
