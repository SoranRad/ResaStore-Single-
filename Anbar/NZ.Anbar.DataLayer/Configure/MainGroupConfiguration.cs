using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.Model;
using NZ.Anbar.Model;

namespace NZ.Anbar.DataLayer.Configure
{
    class MainGroupConfiguration : EntityTypeConfiguration<MainGroup>
    {
        public MainGroupConfiguration()
        {
            this.ToTable        ("Base.tbl_GroupKala_1th");

            this
                .Property       (e => e.title)
                .IsFixedLength  ();
        }
    }
}
