using MS_Control;
using MS_Control.Controls;
using MS_Control.MainForms;
using NZ.General.Business;
using ShareLib.Component;
using ShareLib.Interfaces;
using ShareLib.Models;
using ShareLib.Utils;
using ShareLib.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NZ.General.WinForms.Sms
{
	public partial class FormSmsTemplate : Form_Mother_IRANSans
	{
		#region Logging
		private static readonly log4net.ILog log =
			log4net
				.LogManager
				.GetLogger
					(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		#endregion

		private List<SmsTemplate> _templates = new List<SmsTemplate>();
		private Manager _Manager;


		public FormSmsTemplate()
		{
			InitializeComponent();
			this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
			_Manager = new Manager();
			this.Load += FormSetting_Load;
			LoadTemplates();
		}

		private void LoadTemplates()
		{
			try
			{
				_templates = _Manager.GetList<SmsTemplate>()?.ToList();
			}
			catch (Exception ex)
			{
				MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
				log.Error(ex);
			}
		}
		private void FormSetting_Load(object sender, EventArgs e)
		{
			foreach (var system in Form_Factory.SystemList)
			{
				var tabs = system.GetSmsTemplateTabPages();
				if (tabs != null)
				{
					foreach (var tabPage in tabs)
					{
						tabPage.LoadTemplate(_templates);
						tabPage.OnSaveTemplate+=OnSaveTemplate;
						NzTab.TabPages.Add(tabPage);
					}
				}
			}
		}

		private void OnSaveTemplate(object sender, SmsTemplate e)
		{
			if(e!=null)
				_templates.Add(e);
		}

		private void ms_Save_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (var template in _templates)
					_Manager.Delete(template);

				_templates = new List<SmsTemplate>();
				foreach (NsSmsTemplateTabPage tab in NzTab.TabPages)
					tab.DoSave();

				foreach (var template in _templates)
					_Manager.Save(template);

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

		/*
			private void FormSetting_Load(object sender, EventArgs e)
		   {
		   	foreach (var system in Form_Factory.SystemList)
		   	{
		   		var tabs = system.GetSettingTabPage();
		   		if (tabs != null)
		   		{
		   			foreach (var tabPage in tabs)
		   			{
		   				tabPage.OnSavedItems += OnSavedItems;
		   				NzTab.TabPages.Add(tabPage);
		   			}
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
		 */

	}
}
