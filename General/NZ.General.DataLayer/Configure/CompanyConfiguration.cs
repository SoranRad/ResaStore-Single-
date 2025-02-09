using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Models;

namespace NZ.General.DataLayer.Configure
{
    public class CompanyConfiguration : EntityTypeConfiguration<Company>
    {
        public CompanyConfiguration()
        {
            this.ToTable("General.tbl_Info");

            this
                .Property(e => e.modir)
                .IsFixedLength();

            this
                .Property(e => e.tel)
                .IsFixedLength();

            this
                .Property(e => e.mobile)
                .IsFixedLength();

            this
                .Property(e => e.fax)
                .IsFixedLength();

            this
                .Property(e => e.code_posti)
                .IsFixedLength();

            this
                .Property(e => e.code_melli)
                .IsFixedLength();

            this
                .Property(e => e.code_eqtesadi)
                .IsFixedLength();

            this
                .Property(e => e.tel2)
                .IsFixedLength();

            this
                .Property(e => e.mobile2)
                .IsFixedLength();

            this
                .Property(e => e.email)
                .IsFixedLength();

            this
                .Property(e => e.website)
                .IsFixedLength();

        }
    }
}
