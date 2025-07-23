using MS_Control;
using Nz.Bar.Model.Models;
using Nz.Bar.Model.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MS_Control.Tarikh;
using Nz.Bar.Business;
using Nz.Bar.Bussiness;
using ShareLib.Utils;

namespace Nz.Bar.Winforms.App
{
    public partial class FormListBar : Form
    {
        #region Logging
		private static readonly log4net.ILog log =
			log4net
				.LogManager
				.GetLogger
				(System.Reflection
					.MethodBase
					.GetCurrentMethod()
					.DeclaringType);
		#endregion
		#region Fields
		private ReportManager		_Manager;
		private FormBar				_FormItem;
		#endregion
		public FormListBar	()
		{
			InitializeComponent();
			this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
			_Manager = new ReportManager();
			ms_mah.SelectedTabChanged           += NzFactorKinds_SelectedTabChanged;
			SetCurrentMonth();
			RefreshGrid();
		}

		#region Methods
		private void SetCurrentMonth                    ()
		{
			var mah                 = new MS_Structure_Shamsi(DateTime.Now)._Mah;
			ms_mah.SelectedIndex    = 13 - mah; 
		}
		private void NzFactorKinds_SelectedTabChanged   (object sender, Janus.Windows.UI.Tab.TabEventArgs e)
		{
			RefreshGrid();
		}
		private void Create_Form            (BarFactorList Item)
		{
			_FormItem?.Dispose();

			_FormItem = new FormBar(Item?.ID ?? 0);
			_FormItem.MS_Do_Save += Frm_MS_Do_Save;
			_FormItem.FormClosed += Frm_FormClosed;
		}
		private void Frm_MS_Do_Save         (object sender, EventArgs e)
		{
			var pos = ms_Grid.VerticalScrollPosition;
			RefreshGrid();
			var id = Convert.ToInt64(((AddingNewEventArgs)e).NewObject);

			var row = ms_Grid.GetRows().SingleOrDefault(x => ((BarFactorList)x.DataRow).ID == id);
			if (row == null) return;

			ms_Grid.MoveTo(row);
			ms_Grid.EnsureVisible(row.Position);
			if ((bool)sender)
				ms_Grid.VerticalScrollPosition = pos;
		}
		private void Frm_FormClosed         (object sender, FormClosedEventArgs e)
		{
			Create_Form(null);
		}
		private void RefreshGrid            ()
		{
			try
			{

				var Month = 13 - ms_mah.SelectedIndex;

				ms_Grid.DataSource = _Manager.GetReport<BarFactorList>(new
				{
					Year = SystemConstant.ActiveYear.Salmali,
					Month

				},null)?.ToList();
			}
			catch (Exception ex)
			{
				MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
				log.Error(ex);
			}
		}
		#endregion
		private void ms_Add_Click               (object sender, EventArgs e)
		{
			Create_Form(null);
			_FormItem.Show(this);
		}
		private void ms_Grid_ColumnButtonClick  (object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
		{
			var Row = ms_Grid.CurrentRow.DataRow as BarFactorList;
			if (e.Column.Key == "E")
			{
				Create_Form     (Row);
				_FormItem.Show  (this);
			}
			else if (e.Column.Key == "D")
			{
				try
				{
					var ResultDel = MS_Message.Show("آیـا بـرای حــذف ردیـف مـورد نـظر مـطـمئـنـیـد؟"
						, "تـوجـه"
						, ""
						, MessageBoxButtons.OKCancel
						, MSMessage.FarsiMessageBoxIcon.سوال);

					if (ResultDel != DialogResult.OK)
						return;

					var mgr = new Manager();

					mgr.Delete(new BarFactor(){ID = Row.ID});

					new Form_Notify("تـوجـه", "حـذف ردیــف مـورد نـظر انـجـام شــد.",
							Form_Notify.FarsiMessageBoxIcon.چـک_باکس)
						.Popup(Form_Notify.Direction_Show.Down_To_Up, 500);


					var Spos = ms_Grid.VerticalScrollPosition;
					var Rpos = ms_Grid.CurrentRow.Position;

					RefreshGrid();

					if (Rpos > 0 && Rpos >= ms_Grid.RowCount)
						Rpos--;

					ms_Grid.MoveTo(Rpos);
					ms_Grid.EnsureVisible(Rpos);
					ms_Grid.VerticalScrollPosition = Spos;

				}
				catch (Exception ex)
				{
					MS_Message.Show("خطا در ثبت  اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
					log.Error(ex);
				}
			}
		}
		private void FormListStorage_KeyUp      (object sender, KeyEventArgs e)
		{
			//if (e.KeyCode == Keys.Insert)
			//	ms_Add.PerformClick();
		}

		private void mS_GridX_Setting1_MS_On_Print_Clicked(object sender, EventArgs e)
		{
			mS_GridX_Setting1.FillParametter("");
		}

		private void NzRefreshList_Click(object sender, EventArgs e)
		{
			RefreshGrid();
		}
	}
}
