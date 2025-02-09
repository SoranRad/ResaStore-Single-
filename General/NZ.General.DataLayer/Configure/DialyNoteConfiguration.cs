using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Models;

namespace NZ.General.DataLayer.Configure
{
    public class DialyNoteConfiguration : EntityTypeConfiguration<DailyNote>
    {
        public DialyNoteConfiguration()
        {
            this.ToTable("General.tbl_DailyNote");
        }
    }
}
