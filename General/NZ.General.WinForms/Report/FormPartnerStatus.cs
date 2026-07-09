using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using NZ.General.Business;
using ShareLib;
using ShareLib.Models;
using ShareLib.Models.Report;
using ShareLib.Utils;

namespace NZ.General.WinForms.Report
{
	public partial class FormPartnerStatus : Form
	{
		public FormPartnerStatus()
		{
			InitializeComponent();
			NsHazine.FilterMode			= FilterMode.None;
			NsShoraka.FilterMode		= FilterMode.None;
			NsSahmShoraka.FilterMode	= FilterMode.None;
		}

		private void FormPartnerStatus_Load(object sender, EventArgs e)
		{
			var RptMgr	= new ReportManager();
			var Mgr		= new Manager();

			var people	= Mgr.GetList<People>()?.ToList();
			var Listhazine	= RptMgr.GetReport<Hazine>(new {Kind = Enums.NzAccountKind.Cost},null)?.ToList();

			NsHazine.DataSource		= Listhazine;
			NsShoraka.DataSource	= people.Where(x=>x.IsPartner).ToList();
		}

		private async void NzReport_Click(object sender, EventArgs e)
		{
			var Az			= NzDateFrom.MS_Tarikh?.ToDatetime();
			var Ta			= NzDateTo.MS_Tarikh?.ToDatetime();
			var IdsHazine	= NsHazine.GetCheckedRows().Select(x => x.DataRow as Hazine).Select(x => x.ID).ToArray();
			var IdsShoraka	= NsShoraka.GetCheckedRows().Select(x => x.DataRow as People).Select(x => x.ID).ToArray();

			var anbar		= await Form_Factory._Form_Factory_Anbar.GetPartnerReportItem<PartnerStatus>(Az, Ta);
			var Hazine		= await Form_Factory._Form_Factory_Xazaneh.GetPartnerReportItem<HazineHa>(Az, Ta,IdsHazine);
			var Shoraka		= await Form_Factory._Form_Factory_Xazaneh.GetPartnerReportList<PartnerBardasht>(Az, Ta,IdsShoraka);


			//==load 

			NsSumFroshKalaAmani.MS_Decimal	= anbar.SumFroshKalaAmani;
			NsMandeKalaAmani.MS_Decimal		= anbar.MandeKalaAmani;
			NsSumFroshKalaAdi.MS_Decimal	= anbar.SumFroshKalaAdi;
			NsMandeKalaAdi.MS_Decimal		= anbar.MandeKalaAdi;

			NsSumHazineHa.MS_Decimal		= Hazine.SumHazineHa;
			NsSumSoodKala.MS_Decimal		= anbar.SumSoodKala;
			NsQabelTaqsim.MS_Decimal		= NsSumSoodKala.MS_Decimal - NsSumHazineHa.MS_Decimal;



			foreach (var sharik in Shoraka)
			{
				sharik.MalaqSahm	= (NsQabelTaqsim.MS_Decimal ?? 0 ) * sharik.PartnerPercent / 100;
				sharik.Mande		= sharik.MalaqSahm - sharik.Balance;
			}

			NsSahmShoraka.DataSource = Shoraka.ToList();
		}
	}
}
