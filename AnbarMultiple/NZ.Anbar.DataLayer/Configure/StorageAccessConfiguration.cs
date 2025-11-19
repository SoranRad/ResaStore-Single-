using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Anbar.Model;

namespace NZ.Anbar.DataLayer.Configure
{
    public class StorageAccessConfiguration : EntityTypeConfiguration<StorageAccess>
    {
        public StorageAccessConfiguration()
        {
            this.ToTable("Base.tbl_Base_Anbar_Dastresi");

            //this
            //    .HasRequired    (x => x.Storage)
            //    .WithMany       (x => x.UserAccessList)
            //    .HasForeignKey  (x => new
            //                            {
            //                                x.FK_Salmali,
            //                                x.FK_Anbar
            //                            });
        }
    }
}
