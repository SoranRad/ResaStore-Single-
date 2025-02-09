using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Anbar.Model;

namespace NZ.Anbar.DataLayer.Configure
{
    public class FactorHeadConfiguration : EntityTypeConfiguration<FactorHead>
    {
        public FactorHeadConfiguration()
        {
            this.ToTable("Anbar.tbl_Amaliat_Title");


            this
                .Property               (e => e.sharh)
                .IsFixedLength          ();

            this
                .HasMany                (e => e.FactorItems)
                .WithRequired           (e => e.FactorHead)
                .HasForeignKey          (e => e.FK_Title)
                .WillCascadeOnDelete    ();

            this
                .HasOptional            (e => e.FactorDetail)
                .WithRequired           (e => e.FactorHead)
                .WillCascadeOnDelete    ();

            this.HasOptional            (x => x.Location)
                .WithMany               (x => x.Factors)
                .HasForeignKey          (x => x.FK_Location);

        }
    }
}
