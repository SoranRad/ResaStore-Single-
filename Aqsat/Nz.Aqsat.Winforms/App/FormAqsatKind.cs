using Nz.Aqsat.Bussiness;
using NZ.General.WinForms.Base;
using ShareLib.Models;
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
using Nz.Aqsat.Model.Models;

namespace Nz.Aqsat.Winforms.App
{
	public partial class FormAqsatKind : Form
	{
		#region Logging
		private static readonly log4net.ILog log =
			log4net
				.LogManager
				.GetLogger
					(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
		#endregion
		private Manager             _Manager;

		private AqsatKindBinding _Bind;
		private List<Aqsat_Kind> _List;

		public FormAqsatKind()
		{
			InitializeComponent();
			_Manager = new Manager();

		}

		#region Methods
		private void RefreshGrid()
		{
			try
			{
				_List = _Manager
					.GetList<Aqsat_Kind>(null)?.ToList();

				_Bind = new AqsatKindBinding(_List);
				NzGrid.DataSource = _Bind;
			}
			catch (Exception ex)
			{
				MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
				log.Error(ex);
			}
		}
        #endregion

        private void FormAqsatKind_Load(object sender, EventArgs e)
        {
			RefreshGrid();
        }

        private void NzGrid_ColumnButtonClick(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
	        if (e.Column.Key == "D")
	        {
		        try
		        {
			        var ResultDel = MS_Message.Show("آیـا بـرای حــذف ردیـف مـورد نـظر مـطـمئـنـیـد؟",
				        "تـوجـه", "", MessageBoxButtons.OKCancel, MSMessage.FarsiMessageBoxIcon.سوال);
			        if (ResultDel != DialogResult.OK)
				        return;

			        NzGrid.CurrentRow.Delete();

			        new Form_Notify("تـوجـه", "حـذف ردیــف مـورد نـظر انـجـام شــد.",
					        Form_Notify.FarsiMessageBoxIcon.چـک_باکس)
				        .Popup(Form_Notify.Direction_Show.Down_To_Up, 500);
		        }
		        catch (Exception ex)
		        {
			        MS_Message.Show("خطا در ثبت  اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
			        log.Error(ex);
		        }
	        }
		}

        private void NzGrid_AddingRecord(object sender, CancelEventArgs e)
        {
	        var Row = NzGrid.CurrentRow?.DataRow as Aqsat_Kind;
	        e.Cancel = string.IsNullOrWhiteSpace(Row?.Title?.Trim());
		}

        private void NzGrid_RecordsDeleted(object sender, EventArgs e)
        {
	        var Row = NzGrid.CurrentRow.DataRow as Aqsat_Kind;
	        try
	        {
		        var Mgr = new Manager();
		        Mgr.Save(Row);
		        this.Tag = Row.ID;
		        new Form_Notify("تـوجـه", "ردیــف مـورد نـظر بروز رسانی شــد.",
				        Form_Notify.FarsiMessageBoxIcon.چـک_باکس)
			        .Popup(Form_Notify.Direction_Show.Down_To_Up, 500);
	        }
	        catch (Exception ex)
	        {
		        log.Error(ex);
		        new Form_Notify("تـوجـه", "بروز رسانی با موفقیت انجام شد.",
				        Form_Notify.FarsiMessageBoxIcon.چـک_باکس)
			        .Popup(Form_Notify.Direction_Show.Down_To_Up, 500);
	        }
		}

        private void NzGrid_CellUpdated(object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
	        var Row = NzGrid.CurrentRow.DataRow as Aqsat_Kind;
	        try
	        {
		        var Mgr = new Manager();
		        Mgr.Save(Row);
		        this.Tag = Row.ID;
		        new Form_Notify("تـوجـه", "ردیــف مـورد نـظر بروز رسانی شــد.",
				        Form_Notify.FarsiMessageBoxIcon.چـک_باکس)
			        .Popup(Form_Notify.Direction_Show.Down_To_Up, 500);
	        }
	        catch (Exception ex)
	        {
		        log.Error(ex);
		        new Form_Notify("تـوجـه", "بروز رسانی با موفقیت انجام شد.",
				        Form_Notify.FarsiMessageBoxIcon.چـک_باکس)
			        .Popup(Form_Notify.Direction_Show.Down_To_Up, 500);
	        }
		}
    }
}
