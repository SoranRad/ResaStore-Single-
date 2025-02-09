using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Models;

namespace NZ.General.DataLayer.Configure
{
    public class ActivationConfig: EntityTypeConfiguration<Activation>
    {
        public ActivationConfig()
        {
            ToTable("General.tbl_Config");
        }
    }
}
