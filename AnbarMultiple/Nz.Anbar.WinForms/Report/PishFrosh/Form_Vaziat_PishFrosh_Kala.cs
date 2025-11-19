using MS_Control;
using MS_Control.TSDD;
using Nz.Anbar.Model.Report;
using Nz.Anbar.Model.Report.PishFrosh;
using NZ.Anbar.Business;
using NZ.Anbar.Model;
using ShareLib.Models;
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

namespace Nz.Anbar.WinForms.Report.PishFrosh
{
	public partial class Form_Vaziat_PishFrosh_Kala : Form
	{
		#region Logging
		private static readonly log4net.ILog log =
			log4net
				.LogManager
				.GetLogger
					(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		#endregion

		public Form_Vaziat_PishFrosh_Kala()
		{
			InitializeComponent();
			this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
			NzAnbar.Refresh_Anbar();
			NzAnbar.MS_On_Row_Selected += NzAnbarOnMS_On_Row_Selected;
		}

		private void NzAnbarOnMS_On_Row_Selected(object sender, On_Selected e)
		{
			NzCirculr.PerformClick();
		}


		private void NzCirculr_Click(object sender, EventArgs e)
		{
			try
			{
				if (NzAnbar.MS_Get_Selected() == null)
				{
					NzAnbar.Focus();
					return;
				}
				var Anbar = (NzAnbar.MS_Get_Selected() as Storage).ID;
				var Mgr = new ReportManager();
				var List = Mgr
					.GetReport<PishFoshKala>
					(new
					{
						Year = NzCurrentYear.Checked?(short?)SystemConstant.ActiveYear.Salmali : null, 
						Anbar,
						People =(long?) null,
					}, null);

				ms_Grid.DataSource = List?.ToList();
			}
			catch (Exception ex)
			{
				log.Error(ex);
				MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
			}
		}

		private void NzCurrentYear_CheckedChanged(object sender, EventArgs e)
		{
			NzCirculr.PerformClick();
		}

		private void ms_Grid_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
		{
			var row = ms_Grid.CurrentRow.DataRow as PishFoshKala;
			var Anbar = (NzAnbar.MS_Get_Selected() as Storage).ID;

			var frm = new FormPishFoshKalaKhasBeAshkhas(Anbar, row.Code);
			frm.MdiParent = this.MdiParent;
			frm.Show();
		}
	}
}
