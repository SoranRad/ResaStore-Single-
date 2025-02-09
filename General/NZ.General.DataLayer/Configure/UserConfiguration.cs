using ShareLib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ.General.DataLayer.Configure
{
    public class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            this.ToTable                    ("General.tbl_User")
                .HasKey                     (x=>x.ID)
                ;

            this.Property                   (x => x.ID)
                .HasDatabaseGeneratedOption (DatabaseGeneratedOption.Identity);

            this
                .Property               (e => e.title)
                .IsFixedLength          ();

            this
                .Property               (e => e.user_name)
                .IsFixedLength          ();

            this
                .Property               (e => e.password)
                .IsFixedLength          ();

            this
                .Property               (e => e.default_password)
                .IsFixedLength          ();

            this
                .Property               (e => e.dastressi)
                .IsUnicode              (false);

            this
                .HasMany                (e => e.DialogsEdit)
                .WithRequired           (e => e.UserInsert)
                .HasForeignKey          (e => e.FK_User_Add)
                .WillCascadeOnDelete    (false);

            this
                .HasMany                (e => e.DialogsEdit)
                .WithOptional           (e => e.UserEdit)
                .HasForeignKey          (e => e.FK_User_Edit);

        }
    }
}
