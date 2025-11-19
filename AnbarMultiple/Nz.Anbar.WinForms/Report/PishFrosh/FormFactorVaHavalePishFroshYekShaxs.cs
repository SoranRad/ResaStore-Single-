using MS_Control;
using MS_Control.TSDD;
using Nz.Anbar.Model.Report.PishFrosh;
using Nz.Anbar.WinForms.App;
using NZ.Anbar.Business;
using NZ.Anbar.Model;
using ShareLib;
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
	public partial class FormFactorVaHavalePishFroshYekShaxs : Form
	{
		#region Logging
		private static readonly log4net.ILog log =
			log4net
				.LogManager
				.GetLogger
					(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		#endregion


		public FormFactorVaHavalePishFroshYekShaxs(int Anbar,long IdShaxs)
		{
			InitializeComponent();
			this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
			NzAnbar.Refresh_Anbar();
			NzShaxs.Refresh_Grid((byte)3,null);

			NzShaxs.MS_On_Row_Selected += NzAnbarOnMS_On_Row_Selected;
			NzAnbar.MS_On_Row_Selected += NzAnbarOnMS_On_Row_Selected;
			
			NzAnbar.MS_Set_Select(Anbar);
			NzShaxs.MS_Set_Select(IdShaxs);
			
		}
		private void NzAnbarOnMS_On_Row_Selected(object sender, On_Selected e)
		{
			NzCirculr.PerformClick();
		}

		private void NzCurrentYear_CheckedChanged(object sender, EventArgs e)
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
				if (NzShaxs.MS_Get_Selected() == null)
				{
					NzShaxs.Focus();
					return;
				}

				var Anbar = (NzAnbar.MS_Get_Selected() as Storage).ID;
				var People =(NzShaxs.MS_Get_Selected() as People).ID;

				var Mgr		= new ReportManager();
				var List	= Mgr
					.GetReport<FactorVaHavalePishFroshYekShaxs>
					(new
					{
						Year = NzCurrentYear.Checked?(short?)SystemConstant.ActiveYear.Salmali : null, 
						Anbar,
						People,
					}, null);

				ms_Grid.DataSource = List?.ToList();
			}
			catch (Exception ex)
			{
				log.Error(ex);
				MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
			}
		}

		private void ms_Grid_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
		{
			var row = ms_Grid.CurrentRow.DataRow as FactorVaHavalePishFroshYekShaxs;

			var kind = (Enums.NzFactorKind)row.kind;

			if (kind == Enums.NzFactorKind.Frosh)
				new Form_Purchase(row.ID, kind).ShowDialog();
			else
				new Form_Havale_Resid(row.ID, kind).ShowDialog();
		}
	}
}
