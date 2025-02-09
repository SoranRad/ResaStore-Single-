using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Models;

namespace NZ.General.DataLayer.Configure
{
    public class DialogConfiguration : EntityTypeConfiguration<Dialog>
    {
        public DialogConfiguration()
        {
            this
                .ToTable        ("General.tbl_Mokaleme_Ashxas");

            this
                .Property       (e => e.saat)
                .IsFixedLength  ();

            this
                .Property       (e => e.userTell)
                .IsFixedLength  ();

           this
                .Property       (e => e.shaxsTell)
                .IsFixedLength  ();
        }
    }
}
