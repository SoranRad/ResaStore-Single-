using System;

namespace SmsBan.Core
{
	/// <summary>
	/// دسته‌بندی وضعیت مودم/سرویس پیامک.
	/// </summary>
	public enum SmsStateKind : byte
	{
		/// <summary>رخداد موفق: اتصال برقرار شد، پیامک ارسال شد، پیامک رسید.</summary>
		Success = 0,

		/// <summary>هشدار: مشکل موقت؛ سرویس ادامه می‌دهد.</summary>
		Warning = 1,

		/// <summary>خطا: اتصال برقرار نشد یا ارسال شکست خورد.</summary>
		Error = 2
	}

	/// <summary>
	/// اطلاعات یک تغییر وضعیت سرویس پیامک.
	/// </summary>
	public class SmsStateChangedEventArgs : EventArgs
	{
		/// <summary>دسته‌ی رخداد.</summary>
		public SmsStateKind	Kind		{ get; set; }

		/// <summary>متن فارسی توضیح وضعیت.</summary>
		public string		Message		{ get; set; }

		/// <summary>شماره‌ی مرتبط (برای رخدادهای ارسال)؛ در غیر این صورت null.</summary>
		public string		PhoneNumber	{ get; set; }

		/// <summary>نام/مشخصات مودم در لحظه‌ی رخداد؛ اگر در دسترس نباشد null.</summary>
		public string		DeviceName	{ get; set; }

		/// <summary>زمان رخداد.</summary>
		public DateTime		OccurredAt	{ get; set; }

		/// <summary>متن کوتاه برای نمایش، مثل «[خطا] اتصال به مودم برقرار نشد».</summary>
		public string		DisplayText
		{
			get
			{
				var label = Kind == SmsStateKind.Success ? "موفق"
						  : Kind == SmsStateKind.Warning ? "هشدار"
						  : "خطا";

				return string.Format("[{0}] {1}", label, Message);
			}
		}

		public override string ToString()
		{
			return string.Format("{0} - {1}", OccurredAt.ToString("HH:mm:ss"), DisplayText);
		}
	}

	/// <summary>
	/// پخش‌کننده‌ی رویدادهای وضعیت پیامک.
	///
	/// یک نمونه از این کلاس در <see cref="SmsBanService"/> ساخته و به سرویس‌های
	/// داخلی (ارسال/دریافت) داده می‌شود تا همه بتوانند رخداد منتشر کنند.
	///
	/// نکته: رخدادهای تکراریِ پشت‌سرهم (همان دسته و همان متن و همان شماره)
	/// منتشر نمی‌شوند تا هنگام قطع بودن مودم، هر چند ثانیه یک پیام تکراری نرسد.
	/// </summary>
	public class SmsStateNotifier
	{
		private readonly object _lock = new object();

		private string _lastKey;

		/// <summary>رخداد تغییر وضعیت.</summary>
		public event EventHandler<SmsStateChangedEventArgs> StateChanged;

		public void Success(string message)									{ Raise(SmsStateKind.Success, message, null, null); }
		public void Success(string message, string phoneNumber)				{ Raise(SmsStateKind.Success, message, phoneNumber, null); }
		public void Warning(string message)									{ Raise(SmsStateKind.Warning, message, null, null); }
		public void Warning(string message, string phoneNumber)				{ Raise(SmsStateKind.Warning, message, phoneNumber, null); }
		public void Error(string message)									{ Raise(SmsStateKind.Error, message, null, null); }
		public void Error(string message, string phoneNumber)				{ Raise(SmsStateKind.Error, message, phoneNumber, null); }

		/// <summary>انتشار یک رخداد وضعیت.</summary>
		public void Raise(SmsStateKind kind, string message, string phoneNumber, string deviceName)
		{
			if (string.IsNullOrWhiteSpace(message))
				return;

			var key = string.Format("{0}|{1}|{2}", (int)kind, message, phoneNumber ?? string.Empty);

			lock (_lock)
			{
				if (string.Equals(_lastKey, key, StringComparison.Ordinal))
					return;		// همان وضعیت قبلی؛ رخداد تازه‌ای رخ نداده است

				_lastKey = key;
			}

			var handler = StateChanged;

			if (handler == null)
				return;

			var args = new SmsStateChangedEventArgs
			{
				Kind		= kind,
				Message		= message,
				PhoneNumber	= phoneNumber,
				DeviceName	= deviceName,
				OccurredAt	= DateTime.Now
			};

			try
			{
				handler(this, args);
			}
			catch (Exception ex)
			{
				// خطای مصرف‌کننده نباید چرخه‌ی ارسال/دریافت را متوقف کند.
				log4net
					.LogManager
					.GetLogger(typeof(SmsStateNotifier))
					.Error("خطا در اجرای شنونده‌ی رویداد وضعیت پیامک.", ex);
			}
		}

		/// <summary>پاک‌کردن حافظه‌ی «آخرین وضعیت» تا رخداد بعدی دوباره منتشر شود.</summary>
		public void Reset()
		{
			lock (_lock)
			{
				_lastKey = null;
			}
		}
	}

	/// <summary>
	/// نتیجه‌ی بررسی وضعیت ارسال/تحویل یک پیامک با تابع بافر مودم.
	/// </summary>
	public class SmsDeliveryCheck
	{
		/// <summary>آیا رکورد آرشیو پیدا شد.</summary>
		public bool		Found		{ get; set; }

		/// <summary>مودم اعلام کرد ارسال تمام شده است.</summary>
		public bool		SendDone	{ get; set; }

		/// <summary>مودم اعلام کرد پیامک تحویل شده است.</summary>
		public bool		Delivered	{ get; set; }

		/// <summary>شماره‌ی مرجع ذخیره‌شده برای این رکورد.</summary>
		public string	Reference	{ get; set; }

		/// <summary>توضیح نتیجه برای نمایش به کاربر.</summary>
		public string	Message	{ get; set; }
	}
}
