using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Xazane.Model;

namespace NZ.Xazane.DataLayer.Configure
{
    public class ChequeBookConfiguration : EntityTypeConfiguration<ChequeBook>
    {
        public ChequeBookConfiguration()
        {
            this.ToTable            ("Xazane.tbl_Daste_Chque");

            this
                .Property           (e => e.Sharh)
                .IsFixedLength      ();

            this
                .HasMany            (e => e.ChequeBookDetails)
                .WithRequired       (e => e.ChequeBooks)
                .HasForeignKey      (e => e.FK_Dasteh_Cheque);

           
        }
    }
}
