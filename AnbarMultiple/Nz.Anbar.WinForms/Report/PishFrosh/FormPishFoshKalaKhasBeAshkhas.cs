using MS_Control.TSDD;
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
using NZ.Anbar.Business;
using NZ.Anbar.Model;
using Nz.Anbar.Model.Report.PishFrosh;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.Report.PishFrosh
{
	public partial class FormPishFoshKalaKhasBeAshkhas : Form
	{
		#region Logging
		private static readonly log4net.ILog log =
			log4net
				.LogManager
				.GetLogger
					(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		#endregion


		public FormPishFoshKalaKhasBeAshkhas(int Anbar,int FK_Kala)
		{
			InitializeComponent();
			this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
			NzAnbar.Refresh_Anbar();
			NzObjectSelection.Refresh_Grid((object)null);
			
			NzObjectSelection.MS_Set_Select(FK_Kala);
			NzAnbar.MS_Set_Select(Anbar);
			
			NzAnbar.MS_On_Row_Selected += NzAnbarOnMS_On_Row_Selected;
			NzObjectSelection.MS_On_Row_Selected += NzAnbarOnMS_On_Row_Selected;
		}

		private void ms_Grid_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
		{
			var row = ms_Grid.CurrentRow.DataRow as PishFoshKalaKhasBeAshkhas;
			var Anbar	= (NzAnbar.MS_Get_Selected() as Storage).ID;

			var frm = new FormFactorVaHavalePishFroshYekShaxs(Anbar, row.ID);
			frm.MdiParent = this.MdiParent;
			frm.Show();
		}

		private void NzCurrentYear_CheckedChanged(object sender, EventArgs e)
		{
			NzCirculr.PerformClick();
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
				if (NzObjectSelection.MS_Get_Selected() == null)
				{
					NzObjectSelection.Focus();
					return;
				}

				var Anbar	= (NzAnbar.MS_Get_Selected() as Storage).ID;
				var Kala	= (NzObjectSelection.MS_Get_Selected() as NzObject).Code;
				var Mgr		= new ReportManager();
				var List	= Mgr
					.GetReport<PishFoshKalaKhasBeAshkhas>
					(new
					{
						Year = NzCurrentYear.Checked?(short?)SystemConstant.ActiveYear.Salmali : null, 
						Anbar,
						Kala,
					}, null);

				ms_Grid.DataSource = List?.ToList();
			}
			catch (Exception ex)
			{
				log.Error(ex);
				MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
			}
		}
	}
}
