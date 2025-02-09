using System;
using System.Collections.Generic; 
using System.Globalization;
using System.Linq; 
using System.Windows.Forms;
using Janus.Windows.GridEX;
using MS_Control;
using MS_Control.Controls; 
using Nz.Anbar.Model.ViewModel;
using NZ.Anbar.Business;
using NZ.Anbar.Model;
using ShareLib;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.Base
{
    public partial class FormPriceList : Form
    {
        #region Logging
        private static readonly log4net.ILog 
            log =
                log4net
                .LogManager
                .GetLogger
                (System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #endregion
        #region Fields
        private Manager                         _Manager;
        private BindingListPrice                _Bind;
        private int                             _Pos            = 0;
        private int                             _Len            = 0;
        private List<PriceList>                 _List;
        private string                          _SimpleText     = "";
        private bool                            _DoRefresh      = true;
        private string                          _Dot            = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
        private bool                            _Updated        = false;
        #endregion
        #region Constructor
        public FormPriceList()
        {
            InitializeComponent();
            _Manager = new Manager();
            LoadItem();
        }
        #endregion
        #region Methods
        private void    LoadItem            ()
        {
            try
            {
                var Mgr = new ReportManager(_Manager.Connection);
                _List = Mgr.GetReport<PriceList>(new
                {
                    Year    = SystemConstant.ActiveYear.Salmali,
                    Kind1   = (byte) Enums.NzFactorKind.AvalDore,
                    Kind2   = (byte) Enums.NzFactorKind.Frosh - 1,

                },null).ToList();

                _Bind                = new BindingListPrice(_List);
                ms_Grid.DataSource   = _Bind;
                var i = IsOk();

                if (!i)
                {
                    ms_Grid.AllowEdit            = InheritableBoolean.False;
                    ms_Grid.RootTable.AllowEdit  = InheritableBoolean.False;
                }
            }
            catch (Exception ex)
            {
                MS_Message.Show("سیستم قادر به خواندن اطلاعات نیست","خطا در خواندن اطلاعات", ex.Message,MessageBoxButtons.OK);
                log.Error(ex);
            }
        }
        private void    Save                ()
        {
            try
            {
                if (ms_Grid.CurrentRow.DataRow is PriceList row)
                {
                    var Item            = _Manager.GetItem<NzObject>(new {row.ID});
                    Item.nerkh_frosh    = row.nerkh_frosh;
                    Item.nerkh_frosh1   = row.nerkh_frosh1;     
                    Item.nerkh_frosh2   = row.nerkh_frosh2;     
                    Item.nerkh_frosh3   = row.nerkh_frosh3;     
                    _Manager.Save       (Item);
                    //_Bind.Update    (row,Item);

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
        #endregion
        #region Grid Recieve
        private void    NzGridRecieve_EditModeChanged      (object sender, EventArgs e)
        {
            var Grid    = sender as MS_GridX;
            var Row     = Grid.CurrentRow;
            var Col     = Grid.CurrentColumn;

            if (Grid.EditMode == EditMode.EditOn
                &&  Grid.EditTextBox != null
                && (Row.RowType == RowType.NewRecord || Row.RowType == RowType.Record)
                &&  Col != null
                && (Col.Key.StartsWith("nerkh_frosh"))
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

            ms_Grid.CurrentColumn = ms_Grid.RootTable.Columns["nerkh_frosh"];
        }
        private void    NzGridRecieve_KeyPress             (object sender, KeyPressEventArgs e)
        {
            var Grid = sender as MS_GridX;

            if (Grid == null)
                return;
            
            if (e.KeyChar == (char)27)
            {
                e.Handled = true;
                Grid.CurrentRow?.CancelEdit();
                Grid.CancelCurrentEdit();
            }
        }
        private void    NzGridRecieve_CellUpdated          (object sender, ColumnActionEventArgs e)
        {
            
            _Updated = true;
            Save();
        }
        private void    ms_Grid_RecordUpdated              (object sender, EventArgs e)
        {
            //_Updated = true;
            //Save();
            
            //Application.DoEvents();
            //var col = ms_Grid.RootTable.Columns["nerkh_frosh"];
            //ms_Grid.CurrentColumn = col;
            //if(ms_Grid.CurrentRow!=null)
            //    ms_Grid.EnsureVisible(ms_Grid.CurrentRow.Position,col);
        }
        private void    ms_Grid_CurrentCellChanged         (object sender, EventArgs e)
        {
            //if (ms_Grid.CurrentColumn?.Key == "S" && _Updated)
            //{
            //    var col = ms_Grid.RootTable.Columns["nerkh_frosh"];
            //    ms_Grid.CurrentColumn = col;
            //    _Updated = false;
            //}
        }
        #endregion
        #region TetxBox Events
        private void    EditTextBoxOnKeyPress              (object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            var Grid = ms_Grid;

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

            var Grid = ms_Grid;

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
            var Grid = ms_Grid;

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
        private void    NzChangePrice_Click                (object sender, EventArgs e)
        {
            List<PriceList> List = null;

            var checkrows = ms_Grid.GetCheckedRows();

            if (checkrows != null || checkrows.Any())
                List = checkrows.Select(x => x.DataRow as PriceList).ToList();
            else if( ms_Grid.CurrentRow?.DataRow is PriceList row)
                List = new List<PriceList>(){row};

            if (List == null) return;


            new FormPriceChange(List).ShowDialog(this);
            LoadItem();
        }
        private void    ms_Grid_SelectionChanged           (object sender, EventArgs e)
        {
            if (ms_Grid.CurrentColumn?.Key == "S" && _Updated)
            {
                var col = ms_Grid.RootTable.Columns["nerkh_frosh"];
                ms_Grid.CurrentColumn = col;
                _Updated = false;
            }
        }
    }
}
