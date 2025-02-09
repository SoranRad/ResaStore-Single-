using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Interfaces;

namespace ShareLib.ViewModel
{

    public class UserLogin
    {
        public short    ID                  { get; set; }
        public short    Code                { get; set; }
        public string   Username            { get; set; }
        public string   Password            { get; set; }
        public string   default_password    { get; set; }
        public bool     is_disable          { get; set; }
    }
}
