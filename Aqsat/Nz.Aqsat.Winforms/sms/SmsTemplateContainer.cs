using MS_Control.Controls;
using ShareLib;
using ShareLib.Component;
using ShareLib.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nz.Aqsat.Winforms.sms
{
	public partial class SmsTemplateContainer : UserControl
	{
		public SmsTemplateContainer()
		{
			InitializeComponent();
			NsSarResidTabPage.LoadTemplate += LoadTemplateSarResid;
			NsSarResidTabPage.SetTemplateFunction += () => SetTemplateSarResid;
			//============================================
			NsAqsatMandeTabPage.LoadTemplate += LoadTemplateMande;
			NsAqsatMandeTabPage.SetTemplateFunction += () => SetTemplateMande;
			//============================================
		}

		public NsSmsTemplateTabPage[] TemplateTabPage => new[] { NsSarResidTabPage , NsAqsatMandeTabPage };

		#region سر رسید اقساط

		private async Task LoadTemplateSarResid(IEnumerable<SmsTemplate> templates)
		{
			var template = templates.FirstOrDefault(x => x.Kind == (byte)Enums.NsSmsTemplateKind.AqsatSarresid);
			if (template == null)
				return;

			NsMessageSarResid.Text = template.Message;
		}
		private SmsTemplate SetTemplateSarResid
		{
			get
			{
				if (NsMessageSarResid.TextLength == 0 || string.IsNullOrWhiteSpace(NsMessageSarResid.Text))
					return null;

				return 
					new SmsTemplate()
					{
						Id = 0,
						Kind = (byte)Enums.NsSmsTemplateKind.AqsatSarresid,
						Message = string.Join("\r\n", NsMessageSarResid.Lines),
					};
			}
		}
		private void ButtonVariablesSarResid_Click(object sender, EventArgs e)
		{
			var btn = sender as MS_Button_GridX;
			NsMessageSarResid.SelectedText = "#" + btn.Tag.ToString() + "#";
		}

		#endregion

		#region اقساط مانده
		private async Task		LoadTemplateMande(IEnumerable<SmsTemplate> templates)
		{
			var template = templates.FirstOrDefault(x => x.Kind == (byte)Enums.NsSmsTemplateKind.AqsatMande);
			if (template == null)
				return;

			NsMessageMande.Text = template.Message;
		}
		private SmsTemplate		SetTemplateMande
		{
			get
			{
				if (NsMessageMande.TextLength == 0 || string.IsNullOrWhiteSpace(NsMessageMande.Text))
					return null;

				return
					new SmsTemplate()
					{
						Id = 0,
						Kind = (byte)Enums.NsSmsTemplateKind.AqsatMande,
						Message = string.Join("\r\n", NsMessageMande.Lines),
					};
			}
		}
		private void			ButtonVariablesMande_Click(object sender, EventArgs e)
		{
			var btn = sender as MS_Button_GridX;
			NsMessageMande.SelectedText = "#" + btn.Tag.ToString() + "#";
		}
		#endregion
	}
}
