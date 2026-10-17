using System;
using System.Data.Entity;
using System.Linq;
using SmsBan.DataLayer;
using SmsBan.Model;

namespace SmsBan.Core
{
	/// <summary>
	/// مدیریت وضعیت مشترک ماژول بین چند کامپیوتر:
	///   - توقف/ادامه‌ی ارسال
	///   - مالکیت (lease) کامپیوتری که ارسال را انجام می‌دهد
	///
	/// مالکیت مانع می‌شود دو نمونه به‌طور هم‌زمان یک پیامک را بردارند و بفرستند.
	/// </summary>
	public static class SmsWorkerStateService
	{
		#region Logging
		private static readonly log4net.ILog log =
			log4net
				.LogManager
				.GetLogger
				(System.Reflection
					.MethodBase
					.GetCurrentMethod()
					.DeclaringType);
		#endregion

		private const int StateID = 1;

		/// <summary>خواندن وضعیت؛ در صورت نبودن رکورد null برمی‌گرداند.</summary>
		public static SmsWorkerState Get(SmsBanContext db)
		{
			return db.tbl_SmsWorkerState.AsNoTracking().FirstOrDefault(x => x.ID == StateID);
		}

		/// <summary>
		/// خواندن وضعیت و ساخت رکورد در صورت نبودن.
		/// در برابر درج هم‌زمان چند نمونه مقاوم است.
		/// </summary>
		public static SmsWorkerState GetOrCreate(SmsBanContext db)
		{
			var state = db.tbl_SmsWorkerState.FirstOrDefault(x => x.ID == StateID);

			if (state != null)
				return state;

			state = new SmsWorkerState
			{
				ID			= StateID,
				IsPaused	= false,
				UpdatedAt	= DateTime.Now
			};

			db.tbl_SmsWorkerState.Add(state);

			try
			{
				db.SaveChanges();
				return state;
			}
			catch (Exception ex)
			{
				// نمونه‌ی دیگری زودتر رکورد را ساخته است.
				log.Warn("ساخت رکورد وضعیت با خطا مواجه شد؛ تلاش برای خواندن مجدد.", ex);

				db.Entry(state).State = EntityState.Detached;

				return db.tbl_SmsWorkerState.FirstOrDefault(x => x.ID == StateID);
			}
		}

		/// <summary>
		/// تلاش برای گرفتن مالکیت ارسال.
		/// در صورتی که مالک فعلی منقضی شده باشد یا خود ما باشیم، مالکیت گرفته می‌شود.
		/// این به‌روزرسانی به‌صورت اتمیک در بانک انجام می‌شود.
		/// </summary>
		public static bool TryAcquireLease(SmsBanContext db, string ownerId, int leaseSeconds)
		{
			GetOrCreate(db);

			var now				= DateTime.Now;
			var expiration		= now.AddSeconds(-Math.Max(10, leaseSeconds));

			const string sql =
				"UPDATE SmsBan.tbl_SmsWorkerState " +
				"   SET OwnerID = @p0, Heartbeat = @p1, UpdatedAt = @p1 " +
				" WHERE ID = @p2 " +
				"   AND (OwnerID IS NULL OR OwnerID = '' OR OwnerID = @p0 OR Heartbeat IS NULL OR Heartbeat < @p3)";

			int affected = db.Database.ExecuteSqlCommand(sql, ownerId, now, StateID, expiration);

			return affected > 0;
		}

		/// <summary>به‌روزرسانی ضربان مالکیت.</summary>
		public static void Touch(SmsBanContext db, string ownerId)
		{
			var now = DateTime.Now;

			db.Database.ExecuteSqlCommand(
				"UPDATE SmsBan.tbl_SmsWorkerState SET Heartbeat = @p0, UpdatedAt = @p0 " +
				" WHERE ID = @p1 AND OwnerID = @p2",
				now, StateID, ownerId);
		}

		/// <summary>آزادسازی مالکیت هنگام خاموش شدن.</summary>
		public static void Release(SmsBanContext db, string ownerId)
		{
			db.Database.ExecuteSqlCommand(
				"UPDATE SmsBan.tbl_SmsWorkerState SET OwnerID = NULL, Heartbeat = NULL, UpdatedAt = @p0 " +
				" WHERE ID = @p1 AND OwnerID = @p2",
				DateTime.Now, StateID, ownerId);
		}

		/// <summary>ثبت مشخصات مودم شناسایی‌شده برای نمایش در رابط کاربری.</summary>
		public static void SetModemDevice(SmsBanContext db, string device)
		{
			var state = GetOrCreate(db);

			if (state == null || state.ModemDevice == device)
				return;

			state.ModemDevice	= device;
			state.UpdatedAt		= DateTime.Now;

			db.SaveChanges();
		}
	}
}
