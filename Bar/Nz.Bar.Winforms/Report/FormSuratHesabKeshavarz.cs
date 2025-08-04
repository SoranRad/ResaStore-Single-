using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShareLib.Models;
using ShareLib.Utils;
using Stimulsoft.Report;

namespace Nz.Bar.Winforms.Report
{
	public partial class FormSuratHesabKeshavarz : Form
	{
		public FormSuratHesabKeshavarz()
		{
			InitializeComponent();
			NzCustomer.Refresh_Grid		(null, (byte)3);
		}

		private void NzReport_Click(object sender, EventArgs e)
		{
			var People = (NzCustomer.MS_Get_Selected() as People).ID;
			var Year = SystemConstant.ActiveYear.Salmali;

			var ReportPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
			ReportPath += "\\Print\\Bar\\SuratHesabKeshavarz.mrt";

			var report = new StiReport();
			report.Load(ReportPath);

			var Anbar	= Form_Factory._Form_Factory_Anbar.GetBillRows(People, Year, null, null);
			var Bar		= Form_Factory._Form_Factory_Bar.GetBillRows(People, Year, null, null);
			var Xazane	= Form_Factory._Form_Factory_Xazaneh.GetBillRows(People, Year, null, null);

			if(Anbar!=null)
				report.RegBusinessObject("Anbar",Anbar);

			if(Bar!=null)
				report.RegBusinessObject("Bar",Bar);

			if(Xazane!=null)
				report.RegBusinessObject("Xazane",Xazane);

			 
			report.Dictionary.Variables["company"].Value	= SystemConstant.ActiveCompany.title;
			report.Dictionary.Variables["Keshavarz"].Value	= (NzCustomer.MS_Get_Selected() as People).title;
			report.Dictionary.Variables["Mande"].Value		= NzCustomerRemain.Balance.ToString();
			report.Dictionary.Variables["MandeTitle"].Value	= NzCustomerRemain.Balance>0?"بدهکار":"بستانکار";

			report.Render(true);
			 
			stiViewerControl1.Report = report; 

		}

		private void NzCustomer_MS_On_Row_Selected(object sender, MS_Control.TSDD.On_Selected e)
		{
			if (NzCustomer.MS_Get_Selected() != null)
			{
				NzReport.PerformClick();
				var tmp = NzCustomer.MS_Get_Selected() as People;
				NzCustomerRemain.NzSetCustoemr(tmp?.ID ?? 0);
			}
			else
			{ 
				NzCustomerRemain.Text   = "";
			}
		}
	}
}
