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
	public class Aqsat_Riz_Config : EntityTypeConfiguration<Aqsat_Riz>
	{
		public Aqsat_Riz_Config()
		{
			this.ToTable                    ("Aqsat.tbl_"+nameof(Aqsat_Riz));

			this.HasKey                     (x => x.ID);
			this.Property                   (x => x.ID)
				.HasDatabaseGeneratedOption (DatabaseGeneratedOption.Identity);

			this
				.Property						(x => x.tarixQest)
				.HasColumnType					("Date");
			
			this
				.Property						(x => x.mablaqQest)
				.HasPrecision					(18,0);


			this
				.HasMany						(x => x.AqsatSmsLogs)
				.WithRequired					(x => x.AqsatRiz)
				.HasForeignKey					(x => x.FK_Riz)
				.WillCascadeOnDelete			(true);

		}
	}
}
