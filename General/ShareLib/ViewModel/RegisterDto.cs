using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Newtonsoft.Json;

namespace ShareLib.ViewModel
{
    public class RegisterDto
    {
        //[JsonConstructor]
        //public RegisterDto(string serial)
        //{
        //    Serial  = serial;
        //}
        public string       Serial          { get; set; }
        public string       Title           { get; set; }
        public string       CPU             { get; set; }
        public string       MB              { get; set; }
        public string       Mobile          { get; set; }
        public string       Email           { get; set; }
        public string       Address         { get; set; }
        public DateTime     DateStart       { get; set; }
    }
}
