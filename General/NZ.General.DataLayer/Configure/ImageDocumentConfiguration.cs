using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Models;

namespace NZ.General.DataLayer.Configure
{
    public class ImageDocumentConfiguration : EntityTypeConfiguration<ImageDocument>
    {
        public ImageDocumentConfiguration()
        {
            this.ToTable            ("General.tbl_Image");

            //this
            //    .HasMany            (e => e.PeopleSign)
            //    .WithOptional       (e => e.ImageSign)
            //    .HasForeignKey      (e => e.FK_Image_Emza);

            //this
            //    .HasMany            (e => e.PeoplePicture)
            //    .WithOptional       (e => e.ImagePicture)
            //    .HasForeignKey      (e => e.FK_Image_Tasvir);

            //this
            //    .HasMany            (e => e.PeopleWarranty)
            //    .WithOptional       (e => e.ImageWarranty)
            //    .HasForeignKey      (e => e.FK_Image_Zemanat);
        }
    }
}
