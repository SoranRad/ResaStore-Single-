using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Newtonsoft.Json;

namespace ShareLib.ViewModel
{
    public class ActivationResultDto
    {
        //[JsonConstructor]
        //public ActivationResultDto()
        //{
            
        //}
        public string   MSG         { get; set; }
        public string   Serial      { get; set; }
        public string   Title       { get; set; }
        public string   StartDate   { get; set; }
        public string   Address     { get; set; }
        public string   Mobile      { get; set; }
        public string   Email       { get; set; }
    }
}
