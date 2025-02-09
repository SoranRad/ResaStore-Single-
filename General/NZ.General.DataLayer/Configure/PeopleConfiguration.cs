using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Models;

namespace NZ.General.DataLayer.Configure
{
    public  class PeopleConfiguration : EntityTypeConfiguration<People>
    {
        public PeopleConfiguration()
        {
            this.ToTable        ("Base.tbl_Ashxas");

           
            this
                .Property       (e => e.namePedar)
                .IsFixedLength  ();

            this
                .Property       (e => e.codeMeli)
                .IsFixedLength  ();

            this
                .Property       (e => e.codePosti)
                .IsFixedLength  ();

            this
                .Property       (e => e.codeEqtesadi)
                .IsFixedLength  ();

            this
                .Property       (e => e.tel)
                .IsFixedLength  ();

            this
                .Property       (e => e.mobile)
                .IsFixedLength  ();

            this
                .Property       (e => e.fax)
                .IsFixedLength  ();

            this
                .Property(e => e.addressHome)
                .IsFixedLength();

            this
                .Property(e => e.telDowom)
                .IsFixedLength();

            this
                .Property(e => e.mobDowom)
                .IsFixedLength();

            this
                .Property(e => e.addresswork)
                .IsFixedLength();

            this
                .Property(e => e.shomareHesab)
                .IsFixedLength();

            this
                .Property(e => e.shomareShenasname)
                .IsFixedLength();
            this
                .Property(e => e.BlockMablaq)
                .HasPrecision(18, 0);

            this
                .Property(e => e.Sarmaye_Avalie)
                .HasPrecision(18, 0);

            this
                .Property(e => e.Sarmaye_Kol)
                .HasPrecision(18, 0);

            this
                .Property(e => e.Sarmaye_Darsad)
                .HasPrecision(4, 2);

            this
                .Property(e => e.Plak)
                .HasMaxLength(20)
                .IsFixedLength();
                

            this
                .Property(e => e.Sood_Darsad)
                .HasPrecision(4, 2);

            this
                .HasMany        (e => e.Dialogs)
                .WithRequired   (e => e.Customer)
                .HasForeignKey  (e => e.FK_Shaxs_ID)
                .WillCascadeOnDelete(false);

            this.HasOptional    (e => e.ImagePicture)
                .WithMany       (e => e.PeoplePicture)
                .HasForeignKey  (e => e.FK_Image_Tasvir);

            this.HasOptional    (e => e.ImageSign)
                .WithMany       (e => e.PeopleSign)
                .HasForeignKey  (e => e.FK_Image_Emza);

            this.HasOptional    (e => e.ImageWarranty)
                .WithMany       (e => e.PeopleWarranty)
                .HasForeignKey  (e => e.FK_Image_Zemanat);
        }
    }
}
