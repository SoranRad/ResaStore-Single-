using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janus.Windows.UI.Tab;
using ShareLib.Interfaces;

namespace ShareLib.Component
{
	public partial class NsSettingTabPage : UITabPage
	{
		 public SettingItems SettingFunction;

		public EventHandler<ISettingItems> OnSavedItems;

		public delegate ISettingItems SettingItems();

		public void DoSave()
		{
			var set = SettingFunction();
			OnSavedItems?.Invoke(this, set);
		}

		public NsSettingTabPage()
		{
			InitializeComponent();
		}


	}
}
