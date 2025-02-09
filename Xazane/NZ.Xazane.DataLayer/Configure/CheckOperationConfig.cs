using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Xazane.Model.Models;

namespace NZ.Xazane.DataLayer.Configure
{
    public class CheckOperationConfig:EntityTypeConfiguration<ChequeOperation>
    {
        public CheckOperationConfig()
        {
            this.ToTable            ("Xazane.tbl_Amaliat_Check");

            this
                .Property           (e => e.mablaq)
                .HasPrecision       (18, 0);

            this
                .Property           (e => e.shomare_check)
                .IsFixedLength      ();

            this
                .Property           (e => e.Sharh_Vaziat)
                .IsFixedLength      ();

            this
                .Property           (e => e.babat)
                .IsFixedLength      ();

        }
    }
}
