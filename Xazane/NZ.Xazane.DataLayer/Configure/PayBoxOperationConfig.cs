using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Xazane.Model.Models;

namespace NZ.Xazane.DataLayer.Configure
{
    public class PayBoxOperationConfig : EntityTypeConfiguration<PayBoxOperation>
    {
        public PayBoxOperationConfig()
        {
            this.ToTable        ("Xazane.tbl_Amaliat_Xazaneh");

            this
                .Property       (e => e.mablaq)
                .HasPrecision   (18, 4);

            this
                .Property       (e => e.sharh)
                .IsFixedLength  ();

        }
    }
}
