using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Anbar.Model;

namespace NZ.Anbar.DataLayer.Configure
{
    public class StorageConfiguration : EntityTypeConfiguration<Storage>
    {
        public StorageConfiguration()
        {
            this.ToTable("Base.tbl_Base_Anbar");

            //this
            //    .(x => new { x.FK_Salmali,x.Code});

            this
                .Property(e => e.Title)
                .IsFixedLength();
            
        }
    }
}
