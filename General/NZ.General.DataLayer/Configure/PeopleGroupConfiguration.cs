using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Models;

namespace NZ.General.DataLayer.Configure
{
    public class PeopleGroupConfiguration : EntityTypeConfiguration<PeopleGroup>
    {
        public PeopleGroupConfiguration()
        {
            this.ToTable("Base.tbl_Group_Ashxas");

            this
                .Property           (e => e.Title)
                .IsFixedLength      ();

            this
                .HasMany            (e => e.Peoples)
                .WithRequired       (e => e.Group)
                .HasForeignKey      (e => e.FK_Group);
        }
    }
}
