using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
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
	/// یک پیامک موجود در حافظه‌ی مودم/سیم‌کارت.
	/// اگر پیامک چندپارت باشد، همه‌ی پارت‌ها یک ردیف را تشکیل می‌دهند.
	/// </summary>
	public class DeviceSmsGroup
	{
		/// <summary>اندیس همه‌ی پارت‌های این پیامک در حافظه‌ی دستگاه.</summary>
		public List<int>	Indices			{ get; set; }

		/// <summary>اندیس اصلی (اولین پارت) برای عملیات حذف.</summary>
		public int			Index			{ get { return Indices == null || Indices.Count == 0 ? 0 : Indices[0]; } }

		/// <summary>همه‌ی اندیس‌ها برای نمایش، مثلاً «2,3,4».</summary>
		public string		IndicesText
		{
			get
			{
				if (Indices == null || Indices.Count == 0)
					return string.Empty;

				return string.Join(",", Indices);
			}
		}

		public string		Sender			{ get; set; }

		/// <summary>متن کامل؛ برای پیامک چندپارت، پارت‌ها به هم چسبانده شده‌اند.</summary>
		public string		Text			{ get; set; }

		/// <summary>تعداد کل پارت‌های اعلامی مودم.</summary>
		public int			AllPart			{ get; set; }

		/// <summary>تعداد پارت‌هایی که واقعاً در حافظه موجودند.</summary>
		public int			PartCount		{ get; set; }

		public bool			IsMultipart		{ get; set; }

		public string		Reference		{ get; set; }

		public string		TimeStamp		{ get; set; }

		/// <summary>آیا این پیامک در بانک اطلاعاتی ذخیره شده است.</summary>
		public bool			IsSavedInDatabase { get; set; }

		/// <summary>متن کوتاه برای نمایش در ستون.</summary>
		public string		ShortText
		{
			get
			{
				var text = (Text ?? string.Empty).Replace("\r", " ").Replace("\n", " ").Trim();

				if (text.Length <= 60)
					return text;

				return text.Substring(0, 60) + "…";
			}
		}

		/// <summary>وضعیت ذخیره‌سازی برای نمایش در گرید.</summary>
		public string		SavedText		{ get { return IsSavedInDatabase ? "ذخیره شده" : "ذخیره نشده"; } }

		/// <summary>وضعیت پارت‌ها برای نمایش در گرید.</summary>
		public string		PartText
		{
			get
			{
				if (!IsMultipart)
					return "تک‌پارت";

				if (AllPart > 0 && PartCount >= AllPart)
					return string.Format("{0} پارت", PartCount);

				return string.Format("{0} از {1} پارت", PartCount, AllPart);
			}
		}
	}

	/// <summary>
	/// فهرست پیامک‌های ذخیره‌شده در بانک، برای مقایسه با حافظه‌ی دستگاه.
	/// </summary>
	public class SmsStoredIndex
	{
		private readonly HashSet<string> _references	= new HashSet<string>(StringComparer.Ordinal);
		private readonly HashSet<string> _senderTexts	= new HashSet<string>(StringComparer.Ordinal);

		internal void AddRow(string reference, string sender, string text)
		{
			if (!string.IsNullOrWhiteSpace(reference))
				_references.Add(reference.Trim());

			_senderTexts.Add(BuildSenderText(sender, text));
		}

		/// <summary>
		/// آیا پیامکی با این مشخصات در بانک ذخیره شده است.
		/// برای پیامک چندپارت، شماره‌ی مرجع ملاک است؛
		/// برای تک‌پارت، فرستنده و متن.
		/// </summary>
		public bool Contains(string reference, string sender, string text)
		{
			if (!string.IsNullOrWhiteSpace(reference) && _references.Contains(reference.Trim()))
				return true;

			return _senderTexts.Contains(BuildSenderText(sender, text));
		}

		private static string BuildSenderText(string sender, string text)
		{
			return (sender ?? string.Empty).Trim() + "|" + (text ?? string.Empty);
		}
	}

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

			// هر پیامکی که خوانده و ذخیره‌اش در بانک تأیید شد، از حافظه‌ی مودم پاک می‌شود.
			var deleted = DeleteSavedFromModem(messages);

			if (deleted > 0)
				log.InfoFormat("{0} پیامک پس از ذخیره از حافظه‌ی مودم پاک شد.", deleted);

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
		/// خواندن پیامک‌های موجود در حافظه‌ی دستگاه به صورت گروه‌بندی‌شده.
		///
		/// پارت‌های یک پیامک چندپارتی یک ردیف را تشکیل می‌دهند و برای هر ردیف
		/// مشخص می‌شود که آیا در بانک اطلاعاتی ذخیره شده است یا نه.
		/// </summary>
		public List<DeviceSmsGroup> ReadDeviceGroups()
		{
			var result = new List<DeviceSmsGroup>();

			try
			{
				if (!_modem.Status.Connected)
					_modem.Open();

				if (!_modem.Status.DeviceFound)
				{
					log.Warn("خواندن حافظه انجام نشد؛ مودم شناسایی نشد.");
					return result;
				}

				var messages = _modem.ReadAll(_options.MaxReadPerCycle)
					.Where(x => x != null && !string.IsNullOrEmpty(x.SmsText))
					.ToList();

				if (messages.Count == 0)
					return result;

				var stored = GetStoredIndex();

				foreach (var group in BuildGroups(messages))
				{
					var ordered = group.Parts.OrderBy(x => x.PartNo).ToList();
					var first	= ordered[0];
					var text	= string.Concat(ordered.Select(x => x.SmsText));

					result.Add(new DeviceSmsGroup
					{
						Indices				= ordered.Select(x => x.Index).Distinct().OrderBy(x => x).ToList(),
						Sender				= first.TelNumber,
						Text				= text,
						AllPart				= group.AllPart,
						PartCount			= ordered.Count,
						IsMultipart			= group.IsMultipart,
						Reference			= first.SReference,
						TimeStamp			= first.TimeStamp,
						IsSavedInDatabase	= stored.Contains(first.SReference, first.TelNumber, text)
					});
				}
			}
			catch (Exception ex)
			{
				log.Error(ex);
			}

			return result
				.OrderByDescending(x => x.Index)
				.ToList();
		}

		/// <summary>
		/// آیا این پیامک، گزارش تحویل اپراتور (SMS STATUS REPORT) است.
		/// </summary>
		private static bool IsStatusReport(ModemSmsMessage message)
		{
			if (message == null || string.IsNullOrEmpty(message.SmsType))
				return false;

			return message.SmsType.IndexOf("STATUS", StringComparison.OrdinalIgnoreCase) >= 0
				|| message.SmsType.IndexOf("REPORT", StringComparison.OrdinalIgnoreCase) >= 0;
		}

		/// <summary>
		/// به‌روزرسانی وضعیت تحویل آرشیو بر اساس گزارش‌های تحویل اپراتور.
		/// شماره‌ی مرجع از متن گزارش استخراج و با مرجع ذخیره‌شده مقایسه می‌شود.
		/// </summary>
		private void ApplyStatusReports(IList<ModemSmsMessage> reports)
		{
			if (reports == null || reports.Count == 0)
				return;

			var references = new List<string>();

			foreach (var report in reports)
			{
				foreach (var reference in SmsReferenceParser.Parse(report.SmsText))
				{
					if (!references.Contains(reference))
						references.Add(reference);
				}
			}

			if (references.Count == 0)
			{
				log.Warn("گزارش تحویل بدون شماره‌ی مرجعِ قابل خواندن دریافت شد.");
				return;
			}

			try
			{
				using (var db = CreateContext())
				{
					var rows = db.tbl_SmsArchive
						.Where(x => x.SmsReference != null && x.SmsReference != "")
						.ToList();

					var updated	= 0;
					var now		= DateTime.Now;

					foreach (var row in rows)
					{
						if (row.IsDelivered)
							continue;

						if (!SmsReferenceParser.Overlaps(row.SmsReference, references))
							continue;

						row.IsDelivered			= true;
						row.DeliveredAt			= now;
						row.DeliveredAtShamsi	= JalaliDate.ToShamsi(now);

						updated++;
					}

					if (updated > 0)
					{
						db.SaveChanges();

						log.InfoFormat("{0} پیامک بر اساس گزارش تحویل، «تحویل‌شده» علامت خورد.", updated);
					}
				}
			}
			catch (Exception ex)
			{
				log.Error(ex);
			}
		}

		/// <summary>
		/// فهرست پیامک‌های ذخیره‌شده در بانک، برای مقایسه با حافظه‌ی دستگاه.
		/// </summary>
		public SmsStoredIndex GetStoredIndex()
		{
			return GetStoredIndex(null);
		}

		/// <summary>
		/// فهرست پیامک‌های ذخیره‌شده، محدود به فرستندگانی که لازم است.
		/// اگر <paramref name="senders"/> خالی باشد، همه‌ی ردیف‌ها خوانده می‌شوند.
		/// </summary>
		private SmsStoredIndex GetStoredIndex(IList<string> senders)
		{
			var index = new SmsStoredIndex();

			try
			{
				using (var db = CreateContext())
				{
					var query = db.tbl_SmsInbox.AsNoTracking().AsQueryable();

					if (senders != null && senders.Count > 0)
					{
						var list = senders
							.Where(x => x != null)
							.Distinct()
							.ToList();

						if (list.Count == 0)
							return index;

						query = query.Where(x => list.Contains(x.TelNumber));
					}

					var rows = query
						.Select(x => new { x.SReference, x.TelNumber, x.SmsText })
						.ToList();

					foreach (var row in rows)
						index.AddRow(row.SReference, row.TelNumber, row.SmsText);
				}
			}
			catch (Exception ex)
			{
				log.Error(ex);
			}

			return index;
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
		///
		/// پیامک‌های چندپارتی: پارت‌هایی که «شماره‌ی مرجع» و فرستنده‌ی یکسان دارند
		/// به عنوان یک پیامک ذخیره می‌شوند و متنشان به ترتیب شماره‌ی پارت به هم
		/// چسبانده می‌شود.
		/// </summary>
		private int SaveMessages(IEnumerable<ModemSmsMessage> messages)
		{
			if (messages == null)
				return 0;

			var incoming = messages
				.Where(x => x != null && !string.IsNullOrEmpty(x.SmsText))
				.ToList();

			if (incoming.Count == 0)
				return 0;

			// گزارش تحویل، پیامک عادی نیست؛ فقط وضعیت آرشیو را به‌روز می‌کند
			// و در صندوق ورودی ذخیره نمی‌شود.
			var statusReports = incoming.Where(IsStatusReport).ToList();

			if (statusReports.Count > 0)
			{
				incoming = incoming.Where(x => !IsStatusReport(x)).ToList();

				ApplyStatusReports(statusReports);

				if (incoming.Count == 0)
					return 0;
			}

			var groups = BuildGroups(incoming);

			int saved = 0;

			using (var db = CreateContext())
			{
				foreach (var group in groups)
				{
					try
					{
						if (SaveGroup(db, group))
							saved++;
					}
					catch (Exception ex)
					{
						log.Error(ex);
					}
				}

				try
				{
					if (db.ChangeTracker.HasChanges())
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
		/// گروه‌بندی پارت‌ها: هر شماره‌ی مرجع (به همراه فرستنده) یک پیامک است.
		/// پیامک‌های تک‌پارت هر کدام یک گروه مستقل هستند.
		/// </summary>
		private static List<InboxGroup> BuildGroups(IList<ModemSmsMessage> messages)
		{
			var groups		= new List<InboxGroup>();
			var multipart	= new Dictionary<string, InboxGroup>();

			foreach (var message in messages)
			{
				var reference = (message.SReference ?? string.Empty).Trim();

				var isMultipart = message.AllPart > 1
								  && message.PartNo > 0
								  && reference.Length > 0;

				if (!isMultipart)
				{
					groups.Add(InboxGroup.FromSingle(message));
					continue;
				}

				var key = reference + "|" + (message.TelNumber ?? string.Empty);

				InboxGroup group;

				if (!multipart.TryGetValue(key, out group))
				{
					group = new InboxGroup
					{
						IsMultipart	= true,
						Reference	= reference,
						Sender		= message.TelNumber
					};

					multipart[key] = group;
					groups.Add(group);
				}

				group.Parts.Add(message);
			}

			foreach (var group in groups)
				group.Normalize();

			return groups;
		}

		/// <summary>
		/// ذخیره‌ی یک گروه. اگر ردیفی با همین شماره‌ی مرجع موجود باشد،
		/// پارت‌های تازه به آن اضافه می‌شوند؛ در غیر این صورت ردیف جدید ساخته می‌شود.
		/// خروجی true یعنی چیزی در بانک نوشته شد.
		/// </summary>
		private bool SaveGroup(SmsBanContext db, InboxGroup group)
		{
			var first	= group.Parts.OrderBy(x => x.PartNo).First();
			var now		= DateTime.Now;

			// ---------- پیامک تک‌پارت ----------
			if (!group.IsMultipart)
			{
				var singleHash = ComputeHash(first);

				if (db.tbl_SmsInbox.Any(x => x.DedupHash == singleHash))
					return false;

				db.tbl_SmsInbox.Add(NewRow(first, singleHash, first.SmsText,
					first.AllPart, first.PartNo, null, now));

				return true;
			}

			// ---------- پیامک چندپارت ----------
			var groupHash = ComputeGroupHash(group.Reference, group.Sender, now);
			var existing  = db.tbl_SmsInbox.FirstOrDefault(x => x.DedupHash == groupHash);

			// پارت‌های ذخیره‌شده تا این لحظه: شماره پارت → متن پارت
			var stored = SplitStoredParts(existing);

			var added = 0;

			foreach (var part in group.Parts.OrderBy(x => x.PartNo))
			{
				if (part.PartNo <= 0)
					continue;

				if (stored.ContainsKey(part.PartNo))
					continue;		// این پارت قبلاً ذخیره شده است

				stored[part.PartNo] = part.SmsText ?? string.Empty;
				added++;
			}

			if (existing != null && added == 0)
				return false;		// چیز تازه‌ای وجود ندارد

			var ordered = stored.OrderBy(x => x.Key).ToList();

			var text  = string.Concat(ordered.Select(x => x.Value));
			var index = string.Join(",", ordered.Select(x => x.Key + ":" + (x.Value ?? string.Empty).Length));

			var allPart = Math.Max(group.AllPart, existing == null ? 0 : existing.AllPart);

			if (existing == null)
			{
				db.tbl_SmsInbox.Add(NewRow(first, groupHash, text, allPart, ordered.Count, index, now));

				log.DebugFormat("پیامک چندپارت جدید با {0} پارت ذخیره شد. مرجع: {1}",
					ordered.Count, group.Reference);

				return true;
			}

			existing.SmsText			= text;
			existing.ReceivedParts		= index;
			existing.AllPart			= allPart;
			existing.PartNo				= ordered.Count;
			existing.IsDeletedFromModem	= false;

			log.DebugFormat("پیامک چندپارت تکمیل شد ({0} از {1} پارت). مرجع: {2}",
				ordered.Count, allPart, group.Reference);

			return true;
		}

		/// <summary>
		/// پارت‌های ذخیره‌شده‌ی یک ردیف را برمی‌گرداند: شماره پارت → متن پارت.
		///
		/// متن ردیف با استفاده از طول‌هایی که در <see cref="SmsInbox.ReceivedParts"/>
		/// ذخیره شده به پارت‌هایش شکسته می‌شود؛ بنابراین رسیدن دیرهنگام یک پارت
		/// باعث به‌هم‌ریختن ترتیب متن نمی‌شود و پارت تازه در جای درست خود می‌نشیند.
		/// </summary>
		private static Dictionary<int, string> SplitStoredParts(SmsInbox existing)
		{
			var parts = new Dictionary<int, string>();

			if (existing == null)
				return parts;

			var text = existing.SmsText ?? string.Empty;

			if (text.Length == 0)
				return parts;

			var lengths = ParsePartsIndex(existing.ReceivedParts);

			if (lengths.Count == 0)
			{
				// ردیف‌های قدیمی که ستون ReceivedParts ندارند.
				parts[0] = text;
				return parts;
			}

			var offset = 0;

			foreach (var item in lengths.OrderBy(x => x.Key))
			{
				var length = item.Value;

				if (length < 0)
					length = 0;

				if (offset + length > text.Length)
					length = Math.Max(0, text.Length - offset);

				parts[item.Key] = text.Substring(offset, length);
				offset += length;
			}

			// اگر متن اضافه‌ای باقی مانده باشد، به آخرین پارت چسبانده می‌شود.
			if (offset < text.Length && parts.Count > 0)
			{
				var lastKey = parts.Keys.Max();

				parts[lastKey] = parts[lastKey] + text.Substring(offset);
			}

			return parts;
		}

		/// <summary>
		/// تجزیه‌ی رشته‌ی «1:70,2:70,3:20» به دیکشنری «شماره پارت → طول متن».
		/// </summary>
		private static Dictionary<int, int> ParsePartsIndex(string value)
		{
			var result = new Dictionary<int, int>();

			if (string.IsNullOrWhiteSpace(value))
				return result;

			foreach (var item in value.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
			{
				var pair = item.Split(':');

				if (pair.Length != 2)
					continue;

				int partNo;
				int length;

				if (!int.TryParse(pair[0].Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out partNo))
					continue;

				if (!int.TryParse(pair[1].Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out length))
					continue;

				result[partNo] = length;
			}

			return result;
		}

		/// <summary>ساخت یک ردیف تازه برای صندوق ورودی.</summary>
		private SmsInbox NewRow(ModemSmsMessage message, string hash, string text,
			int allPart, int partNo, string receivedParts, DateTime now)
		{
			return new SmsInbox
			{
				ModemIndex			= message.Index,
				SmsCenter			= message.SmsCenter,
				SmsType				= message.SmsType,
				TelNumber			= message.TelNumber,
				TimeStamp			= message.TimeStamp,
				Discharge			= message.Discharge,
				SmsText				= text,
				TPPid				= message.TPPid,
				TPDcs				= message.TPDcs,
				TPVp				= message.TPVp,
				TPSt				= message.TPSt,
				SReference			= message.SReference,
				AllPart				= allPart,
				PartNo				= partNo,
				ReceivedParts		= receivedParts,
				DeviceName			= _modem.Status.DeviceInfo,
				SimId				= _modem.Status.SimId,
				DedupHash			= hash,
				ReceivedAt			= now,
				ReceivedAtShamsi	= JalaliDate.ToShamsi(now),
				IsRead				= false,
				IsDeletedFromModem	= false
			};
		}

		/// <summary>
		/// اثر انگشت یک پیامک تک‌پارت برای جلوگیری از ذخیره‌ی تکراری.
		/// ترکیب فرستنده، زمان، متن و مشخصات دستگاه.
		/// </summary>
		private string ComputeHash(ModemSmsMessage message)
		{
			return Sha256Hex(string.Join("|", new[]
			{
				_modem.Status.DeviceInfo ?? string.Empty,
				_modem.Status.SimId ?? string.Empty,
				message.TelNumber ?? string.Empty,
				message.TimeStamp ?? string.Empty,
				message.SmsText ?? string.Empty
			}));
		}

		/// <summary>
		/// اثر انگشت گروه پارت‌های یک پیامک چندپارتی.
		///
		/// عمداً فقط بر اساس دستگاه، فرستنده، شماره‌ی مرجع و تاریخ ساخته می‌شود
		/// (نه متن پارت‌ها) تا وقتی پارت بعدی می‌رسد، همان ردیف قبلی پیدا
		/// و تکمیل شود، نه اینکه ردیف تازه‌ای ساخته شود.
		/// </summary>
		private string ComputeGroupHash(string reference, string sender, DateTime receivedAt)
		{
			return Sha256Hex(string.Join("|", new[]
			{
				_modem.Status.DeviceInfo ?? string.Empty,
				_modem.Status.SimId ?? string.Empty,
				sender ?? string.Empty,
				reference ?? string.Empty,
				receivedAt.ToString("yyyyMMdd", CultureInfo.InvariantCulture)
			}));
		}

		private static string Sha256Hex(string raw)
		{
			using (var sha = SHA256.Create())
			{
				var bytes	= sha.ComputeHash(Encoding.UTF8.GetBytes(raw));
				var builder	= new StringBuilder(bytes.Length * 2);

				foreach (var b in bytes)
					builder.Append(b.ToString("x2"));

				return builder.ToString();
			}
		}

		/// <summary>
		/// حذف پیامک‌هایی که خوانده شده‌اند و پردازش‌شان تمام شده است.
		///
		/// پیامک عادی وقتی پاک می‌شود که ذخیره‌اش در بانک تأیید شده باشد؛
		/// پیامکی که ذخیره نشده باشد در حافظه باقی می‌ماند.
		///
		/// گزارش تحویل در بانک ذخیره نمی‌شود (فقط وضعیت آرشیو را به‌روز می‌کند)،
		/// پس بلافاصله پس از پردازش از حافظه پاک می‌شود تا حافظه‌ی مودم پر نشود.
		/// </summary>
		private int DeleteSavedFromModem(IEnumerable<ModemSmsMessage> messages)
		{
			if (!_options.DeleteAfterRead || messages == null)
				return 0;

			var items = messages
				.Where(x => x != null && !string.IsNullOrEmpty(x.SmsText))
				.ToList();

			if (items.Count == 0)
				return 0;

			var stored	= GetStoredIndex(items.Select(x => x.TelNumber).ToList());
			var deleted	= 0;

			foreach (var message in items)
			{
				var handled = IsStatusReport(message)
							  || stored.Contains(message.SReference, message.TelNumber, message.SmsText);

				if (!handled)
					continue;		// ذخیره نشده → از حافظه پاک نمی‌شود

				try
				{
					if (_modem.Delete(message.Index, ModemDeleteType.ByIndex))
						deleted++;
				}
				catch (Exception ex)
				{
					log.Error(ex);
				}
			}

			return deleted;
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

		/// <summary>
		/// پارت‌های یک پیامک.
		///
		/// برای پیامک تک‌پارت یک گروه با یک عضو ساخته می‌شود
		/// و برای پیامک چندپارت همه‌ی پارت‌های هم‌مرجع در آن جمع می‌شوند.
		/// </summary>
		private class InboxGroup
		{
			public bool		IsMultipart	{ get; set; }

			/// <summary>شماره‌ی مرجع پارت‌ها (فقط برای پیامک چندپارت).</summary>
			public string	Reference	{ get; set; }

			/// <summary>شماره‌ی فرستنده.</summary>
			public string	Sender		{ get; set; }

			public List<ModemSmsMessage> Parts { get; private set; }

			/// <summary>تعداد کل پارت‌ها، طبق اعلام مودم.</summary>
			public int		AllPart		{ get; set; }

			public InboxGroup()
			{
				Parts = new List<ModemSmsMessage>();
			}

			public static InboxGroup FromSingle(ModemSmsMessage message)
			{
				var group = new InboxGroup { IsMultipart = false };

				group.Parts.Add(message);
				group.AllPart = 1;

				return group;
			}

			/// <summary>
			/// حذف پارت‌های تکراری و مرتب‌سازی بر اساس شماره‌ی پارت.
			/// اگر یک پارت دو بار از مودم خوانده شده باشد، فقط یکی نگه داشته می‌شود.
			/// </summary>
			public void Normalize()
			{
				if (!IsMultipart)
					return;

				var unique	= new List<ModemSmsMessage>();
				var seen	= new HashSet<int>();

				foreach (var part in Parts)
				{
					if (part.PartNo > 0 && !seen.Add(part.PartNo))
						continue;

					unique.Add(part);
				}

				unique.Sort((a, b) => a.PartNo.CompareTo(b.PartNo));

				Parts.Clear();
				Parts.AddRange(unique);

				AllPart = Parts.Count == 0 ? 0 : Parts.Max(x => x.AllPart);
			}
		}
	}
}
