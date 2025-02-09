using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Xazane.Model;
using ShareLib.Models;

namespace NZ.Xazane.DataLayer.Configure
{
    public class AccountConfiguration : EntityTypeConfiguration<Accounts>
    {
        public AccountConfiguration         ()
        {
            this.ToTable                    ("Xazane.tbl_Hesab_Xazaneh");


            this
                .Property                   (e => e.title)
                .IsFixedLength              ();

            this
                .Property                   (e => e.mojudi_avalie)
                .HasPrecision               (18, 0);

            this
                .Property                   (e => e.shobe)
                .IsFixedLength              ();

            this
                .Property                   (e => e.Shomare_Hesab)
                .IsFixedLength              ();

            this
                .Property                   (e => e.Kind_Hesab)
                .IsFixedLength              ();

            this
                .HasMany        (e => e.Cheque_Book) // Account
                .WithRequired   (e => e.Account) // ChequwBook
                .HasForeignKey  (e => e.FK_Xazaneh);

            this.HasMany        (x => x.ChequeOperations)
                .WithOptional   (x => x.PayAccount)
                .HasForeignKey  (x => x.FK_Hesab_Pardaxtani);

            this.HasMany        (x => x.DebitPayBoxes)
                .WithOptional   (x => x.DebitAccount)
                .HasForeignKey  (x => x.FK_Xazaneh_Bad);

            this.HasMany        (x => x.CreditPayBoxes)
                .WithOptional   (x => x.CreditAccount)
                .HasForeignKey  (x => x.FK_Xazaneh_Bas);

            this.HasMany        (x => x.ChequeStateAccount)
                .WithOptional   (x => x.StateAccount)
                .HasForeignKey  (x => x.FK_Xazaneh_Vaziat);
        }
    }
}
