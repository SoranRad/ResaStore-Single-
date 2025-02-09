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
    public class ObjectImagesConfig :  EntityTypeConfiguration<ObjectImages>
    {
        public ObjectImagesConfig()
        {

            this.ToTable                        ("General.tbl_Image");

            this.HasIndex                       (x => x.ID);

            this.Property                       (x => x.ID)
                .HasDatabaseGeneratedOption     (DatabaseGeneratedOption.Identity);

        }
    }
}
