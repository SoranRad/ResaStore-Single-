using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Anbar.Model;

namespace NZ.Anbar.DataLayer.Configure
{
    public class KardexConfiguration : EntityTypeConfiguration<Kardex>
    {
        public KardexConfiguration()
        {
            this
                .Property       (e => e.nerkh)
                .HasPrecision   (18, 4);

            this
                .Property       (e => e.nerkh_mande_miangin)
                .HasPrecision   (18, 4);

            this
                .Property       (e => e.meqdar)
                .HasPrecision   (18, 4);

            this
                .Property       (e => e.meqdar_mande_miangin)
                .HasPrecision   (18, 4);

            this
                .Property       (e => e.meqdar_mande_miani_Fari)
                .HasPrecision   (18, 4);

            this
                .Property       (e => e.meqdar_mande_varede)
                .HasPrecision   (18, 4);

            this
                .Property       (e => e.meqdar_mandeh_radif)
                .HasPrecision   (18, 4);

            this
                .Property       (e => e.meqdar_mande_varede_fari)
                .HasPrecision   (18, 4);

            this
                .Property       (e => e.meqdar_mandeh_radif_fari)
                .HasPrecision   (18, 4);

            this
                .Property       (e => e.rowversion)
                .IsFixedLength  ();

            this
                .HasMany        (e => e.SubKardex)
                .WithOptional   (e => e.ParentKardex)
                .HasForeignKey  (e => e.FK_Parent_Varede);
        }
    }
}
