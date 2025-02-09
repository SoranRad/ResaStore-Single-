using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Models;

namespace NZ.General.DataLayer.Configure
{
    public class DescriptionConfiguration : EntityTypeConfiguration<Description>
    {
        public DescriptionConfiguration()
        {
            this.ToTable    ("General.tbl_Sharh");

            this
            .Property       (e => e.Text)
            .IsFixedLength  ();
        }
    }
}
