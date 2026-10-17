using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using SmsBan.Model;

namespace SmsBan.DataLayer.Configure
{
	public class SmsRateCounterConfig : EntityTypeConfiguration<SmsRateCounter>
	{
		public SmsRateCounterConfig()
		{
			this.ToTable					("SmsBan.tbl_" + nameof(SmsRateCounter));

			this.HasKey						(x => x.ID);
			this.Property					(x => x.ID)
				.HasDatabaseGeneratedOption	(DatabaseGeneratedOption.Identity);

			this.Property					(x => x.PeriodKey).HasMaxLength(20).IsUnicode(false);
			this.Property					(x => x.PeriodKeyShamsi).HasMaxLength(20).IsUnicode(false);
			this.Property					(x => x.PeriodStartShamsi).HasMaxLength(19).IsUnicode(false);

			// هر بازه فقط یک رکورد شمارنده دارد.
			this.HasIndex					(x => new { x.PeriodType, x.PeriodKey }).IsUnique();
		}
	}
}
