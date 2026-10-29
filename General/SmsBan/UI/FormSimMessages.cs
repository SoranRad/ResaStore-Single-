using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using MS_Control;
using MS_Control.MainForms;
using SmsBan.Core;
using SmsBan.Modem;

namespace SmsBan.UI
{
	/// <summary>
	/// فرم مشاهده و حذف پیامک‌هایی که در حافظه‌ی سیم‌کارت یا مودم ذخیره شده‌اند.
	///
	/// این فرم فقط روی کامپیوتری کار می‌کند که مودم به آن وصل است.
	/// کد رابط کاربری در <c>FormSimMessages.Designer.cs</c> قرار دارد و از طریق
	/// Designer قابل ویرایش است. ستون‌های گرید در متد <see cref="EnsureColumns"/>
	/// تعریف شده‌اند تا با بازتولید کد طراحی از بین نروند.
	/// </summary>
	public partial class FormSimMessages : Form_Mother_IRANSans
	{
		#region Logging

		private static readonly log4net.ILog log =
			log4net
				.LogManager
				.GetLogger
				(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		#endregion

		#region Fields

		private readonly SmsBanService	_service;

		private List<ModemSmsMessage>	_messages = new List<ModemSmsMessage>();

		private bool					_columnsReady;
		#endregion

		#region Constructor

		public FormSimMessages(SmsBanService service)
		{
			if (service == null)
				throw new ArgumentNullException("service");

			_service = service;

			InitializeComponent();
		}
		#endregion

		#region Columns

		/// <summary>تعریف ستون‌های گرید؛ یک‌بار و در صورت آماده بودن گرید.</summary>
		private void EnsureColumns()
		{
			if (_columnsReady)
				return;

			var table = gridMessages.RootTable;

			if (table == null)
				return;

			try
			{
				table.Columns.Clear();

				AddColumn(table.Columns, "Index",		"اندیس",		60,	 TextAlignment.Center);
				AddColumn(table.Columns, "TelNumber",	"فرستنده",		130, TextAlignment.Center);
				AddColumn(table.Columns, "SmsText",		"متن پیامک",	420, TextAlignment.Near);
				AddColumn(table.Columns, "TimeStamp",	"زمان",			130, TextAlignment.Center);
				AddColumn(table.Columns, "PartNo",		"پارت",			60,	 TextAlignment.Center);
				AddColumn(table.Columns, "SmsType",		"نوع",			120, TextAlignment.Center);

				_columnsReady = true;
			}
			catch (Exception ex)
			{
				log.Error(ex);
			}
		}

		private static void AddColumn(Janus.Windows.GridEX.GridEXColumnCollection table,
			string dataMember, string caption, int width, TextAlignment alignment)
		{
			var column = new GridEXColumn
			{
				DataMember		= dataMember,
				Caption			= caption,
				Width			= width,
				Visible			= true,
				TextAlignment	= alignment
			};

			table.Add(column);
		}
		#endregion

		#region Methods

		private void LoadMessages()
		{
			try
			{
				lblStatus.Text = "در حال خواندن از مودم...";
				Application.DoEvents();

				_messages = _service.ReadStoredFromModem();

				EnsureColumns();

				gridMessages.DataSource = _messages;

				lblStatus.Text = string.Format("{0} پیامک روی سیم‌کارت / مودم یافت شد.", _messages.Count);
			}
			catch (Exception ex)
			{
				log.Error(ex);
				lblStatus.Text = "خطا در خواندن از مودم: " + ex.Message;
			}
		}

		private int? GetSelectedIndex()
		{
			var row = gridMessages.CurrentRow;

			if (row == null)
				return null;

			var message = row.DataRow as ModemSmsMessage;

			return message != null ? message.Index : (int?)null;
		}
		#endregion

		#region Event Handlers

		private void FormSimMessages_Load(object sender, EventArgs e)
		{
			if (!_service.Options.IsModemHost)
			{
				btnLoad.Enabled		= false;
				btnDelete.Enabled	= false;

				lblStatus.Text = "این کامپیوتر به مودم وصل نیست؛ خواندن و حذف ممکن نیست.";

				return;
			}

			LoadMessages();
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			LoadMessages();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			var index = GetSelectedIndex();

			if (index == null)
			{
				MS_Message.Show(this, "ابتدا یک پیامک را از فهرست انتخاب کنید.", "اطلاع");
				return;
			}

			var confirm = MS_Message.Show(this, "تأیید حذف", "تأیید حذف",
				string.Format("پیامک با اندیس {0} از حافظه‌ی سیم‌کارت/مودم حذف شود؟", index.Value),
				MessageBoxButtons.YesNo);

			if (confirm != DialogResult.Yes)
				return;

			try
			{
				if (!_service.DeleteFromModem(index.Value))
				{
					MS_Message.Show(this, "حذف انجام نشد.", "اطلاع");
					return;
				}

				LoadMessages();
			}
			catch (Exception ex)
			{
				log.Error(ex);
				MS_Message.Show(this, "خطا", "خطا در حذف", ex.Message, MessageBoxButtons.OK);
			}
		}
		#endregion
	}
}
