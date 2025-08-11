using Nz.Aqsat.Model.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Nz.Aqsat.DataLayer.Configure
{
	public class Aqsat_Kind_Config :  EntityTypeConfiguration<Aqsat_Kind> 
	{
		public Aqsat_Kind_Config()
		{
			this.ToTable                    ("Aqsat.tbl_"+nameof(Aqsat_Kind));

			this.HasKey                     (x => x.ID);
			this.Property                   (x => x.ID)
				.HasDatabaseGeneratedOption (DatabaseGeneratedOption.Identity);

			this
				.Property                   (e => e.Title)
				.HasMaxLength               (250)
				.IsFixedLength              ();
		}
	}
}
