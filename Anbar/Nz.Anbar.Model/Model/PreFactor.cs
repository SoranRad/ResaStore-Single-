using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Anbar.Model.Model
{
    public class PreFactor
    {
        public PreFactor()
        {
            Items = new HashSet<PreFactorItems>();
        }
        public int      ID      { get; set; }
        public string   Title   { get; set; }

        public ICollection<PreFactorItems> Items { get; set; }
    }
}
