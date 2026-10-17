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
	/// مدیریت صف ارسال پیامک.
	///
	/// ترتیب صف با ستون <c>SortOrder</c> تعیین می‌شود:
	///   - عادی   : انتهای صف
	///   - فوری   : ابتدای صف
	///   - متوسط  : میانه‌ی صف
	///
	/// کاربر می‌تواند ترتیب را دستی تغییر دهد و چون ترتیب نهایی همین ستون است،
	/// تغییر دستی همیشه حاکم می‌ماند.
	/// </summary>
	public class SmsQueueService
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

		/// <summary>مقدار شروع ترتیب صف.</summary>
		internal const decimal	InitialSortOrder	= 1000000m;

		/// <summary>فاصله‌ی پیش‌فرض بین دو ردیف هنگام درج.</summary>
		internal const decimal	SortGap				= 1000m;

		/// <summary>کمترین فاصله‌ی مجاز؛ کمتر از آن نیاز به بازشماره‌گذاری است.</summary>
		private const decimal	MinGap				= 0.000001m;

		private readonly SmsBanOptions _options;

		public SmsQueueService(SmsBanOptions options)
		{
			if (options == null)
				throw new ArgumentNullException("options");

			_options = options;
		}

		public SmsBanOptions Options
		{
			get { return _options; }
		}

		private SmsBanContext CreateContext()
		{
			return SmsBanDb.Create(_options.ConnectionString);
		}

		private string RequesterName
		{
			get
			{
				if (!string.IsNullOrWhiteSpace(_options.EnqueuedBy))
					return _options.EnqueuedBy;

				if (!string.IsNullOrWhiteSpace(_options.InstanceId))
					return _options.InstanceId;

				return Environment.MachineName;
			}
		}

		// ==================================================================
		// درج در صف
		// ==================================================================

		/// <summary>
		/// ارسال یک پیامک به یک شماره. شناسه‌ی ردیف صف برگردانده می‌شود.
		/// </summary>
		public long Enqueue(string phoneNumber, string text, SmsPriority priority)
		{
			var ids = EnqueueMany(
				new[] { new SmsRequest(phoneNumber, text) },
				priority);

			return ids.Count > 0 ? ids[0] : 0;
		}

		/// <summary>ارسال یک متن یکسان به چند شماره.</summary>
		public List<long> EnqueueSameText(IEnumerable<string> phoneNumbers, string text, SmsPriority priority)
		{
			if (phoneNumbers == null)
				return new List<long>();

			var requests = phoneNumbers
				.Where(p => !string.IsNullOrWhiteSpace(p))
				.Select(p => new SmsRequest(p, text))
				.ToList();

			return EnqueueMany(requests, priority);
		}

		/// <summary>ارسال متن اختصاصی برای هر شماره.</summary>
		public List<long> EnqueueMany(IEnumerable<SmsRequest> requests, SmsPriority defaultPriority)
		{
			var list = (requests ?? Enumerable.Empty<SmsRequest>())
				.Where(r => r != null
							&& !string.IsNullOrWhiteSpace(r.PhoneNumber)
							&& !string.IsNullOrEmpty(r.Text))
				.ToList();

			if (list.Count == 0)
				return new List<long>();

			var result = new List<long>(list.Count);

			using (var db = CreateContext())
			using (var transaction = db.Database.BeginTransaction())
			{
				try
				{
					var orders = ComputeOrders(db, defaultPriority, list.Count);

					// اگر فضای عددی کافی نبود، یک‌بار کل صف بازشماره‌گذاری می‌شود.
					if (orders.Any(o => o < 0))
					{
						Renumber(db, list.Count);
						db.SaveChanges();
						orders = ComputeOrders(db, defaultPriority, list.Count);
					}

					var now			= DateTime.Now;
					var nowShamsi	= JalaliDate.ToShamsi(now);
					var requester	= RequesterName;

					var items = new List<SmsOutbox>(list.Count);

					for (int index = 0; index < list.Count; index++)
					{
						var request		= list[index];
						var priority	= request.Priority ?? defaultPriority;

						var item = new SmsOutbox
						{
							SortOrder		= orders[index],
							Priority		= (int)priority,
							PhoneNumber		= SmsPhoneNumber.Normalize(request.PhoneNumber, _options.CountryCode),
							MessageText		= request.Text,
							PageCount		= SmsPageCalculator.CalculatePageCount(request.Text, _options.CharsPerPage),
							Status			= (int)SmsMessageStatus.Pending,
							RetryCount		= 0,
							CreatedAt		= now,
							CreatedAtShamsi	= nowShamsi,
							EnqueuedBy		= requester
						};

						db.tbl_SmsOutbox.Add(item);
						items.Add(item);
					}

					db.SaveChanges();

					result.AddRange(items.Select(i => i.ID));

					transaction.Commit();

					log.DebugFormat("{0} پیامک با اولویت {1} به صف اضافه شد.",
						list.Count, SmsTexts.Priority(defaultPriority));
				}
				catch (Exception ex)
				{
					transaction.Rollback();
					log.Error(ex);
					throw;
				}
			}

			return result;
		}

		/// <summary>حداقل و حداکثر ترتیب موجود در صف.</summary>
		private static void GetSortRange(SmsBanContext db, out decimal? min, out decimal? max)
		{
			min = db.tbl_SmsOutbox.Min(x => (decimal?)x.SortOrder);
			max = db.tbl_SmsOutbox.Max(x => (decimal?)x.SortOrder);
		}

		/// <summary>
		/// محاسبه‌ی ترتیب ردیف‌های جدید بر اساس اولویت.
		///
		/// برای اولویت متوسط، بازه‌ی بین دو ردیفِ وسطِ صف محاسبه و ردیف‌های جدید
		/// با فاصله‌ی متناسب در همان بازه جای می‌گیرند تا هیچ‌گاه با ردیف‌های
		/// موجود تصادم نداشته باشند.
		/// </summary>
		private static decimal[] ComputeOrders(SmsBanContext db, SmsPriority priority, int count)
		{
			var orders = new decimal[count];

			decimal? min, max;
			GetSortRange(db, out min, out max);

			if (min == null || max == null)
			{
				for (int i = 0; i < count; i++)
					orders[i] = InitialSortOrder + i * SortGap;

				return orders;
			}

			if (priority == SmsPriority.Urgent)
			{
				var start = min.Value - SortGap * count;

				for (int i = 0; i < count; i++)
					orders[i] = start + i * SortGap;

				return orders;
			}

			if (priority == SmsPriority.Normal)
			{
				var start = max.Value + SortGap;

				for (int i = 0; i < count; i++)
					orders[i] = start + i * SortGap;

				return orders;
			}

			// ---- اولویت متوسط ----

			int total = db.tbl_SmsOutbox.Count();

			if (total == 0)
			{
				for (int i = 0; i < count; i++)
					orders[i] = InitialSortOrder + i * SortGap;

				return orders;
			}

			int middle = total / 2;

			decimal lower;
			decimal upper;

			if (middle <= 0)
			{
				lower = min.Value - SortGap;
			}
			else
			{
				lower = db.tbl_SmsOutbox
					.OrderBy(x => x.SortOrder).ThenBy(x => x.ID)
					.Skip(middle - 1).Take(1)
					.Select(x => x.SortOrder)
					.First();
			}

			if (middle >= total)
			{
				upper = max.Value + SortGap;
			}
			else
			{
				upper = db.tbl_SmsOutbox
					.OrderBy(x => x.SortOrder).ThenBy(x => x.ID)
					.Skip(middle).Take(1)
					.Select(x => x.SortOrder)
					.First();
			}

			var available	= upper - lower;
			var step		= Math.Min(SortGap, available / (count + 1));

			if (step < MinGap)
				step = MinGap;

			var begin = lower + step;

			for (int i = 0; i < count; i++)
				orders[i] = begin + i * step;

			return orders;
		}

		/// <summary>
		/// بازشماره‌گذاری کل صف با فاصله‌ی یکنواخت، با فضای خالی در ابتدا
		/// برای درج‌های فوری بعدی.
		/// </summary>
		private static void Renumber(SmsBanContext db, int roomAtBeginning)
		{
			var items = db.tbl_SmsOutbox
				.OrderBy(x => x.SortOrder)
				.ThenBy(x => x.ID)
				.ToList();

			var order = InitialSortOrder + SortGap * (roomAtBeginning + 10);

			foreach (var item in items)
			{
				item.SortOrder = order;
				order += SortGap;
			}
		}

		// ==================================================================
		// نمایش صف
		// ==================================================================

		public int GetQueueCount(SmsMessageStatus? status)
		{
			using (var db = CreateContext())
			{
				var query = db.tbl_SmsOutbox.AsNoTracking().AsQueryable();

				if (status != null)
					query = query.Where(x => x.Status == (int)status.Value);

				return query.Count();
			}
		}

		/// <summary>گرفتن لیست صف با فیلتر، برای نمایش به کاربر.</summary>
		public List<SmsQueueItem> GetQueue(SmsQueueFilter filter)
		{
			filter = filter ?? new SmsQueueFilter();

			using (var db = CreateContext())
			{
				var query = db.tbl_SmsOutbox.AsNoTracking().AsQueryable();

				if (filter.Status != null)
					query = query.Where(x => x.Status == (int)filter.Status.Value);

				if (filter.Priority != null)
					query = query.Where(x => x.Priority == (int)filter.Priority.Value);

				if (filter.FromDate != null)
					query = query.Where(x => x.CreatedAt >= filter.FromDate.Value);

				if (filter.ToDate != null)
					query = query.Where(x => x.CreatedAt <= filter.ToDate.Value);

				if (!string.IsNullOrWhiteSpace(filter.PhoneNumber))
				{
					var phone = filter.PhoneNumber.Trim();
					query = query.Where(x => x.PhoneNumber.Contains(phone));
				}

				query = query
					.OrderBy(x => x.SortOrder)
					.ThenBy(x => x.ID);

				if (filter.MaxRows > 0)
					query = query.Take(filter.MaxRows);

				var rows = query.Select(x => new SmsQueueItem
				{
					ID				= x.ID,
					SortOrder		= x.SortOrder,
					Priority		= x.Priority,
					PhoneNumber		= x.PhoneNumber,
					MessageText		= x.MessageText,
					PageCount		= x.PageCount,
					Status			= x.Status,
					RetryCount		= x.RetryCount,
					LastError		= x.LastError,
					CreatedAt		= x.CreatedAt,
					CreatedAtShamsi	= x.CreatedAtShamsi,
					EnqueuedBy		= x.EnqueuedBy,
					LockedBy		= x.LockedBy
				}).ToList();

				foreach (var row in rows)
				{
					row.PriorityText	= SmsTexts.Priority(row.Priority);
					row.StatusText		= SmsTexts.Status(row.Status);
				}

				return rows;
			}
		}

		// ==================================================================
		// دستکاری صف توسط کاربر
		// ==================================================================

		/// <summary>
		/// لغو یک ردیف در صف. ردیف از صف حذف و در آرشیو با وضعیت «لغو شد» ثبت می‌شود.
		/// </summary>
		public bool Cancel(long id)
		{
			using (var db = CreateContext())
			using (var transaction = db.Database.BeginTransaction())
			{
				var item = db.tbl_SmsOutbox.FirstOrDefault(
					x => x.ID == id && x.Status == (int)SmsMessageStatus.Pending);

				if (item == null)
					return false;

				Archive(db, item, SmsMessageStatus.Canceled, "لغو توسط کاربر");

				db.tbl_SmsOutbox.Remove(item);
				db.SaveChanges();

				transaction.Commit();
			}

			log.InfoFormat("پیامک شماره {0} از صف لغو شد.", id);
			return true;
		}

		/// <summary>لغو تمام ردیف‌های در انتظار.</summary>
		public int CancelAllPending()
		{
			using (var db = CreateContext())
			using (var transaction = db.Database.BeginTransaction())
			{
				var items = db.tbl_SmsOutbox
					.Where(x => x.Status == (int)SmsMessageStatus.Pending)
					.ToList();

				foreach (var item in items)
					Archive(db, item, SmsMessageStatus.Canceled, "لغو گروهی توسط کاربر");

				db.tbl_SmsOutbox.RemoveRange(items);
				db.SaveChanges();

				transaction.Commit();

				return items.Count;
			}
		}

		/// <summary>
		/// تغییر اولویت یک ردیف؛ محل آن در صف نیز بر اساس اولویت جدید تعیین می‌شود.
		/// </summary>
		public bool ChangePriority(long id, SmsPriority priority)
		{
			using (var db = CreateContext())
			using (var transaction = db.Database.BeginTransaction())
			{
				var item = db.tbl_SmsOutbox.FirstOrDefault(
					x => x.ID == id && x.Status == (int)SmsMessageStatus.Pending);

				if (item == null)
					return false;

				// ردیف فعلی از محاسبه‌ی محدوده کنار گذاشته می‌شود.
				item.Priority = (int)priority;
				db.SaveChanges();

				var othersMin = db.tbl_SmsOutbox.Where(x => x.ID != id).Min(x => (decimal?)x.SortOrder);
				var othersMax = db.tbl_SmsOutbox.Where(x => x.ID != id).Max(x => (decimal?)x.SortOrder);

				item.SortOrder = ComputeSingleOrder(othersMin, othersMax, priority);

				db.SaveChanges();
				transaction.Commit();
			}

			return true;
		}

		/// <summary>ترتیب یک ردیف منفرد بر اساس اولویت، با محدوده‌ی داده‌شده.</summary>
		private static decimal ComputeSingleOrder(decimal? min, decimal? max, SmsPriority priority)
		{
			if (min == null || max == null)
				return InitialSortOrder;

			switch (priority)
			{
				case SmsPriority.Urgent:
					return min.Value - SortGap;

				case SmsPriority.Medium:
					return (min.Value + max.Value) / 2m;

				default:
					return max.Value + SortGap;
			}
		}

		/// <summary>انتقال به ابتدای صف.</summary>
		public bool MoveToTop(long id)
		{
			return MoveToEdge(id, true);
		}

		/// <summary>انتقال به انتهای صف.</summary>
		public bool MoveToBottom(long id)
		{
			return MoveToEdge(id, false);
		}

		private bool MoveToEdge(long id, bool top)
		{
			using (var db = CreateContext())
			using (var transaction = db.Database.BeginTransaction())
			{
				var item = db.tbl_SmsOutbox.FirstOrDefault(
					x => x.ID == id && x.Status == (int)SmsMessageStatus.Pending);

				if (item == null)
					return false;

				var min = db.tbl_SmsOutbox.Where(x => x.ID != id).Min(x => (decimal?)x.SortOrder);
				var max = db.tbl_SmsOutbox.Where(x => x.ID != id).Max(x => (decimal?)x.SortOrder);

				if (top)
				{
					if (min == null)
					{
						item.SortOrder = InitialSortOrder;
					}
					else
					{
						if (min.Value < SortGap * 3)
						{
							Renumber(db, 10);
							db.SaveChanges();
							min = db.tbl_SmsOutbox.Where(x => x.ID != id).Min(x => (decimal?)x.SortOrder);
						}

						item.SortOrder = (min ?? InitialSortOrder) - SortGap;
					}
				}
				else
				{
					item.SortOrder = (max ?? InitialSortOrder) + SortGap;
				}

				db.SaveChanges();
				transaction.Commit();
			}

			return true;
		}

		/// <summary>یک ردیف به بالا (زودتر).</summary>
		public bool MoveUp(long id)
		{
			return SwapWithNeighbor(id, -1);
		}

		/// <summary>یک ردیف به پایین (دیرتر).</summary>
		public bool MoveDown(long id)
		{
			return SwapWithNeighbor(id, +1);
		}

		/// <summary>
		/// جابه‌جایی با ردیف همسایه.
		/// برای سادگی و جلوگیری از خطای دقت اعشاری، ترتیب کل صف
		/// با فاصله‌ی یکنواخت بازنویسی می‌شود و سپس دو ردیف جابه‌جا می‌شوند.
		/// </summary>
		private bool SwapWithNeighbor(long id, int direction)
		{
			using (var db = CreateContext())
			using (var transaction = db.Database.BeginTransaction())
			{
				var items = db.tbl_SmsOutbox
					.Where(x => x.Status == (int)SmsMessageStatus.Pending)
					.OrderBy(x => x.SortOrder)
					.ThenBy(x => x.ID)
					.ToList();

				int index = items.FindIndex(x => x.ID == id);

				if (index < 0)
					return false;

				int target = index + direction;

				if (target < 0 || target >= items.Count)
					return false;

				var current		= items[index];
				var neighbor	= items[target];

				var order = InitialSortOrder;

				foreach (var item in items)
				{
					item.SortOrder = order;
					order += SortGap;
				}

				var temp = current.SortOrder;
				current.SortOrder	= neighbor.SortOrder;
				neighbor.SortOrder	= temp;

				db.SaveChanges();
				transaction.Commit();
			}

			return true;
		}

		/// <summary>برگرداندن یک پیامک ناموفق یا لغوشده به صف.</summary>
		public bool RetryFailed(long archiveId)
		{
			using (var db = CreateContext())
			using (var transaction = db.Database.BeginTransaction())
			{
				var archived = db.tbl_SmsArchive.FirstOrDefault(
					x => x.ID == archiveId
						&& (x.Status == (int)SmsMessageStatus.Failed
							|| x.Status == (int)SmsMessageStatus.Canceled));

				if (archived == null)
					return false;

				decimal? min, max;
				GetSortRange(db, out min, out max);

				var now = DateTime.Now;

				var item = new SmsOutbox
				{
					SortOrder		= ComputeSingleOrder(min, max, SmsPriority.Normal),
					Priority		= (int)SmsPriority.Normal,
					PhoneNumber		= archived.PhoneNumber,
					MessageText		= archived.MessageText,
					PageCount		= archived.PageCount,
					Status			= (int)SmsMessageStatus.Pending,
					RetryCount		= 0,
					CreatedAt		= now,
					CreatedAtShamsi	= JalaliDate.ToShamsi(now),
					EnqueuedBy		= RequesterName
				};

				db.tbl_SmsOutbox.Add(item);
				db.tbl_SmsArchive.Remove(archived);

				db.SaveChanges();
				transaction.Commit();
			}

			log.InfoFormat("پیامک ناموفق {0} به صف برگردانده شد.", archiveId);
			return true;
		}

		// ==================================================================
		// توقف و ادامه‌ی ارسال
		// ==================================================================

		public bool IsPaused()
		{
			using (var db = CreateContext())
			{
				var state = SmsWorkerStateService.Get(db);

				return state != null && state.IsPaused;
			}
		}

		public void Pause(string by)
		{
			using (var db = CreateContext())
			{
				var state = SmsWorkerStateService.GetOrCreate(db);

				state.IsPaused		= true;
				state.PausedAt		= DateTime.Now;
				state.PausedAtShamsi= JalaliDate.ToShamsi(DateTime.Now);
				state.PausedBy		= string.IsNullOrWhiteSpace(by) ? RequesterName : by;
				state.UpdatedAt		= DateTime.Now;

				db.SaveChanges();
			}

			log.Info("ارسال پیامک متوقف شد.");
		}

		public void Resume()
		{
			using (var db = CreateContext())
			{
				var state = SmsWorkerStateService.GetOrCreate(db);

				state.IsPaused		= false;
				state.PausedAt		= null;
				state.PausedAtShamsi= null;
				state.PausedBy		= null;
				state.UpdatedAt		= DateTime.Now;

				db.SaveChanges();
			}

			log.Info("ارسال پیامک ادامه یافت.");
		}

		// ==================================================================
		// کمکی
		// ==================================================================

		/// <summary>انتقال یک ردیف از صف به آرشیو با وضعیت نهایی مشخص.</summary>
		internal static void Archive(SmsBanContext db, SmsOutbox item, SmsMessageStatus status, string errorMessage)
		{
			db.tbl_SmsArchive.Add(new SmsArchive
			{
				OutboxID		= item.ID,
				SortOrder		= item.SortOrder,
				Priority		= item.Priority,
				PhoneNumber		= item.PhoneNumber,
				MessageText		= item.MessageText,
				PageCount		= item.PageCount,
				Status			= (int)status,
				RetryCount		= item.RetryCount,
				ErrorMessage	= errorMessage,
				CreatedAt		= item.CreatedAt,
				CreatedAtShamsi	= item.CreatedAtShamsi,
				EnqueuedBy		= item.EnqueuedBy
			});
		}
	}
}
