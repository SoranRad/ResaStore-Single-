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
using Nz.Anbar.Model.Model;
using Nz.Bar.Business;
using Nz.Bar.Bussiness;
using Nz.Bar.Model.Models;
using Nz.Bar.Model.Report;
using ShareLib.Utils;

namespace Nz.Bar.Winforms.App
{
	public partial class FormCarList : Form
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
		private FormCar				_FormItem;
		#endregion
		public FormCarList()
		{
			InitializeComponent();
			this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
			_Manager = new ReportManager();
			RefreshGrid();
		}

		#region Methods
		private void Create_Form            (CarList Item)
		{
			_FormItem?.Dispose();

			_FormItem = new FormCar(Item?.ID??0);
			_FormItem.MS_Do_Save += Frm_MS_Do_Save;
			_FormItem.FormClosed += Frm_FormClosed;
		}
		private void Frm_MS_Do_Save         (object sender, EventArgs e)
		{
			var pos = ms_Grid.VerticalScrollPosition;
			RefreshGrid();
			var id = Convert.ToInt16(((AddingNewEventArgs)e).NewObject);

			var row = ms_Grid.GetRows()
				.SingleOrDefault(x => (x.DataRow as CarList).ID == id);
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
				ms_Grid.DataSource = _Manager.GetReport<CarList>(null,null)?.ToList();
			}
			catch (Exception ex)
			{
				MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
				log.Error(ex);
			}
		}
		private bool HaveCircular           (CarList Item)
		{
			try
			{
				var mgr = new Manager();
				var ha = mgr.HaveCircular<Car>(new
				{
					Item.ID
				});

				if (ha)
				{
					MS_Message.Show("ردیف مورد نطر دارای تعدادی زیر گروه فرعی است" +
					                "\n نمی توانید آن را حذف کنید");
					return true;
				}
				return false;
			}
			catch (Exception ex)
			{
				MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
				log.Error(ex);
				return true;
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
			var Row = ms_Grid.CurrentRow.DataRow as CarList;
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
					if (HaveCircular(Row))
						return;

					var mgr = new Manager();

					mgr.Delete(new Car(){ID = Row.ID});

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
			if (e.KeyCode == Keys.Insert)
				ms_Add.PerformClick();
		}

		private void mS_GridX_Setting1_MS_On_Print_Clicked(object sender, EventArgs e)
		{
			mS_GridX_Setting1.FillParametter("");
		}
	}
}
