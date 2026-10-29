using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using SmsBan.DataLayer.Context;

namespace SmsBan.Core
{
	/// <summary>
	/// یک مخاطب (شخص) همراه با شماره‌های موبایل او.
	/// </summary>
	public class SmsContact
	{
		public long		ID				{ get; set; }

		/// <summary>عنوان/نام شخص از جدول اشخاص.</summary>
		public string	Title			{ get; set; }

		public string	Mobile1			{ get; set; }

		public string	Mobile2			{ get; set; }

		public string	Mobile3			{ get; set; }

		public string	Mobile4			{ get; set; }

		/// <summary>نام قابل نمایش (در صورت خالی بودن عنوان، «بدون نام»).</summary>
		public string	DisplayName		{ get; set; }

		/// <summary>
		/// true یعنی این شماره در دفترچه‌ی اشخاص نیست و با نام «ناشناس» نمایش داده می‌شود.
		/// </summary>
		public bool		IsUnknown		{ get; set; }

		/// <summary>شماره‌ی اصلی برای ارسال؛ ملی و بدون کد کشور (مثلاً 9123456789).</summary>
		public string	PrimaryMobile	{ get; set; }

		/// <summary>شماره‌ی اصلی با قالب نمایشی، مثلاً 912-345-6789.</summary>
		public string	DisplayMobile	{ get; set; }

		/// <summary>همه‌ی شماره‌های این شخص، ملی و بدون کد کشور (مثلاً 9123456789).</summary>
		public List<string> Phones		{ get; set; }

		/// <summary>
		/// همان شماره‌ها با پیش‌شماره‌ی کشور (مثلاً 989123456789)؛
		/// فقط برای تطبیق با شماره‌های ذخیره‌شده در بانک اطلاعاتی.
		/// </summary>
		internal List<string> InternationalPhones { get; set; }

		/// <summary>همه‌ی حالت‌های نوشتن شماره‌ها، برای جست‌وجوی پیامک‌ها.</summary>
		public List<string> Variants	{ get; set; }

		/// <summary>آخرین زمان ارسال یا دریافت پیامک برای این شخص.</summary>
		public DateTime?	LastActivity		{ get; set; }

		public string		LastActivityText	{ get; set; }

		public override string ToString()
		{
			return string.Format("{0} - {1}", DisplayName, PrimaryMobile);
		}
	}

	/// <summary>
	/// خواندن فهرست اشخاص و مرتب‌سازی آن‌ها بر اساس تازه‌ترین پیامک.
	/// </summary>
	public class SmsContactService
	{
		/// <summary>
		/// نام نمایشی برای شماره‌هایی که پیامک دارند ولی در دفترچه‌ی اشخاص نیستند.
		/// </summary>
		public const string UnknownDisplayName = "ناشناس";

		#region Logging

		private static readonly log4net.ILog log =
			log4net
				.LogManager
				.GetLogger
				(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		#endregion

		/// <summary>
		/// دستور خواندن اشخاص؛ دقیقاً همان دستوری که برای این ماژول تعیین شده است.
		/// </summary>
		private const string ContactsSql = @"
SELECT
    ID,
    LTRIM(RTRIM(title))      AS Title,
    LTRIM(RTRIM(mobile))     AS Mobile1,
    LTRIM(RTRIM(mobDowom))   AS Mobile2,
    LTRIM(RTRIM(tel))        AS Mobile3,
    LTRIM(RTRIM(telDowom ))  AS Mobile4
FROM base.tbl_Ashxas";

		private readonly SmsBanOptions			_options;
		private readonly SmsConversationService	_conversation;

		public SmsContactService(SmsBanOptions options)
		{
			if (options == null)
				throw new ArgumentNullException("options");

			_options		= options;
			_conversation	= new SmsConversationService(options);
		}

		/// <summary>
		/// خواندن خام اشخاص از بانک اطلاعاتی.
		/// </summary>
		public List<SmsContact> GetContacts()
		{
			var result = new List<SmsContact>();

			List<SmsContactRow> rows;

			try
			{
				using (var db = SmsBanDb.Create(_options.ConnectionString))
				{
					rows = db.Database.SqlQuery<SmsContactRow>(ContactsSql).ToList();
				}
			}
			catch (Exception ex)
			{
				log.Error("خواندن فهرست اشخاص ناموفق بود.", ex);
				return result;
			}

			foreach (var row in rows)
			{
				var contact = BuildContact(row);

				if (contact != null)
					result.Add(contact);
			}

			return result;
		}

		/// <summary>
		/// فهرست مخاطبان دارای پیامک (ارسالی یا دریافتی)، مرتب‌شده بر اساس
		/// تازه‌ترین پیامک.
		///
		/// شامل دو دسته است:
		///   ۱) اشخاص ثبت‌شده در دفترچه که پیامک دارند.
		///   ۲) شماره‌هایی که پیامک دارند ولی در دفترچه نیستند؛
		///      این‌ها با نام «ناشناس» نمایش داده می‌شوند.
		///
		/// اشخاصی که هیچ پیامکی ندارند در خروجی نمی‌آیند.
		/// شماره‌ها در <see cref="SmsContact.Phones"/> به شکل ملی (9123456789) هستند.
		/// </summary>
		public List<SmsContact> GetContactsOrderedByLastMessage()
		{
			var activity	= _conversation.GetLastActivity();
			var result		= new List<SmsContact>();
			var knownPhones	= new HashSet<string>();

			// ---------- ۱) مخاطبان ثبت‌شده ----------
			foreach (var contact in GetContacts())
			{
				foreach (var phone in contact.InternationalPhones)
					knownPhones.Add(phone);

				DateTime date;
				DateTime? latest = null;

				// تطبیق با شماره‌های دارای پیش‌شماره، همان‌طور که در بانک ذخیره شده‌اند.
				foreach (var phone in contact.InternationalPhones)
				{
					if (!activity.TryGetValue(phone, out date))
						continue;

					if (latest == null || date > latest.Value)
						latest = date;
				}

				if (latest == null)
					continue;		// بدون هیچ پیامکی → نمایش داده نمی‌شود

				contact.LastActivity		= latest;
				contact.LastActivityText	= JalaliDate.ToShamsi(latest.Value);

				result.Add(contact);
			}

			// ---------- ۲) شماره‌های ناشناس ----------
			foreach (var item in activity)
			{
				if (knownPhones.Contains(item.Key))
					continue;		// متعلق به یکی از مخاطبان ثبت‌شده است

				result.Add(BuildUnknownContact(item.Key, item.Value));
			}

			return result
				.OrderByDescending(x => x.LastActivity)
				.ThenBy(x => x.DisplayName)
				.ThenBy(x => x.DisplayMobile)
				.ToList();
		}

		/// <summary>
		/// ساخت یک مخاطب «ناشناس» برای شماره‌ای که در دفترچه نیست ولی پیامک دارد.
		/// </summary>
		private SmsContact BuildUnknownContact(string internationalPhone, DateTime lastActivity)
		{
			var national = SmsPhoneNumber.ToNational(internationalPhone, _options.CountryCode);

			return new SmsContact
			{
				ID					= BuildUnknownID(national),
				IsUnknown			= true,
				DisplayName			= UnknownDisplayName,
				PrimaryMobile		= national,
				DisplayMobile		= SmsPhoneNumber.FormatNationalDigits(national),
				Phones				= new List<string> { national },
				InternationalPhones	= new List<string> { internationalPhone },
				Variants			= new List<string>(
										  SmsPhoneNumber.Variants(internationalPhone, _options.CountryCode)),
				LastActivity		= lastActivity,
				LastActivityText	= JalaliDate.ToShamsi(lastActivity)
			};
		}

		/// <summary>
		/// شناسه‌ی پایدار و منفی برای مخاطب ناشناس.
		/// منفی بودن باعث می‌شود با شناسه‌های واقعی (مثبت) تداخل نداشته باشد
		/// و یکتایی‌اش تضمین شود تا انتخاب در فهرست درست کار کند.
		/// </summary>
		private static long BuildUnknownID(string national)
		{
			long value;

			if (long.TryParse(national, out value) && value > 0)
				return -value;

			return -1;
		}

		private SmsContact BuildContact(SmsContactRow row)
		{
			if (row == null)
				return null;

			var phones			= new List<string>();	// ملی، مثلاً 9123456789
			var international	= new List<string>();	// با کد کشور، مثلاً 989123456789
			var variants		= new List<string>();

			foreach (var raw in new[] { row.Mobile1, row.Mobile2, row.Mobile3, row.Mobile4 })
			{
				var normalized = SmsPhoneNumber.Normalize(raw, _options.CountryCode);

				if (string.IsNullOrEmpty(normalized) || international.Contains(normalized))
					continue;

				international.Add(normalized);

				var national = SmsPhoneNumber.ToNational(normalized, _options.CountryCode);

				if (national.Length > 0 && !phones.Contains(national))
					phones.Add(national);

				foreach (var variant in SmsPhoneNumber.Variants(normalized, _options.CountryCode))
				{
					if (!variants.Contains(variant))
						variants.Add(variant);
				}
			}

			if (phones.Count == 0)
				return null;		// شخص بدون شماره‌ی معتبر

			var title = string.IsNullOrWhiteSpace(row.Title) ? "بدون نام" : row.Title.Trim();

			return new SmsContact
			{
				ID					= row.ID,
				Title				= row.Title,
				Mobile1				= row.Mobile1,
				Mobile2				= row.Mobile2,
				Mobile3				= row.Mobile3,
				Mobile4				= row.Mobile4,
				DisplayName			= title,
				PrimaryMobile		= phones[0],
				DisplayMobile		= SmsPhoneNumber.FormatNationalDigits(phones[0]),
				Phones				= phones,
				InternationalPhones	= international,
				Variants			= variants
			};
		}

		/// <summary>
		/// ردیف خام جدول اشخاص (فقط برای نگاشت نتیجه‌ی دستور SQL).
		/// </summary>
		private class SmsContactRow
		{
			public long		ID			{ get; set; }
			public string	Title		{ get; set; }
			public string	Mobile1		{ get; set; }
			public string	Mobile2		{ get; set; }
			public string	Mobile3		{ get; set; }
			public string	Mobile4		{ get; set; }
		}
	}
}
