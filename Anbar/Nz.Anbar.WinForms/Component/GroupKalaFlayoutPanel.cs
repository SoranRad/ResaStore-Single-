using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janus.Windows.EditControls;
using NZ.Anbar.Business;
using Nz.Anbar.Model.Model;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.Component
{
	public partial class GroupKalaFlayoutPanel : FlowLayoutPanel
	{
		public delegate void	StatusUpdateHandler	(object sender, SubGroupEventArgs e);
		public event			StatusUpdateHandler OnSubGroupChanged;


		public GroupKalaFlayoutPanel()
		{
			InitializeComponent();
		}

		public void RefreshGroup()
		{
			var mgr			= new Manager();
			var groups		= mgr.GetList<SubGroup>()?.ToList();

			var i = 0;
			foreach (var group in groups.Where(x=>x.ShowInBarcode))
			{
				var btnRadio				= new Janus.Windows.EditControls.UIRadioButton();

				btnRadio.Appearance			= System.Windows.Forms.Appearance.Button;
				btnRadio.ImageAlignment		= Janus.Windows.EditControls.ImageHorizontalAlignment.Center;
				btnRadio.Location			= new System.Drawing.Point(467, 7);
				btnRadio.Margin				= new System.Windows.Forms.Padding(2);
				btnRadio.MinimumSize		= new System.Drawing.Size(100, 25);
				btnRadio.Name				= "uiRadioButton"+i;
				btnRadio.Padding			= new System.Windows.Forms.Padding(2);
				btnRadio.RightToLeft		= System.Windows.Forms.RightToLeft.Yes;
				btnRadio.Size				= new System.Drawing.Size(100, 25);
				btnRadio.TabIndex			= i;
				btnRadio.Text				= group.title;
				btnRadio.TextAlignment		= Janus.Windows.EditControls.TextAlignment.Center;
				btnRadio.VisualStyle		= Janus.Windows.UI.VisualStyle.Office2007;
				btnRadio.Tag				= group;

				btnRadio.CheckedChanged += BtnRadioOnCheckedChanged;
				this.Controls.Add(btnRadio);
				i++;
			}
		}

		private void BtnRadioOnCheckedChanged(object sender, EventArgs e)
		{
			if (sender is UIRadioButton btn)
			{
				if (btn.Checked && btn.Tag is SubGroup subGroup)
				{
					OnSubGroupChanged?.Invoke(btn, new SubGroupEventArgs(subGroup));
				}
			}
		}
	}
}
