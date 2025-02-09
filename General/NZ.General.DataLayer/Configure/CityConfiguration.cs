using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Models;

namespace NZ.General.DataLayer.Configure
{
    public class CityConfiguration : EntityTypeConfiguration<City>
    {
        public CityConfiguration()
        {
            this.ToTable        ("Base.tbl_Shahr");
           this
               .Property        (e => e.title)
               .IsFixedLength   ();

            this    
                .HasMany        (e => e.Peoples)
                .WithOptional   (e => e.City)
                .HasForeignKey  (e => e.FK_Shahr);
        }
    }
}
