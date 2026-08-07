using Janus.Windows.GridEX;
using MS_Control;
using NZ.General.Business;
using NZ.General.WinForms.Component;
using ShareLib;
using ShareLib.Models;
using ShareLib.Models.Report;
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
			var mgr			= new Manager();
			var shoraka		= new List<PartnerBardasht>();

			var Az			= NzDateFrom.MS_Tarikh?.ToDatetime();
			var Ta			= NzDateTo.MS_Tarikh?.ToDatetime();
			var IdsHazine	= NsHazine.GetCheckedRows().Select(x => x.DataRow as Hazine).Select(x => x.ID).ToArray();
			var IdsShoraka	= NsShoraka.GetCheckedRows().Any()
				? NsShoraka.GetCheckedRows().Select(x => x.DataRow as People).Select(x => x.ID).ToArray()
				: NsShoraka.GetDataRows().Select(x => x.DataRow as People).Select(x => x.ID).ToArray();

			var anbar		= await Form_Factory._Form_Factory_Anbar.GetPartnerReportItem<PartnerStatus>(Az, Ta);
			var Hazine		= await Form_Factory._Form_Factory_Xazaneh.GetPartnerReportItem<HazineHa>(Az, Ta,IdsHazine);
			//var Shoraka		= await Form_Factory._Form_Factory_Xazaneh.GetPartnerReportList<PartnerBardasht>(Az, Ta,IdsShoraka);


			//==load 

			NsSumFroshKalaAmani.MS_Decimal	= anbar.SumFroshKalaAmani;
			NsMandeKalaAmani.MS_Decimal		= anbar.MandeKalaAmani;
			NsSumFroshKalaAdi.MS_Decimal	= anbar.SumFroshKalaAdi;
			NsMandeKalaAdi.MS_Decimal		= anbar.MandeKalaAdi;

			NsSumHazineHa.MS_Decimal		= Hazine.SumHazineHa;
			NsSumSoodKala.MS_Decimal		= anbar.SumSoodKala;
			NsQabelTaqsim.MS_Decimal		= NsSumSoodKala.MS_Decimal - NsSumHazineHa.MS_Decimal;


			foreach (var sharik in IdsShoraka)
			{
				var peopel		=  mgr.GetItem<People>(new { ID = sharik });
				var Balance		= new List<decimal>();

				var DateFrom = NzDateFrom.MS_Tarikh.HasValue  
					? (DateTime?)NzDateFrom.MS_Tarikh.Value.ToDatetime()
					: null;
				var DateTo	= NzDateTo.MS_Tarikh.HasValue  
					? (DateTime?)NzDateTo.MS_Tarikh.Value.ToDatetime()
					: null;

				var Year	= (short?)SystemConstant.ActiveYear.Salmali;
				var List2	= new List<CircularRowItem>();

				Form_Factory
					.SystemList
					.MSZ_ForEach(x =>
					{
						var list2 = x.GetBillItems(peopel.ID, Year, DateFrom, DateTo, (byte)1);

						if (list2 != null)
							List2.InsertRange(0, list2.Where(y => y.Credit > 0 || y.Debit > 0));
					});

				var balance      = List2
									.OrderBy(x => x.Date)
									.ThenBy(x => x.SubSystem)
									.ThenBy(x => x.Kind)
									.Sum(x=> x.Debit - x.Credit);
					//{
					//	remaind += x.Debit - x.Credit;
					//	x.Remaind = remaind;
					//});

				//var balance		= Balance.Sum();
				var malaqSahm	= (NsQabelTaqsim.MS_Decimal ?? 0) * peopel.PartnerPercent / 100;

				var PartnerState = new PartnerBardasht()
				{
					Balance			= balance,
					ID				= sharik,
					title			= peopel.title,
					PartnerPercent	= peopel.PartnerPercent,
					code			= peopel.code,
					MalaqSahm		= malaqSahm,
					Mande			= malaqSahm - balance ,
				};

				shoraka.Add(PartnerState);
			}






			//foreach (var sharik in Shoraka)
			//{
			//	sharik.MalaqSahm	= (NsQabelTaqsim.MS_Decimal ?? 0 ) * sharik.PartnerPercent / 100;
			//	sharik.Mande		= sharik.MalaqSahm - sharik.Balance;
			//}

			NsSahmShoraka.DataSource = shoraka.ToList();
		}
	}
}
