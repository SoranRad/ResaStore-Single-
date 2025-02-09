using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Updater.Model
{
    public class ChangeLog
    {
        //public Guid Id { get; set; }
        public short FK_Appliocation { get; set; }
        public string Version { get; set; }
        public string UpdateDate { get; set; }
        public string Description { get; set; }
    }
}
