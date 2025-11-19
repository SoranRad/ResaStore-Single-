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
using MS_Control;
using NZ.Anbar.Business;
using NZ.Anbar.Model;
using Nz.Anbar.Model.Report.PishFrosh;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.App
{
	public partial class Form_ReviewPishFactor : Form_Mother_IRANSans
	{
		#region Logging
		private static readonly log4net.ILog log =
			log4net
				.LogManager
				.GetLogger
					(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		#endregion
		private FactorManager       _Manager;
		private FactorHead          _Factor;
		public event EventHandler   AddRowItem;

		public Form_ReviewPishFactor()
		{
			InitializeComponent();
			_Manager = new FactorManager();
			
		}

		public void LoadFactor(long idFactor,int IdAnbar)
		{
			try
			{
				var Mgr = new ReportManager();
				var List = Mgr
					.GetReport<PishFoshFactor>
					(new
					{
						Year = (short?)SystemConstant.ActiveYear.Salmali , 
						Anbar = IdAnbar,
						Factor = idFactor
					}, null);

				ms_Grid.DataSource = List?.ToList();
				_Factor     = _Manager.GetItem(idFactor);
			}
			catch (Exception ex)
			{
				log.Error(ex);
				MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
			}
		}

		private void ms_Grid_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
		{
			try
			{
				var current = ms_Grid.CurrentRow.DataRow as PishFoshFactor;
				var row = _Factor.FactorItems.FirstOrDefault(x => x.FK_Kala == current.Code);

				AddRowItem?.Invoke(this, new AddingNewEventArgs(row));
			}
			catch (Exception ex)
			{
				log.Error(ex);
				MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
			}
			
		}
	}
}
