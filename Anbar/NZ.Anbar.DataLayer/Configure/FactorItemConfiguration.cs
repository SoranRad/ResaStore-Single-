using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Anbar.Model;

namespace NZ.Anbar.DataLayer.Configure
{
    public class FactorItemConfiguration : EntityTypeConfiguration<FactorItem>
    {
        public FactorItemConfiguration()
        {
            this.ToTable("Anbar.tbl_Amaliat_Riz");

          

            this.HasKey(x => x.ID);

            this
                .Property(x => x.ID)
                
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this
                .Property       (e => e.meqdar)
                .HasPrecision   (18, 3);

            this
                .Property       (e => e.nerkh_2)
                .HasPrecision   (18, 3);

            this
                .Property       (e => e.Remain)
                .HasPrecision   (18, 3);

            this
                .Property       (e => e.takhfif_darsad)
                .HasPrecision   (8, 3);

            this
                .Property       (e => e.rowversion)
                .IsFixedLength  ();

            this
                .HasMany        (e => e.KardexItems)
                .WithRequired   (e => e.FactorItem)
                .HasForeignKey  (e => e.FK_Riz);

        }
    }
}
