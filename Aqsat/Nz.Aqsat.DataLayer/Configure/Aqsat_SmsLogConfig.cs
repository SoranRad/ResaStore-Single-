using Nz.Aqsat.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Aqsat.DataLayer.Configure
{
	public class Aqsat_SmsLogConfig :  EntityTypeConfiguration<Aqsat_SmsLog> 
	{
		public Aqsat_SmsLogConfig()
		{
			this.ToTable                    ("Aqsat.tbl_"+nameof(Aqsat_SmsLog));

			this.HasKey                     (x => x.ID);
			this.Property                   (x => x.ID)
				.HasDatabaseGeneratedOption (DatabaseGeneratedOption.Identity);


		}
	}
}
