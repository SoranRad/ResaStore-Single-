using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nz.Anbar.Model.Model;

namespace NZ.Anbar.DataLayer.Configure
{
    public class PreFactorConfig : EntityTypeConfiguration<PreFactor>
    {
        public PreFactorConfig()
        {
            this.ToTable("Base.tbl_Prefactor");

            this.HasKey                         (x => x.ID);
            this.Property                       (x => x.ID)
                .HasDatabaseGeneratedOption     (DatabaseGeneratedOption.Identity);

            this
                .Property               (e => e.Title)
                .HasMaxLength           (300)
                .IsFixedLength          ();

            this
                .HasMany                (e => e.Items)
                .WithRequired           (e => e.PreFactor)
                .HasForeignKey          (e => e.FK_Title)
                .WillCascadeOnDelete    ();

        }
    }
}
