namespace SmsBan.DataLayer.Migrations
{
	using System;
	using System.Data.Entity;
	using System.Data.Entity.Migrations;
	using System.Linq;

	/// <summary>
	/// تنظیمات مایگریشن ماژول ارسال پیامک.
	/// چون چند کانتکست دیگر روی همین بانک اطلاعاتی کار می‌کنند:
	///   - مایگریشن خودکار غیرفعال است
	///   - حذف داده در مایگریشن خودکار مجاز نیست
	///   - ContextKey مستقل انتخاب شده تا تاریخچه‌ی مایگریشن این ماژول
	///     با سایر ماژول‌ها تداخل پیدا نکند
	/// </summary>
	internal sealed class Configuration : DbMigrationsConfiguration<SmsBanContext>
	{
		public Configuration()
		{
			AutomaticMigrationsEnabled			= false;
			AutomaticMigrationDataLossAllowed	= false;

			// معادل nameof("SmsBan")؛ زیرا nameof با رشته‌ی مستقیم کامپایل نمی‌شود (CS8081).
			ContextKey							= "SmsBan";
		}

		protected override void Seed(SmsBanContext context)
		{
			// داده‌ی اولیه‌ای برای درج وجود ندارد.
		}
	}
}
