using System.Data.SqlClient;

namespace SmsBan.DataLayer.Context
{
	/// <summary>
	/// ساخت کانتکست از رشته‌ی اتصال.
	/// اتصال در اختیار کانتکست قرار می‌گیرد و با Dispose آن بسته می‌شود.
	/// </summary>
	public static class SmsBanDb
	{
		public static SmsBanContext Create(string connectionString)
		{
			var connection = new SqlConnection(connectionString);
			return new SmsBanContext(connection, true);
		}
	}
}
