using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using MS_Control;
using MS_Control.TSDD;
using Nz.Anbar.Model.ViewModel;
using Nz.Anbar.WinForms.Base;
using NZ.Anbar.Business;
using NZ.Anbar.Model;
using Nz.Anbar.WinForms.Report;
using NZ.General.WinForms.Base;
using ShareLib.Models;
using ShareLib.Utils;

namespace Nz.Anbar.WinForms.Component
{
    public class NzObjectPopup : ToolStripDropDown
    {
        #region Fields
        private TableLayoutSettings     tableSettings   = null;
        private Size                    tileSize        = new Size(24, 24);
        private int                     _StripSize      = 25;
        public  ToolStripTextBox        NzFilterBox;
        private ToolStripControlHost    NzHost;
        private ToolStripButton         NzAdd, NzRefresh, NzSelect, NsPrice;
        private int                     NzWidth = 400;
        private MS_Control.Controls.MS_GridX NzGrid;
        private int                     NzHeight = 600;
        private AvailObject             _SelectObject;
        private ReportManager           _Manager;
        private List<AvailObject>       _List           = new List<AvailObject>();
        //====
        public event EventHandler       NzSelectObject,
                                        NzEscapedPress;

        private long                              _FactorMabnaId = 0;
        private IEnumerable<FactorIItemsId>       _FactorItemsIDList;
        #endregion
        #region Property
        public AvailObject NzSelected {
            get => _SelectObject;
            set => _SelectObject = value;
        }
        #endregion
        #region Constructor
        public          NzObjectPopup       ()
        {
            InitializeComponent();
            Capture                     = true;
            DoubleBuffered              = true;
            ResizeRedraw                = true;
            RightToLeft                 = RightToLeft.Yes;
            LayoutStyle                 = ToolStripLayoutStyle.Table;
            AutoClose                   = true;
            Padding                     = new Padding(0);
            Margin                      = new Padding(0);
            DropShadowEnabled           = false;
            NzGrid.FilterMode           = FilterMode.None;
            NzGrid.KeyPress             += NzGridOnKeyPress;
        }
        #endregion
        #region Methods
        private void AddControls            ()
        {
            AddTextBox          ();
            AddGrid             ();
            AddButtons          ();
            TableLayoutSetting  ();
        }
        private void AddTextBox             ()
        {   
            NzFilterBox         = new ToolStripTextBox()
            {
                Name            = "NzFilter",
                AcceptsReturn   = false,
                AcceptsTab      = true,
                Width           = NzWidth,
                Font            = new Font("IRANSans(Small)", 14F),
        };
            NzFilterBox.Size    = new Size(NzWidth,NzFilterBox.Height);
            NzFilterBox.TextChanged += NzFilterBoxOnTextChanged;
            NzFilterBox.KeyUp += (sender, e) =>
            {
                if (e.KeyCode == Keys.F12)
                {
                    int pos = 0;
                    foreach (InputLanguage a in InputLanguage.InstalledInputLanguages)
                    {
                        if (InputLanguage.CurrentInputLanguage.LayoutName == a.LayoutName)
                        {
                            try
                            {
                                InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages[pos + 1];
                            }
                            catch
                            {
                                InputLanguage.CurrentInputLanguage = InputLanguage.InstalledInputLanguages[0];
                            }

                            break;
                        }
                        pos++;
                    }
                }
            };
            Items.Add           (NzFilterBox);
        }

        private void AddGrid                ()
        {
            NzHost = new ToolStripControlHost(NzGrid)
            {
                Margin              = Padding.Empty,
                Padding             = Padding.Empty,
                AutoSize            = false,
                AutoToolTip         = false,
                DoubleClickEnabled  = true,
            };
            Items.Add(NzHost);
        }
        private void AddButtons             ()
        {
            NzAdd = new ToolStripButton()
            {
                DisplayStyle            = ToolStripItemDisplayStyle.Image,
                Image                   = global::MS_Resource.GlobalResources._ms_New,
                ImageTransparentColor   = Color.Magenta,
                Name                    = "NzAdd",
                Size                    = new Size(23, 22),
                Text                    = @"افزودن مورد جدید",
                ToolTipText             = @"افزودن مورد جدید",
                
            };

            NzRefresh = new ToolStripButton()
            {
                DisplayStyle            = ToolStripItemDisplayStyle.Image,
                Image                   = global::MS_Resource.GlobalResources.refresh,
                ImageTransparentColor   = Color.Magenta,
                Name                    = "NzRefresh",
                Size                    = new Size(23, 22),
                Text                    = @"بروزرسانی لیست",
                ToolTipText             = @"بروزرسانی لیست",
            };

            NzSelect = new ToolStripButton()
            {
                DisplayStyle            = ToolStripItemDisplayStyle.Image,
                Image                   = global::MS_Resource.GlobalResources._ms_Save,
                ImageTransparentColor   = Color.Magenta,
                Name                    = "NzSelect",
                Size                    = new Size(23, 22),
                Text                    = @"انتخاب ردیف",
                ToolTipText             = @"انتخاب ردیف",
            };

            NsPrice = new ToolStripButton()
            {
	            DisplayStyle            = ToolStripItemDisplayStyle.Image,
	            Image                   = global::MS_Resource.GlobalResources.chart_bar,
	            ImageTransparentColor   = Color.Magenta,
	            Name                    = "NsPrice",
	            Size                    = new Size(23, 22),
	            Text                    = @"نوسان قیمت",
	            ToolTipText             = @"نوسان قیمت",
            };

            Items.Add   (NzAdd);
            Items.Add   (NzRefresh);
            Items.Add   (NzSelect);
            Items.Add   (NsPrice);

            NzSelect.Click  += NzSelectOnClick;
            NzAdd.Click     +=NzAddOnClick;
            NzRefresh.Click +=NzRefreshOnClick;
            NsPrice.Click   +=NzPriceOnClick;

        }

        private void NzRefreshOnClick       (object sender, EventArgs eventArgs)
        {


            _List = _Manager
                        .GetReport<AvailObject>
                            (new {
                                    Year = SystemConstant.ActiveYear.Salmali
                                 },"")?
                        .OrderBy(x=>x.Code)
                        .ToList();

            
            RefreshGrid();
        }
        private void NzAddOnClick           (object sender, EventArgs eventArgs)
        {

            //var p = _DropMenu as Popup_ToolStrip;
            //p?.Close();
            //var frm = new Form_PeopleGroup(_Manager, null);
            //frm.ShowDialog(this.FindForm());
            //p?.Show();
            //RefreshControl();
            //var ID = Convert.ToInt32(frm.Tag);
            //var row = ms_grid
            //    .GetDataRows()
            //    .SingleOrDefault(x =>
            //        ((PeopleGroup)x.DataRow)?.ID == ID);
            //if (row != null)
            //{
            //    ms_grid.MoveTo(row);
            //    ms_grid.EnsureVisible(row.Position, ms_grid.RootTable.Columns[0]);
            //}
            //=========================================================================
            var p = this;
            p?.Close();
            var frm = new FormObjects(null);
            frm.ShowDialog(this.FindForm());
            p?.Show();
            NzRefreshOnClick(sender, eventArgs);
            var ID = Convert.ToInt32(frm.Tag);
            var row = NzGrid
                .GetDataRows()
                .SingleOrDefault(x =>
                    ((AvailObject)x.DataRow)?.ID == ID);
            if (row != null)
            {
                NzGrid.MoveTo(row);
                NzGrid.EnsureVisible(row.Position, NzGrid.RootTable.Columns[0]);
                NzSelect.PerformClick();
            }
        }
        private void NzSelectOnClick        (object sender, EventArgs eventArgs)
        {
            if(NzGrid.CurrentRow==null)
                return;

            _SelectObject   = NzGrid.CurrentRow.DataRow as AvailObject;

            NzSelectObject? .Invoke(sender, null);
            NzFilterBox.Text = "";
        }
        private void NzPriceOnClick           (object sender, EventArgs eventArgs)
        {
            var Currentrow = NzGrid.CurrentRow;
            if(Currentrow == null )
                return;
            var rowData = Currentrow.DataRow as AvailObject;

            if(rowData == null)
                return;


	        var p = this;
	        p?.Close();
	        var frm = new FormPriceChart(rowData.Code);
	        frm.ShowDialog(this.FindForm());
	        p?.Show();
        }

        private void TableLayoutSetting     ()
        {
            NzGrid?.SetBounds        (0, 0, NzWidth , NzHeight - _StripSize, BoundsSpecified.Size);
            NzGrid.Size              = new Size( NzWidth , NzHeight - _StripSize);
            NzHost.Size                     = new Size  (this.NzWidth, NzHeight - _StripSize);
            tableSettings                   = base.LayoutSettings as TableLayoutSettings;

            tableSettings.ColumnCount       = NzWidth / tileSize.Width;
            tableSettings.RowCount          = NzHeight / tileSize.Height;

            var  cellPos                    = new TableLayoutPanelCellPosition(0, 0);

            tableSettings.SetCellPosition   (NzFilterBox, cellPos);
            tableSettings.SetColumnSpan     (NzFilterBox, this.tableSettings.ColumnCount);
            tableSettings.SetRowSpan        (NzFilterBox, 1);


            cellPos                         = new TableLayoutPanelCellPosition(0, 1);

            tableSettings.SetCellPosition   (NzHost, cellPos);
            tableSettings.SetColumnSpan     (NzHost, this.tableSettings.ColumnCount);
            tableSettings.SetRowSpan        (NzHost, this.tableSettings.RowCount - 2);

            //================================================

            cellPos                         = new TableLayoutPanelCellPosition(2, this.tableSettings.RowCount - 1);
            tableSettings.SetCellPosition   (NzSelect, cellPos);

            cellPos                         = new TableLayoutPanelCellPosition(1, this.tableSettings.RowCount - 1);
            tableSettings.SetCellPosition   (NzAdd ,cellPos);

             cellPos                         = new TableLayoutPanelCellPosition(0, this.tableSettings.RowCount - 1);
            tableSettings.SetCellPosition   (NzRefresh ,cellPos);

        }
        public  void RefreshControl         (Size PopupSize)
        {
            NzWidth             = PopupSize.Width-2;
            NzHeight            = PopupSize.Height;

            AddControls();

            Task.Run(() =>
            {
                _Manager    = new ReportManager();
                _List = _Manager
                    .GetReport<AvailObject>
                    (new
                    {
                        Year = SystemConstant.ActiveYear.Salmali
                    }, "")?.ToList();
                RefreshGrid();
            });
        }

        public AvailObject  GetAvailObject  (long ObjectCode)
        {
            return _List.FirstOrDefault(x => x.Code == ObjectCode);
        }
        public void         FilterByFactor  (long IdFactor)
        {
            _FactorMabnaId      = IdFactor;
            _FactorItemsIDList  = _Manager
                                    .GetReport<FactorIItemsId>
                                        (new
                                        {
                                            ID = _FactorMabnaId
                                        }, "")?
                                    .ToList();

            RefreshGrid();
        }

        protected override bool     ProcessCmdKey   (ref Message m, Keys keyData)
        {
            if (   keyData == Keys.Down 
                || keyData == Keys.Up 
                || keyData == Keys.PageDown 
                || keyData == Keys.PageUp 
                || keyData == Keys.Enter 
                || keyData == Keys.Escape)
            {
                if (keyData != Keys.Escape)
                    Process_Key(keyData);
                else
                {
                    NzEscapedPress?.Invoke(this,null);
                    Hide();
                }
                return true;
            }

            return base.ProcessCmdKey(ref m, keyData);

        }
        private void                Process_Key     (Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Down:
                    MS_INPUT.SendMessage((int)NzGrid.Handle,
                        (int)MS_INPUT.WMessages.WM_KEYDOWN,
                        (int)MS_INPUT.VKeys.VK_DOWN, 0);

                    break;
                case Keys.Up:
                    MS_INPUT.SendMessage((int)NzGrid.Handle,
                        (int)MS_INPUT.WMessages.WM_KEYDOWN,
                        (int)MS_INPUT.VKeys.VK_UP, 0);
                    break;
                case Keys.PageUp:
                    MS_INPUT.SendMessage((int)NzGrid.Handle,
                        (int)MS_INPUT.WMessages.WM_KEYDOWN,
                        (int)MS_INPUT.VKeys.VK_PRIOR, 0);
                    break;
                case Keys.PageDown:
                    MS_INPUT.SendMessage((int)NzGrid.Handle,
                        (int)MS_INPUT.WMessages.WM_KEYDOWN,
                        (int)MS_INPUT.VKeys.VK_NEXT, 0);
                    break;
                case Keys.Enter:
                    NzSelect.PerformClick();
                    break;
            }
        }
        #endregion
        #region TextBox
        private void NzFilterBoxOnTextChanged       (object sender, EventArgs eventArgs)
        {
            var str = NzFilterBox.Text.Trim();
            if (string.IsNullOrEmpty(str))
            {
                RefreshGrid();
            }

            var list = _FactorMabnaId > 0 && _FactorItemsIDList.Any()

                ? (
                    from i in _List
                    join j in _FactorItemsIDList on i.Code equals j.Code
                    select i
                ).ToList()

                : _List;

            NzGrid.DataSource=
                list?
                .Where(x => 
                            (x.Code.ToString().Contains(str)|| x.title.Contains(str) || x.barcode.Contains(str))
                            &&
                            ! x.is_disabled )
                .OrderBy(x => x.Code)
                .ToList();
        }
        #endregion
        #region Grid
        private void RefreshGrid                    ()
        {
            var list = _FactorMabnaId > 0 && _FactorItemsIDList.Any()

                ? (
                    from i in _List
                    join j in _FactorItemsIDList on i.Code equals j.Code
                    select i
                ).ToList()

                : _List;



            if (NzGrid.InvokeRequired)
                NzGrid.Invoke(new MethodInvoker(delegate
                {
                    NzGrid.DataSource = list?.Where(x=>!x.is_disabled).ToList();
                }));
            else 
                NzGrid.DataSource = list?.Where(x=>!x.is_disabled).ToList();
        }
        private void NzGrid_RowDoubleClick          (object sender, RowActionEventArgs e)
        {
            NzSelect.PerformClick();
        }
        private void NzGrid_KeyPress                (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) 13)
                NzSelect.PerformClick();
        }
        private void NzGridOnKeyPress               (object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar))
            {
                NzFilterBox.Focus();
                SendKeys.Send(e.KeyChar.ToString());
            }
        }
        #endregion
        #region Designer
        private void InitializeComponent            ()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NzObjectPopup));
            Janus.Windows.GridEX.GridEXLayout NzGrid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.NzGrid = new MS_Control.Controls.MS_GridX();
            ((System.ComponentModel.ISupportInitialize)(this.NzGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // NzGrid
            // 
            this.NzGrid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.NzGrid.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.True;
            this.NzGrid.AlternatingColors = true;
            this.NzGrid.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NzGrid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NzGrid.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat;
            this.NzGrid.BuiltInTextsData = resources.GetString("NzGrid.BuiltInTextsData");
            this.NzGrid.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet;
            this.NzGrid.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NzGrid.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            NzGrid_DesignTimeLayout.LayoutString = resources.GetString("NzGrid_DesignTimeLayout.LayoutString");
            this.NzGrid.DesignTimeLayout = NzGrid_DesignTimeLayout;
            this.NzGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NzGrid.DynamicFiltering = true;
            this.NzGrid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.NzGrid.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.NzGrid.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.NzGrid.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzGrid.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.NzGrid.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle;
            this.NzGrid.FocusStyle = Janus.Windows.GridEX.FocusStyle.None;
            this.NzGrid.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
            this.NzGrid.GridLineColor = System.Drawing.Color.Black;
            this.NzGrid.GridLines = Janus.Windows.GridEX.GridLines.Vertical;
            this.NzGrid.GroupByBoxVisible = false;
            this.NzGrid.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.NzGrid.HeaderFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.NzGrid.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.NzGrid.Location = new System.Drawing.Point(0, 0);
            this.NzGrid.Name = "NzGrid";
            this.NzGrid.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
            this.NzGrid.Office2007CustomColor = System.Drawing.SystemColors.HotTrack;
            this.NzGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzGrid.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
            this.NzGrid.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.NzGrid.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.NzGrid.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.NzGrid.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelectionSameTable;
            this.NzGrid.SelectOnExpand = false;
            this.NzGrid.Size = new System.Drawing.Size(800, 400);
            this.NzGrid.TabIndex = 719;
            this.NzGrid.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzGrid.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.NzGrid.TreeLineColor = System.Drawing.Color.Black;
            this.NzGrid.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.NzGrid.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.NzGrid_RowDoubleClick);
            this.NzGrid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NzGrid_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.NzGrid)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

    }
}
