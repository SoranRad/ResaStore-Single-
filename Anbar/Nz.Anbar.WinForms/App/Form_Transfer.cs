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
using Nz.Anbar.Model.ViewModel;
using Nz.Anbar.WinForms.Print;
using NZ.Anbar.Business;
using NZ.Anbar.Model;
using Nz.Anbar.Model.Report;
using ShareLib;
using ShareLib.Models;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.App
{
    public partial class Form_Transfer : Form_Mother_IRANSans
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
        private bool                _IsEdit         = false;
        private bool                _Is_Delete_Key  = false;
        private bool                _DoRefresh      = true;
        private FactorHead          _Factor;
        private BidingFactorItems   _Bind;
        private FactorManager       _Manager;
        private long                _ID;
        private int                 _Serial;
        private Enums.NzFactorKind  _Kind;
        //private Task _task;
        #endregion
        public Form_Transfer(long ID = 0, Enums.NzFactorKind Kind = Enums.NzFactorKind.HavaleZayeat)
        {
            InitializeComponent();
            _Kind       = Kind;
            _ID         = ID;
            _Manager    = new FactorManager();
        }
        #region Methods
        private void ValidationDemo()
        {
            if(!SystemConstant.IsDemo)
                return;
            var mgr = new ReportManager();
            var count = mgr.GetItem<FactorItemsCount>(new{},null);
            if (count.ItemsCount >= SystemConstant.DemoCount)
            {
                MS_Message.Show("نسخه برنامه شما آزمایشی می باشد لطفا آن را ارتقا دهید", "خطا", MessageBoxButtons.OK);
                NzSave.Enabled = false;
            }
        }
        private void Init                           ()
        {
            nzObjectPopup1.RefreshControl   (new Size(550, 170));
            nzObjectPopup1.NzSelectObject   += NzObjectPopup1OnNzSelectObject;
            nzObjectPopup1.NzEscapedPress   += NzObjectPopup1OnNzEscapedPress;
            NzGrid.FilterMode               = FilterMode.None;

            if(_ID==0)
                Reset();
            else 
                LoadItem();

            ChangeUIForm();
            _Bind                           = new BidingFactorItems(_Factor);
            NzGrid.DataSource               = _Bind;
            ValidationDemo();
        }
        private void ChangeUIForm                   ()
        {
            Text = _Kind.NzToString();
        }
        private void LoadItem                           ()
        {
            try
            {
                _Factor     = _Manager.GetItem(_ID);
                if (_Factor == null)
                {
                    MS_Message.Show("فاکتور مورد نظر یافت نشد");
                    Reset();
                }

                NzSerial.MS_Decimal     = _Factor.Serial;
                NzDate.MS_Tarikh        = new MS_Structure_Shamsi(_Factor.tarikh);
                NzDescription.Text      = _Factor.sharh;
                _Kind                   = (Enums.NzFactorKind) _Factor.kind;
                _Bind                   = new BidingFactorItems(_Factor);
                NzGrid.DataSource       = _Bind;

                ChangeUIForm        ();
            }
            catch (Exception ex)
            {
                MS_Message.Show(ex.Message);
            }
        }
        private void Save                           ()
        {
            if (_Factor.ID == 0)
            {
                _Factor.FK_Salmali  = SystemConstant.ActiveYear.Salmali;
                _Factor.FK_User_Add = SystemConstant.ActiveUser.ID;
                _Factor.tarikh_add  = DateTime.Now;
                _Factor.kind        = (byte)_Kind;
            }
            else if (_IsEdit)
            {
                 _Factor.FactorDetail = _Factor.FactorDetail ?? new FactorDetail()
                {
                    FactorHead  = _Factor,
                    State       = Enums.NzItemState.AddedNew,
                };

                var Detail          = _Factor.FactorDetail;
                Detail.FK_User_Edit = SystemConstant.ActiveUser.ID;
                Detail.tarikh_edit  = DateTime.Now;
            }

            _Factor.Serial          = Convert.ToInt32( NzSerial.MS_Decimal);
            _Factor.tarikh          = NzDate.MS_Tarikh.Value.ToDatetime().Date;
            _Factor.sharh           = string.IsNullOrEmpty(NzDescription.Text.Trim()) 
                                        ? null 
                                        : NzDescription.Text.Trim();

            try
            {
                _Manager.Save(_Factor);
                new Form_Notify("ذخـیـره سـازی", "اطـلاعـات بـا مـوفـقـیـت ثـبـت شـــد.",
                        Form_Notify.FarsiMessageBoxIcon.اضافه)
                    .Popup(Form_Notify.Direction_Show.Right_To_Left, 1000);
                NzSerial.MS_Decimal = _Factor.Serial;
                SetItemsNoChanges();
            }
            catch (Exception ex)
            {
                MS_Message.Show("خطا در برنامه", "",ex.Message,MessageBoxButtons.OK);
            }
        }
        private void Reset                          ()
        {
            _DoRefresh                  = false;
            _IsEdit                     = false;

            GetMaxSerial                ();

            _ID                         = 0;
            _Factor                     = new FactorHead();
            _Bind                       = new BidingFactorItems(_Factor);
            NzGrid.DataSource           = _Bind;
            NzDate.MS_Tarikh            = new MS_Structure_Shamsi(DateTime.Now);
            NzDescription.Text          = "";

            NzSerial.Focus();

            _DoRefresh                  = true;
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
                nzObjectPopup1.Show(NzGrid, new Point(rec.X + rec.Width + rec.Width/2, rec.Y + rec.Height), ToolStripDropDownDirection.BelowLeft);
                SendKeys.Send("{TAB}");
            }
        }
        private void RemoveUnSavedRow               ()
        {
            try
            {
                _Factor
                        .FactorItems
                        .Where(x => x.ID == 0 && x.meqdar == 0)
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
        private void GetMaxSerial                   ()
        {
            //Task.Run(() =>
            //{
                _Serial = _Manager.GetMaxSerial(new
                {
                    Kind = (byte)_Kind,
                    Year = SystemConstant.ActiveYear.Salmali
                })+1;

                if (NzSerial.InvokeRequired)
                    NzSerial.Invoke(new MethodInvoker(delegate
                    {
                        NzSerial.MS_Decimal = _Serial;
                    }));
                else 
                    NzSerial.MS_Decimal = _Serial;
            //});
        }
        private bool IsOK                           ()
        {
            if (SystemConstant.ActiveYear.is_close)
            {
                MS_Message.Show("سال مالی بسته شده است " +
                                "\n  نمی توانید ادامه دهید ");
                return false;
            }
            if (NzSerial.MS_Decimal == 0)
            {
                NzSerial.Focus();
                mS_Notify1.Show(NzSerial);
                return false;
            }
            if (!NzDate.MS_Tarikh.HasValue)
            {
                NzDate.Focus();
                mS_Notify1.Show(NzDate);
                return false;
            }
            var date = NzDate.MS_Tarikh.Value.ToDatetime().Date;
            var salmali = SystemConstant.ActiveYear;
            if (date > salmali.EndDate || date < salmali.StartDate)
            {
                MS_Message.Show("تاریخ حواله در محدوده سال مالی نیست" +
                                "\n\n" +
                                "از تاریخ " + new MS_Structure_Shamsi(salmali.StartDate).ToShamsi() +
                                " تا تاریخ " + new MS_Structure_Shamsi(salmali.StartDate).ToShamsi());
                NzDate.Focus();
                mS_Notify1.Show(NzDate);
                return false;
            }
            if (!_Factor.FactorItems.Any())
            {
                MS_Message.Show("یک یا چند قلم کالا را وارد کنید.");
                NzGrid.Focus();
                mS_Notify1.Show(NzGrid);
                return false;
            }
            if ((_Factor.ID == 0 && _Serial != NzSerial.MS_Decimal)
                || (_Factor.ID > 0 && _Factor.Serial != NzSerial.MS_Decimal))
            {
                var r       = _Manager.IsCodeUnique(new
                {
                    Year    = SystemConstant.ActiveYear.Salmali,
                    Kind    = (byte) _Kind,
                    Serial  = NzSerial.MS_Decimal,
                });

                if (!r)
                {
                    MS_Message.Show     ("شماره سریال تکراری است");
                    NzSerial.Focus      ();
                    mS_Notify1.Show     (NzSerial);
                    return false;
                }
            }

            return true;
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
            if (NzGrid.EditMode == EditMode.EditOn 
                && NzGrid.EditTextBox != null 
                && (NzGrid.CurrentRow.RowType==RowType.NewRecord 
                    || NzGrid.CurrentRow.RowType == RowType.Record))
            {
                NzGrid.EditTextBox.KeyPress         += EditTextBoxOnKeyPress;
                NzGrid.EditTextBox.TextChanged      += EditTextBoxOnTextChanged;
            }
        }
        private void ms_grid_RowDoubleClick         (object sender, RowActionEventArgs e)
        {
            if (!(e.Row.RowType == RowType.Record || e.Row.RowType == RowType.NewRecord))
                return;
            ShowMenu();
        }
        private void ms_grid_CurrentCellChanged     (object sender, EventArgs e)
        {
            if (NzGrid.CurrentRow.RowType == RowType.NewRecord)
                ShowMenu();
        }
        private void ms_grid_UpdatingRecord         (object sender, CancelEventArgs e)
        {
            try
            {
                if (NzGrid.CurrentRow == null)
                    return;

                var key = NzGrid.CurrentRow.DataRow as FactorItem;

                if (key?.meqdar == 0 || key?.FK_Kala == 0)
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

                if (key?.meqdar == 0 || key?.FK_Kala == 0)
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
                var row = NzGrid.CurrentRow.DataRow as FactorItem;
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
            var row = NzGrid.CurrentRow.DataRow as FactorItem;
            if (row?.ID > 0)
                row.State = Enums.NzItemState.Modified;
        }
        private void NzGrid_CancelingRowEdit        (object sender, RowActionCancelEventArgs e)
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
        private void NzGrid_UpdatingCell            (object sender, UpdatingCellEventArgs e)
        {
            try
            {
                if (NzGrid.CurrentRow == null || e.Column.DataMember!="meqdar")
                    return;

                var key = NzGrid.CurrentRow.DataRow as FactorItem;

                if ((byte)_Kind >= 50)
                {
                    var objectItem      = nzObjectPopup1.GetAvailObject(key?.FK_Kala ?? 0);
                    var Value           = Convert.ToDecimal(e.Value);
                    var InitialValue    = Convert.ToDecimal(e.InitialValue);

                    if (
                        //   objectItem.kind == (byte) Enums.NzObjectKind.Object
                        //&& 
                        objectItem?.remaind < Value
                        && Value != InitialValue 
                    )
                    {
                        var result = MS_Message.Show(
                            "موجودی کالا از مقداری که وارد کرده اید کمـتر است" +
                            "\n آیا مایلید ردیف مورد نظر ثبت شود",
                            "هشدار",
                            MessageBoxButtons.YesNo,
                            MSMessage.FarsiMessageBoxIcon.اخطار
                        );

                        if (result == DialogResult.No)
                        {
                            e.Cancel = true;
                            e.Value = e.InitialValue;
                            //NzGrid.Refresh();
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                log.Error(ex);
            }
        }
        private void NzGrid_CellEdited              (object sender, ColumnActionEventArgs e)
        {
            try
            {
                if (NzGrid.CurrentRow == null || e.Column.DataMember != "meqdar")
                    return;

                var key = NzGrid.CurrentRow.DataRow as FactorItem;

                if (key?.meqdar <= 0)
                {
                    NzGrid.Refresh();
                    NzGrid.CurrentColumn = e.Column;
                    //NzGrid.CurrentColumn = NzGrid.CurrentRow.Cells["meqdar"].Column;

                    MS_Message.Show("مقدار را وارد کنید. مقدار نباید صفر [ 0 ] باشد");
                    
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
            if (!(char.IsDigit(key) || key == '\b' || key == '.' || key == '+' || key == '-'))
                e.Handled = true;
            else if (key == '.' && NzGrid.EditTextBox.Text.Contains("."))
                e.Handled = true;
            else if (key == '+')
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

            if(NzGrid.EditTextBox ==null)
                return;

            var TextBox     = NzGrid.EditTextBox;
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
            //var col = NzGrid.CurrentColumn.Key;
            //     if (col == "meqdar")
            //    RefreshCount();
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
            if (keyEventArgs.KeyCode == Keys.Add)
            {
                NzGrid.EditTextBox.Text += @"000";
                //e.Handled = true;
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
            var text = NzGrid.EditTextBox.Text.Trim();
            var Str = string.IsNullOrEmpty(text)
                            ? "0"
                            : text;

            if (decimal.TryParse(Str,
                                        sty, 
                                        CultureInfo.CurrentCulture,
                                        out decimal num))
            {
                var r           = NzGrid.CurrentRow.DataRow as FactorItem;

                var sum         = num * r.nerkh;
                var takhfif     = r.takhfif_darsad > 0
                                    ? Math.Round(r.takhfif_darsad / 100 * sum)
                                    : r.takhfif;
                RefreshCurrency(sum,takhfif);
            }
        }
        private void RefreshCurrency                (decimal Sum , decimal Off)
        {
            var cellSum     = NzGrid.CurrentRow.Cells["mablaq"];
            var cellOff     = NzGrid.CurrentRow.Cells["takhfif"];

            cellOff.Text    = (Off).ToString(cellOff.Column.FormatString);
            cellOff.Value   =  Off;

            cellSum.Text    = (Sum - Off).ToString(cellSum.Column.FormatString);
            cellSum.Value   =  Sum - Off;

        }
        #endregion
        //====================================
        private void NzObjectPopup1OnNzSelectObject     (object sender, EventArgs eventArgs)
        {
            if (nzObjectPopup1.NzSelected == null || NzGrid.CurrentRow == null)
                return;

            var obj                             = nzObjectPopup1.NzSelected;
            var Current                         = NzGrid.CurrentRow;

            Current?.BeginEdit();

            Current.Cells["ObjectTitle"].Value  = obj.title;
            Current.Cells["FK_Kala"].Value      = obj.Code;
            Current.Cells["UnitTitle"].Value    = obj.UnitTitle;

            if (    _Kind == Enums.NzFactorKind.Frosh 
                    ||  _Kind == Enums.NzFactorKind.BargshtFrosh
                    ||  _Kind == Enums.NzFactorKind.PishFaktor )

                Current.Cells["nerkh"].Value = obj.nerkh_frosh;

            NzGrid.CurrentColumn               = NzGrid.RootTable.Columns["meqdar"];

        }
        private void NzObjectPopup1OnNzEscapedPress     (object sender, EventArgs eventArgs)
        {
            if (NzGrid.CurrentRow == null)
            {
                NzGrid.CancelCurrentEdit();
                NzGrid.CurrentRow.CancelEdit();
            }

            if (!(NzGrid.CurrentRow.DataRow is FactorItem row))
                return;

            if (row.FK_Kala != 0 && (row.meqdar > 0 || row.nerkh > 0 || row.mablaq > 0))
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
                case Keys.F7:
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
           if(_Factor.ID==0)
                return;

            new PrintTransfers(new List<long>() {_Factor.ID}, _Kind)
                .Show(this);
        }
        private void NzPrintNormalA4_Click              (object sender, EventArgs e)
        {
            var prn = new Print.Print(_Manager, _Factor.ID, Enums.NzKindPrint.PaperA4);
            prn.Show(this);
        }
        private void NzPrintNormalA5_Click              (object sender, EventArgs e)
        {
            var prn = new Print.Print(_Manager, _Factor.ID, Enums.NzKindPrint.PaperA5);
            prn.Show(this);
        }

        private void NzSave_Click                       (object sender, EventArgs e)
        {
            RemoveUnSavedRow();

            if(IsOK())
                Save();
        }
        private void NzNew_Click                        (object sender, EventArgs e)
        {
            Reset();
        }

      
    }
}
