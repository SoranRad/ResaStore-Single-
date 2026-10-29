using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using SmsBan.DataLayer;
using SmsBan.DataLayer.Context;
using SmsBan.Model;

namespace SmsBan.Core
{
	/// <summary>
	/// جهت نمایش پیامک‌ها در صفحه‌ی گفتگو.
	/// </summary>
	public enum SmsDirection
	{
		/// <summary>هر دو جهت.</summary>
		Both		= 0,

		/// <summary>فقط ارسالی.</summary>
		Outgoing	= 1,

		/// <summary>فقط دریافتی.</summary>
		Incoming	= 2
	}

	/// <summary>
	/// یک پیام در نمای گفتگو (چه ارسالی و چه دریافتی).
	/// </summary>
	public class SmsChatMessage
	{
		public long		Id					{ get; set; }

		/// <summary>true یعنی ارسالی، false یعنی دریافتی.</summary>
		public bool		IsOutgoing			{ get; set; }

		public string	Text				{ get; set; }

		public string	PhoneNumber			{ get; set; }

		/// <summary>تعداد پارت (صفحه) پیامک.</summary>
		public int		PageCount			{ get; set; }

		/// <summary>زمان وقوع (ارسال یا دریافت).</summary>
		public DateTime? OccurredAt			{ get; set; }

		/// <summary>زمان وقوع به شمسی.</summary>
		public string	OccurredAtShamsi	{ get; set; }

		/// <summary>آیا تحویل مخاطب شده است (فقط ارسالی).</summary>
		public bool		IsDelivered			{ get; set; }

		/// <summary>تاریخ تحویل به شمسی.</summary>
		public string	DeliveredAtShamsi	{ get; set; }

		public string	StatusText			{ get; set; }

		public string	ErrorMessage		{ get; set; }

		public string	PriorityText		{ get; set; }

		public string	SmsReference		{ get; set; }

		public int?		DurationMs			{ get; set; }

		/// <summary>متن ریز اطلاعات برای نمایش زیر حباب پیام.</summary>
		public string	MetaText			{ get; set; }

		public override string ToString()
		{
			return string.Format("{0} | {1} | {2}", OccurredAtShamsi, IsOutgoing ? "ارسالی" : "دریافتی", Text);
		}
	}

	/// <summary>
	/// خواندن گفتگوهای یک مخاطب و حذف پیامک‌ها.
	/// </summary>
	public class SmsConversationService
	{
		#region Logging

		private static readonly log4net.ILog log =
			log4net
				.LogManager
				.GetLogger
				(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		#endregion

		private readonly SmsBanOptions _options;

		public SmsConversationService(SmsBanOptions options)
		{
			if (options == null)
				throw new ArgumentNullException("options");

			_options = options;
		}

		private SmsBanContext CreateContext()
		{
			return SmsBanDb.Create(_options.ConnectionString);
		}

		#region Conversation

		/// <summary>
		/// خواندن پیامک‌های یک مخاطب بر اساس همه‌ی حالت‌های نوشتن شماره‌ی او.
		/// </summary>
		/// <param name="phoneVariants">حالت‌های مختلف شماره، از <see cref="SmsPhoneNumber.Variants"/>.</param>
		/// <param name="direction">کدام جهت‌ها خوانده شوند.</param>
		/// <param name="maxRows">حداکثر تعداد پیام در هر جهت.</param>
		public List<SmsChatMessage> GetConversation(IEnumerable<string> phoneVariants,
			SmsDirection direction, int maxRows)
		{
			var messages = new List<SmsChatMessage>();

			if (phoneVariants == null)
				return messages;

			var variants = phoneVariants
				.Where(x => !string.IsNullOrWhiteSpace(x))
				.Distinct()
				.ToList();

			if (variants.Count == 0)
				return messages;

			if (maxRows <= 0)
				maxRows = 500;

			try
			{
				using (var db = CreateContext())
				{
					if (direction == SmsDirection.Both || direction == SmsDirection.Outgoing)
					{
						var outgoing = db.tbl_SmsArchive
							.AsNoTracking()
							.Where(x => variants.Contains(x.PhoneNumber))
							.OrderByDescending(x => x.SentAt ?? x.CreatedAt)
							.ThenByDescending(x => x.ID)
							.Take(maxRows)
							.ToList();

						messages.AddRange(outgoing.Select(FromArchive));
					}

					if (direction == SmsDirection.Both || direction == SmsDirection.Incoming)
					{
						var incoming = db.tbl_SmsInbox
							.AsNoTracking()
							.Where(x => variants.Contains(x.TelNumber))
							.OrderByDescending(x => x.ReceivedAt)
							.ThenByDescending(x => x.ID)
							.Take(maxRows)
							.ToList();

						messages.AddRange(incoming.Select(FromInbox));
					}
				}
			}
			catch (Exception ex)
			{
				log.Error(ex);
			}

			return messages
				.OrderBy(x => x.OccurredAt)
				.ThenBy(x => x.Id)
				.ToList();
		}

		private SmsChatMessage FromArchive(SmsArchive row)
		{
			var occurredAt = row.SentAt ?? row.CreatedAt;

			var message = new SmsChatMessage
			{
				Id					= row.ID,
				IsOutgoing			= true,
				Text				= row.MessageText,
				PhoneNumber			= row.PhoneNumber,
				PageCount			= row.PageCount,
				OccurredAt			= occurredAt,
				OccurredAtShamsi	= row.SentAtShamsi ?? row.CreatedAtShamsi ?? JalaliDate.ToShamsi(occurredAt),
				IsDelivered			= row.IsDelivered,
				DeliveredAtShamsi	= row.DeliveredAtShamsi,
				StatusText			= SmsTexts.Status(row.Status),
				ErrorMessage		= row.ErrorMessage,
				PriorityText		= SmsTexts.Priority(row.Priority),
				SmsReference		= row.SmsReference,
				DurationMs			= row.DurationMs
			};

			message.MetaText = BuildOutgoingMeta(message);

			return message;
		}

		private SmsChatMessage FromInbox(SmsInbox row)
		{
			var message = new SmsChatMessage
			{
				Id					= row.ID,
				IsOutgoing			= false,
				Text				= row.SmsText,
				PhoneNumber			= row.TelNumber,
				PageCount			= row.PartNo > 0 ? row.PartNo : (row.AllPart > 0 ? row.AllPart : 1),
				OccurredAt			= row.ReceivedAt,
				OccurredAtShamsi	= row.ReceivedAtShamsi ?? JalaliDate.ToShamsi(row.ReceivedAt),
				IsDelivered			= true,
				StatusText			= "دریافت شد",
				SmsReference		= row.SReference
			};

			message.MetaText = BuildIncomingMeta(message);

			return message;
		}

		private static string BuildOutgoingMeta(SmsChatMessage message)
		{
			var parts = new List<string>();

			parts.Add(message.OccurredAtShamsi ?? string.Empty);
			parts.Add(string.Format("{0} پارت", message.PageCount));

			if (message.IsDelivered)
				parts.Add(string.IsNullOrWhiteSpace(message.DeliveredAtShamsi)
					? "تحویل شد"
					: "تحویل: " + message.DeliveredAtShamsi);
			else
				parts.Add(message.StatusText ?? "در انتظار تحویل");

			return string.Join("  •  ", parts);
		}

		private static string BuildIncomingMeta(SmsChatMessage message)
		{
			return string.Format("{0}  •  {1} پارت  •  دریافتی",
				message.OccurredAtShamsi ?? string.Empty, message.PageCount);
		}

		#endregion

		#region Last Activity

		/// <summary>
		/// آخرین زمان فعالیت (ارسال یا دریافت) به تفکیک شماره‌ی نرمال‌شده.
		/// برای مرتب‌سازی فهرست مخاطبان بر اساس تازه‌ترین پیامک استفاده می‌شود.
		/// </summary>
		public Dictionary<string, DateTime> GetLastActivity()
		{
			var map = new Dictionary<string, DateTime>();

			try
			{
				using (var db = CreateContext())
				{
					var outgoing = db.tbl_SmsArchive
						.AsNoTracking()
						.GroupBy(x => x.PhoneNumber)
						.Select(g => new
						{
							Phone	= g.Key,
							Sent	= g.Max(x => x.SentAt),
							Created	= g.Max(x => x.CreatedAt)
						})
						.ToList();

					foreach (var row in outgoing)
					{
						var date = Later(row.Sent, row.Created);

						if (date != null)
							Add(map, row.Phone, date.Value);
					}

					var incoming = db.tbl_SmsInbox
						.AsNoTracking()
						.GroupBy(x => x.TelNumber)
						.Select(g => new
						{
							Phone		= g.Key,
							Received	= g.Max(x => x.ReceivedAt)
						})
						.ToList();

					foreach (var row in incoming)
						Add(map, row.Phone, row.Received);
				}
			}
			catch (Exception ex)
			{
				log.Error(ex);
			}

			return map;
		}

		private static DateTime? Later(DateTime? first, DateTime? second)
		{
			if (first == null) return second;
			if (second == null) return first;

			return first.Value >= second.Value ? first : second;
		}

		private void Add(Dictionary<string, DateTime> map, string rawPhone, DateTime date)
		{
			var normalized = SmsPhoneNumber.Normalize(rawPhone, _options.CountryCode);

			if (string.IsNullOrEmpty(normalized))
				return;

			DateTime current;

			if (!map.TryGetValue(normalized, out current) || date > current)
				map[normalized] = date;
		}

		#endregion

		#region Delete

		/// <summary>
		/// حذف یک پیامک بر اساس شناسه و جهت آن.
		/// برای ارسالی از جدول آرشیو و برای دریافتی از جدول صندوق ورودی حذف می‌شود.
		/// </summary>
		public bool DeleteMessage(long id, bool isOutgoing)
		{
			return isOutgoing ? DeleteOutgoing(id) : DeleteIncoming(id);
		}

		/// <summary>حذف یک پیامک ارسالی از جدول آرشیو.</summary>
		public bool DeleteOutgoing(long id)
		{
			try
			{
				using (var db = CreateContext())
				{
					var row = db.tbl_SmsArchive.FirstOrDefault(x => x.ID == id);

					if (row == null)
						return false;

					db.tbl_SmsArchive.Remove(row);
					db.SaveChanges();
				}

				return true;
			}
			catch (Exception ex)
			{
				log.Error(ex);
				return false;
			}
		}

		/// <summary>حذف یک پیامک دریافتی از جدول صندوق ورودی.</summary>
		public bool DeleteIncoming(long id)
		{
			try
			{
				using (var db = CreateContext())
				{
					var row = db.tbl_SmsInbox.FirstOrDefault(x => x.ID == id);

					if (row == null)
						return false;

					db.tbl_SmsInbox.Remove(row);
					db.SaveChanges();
				}

				return true;
			}
			catch (Exception ex)
			{
				log.Error(ex);
				return false;
			}
		}

		/// <summary>
		/// حذف گروهی پیامک‌های ارسالی.
		/// تعداد ردیف‌های واقعاً حذف‌شده برگردانده می‌شود.
		/// </summary>
		public int DeleteOutgoing(IEnumerable<long> ids)
		{
			return DeleteMany(ids, true);
		}

		/// <summary>
		/// حذف گروهی پیامک‌های دریافتی.
		/// تعداد ردیف‌های واقعاً حذف‌شده برگردانده می‌شود.
		/// </summary>
		public int DeleteIncoming(IEnumerable<long> ids)
		{
			return DeleteMany(ids, false);
		}

		private int DeleteMany(IEnumerable<long> ids, bool isOutgoing)
		{
			if (ids == null)
				return 0;

			var list = ids.Distinct().ToList();

			if (list.Count == 0)
				return 0;

			try
			{
				using (var db = CreateContext())
				{
					var count = isOutgoing
						? DeleteArchiveRows(db, list)
						: DeleteInboxRows(db, list);

					if (count > 0)
						db.SaveChanges();

					return count;
				}
			}
			catch (Exception ex)
			{
				log.Error(ex);
				return 0;
			}
		}

		private static int DeleteArchiveRows(SmsBanContext db, IList<long> ids)
		{
			var rows = db.tbl_SmsArchive.Where(x => ids.Contains(x.ID)).ToList();

			if (rows.Count == 0)
				return 0;

			db.tbl_SmsArchive.RemoveRange(rows);

			return rows.Count;
		}

		private static int DeleteInboxRows(SmsBanContext db, IList<long> ids)
		{
			var rows = db.tbl_SmsInbox.Where(x => ids.Contains(x.ID)).ToList();

			if (rows.Count == 0)
				return 0;

			db.tbl_SmsInbox.RemoveRange(rows);

			return rows.Count;
		}

		/// <summary>
		/// حذف کل گفتگوی یک یا چند شماره (هم ارسالی و هم دریافتی).
		/// </summary>
		public int DeleteConversation(IEnumerable<string> phoneVariants)
		{
			return DeleteConversation(phoneVariants, SmsDirection.Both);
		}

		/// <summary>حذف گفتگوی یک شماره در جهت مشخص.</summary>
		public int DeleteConversation(IEnumerable<string> phoneVariants, SmsDirection direction)
		{
			if (phoneVariants == null)
				return 0;

			var variants = phoneVariants
				.Where(x => !string.IsNullOrWhiteSpace(x))
				.Distinct()
				.ToList();

			if (variants.Count == 0)
				return 0;

			try
			{
				using (var db = CreateContext())
				{
					var deleted = 0;

					if (direction == SmsDirection.Both || direction == SmsDirection.Outgoing)
					{
						var rows = db.tbl_SmsArchive
							.Where(x => variants.Contains(x.PhoneNumber))
							.ToList();

						if (rows.Count > 0)
						{
							db.tbl_SmsArchive.RemoveRange(rows);
							deleted += rows.Count;
						}
					}

					if (direction == SmsDirection.Both || direction == SmsDirection.Incoming)
					{
						var rows = db.tbl_SmsInbox
							.Where(x => variants.Contains(x.TelNumber))
							.ToList();

						if (rows.Count > 0)
						{
							db.tbl_SmsInbox.RemoveRange(rows);
							deleted += rows.Count;
						}
					}

					if (deleted > 0)
						db.SaveChanges();

					return deleted;
				}
			}
			catch (Exception ex)
			{
				log.Error(ex);
				return 0;
			}
		}

		/// <summary>
		/// حذف پیامک‌های ارسالی قدیمی‌تر از یک تاریخ
		/// (بر اساس زمان ارسال، و اگر ارسال نشده باشد زمان ثبت).
		/// </summary>
		public int DeleteOutgoingBefore(DateTime date)
		{
			try
			{
				using (var db = CreateContext())
				{
					var rows = db.tbl_SmsArchive
						.Where(x => (x.SentAt ?? x.CreatedAt) < date)
						.ToList();

					if (rows.Count == 0)
						return 0;

					db.tbl_SmsArchive.RemoveRange(rows);
					db.SaveChanges();

					return rows.Count;
				}
			}
			catch (Exception ex)
			{
				log.Error(ex);
				return 0;
			}
		}

		/// <summary>حذف پیامک‌های دریافتی قدیمی‌تر از یک تاریخ.</summary>
		public int DeleteIncomingBefore(DateTime date)
		{
			try
			{
				using (var db = CreateContext())
				{
					var rows = db.tbl_SmsInbox
						.Where(x => x.ReceivedAt < date)
						.ToList();

					if (rows.Count == 0)
						return 0;

					db.tbl_SmsInbox.RemoveRange(rows);
					db.SaveChanges();

					return rows.Count;
				}
			}
			catch (Exception ex)
			{
				log.Error(ex);
				return 0;
			}
		}

		#endregion
	}
}
