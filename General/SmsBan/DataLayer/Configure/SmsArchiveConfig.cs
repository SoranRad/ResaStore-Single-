using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using SmsBan.Model;

namespace SmsBan.DataLayer.Configure
{
	public class SmsArchiveConfig : EntityTypeConfiguration<SmsArchive>
	{
		public SmsArchiveConfig()
		{
			this.ToTable					("SmsBan.tbl_" + nameof(SmsArchive));

			this.HasKey						(x => x.ID);
			this.Property					(x => x.ID)
				.HasDatabaseGeneratedOption	(DatabaseGeneratedOption.Identity);

			this.Property					(x => x.SortOrder).HasPrecision(18, 6);
			this.Property					(x => x.PhoneNumber).HasMaxLength(32).IsUnicode(true);
			this.Property					(x => x.MessageText).IsUnicode(true);
			this.Property					(x => x.ErrorMessage).HasMaxLength(1024).IsUnicode(true);
			this.Property					(x => x.SmsReference).HasMaxLength(64).IsUnicode(true);
			this.Property					(x => x.DeliveredAtShamsi).HasMaxLength(19).IsUnicode(false);
			this.Property					(x => x.CreatedAtShamsi).HasMaxLength(19).IsUnicode(false);
			this.Property					(x => x.SentAtShamsi).HasMaxLength(19).IsUnicode(false);
			this.Property					(x => x.ModemDevice).HasMaxLength(128).IsUnicode(true);
			this.Property					(x => x.EnqueuedBy).HasMaxLength(128).IsUnicode(true);
			this.Property					(x => x.SentBy).HasMaxLength(128).IsUnicode(true);
			this.Property					(x => x.SmsCenter).HasMaxLength(32).IsUnicode(true);

			// محاسبه‌ی سهمیه‌ی دقیقه و روز روی همین ستون‌ها انجام می‌شود.
			this.HasIndex					(x => new { x.Status, x.SentAt });
			this.HasIndex					(x => x.SentAt);
		}
	}
}
