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
    public class PreFactorItemsConfig : EntityTypeConfiguration<PreFactorItems>
    {
        public PreFactorItemsConfig()
        {
            this.ToTable                        ("Base.tbl_PreFactorItems");

            this.HasKey                         (x => x.ID);
            this.Property                       (x => x.ID)
                .HasDatabaseGeneratedOption     (DatabaseGeneratedOption.Identity);

            this.Ignore                         (x => x.ObjectTitle)
                .Ignore                         (x => x.State)
                .Ignore                         (x => x.UnitTitle)
                .Ignore                         (x => x.ObjectCode);
        }
    }
}
