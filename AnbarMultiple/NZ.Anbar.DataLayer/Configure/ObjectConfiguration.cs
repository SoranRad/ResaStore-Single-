using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Anbar.Model;

namespace NZ.Anbar.DataLayer.Configure
{
    public class ObjectConfiguration : EntityTypeConfiguration<NzObject>
    {
        public ObjectConfiguration()
        {
            this.ToTable("Base.tbl_Kala_Xadamat");

            this
                .Property(e => e.title)
                .IsFixedLength();

            this
                .Property(e => e.barcode)
                .IsFixedLength();

            this
                .Property(e => e.nameFani)
                .IsFixedLength();

            this
                .Property(e => e.codeFani)
                .IsFixedLength();

            this
                .Property(e => e.point_bohrani)
                .HasPrecision(12, 2);

            this
                .Property(e => e.nerkh_frosh)
                .HasPrecision(18, 0);

            this
                .Property(e => e.nerkh_frosh1)
                .HasPrecision(18, 0);

            this
                .Property(e => e.nerkh_frosh2)
                .HasPrecision(18, 0);

            this
                .Property(e => e.nerkh_frosh3)
                .HasPrecision(18, 0);

            this
                .Property(e => e.keshvarSazande)
                .IsFixedLength()
                .HasMaxLength(150);

            this
                .Property(e => e.Height)
                .HasPrecision(12, 2);

            this
                .Property(e => e.Width)
                .HasPrecision(12, 2);
            this
                .Property(e => e.Length)
                .HasPrecision(12, 2);

            this
                .Property(e => e.Gender)
                .IsFixedLength()
                .HasMaxLength(200);

            this
                .Property(e => e.Size)
                .IsFixedLength()
                .HasMaxLength(10);

            this.HasMany                (x => x.PreFactorItemses)
                .WithRequired           (x => x.NzObject)
                .HasForeignKey          (x => x.FK_Kala)
                .WillCascadeOnDelete    (true);


            this
                .HasOptional            (x => x.tbl_BasteBandi)
                .WithMany               (x => x.Objects)
                .HasForeignKey          (x => x.FK_BasteBandi);

             this
                .HasOptional            (x => x.tbl_Brand)
                .WithMany               (x => x.Objects)
                .HasForeignKey          (x => x.FK_Brand);

             this
                .HasOptional            (x => x.tbl_Images)
                .WithMany               (x => x.Objects)
                .HasForeignKey          (x => x.FK_Image);

            
        }
    }
}
