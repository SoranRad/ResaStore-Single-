using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using MS_Control;
using MS_Control.MainForms;
using SmsBan.Core;
using SmsBan.Model;

namespace SmsBan.UI
{
	/// <summary>
	/// فرم مدیریت صف ارسال پیامک.
	///
	/// امکانات: نمایش صف، نمایش آرشیو، لغو، تغییر اولویت، جابه‌جایی دستی،
	/// بازگرداندن پیامک‌های ناموفق به صف و توقف/ادامه‌ی ارسال.
	///
	/// این فرم به روش استاندارد ویژوال استودیو نوشته شده است:
	/// کد رابط کاربری در فایل <c>FormQueueManager.Designer.cs</c> قرار دارد
	/// و از طریق Designer قابل ویرایش است.
	///
	/// توجه: ستون‌های دو گرید در متد <see cref="SetupGrids"/> در همین فایل
	/// تعریف شده‌اند (نه در Designer) تا هنگام ویرایش فرم در Designer از بین نروند.
	/// برای تغییر عنوان یا عرض ستون‌ها همین متد را ویرایش کنید.
	/// </summary>
	public partial class FormQueueManager : Form_Mother_IRANSans
	{
		#region Logging

		private static readonly log4net.ILog log =
			log4net
				.LogManager
				.GetLogger
				(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		#endregion

		#region Fields

		private readonly SmsBanService _service;

		/// <summary>برای یافتن نام مخاطب از روی شماره.</summary>
		private readonly SmsContactService _contactService;

		private Timer _timer;

		/// <summary>برای جلوگیری از بارگذاری مجدد هنگام تغییر برنامه‌ای کمبوی آرشیو.</summary>
		private bool _suppressReload;

		/// <summary>ستون‌های گریدها یک‌بار تعریف می‌شوند.</summary>
		private bool _queueColumnsReady;

		private bool _archiveColumnsReady;
		#endregion

		#region Constructor

		public FormQueueManager(SmsBanService service)
		{
			if (service == null)
				throw new ArgumentNullException("service");

			_service = service;
			_contactService = new SmsContactService(service.Options);

			InitializeComponent();

			_suppressReload = true;
			cmbArchiveStatus.SelectedIndex = 0;
			_suppressReload = false;
		}
		#endregion

		#region Grid Setup

		/// <summary>
		/// تعریف ستون‌های گرید صف؛ فقط یک‌بار و در صورت آماده بودن گرید.
		/// این متد عمداً بیرون از فایل Designer نگه داشته شده تا با بازتولید
		/// کد طراحی، ستون‌ها حذف نشوند.
		/// </summary>
		private void EnsureQueueColumns()
		{
			if (_queueColumnsReady)
				return;

			var table = gridQueue.RootTable;

			if (table == null)
				return;

			try
			{
				table.Columns.Clear();

				AddColumn(table.Columns, "ID",				"شناسه",			60,	 TextAlignment.Center);
				AddColumn(table.Columns, "PriorityText",	"اولویت",			80,	 TextAlignment.Center);
				AddColumn(table.Columns, "ContactName",		"مخاطب",			130, TextAlignment.Near);
				AddColumn(table.Columns, "PhoneNumber",		"شماره",			130, TextAlignment.Center);
				AddColumn(table.Columns, "MessageText",		"متن پیامک",		320, TextAlignment.Near);
				AddColumn(table.Columns, "PageCount",		"صفحه",				60,	 TextAlignment.Center);
				AddColumn(table.Columns, "StatusText",		"وضعیت",			110, TextAlignment.Center);
				AddColumn(table.Columns, "RetryCount",		"بازگشت",			70,	 TextAlignment.Center);
				AddColumn(table.Columns, "CreatedAtShamsi",	"تاریخ ثبت",		140, TextAlignment.Center);
				AddColumn(table.Columns, "EnqueuedBy",		"درخواست‌دهنده",	130, TextAlignment.Center);
				AddColumn(table.Columns, "LastError",		"آخرین خطا",		200, TextAlignment.Near);

				_queueColumnsReady = true;
			}
			catch (Exception ex)
			{
				log.Error(ex);
			}
		}

		/// <summary>تعریف ستون‌های گرید آرشیو؛ فقط یک‌بار و در صورت آماده بودن گرید.</summary>
		private void EnsureArchiveColumns()
		{
			//if (_archiveColumnsReady)
			//	return;

			//var table = gridArchive.RootTable;

			//if (table == null)
			//	return;

			//try
			//{
			//	table.Columns.Clear();

			//	AddColumn(table.Columns, "ID",				"شناسه",			60,	 TextAlignment.Center);
			//	AddColumn(table.Columns, "StatusText",		"وضعیت",			110, TextAlignment.Center);
			//	AddColumn(table.Columns, "PhoneNumber",		"شماره",			130, TextAlignment.Center);
			//	AddColumn(table.Columns, "MessageText",		"متن پیامک",		300, TextAlignment.Near);
			//	AddColumn(table.Columns, "PageCount",		"صفحه",				60,	 TextAlignment.Center);
			//	AddColumn(table.Columns, "CreatedAtShamsi",	"تاریخ ثبت",		140, TextAlignment.Center);
			//	AddColumn(table.Columns, "SentAtShamsi",	"زمان ارسال",		140, TextAlignment.Center);
			//	AddColumn(table.Columns, "SmsReference",	"مرجع",				90,	 TextAlignment.Center);
			//	AddColumn(table.Columns, "IsDelivered",		"تحویل",			60,	 TextAlignment.Center);
			//	AddColumn(table.Columns, "ErrorMessage",	"خطا",				200, TextAlignment.Near);

			//	_archiveColumnsReady = true;
			//}
			//catch (Exception ex)
			//{
			//	log.Error(ex);
			//}
		}

		private static void AddColumn(GridEXColumnCollection table,
			string dataMember, string caption, int width, TextAlignment alignment)
		{
			var column = new GridEXColumn();

			column.DataMember		= dataMember;
			column.Caption			= caption;
			column.Width			= width;
			column.Visible			= true;
			column.TextAlignment	= alignment;

			table.Add(column);
		}
		#endregion

		#region Methods

		private void ReloadAll()
		{
			ReloadQueue();
			ReloadArchive();
			UpdatePauseButton();
		}

		private void ReloadQueue()
		{
			try
			{
				var rows	= _service.GetQueue(new SmsQueueFilter { MaxRows = 2000 });
				var map		= BuildContactMap();

				foreach (var row in rows)
					row.ContactName = ResolveContactName(map, row.PhoneNumber);

				EnsureQueueColumns();

				gridQueue.DataSource = rows;

				lblStatus.Text = string.Format("تعداد در صف: {0}", rows.Count);
			}
			catch (Exception ex)
			{
				log.Error(ex);
				lblStatus.Text = "خطا در خواندن صف: " + ex.Message;
			}
		}

		/// <summary>
		/// نمایه‌ی «شماره‌ی نرمال‌شده → نام مخاطب» از دفترچه‌ی اشخاص.
		/// هر شماره فقط یک‌بار خوانده می‌شود تا برای هر ردیف صف به بانک مراجعه نشود.
		/// </summary>
		private Dictionary<string, string> BuildContactMap()
		{
			var map = new Dictionary<string, string>(StringComparer.Ordinal);

			try
			{
				foreach (var contact in _contactService.GetContacts())
				{
					foreach (var phone in contact.InternationalPhones)
					{
						if (!map.ContainsKey(phone))
							map[phone] = contact.DisplayName;
					}
				}
			}
			catch (Exception ex)
			{
				log.Error(ex);
			}

			return map;
		}

		/// <summary>نام مخاطب برای یک شماره؛ اگر در دفترچه نباشد «ناشناس».</summary>
		private string ResolveContactName(Dictionary<string, string> map, string phoneNumber)
		{
			if (map == null)
				return SmsContactService.UnknownDisplayName;

			var key = SmsPhoneNumber.Normalize(phoneNumber, _service.Options.CountryCode);

			string name;

			if (!string.IsNullOrEmpty(key) && map.TryGetValue(key, out name))
				return name;

			return SmsContactService.UnknownDisplayName;
		}

		private void ReloadArchive()
		{
			try
			{
				SmsMessageStatus? status = null;

				switch (cmbArchiveStatus.SelectedIndex)
				{
					case 1: status = SmsMessageStatus.Sent;		break;
					case 2: status = SmsMessageStatus.Failed;	break;
					case 3: status = SmsMessageStatus.Canceled;	break;
				}

				var rows = _service.GetArchive(status, null, null, 2000);
				var map  = BuildContactMap();

				EnsureArchiveColumns();

				gridArchive.DataSource = rows
					.Select(x => new ArchiveRow
					{
						ID				= x.ID,
						StatusText		= SmsTexts.Status(x.Status),
						ContactName		= ResolveContactName(map, x.PhoneNumber),
						PhoneNumber		= x.PhoneNumber,
						MessageText		= x.MessageText,
						PageCount		= x.PageCount,
						CreatedAtShamsi	= x.CreatedAtShamsi,
						SentAtShamsi	= x.SentAtShamsi,
						SmsReference	= x.SmsReference,
						IsDelivered		= x.IsDelivered ? "بله" : "خیر",
						ErrorMessage	= x.ErrorMessage
					})
					.ToList();
			}
			catch (Exception ex)
			{
				log.Error(ex);
			}
		}

		private void UpdatePauseButton()
		{
			try
			{
				btnPauseResume.Text = _service.IsPaused() ? "ادامه ارسال" : "توقف ارسال";
			}
			catch (Exception ex)
			{
				log.Error(ex);
			}
		}

		private long? GetSelectedQueueId()
		{
			var row = gridQueue.CurrentRow;

			if (row == null)
				return null;

			var item = row.DataRow as SmsQueueItem;

			return item != null ? item.ID : (long?)null;
		}

		private void Run(Func<bool> action, string caption)
		{
			try
			{
				action();
				ReloadAll();
			}
			catch (Exception ex)
			{
				log.Error(ex);
				MS_Message.Show(this, "خطا", "خطا در " + caption, ex.Message, MessageBoxButtons.OK);
			}
		}

		private void ActOnSelected(Func<long, bool> action, string caption)
		{
			var id = GetSelectedQueueId();

			if (id == null)
			{
				MS_Message.Show(this, "ابتدا یک ردیف از صف را انتخاب کنید.", "اطلاع");
				return;
			}

			Run(() => action(id.Value), caption);
		}

		private void ChangePriority(SmsPriority priority)
		{
			var id = GetSelectedQueueId();

			if (id == null)
			{
				MS_Message.Show(this, "ابتدا یک ردیف از صف را انتخاب کنید.", "اطلاع");
				return;
			}

			Run(() => _service.ChangePriority(id.Value, priority), "تغییر اولویت");
		}
		#endregion

		#region Event Handlers

		private void FormQueueManager_Load(object sender, EventArgs e)
		{
			ReloadAll();

			_timer = new Timer { Interval = 5000 };
			_timer.Tick += Timer_Tick;
			_timer.Start();
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			ReloadAll();
		}

		private void FormQueueManager_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (_timer == null)
				return;

			_timer.Stop();
			_timer.Dispose();
			_timer = null;
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			ReloadAll();
		}

		private void btnTop_Click(object sender, EventArgs e)
		{
			ActOnSelected(id => _service.MoveToTop(id), "انتقال به ابتدا");
		}

		private void btnUp_Click(object sender, EventArgs e)
		{
			ActOnSelected(id => _service.MoveUp(id), "انتقال به بالا");
		}

		private void btnDown_Click(object sender, EventArgs e)
		{
			ActOnSelected(id => _service.MoveDown(id), "انتقال به پایین");
		}

		private void btnBottom_Click(object sender, EventArgs e)
		{
			ActOnSelected(id => _service.MoveToBottom(id), "انتقال به انتها");
		}

		private void btnUrgent_Click(object sender, EventArgs e)
		{
			ChangePriority(SmsPriority.Urgent);
		}

		private void btnMedium_Click(object sender, EventArgs e)
		{
			ChangePriority(SmsPriority.Medium);
		}

		private void btnNormal_Click(object sender, EventArgs e)
		{
			ChangePriority(SmsPriority.Normal);
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			var id = GetSelectedQueueId();

			if (id == null)
			{
				MS_Message.Show(this, "ابتدا یک ردیف از صف را انتخاب کنید.", "اطلاع");
				return;
			}

			var confirm = MS_Message.Show(this, "تأیید لغو", "تأیید لغو",
				"آیا این ردیف از صف لغو شود؟", MessageBoxButtons.YesNo);

			if (confirm != DialogResult.Yes)
				return;

			Run(() => _service.Cancel(id.Value), "لغو ردیف");
		}

		private void btnCancelAll_Click(object sender, EventArgs e)
		{
			var confirm = MS_Message.Show(this, "تأیید لغو گروهی", "تأیید لغو گروهی",
				"تمام ردیف‌های در انتظار لغو شوند؟", MessageBoxButtons.YesNo);

			if (confirm != DialogResult.Yes)
				return;

			try
			{
				var count = _service.CancelAllPending();

				ReloadAll();

				MS_Message.Show(this, string.Format("{0} ردیف لغو شد.", count), "اطلاع");
			}
			catch (Exception ex)
			{
				log.Error(ex);
				MS_Message.Show(this, "خطا", "خطا در لغو گروهی", ex.Message, MessageBoxButtons.OK);
			}
		}

		private void btnPauseResume_Click(object sender, EventArgs e)
		{
			try
			{
				if (_service.IsPaused())
					_service.Resume();
				else
					_service.Pause(Environment.MachineName);

				UpdatePauseButton();
			}
			catch (Exception ex)
			{
				log.Error(ex);
				MS_Message.Show(this, "خطا", "خطا در تغییر وضعیت ارسال", ex.Message, MessageBoxButtons.OK);
			}
		}

		private void btnStatus_Click(object sender, EventArgs e)
		{
			try
			{
				var status	= _service.GetModemStatus();
				var quota	= _service.GetQuota();

				var text = string.Format(
					"مودم: {0}\r\nنسخه نرم‌افزار: {1}\r\nاتصال: {2}   آماده: {3}\r\nآنتن: {4}\r\n" +
					"IMEI: {5}\r\nSIM: {6}\r\nمرکز پیامک: {7}\r\n" +
					"تعداد دستگاه شناسایی‌شده: {8}   شماره دستگاه انتخاب‌شده: {9}\r\n\r\n" +
					"سهمیه دقیقه: {10} از {11}   (باقی‌مانده {12})\r\n" +
					"سهمیه روز: {13} از {14}   (باقی‌مانده {15})\r\n\r\n{16}",
					status.DeviceInfo,
					status.SoftwareVersion,
					status.Connected,
					status.Ready,
					status.Signal,
					status.Imei,
					status.SimId,
					status.SmsCenter,
					status.DeviceCount,
					status.SelectedDeviceNumber,
					quota.MinuteUsed, quota.MinuteLimit, quota.MinuteRemaining,
					quota.DayUsed, quota.DayLimit, quota.DayRemaining,
					status.LastError);

				MS_Message.Show(this, "وضعیت مودم", "وضعیت مودم", text, MessageBoxButtons.OK);
			}
			catch (Exception ex)
			{
				log.Error(ex);
				MS_Message.Show(this, "خطا", "خطا در خواندن وضعیت", ex.Message, MessageBoxButtons.OK);
			}
		}

		private void cmbArchiveStatus_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (_suppressReload)
				return;

			ReloadArchive();
		}

		private void btnRetry_Click(object sender, EventArgs e)
		{
			var row = gridArchive.CurrentRow;

			if (row == null)
			{
				MS_Message.Show(this, "ابتدا یک ردیف از آرشیو را انتخاب کنید.", "اطلاع");
				return;
			}

			var archiveRow = row.DataRow as ArchiveRow;

			if (archiveRow == null)
				return;

			Run(() => _service.RetryFailed(archiveRow.ID), "بازگشت به صف");
		}

		#endregion
		#region Nested Types
		#endregion
	}
}
