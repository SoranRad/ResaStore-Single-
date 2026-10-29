using System;

namespace SmsBan.Model
{
	/// <summary>
	/// پیامک دریافتی که از مودم/سیم‌کارت خوانده و در بانک ذخیره شده است.
	/// </summary>
	public class SmsInbox
	{
		public long				ID					{ get; set; }

		/// <summary>اندیس پیامک در حافظه‌ی مودم/سیم‌کارت.</summary>
		public int				ModemIndex			{ get; set; }

		public string			SmsCenter			{ get; set; }

		public string			SmsType				{ get; set; }

		public string			TelNumber			{ get; set; }

		/// <summary>زمان ثبت‌شده توسط اپراتور روی پیامک (رشته‌ای که مودم برمی‌گرداند).</summary>
		public string			TimeStamp			{ get; set; }

		public string			Discharge			{ get; set; }

		public string			SmsText				{ get; set; }

		public string			TPPid				{ get; set; }

		public string			TPDcs				{ get; set; }

		public string			TPVp				{ get; set; }

		public string			TPSt				{ get; set; }

		public string			SReference			{ get; set; }

		public int				AllPart				{ get; set; }

		/// <summary>
		/// تعداد پارت‌هایی که تا این لحظه از این پیامک دریافت و در همین ردیف ذخیره شده‌اند.
		/// وقتی پیامک کامل شد، این مقدار برابر <see cref="AllPart"/> می‌شود.
		/// </summary>
		public int				PartNo				{ get; set; }

		/// <summary>
		/// فهرست پارت‌های ذخیره‌شده‌ی یک پیامک چندپارتی، به شکل «شماره‌پارت:طول‌متن».
		/// مثال: <c>1:70,2:70,3:20</c>
		///
		/// نگه‌داشتن طول هر پارت این امکان را می‌دهد که اگر پارتی دیرتر برسد،
		/// متن موجود به پارت‌هایش شکسته شود و پارت تازه در جای درست خود قرار گیرد.
		/// برای پیامک‌های تک‌پارت خالی است.
		/// </summary>
		public string			ReceivedParts		{ get; set; }

		/// <summary>مشخصات مودمی که پیامک از آن خوانده شده است.</summary>
		public string			DeviceName			{ get; set; }

		public string			SimId				{ get; set; }

		/// <summary>اثر انگشت برای جلوگیری از ذخیره‌ی پیامک تکراری.</summary>
		public string			DedupHash			{ get; set; }

		public DateTime			ReceivedAt			{ get; set; }

		public string			ReceivedAtShamsi	{ get; set; }

		public bool				IsRead				{ get; set; }

		/// <summary>آیا این پیامک از حافظه‌ی مودم/سیم‌کارت حذف شده است.</summary>
		public bool				IsDeletedFromModem	{ get; set; }
	}
}
