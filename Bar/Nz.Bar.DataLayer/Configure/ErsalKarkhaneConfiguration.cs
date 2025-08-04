using Nz.Bar.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nz.Bar.DataLayer.Configure
{
	public class ErsalKarkhaneConfiguration :  EntityTypeConfiguration<ErsalKarkhane>
	{
		public ErsalKarkhaneConfiguration()
		{
			this.ToTable("Bar.tbl_"+nameof(ErsalKarkhane));

			this.HasKey                         (x => x.ID);

			//this.Property                       (x => x.ID)
			//	.HasDatabaseGeneratedOption     (DatabaseGeneratedOption.Identity)
			//	.HasColumnAnnotation			("Index", new IndexAnnotation(
			//										new IndexAttribute("IX_ErsalKarkhane_ID_Index", 2) { IsClustered = false,IsUnique = true,Order = 2}
			//									));

			this.Property						(o => o.FK_Salmali)
				.HasColumnAnnotation			("Index", new IndexAnnotation(
													new IndexAttribute("IX_ErsalKarkhane_FK_Salmali", 1) { IsClustered = true, IsUnique = false, Order = 1}
												));

			this
				.Property						(x => x.Tarikh)
				.HasColumnType					("Date");

			this
				.Property						(x => x.Tozihat)
				.IsOptional						();

			this
				.Property						(x => x.VaznNaKhales)
				.HasPrecision					(18,0);

			this
				.Property						(x => x.VaznKHali)
				.HasPrecision					(18,0);

			this
				.Property						(x => x.VaznOft)
				.HasPrecision					(18,0);

			this
				.Property						(x => x.DarsadOft)
				.HasPrecision					(10,2);

			this
				.Property						(x => x.VaznKHales)
				.HasPrecision					(18,0);


			this
				.Property						(x => x.Nerkh)
				.HasPrecision					(18,0);

			this
				.Property						(x => x.Mablaq)
				.HasPrecision					(18,0);

			this
				.Property						(x => x.MablaqKeraye)
				.HasPrecision					(18,0);
			

			this
				.HasOptional					(x => x.Car)
				.WithMany						(x=>x.ErsalKarkhanes)
				.HasForeignKey					(x => x.FK_Car)
				;

		}
	}
}
