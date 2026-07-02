using Janus.Windows.GridEX;
using MS_Control;
using MS_Control.Controls;
using Nz.Anbar.Model.Model;
using NZ.Anbar.Business;
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
using NZ.Anbar.Model;

namespace Nz.Anbar.WinForms.Base
{
    public partial class FormCodingKala : Form
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
		private Manager			_Manager;
		private FormMainGroup	_FormMainGroup;
		private FormSubGroup	_FormSubGroup;
		private FormObjects		_FormObjects;

		private bool			_DoRefresh = true;

		#endregion
		public FormCodingKala()
        {
            InitializeComponent();
            this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
            _Manager = new Manager();

           
        }
		 
		#region Main Group Methods
		private void Create_FormMain			(MainGroup Item)
		{
			_FormMainGroup?.Dispose();

			_FormMainGroup = new FormMainGroup(_Manager, Item);
			_FormMainGroup.MS_Do_Save += Frm_MS_Do_Save_Main;
			_FormMainGroup.FormClosed += Frm_FormClosed_Main;
		}
		private void Frm_MS_Do_Save_Main		(object sender, EventArgs e)
		{
			var pos = NsMainGrid.VerticalScrollPosition;
			RefreshGrid_Main();
			var id = Convert.ToInt16(((AddingNewEventArgs)e).NewObject);

			var row = NsMainGrid.GetRows()
				.SingleOrDefault(x => (x.DataRow as MainGroup).ID == id);
			if (row == null) return;

			NsMainGrid.MoveTo(row);
			NsMainGrid.EnsureVisible(row.Position);
			if ((bool)sender)
				NsMainGrid.VerticalScrollPosition = pos;
		}
		private void Frm_FormClosed_Main		(object sender, FormClosedEventArgs e)
		{
			Create_FormMain(null);
		}
		private void RefreshGrid_Main			()
		{
			try
			{
				NsMainGrid.DataSource = _Manager.GetList<MainGroup>
						(new { Year = SystemConstant.ActiveYear.Salmali })
					?.ToList();
			}
			catch (Exception ex)
			{
				MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
				log.Error(ex);
			}
		}
		private bool HaveCircular_Main			(MainGroup Item)
		{
			if (_Manager
			    .HaveCircular<MainGroup>
			    (new
			    {
				    Year = SystemConstant.ActiveYear.Salmali,
				    Item.Code
			    })
			   )
			{
				MS_Message.Show("ردیف مورد نطر دارای تعدادی زیر گروه فرعی است" +
				                "\n نمی توانید آن را حذف کنید");
				return true;
			}
			return false;
		}
		#endregion

		#region MainGroup Buttons
		private void NsEditMainGroup_Click		(object sender, EventArgs e)
		{
			var Row = NsMainGrid.CurrentRow.DataRow as MainGroup;

			Create_FormMain(Row);
			_FormMainGroup.Show(this);
		}
		private void NsDeleteMainGroup_Click	(object sender, EventArgs e)
		{
			var Row = NsMainGrid.CurrentRow.DataRow as MainGroup;

			var ResultDel = MS_Message.Show("آیـا بـرای حــذف ردیـف مـورد نـظر مـطـمئـنـیـد؟"
				, "تـوجـه"
				, ""
				, MessageBoxButtons.OKCancel
				, MSMessage.FarsiMessageBoxIcon.سوال);

			if (ResultDel != DialogResult.OK)
				return;
			if (HaveCircular_Main(Row))
				return;
			_Manager = new Manager();

			_Manager.Delete(Row);

			new Form_Notify("تـوجـه", "حـذف ردیــف مـورد نـظر انـجـام شــد.",
					Form_Notify.FarsiMessageBoxIcon.چـک_باکس)
				.Popup(Form_Notify.Direction_Show.Down_To_Up, 500);

			_DoRefresh = false;

			var Spos = NsMainGrid.VerticalScrollPosition;
			var Rpos = NsMainGrid.CurrentRow.Position;

			RefreshGrid_Main();

			if (Rpos > 0 && Rpos >= NsMainGrid.RowCount)
				Rpos--;

			NsMainGrid.EnsureVisible(Rpos);
			NsMainGrid.VerticalScrollPosition = Spos;
			NsMainGrid.MoveTo(Rpos);

			_DoRefresh = true;
		}
		private void NsAddMainGroup_Click		(object sender, EventArgs e)
		{
			Create_FormMain(null);
			_FormMainGroup.Show(this);
		}
		private void ms_Grid_SelectionChanged	(object sender, EventArgs e)
		{
			if(!_DoRefresh)
				return;

			if (NsMainGrid.CurrentRow == null)
				return;

			NsEditMainGroup.Enabled = NsDeleteMainGroup.Enabled = NsMainGrid.CurrentRow.RowType == RowType.Record;

			// refresh Sub Group
			RefreshGrid_SubGroup();
		}
		private void ms_Grid_RowDoubleClick		(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
		{

		}
		private void NsRefreshGridMain_Click	(object sender, EventArgs e)
		{
			_DoRefresh = false;

			var Spos = NsMainGrid.VerticalScrollPosition;
			var Rpos = NsMainGrid.CurrentRow.Position;

			RefreshGrid_Main();

			if (Rpos > 0 && Rpos >= NsMainGrid.RowCount)
				Rpos--;

			NsMainGrid.EnsureVisible(Rpos);
			NsMainGrid.VerticalScrollPosition = Spos;
			NsMainGrid.MoveTo(Rpos);

			_DoRefresh = true;
		}
		#endregion
		#region Methods SubGroup
		private void Create_Form_SubGroup		(SubGroup Item)
		{
			_FormSubGroup?.Dispose();

			var mainGroup = NsMainGrid.CurrentRow?.DataRow as MainGroup;

			_FormSubGroup = new FormSubGroup(_Manager, Item , mainGroup?.Code);
			_FormSubGroup.MS_Do_Save += Frm_MS_Do_Save_SubGroup;
			_FormSubGroup.FormClosed += Frm_FormClosed_SubGroup;
		}
		private void Frm_MS_Do_Save_SubGroup	(object sender, EventArgs e)
		{
			var pos = NsGridSubGroup.VerticalScrollPosition;
			RefreshGrid_SubGroup();
			var id = Convert.ToInt16(((AddingNewEventArgs)e).NewObject);

			var row = NsGridSubGroup.GetRows()
				.SingleOrDefault(x => (x.DataRow as SubGroup).ID == id);
			if (row == null) return;

			NsGridSubGroup.MoveTo(row);
			NsGridSubGroup.EnsureVisible(row.Position);
			if ((bool)sender)
				NsGridSubGroup.VerticalScrollPosition = pos;
		}
		private void Frm_FormClosed_SubGroup	(object sender, FormClosedEventArgs e)
		{
			Create_Form_SubGroup(null);
		}
		private void RefreshGrid_SubGroup		()
		{
			try
			{
				var main = NsMainGrid.CurrentRow.DataRow as MainGroup;
				NsGridSubGroup.DataSource = _Manager.GetList<SubGroup>(new { FkGroup1 = NsShowAllSubGroup.Checked ? null : main?.Code})?.ToList();
			}
			catch (Exception ex)
			{
				MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
				log.Error(ex);
			}
		}
		private bool HaveCircular_SubGroup		(SubGroup Item)
		{
			if (_Manager
			    .HaveCircular<SubGroup>
			    (new
			    {
				    Year = SystemConstant.ActiveYear.Salmali,
				    Item.Code
			    })
			   )
			{
				MS_Message.Show("ردیف مورد نطر دارای چند کالای تعریف شده است" +
				                "\n نمی توانید آن را حذف کنید");
				return true;
			}
			return false;
		}
		#endregion
		
		private async void FormCodingKala_Load	(object sender, EventArgs e)
		{
			_DoRefresh = false;
			RefreshGrid_Main();
			RefreshGrid_SubGroup();
			RefreshGrid_Kala();
			_DoRefresh = true;

			await webView21.EnsureCoreWebView2Async(null);
			//string videoPageUrl = "<div id=\"82614723436\"><script type=\"text/JavaScript\" src=\"https://www.aparat.com/embed/fvj510m?data[rnddiv]=82614723436&data[responsive]=yes\"></script></div>";
			//webView21.CoreWebView2.;
		}

		#region SubGroup Buttons
		private void NsEditSubGroup_Click				(object sender, EventArgs e)
		{
			var Row = NsGridSubGroup.CurrentRow.DataRow as SubGroup;
			Create_Form_SubGroup(Row);
			_FormSubGroup.Show(this);
		}
		private void NsDeleteSubGroup_Click				(object sender, EventArgs e)
		{
			try
			{
				var Row = NsGridSubGroup.CurrentRow.DataRow as SubGroup;

				var ResultDel = MS_Message.Show("آیـا بـرای حــذف ردیـف مـورد نـظر مـطـمئـنـیـد؟"
					, "تـوجـه"
					, ""
					, MessageBoxButtons.OKCancel
					, MSMessage.FarsiMessageBoxIcon.سوال);

				if (ResultDel != DialogResult.OK)
					return;
				if (HaveCircular_SubGroup(Row))
					return;
				_Manager = new Manager();

				_Manager.Delete(Row);

				new Form_Notify("تـوجـه", "حـذف ردیــف مـورد نـظر انـجـام شــد.",
						Form_Notify.FarsiMessageBoxIcon.چـک_باکس)
					.Popup(Form_Notify.Direction_Show.Down_To_Up, 500);


				var Spos = NsGridSubGroup.VerticalScrollPosition;
				var Rpos = NsGridSubGroup.CurrentRow.Position;

				RefreshGrid_SubGroup();

				if (Rpos > 0 && Rpos >= NsGridSubGroup.RowCount)
					Rpos--;

				NsGridSubGroup.MoveTo(Rpos);
				NsGridSubGroup.EnsureVisible(Rpos);
				NsGridSubGroup.VerticalScrollPosition = Spos;

			}
			catch (Exception ex)
			{
				MS_Message.Show("خطا در ثبت  اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
				log.Error(ex);
			}
		}
		private void NsAddSubGroup_Click				(object sender, EventArgs e)
		{
			Create_Form_SubGroup(null);
			_FormSubGroup.Show(this);
		}
		private void NsRefreshGridSub_Click				(object sender, EventArgs e)
		{
			_DoRefresh = false;

			var Spos = NsGridSubGroup.VerticalScrollPosition;
			var Rpos = NsGridSubGroup.CurrentRow?.Position??0;

			RefreshGrid_SubGroup();

			if (Rpos > 0 && Rpos >= NsGridSubGroup.RowCount)
				Rpos = NsGridSubGroup.RowCount -1;

			NsGridSubGroup.EnsureVisible(Rpos);
			NsGridSubGroup.VerticalScrollPosition = Spos;
			NsGridSubGroup.MoveTo(Rpos);

			_DoRefresh = true;
		}
		private void NsShowAllSubGroup_CheckedChanged	(object sender, EventArgs e)
		{
			NsRefreshGridSub.PerformClick();
		}
		private void NsGridSubGroup_SelectionChanged	(object sender, EventArgs e)
		{
			if (!_DoRefresh)
				return;

			if (NsGridSubGroup.CurrentRow == null)
				return;

			NsEditSubGroup.Enabled = NsDeleteSubGroup.Enabled = NsGridSubGroup.CurrentRow.RowType == RowType.Record;

			RefreshGrid_Kala();
		}
		#endregion

		#region Methods Kala
		private void Create_Form_Kala					(NzObject Item)
		{
			var SubGroup = NsGridSubGroup.CurrentRow?.DataRow as SubGroup;

			_FormObjects?.Dispose();
			
			_FormObjects = new FormObjects(_Manager, Item,SubGroup?.Code);
			_FormObjects.MS_Do_Save += Frm_MS_Do_Save_Kala;
			_FormObjects.FormClosed += Frm_FormClosed_Kala;
		}
		private void Frm_MS_Do_Save_Kala				(object sender, EventArgs e)
		{
			var pos = NsGridKala.VerticalScrollPosition;
			RefreshGrid_Kala();
			var id = Convert.ToInt32(((AddingNewEventArgs)e).NewObject);

			var row = NsGridKala.GetRows()
				.SingleOrDefault(x => (x.DataRow as NzObject).ID == id);
			if (row == null) return;

			NsGridKala.MoveTo(row);
			NsGridKala.EnsureVisible(row.Position);
			if ((bool)sender)
				NsGridKala.VerticalScrollPosition = pos;
		}
		private void Frm_FormClosed_Kala				(object sender, FormClosedEventArgs e)
		{
			Create_Form_Kala(null);
		}
		private void RefreshGrid_Kala					()
		{
			try
			{
				var sub = NsGridSubGroup.CurrentRow.DataRow as SubGroup;

				NsGridKala.DataSource = _Manager.GetList<NzObject>(new { FkGroup2 = NsShowAllObjects.Checked ? null : sub?.Code })?.ToList();
			}
			catch (Exception ex)
			{
				MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
				log.Error(ex);
			}
		}
		private bool HaveCircularKala						(NzObject Item)
		{
			if (_Manager
			    .HaveCircular<NzObject>
			    (new
			    {
				    Item.Code
			    })
			   )
			{
				MS_Message.Show("ردیف مورد نطر دارای گردش عملیاتی است" +
				                "\n نمی توانید آن را حذف کنید");
				return true;
			}
			return false;
		}

		#endregion
		#region Buttons Kala
		private void	NsImageKala_Click					(object sender, EventArgs e)
		{
			try
			{
				var Row		= NsGridKala.CurrentRow.DataRow as NzObject;
				var Images	= _Manager.GetItem<ObjectImages>(new { ID = Row.FK_Image });

				if (Images?.Image != null && Images.Image.LongLength > 0)
					new MS_Control.Image.Form_Image_Viewer(Images.Image).ShowDialog();
				else
					MS_Message.Show("تصویری برای این مورد ثبت نشده است");
			}
			catch (Exception ex)
			{
				MS_Message.Show("برنامه قادر به خواندن تصویر نیست");
				log.Error(ex);
			}
		}
		private void	NsEditKala_Click					(object sender, EventArgs e)
		{
			var Row = NsGridKala.CurrentRow.DataRow as NzObject;
			Create_Form_Kala(Row);
			_FormObjects.Show(this);
		}
		private void	NsDeleteKala_Click					(object sender, EventArgs e)
		{
			try
			{
				var Row = NsGridKala.CurrentRow.DataRow as NzObject;


				var ResultDel = MS_Message.Show("آیـا بـرای حــذف ردیـف مـورد نـظر مـطـمئـنـیـد؟"
					, "تـوجـه"
					, ""
					, MessageBoxButtons.OKCancel
					, MSMessage.FarsiMessageBoxIcon.سوال);

				if (ResultDel != DialogResult.OK)
					return;
				if (HaveCircularKala(Row))
					return;
				_Manager = new Manager();
				_Manager.Delete(Row);

				new Form_Notify("تـوجـه", "حـذف ردیــف مـورد نـظر انـجـام شــد.",
						Form_Notify.FarsiMessageBoxIcon.چـک_باکس)
					.Popup(Form_Notify.Direction_Show.Down_To_Up, 500);


				var Spos = NsGridKala.VerticalScrollPosition;
				var Rpos = NsGridKala.CurrentRow.Position;

				RefreshGrid_Kala();

				if (Rpos > 0 && Rpos >= NsGridKala.RowCount)
					Rpos--;

				NsGridKala.MoveTo(Rpos);
				NsGridKala.EnsureVisible(Rpos);
				NsGridKala.VerticalScrollPosition = Spos;

			}
			catch (Exception ex)
			{
				MS_Message.Show("خطا در ثبت  اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
				log.Error(ex);
			}
		}
		private void	NsAddKala_Click						(object sender, EventArgs e)
		{
			Create_Form_Kala(null);
			_FormObjects.Show(this);
		}
		private void	NsRefreshObjects_Click				(object sender, EventArgs e)
		{
			_DoRefresh = false;

			var Spos = NsGridKala.VerticalScrollPosition;
			var Rpos = NsGridKala.CurrentRow?.Position??0;

			RefreshGrid_Kala();

			if (Rpos > 0 && Rpos >= NsGridKala.RowCount)
				Rpos = NsGridKala.RowCount - 1;

			NsGridKala.EnsureVisible(Rpos);
			NsGridKala.VerticalScrollPosition = Spos;
			NsGridKala.MoveTo(Rpos);

			_DoRefresh = true;
		}
		private void	NzBarcode_Click						(object sender, EventArgs e)
		{
			if (NsGridKala.GetCheckedRows().Any())
			{
				var kalaHa = NsGridKala.GetCheckedRows().Select(x => x.DataRow as NzObject).ToList();

				new Print.PrintBarcode(kalaHa).Show(this);
			}
		}
		private void	NsGridKala_SelectionChanged			(object sender, EventArgs e)
		{
			if (!_DoRefresh)
				return;

			if (NsGridKala.CurrentRow == null)
				return;

			NsEditKala.Enabled = NsDeleteKala.Enabled = NsImageKala.Enabled = NsGridKala.CurrentRow.RowType == RowType.Record;
		}
		private void	NsShowAllObjects_CheckedChanged		(object sender, EventArgs e)
		{
			NsRefreshObjects.PerformClick();
		}
		#endregion

		private void webView21_Click(object sender, EventArgs e)
		{
			string videoPageUrl = "https://www.aparat.com/v/fvj510m";

			// ناوبری به صفحه ویدیو
			webView21.CoreWebView2.Navigate(videoPageUrl);
		}
	}
}
