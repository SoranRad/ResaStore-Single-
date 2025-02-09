using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.Model;

namespace NZ.Anbar.DataLayer.Configure
{
    public class SubGroupConfiguration : EntityTypeConfiguration<SubGroup>
    {
        public SubGroupConfiguration()
        {
            this
                .ToTable        ("Base.tbl_GroupKala_2th");

            this
                .Property       (e => e.title)
                .IsFixedLength  ();
        }
    }
}
