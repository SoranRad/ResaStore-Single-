using MS_Control;
using SmsBan.Core;
using SmsBan.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SmsBan.UI.FormQueueManager;

namespace SmsBan.UI
{
	public partial class FormQueueMonitor : Form
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
		private readonly SmsContactService _contactService;


		private Timer _timer;

		/// <summary>برای جلوگیری از بارگذاری مجدد هنگام تغییر برنامه‌ای کمبوی آرشیو.</summary>
		private bool _suppressReload;
		 
		#endregion

		public FormQueueMonitor(SmsBanService service)
		{
			if (service == null)
				throw new ArgumentNullException("service");

			_service = service;
			_contactService = new SmsContactService(service.Options);


			InitializeComponent();

			_suppressReload = true;
			NsState.SelectedIndex = 0;
			_suppressReload = false;
		}

		#region Methods

		private void ReloadAll()
		{
			ReloadQueue();
			ReloadArchive();
			//UpdatePauseButton();
		}

		private void ReloadQueue()
		{
			try
			{
				var rows = _service.GetQueue(new SmsQueueFilter { MaxRows = 2000 });
				var map = BuildContactMap();

				foreach (var row in rows)
					row.ContactName = ResolveContactName(map, row.PhoneNumber);

				gridQueue.DataSource = rows;
				 
			}
			catch (Exception ex)
			{
				log.Error(ex);
				MS_Message.Show("خطا در خواندن صف ارسال", "خطا", ex.Message, MessageBoxButtons.OK);
			}
		}

		
		private void ReloadArchive()
		{
			try
			{
				SmsMessageStatus? status = null;

				switch (NsState.SelectedIndex)
				{
					case 1: status = SmsMessageStatus.Sent; break;
					case 2: status = SmsMessageStatus.Failed; break;
					case 3: status = SmsMessageStatus.Canceled; break;
				}

				var from = NsDateFrom.MS_Tarikh?.ToDatetime();
				var to = NsDateTo.MS_Tarikh?.ToDatetime();



				var rows = _service.GetArchive(status,from, to, (int)NsCount.MS_Decimal);
				var map = BuildContactMap();



				NsGridArchives.DataSource = rows
					.Select(x => new ArchiveRow
					{
						ID = x.ID,
						StatusText = SmsTexts.Status(x.Status),
						ContactName		= ResolveContactName(map, x.PhoneNumber),
						PhoneNumber = x.PhoneNumber,
						MessageText = x.MessageText,
						PageCount = x.PageCount,
						CreatedAtShamsi = x.CreatedAtShamsi,
						SentAtShamsi = x.SentAtShamsi,
						SmsReference = x.SmsReference,
						IsDelivered = x.IsDelivered ? "بله" : "خیر",
						ErrorMessage = x.ErrorMessage
					})
					.ToList();
			}
			catch (Exception ex)
			{
				log.Error(ex);
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
						var status = _service.GetModemStatus();
						var quota = _service.GetQuota();

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

		#endregion

		private void FormQueueMonitor_Shown(object sender, EventArgs e)
		{
			ReloadAll();
		}
	}
}
