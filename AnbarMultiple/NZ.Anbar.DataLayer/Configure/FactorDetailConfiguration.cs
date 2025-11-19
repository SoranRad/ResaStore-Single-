using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Anbar.Model;

namespace NZ.Anbar.DataLayer.Configure
{
    public class FactorDetailConfiguration : EntityTypeConfiguration<FactorDetail>
    {
        public FactorDetailConfiguration()
        {
            this.ToTable    ("Anbar.tbl_Amaliat_Title_Detail");

            //this.HasRequired(x=>x.FactorHead)
            //    .WithRequiredPrincipal()

            this
                .Property   (e => e.Darsad_Maliat)
                .HasPrecision(6, 2);

            this
                .Property   (e => e.Darsad_Takhfif)
                .HasPrecision(6, 2);

            this
                .Property   (e => e.Darsad_Porsant)
                .HasPrecision(6, 2);

        }
    }
}
