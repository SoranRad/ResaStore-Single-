using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Xazane.Model;

namespace NZ.Xazane.DataLayer.Configure
{
    public class ChequeBookDetailConfiguration : EntityTypeConfiguration<ChequeBookDetail>
    {
        public ChequeBookDetailConfiguration()
        {
            this.ToTable        ("Xazane.tbl_Daste_Cheque_Riz");

            this
                .Property       (e => e.Sharh)
                .IsFixedLength  ();

            this
                .HasMany(x => x.ChequeOP)
                .WithRequired(x => x.ChequeBookDetail)
                .HasForeignKey(x => x.FK_Daste_Cheque);

        }
    }
}
