using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Nz.Anbar.Model.Model;

namespace NZ.Anbar.DataLayer.Configure
{
    public class BasteBandiConfiguration : EntityTypeConfiguration<BasteBandi>
    {
        public BasteBandiConfiguration()
        {
            this.ToTable("Base.tbl_BasteBandi");

            this.HasKey                         (x => x.ID);
            this.Property                       (x => x.ID)
                .HasDatabaseGeneratedOption     (DatabaseGeneratedOption.Identity);

            this
                .Property                       (e => e.Title)
                .HasMaxLength                   (150)
                .IsFixedLength                  ();
        }
    }
}