using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control.Controls;
using ShareLib;
using ShareLib.Component;
using ShareLib.Models;

namespace NZ.General.WinForms.Sms
{
	public partial class SmsTemplateContainer : UserControl
	{
		public SmsTemplateContainer()
		{
			InitializeComponent();
			NsStorageSmsTemplate.SetTemplateFunction	+= () => SetTemplateFunction;
			NsStorageSmsTemplate.LoadTemplate			+= LoadTemplate;	 
		}

		private async Task LoadTemplate(IEnumerable<SmsTemplate> templates)
		{
			var StorageTemplate = templates.FirstOrDefault(x => x.Kind == (byte)Enums.NsSmsTemplateKind.MandeShaxs);
			if(StorageTemplate==null)
				return;

			NsMessage.Text = StorageTemplate.Message;
		}

		private SmsTemplate SetTemplateFunction 
		{
			get
			{
				if (NsMessage.TextLength == 0 || string.IsNullOrWhiteSpace(NsMessage.Text))
					return null;

				return new SmsTemplate()
					{
						Id = 0,
						Kind = (byte)Enums.NsSmsTemplateKind.MandeShaxs,
						Message = string.Join("\r\n", NsMessage.Lines),
					};
			}
		}

		public NsSmsTemplateTabPage[] TemplateTabPage => new NsSmsTemplateTabPage[]{ NsStorageSmsTemplate};

		private void ButtonVariables_Click(object sender, EventArgs e)
		{
			var btn					= sender as MS_Button_GridX;
			NsMessage.SelectedText	= "#"+btn.Tag.ToString()+"#";
		}
	}
}
