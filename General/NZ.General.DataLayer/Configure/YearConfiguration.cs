using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Models;

namespace NZ.General.DataLayer.Configure
{
    public class YearConfiguration : EntityTypeConfiguration<Year>
    {
        public YearConfiguration()
        {
            this.ToTable        ("General.tbl_Salmali");

            

            this
                .Property       (e => e.Money)
                .IsFixedLength  ();

        }
    }
}
