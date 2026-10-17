using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using SmsBan.Model;

namespace SmsBan.DataLayer.Configure
{
	public class SmsWorkerStateConfig : EntityTypeConfiguration<SmsWorkerState>
	{
		public SmsWorkerStateConfig()
		{
			this.ToTable					("SmsBan.tbl_" + nameof(SmsWorkerState));

			this.HasKey						(x => x.ID);
			this.Property					(x => x.ID)
				.HasDatabaseGeneratedOption	(DatabaseGeneratedOption.None);

			this.Property					(x => x.PausedAtShamsi).HasMaxLength(19).IsUnicode(false);
			this.Property					(x => x.PausedBy).HasMaxLength(128).IsUnicode(true);
			this.Property					(x => x.ModemDevice).HasMaxLength(128).IsUnicode(true);
			this.Property					(x => x.OwnerID).HasMaxLength(128).IsUnicode(true);
		}
	}
}
