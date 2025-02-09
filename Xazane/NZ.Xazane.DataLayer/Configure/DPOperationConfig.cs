using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Xazane.Model.Models;

namespace NZ.Xazane.DataLayer.Configure
{
    public class DPOperationConfig : EntityTypeConfiguration<DPOperation>
    {
        public DPOperationConfig()
        {
            this.ToTable                ("Xazane.tbl_Amaliat_DP");

            this.HasKey                 (x => x.ID);

            this.Property               (x => x.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this
                .Property               (e => e.takhfif)
                .HasPrecision           (18, 4);

            this
                .HasMany                (e => e.ChequeOP)
                .WithRequired           (e => e.DpHead)
                .HasForeignKey          (e => e.FK_DP)
                .WillCascadeOnDelete    ();


            this
                .HasMany                (e => e.PayBoxOP)
                .WithOptional           (e => e.DpHead)
                .HasForeignKey          (e => e.FK_DP)
                .WillCascadeOnDelete    ();
        }
    }

}
