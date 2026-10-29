using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using MS_Control;
using SmsBan.Core;
using SmsBan.Modem;

namespace SmsBan.UI
{
	/// <summary>
	/// یک مخاطب در فهرست سمت راست فرم مدیریت حافظه.
	/// پیامک‌های همین مخاطب که در حافظه‌ی دستگاه هستند در <see cref="Messages"/> قرار دارد.
	/// </summary>
	public class DeviceContactItem
	{
		/// <summary>اطلاعات مخاطب (نام، شماره، حالت‌های جست‌وجو).</summary>
		public SmsContact			Contact		{ get; set; }

		/// <summary>پیامک‌های این مخاطب در حافظه‌ی دستگاه.</summary>
		public List<DeviceSmsGroup>	Messages	{ get; set; }

		public string DisplayName		{ get { return Contact == null ? string.Empty : Contact.DisplayName; } }

		public string DisplayMobile		{ get { return Contact == null ? string.Empty : Contact.DisplayMobile; } }

		public int MessageCount			{ get { return Messages == null ? 0 : Messages.Count; } }

		public int PartCount			{ get { return Messages == null ? 0 : Messages.Sum(x => x.PartCount); } }

		public string MessageCountText
		{
			get
			{
				if (MessageCount == 0)
					return "بدون پیامک";

				return string.Format("{0} ({1} پارت)", MessageCount, PartCount);
			}
		}
	}

	/// <summary>
	/// مدیریت حافظه‌ی پیامک مودم/سیم‌کارت.
	///
	/// سمت راست: مخاطبانی که در حافظه‌ی دستگاه پیامک دارند.
	/// سمت چپ: پیامک‌های مخاطب انتخاب‌شده (پارت‌های یک پیامک یک ردیف هستند).
	/// بالا: آمار حافظه‌ی دستگاه.
	/// </summary>
	public partial class FormDeviceMemory : MS_Control.MainForms.Form_Mother_IRANSans
	{
		#region Logging
		private static readonly log4net.ILog log =
			log4net
				.LogManager
				.GetLogger
					(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		#endregion

		#region Fields
		private readonly SmsBanService		_service;
		private readonly SmsContactService	_contactService;

		private List<DeviceSmsGroup>		_deviceMessages	= new List<DeviceSmsGroup>();
		private List<DeviceContactItem>		_contacts		= new List<DeviceContactItem>();

		private DeviceContactItem			_selectedContact;

		private bool						_contactColumnsReady;
		private bool						_messageColumnsReady;
		private bool						_suppressSelection;
		#endregion

		public FormDeviceMemory(SmsBanService service)
		{
			if (service == null)
				throw new ArgumentNullException("service");

			_service		= service;
			_contactService	= new SmsContactService(service.Options);

			InitializeComponent();
		}

		#region Load / Reload

		private void FormDeviceMemory_Load(object sender, EventArgs e)
		{
			EnsureContactColumns();
			EnsureMessageColumns();
			Reload();
		}

		/// <summary>خواندن دوباره‌ی حافظه‌ی دستگاه و به‌روزرسانی همه‌ی بخش‌ها.</summary>
		private void Reload()
		{
			try
			{
				Cursor			= Cursors.WaitCursor;
				lblStatus.Text	= "در حال خواندن حافظه دستگاه...";

				_deviceMessages = _service.ReadDeviceGroups() ?? new List<DeviceSmsGroup>();

				BuildContacts();
				LoadStats();

				_suppressSelection = true;

				gridContacts.DataSource = null;
				gridContacts.DataSource = _contacts;

				_suppressSelection = false;

				if (_contacts.Count > 0)
					SelectContact(_contacts[0]);
				else
				{
					_selectedContact = null;
					gridMessages.DataSource = null;
					lblMessagesTitle.Text = "پیامک‌های حافظه دستگاه";
				}

				lblStatus.Text = string.Format("{0} پیامک، {1} مخاطب",
					_deviceMessages.Count, _contacts.Count);
			}
			catch (Exception ex)
			{
				log.Error(ex);
				lblStatus.Text = "خطا در خواندن حافظه: " + ex.Message;
			}
			finally
			{
				Cursor = Cursors.Default;
			}
		}

		#endregion

		#region Contacts

		/// <summary>
		/// ساخت فهرست مخاطبانی که در حافظه‌ی دستگاه پیامک دارند.
		/// نام هر شماره از دفترچه‌ی اشخاص گرفته می‌شود و اگر پیدا نشود «ناشناس» است.
		/// </summary>
		private void BuildContacts()
		{
			var code = _service.Options.CountryCode;

			// نمایه‌ی شماره‌ی دفترچه: هر حالت نوشتن شماره → مخاطب
			var lookup = new Dictionary<string, SmsContact>(StringComparer.Ordinal);

			foreach (var contact in _contactService.GetContacts())
			{
				foreach (var variant in contact.Variants)
				{
					if (!lookup.ContainsKey(variant))
						lookup[variant] = contact;
				}
			}

			var byPhone = new Dictionary<string, DeviceContactItem>(StringComparer.Ordinal);
			var order	= new List<string>();

			foreach (var message in _deviceMessages)
			{
				var key = SmsPhoneNumber.Normalize(message.Sender, code);

				if (string.IsNullOrEmpty(key))
					key = (message.Sender ?? string.Empty).Trim();

				DeviceContactItem item;

				if (!byPhone.TryGetValue(key, out item))
				{
					SmsContact contact;

					if (!lookup.TryGetValue(key, out contact))
						contact = BuildUnknownContact(message.Sender, code);

					item = new DeviceContactItem
					{
						Contact		= contact,
						Messages	= new List<DeviceSmsGroup>()
					};

					byPhone[key] = item;
					order.Add(key);
				}

				item.Messages.Add(message);
			}

			_contacts = order
				.Select(x => byPhone[x])
				.OrderByDescending(x => x.Messages.Max(m => m.Index))
				.ThenBy(x => x.DisplayName)
				.ToList();
		}

		/// <summary>ساخت مخاطب «ناشناس» برای شماره‌ای که در دفترچه نیست.</summary>
		private static SmsContact BuildUnknownContact(string sender, string countryCode)
		{
			var national = SmsPhoneNumber.ToNational(sender, countryCode);

			return new SmsContact
			{
				IsUnknown		= true,
				DisplayName		= SmsContactService.UnknownDisplayName,
				PrimaryMobile	= national,
				DisplayMobile	= SmsPhoneNumber.FormatNationalDigits(national),
				Phones			= new List<string> { national },
				Variants		= new List<string>(
									  SmsPhoneNumber.Variants(national, countryCode))
			};
		}

		private void EnsureContactColumns()
		{
			if (_contactColumnsReady)
				return;

			var table = gridContacts.RootTable;

			if (table == null)
				return;

			try
			{
				table.Columns.Clear();

				var name = new GridEXColumn
				{
					DataMember		= "DisplayName",
					Caption			= "نام",
					Width			= 120,
					Visible			= true,
					TextAlignment	= TextAlignment.Near
				};

				var mobile = new GridEXColumn
				{
					DataMember		= "DisplayMobile",
					Caption			= "موبایل",
					Width			= 105,
					Visible			= true,
					TextAlignment	= TextAlignment.Center
				};

				var count = new GridEXColumn
				{
					DataMember		= "MessageCountText",
					Caption			= "پیامک",
					Width			= 90,
					Visible			= true,
					TextAlignment	= TextAlignment.Center
				};

				table.Columns.Add(name);
				table.Columns.Add(mobile);
				table.Columns.Add(count);

				_contactColumnsReady = true;
			}
			catch (Exception ex)
			{
				log.Error(ex);
			}
		}

		private void gridContacts_SelectionChanged(object sender, EventArgs e)
		{
			if (_suppressSelection)
				return;

			var row = gridContacts.CurrentRow;

			if (row == null)
				return;

			var item = row.DataRow as DeviceContactItem;

			if (item == null || ReferenceEquals(item, _selectedContact))
				return;

			SelectContact(item);
		}

		private void SelectContact(DeviceContactItem item)
		{
			_selectedContact = item;

			lblMessagesTitle.Text = string.Format("{0} — {1}   ({2} پیامک)",
				item.DisplayName, item.DisplayMobile, item.Messages.Count);

			gridMessages.DataSource = null;
			gridMessages.DataSource = item.Messages
				.OrderByDescending(x => x.Index)
				.ToList();
		}

		#endregion

		#region Messages

		private void EnsureMessageColumns()
		{
			if (_messageColumnsReady)
				return;

			var table = gridMessages.RootTable;

			if (table == null)
				return;

			try
			{
				table.Columns.Clear();

				var index = new GridEXColumn
				{
					DataMember		= "IndicesText",
					Caption			= "اندیس",
					Width			= 75,
					Visible			= true,
					TextAlignment	= TextAlignment.Center
				};

				var sender = new GridEXColumn
				{
					DataMember		= "Sender",
					Caption			= "فرستنده",
					Width			= 110,
					Visible			= true,
					TextAlignment	= TextAlignment.Center
				};

				var text = new GridEXColumn
				{
					DataMember		= "ShortText",
					Caption			= "متن پیامک",
					Width			= 300,
					Visible			= true,
					TextAlignment	= TextAlignment.Near
				};

				var part = new GridEXColumn
				{
					DataMember		= "PartText",
					Caption			= "پارت",
					Width			= 90,
					Visible			= true,
					TextAlignment	= TextAlignment.Center
				};

				var time = new GridEXColumn
				{
					DataMember		= "TimeStamp",
					Caption			= "زمان",
					Width			= 110,
					Visible			= true,
					TextAlignment	= TextAlignment.Center
				};

				var saved = new GridEXColumn
				{
					DataMember		= "SavedText",
					Caption			= "وضعیت بانک",
					Width			= 90,
					Visible			= true,
					TextAlignment	= TextAlignment.Center
				};

				table.Columns.Add(index);
				table.Columns.Add(sender);
				table.Columns.Add(text);
				table.Columns.Add(part);
				table.Columns.Add(time);
				table.Columns.Add(saved);

				_messageColumnsReady = true;
			}
			catch (Exception ex)
			{
				log.Error(ex);
			}
		}

		#endregion

		#region Stats

		private void LoadStats()
		{
			var info = _service.GetMemoryInfo();

			// اگر مودم در دسترس نباشد، تابع بومی مقدار ۱- برمی‌گرداند؛
			// در آن حالت به‌جای عدد بی‌معنا، «—» نمایش داده می‌شود.
			var hasMemory = info != null && info.IsValid && info.TotalSize > 0;

			if (!hasMemory)
			{
				lblTotal.Text	= "ظرفیت کل: —";
				lblUsed.Text	= "اشغال‌شده: —";
				lblFree.Text	= "آزاد: —";
				lblPercent.Text	= "استفاده: —";

				progressMemory.Value = 0;
			}
			else
			{
				lblTotal.Text	= string.Format("ظرفیت کل: {0}", info.TotalSize);
				lblUsed.Text	= string.Format("اشغال‌شده: {0}", info.UsedSpace);
				lblFree.Text	= string.Format("آزاد: {0}", Math.Max(0, info.FreeSpace));
				lblPercent.Text	= string.Format("استفاده: {0}%", info.UsedPercent);

				progressMemory.Value = Math.Max(0, Math.Min(100, info.UsedPercent));
			}

			lblCount.Text = string.Format("پیامک: {0} ({1} پارت)",
				_deviceMessages.Count,
				_deviceMessages.Sum(x => x.PartCount));
		}

		#endregion

		#region Actions

		private DeviceSmsGroup GetSelectedMessage()
		{
			var row = gridMessages.CurrentRow;

			return row == null ? null : row.DataRow as DeviceSmsGroup;
		}

		/// <summary>حذف همه‌ی پارت‌های پیامک‌های داده‌شده از حافظه‌ی دستگاه.</summary>
		private int DeleteGroups(IEnumerable<DeviceSmsGroup> groups)
		{
			var deleted = 0;

			foreach (var group in groups)
			{
				var success = true;

				foreach (var index in group.Indices)
				{
					if (!_service.DeleteFromModem(index))
					{
						success = false;
						log.WarnFormat("حذف پیامک با اندیس {0} از مودم انجام نشد.", index);
					}
				}

				if (success)
					deleted++;
			}

			return deleted;
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			Reload();
		}

		private void btnSaveToDb_Click(object sender, EventArgs e)
		{
			try
			{
				Cursor			= Cursors.WaitCursor;
				lblStatus.Text	= "در حال ذخیره در بانک...";

				var saved = _service.ReadNow();

				Reload();

				MS_Message.Show(this,
					string.Format("{0} پیامک در بانک ذخیره شد.", saved),
					"ذخیره در بانک");
			}
			catch (Exception ex)
			{
				log.Error(ex);
				MS_Message.Show(this, "خطا", "خطا در ذخیره‌سازی", ex.Message, MessageBoxButtons.OK);
			}
			finally
			{
				Cursor = Cursors.Default;
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			var message = GetSelectedMessage();

			if (message == null)
			{
				MS_Message.Show(this, "ابتدا یک پیامک را از فهرست انتخاب کنید.", "اطلاع");
				return;
			}

			var confirm = MS_Message.Show(this, "تأیید حذف", "حذف از دستگاه",
				string.Format("این پیامک{0} از حافظه‌ی دستگاه حذف شود؟",
					message.IsMultipart ? " و همه‌ی پارت‌هایش" : string.Empty),
				MessageBoxButtons.YesNo);

			if (confirm != DialogResult.Yes)
				return;

			try
			{
				Cursor = Cursors.WaitCursor;

				if (DeleteGroups(new[] { message }) > 0)
					MS_Message.Show(this, "پیامک از حافظه‌ی دستگاه حذف شد.", "اطلاع");
				else
					MS_Message.Show(this, "حذف انجام نشد.", "اطلاع");

				Reload();
			}
			catch (Exception ex)
			{
				log.Error(ex);
				MS_Message.Show(this, "خطا", "خطا در حذف", ex.Message, MessageBoxButtons.OK);
			}
			finally
			{
				Cursor = Cursors.Default;
			}
		}

		private void btnDeleteSaved_Click(object sender, EventArgs e)
		{
			var saved = _deviceMessages
				.Where(x => x.IsSavedInDatabase)
				.ToList();

			if (saved.Count == 0)
			{
				MS_Message.Show(this, "پیامک ذخیره‌شده‌ای در حافظه‌ی دستگاه وجود ندارد.", "اطلاع");
				return;
			}

			var confirm = MS_Message.Show(this, "تأیید حذف", "حذف ذخیره‌شده‌ها",
				string.Format("{0} پیامکی که در بانک ذخیره شده‌اند از حافظه‌ی دستگاه حذف شوند؟", saved.Count),
				MessageBoxButtons.YesNo);

			if (confirm != DialogResult.Yes)
				return;

			try
			{
				Cursor			= Cursors.WaitCursor;
				lblStatus.Text	= "در حال حذف...";

				var deleted = DeleteGroups(saved);

				Reload();

				MS_Message.Show(this,
					string.Format("{0} پیامک از حافظه‌ی دستگاه حذف شد.", deleted),
					"اطلاع");
			}
			catch (Exception ex)
			{
				log.Error(ex);
				MS_Message.Show(this, "خطا", "خطا در حذف", ex.Message, MessageBoxButtons.OK);
			}
			finally
			{
				Cursor = Cursors.Default;
			}
		}

		private void btnDeleteAll_Click(object sender, EventArgs e)
		{
			if (_deviceMessages.Count == 0)
			{
				MS_Message.Show(this, "حافظه‌ی دستگاه خالی است.", "اطلاع");
				return;
			}

			var confirm = MS_Message.Show(this, "تأیید حذف", "حذف همه",
				string.Format("همه‌ی {0} پیامک از حافظه‌ی دستگاه حذف شوند؟", _deviceMessages.Count),
				MessageBoxButtons.YesNo);

			if (confirm != DialogResult.Yes)
				return;

			try
			{
				Cursor			= Cursors.WaitCursor;
				lblStatus.Text	= "در حال حذف...";

				var deleted = DeleteGroups(_deviceMessages);

				Reload();

				MS_Message.Show(this,
					string.Format("{0} پیامک از حافظه‌ی دستگاه حذف شد.", deleted),
					"اطلاع");
			}
			catch (Exception ex)
			{
				log.Error(ex);
				MS_Message.Show(this, "خطا", "خطا در حذف", ex.Message, MessageBoxButtons.OK);
			}
			finally
			{
				Cursor = Cursors.Default;
			}
		}

		#endregion
	}
}
