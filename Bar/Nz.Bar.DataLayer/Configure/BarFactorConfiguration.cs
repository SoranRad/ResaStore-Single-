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
				.HasColumnType					("decimal(18,0)");



			this
				.HasOptional					(x => x.Car)
				.WithMany						(x=>x.BarFactors)
				.HasForeignKey					(x => x.FK_Car)
				;


			//this
			//	.HasRequired					(x => x.Kala)
			//	.WithMany						()
			//	.Map(c=>c.)
			//	.HasForeignKey					(x => x.FK_Kala)
			//	;

			//this
			//	.HasRequired					(x => x.People)
			//	.WithMany						()
			//	.HasForeignKey					(x => x.FK_People)
			//	;

			//this
			//	.HasRequired					(x => x.Year)
			//	.WithMany						()
			//	.HasForeignKey					(x => x.FK_Salmali)
			//	;

			//this
			//	.HasRequired					(x => x.UserAdd)
			//	.WithMany						()
			//	.HasForeignKey					(x => x.FK_User_Add)
			//	;

			//this
			//	.HasOptional					(x => x.UserEdit)
			//	.WithMany						()
			//	.HasForeignKey					(x => x.FK_User_Edit)
			//	;

		}
	}
}
