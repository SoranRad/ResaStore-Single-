using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using MS_Control;
using MS_Control.MainForms;
using MS_Print_Dialog;
using Nz.Anbar.Model.Model;
using NZ.Anbar.Business;
using NZ.Anbar.Model;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.Base
{
    public partial class FormListObject : Form 
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
        private Manager         _Manager;
        private FormObjects     _FormItem;
        private List<NzObject>  _List ,_TempList;
        #endregion
        #region Constructor
        public FormListObject()
        {
            InitializeComponent();
            this.Icon = global::MS_Resource.GlobalResources.Logo_Resaa;
            _Manager = new Manager();
            LoadList();
            RefreshGrid();
		}
		#endregion
		#region Methods
		private void Create_Form                (NzObject Item)
        {
            _FormItem?.Dispose();

            _FormItem = new FormObjects(_Manager, Item);
            _FormItem.MS_Do_Save += Frm_MS_Do_Save;
            _FormItem.FormClosed += Frm_FormClosed;
        }
        private void Frm_MS_Do_Save             (object sender, EventArgs e)
        {
            var pos = ms_Grid.VerticalScrollPosition;
            LoadList();
            RefreshGrid();
            var id = Convert.ToInt32(((AddingNewEventArgs)e).NewObject);

            var row = ms_Grid.GetRows()
                .SingleOrDefault(x => (x.DataRow as NzObject).ID == id);
            if (row == null) return;

            ms_Grid.MoveTo(row);
            ms_Grid.EnsureVisible(row.Position);
            if ((bool)sender)
                ms_Grid.VerticalScrollPosition = pos;
        }
        private void Frm_FormClosed             (object sender, FormClosedEventArgs e)
        {
            Create_Form(null);
        }
        private void LoadList                   ()
        {
	        try
	        {
		        _List = _Manager.GetList<NzObject>()
				        ?.ToList();
	        }
	        catch (Exception ex)
	        {
		        MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
		        log.Error(ex);
	        }
        }
        private void RefreshGrid                ()
        {
            try
            {
	            if (NsSearchBox.Text.Trim().Length > 0)
	            {
		            var sentances = NsSearchBox.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

		            _TempList = _List
			            .Where((o, index) =>
			            {
				            var title = o.title.Trim();
				            while (title.Contains("  "))
					            title = title.Replace("  ", " ");

				            var nameParts = title.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

				            var indexSen = 0;
				            var trueCount = 0;

				            while (indexSen < sentances.Length)
				            {
					            var e = nameParts.Any(x => x.Contains(sentances[indexSen]));

					            if (e)
						            trueCount++;

					            indexSen++;
				            }


				            return (trueCount == sentances.Length);
			            })
			            .OrderBy(x => x.Code)
			            .ToList();
	            }
	            else
		            _TempList = _List.ToList();


	            ms_Grid.DataSource = _TempList;
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در خواندن اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private bool HaveCircular               (NzObject Item)
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
        private void ms_Add_Click               (object sender, EventArgs e)
        {
            Create_Form(null);
            _FormItem.Show(this);
        }
        private void ms_Grid_ColumnButtonClick  (object sender, Janus.Windows.GridEX.ColumnActionEventArgs e)
        {
            var Row = ms_Grid.CurrentRow.DataRow as NzObject;
            if (e.Column.Key == "E")
            {
                Create_Form(Row);
                _FormItem.Show(this);
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
                    _Manager = new Manager();
                    _Manager.Delete(Row);

                    new Form_Notify("تـوجـه", "حـذف ردیــف مـورد نـظر انـجـام شــد.",
                            Form_Notify.FarsiMessageBoxIcon.چـک_باکس)
                        .Popup(Form_Notify.Direction_Show.Down_To_Up, 500);


                    var Spos = ms_Grid.VerticalScrollPosition;
                    var Rpos = ms_Grid.CurrentRow.Position;

                    LoadList();
                    RefreshGrid();

                    if (Rpos > 0 && Rpos >= ms_Grid.RowCount)
                        Rpos--;

                    ms_Grid.MoveTo          (Rpos);
                    ms_Grid.EnsureVisible   (Rpos);
                    ms_Grid.VerticalScrollPosition = Spos;

                }
                catch (Exception ex)
                {
                    MS_Message.Show("خطا در ثبت  اطلاعات ", "خطا", ex.Message, MessageBoxButtons.OK);
                    log.Error(ex);
                }
            }
            else if (e.Column.Key == "I")
            {
                try
                {
                    var Images = _Manager.GetItem<ObjectImages>(new { ID = Row.FK_Image });

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
        }
        private void FormListStorage_KeyUp      (object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Insert)
                ms_Add.PerformClick();
        }
        private void NsSearchBox_TextChanged    (object sender, EventArgs e)
        {
            RefreshGrid();
        }
        private void NzBarcode_Click            (object sender, EventArgs e)
        {
	        {
		        if(ms_Grid.CurrentRow == null)
			        return;
		        if(ms_Grid.CurrentRow.RowType != RowType.Record)
			        return;

		        var kala = ms_Grid.CurrentRow.DataRow as NzObject;

		        var path = Utility.GetPrintDirectory()+ "\\Anbar\\Barcode.mrt";
                
		        var PrnDiag = new Print_Dialog(path);
                

		        PrnDiag.Set_Variable("BarCode"           , kala.barcode);
		        PrnDiag.Set_Variable("Title"             , kala.title);
		        PrnDiag.Set_Variable("Price"             , kala.nerkh_frosh);
              

		        PrnDiag.ShowDialog(this);
	        }
        }
        
        private void mS_GridX_Setting1_MS_On_Print_Clicked  (object sender, EventArgs e)
        {
            mS_GridX_Setting1.FillParametter("");
        }

		
	}
}
