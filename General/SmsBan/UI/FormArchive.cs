using Janus.Windows.EditControls;
using MS_Control;
using MS_Control.MainForms;
using SmsBan.Core;
using SmsBan.UI.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control.Controls;
using SmsBan.Model;
using static MS_Control.MS_INPUT;
using static MS_Control.MS_Util;

namespace SmsBan.UI
{
	public partial class FormArchive : Form
	{
		#region Systems
		////Moving form with mouse
		//public const int WM_NCLBUTTONDOWN = 0xA1;
		//private Label label1;
		//public const int HTCAPTION = 0x2;
		//[DllImport("User32.dll")]
		//public static extern bool ReleaseCapture();
		//[DllImport("User32.dll")]
		//public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		//protected virtual void OnMouseDownMoveForm(object sender, MouseEventArgs e)
		//{
		//	if (e.Button == MouseButtons.Left)
		//	{
		//		ReleaseCapture();
		//		SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
		//	}
		//}

		#endregion
		#region Logging

		private static readonly log4net.ILog log =
			log4net
				.LogManager
				.GetLogger
					(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		#endregion
		#region Fields

		private readonly SmsBanService _service;
		private readonly SmsConversationService _conversation;
		private readonly SmsContactService _contactService;

		private readonly List<ChatBubble> _bubbles = new List<ChatBubble>();

		private List<SmsContact> _contacts = new List<SmsContact>();
		private SmsContact _selectedContact;
		private ChatBubble _selectedBubble;

		private bool _contactsColumnsReady;
		private bool _suppressSelection;
		#endregion

		public FormArchive(SmsBanService service)
		{
			InitializeComponent();

			if (service == null)
				throw new ArgumentNullException("service");

			_service = service;
			_conversation = new SmsConversationService(service.Options);
			_contactService = new SmsContactService(service.Options);
			NsProirity.SelectedIndex = 0;
		}
		#region Methods
		private void LoadContacts()
		{
			try
			{
				_contacts = _contactService.GetContactsOrderedByLastMessage();
				FillContacts();
			}
			catch (Exception ex)
			{
				MS_Message.Show("");
				log.Error(ex); 
			}
		}

		private void FillContacts(List<SmsContact> contacts = null)
		{
			var conts = contacts ?? _contacts;

			NsUsersPanel.Controls.Clear();

			var odd = false;
			foreach (var contact in conts)
			{
				odd = !odd;
					
				var contactControl = new UsersControl();
				contactControl.BackColor = odd ? Color.WhiteSmoke : Color.Transparent;
				contactControl.SetContact(contact);
				contactControl.Dock = DockStyle.Top;
				contactControl.Tag = contact;
				contactControl.Selected = false;
				contactControl.SelectedColor = Color.Green;
				contactControl.Margin = new Padding(3, 5, 3, 5);

				contactControl.Click += ContactControlOnClick;
				NsUsersPanel.Controls.Add(contactControl);
			}
		}

		private void ContactControlOnClick(object sender, EventArgs e)
		{
			_selectedContact = (sender as Control).Tag as SmsContact;
			NsUsersPanel.Controls.OfType<UsersControl>().MSZ_ForEach(control =>
			{
				control.Selected = false;
			});
			(sender as UsersControl).Selected = true;
			LoadConversation();
		}
		private void LoadConversation()
		{
			try
			{
				NsMessages.Controls.Clear();

				var messages = _conversation
					.GetConversation
					(
						_selectedContact.Variants,
						SmsDirection.Both,
						500
					);

				foreach (var msg in messages)
				{
					if (msg.IsOutgoing)
					{
						var rmsg = new RightChatMessage();
						rmsg.Size = new Size(365, 200);
						rmsg.Body = msg.Text;
						rmsg.Meta = msg.MetaText;
						rmsg.Tag = msg;
						rmsg.Dock = DockStyle.Top;

						rmsg.MouseUp += (sender, args) =>
						{
							if (args.Button == MouseButtons.Right)
							{
								contextMenuStrip1.Tag = msg;
								contextMenuStrip1.Show(rmsg,args.Location,ToolStripDropDownDirection.BelowRight);
							}
						};

						NsMessages.Controls.Add(rmsg);
					}
					else
					{
						var lmsg = new LeftChatMessage();
						lmsg.Size = new Size(365, 200);
						lmsg.Body = msg.Text;
						lmsg.Meta = msg.MetaText;
						lmsg.Tag = msg;
						lmsg.Dock = DockStyle.Top;

						lmsg.MouseUp += (sender, args) =>
						{
							if (args.Button == MouseButtons.Right)
							{
								contextMenuStrip1.Tag = msg;
								contextMenuStrip1.Show(lmsg, args.Location, ToolStripDropDownDirection.BelowRight);
							}
						};

						NsMessages.Controls.Add(lmsg);
					}
				}
				LoadMobiles(); 
			}
			catch (Exception ex)
			{
				MS_Message.Show("خطا در خواندن پیام های مخاطب");
				log.Error(ex); 
			}
		}

		private void LoadMobiles()
		{
			NsNumbers.Items.Clear();
			var items = _selectedContact.Phones.Select(x => new UIComboBoxItem(x, x)).ToArray();
			NsNumbers.Items.AddRange(items);
			if(NsNumbers.Items.Count > 0)
				NsNumbers.SelectedIndex = 0;
		}
		
		#endregion

		private void FormArchive_Shown(object sender, EventArgs e)
		{
			LoadContacts();
		}
		private void NsRefresh_Click(object sender, EventArgs e)
		{
			LoadContacts();
		}
		
		#region Send Message

		private void NsSend_Click(object sender, EventArgs e)
		{
			if (NsNumbers.Items.Count == 0)
			{
				MSMessage.Show("هیچ شماره ای وارد نشده است.");
				NsNumbers.Focus();
				return;
			}
			if ((NsMessageText.TextLength == 0 || string.IsNullOrWhiteSpace(NsMessageText.Text)))
			{
				MSMessage.Show("هیچ متنی وارد نشده است.");
				NsMessageText.Focus();
				return;
			}

			_service.Enqueue
				(
					NsNumbers.SelectedValue.ToString(),
					NsMessageText.Text,
					NsProirity.SelectedIndex == 0 ? SmsPriority.Normal: SmsPriority.Urgent
				);

			new Form_Notify("ارسال پیامک", "پیامک با موفقیت وارد صف شد.",
					Form_Notify.FarsiMessageBoxIcon.چـک_باکس)
				.Popup(Form_Notify.Direction_Show.Right_To_Left, 1500);
		}

		#endregion

		private void NsMnuCopy_Click(object sender, EventArgs e)
		{
			if(contextMenuStrip1.Tag== null)
				return;

			var msg = contextMenuStrip1.Tag as SmsChatMessage;

			Clipboard.SetText(msg.Text);


			new Form_Notify("گپی پیامک", "متن پیامک در حافظه کپی شد.",
					Form_Notify.FarsiMessageBoxIcon.چـک_باکس)
				.Popup(Form_Notify.Direction_Show.Right_To_Left, 1500);

			
		}

		private void NsMnuDelete_Click(object sender, EventArgs e)
		{
			if (contextMenuStrip1.Tag == null)
				return;

			var result = MS_Message.Show("آیا برای حذف مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo);
			if(result!= DialogResult.Yes)
				return;

			var msg = contextMenuStrip1.Tag as SmsChatMessage;

			_service.DeleteMessage(msg.Id, msg.IsOutgoing);

			LoadConversation();

			new Form_Notify("گپی پیامک", "متن پیامک در حافظه کپی شد.",
					Form_Notify.FarsiMessageBoxIcon.چـک_باکس)
				.Popup(Form_Notify.Direction_Show.Right_To_Left, 1500);
		}

		private void NsSearch_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar !=(char)13)
				return;

			if(string.IsNullOrWhiteSpace(NsSearch.Text))
				return;

			var str = NsSearch.Text.Trim();

			var filtered = _contacts
				.Where(x => x.DisplayName.Contains(str) || x.InternationalPhones.Any(y => y.Contains(str)))
				.ToList();

			FillContacts(filtered);

		}

		private void NsSearch_KeyUp(object sender, KeyEventArgs e)
		{
			if(e.KeyCode != Keys.Enter)
				return;

			if (string.IsNullOrWhiteSpace(NsSearch.Text))
			{
				FillContacts();
				return;
			}

			var str = NsSearch.Text.Trim();

			var filtered = _contacts
				.Where(x => x.DisplayName.Contains(str) || x.InternationalPhones.Any(y => y.Contains(str)))
				.ToList();

			FillContacts(filtered);

		}
	}
}
