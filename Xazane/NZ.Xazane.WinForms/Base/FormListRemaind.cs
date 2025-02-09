using System;
using System.Collections.Generic;
using System.ComponentModel; 
using System.Drawing;
using System.Globalization;
using System.Linq; 
using System.Windows.Forms;
using Janus.Windows.GridEX;
using MS_Control;
using MS_Control.Controls;
using MS_Control.Tarikh; 
using NZ.Xazane.Business; 
using NZ.Xazane.Model.Models;
using NZ.Xazane.Model.ViewModel; 
using ShareLib;
using ShareLib.Interfaces; 
using ShareLib.Utils;

namespace NZ.Xazane.WinForms.Base
{
    public partial class FormListRemaind : Form,IForm_Editor
    {
        #region Logging
        private static readonly log4net.ILog log =
            log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion
        #region Fields

        private Manager                         _Manager;
        private BindingRemaindList              _Bind;
        private int                             _Pos            = 0;
        private int                             _Len            = 0;
        //private int                             _Serial         = 0;
        private List<RemaindList>               _List;
        private string                          _SimpleText     = "";
        private bool                            _DoRefresh      = true;
        private string                          _Dot            = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

        #endregion
        #region Constructor
        public FormListRemaind()
        {
            InitializeComponent();
            this.Icon   = global::MS_Resource.GlobalResources.Logo_Resaa;
            _Manager    = new Manager();
            LoadItem();
        }
        #endregion
        #region Methods
        private void    LoadItem                ()
        {
            try
            {
                var Mgr = new DpManager(_Manager.Connection);
                _List = Mgr.GetView<RemaindList>(new
                {
                    Year    = SystemConstant.ActiveYear.Salmali,
                    Kind1   = (byte) Enums.NzPaymentOperatingKind.RemaindDebit,
                    Kind2   = (byte) Enums.NzPaymentOperatingKind.RemaindCredit,

                }).ToList();
                _Bind               = new BindingRemaindList(_List);
                NzGrid.DataSource   = _Bind;
                var i = IsOk();

                if (!i)
                {
                    NzGrid.AllowEdit            = InheritableBoolean.False;
                    NzGrid.RootTable.AllowEdit  = InheritableBoolean.False;
                }
            }
            catch (Exception ex)
            {
                MS_Message.Show("سیستم قادر به خواندن اطلاعات نیست","خطا در خواندن اطلاعات"
                    ,ex.Message,MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private void    Save                ()
        {
            try
            {
                if (NzGrid.CurrentRow.DataRow is RemaindList row)
                {
                    var Item = new DPOperation()
                    {
                        ID              = row.ID_DP ?? 0,
                        FK_Salmali      = SystemConstant.ActiveYear.Salmali,
                        FK_ShaXs        = row.ID,
                        FK_User_Add     = row.ID_DP == null ? SystemConstant.ActiveUser.ID : (row.FK_User_Add ?? SystemConstant.ActiveUser.ID),
                        FK_User_Edit    = row.ID_DP == null ? null : (short?)SystemConstant.ActiveUser.ID,
                        kind            = row.kind??0,
                        sharh           = row.sharh,
                        takhfif         = row.takhfif,
                        tarikh          = new MS_Structure_Shamsi(SystemConstant.ActiveYear.Salmali, 1, 1).ToDatetime().Date,
                        tarikh_add      = row.ID_DP == null ? DateTime.Now : row.tarikh_add ?? DateTime.Now,
                        tarikh_edit     = row.ID_DP == null ? null : (DateTime?)DateTime.Now,
                    };

                    _Manager.Save   (Item);
                    _Bind.Update    (row,Item);

                    new Form_Notify("ذخـیـره سـازی", "اطـلاعـات بـا مـوفـقـیـت ثـبـت شـــد.",
                            Form_Notify.FarsiMessageBoxIcon.اضافه)
                        .Popup(Form_Notify.Direction_Show.Right_To_Left, 1000);
                }
            }
            catch (Exception ex )
            {
                MS_Message.Show("خطا در ذخیره اطلاعات","خطا",ex.Message,MessageBoxButtons.OK);
                LoadItem();
                log.Error(ex);
            }
        }
        private bool    IsOk                ()
        {
            if (SystemConstant.ActiveYear.is_close)
            {
                MS_Message.Show("سال مالی بسته شده است " +
                                "\n  نمی توانید ادامه دهید ");
                return false;
            }
            return true;
        }
        private void    ShowMenu            ()
        {
            if(NzGrid.CurrentRow==null || NzGrid.CurrentRow.RowType !=RowType.Record)
                return;

            if (NzGrid.CurrentColumn == null)
                return;

            var key = NzGrid.CurrentColumn.Key;
            if (key == "StateTitle")
            {
                var rec =
                    NzGrid.CurrentRow == null ?
                        NzGrid.Bounds
                        : NzGrid.GetCellBounds(NzGrid.CurrentRow.Position, NzGrid.RootTable.Columns["StateTitle"]);

               
                NzMenu.Show(NzGrid, new Point(rec.X + rec.Width, rec.Y + rec.Height), ToolStripDropDownDirection.BelowLeft);
                SendKeys.Send("{TAB}");
            }
        }
        private void    ChangeType          (Enums.NzPaymentOperatingKind Kind)
        {
            var Current = NzGrid.CurrentRow;

            if (Current == null)
                return;


            if(NzGrid.EditMode==EditMode.EditOff)
            
            //if (Current?.DataRow == null)
                Current.BeginEdit();

            if (Current?.DataRow is RemaindList row)
            {
                row.kind    = (byte)Kind;

                var cell = Current.Cells["StateTitle"];
                cell.Text = Kind == Enums.NzPaymentOperatingKind.RemaindDebit
                                ? "بدهکار"
                                : "بستانکار";

                cell.Value = Kind == Enums.NzPaymentOperatingKind.RemaindDebit
                    ? "بدهکار"
                    : "بستانکار";

                NzGrid.CurrentColumn = NzGrid.RootTable.Columns["sharh"];
                if (row.ID_DP != null)
                {
                    Save();
                    _Bind.ListChangedInvoke(ListChangedType.ItemChanged,Current.RowIndex);
                }
                NzMenu.Hide();
            }
        }
        #endregion
        #region Grid Recieve
        private void    NzGridRecieve_EditModeChanged      (object sender, EventArgs e)
        {
            var Grid    = sender as MS_GridX;
            var Row     = Grid.CurrentRow;
            var Col     = Grid.CurrentColumn;

            if (Grid.EditMode == EditMode.EditOn
                && Grid.EditTextBox != null
                && (Row.RowType == RowType.NewRecord || Row.RowType == RowType.Record)
                && Col != null
                && Col.Key == "takhfif"
            )

            {

                Grid.EditTextBox.KeyPress       += EditTextBoxOnKeyPress;
                Grid.EditTextBox.TextChanged    += EditTextBoxOnTextChanged;
            }
        }
        private void    NzGridRecieve_RowDoubleClick       (object sender, RowActionEventArgs e)
        {
            if (!(e.Row.RowType == RowType.Record || e.Row.RowType == RowType.NewRecord))
                return;

            var Grid = sender as MS_GridX;

            if (Grid.CurrentColumn != null 
                && Grid.CurrentColumn.Key == "StateTitle")
                ShowMenu();
        }
        private void    NzGridRecieve_CurrentCellChanged   (object sender, EventArgs e)
        {
            ShowMenu();
        }
        private void    NzGridRecieve_KeyPress             (object sender, KeyPressEventArgs e)
        {
            var Grid = sender as MS_GridX;

            if (Grid == null)
                return;
            
            if (char.IsLetterOrDigit(e.KeyChar) && Grid.CurrentRow != null)
            {
                var key     = Grid.CurrentColumn?.Key;
                var type    = Grid.CurrentRow?.RowType;

                if (    key == "StateTitle"
                        && (type == RowType.NewRecord || type == RowType.Record)
                   )
                    ShowMenu();
            }
            else if (e.KeyChar == (char)27)
            {
                e.Handled = true;
                Grid.CurrentRow?.CancelEdit();
                Grid.CancelCurrentEdit();
            }
        }
        private void    Grid_ColumnButtonClick             (object sender, ColumnActionEventArgs e)
        {
            if (!(sender is MS_GridX Grid))
                return;

            if (e.Column.Key == "D")
            {
                if (Grid.CurrentRow?.DataRow == null)
                    return;

                if (!(Grid.CurrentRow.DataRow is RemaindList row) || !(row.ID_DP > 0)) return;

                var result = MS_Message
                    .Show("آیا برای حذف ردیف مورد نظر مطمئنید؟",
                        "حذف ردیف",
                        MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                    return;

                var item = new DPOperation(){ID = row.ID_DP??0};
                _Manager.Delete(item);

                _Bind.Remove(row);
            }
            else if (e.Column.Key == "E")
            {
                Grid.CurrentColumn = Grid.RootTable.Columns["takhfif"];
                SendKeys.Send("{F2}");
            }

        }
        private void    NzGridRecieve_CellUpdated          (object sender, ColumnActionEventArgs e)
        {
            //var Grid = sender as MS_GridX;

            //if (Grid == null)
            //    return;

            //var row = Grid.CurrentRow.DataRow as ChequeOperation;
            //if (row?.ID > 0)
            //    row.State = Enums.NzItemState.Modified;
            
            
        }
        private void    NzGrid_RecordUpdated               (object sender, EventArgs e)
        {
            Save();
        }
        private void    NzGrid_UpdatingRecord              (object sender, CancelEventArgs e)
        {
            if (NzGrid.CurrentRow?.DataRow is RemaindList row)
            {
                if (row.kind == null)
                {
                    NzGrid.CancelCurrentEdit();
                    NzGrid.CurrentRow?.CancelEdit();
                    e.Cancel = true;
                }
            }
        }
        #endregion

        #region TetxBox Events
        private void    EditTextBoxOnKeyPress              (object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            var Grid = NzGrid;

            if (!(char.IsDigit(key) || key == '\b' || key == '.' || key == '+' || key == '-'))
                e.Handled = true;
            if (key == '.' && Grid.EditTextBox.Text.Contains("."))
                e.Handled = true;
            if (key == '+')
            {
                Grid.EditTextBox.Text += @"000";
                e.Handled = true;
            }
            else if (key == '-')
            {
                Grid.EditTextBox.Text += @"00";
                e.Handled = true;
            }
        }
        private void    EditTextBoxOnTextChanged           (object sender, EventArgs eventArgs)
        {
            if (!_DoRefresh)
                return;
            _DoRefresh = false;

            var Grid = NzGrid;

            var TextBox = Grid.EditTextBox;
            _SimpleText = TextBox.Text.Replace(",", string.Empty);

            var start = _SimpleText.Contains(_Dot)
                                ? _SimpleText.IndexOf(_Dot) - 3
                                : _SimpleText.Length - 3;

            for (int i = start; i > 0; i -= 3)
                _SimpleText = _SimpleText.Insert(i, ",");

            TextBox.Text = _SimpleText;
            Set_Cursor_Location();
            
            _DoRefresh = true;
        }

        private void    Set_Cursor_Location                ()
        {
            var Grid = NzGrid;

            int tm = Grid.EditTextBox.Text.Length - _Len;

            int x = _Pos + tm;
            x = x < 0 ? 0 : x;
            if (tm > 0)// طول زیاد شده باشد
            {
                Grid.EditTextBox.Select(_Pos + tm, 0);
            }
            else if (tm < 0) //  اگر طول کم شده باشد
            {
                var i = Math.Max(0, _Pos + tm);
                Grid.EditTextBox.Select(i, 0);
            }
            else // طول 
            {
                Grid.EditTextBox.Select(_Pos, 0);
            }
        }
        #endregion

        private void    NzDebit_Click                      (object sender, EventArgs e)
        {
            ChangeType(Enums.NzPaymentOperatingKind.RemaindDebit);
        }
        private void    NzCredit_Click                     (object sender, EventArgs e)
        {
            ChangeType(Enums.NzPaymentOperatingKind.RemaindCredit);
        }

        private void    mS_GridX_Setting1_MS_On_Print_Clicked   (object sender, EventArgs e)
        {
            mS_GridX_Setting1.FillParametter(this.Text);
        }
        public void     Set_Form_Param                          (params object[] List_Parametter)
        {
            throw new NotImplementedException();
        }

        private void NzGrid_EditingCell(object sender, EditingCellEventArgs e)
        {
            
        }
    }
}
