using System;
using System.Collections.Generic;
using System.Drawing;
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
	/// فرم گفتگوی پیامک.
	///
	/// ستون کناری: فهرست اشخاص (بر اساس تازه‌ترین پیامک).
	/// بخش اصلی: پیام‌های ارسالی و دریافتی به شکل حباب چت.
	/// بالا: فیلتر نمایش (هر دو / ارسالی / دریافتی).
	/// پایین: نوشتن پیام، انتخاب اولویت و ارسال به صف.
	///
	/// کد رابط کاربری در <c>FormChat.Designer.cs</c> قرار دارد و از طریق Designer
	/// قابل ویرایش است. ستون‌های گرید مخاطبین در متد <see cref="EnsureContactColumns"/>
	/// تعریف شده‌اند تا با بازتولید کد طراحی از بین نروند.
	/// </summary>
	public partial class FormChat : Form_Mother_IRANSans
	{
		#region Logging

		private static readonly log4net.ILog log =
			log4net
				.LogManager
				.GetLogger
				(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		#endregion

		#region Constants

		private const int BubbleMarginX	= 12;
		private const int BubbleMarginY	= 8;
		private const int ConversationSize = 500;
		#endregion

		#region Fields

		private readonly SmsBanService			_service;
		private readonly SmsConversationService	_conversation;
		private readonly SmsContactService		_contactService;

		private readonly List<ChatBubble>		_bubbles = new List<ChatBubble>();

		private List<SmsContact>	_contacts = new List<SmsContact>();
		private SmsContact			_selectedContact;
		private ChatBubble			_selectedBubble;

		private bool				_contactsColumnsReady;
		private bool				_suppressSelection;
		#endregion

		#region Constructor

		public FormChat(SmsBanService service)
		{
			if (service == null)
				throw new ArgumentNullException("service");

			_service		= service;
			_conversation	= new SmsConversationService(service.Options);
			_contactService	= new SmsContactService(service.Options);

			InitializeComponent();

			btnCopy.Enabled		= false;
			btnDelete.Enabled	= false;

			panelMessages.Resize += PanelMessages_Resize;
		}
		#endregion

		#region Contacts

		/// <summary>
		/// ستون‌های گرید مخاطبین؛ یک‌بار و در صورت آماده بودن گرید.
		/// </summary>
		private void EnsureContactColumns()
		{
			if (_contactsColumnsReady)
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
					Width			= 150,
					Visible			= true,
					TextAlignment	= TextAlignment.Near
				};

				var phone = new GridEXColumn
				{
					DataMember		= "DisplayMobile",
					Caption			= "موبایل",
					Width			= 120,
					Visible			= true,
					TextAlignment	= TextAlignment.Center
				};

				var last = new GridEXColumn
				{
					DataMember		= "LastActivityText",
					Caption			= "آخرین پیام",
					Width			= 130,
					Visible			= true,
					TextAlignment	= TextAlignment.Center
				};

				table.Columns.Add(name);
				table.Columns.Add(phone);
				table.Columns.Add(last);

				_contactsColumnsReady = true;
			}
			catch (Exception ex)
			{
				log.Error(ex);
			}
		}

		private void LoadContacts(long? keepContactId)
		{
			try
			{
				_contacts = _contactService.GetContactsOrderedByLastMessage();

				EnsureContactColumns();

				_suppressSelection = true;
				gridContacts.DataSource = _contacts;
				_suppressSelection = false;

				lblStatus.Text = string.Format("تعداد مخاطبین: {0}", _contacts.Count);

				var target = keepContactId == null
					? _contacts.FirstOrDefault()
					: _contacts.FirstOrDefault(x => x.ID == keepContactId.Value);

				if (target == null)
					target = _contacts.FirstOrDefault();

				if (target != null)
					SelectContact(target);
			}
			catch (Exception ex)
			{
				log.Error(ex);
				lblStatus.Text = "خطا در خواندن مخاطبین: " + ex.Message;
			}
		}

		private void SelectContact(SmsContact contact)
		{
			_selectedContact = contact;

			LoadConversation();
		}
		#endregion

		#region Conversation

		private SmsDirection GetDirection()
		{
			if (rbOutgoing.Checked)
				return SmsDirection.Outgoing;

			if (rbIncoming.Checked)
				return SmsDirection.Incoming;

			return SmsDirection.Both;
		}

		private void LoadConversation()
		{
			ClearBubbles();

			if (_selectedContact == null)
			{
				lblHeader.Text = "یک مخاطب را انتخاب کنید";
				return;
			}

			try
			{
				var messages = _conversation.GetConversation(
					_selectedContact.Variants, GetDirection(), ConversationSize);

				foreach (var message in messages)
					AddBubble(message);

				LayoutBubbles();

				lblHeader.Text = string.Format("{0}   —   {1}   ({2} پیام)",
					_selectedContact.DisplayName,
					_selectedContact.DisplayMobile,
					messages.Count);

				ConfirmHeader();
			}
			catch (Exception ex)
			{
				log.Error(ex);
				lblStatus.Text = "خطا در خواندن گفتگو: " + ex.Message;
			}
		}

		private void AddBubble(SmsChatMessage message)
		{
			var bubble = new ChatBubble
			{
				MessageId	= message.Id,
				IsOutgoing	= message.IsOutgoing,
				MessageText	= message.Text,
				MetaText	= message.MetaText,
				Tag			= message,
				Margin		= new Padding(0)
			};

			bubble.Click += (sender, args) => SelectBubble(bubble);

			panelMessages.Controls.Add(bubble);
			_bubbles.Add(bubble);
		}

		private void ClearBubbles()
		{
			foreach (var bubble in _bubbles)
			{
				panelMessages.Controls.Remove(bubble);
				bubble.Dispose();
			}

			_bubbles.Clear();

			_selectedBubble	= null;
			btnCopy.Enabled	= false;
			btnDelete.Enabled = false;
		}

		/// <summary>
		/// چیدن حباب‌ها: ارسالی سمت راست و دریافتی سمت چپ.
		/// </summary>
		private void LayoutBubbles()
		{
			if (_bubbles.Count == 0)
				return;

			var clientWidth	= panelMessages.ClientSize.Width;
			var available	= Math.Max(240, clientWidth - BubbleMarginX * 2 - 18);

			var mirrored = RightToLeftLayout;
			var y = BubbleMarginY;

			foreach (var bubble in _bubbles)
			{
				bubble.Relayout(available);

				var x = bubble.IsOutgoing
					? available + BubbleMarginX - bubble.Width
					: BubbleMarginX;

				if (mirrored)
					x = clientWidth - x - bubble.Width;

				bubble.Left	= Math.Max(0, x);
				bubble.Top	= y;

				y += bubble.Height + BubbleMarginY;
			}

			var last = _bubbles.LastOrDefault();

			if (last == null)
				return;

			try
			{
				panelMessages.ScrollControlIntoView(last);
			}
			catch (Exception ex)
			{
				log.Debug("اسکرول به انتهای گفتگو انجام نشد.", ex);
			}
		}

		private void SelectBubble(ChatBubble bubble)
		{
			foreach (var item in _bubbles)
			{
				item.IsSelected = ReferenceEquals(item, bubble);
				item.Invalidate();
			}

			_selectedBubble		= bubble;
			btnCopy.Enabled		= bubble != null;
			btnDelete.Enabled	= bubble != null;
		}

		private void ConfirmHeader()
		{
			if (_selectedContact == null)
				return;

			lblHeader.Text = string.Format("{0}   —   {1}",
				_selectedContact.DisplayName,
				_selectedContact.DisplayMobile);
		}
		#endregion

		#region Event Handlers

		private void FormChat_Load(object sender, EventArgs e)
		{
			LoadContacts(null);
		}

		private void PanelMessages_Resize(object sender, EventArgs e)
		{
			LayoutBubbles();
		}

		private void gridContacts_SelectionChanged(object sender, EventArgs e)
		{
			if (_suppressSelection)
				return;

			var row = gridContacts.CurrentRow;

			if (row == null)
				return;

			var contact = row.DataRow as SmsContact;

			if (contact == null || (_selectedContact != null && contact.ID == _selectedContact.ID))
				return;

			SelectContact(contact);
		}

		private void rbFilter_CheckedChanged(object sender, EventArgs e)
		{
			var radio = sender as RadioButton;

			if (radio == null || !radio.Checked)
				return;

			LoadConversation();
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			LoadContacts(_selectedContact != null ? _selectedContact.ID : (long?)null);
		}

		private void btnCopy_Click(object sender, EventArgs e)
		{
			if (_selectedBubble == null)
			{
				MS_Message.Show(this, "ابتدا یک پیام را در گفتگو انتخاب کنید.", "اطلاع");
				return;
			}

			try
			{
				Clipboard.SetText(_selectedBubble.MessageText ?? string.Empty);

				lblStatus.Text = "متن پیام در حافظه کپی شد.";
			}
			catch (Exception ex)
			{
				log.Error(ex);
				MS_Message.Show(this, "خطا", "خطا در کپی", ex.Message, MessageBoxButtons.OK);
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (_selectedBubble == null)
			{
				MS_Message.Show(this, "ابتدا یک پیام را در گفتگو انتخاب کنید.", "اطلاع");
				return;
			}

			var message = _selectedBubble.Tag as SmsChatMessage;

			if (message == null)
				return;

			var confirm = MS_Message.Show(this, "تأیید حذف", "تأیید حذف",
				"این پیامک از بانک اطلاعاتی حذف شود؟", MessageBoxButtons.YesNo);

			if (confirm != DialogResult.Yes)
				return;

			try
			{
				if (!_conversation.DeleteMessage(message.Id, message.IsOutgoing))
				{
					MS_Message.Show(this, "پیامک پیدا نشد یا حذف نشد.", "اطلاع");
					return;
				}

				LoadConversation();
				LoadContacts(_selectedContact != null ? _selectedContact.ID : (long?)null);
			}
			catch (Exception ex)
			{
				log.Error(ex);
				MS_Message.Show(this, "خطا", "خطا در حذف", ex.Message, MessageBoxButtons.OK);
			}
		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			if (_selectedContact == null)
			{
				MS_Message.Show(this, "ابتدا یک مخاطب را از فهرست انتخاب کنید.", "اطلاع");
				return;
			}

			var text = (txtMessage.Text ?? string.Empty).Trim();

			if (text.Length == 0)
			{
				MS_Message.Show(this, "متن پیامک خالی است.", "اطلاع");
				txtMessage.Focus();
				return;
			}

			try
			{
				var id = _service.Enqueue(_selectedContact.PrimaryMobile, text, GetSelectedPriority());

				if (id <= 0)
				{
					MS_Message.Show(this, "ثبت درخواست ارسال انجام نشد.", "اطلاع");
					return;
				}

				txtMessage.Clear();

				lblStatus.Text = "پیامک به صف ارسال اضافه شد.";

				LoadConversation();
				LoadContacts(_selectedContact.ID);
			}
			catch (Exception ex)
			{
				log.Error(ex);
				MS_Message.Show(this, "خطا", "خطا در ارسال به صف", ex.Message, MessageBoxButtons.OK);
			}
		}

		private SmsPriority GetSelectedPriority()
		{
			switch (cmbPriority.SelectedIndex)
			{
				case 2:		return SmsPriority.Urgent;
				case 1:		return SmsPriority.Medium;
				default:	return SmsPriority.Normal;
			}
		}
		#endregion
	}
}
