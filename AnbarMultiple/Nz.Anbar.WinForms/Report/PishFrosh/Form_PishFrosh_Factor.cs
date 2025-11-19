using System; 
using System.Linq; 
using System.Windows.Forms;
using MS_Control;
using MS_Control.TSDD;
using NZ.Anbar.Business;
using NZ.Anbar.Model;
using Nz.Anbar.Model.Report.PishFrosh;
using ShareLib.Utils;
using Nz.Anbar.Model.ViewModel;

namespace Nz.Anbar.WinForms.Report.PishFrosh
{
	public partial class Form_PishFrosh_Factor : Form
	{
		#region Logging
		private static readonly log4net.ILog log =
			log4net
				.LogManager
				.GetLogger
					(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		#endregion

		public Form_PishFrosh_Factor()
		{
			InitializeComponent();
			Nzfactor.Refresh_Grid();
			NzAnbar.Refresh_Anbar();
			NzAnbar.MS_On_Row_Selected += NzAnbarOnMS_On_Row_Selected;
		}

		private void NzAnbarOnMS_On_Row_Selected(object sender, On_Selected e)
		{
			var anbar = (NzAnbar.MS_Get_Selected() as Storage).ID; 
			Nzfactor.SetAnabr(anbar);
			Nzfactor.MS_Set_Select(null); 
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
				if (Nzfactor.MS_Get_Selected() == null)
				{
					Nzfactor.Focus();
					return;
				}
				var Anbar = (NzAnbar.MS_Get_Selected() as Storage).ID;
				var Factor = (Nzfactor.MS_Get_Selected() as FactorPishFrosh).ID;
				var Mgr = new ReportManager();
				var List = Mgr
					.GetReport<PishFoshFactor>
					(new
					{
						Year = NzCurrentYear.Checked?(short?)SystemConstant.ActiveYear.Salmali : null, 
						Anbar,
						Factor
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

		private void NzConfirm_Click(object sender, EventArgs e)
		{
			try
			{
				if (Nzfactor.MS_Get_Selected() == null)
				{
					Nzfactor.Focus();
					return;
				}

				var Factor = (Nzfactor.MS_Get_Selected() as FactorPishFrosh).ID;

				var ID = Factor;

				var mgr = new ReportManager();
				mgr.GetItem<UpdateFactorState>(new {ID},null);
        
				new Form_Notify("ذخـیـره سـازی", "اطـلاعـات بـا مـوفـقـیـت ثـبـت شـــد.",
						Form_Notify.FarsiMessageBoxIcon.اضافه)
					.Popup(Form_Notify.Direction_Show.Right_To_Left, 1000);
			}
			catch (Exception ex)
			{
				log.Error(ex);
				MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
			}
		}
	}
}
