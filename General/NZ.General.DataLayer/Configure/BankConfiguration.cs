using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Models;

namespace NZ.General.DataLayer.Configure
{
    public class BankConfiguration : EntityTypeConfiguration<Bank>
    {
        public BankConfiguration()
        {
            this.ToTable        ("Base.tbl_Bank");

            this
               .Property        (e => e.title)
               .IsFixedLength   ();

            this
                .HasMany        (e => e.Peoples)
                .WithOptional   (e => e.Bank)
                .HasForeignKey  (e => e.FK_Bank);

        }
    }
}
