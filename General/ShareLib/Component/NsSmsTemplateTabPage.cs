using Janus.Windows.UI.Tab;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShareLib.Models;

namespace ShareLib.Component
{
	public partial class NsSmsTemplateTabPage : UITabPage
	{
		public delegate		SmsTemplate					TemplatesSms();
		public				TemplatesSms				SetTemplateFunction;
		public				EventHandler<SmsTemplate>	OnSaveTemplate;
		public delegate		Task						LoadTemplates(IEnumerable<SmsTemplate> templates);
		public				LoadTemplates				LoadTemplate; 

		public void DoSave()
		{
			var template = SetTemplateFunction();
			OnSaveTemplate?.Invoke(this, template);
		}

		public  void LoadSmsTemplates(IEnumerable<SmsTemplate> templates)
		{
			LoadTemplate?.Invoke(templates);
		}


		public NsSmsTemplateTabPage()
		{
			InitializeComponent();
		}

		 
	}
}
