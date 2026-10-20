using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SmsBan.Core;
using SmsBan.Model;

namespace SmsBan.UI
{
	/// <summary>
	/// فرم مدیریت صف ارسال پیامک.
	///
	/// امکانات: نمایش صف، نمایش آرشیو، لغو، تغییر اولویت، جابه‌جایی دستی،
	/// بازگرداندن پیامک‌های ناموفق به صف و توقف/ادامه‌ی ارسال.
	/// </summary>
	public class FormQueueManager : Form
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

		private readonly SmsBanService	_service;

		private DataGridView			_gridQueue;
		private DataGridView			_gridArchive;
		private ComboBox				_cmbArchiveStatus;
		private ToolStripStatusLabel	_lblStatus;
		private ToolStripButton			_btnPauseResume;
		private Timer					_timer;

		public FormQueueManager(SmsBanService service)
		{
			if (service == null)
				throw new ArgumentNullException("service");

			_service = service;

			BuildUi();
			Load += OnFormLoad;
		}

		// ==================================================================
		// ساخت رابط کاربری
		// ==================================================================

		private void BuildUi()
		{
			Text				= "مدیریت صف ارسال پیامک";
			RightToLeft			= RightToLeft.Yes;
			RightToLeftLayout	= true;
			Font				= new Font("Tahoma", 9F);
			StartPosition		= FormStartPosition.CenterScreen;
			Size				= new Size(1100, 650);

			var toolStrip = new ToolStrip
			{
				RightToLeft		= RightToLeft.Yes,
				GripStyle		= ToolStripGripStyle.Hidden,
				ImageScalingSize = new Size(16, 16)
			};

			toolStrip.Items.Add(MakeButton("به‌روزرسانی",	OnRefresh));
			toolStrip.Items.Add(new ToolStripSeparator());
			toolStrip.Items.Add(MakeButton("ابتدا",			(s, e) => ActOnSelected(id => _service.MoveToTop(id),    "انتقال به ابتدا")));
			toolStrip.Items.Add(MakeButton("بالا",			(s, e) => ActOnSelected(id => _service.MoveUp(id),       "انتقال به بالا")));
			toolStrip.Items.Add(MakeButton("پایین",			(s, e) => ActOnSelected(id => _service.MoveDown(id),     "انتقال به پایین")));
			toolStrip.Items.Add(MakeButton("انتها",			(s, e) => ActOnSelected(id => _service.MoveToBottom(id), "انتقال به انتها")));
			toolStrip.Items.Add(new ToolStripSeparator());

			var priorityButton = new ToolStripDropDownButton("تغییر اولویت");

			priorityButton.DropDownItems.Add("فوری",  null, (s, e) => ChangePriority(SmsPriority.Urgent));
			priorityButton.DropDownItems.Add("متوسط", null, (s, e) => ChangePriority(SmsPriority.Medium));
			priorityButton.DropDownItems.Add("عادی",  null, (s, e) => ChangePriority(SmsPriority.Normal));

			toolStrip.Items.Add(priorityButton);

			toolStrip.Items.Add(MakeButton("لغو مورد",		OnCancelSelected));
			toolStrip.Items.Add(MakeButton("لغو همه",		OnCancelAll));
			toolStrip.Items.Add(new ToolStripSeparator());

			_btnPauseResume = MakeButton("توقف ارسال", OnPauseResume);
			toolStrip.Items.Add(_btnPauseResume);

			toolStrip.Items.Add(new ToolStripSeparator());
			toolStrip.Items.Add(MakeButton("وضعیت مودم",	OnShowStatus));

			var tabs = new TabControl
			{
				Dock		= DockStyle.Fill,
				RightToLeft	= RightToLeft.Yes,
				Padding		= new Point(12, 6)
			};

			_gridQueue = MakeGrid();
			AddQueueColumns(_gridQueue);

			var tabQueue = new TabPage("صف ارسال");
			tabQueue.Controls.Add(_gridQueue);

			_gridArchive = MakeGrid();
			AddArchiveColumns(_gridArchive);

			var panelArchive = new Panel { Dock = DockStyle.Fill };

			var panelTop = new Panel { Dock = DockStyle.Top, Height = 38 };

			_cmbArchiveStatus = new ComboBox
			{
				DropDownStyle	= ComboBoxStyle.DropDownList,
				Location		= new Point(10, 8),
				Width			= 160
			};

			_cmbArchiveStatus.Items.AddRange(new object[]
			{
				"همه",
				"ارسال شد",
				"ارسال نشد",
				"لغو شد"
			});

			_cmbArchiveStatus.SelectedIndex = 0;
			_cmbArchiveStatus.SelectedIndexChanged += (s, e) => ReloadArchive();

			var btnRetry = new Button
			{
				Text		= "بازگشت به صف",
				Location	= new Point(180, 6),
				Size		= new Size(120, 26)
			};

			btnRetry.Click += OnRetryFailed;

			panelTop.Controls.Add(_cmbArchiveStatus);
			panelTop.Controls.Add(btnRetry);

			_gridArchive.Dock = DockStyle.Fill;

			panelArchive.Controls.Add(_gridArchive);
			panelArchive.Controls.Add(panelTop);

			var tabArchive = new TabPage("آرشیو ارسال‌ها");
			tabArchive.Controls.Add(panelArchive);

			tabs.TabPages.Add(tabQueue);
			tabs.TabPages.Add(tabArchive);

			var statusStrip = new StatusStrip { RightToLeft = RightToLeft.Yes };
			_lblStatus = new ToolStripStatusLabel("آماده");
			statusStrip.Items.Add(_lblStatus);

			Controls.Add(tabs);
			Controls.Add(toolStrip);
			Controls.Add(statusStrip);
		}

		private static ToolStripButton MakeButton(string text, EventHandler handler)
		{
			var button = new ToolStripButton(text)
			{
				DisplayStyle	= ToolStripItemDisplayStyle.Text,
				AutoSize		= true
			};

			button.Click += handler;

			return button;
		}

		private static DataGridView MakeGrid()
		{
			return new DataGridView
			{
				Dock					= DockStyle.Fill,
				ReadOnly				= true,
				AllowUserToAddRows		= false,
				AllowUserToDeleteRows	= false,
				AutoGenerateColumns		= false,
				SelectionMode			= DataGridViewSelectionMode.FullRowSelect,
				MultiSelect				= false,
				RowHeadersVisible		= false,
				RightToLeft				= RightToLeft.Yes,
				BackgroundColor			= SystemColors.Window,
				AutoSizeColumnsMode		= DataGridViewAutoSizeColumnsMode.None
			};
		}

		private static void AddQueueColumns(DataGridView grid)
		{
			grid.Columns.Add(MakeText("ID",			"شناسه",		60));
			grid.Columns.Add(MakeText("PriorityText",	"اولویت",		70));
			grid.Columns.Add(MakeText("PhoneNumber",	"شماره",		120));
			grid.Columns.Add(MakeText("MessageText",	"متن پیامک",	320));
			grid.Columns.Add(MakeText("PageCount",		"صفحه",			50));
			grid.Columns.Add(MakeText("StatusText",		"وضعیت",		100));
			grid.Columns.Add(MakeText("RetryCount",		"بازگشت",		60));
			grid.Columns.Add(MakeText("CreatedAtShamsi","تاریخ ثبت",	130));
			grid.Columns.Add(MakeText("EnqueuedBy",		"درخواست‌دهنده",	120));
			grid.Columns.Add(MakeText("LastError",		"آخرین خطا",	180));
		}

		private static void AddArchiveColumns(DataGridView grid)
		{
			grid.Columns.Add(MakeText("ID",					"شناسه",		60));
			grid.Columns.Add(MakeText("StatusText",			"وضعیت",		100));
			grid.Columns.Add(MakeText("PhoneNumber",		"شماره",		120));
			grid.Columns.Add(MakeText("MessageText",		"متن پیامک",	300));
			grid.Columns.Add(MakeText("PageCount",			"صفحه",			50));
			grid.Columns.Add(MakeText("CreatedAtShamsi",	"تاریخ ثبت",	130));
			grid.Columns.Add(MakeText("SentAtShamsi",		"زمان ارسال",	130));
			grid.Columns.Add(MakeText("SmsReference",		"مرجع",			90));
			grid.Columns.Add(MakeText("IsDelivered",		"تحویل",		55));
			grid.Columns.Add(MakeText("ErrorMessage",		"خطا",			200));
		}

		private static DataGridViewTextBoxColumn MakeText(string property, string header, int width)
		{
			return new DataGridViewTextBoxColumn
			{
				DataPropertyName	= property,
				HeaderText			= header,
				Width				= width,
				SortMode			= DataGridViewColumnSortMode.NotSortable
			};
		}

		// ==================================================================
		// چرخه‌ی عمر فرم
		// ==================================================================

		private void OnFormLoad(object sender, EventArgs e)
		{
			ReloadAll();

			_timer = new Timer { Interval = 5000 };
			_timer.Tick += (s, args) => ReloadAll();
			_timer.Start();
		}

		protected override void OnFormClosed(FormClosedEventArgs e)
		{
			if (_timer != null)
			{
				_timer.Stop();
				_timer.Dispose();
				_timer = null;
			}

			base.OnFormClosed(e);
		}

		// ==================================================================
		// بارگذاری داده‌ها
		// ==================================================================

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
				var rows = _service.GetQueue(new SmsQueueFilter { MaxRows = 2000 });

				var selectedId = GetSelectedId(_gridQueue);

				_gridQueue.DataSource = rows;

				SelectById(_gridQueue, selectedId);

				_lblStatus.Text = string.Format("تعداد در صف: {0}", rows.Count);
			}
			catch (Exception ex)
			{
				log.Error(ex);
				_lblStatus.Text = "خطا در خواندن صف: " + ex.Message;
			}
		}

		private void ReloadArchive()
		{
			try
			{
				SmsMessageStatus? status = null;

				switch (_cmbArchiveStatus.SelectedIndex)
				{
					case 1: status = SmsMessageStatus.Sent;		break;
					case 2: status = SmsMessageStatus.Failed;	break;
					case 3: status = SmsMessageStatus.Canceled;	break;
				}

				var rows = _service.GetArchive(status, null, null, 2000);

				_gridArchive.DataSource = rows
					.Select(x => new ArchiveRow
					{
						ID				= x.ID,
						StatusText		= SmsTexts.Status(x.Status),
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
				var paused = _service.IsPaused();

				_btnPauseResume.Text = paused ? "ادامه ارسال" : "توقف ارسال";
			}
			catch (Exception ex)
			{
				log.Error(ex);
			}
		}

		private static long? GetSelectedId(DataGridView grid)
		{
			if (grid.CurrentRow == null)
				return null;

			var item = grid.CurrentRow.DataBoundItem as SmsQueueItem;

			return item != null ? item.ID : (long?)null;
		}

		private static void SelectById(DataGridView grid, long? id)
		{
			if (id == null)
				return;

			foreach (DataGridViewRow row in grid.Rows)
			{
				var item = row.DataBoundItem as SmsQueueItem;

				if (item != null && item.ID == id.Value)
				{
					row.Selected = true;
					return;
				}
			}
		}

		// ==================================================================
		// عملیات
		// ==================================================================

		private void OnRefresh(object sender, EventArgs e)
		{
			ReloadAll();
		}

		private void ActOnSelected(Func<long, bool> action, string caption)
		{
			var id = GetSelectedId(_gridQueue);

			if (id == null)
			{
				ShowInfo("ابتدا یک ردیف از صف را انتخاب کنید.");
				return;
			}

			Run(() => action(id.Value), caption);
		}

		private void ChangePriority(SmsPriority priority)
		{
			var id = GetSelectedId(_gridQueue);

			if (id == null)
			{
				ShowInfo("ابتدا یک ردیف از صف را انتخاب کنید.");
				return;
			}

			Run(() => _service.ChangePriority(id.Value, priority), "تغییر اولویت");
		}

		private void OnCancelSelected(object sender, EventArgs e)
		{
			var id = GetSelectedId(_gridQueue);

			if (id == null)
			{
				ShowInfo("ابتدا یک ردیف از صف را انتخاب کنید.");
				return;
			}

			if (MessageBox.Show(this, "آیا این ردیف از صف لغو شود؟", "تأیید لغو",
					MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
				return;

			Run(() => _service.Cancel(id.Value), "لغو ردیف");
		}

		private void OnCancelAll(object sender, EventArgs e)
		{
			if (MessageBox.Show(this, "تمام ردیف‌های در انتظار لغو شوند؟", "تأیید لغو گروهی",
					MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
				return;

			int count = 0;

			Run(() =>
			{
				count = _service.CancelAllPending();
				return true;
			}, "لغو گروهی");

			ShowInfo(string.Format("{0} ردیف لغو شد.", count));
		}

		private void OnRetryFailed(object sender, EventArgs e)
		{
			var row = _gridArchive.CurrentRow;

			if (row == null)
			{
				ShowInfo("ابتدا یک ردیف از آرشیو را انتخاب کنید.");
				return;
			}

			var archiveRow = row.DataBoundItem as ArchiveRow;

			if (archiveRow == null)
				return;

			Run(() => _service.RetryFailed(archiveRow.ID), "بازگشت به صف");
		}

		private void OnPauseResume(object sender, EventArgs e)
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
				ShowInfo("خطا: " + ex.Message);
			}
		}

		private void OnShowStatus(object sender, EventArgs e)
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

				MessageBox.Show(this, text, "وضعیت مودم", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				log.Error(ex);
				ShowInfo("خطا: " + ex.Message);
			}
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
				ShowInfo(string.Format("خطا در {0}:\r\n{1}", caption, ex.Message));
			}
		}

		private void ShowInfo(string message)
		{
			MessageBox.Show(this, message, "اطلاع", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		/// <summary>ردیف قابل نمایش آرشیو.</summary>
		private class ArchiveRow
		{
			public long		ID				{ get; set; }
			public string	StatusText		{ get; set; }
			public string	PhoneNumber		{ get; set; }
			public string	MessageText		{ get; set; }
			public int		PageCount		{ get; set; }
			public string	CreatedAtShamsi	{ get; set; }
			public string	SentAtShamsi	{ get; set; }
			public string	SmsReference	{ get; set; }
			public string	IsDelivered		{ get; set; }
			public string	ErrorMessage	{ get; set; }
		}
	}
}
