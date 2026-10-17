using System.Data.Common;
using System.Data.Entity;
using SmsBan.Model;

namespace SmsBan.DataLayer
{
	/// <summary>
	/// کانتکست اختصاصی ماژول ارسال پیامک.
	/// از آنجا که چند کانتکست دیگر نیز از همین بانک اطلاعاتی استفاده می‌کنند،
	/// تنظیمات مایگریشن جداگانه (ContextKey = "SmsBan") اعمال شده است.
	/// </summary>
	public partial class SmsBanContext : DbContext
	{
		public SmsBanContext(DbConnection connection, bool contextOwnsConnection)
			: base(connection, contextOwnsConnection)
		{
			Database.SetInitializer(new MigrateDatabaseToLatestVersion<SmsBanContext, Migrations.Configuration>(true));
			this.Database.Initialize(false);
			this.Configuration.LazyLoadingEnabled = false;
		}

		public virtual DbSet<SmsOutbox>			tbl_SmsOutbox		{ get; set; }

		public virtual DbSet<SmsArchive>		tbl_SmsArchive		{ get; set; }

		public virtual DbSet<SmsInbox>			tbl_SmsInbox		{ get; set; }

		public virtual DbSet<SmsRateCounter>	tbl_SmsRateCounter	{ get; set; }

		public virtual DbSet<SmsWorkerState>	tbl_SmsWorkerState	{ get; set; }


		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.AddFromAssembly(GetType().Assembly);
		}
	}
}
