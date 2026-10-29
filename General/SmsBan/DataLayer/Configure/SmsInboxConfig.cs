using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using SmsBan.Model;

namespace SmsBan.DataLayer.Configure
{
	public class SmsInboxConfig : EntityTypeConfiguration<SmsInbox>
	{
		public SmsInboxConfig()
		{
			this.ToTable					("SmsBan.tbl_" + nameof(SmsInbox));

			this.HasKey						(x => x.ID);
			this.Property					(x => x.ID)
				.HasDatabaseGeneratedOption	(DatabaseGeneratedOption.Identity);

			this.Property					(x => x.SmsCenter).HasMaxLength(32).IsUnicode(true);
			this.Property					(x => x.SmsType).HasMaxLength(64).IsUnicode(true);
			this.Property					(x => x.TelNumber).HasMaxLength(32).IsUnicode(true);
			this.Property					(x => x.TimeStamp).HasMaxLength(32).IsUnicode(true);
			this.Property					(x => x.Discharge).HasMaxLength(32).IsUnicode(true);
			this.Property					(x => x.SmsText).IsUnicode(true);
			this.Property					(x => x.TPPid).HasMaxLength(8).IsUnicode(true);
			this.Property					(x => x.TPDcs).HasMaxLength(8).IsUnicode(true);
			this.Property					(x => x.TPVp).HasMaxLength(8).IsUnicode(true);
			this.Property					(x => x.TPSt).HasMaxLength(8).IsUnicode(true);
			this.Property					(x => x.SReference).HasMaxLength(64).IsUnicode(true);
			this.Property					(x => x.DeviceName).HasMaxLength(128).IsUnicode(true);
			this.Property					(x => x.SimId).HasMaxLength(64).IsUnicode(true);
			this.Property					(x => x.DedupHash).HasMaxLength(64).IsUnicode(false);
			this.Property					(x => x.ReceivedAtShamsi).HasMaxLength(19).IsUnicode(false);
			this.Property					(x => x.ReceivedParts).HasMaxLength(512).IsUnicode(false);

			// جلوگیری از ذخیره‌ی پیامک تکراری در سطح بانک اطلاعاتی.
			this.HasIndex					(x => x.DedupHash).IsUnique();

			this.HasIndex					(x => x.ReceivedAt);
		}
	}
}
