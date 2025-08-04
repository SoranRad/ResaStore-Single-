using Nz.Bar.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Bar.DataLayer.Configure
{
	public class BarFactorConfiguration :  EntityTypeConfiguration<BarFactor>
	{
		public BarFactorConfiguration()
		{
			this.ToTable("Bar.tbl_"+nameof(BarFactor));

			this.HasKey                         (x => x.ID);

			this.Property                       (x => x.ID)
				.HasDatabaseGeneratedOption     (DatabaseGeneratedOption.Identity);

			this
				.Property						(x => x.Tarikh)
				.HasColumnType					("Date");

			this
				.Property						(x => x.Tozihat)
				.IsOptional						();

			this
				.Property						(x => x.VaznPorMachine)
				.HasPrecision					(18,0);

			this
				.Property						(x => x.VaznKHaliMachine)
				.HasPrecision					(18,0);

			this
				.Property						(x => x.TedadBox)
				.HasPrecision					(18,0);

			this
				.Property						(x => x.VaznKhaliBox)
				.HasPrecision					(18,2);

			this
				.Property						(x => x.VaznOft)
				.HasPrecision					(18,0);

			this
				.Property						(x => x.VaznKHales)
				.HasPrecision					(18,0);

			this
				.HasOptional					(x => x.Car)
				.WithMany						(x=>x.BarFactors)
				.HasForeignKey					(x => x.FK_Car)
				;
		}
	}
}
