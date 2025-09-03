using Nz.Aqsat.Model.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;


namespace Nz.Aqsat.DataLayer.Configure
{
	public class Aqsat_Main_Config : EntityTypeConfiguration<Aqsat_Main>
	{
		public Aqsat_Main_Config()
		{
			this.ToTable                    ("Aqsat.tbl_"+nameof(Aqsat_Main));

			this.HasKey                     (x => x.ID);
			this.Property                   (x => x.ID)
				.HasDatabaseGeneratedOption (DatabaseGeneratedOption.Identity);

			this
				.Property						(x => x.Tarikh)
				.HasColumnType					("Date");

			this
				.Property						(x => x.StartDate)
				.HasColumnType					("Date");

			this
				.Property						(x => x.MablaqAqsat)
				.HasPrecision					(18,0);

			this
				.Property						(x => x.MablaqPishpardaxt)
				.HasPrecision					(18,0);

			this
				.Property						(x => x.MablaqMandeAqsat)
				.HasPrecision					(18,0);

			this
				.Property						(x => x.MablaqSoud)
				.HasPrecision					(18,0);

			this
				.Property						(x => x.MablaqMandeAqsat)
				.HasPrecision					(18,0);

			this
				.Property						(x => x.DarsadSoud)
				.HasPrecision					(18,2);

			this
				.Property						(x => x.MablaqSoud)
				.HasPrecision					(18,0);

			this
				.Property						(x => x.MablaqFinalAqsat)
				.HasPrecision					(18,0);

			this
				.Property						(x => x.MablaqSoud)
				.HasPrecision					(18,0);


			this
				.HasRequired					(x => x.AqsatKind)
				.WithMany						(x => x.AqsatMains)
				.HasForeignKey					(x => x.FK_Noh);

			this
				.HasMany						(x => x.AqsatRizs)
				.WithRequired					(x => x.AqsatMain)
				.HasForeignKey					(x => x.FK_Main)
				.WillCascadeOnDelete			(true)
				;

		}
	}
}
