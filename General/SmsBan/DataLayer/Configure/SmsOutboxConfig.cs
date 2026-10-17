using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using SmsBan.Model;

namespace SmsBan.DataLayer.Configure
{
	public class SmsOutboxConfig : EntityTypeConfiguration<SmsOutbox>
	{
		public SmsOutboxConfig()
		{
			this.ToTable					("SmsBan.tbl_" + nameof(SmsOutbox));

			this.HasKey						(x => x.ID);
			this.Property					(x => x.ID)
				.HasDatabaseGeneratedOption	(DatabaseGeneratedOption.Identity);

			this.Property					(x => x.SortOrder).HasPrecision(18, 6);
			this.Property					(x => x.PhoneNumber).HasMaxLength(32).IsUnicode(true);
			this.Property					(x => x.MessageText).IsUnicode(true);
			this.Property					(x => x.LastError).HasMaxLength(1024).IsUnicode(true);
			this.Property					(x => x.CreatedAtShamsi).HasMaxLength(19).IsUnicode(false);
			this.Property					(x => x.EnqueuedBy).HasMaxLength(128).IsUnicode(true);
			this.Property					(x => x.LockedBy).HasMaxLength(128).IsUnicode(true);
			this.Property					(x => x.LockedAtShamsi).HasMaxLength(19).IsUnicode(false);

			// واکشی پیامک بعدی همیشه با فیلتر وضعیت و مرتب‌سازی بر اساس SortOrder انجام می‌شود.
			this.HasIndex					(x => new { x.Status, x.SortOrder });
		}
	}
}
