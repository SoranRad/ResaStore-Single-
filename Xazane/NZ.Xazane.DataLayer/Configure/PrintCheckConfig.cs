using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NZ.Xazane.Model.Models;

namespace NZ.Xazane.DataLayer.Configure
{
   public class PrintCheckConfig:EntityTypeConfiguration<PrintCheck>
    {
        public PrintCheckConfig()
        {
            this.ToTable        ("Xazane.tbl_Print_Cheque");
        }
    }
}
