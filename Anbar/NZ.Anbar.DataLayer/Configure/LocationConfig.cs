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
    public class LocationConfig : EntityTypeConfiguration<Location>
    {
        public LocationConfig()
        {
            this
                .ToTable        ("Base.tbl_Base_Location");

            this
                .HasKey         (x => x.ID);

            this
                .Property       (x => x.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this
                .Property       (e => e.Title)
                .IsFixedLength  ()
                .HasMaxLength   (300);
            
        }

    }
}
