using SmsBan.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmsBan.UI.Components
{
	public partial class UsersControl : UserControl
	{
		private bool _selected;

		public bool Selected
		{
			get => _selected;
			set
			{
				_selected = value;
				label1.BackColor = value ? SelectedColor : Color.Transparent;
			}
		}

		public Color SelectedColor { get; set; }

		public UsersControl()
		{
			InitializeComponent();
			HookClickToRaiseParentClick(this);
		}

		public void SetContact(SmsContact contact)
		{
			if (contact == null)
			{
				NsTitle.Text = "";
				NsMobiles.Text = "";
			}
			else
			{
				NsTitle.Text = contact.DisplayName;
				NsMobiles.Text = string.Join(" - ",
					contact.Phones.Select(SmsPhoneNumber.FormatNationalDigits));
			}
		}

		
		private void HookClickToRaiseParentClick(Control parent)
		{
			foreach (Control c in parent.Controls)
			{
				c.Click += Child_Click;
				if (c.HasChildren)
					HookClickToRaiseParentClick(c);
			}
		}

		private void Child_Click(object sender, EventArgs e)
		{
			OnClick(EventArgs.Empty);   // bubble up as the UserControl's Click
		}
	}
}
