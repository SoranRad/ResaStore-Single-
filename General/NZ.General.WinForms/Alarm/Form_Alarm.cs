using MS_Control.MainForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShareLib.Utils;

namespace NZ.General.WinForms.Alarm
{
	public partial class Form_Alarm : Form_Mother_IRANSans
	{
		public Form_Alarm()
		{
			InitializeComponent();
		}

		private void Form_Alarm_Shown(object sender, EventArgs e)
		{
			foreach (var system in Form_Factory.SystemList.Where(system => system.AnyAlaram()))
				NzTab.TabPages.AddRange(system.GetAlarmsTabPage());
		}
	}
}
