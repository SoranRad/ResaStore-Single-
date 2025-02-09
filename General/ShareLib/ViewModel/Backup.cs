using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Interfaces;

namespace ShareLib.ViewModel
{
    public class Backup : ISqlQueryMaker
    {
        public string Address { get; set; }

        public string GetItem()
        {
            return @"";
        }

        public string GetList()
        {
            return @"print 'Nothing'";
        }
    }
}
