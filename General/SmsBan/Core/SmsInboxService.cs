using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using SmsBan.DataLayer;
using SmsBan.DataLayer.Context;
using SmsBan.Modem;
using SmsBan.Model;

namespace SmsBan.Core
{
	/// <summary>
	/// خواندن پیامک‌های رسیده از مودم و ذخیره‌ی آن‌ها در بانک اطلاعاتی.
	/// فقط روی کامپیوتری اجرا می‌شود که مودم به آن وصل است.
	/// پیامک تکراری ذخیره نمی‌شود.
	/// </summary>
	public class SmsInboxService
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

		private readonly SmsBanOptions	_options;
		private readonly ModemGateway	_modem;

		public SmsInboxService(SmsBanOptions options, ModemGateway modem)
		{
			if (options == null)
				throw new ArgumentNullException("options");

			if (modem == null)
				throw new ArgumentNullException("modem");

			_options	= options;
			_modem		= modem;
		}

		private SmsBanContext CreateContext()
		{
			return SmsBanDb.Create(_options.ConnectionString);
		}

		/// <summary>
		/// خواندن فوری پیامک‌های موجود. تعداد پیامک‌های تازه ذخیره‌شده برگردانده می‌شود.
		/// </summary>
		public int ReadNow()
		{
			if (!_modem.Status.Connected)
				_modem.Open();

			if (!_modem.Status.DeviceFound)
			{
				log.Warn("خواندن پیامک انجام نشد؛ مودم شناسایی نشد.");
				return 0;
			}

			var messages = new List<ModemSmsMessage>();

			try
			{
				// ابتدا بازه‌ی پیامک‌های تازه‌رسیده (سریع‌تر).
				int from, to;

				if (_modem.TryGetNewSmsRange(out from, out to) && to >= from && from > 0)
				{
					for (int index = from; index <= to; index++)
					{
						var message = _modem.Read(index);

						if (message != null)
							messages.Add(message);
					}
				}

				// سپس پیمایش کامل حافظه‌ی مودم/سیم‌کارت برای اطمینان.
				var stored = _modem.ReadAll(_options.MaxReadPerCycle);

				foreach (var message in stored)
					messages.Add(message);
			}
			catch (Exception ex)
			{
				log.Error(ex);
			}

			var saved = SaveMessages(messages);

			if (_options.DeleteAfterRead && saved > 0)
				DeleteReadFromModem(messages);

			return saved;
		}

		/// <summary>
		/// خواندن پیامک‌هایی که در حافظه‌ی سیم‌کارت یا مودم ذخیره شده‌اند.
		/// خروجی، فهرست خام خوانده‌شده است و همه در بانک نیز ذخیره می‌شوند.
		/// </summary>
		public List<ModemSmsMessage> ReadStoredFromModem()
		{
			if (!_modem.Status.Connected)
				_modem.Open();

			var list = new List<ModemSmsMessage>();

			if (!_modem.Status.DeviceFound)
				return list;

			try
			{
				list = _modem.ReadAll(_options.MaxReadPerCycle);

				SaveMessages(list);
			}
			catch (Exception ex)
			{
				log.Error(ex);
			}

			return list;
		}

		/// <summary>
		/// حذف یک پیامک از حافظه‌ی مودم/سیم‌کارت و علامت‌گذاری آن در بانک.
		/// </summary>
		public bool DeleteFromModem(int index)
		{
			bool deleted = _modem.Delete(index, ModemDeleteType.ByIndex);

			if (!deleted)
			{
				log.WarnFormat("حذف پیامک با اندیس {0} از مودم انجام نشد.", index);
				return false;
			}

			try
			{
				using (var db = CreateContext())
				{
					var rows = db.tbl_SmsInbox.Where(x => x.ModemIndex == index).ToList();

					foreach (var row in rows)
						row.IsDeletedFromModem = true;

					db.SaveChanges();
				}
			}
			catch (Exception ex)
			{
				log.Error(ex);
			}

			return true;
		}

		/// <summary>
		/// ذخیره‌ی پیامک‌ها با حذف تکراری‌ها.
		/// </summary>
		private int SaveMessages(IEnumerable<ModemSmsMessage> messages)
		{
			if (messages == null)
				return 0;

			int saved = 0;

			using (var db = CreateContext())
			{
				foreach (var message in messages)
				{
					if (message == null || string.IsNullOrEmpty(message.SmsText))
						continue;

					var hash = ComputeHash(message);

					if (db.tbl_SmsInbox.Any(x => x.DedupHash == hash))
						continue;

					var now = DateTime.Now;

					db.tbl_SmsInbox.Add(new SmsInbox
					{
						ModemIndex			= message.Index,
						SmsCenter			= message.SmsCenter,
						SmsType				= message.SmsType,
						TelNumber			= message.TelNumber,
						TimeStamp			= message.TimeStamp,
						Discharge			= message.Discharge,
						SmsText				= message.SmsText,
						TPPid				= message.TPPid,
						TPDcs				= message.TPDcs,
						TPVp				= message.TPVp,
						TPSt				= message.TPSt,
						SReference			= message.SReference,
						AllPart				= message.AllPart,
						PartNo				= message.PartNo,
						DeviceName			= _modem.Status.DeviceInfo,
						SimId				= _modem.Status.SimId,
						DedupHash			= hash,
						ReceivedAt			= now,
						ReceivedAtShamsi	= JalaliDate.ToShamsi(now),
						IsRead				= false,
						IsDeletedFromModem	= false
					});

					saved++;
				}

				try
				{
					db.SaveChanges();
				}
				catch (System.Data.Entity.Infrastructure.DbUpdateException ex)
				{
					// احتمال درج هم‌زمان همان پیامک توسط نمونه‌ی دیگر.
					log.Warn("ذخیره‌ی پیامک‌های دریافتی با تداخل مواجه شد.", ex);
					saved = 0;
				}
			}

			if (saved > 0)
				log.InfoFormat("{0} پیامک دریافتی جدید ذخیره شد.", saved);

			return saved;
		}

		/// <summary>
		/// اثر انگشت پیامک برای جلوگیری از ذخیره‌ی تکراری.
		/// ترکیب فرستنده، زمان، متن و مشخصات دستگاه.
		/// </summary>
		private string ComputeHash(ModemSmsMessage message)
		{
			var raw = string.Join("|", new[]
			{
				_modem.Status.DeviceInfo ?? string.Empty,
				_modem.Status.SimId ?? string.Empty,
				message.TelNumber ?? string.Empty,
				message.TimeStamp ?? string.Empty,
				message.SmsText ?? string.Empty
			});

			using (var sha = SHA256.Create())
			{
				var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(raw));
				var builder = new StringBuilder(bytes.Length * 2);

				foreach (var b in bytes)
					builder.Append(b.ToString("x2"));

				return builder.ToString();
			}
		}

		/// <summary>حذف پیامک‌های خوانده‌شده از مودم در صورت فعال بودن گزینه.</summary>
		private void DeleteReadFromModem(IEnumerable<ModemSmsMessage> messages)
		{
			foreach (var message in messages)
			{
				try
				{
					_modem.Delete(message.Index, ModemDeleteType.ByIndex);
				}
				catch (Exception ex)
				{
					log.Error(ex);
				}
			}
		}

		/// <summary>
		/// لیست پیامک‌های دریافتی ذخیره‌شده، برای نمایش.
		/// </summary>
		public List<SmsInbox> GetInbox(DateTime? from, DateTime? to, string phoneNumber, int maxRows)
		{
			using (var db = CreateContext())
			{
				var query = db.tbl_SmsInbox.AsNoTracking().AsQueryable();

				if (from != null)
					query = query.Where(x => x.ReceivedAt >= from.Value);

				if (to != null)
					query = query.Where(x => x.ReceivedAt <= to.Value);

				if (!string.IsNullOrWhiteSpace(phoneNumber))
					query = query.Where(x => x.TelNumber.Contains(phoneNumber));

				query = query.OrderByDescending(x => x.ReceivedAt);

				if (maxRows > 0)
					query = query.Take(maxRows);

				return query.ToList();
			}
		}
	}
}
