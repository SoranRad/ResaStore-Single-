using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MS_Control.MS_Util;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace SmsBan.UI.Components
{
	public partial class RightChatMessage : UserControl
	{
		[Editor("System.ComponentModel.Design.MultilineStringEditor, System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
		public string Body
		{
			get
			{
				return NsBody.Text;
			}
			set
			{
				NsBody.Text = value;
			}
		}
		public string Meta
		{
			get
			{
				return NsMeta.Text;

			}
			set
			{
				NsMeta.Text = value;
			}
		}
		 

		public RightChatMessage()
		{
			InitializeComponent();
			HookClickToRaiseParentClick(this);
		}

		private void HookClickToRaiseParentClick(Control parent)
		{
			foreach (Control c in parent.Controls)
			{
				c.MouseUp += COnMouseUp;
				if (c.HasChildren)
					HookClickToRaiseParentClick(c);
			}
		}

		private void COnMouseUp(object sender, MouseEventArgs e)
		{
			OnMouseUp(e);
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			//Responsiveness when window or container resizes
			NsBody.MaximumSize = new Size((this.Width - NsUserPic.Width - 21) / 2, 0);
			NsBody.Width = this.Width - NsUserPic.Width - 21;

			if (NsBody.Height < NsUserPic.Height + 1)
			{
				this.MinimumSize = new Size(0, NsUserPic.Height + NsFooter.Height + 5);
				this.Height = NsUserPic.Height + NsFooter.Height + 5;
			}
			else
			{
				this.MinimumSize = new Size(0, NsBody.Height + NsFooter.Height + 25);
				this.Height = NsBody.Height + NsFooter.Height + 15;
			}

			GraphicsPath path = RoundedRectangle.Create(NsBody.ClientRectangle, 5, RoundedRectangle.RectangleCorners.All);
			NsBody.Region = new Region(path);

			base.OnPaint(e);
		}

	}
}
