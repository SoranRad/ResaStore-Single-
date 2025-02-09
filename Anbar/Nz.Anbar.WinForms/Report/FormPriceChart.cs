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
using System.Windows.Forms.DataVisualization.Charting;
using MS_Control;
using NZ.Anbar.Business;
using NZ.Anbar.Model;
using Nz.Anbar.Model.Report;
using ShareLib;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.Report
{
	public partial class FormPriceChart : Form_Mother_IRANSans
	{
		#region Logging
		private static readonly log4net.ILog log =
			log4net
				.LogManager
				.GetLogger
					(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		#endregion


		public FormPriceChart(int  Code= 0)
		{
			InitializeComponent();
			this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
			NzObjectSelection.Refresh_Grid((object)null);

			if (Code != 0)
			{
				NzObjectSelection.MS_Set_Select(Code);
				NzReport.PerformClick();
			}
		}

		private void NzReport_Click(object sender, EventArgs e)
		{
			{
				if(NzObjectSelection.MS_Get_Selected()==null)
					return;
				 

				var NzObject = NzObjectSelection.MS_Get_Selected() as NzObject;
				try
				{
					var Mgr = new ReportManager();
					var List = Mgr.GetReport<TopPriceObject>(new
					{
						Year = SystemConstant.ActiveYear.Salmali,
						Kala = NzObject.Code, 
					},null);

					ms_Grid.DataSource = List?
						.OrderBy(x => x.tarikh)
						.ToList();

					var listPurchase = Mgr.GetReport<PriceChartMonthly>(new
					{
						Year = SystemConstant.ActiveYear.Salmali,
						Kala = NzObject.Code,
						Kind = (int)Enums.NzFactorKind.Xarid
					},null);

					var listSale = Mgr.GetReport<PriceChartMonthly>(new
					{
						Year = SystemConstant.ActiveYear.Salmali,
						Kala = NzObject.Code,
						Kind = (int)Enums.NzFactorKind.Frosh
					},null);

					Ns_Chart.Series[0].Points.Clear();
					Ns_Chart.Series[1].Points.Clear();

					if (listPurchase != null && listPurchase.Any())
					{
						foreach (var month in listPurchase.OrderBy(x => x.PersianMonthNo))
						{
							var dp = new DataPoint();
							dp.AxisLabel = month.PersianMonthName;
							dp.LabelForeColor = Color.Black;
							dp.SetValueY(Convert.ToDouble(month.Price));
							Ns_Chart.Series[0].Points.Add(dp);
							dp.IsValueShownAsLabel = true;
						}
					}

					if (listSale != null && listSale.Any())
					{
						foreach (var month in listSale.OrderBy(x=>x.PersianMonthNo))
						{
							var dp              = new DataPoint();
							dp.AxisLabel        = month.PersianMonthName;
							dp.LabelForeColor   = Color.Black;
							dp.SetValueY(Convert.ToDouble(month.Price));
							Ns_Chart.Series[1].Points.Add(dp);
							dp.IsValueShownAsLabel = true;
						}
					}


				}
				catch (Exception ex)
				{
					log.Error(ex);
					MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
				}
			}
		}
	}
}
