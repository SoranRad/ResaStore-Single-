using MS_Control.MainForms;
using ShareLib.Component;
using ShareLib.Interfaces;
using ShareLib.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control;
using ShareLib.ViewModel;

namespace NZ.General.WinForms.Setting
{
	public partial class FormSetting : Form_Mother_IRANSans
	{
		#region Logging
		private static readonly log4net.ILog log =
			log4net
				.LogManager
				.GetLogger
					(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		#endregion

		private List<dynamic> _settings = new List<dynamic>();

		public FormSetting()
		{
			InitializeComponent();
		}

		private void FormSetting_Load(object sender, EventArgs e)
		{
			foreach (var system in Form_Factory.SystemList)
			{
				var tab = system.GetSettingTabPage();
				if (tab != null)
				{
					tab.OnSavedItems+=OnSavedItems;
					NzTab.TabPages.Add(tab);
				}
			}
		}

		private void OnSavedItems(object sender, ISettingItems e)
		{
			if(e!=null)
				_settings.Add(e);

		}

		private void ms_Save_Click(object sender, EventArgs e)
		{
			try
			{
				_settings = new List<dynamic>();
				foreach (NsSettingTabPage tab in NzTab.TabPages)
					tab.DoSave();

				var config = Config.FromXML();
				config.Settings = _settings;

				var general = _settings.SingleOrDefault(x => ((ISettingItems)x).Name == SettingItems.KeyName);
				config.ConStr = (general as SettingItems)?.ConStr;

				config.ToXml();


				new Form_Notify("ذخـیـره سـازی", "اطـلاعـات بـا مـوفـقـیـت ثـبـت شـــد.",
						Form_Notify.FarsiMessageBoxIcon.چـک_باکس)
					.Popup(Form_Notify.Direction_Show.Right_To_Left, 1500);

				 
				DialogResult = DialogResult.OK;
			}
			catch (Exception ex)
			{
				MS_Message.Show("سیستم قادر به ثبت اطلاعات نیست", "خطا در ثبت", ex.Message, MessageBoxButtons.OK);
				log.Error(ex);
			}
		}

		private void ms_Exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
