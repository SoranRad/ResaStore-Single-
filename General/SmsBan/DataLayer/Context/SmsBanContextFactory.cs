using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;

namespace SmsBan.DataLayer.Context
{
	/// <summary>
	/// سازنده‌ی کانتکست برای ابزارهای مایگریشن (Add-Migration / Update-Database).
	/// چون ابزار طراحی راهی برای دریافت رشته‌ی اتصال ندارد، از
	/// <see cref="ConnectionString"/> استفاده می‌کند؛ در زمان اجرا این مقدار
	/// توسط <c>SmsBanOptions.ConnectionString</c> بازنویسی می‌شود.
	/// </summary>
	public class SmsBanContextFactory : IDbContextFactory<SmsBanContext>
	{
		/// <summary>
		/// رشته‌ی اتصال پیش‌فرض برای ابزار مایگریشن.
		/// همین مقداری است که سایر ماژول‌های پروژه استفاده می‌کنند.
		/// </summary>
		public static string ConnectionString { get; set; } =
			@"Server=.\sqlentr;Database=DB_NzResaaStore;User Id=sa;Password=123456;" +
			@"MultipleActiveResultSets=True;Persist Security Info=True;App=NzResaaStore;";

		public SmsBanContext Create()
		{
			var connection = new SqlConnection(ConnectionString);

			return new SmsBanContext(connection, true);
		}
	}
}
