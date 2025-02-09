using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Models;

namespace NZ.General.DataLayer.Configure
{
    public class StateConfiguration :EntityTypeConfiguration<State>
    {
        public StateConfiguration()
        {
            this.ToTable("Base.tbl_Ostan");
            this
               .Property                (e => e.title)
               .IsFixedLength           ();

            this
                .HasMany                (e => e.City)
                .WithRequired           (e => e.State)
                .HasForeignKey          (e => e.FK_Ostan)
                .WillCascadeOnDelete    (false);
        }

    }
}
