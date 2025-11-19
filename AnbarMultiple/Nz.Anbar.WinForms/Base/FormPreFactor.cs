using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using MS_Control;
using MS_Control.MainForms;
using MS_Control.Tarikh;
using NZ.Anbar.Business;
using NZ.Anbar.Model;
using Nz.Anbar.Model.Model;
using Nz.Anbar.Model.Report;
using Nz.Anbar.Model.ViewModel;
using Nz.Anbar.WinForms.App;
using Nz.Anbar.WinForms.Component;
using ShareLib;
using ShareLib.Models;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.Base
{
    public partial class FormPreFactor : Form_Mother_IRANSans
    {
         #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion
        #region Fields
        private string              _SimpleText;
        private string              _Dot            = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
        private int                 _Pos            = 0;
        private int                 _Len            = 0; 
        private bool                _DoRefresh      = true;
        private PreFactor           _Factor;
        private BindingPrefactor    _Bind;
        private PrefactorManager    _Manager;
        private long                _ID; 
        #endregion
        #region Constructor
        public FormPreFactor                        (long ID = 0)
        {
            InitializeComponent();

            _ID         = ID;
            _Manager    = new PrefactorManager();
        }
        #endregion
        #region Methods

       
        private void Init                           ()
        { 
            nzObjectPopup1.RefreshControl   (new Size(550, 220));
            nzObjectPopup1.NzSelectObject   += NzObjectPopup1OnNzSelectObject;
            nzObjectPopup1.NzEscapedPress   += NzObjectPopup1OnNzEscapedPress;
            NzGrid.FilterMode               = FilterMode.None;

            if(_ID==0)
                Reset();
            else 
                LoadItem();

            
            _Bind                       = new BindingPrefactor(_Factor); 
            NzGrid.DataSource           = _Bind;
        }
        private void LoadItem                       ()
        {
            try
            {
                _Factor     = _Manager.GetItem(_ID);
                if (_Factor == null)
                {
                    MS_Message.Show(" مورد نظر یافت نشد");
                    Reset();
                }
                _DoRefresh = false;

                NzDescription.Text          = _Factor.Title;
                _Bind                       = new BindingPrefactor(_Factor);
                NzGrid.DataSource           = _Bind;

                _DoRefresh = true;
            }
            catch (Exception ex)
            {
                MS_Message.Show(ex.Message);
                log.Error(ex);
            }
        }
        private void Save                           ()
        {
            try
            {

                _Factor.Title = NzDescription.Text.Trim();

                _Manager.Save(_Factor);


                new Form_Notify("ذخـیـره سـازی", "اطـلاعـات بـا مـوفـقـیـت ثـبـت شـــد.",
                        Form_Notify.FarsiMessageBoxIcon.اضافه)
                    .Popup(Form_Notify.Direction_Show.Right_To_Left, 1000);

                SetItemsNoChanges();
            }
            catch (Exception ex)
            {
                //log.Error(ex);
                MS_Message.Show("خطا در برنامه، فاکتور مورد نظر ذخیره نشد.لطفا فرم را ببندید و مجددا اقدام نمایید.", "خطا", ex.Message, MessageBoxButtons.OK);
            }
        }
        private void Reset                          ()
        {
            _DoRefresh                  = false;
             
            _ID                         = 0;
            _Factor                     = new PreFactor();
            _Bind                       = new BindingPrefactor(_Factor);
            NzGrid.DataSource           = _Bind;
            NzDescription.Text          = "";

            _DoRefresh                  = true;
        }
        private void ShowMenu                       ()
        {
            if (NzGrid.CurrentColumn == null)
                return;

            var key = NzGrid.CurrentColumn.Key;
            if (key == "ObjectCode" || key == "UnitTitle" || key == "ObjectTitle")
            {
                var rec =
                    NzGrid.CurrentRow == null ?
                        NzGrid.Bounds
                        : NzGrid.GetCellBounds(NzGrid.CurrentRow.Position, NzGrid.RootTable.Columns["ObjectTitle"]);

                nzObjectPopup1.NzSelected = null;
                nzObjectPopup1.Show(NzGrid, new Point(rec.X + rec.Width, rec.Y + rec.Height), ToolStripDropDownDirection.BelowLeft);
                SendKeys.Send("{TAB}");
            }
        }
        private void RemoveUnSavedRow               ()
        {
            try
            {
                _Factor
                        .Items
                        .Where(x => x.ID == 0 && x.FK_Kala == 0 )
                        .ToList()
                        .MSZ_ForEach(x =>
                        {
                            _Bind.Remove(x);
                        });
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private bool IsOK                           ()
        {
            try
            {
                if (string.IsNullOrEmpty(NzDescription.Text))
                {
                    NzDescription.Focus();
                    mS_Notify1.Show(NzDescription);
                    return false;
                }

                if (_Bind.Count == 0)
                {
                    MS_Message.Show("تعدادی کالا را وارد کنید");
                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                log.Error(ex);
                MS_Message.Show("خطا در اعتبار سنجی");
                return false;
            }
        }
        private void SetItemsNoChanges              ()
        {
            _Factor.Items.MSZ_ForEach(x =>
            {
                x.State = Enums.NzItemState.NotChanged;
            });
        }
        #endregion
        #region Grid Events
        private void ms_grid_EditModeChanged        (object sender, EventArgs e)
        {
            try
            {
                if (
                           NzGrid.EditMode == EditMode.EditOn
                        && NzGrid.EditTextBox != null
                        && (
                                   NzGrid.CurrentRow?.RowType == RowType.NewRecord
                                || NzGrid.CurrentRow?.RowType == RowType.Record
                            )
                    )
                {

                    NzGrid.EditTextBox.KeyPress     += EditTextBoxOnKeyPress;
                    NzGrid.EditTextBox.TextChanged  += EditTextBoxOnTextChanged;
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void ms_grid_RowDoubleClick         (object sender, RowActionEventArgs e)
        {
            try
            {
                if (!(e.Row.RowType == RowType.Record || e.Row.RowType == RowType.NewRecord))
                    return;
                ShowMenu();
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void ms_grid_CurrentCellChanged     (object sender, EventArgs e)
        {
            try
            {
                if (NzGrid.CurrentRow?.RowType == RowType.NewRecord)
                    ShowMenu();
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void ms_grid_UpdatingRecord         (object sender, CancelEventArgs e)
        {
            try
            {
                if (NzGrid.CurrentRow == null)
                    return;

                var key = NzGrid.CurrentRow.DataRow as PreFactorItems;

                if ( key?.FK_Kala == 0 )
                {
                    NzGrid.CancelCurrentEdit();
                    NzGrid.CurrentRow.CancelEdit();
                    e.Cancel = true;
                    _Bind.Remove(key);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void ms_grid_AddingRecord           (object sender, CancelEventArgs e)
        {
            try
            {
                if (NzGrid.CurrentRow == null)
                    return;

                var key = NzGrid.CurrentRow.DataRow as PreFactorItems;

                if (key?.FK_Kala == 0)
                {
                    NzGrid.CancelCurrentEdit();
                    NzGrid.CurrentRow.CancelEdit();
                    e.Cancel = true;
                    _Bind.Remove(key);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
            
        }
        private void ms_grid_KeyPress               (object sender, KeyPressEventArgs e)
        {
            try
            {
                var Cur = NzGrid.CurrentRow;

                if (char.IsLetterOrDigit(e.KeyChar) && Cur != null)
                {
                    var key     = NzGrid.CurrentColumn?.Key;
                    var type    = Cur.RowType;

                    if ((key == "ObjectCode" || key == "UnitTitle" || key == "ObjectTitle")
                            && (type == RowType.NewRecord || type == RowType.Record))
                    {
                        ShowMenu();
                    }
                }
                else if (e.KeyChar == (char)27)
                {
                    e.Handled = true;
                    if (Cur != null)
                    {
                        if (Cur.RowType == RowType.NewRecord)
                        {
                            Cur?.CancelEdit();
                            var row = Cur?.DataRow as PreFactorItems;
                            if (row?.ID > 0)
                            {
                                Cur?.Delete(); 
                                //Save();
                            }
                        }
                    }
                    Cur?.CancelEdit();
                    NzGrid.CancelCurrentEdit();

                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void ms_grid_ColumnButtonClick      (object sender, ColumnActionEventArgs e)
        {
            if (e.Column.Key == "D")
            {
                if (NzGrid.CurrentRow?.DataRow == null)
                    return;

                if (NzGrid.CurrentRow.RowType == RowType.NewRecord)
                {
                    NzGrid.CancelCurrentEdit();
                    NzGrid.CurrentRow.CancelEdit(); 
                    return;
                }
                var row = NzGrid.CurrentRow.DataRow as PreFactorItems;
                if (row?.ID > 0)
                {
                    var result = MS_Message
                        .Show("آیا برای حذف ردیف مورد نظر مطمئنید؟", 
                        "حذف ردیف",
                        MessageBoxButtons.YesNo);
                    if(result!=DialogResult.Yes)
                        return;
                }
                NzGrid.CurrentRow?.Delete(); 
            }
            else if (e.Column.Key == "E")
            {
                NzGrid.CurrentColumn = NzGrid.RootTable.Columns["ObjectTitle"];
                ShowMenu();
            }
        }
        private void ms_grid_CellUpdated            (object sender, ColumnActionEventArgs e)
        {

            try
            {
                var row = NzGrid.CurrentRow?.DataRow as PreFactorItems;
                if (row?.ID > 0)
                    row.State = Enums.NzItemState.Modified;
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void NzGrid_CancelingRowEdit        (object sender, RowActionCancelEventArgs e)
        {
            try
            {
                var Cur = e.Row;
                if (Cur != null && Cur.RowType == RowType.NewRecord)
                {
                    var row = Cur.DataRow as PreFactorItems;
                    if (row != null)
                        _Bind.Remove(row);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
          
        #endregion
        #region TextBox Events
        private void EditTextBoxOnKeyPress          (object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (!(char.IsDigit(key) || key == '\b' || key == '.' || key=='+' || key == '-'))
                e.Handled = true;
            if (key == '.' && NzGrid.EditTextBox.Text.Contains("."))
                e.Handled = true;
            if (key == '+')
            {
                NzGrid.EditTextBox.Text += "000";
                e.Handled = true;
            }
            else if (key == '-')
            {
                NzGrid.EditTextBox.Text += "00";
                e.Handled = true;
            }
        }
        private void EditTextBoxOnTextChanged       (object sender, EventArgs eventArgs)
        {
            if(!_DoRefresh)
                return;
            _DoRefresh      = false;

            var TextBox     = NzGrid.EditTextBox;
            
            if (TextBox == null)
                return;

            _SimpleText     = TextBox.Text.Replace(",", string.Empty);
            
            var start       = _SimpleText.Contains(_Dot)
                                ? _SimpleText.IndexOf(_Dot) - 3
                                : _SimpleText.Length - 3;
           
            for (int i = start; i > 0; i -= 3)
                _SimpleText = _SimpleText.Insert(i, ",");

            TextBox.Text = _SimpleText;
            Set_Cursor_Location();
             
            _DoRefresh = true;
        }
        private void EditTextBoxOnGotFocus          (object sender, EventArgs eventArgs)
        {
            if (NzGrid.EditTextBox != null)
                NzGrid.EditTextBox.Text = NzGrid.CurrentRow.Cells[NzGrid.CurrentColumn].Text;
        }
        private void EditTextBoxOnKeyDown           (object sender, KeyEventArgs keyEventArgs)
        {
            if (NzGrid.EditTextBox != null)
            {
                _Pos            = NzGrid.EditTextBox.SelectionStart + NzGrid.EditTextBox.SelectionLength;
                _Len            = NzGrid.EditTextBox.Text.Length; 
            }
        }

        private void Set_Cursor_Location            ()
        {
            if(NzGrid.EditTextBox==null) 
                return;

            int tm = NzGrid.EditTextBox.Text.Length - _Len;

            //int x = _Pos + tm;
            //x = x < 0 ? 0 : x;
            if (tm > 0)// طول زیاد شده باشد
            {
                NzGrid.EditTextBox.Select(_Pos + tm, 0);
            }
            else if (tm < 0) //  اگر طول کم شده باشد
            {
                var i = Math.Max(0, _Pos + tm);
                NzGrid.EditTextBox.Select(i, 0);
            }
            else // طول 
            {
                NzGrid.EditTextBox.Select(_Pos, 0);
            }
            //_Len = ms_grid.EditTextBox.Text.Length;
            //if (tm < 0 && TextLength == 1)
            //    base.Select(TextLength, 0);
            //else if(TextLength>0 && tm==0)
            //    base.Select(TextLength, 0);
            //else
            //    base.Select(x, 0);
            //_Len = TextLength;
        }
        #endregion
        private void NzObjectPopup1OnNzSelectObject     (object sender, EventArgs eventArgs)
        {
            if (nzObjectPopup1.NzSelected == null || NzGrid.CurrentRow == null )
                return;


            var obj                             = nzObjectPopup1.NzSelected;
            var Current                         = NzGrid.CurrentRow;

            Current?.BeginEdit();

            Current.Cells["ObjectTitle"].Value  = obj.title;
            Current.Cells["FK_Kala"].Value      = obj.ID;
            Current.Cells["ObjectCode"].Value   = obj.Code;
            Current.Cells["UnitTitle"].Value    = obj.UnitTitle;

             

            NzGrid.CurrentColumn = NzGrid.RootTable.Columns["Count"];
        }
        private void NzObjectPopup1OnNzEscapedPress     (object sender, EventArgs eventArgs)
        {
            if (NzGrid.CurrentRow == null)
            {
                NzGrid.CancelCurrentEdit();
                return;
            }


            if (!(NzGrid.CurrentRow.DataRow is PreFactorItems row))
            {
                NzGrid.CancelCurrentEdit();
                NzGrid.CurrentRow.CancelEdit();
                return;
            }

            if (row.FK_Kala != 0 )
                return;

            if (    NzGrid.CurrentRow.RowType == RowType.NewRecord 
                &&  nzObjectPopup1.NzSelected == null)
            {
                NzGrid.CancelCurrentEdit();
                NzGrid.CurrentRow.CancelEdit();
            }
        }

        private void Form_Purchase_Shown                (object sender, EventArgs e)
        {
            Init();
        }
        private void Form_Purchase_KeyUp                (object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F4:
                    NzSave.PerformClick();
                    break;
                case Keys.F6:
                    NzDescription.Focus();
                    break;
                case Keys.Insert:
                    NzGrid.Focus();
                    NzGrid.MoveToNewRecord();
                    NzGrid.CurrentColumn = NzGrid.RootTable.Columns["ObjectTitle"];
                    ShowMenu();
                    break;
                case Keys.P:
                    if(e.Control)
                        NzPrint.PerformClick();
                    break;
            }
        }
        private void NzPrint_Click                      (object sender, EventArgs e)
        {
            var prn = new Print.PrintPrefactor(_Factor.ID); 
            prn.Show(this);
        }
          
        private void NzSave_Click                       (object sender, EventArgs e)
        {
            RemoveUnSavedRow(); 

            if (IsOK())
                Save();
        }
        private void NzNew_Click                        (object sender, EventArgs e)
        {
            Reset();
        }
    }
}
