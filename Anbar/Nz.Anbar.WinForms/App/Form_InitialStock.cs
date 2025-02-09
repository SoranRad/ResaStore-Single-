using NZ.Anbar.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using MS_Control;
using MS_Control.Tarikh;
using Nz.Anbar.Model.ViewModel;
using NZ.Anbar.Business;
using ShareLib;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.App
{
    public partial class Form_InitialStock : Form
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        NumberStyles sty = NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.Currency;
        #endregion
        #region Fields
        private string              _SimpleText;
        private string              _Dot            = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
        private int                 _Pos            = 0;
        private int                 _Len            = 0;
        private bool                _DoRefresh      = true;
        private bool                _Is_Delete_Key  = false;
        private FactorHead          _Factor;
        private BidingFactorItems   _Bind;
        private FactorManager       _Manager;
        private long?               _RowSelect;
        #endregion
        #region Constructor
        public Form_InitialStock(long? RowSelect=null)
        {
            InitializeComponent();

            _Factor             = new FactorHead();
            _Manager            = new FactorManager();
            _RowSelect          = RowSelect;
        }
        #endregion
        #region Methods
        private void Init                           ()
        {
            nzObjectPopup1.RefreshControl   (new Size(550, 170));
            nzObjectPopup1.NzSelectObject   += NzObjectPopup1OnNzSelectObject;
            nzObjectPopup1.NzEscapedPress   += NzObjectPopup1OnNzEscapedPress;
            LoadItem();
            _Bind               = new BidingFactorItems(_Factor);
            NzGrid.DataSource   = _Bind;

            if (_RowSelect.HasValue)
            {
                var item  = NzGrid
                            .GetDataRows()
                            .FirstOrDefault
                                (x => (x.DataRow as FactorItem).ID == _RowSelect.Value);

                if (item!=null)
                {
                    NzGrid.MoveTo(item.Position);
                    NzGrid.EnsureVisible(item.Position);
                }
            }
        }
        private void LoadItem                       ()
        {
            try
            {
                var Mgr     = new Manager(_Manager.Connection);
                var item    = Mgr.GetItem<InitialStorage>(new
                {
                    Year    = SystemConstant.ActiveYear.Salmali,
                    Kind    = (byte)Enums.NzFactorKind.AvalDore
                });

                _Factor     = item == null ? new FactorHead() : _Manager.GetItem(item.ID);
                SetItemsNoChanges();
            }
            catch (Exception ex)
            {
                MS_Message.Show(ex.Message);
            }
        }
        private void Save                           ()
        {
            try
            {
                if (_Factor.ID == 0)
                {
                    _Factor.FK_Salmali  = SystemConstant.ActiveYear.Salmali;
                    _Factor.FK_User_Add = SystemConstant.ActiveUser.ID;
                    _Factor.tarikh_add  = DateTime.Now;
                    _Factor.kind        = (byte) Enums.NzFactorKind.AvalDore;
                    _Factor.Serial      = 1;
                    _Factor.tarikh      = new MS_Structure_Shamsi(SystemConstant.ActiveYear.Salmali, 1, 1)
                                            .ToDatetime()
                                            .Date;
                }

                _Factor.mablaq = _Factor
                    .FactorItems.Where(x => x.State != Enums.NzItemState.Deleted)
                    .Sum(x => x.mablaq);

                RemoveUnSavedRow();

                _Manager.Save(_Factor);
                new Form_Notify("ذخـیـره سـازی", "اطـلاعـات بـا مـوفـقـیـت ثـبـت شـــد.",
                        Form_Notify.FarsiMessageBoxIcon.اضافه)
                    .Popup(Form_Notify.Direction_Show.Right_To_Left, 1000);
                SetItemsNoChanges();
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در برنامه", "", ex.Message, MessageBoxButtons.OK);
            }
        }
        private void ShowMenu                       ()
        {
            if (NzGrid.CurrentColumn == null)
                return;

            var key = NzGrid.CurrentColumn.Key;
            if (key == "FK_Kala" || key == "UnitTitle" || key == "ObjectTitle")
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
                        .FactorItems
                        .Where(x => x.ID == 0 && (x.meqdar == 0 || x.FK_Kala == 0 || x.mablaq == 0))
                        .ToList()
                        .MSZ_ForEach(x =>
                        {
                            _Bind.Remove(x);
                        });

                _Factor
                    .FactorItems
                    .Where(x => x.mablaq > 0 && x.nerkh == 0)
                    .MSZ_ForEach(x =>
                    {
                        x.nerkh = x.mablaq / x.meqdar;
                        x.State = Enums.NzItemState.Modified;
                    });
            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void SetItemsNoChanges              ()
        {
            _Factor.FactorItems.MSZ_ForEach(x =>
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
                if (NzGrid.EditMode == EditMode.EditOn
                        && NzGrid.EditTextBox != null
                        && (NzGrid.CurrentRow?.RowType == RowType.NewRecord
                                || NzGrid.CurrentRow?.RowType == RowType.Record))
                {

                    NzGrid.EditTextBox.KeyPress += EditTextBoxOnKeyPress;
                    NzGrid.EditTextBox.TextChanged += EditTextBoxOnTextChanged;
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

                var key = NzGrid.CurrentRow.DataRow as FactorItem;

                if (key?.meqdar == 0 || key?.FK_Kala == 0 || key?.nerkh==0)
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

                var key = NzGrid.CurrentRow.DataRow as FactorItem;

                if (key?.meqdar == 0 || key?.FK_Kala == 0 || key?.nerkh==0)
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

                if (char.IsLetterOrDigit(e.KeyChar) && NzGrid.CurrentRow != null)
                {
                    var key = NzGrid.CurrentColumn?.Key;
                    var type = NzGrid.CurrentRow.RowType;

                    if ((key == "FK_Kala" || key == "UnitTitle" || key == "ObjectTitle")
                            && (type == RowType.NewRecord || type == RowType.Record))
                    {
                        ShowMenu();
                    }
                }
                else if (e.KeyChar == (char)27)
                {
                    e.Handled = true;
                    NzGrid.CurrentRow?.CancelEdit();
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
                var row = NzGrid.CurrentRow.DataRow as FactorItem;
                if (row.ID > 0)
                {
                    var result = MS_Message
                        .Show("آیا برای حذف ردیف مورد نظر مطمئنید؟", 
                        "حذف ردیف",
                        MessageBoxButtons.YesNo);
                    if(result!=DialogResult.Yes)
                        return;
                }
                NzGrid.CurrentRow?.Delete();

                Save();
            }
            else if (e.Column.Key == "E")
            {
                NzGrid.CurrentColumn = NzGrid.RootTable.Columns["ObjectTitle"];
                ShowMenu();
            }
        }
        private void ms_grid_CellUpdated            (object sender, ColumnActionEventArgs e)
        {
            var row = NzGrid.CurrentRow.DataRow as FactorItem;
            if (row?.ID > 0)
                row.State = Enums.NzItemState.Modified;
        }
        private void NzGrid_CancelingRowEdit        (object sender, RowActionCancelEventArgs e)
        {
            try
            {
                var Cur = e.Row;
                if (Cur != null)
                {
                    var row = Cur.DataRow as FactorItem;
                    if (row?.ID == 0)
                        _Bind.Remove(row);
                }
                NzGrid.CurrentRow?.CancelEdit();
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
            if (!(char.IsDigit(key) || key == '\b' || key == '.' || key == '+' || key == '-'))
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

            if(TextBox==null)
                return;

            _SimpleText     = TextBox.Text.Replace(",", string.Empty);
            
            var start       = _SimpleText.Contains(_Dot)
                                ? _SimpleText.IndexOf(_Dot) - 3
                                : _SimpleText.Length - 3;
           
            for (int i = start; i > 0; i -= 3)
                _SimpleText = _SimpleText.Insert(i, ",");

            TextBox.Text = _SimpleText;
            Set_Cursor_Location();
            //===============================
            //===============================
            var col = NzGrid.CurrentColumn.Key;
                 if (col == "nerkh" )
                RefreshPrice();
            else if ( col == "meqdar")
                RefreshCount();
            else if (col == "mablaq")
                RefreshSum();
            //===============================
            //===============================
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
                _Is_Delete_Key  = keyEventArgs.KeyCode == Keys.Delete;
            }
        }
        private void Set_Cursor_Location            ()
        {
            int tm = NzGrid.EditTextBox.Text.Length - _Len;

            int x = _Pos + tm;
            x = x < 0 ? 0 : x;
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
        private void RefreshCount                   ()
        {
            try
            {
                if (NzGrid.CurrentRow == null)
                    return;

                var text = NzGrid.EditTextBox.Text.Trim();
                var Str = string.IsNullOrEmpty(text)
                                ? "0"
                                : text;

                if (decimal.TryParse(Str,
                                            sty,
                                            CultureInfo.CurrentCulture,
                                            out decimal num))
                {
                    var r = NzGrid.CurrentRow?.DataRow as FactorItem;

                    var sum = num * (r?.nerkh ?? 0);

                    if (sum == 0)
                    {
                        RefreshCurrency(0);
                        return;
                    }

                    RefreshCurrency(sum);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                RefreshCurrency(0);
            }
        }
        private void RefreshPrice                   ()
        {
            try
            {
                var text = NzGrid.EditTextBox.Text.Trim();
                var Str = string.IsNullOrEmpty(text)
                    ? "0"
                    : text;

                if (decimal.TryParse(Str,
                                            sty,
                                            CultureInfo.CurrentCulture,
                                            out decimal num))
                {
                    var r = NzGrid.CurrentRow.DataRow as FactorItem;

                    var sum = num * (r?.meqdar ?? 0);

                    if (sum == 0)
                    {
                        RefreshCurrency(0);
                        return;
                    }

                    RefreshCurrency(sum);
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                RefreshCurrency(0);
            }
        }
        private void RefreshSum                     ()
        {
            try
            {
                var text = NzGrid.EditTextBox.Text.Trim();
                var Str = string.IsNullOrEmpty(text)
                    ? "0"
                    : text;

                if (decimal.TryParse(Str,
                                            sty,
                                            CultureInfo.CurrentCulture,
                                            out decimal num))
                {
                    var r       = NzGrid.CurrentRow.DataRow as FactorItem;
                    var cell    = NzGrid.CurrentRow.Cells["nerkh"];

                    if ((r?.meqdar ?? 0) == 0)
                    {
                        RefreshCurrency(0);
                        return;
                    }


                    var nerkh = num / r.meqdar;
                    cell.Text = decimal.Round(nerkh).ToString(cell.Column.FormatString);
                    cell.Value = nerkh;
                }
            }
            catch (Exception ex)
            {
                log.Error(ex);
                RefreshCurrency(0);
            }
        }
        private void RefreshCurrency                (decimal Sum )
        {
            var cellSum     = NzGrid.CurrentRow.Cells["mablaq"];
           
            cellSum.Text    =  Sum .ToString(cellSum.Column.FormatString);
            cellSum.Value   =  Sum ;
        }
        #endregion
        //================Misc Events

        private void NzObjectPopup1OnNzSelectObject     (object sender, EventArgs eventArgs)
        {
            if (nzObjectPopup1.NzSelected == null)
                return;

            var obj                             = nzObjectPopup1.NzSelected;
            var Current                         = NzGrid.CurrentRow;

            Current.BeginEdit();
            Current.Cells["ObjectTitle"].Value  = obj.title;
            Current.Cells["FK_Kala"].Value      = obj.Code;
            Current.Cells["UnitTitle"].Value    = obj.UnitTitle;

            NzGrid.CurrentColumn               = NzGrid.RootTable.Columns["meqdar"];

        }
        private void NzObjectPopup1OnNzEscapedPress     (object sender, EventArgs eventArgs)
        {
            if (NzGrid.CurrentRow == null)
            {
                NzGrid.CancelCurrentEdit();
                return;
            }

            if (!(NzGrid.CurrentRow.DataRow is FactorItem row))
            {
                NzGrid.CancelCurrentEdit();
                NzGrid.CurrentRow.CancelEdit();
                return;
            }

            if (row.FK_Kala != 0 
                && (row.meqdar > 0 || row.nerkh > 0 || row.mablaq > 0))
                return;


            if (NzGrid.CurrentRow.RowType == RowType.NewRecord 
                && nzObjectPopup1.NzSelected == null)
            {
                NzGrid.CancelCurrentEdit();
                NzGrid.CurrentRow.CancelEdit();
            }
        }

        private void NzSave_Click                       (object sender, EventArgs e)
        {
            if (SystemConstant.ActiveYear.is_close)
            {
                MS_Message.Show("سال مالی بسته شده است " +
                                "\n  نمی توانید ادامه دهید ");
                return;
            }
            Save();
        }
        private void Form_InitialStock_Shown            (object sender, EventArgs e)
        {
            Init();
        }
        private void Form_InitialStock_KeyUp            (object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.F4)
                NzSave.PerformClick();
        }

        private void Form_InitialStock_FormClosing      (object sender, FormClosingEventArgs e)
        {
            if(_Factor.FactorItems.All(x => x.State == Enums.NzItemState.NotChanged))
                return;
            var r = MS_Message.Show(
                "آیا مایل به ذخیره تغییرات هستید؟",
                "ذخیره تغییرات", 
                MessageBoxButtons.YesNo,
                MSMessage.FarsiMessageBoxIcon.سوال);

            if(r==DialogResult.Yes)
                NzSave_Click(sender,null);

        }

        private void NzGrid_RecordAdded(object sender, EventArgs e)
        {
            NzSave_Click(sender,  e);
        }

        private void NzGrid_RecordUpdated(object sender, EventArgs e)
        {
            NzSave_Click(sender, e);
        }
    }
}
