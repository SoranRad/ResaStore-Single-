using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Anbar.Model;

namespace NZ.Anbar.DataLayer.Configure
{
    public class UnitConfiguration : EntityTypeConfiguration<Unit>
    {
        public UnitConfiguration()
        {
            this.ToTable            ("Base.tbl_Vahed");

            this.Property           (e => e.title)
                .IsFixedLength();

            this
                .HasMany            (e => e.FactorItems)
                .WithOptional       (e => e.Unit)
                .HasForeignKey      (e => e.FK_Vahed);

            this
                .HasMany            (e => e.Objects)
                .WithRequired       (e => e.tbl_Vahed)
                .HasForeignKey      (e => e.FK_Vahed)
                .WillCascadeOnDelete(false);
        }
    }
}
