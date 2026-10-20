using ShareLib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NZ.General.DataLayer.Configure
{
    public class SmsTemplateConfiguration : EntityTypeConfiguration<SmsTemplate>
    {
        public SmsTemplateConfiguration()
        {
            this.ToTable                    ("General.tbl_SmsTemplate")
                .HasKey                     (x=>x.Id)
                ;

            this.Property                   (x => x.Id)
                .HasDatabaseGeneratedOption (DatabaseGeneratedOption.Identity);

            this
                .Property               (e => e.Message)
                .IsFixedLength          ()
                .HasMaxLength           (700)
                ;
        }
    }
}
