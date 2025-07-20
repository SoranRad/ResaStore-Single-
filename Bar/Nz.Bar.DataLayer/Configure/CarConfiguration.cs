using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Nz.Bar.Model.Models;


namespace Nz.Bar.DataLayer.Configure
{
	public class CarConfiguration : EntityTypeConfiguration<Car>
	{
		public CarConfiguration()
		{
			this.ToTable("Bar.tbl_"+nameof(Car));

			this.HasKey                         (x => x.ID);

			this.Property                       (x => x.ID)
				.HasDatabaseGeneratedOption     (DatabaseGeneratedOption.Identity);

			this
				.HasRequired					(x => x.People)
				.WithMany						()
				.HasForeignKey					(x => x.FK_People)
				;

		}
	}
}
