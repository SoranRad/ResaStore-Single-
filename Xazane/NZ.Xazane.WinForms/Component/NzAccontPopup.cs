using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using MS_Control;
using NZ.Xazane.Business;
using NZ.Xazane.Model;
using NZ.Xazane.WinForms.Base;
using ShareLib;
using ShareLib.Models;
using BorderStyle = Janus.Windows.GridEX.BorderStyle;

namespace NZ.Xazane.WinForms.Component
{
    public partial class NzAccontPopup : ToolStripDropDown
    {
        #region Fields
        private TableLayoutSettings     tableSettings   = null;
        //private int                     rows            = 5;
        //private int                     columns         = 5;
        private Size                    tileSize        = new Size(24, 24);
        private int                     _StripSize      = 25;
        //====
        public ToolStripTextBox         NzFilterBox;
        private ToolStripControlHost    NzHost;
        private ToolStripButton         NzAdd, 
                                        NzRefresh, 
                                        NzSelect;
        private int                     NzWidth         = 250;
        private int                     NzHeight        = 150;
        //====
        private DbConnection            _Connection;
        private Accounts                _SelectObject;
        private Manager                 _Manager;
        private List<Accounts>          _List           = new List<Accounts>();
        private Enums.NzAccountKind     _Kind;

        //====
        public event EventHandler       NzSelectObject,
                                        NzEscapedPress;
        #endregion
        #region Property
        public Accounts                 NzSelected
        {
            get => _SelectObject;
            set => _SelectObject = value;
        }
        #endregion
        #region Constructor
        public NzAccontPopup            ()
        {
            InitializeComponent();
            Capture             = true;
            DoubleBuffered      = true;
            ResizeRedraw        = true;
            RightToLeft         = RightToLeft.Yes;
            LayoutStyle         = ToolStripLayoutStyle.Table;
            AutoClose           = true;
            Padding             = new Padding(0);
            Margin              = new Padding(0);
            DropShadowEnabled   = false;
            NzGrid.FilterMode   = FilterMode.None;
            NzGrid.KeyPress     += NzGridOnKeyPress;
        }
        #endregion
        #region Methods
        private void SetLayout          ()
        {
            switch (_Kind)
            {
                case Enums.NzAccountKind.Cache:
                    NzGrid.LoadLayout(NzGrid.Layouts["Cache"]);
                    break;
                case Enums.NzAccountKind.BankAccount:
                    NzGrid.LoadLayout(NzGrid.Layouts["BankAccount"]);
                    break;
                case Enums.NzAccountKind.Income:
                    NzGrid.LoadLayout(NzGrid.Layouts["Income"]);
                    break;
                case Enums.NzAccountKind.Cost:
                    NzGrid.LoadLayout(NzGrid.Layouts["Cost"]);
                    break;
                case Enums.NzAccountKind.Deficit:
                    NzGrid.LoadLayout(NzGrid.Layouts["Deficit"]);
                    break;
            }
        }
        private void AddControls        ()
        {
            AddTextBox();
            AddGrid();
            AddButtons();
            TableLayoutSetting();
        }
        private void AddTextBox         ()
        {
            NzFilterBox = new ToolStripTextBox()
            {
                Name = "NzFilter",

                AcceptsReturn = false,
                AcceptsTab = true,
                Width = NzWidth,
                Font = new Font("IRANSans(Small)", 12F),

                Margin = Padding.Empty,
                Padding = Padding.Empty,
            };
            NzFilterBox.Size = new Size(NzWidth, NzFilterBox.Height);
            NzFilterBox.TextChanged += NzFilterBoxOnTextChanged;
            Items.Add(NzFilterBox);
        }

        private void AddGrid            ()
        {
            NzHost = new ToolStripControlHost(NzGrid)
            {
                Margin = Padding.Empty,
                Padding = Padding.Empty,

                AutoSize = false,
                AutoToolTip = false,
                DoubleClickEnabled = true,
            };
            Items.Add(NzHost);
        }
        private void AddButtons         ()
        {
            NzAdd = new ToolStripButton()
            {
                DisplayStyle = ToolStripItemDisplayStyle.Image,
                Image = global::MS_Resource.GlobalResources._ms_New,
                ImageTransparentColor = Color.Magenta,
                Name = "NzAdd",
                Size = new Size(23, 22),
                Text = @"افزودن مورد جدید",
                ToolTipText = @"افزودن مورد جدید",

            };

            NzRefresh = new ToolStripButton()
            {
                DisplayStyle = ToolStripItemDisplayStyle.Image,
                Image = global::MS_Resource.GlobalResources.refresh,
                ImageTransparentColor = Color.Magenta,
                Name = "NzRefresh",
                Size = new Size(23, 22),
                Text = @"بروزرسانی لیست",
                ToolTipText = @"بروزرسانی لیست",
            };

            NzSelect = new ToolStripButton()
            {
                DisplayStyle = ToolStripItemDisplayStyle.Image,
                Image = global::MS_Resource.GlobalResources._ms_Save,
                ImageTransparentColor = Color.Magenta,
                Name = "NzSelect",
                Size = new Size(23, 22),
                Text = @"انتخاب ردیف",
                ToolTipText = @"انتخاب ردیف",
            };

            Items.Add(NzAdd);
            Items.Add(NzRefresh);
            Items.Add(NzSelect);

            NzSelect.Click += NzSelectOnClick;
            NzAdd.Click += NzAddOnClick;
            NzRefresh.Click += NzRefreshOnClick;
        }

        private void NzRefreshOnClick   (object sender, EventArgs eventArgs)
        {
            _List = _Manager.GetList<Accounts>(new { Kind = _Kind })?.ToList();
            RefreshGrid();
        }
        private void NzAddOnClick       (object sender, EventArgs eventArgs)
        {
            this.Hide();

            var frm = new FormBankAccount(null,null);
            frm.ShowDialog(this.FindForm());

            this.Show();

            var ID = Convert.ToInt64(frm.Tag);
            _List = _Manager.GetList<Accounts>(new { Kind = _Kind })?.ToList();
            RefreshGrid();
            var row = NzGrid
                .GetDataRows()
                .SingleOrDefault(x =>
                    ((Accounts)x.DataRow)?.ID == ID);

            if (row != null)
            {
                NzGrid.MoveTo(row);
                NzGrid.EnsureVisible(row.Position, NzGrid.RootTable.Columns[0]);
            }
        }
        private void NzSelectOnClick    (object sender, EventArgs eventArgs)
        {
            if (NzGrid.CurrentRow == null)
                return;
            _SelectObject = NzGrid.CurrentRow.DataRow as Accounts;
            NzSelectObject?.Invoke(sender, null);
            NzFilterBox.Text = "";
        }

        private void TableLayoutSetting ()
        {
            NzGrid?.SetBounds(0, 0, NzWidth, NzHeight - _StripSize, BoundsSpecified.Size);
            NzGrid.Size = new Size(NzWidth, NzHeight - _StripSize);
            NzHost.Size = new Size(this.NzWidth, NzHeight - _StripSize);
            tableSettings = base.LayoutSettings as TableLayoutSettings;

            tableSettings.ColumnCount = NzWidth / tileSize.Width;
            tableSettings.RowCount = NzHeight / tileSize.Height;

            var cellPos = new TableLayoutPanelCellPosition(0, 0);

            tableSettings.SetCellPosition(NzFilterBox, cellPos);
            tableSettings.SetColumnSpan(NzFilterBox, this.tableSettings.ColumnCount);
            tableSettings.SetRowSpan(NzFilterBox, 1);


            cellPos = new TableLayoutPanelCellPosition(0, 1);

            tableSettings.SetCellPosition(NzHost, cellPos);
            tableSettings.SetColumnSpan(NzHost, this.tableSettings.ColumnCount);
            tableSettings.SetRowSpan(NzHost, this.tableSettings.RowCount - 2);

            //================================================

            cellPos = new TableLayoutPanelCellPosition(2, this.tableSettings.RowCount - 1);
            tableSettings.SetCellPosition(NzSelect, cellPos);

            cellPos = new TableLayoutPanelCellPosition(1, this.tableSettings.RowCount - 1);
            tableSettings.SetCellPosition(NzAdd, cellPos);

            cellPos = new TableLayoutPanelCellPosition(0, this.tableSettings.RowCount - 1);
            tableSettings.SetCellPosition(NzRefresh, cellPos);

        }
        public void  RefreshControl     (Size PopupSize, DbConnection Connection,Enums.NzAccountKind Kind)
        {
            NzWidth     = PopupSize.Width - 2;
            NzHeight    = PopupSize.Height;
            _Connection = Connection;
            _Kind       = Kind;
           
            AddControls ();
            SetLayout   ();
            NzGrid
                .RootTable
                .ColumnHeaders = InheritableBoolean.False;
            Task.Run(() =>
            {
                _Manager    = new Manager(_Connection);
                _List       = _Manager.GetList<Accounts>(new { Kind = _Kind })?.ToList();
                RefreshGrid ();
            });
        }

        protected override bool ProcessCmdKey   (ref Message m, Keys keyData)
        {
            if (keyData == Keys.Down
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
                    NzEscapedPress?.Invoke(this, null);
                    Hide();
                }
                return true;
            }

            return base.ProcessCmdKey(ref m, keyData);

        }
        private void            Process_Key     (Keys keyData)
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
        private void NzFilterBoxOnTextChanged   (object sender, EventArgs eventArgs)
        {
            var str = NzFilterBox.Text.Trim();
            if (string.IsNullOrEmpty(str))
            {
                RefreshGrid();
            }
            NzGrid.DataSource =
                _List?
                .Where(x => x.title.Contains(str))
                .ToList();
        }
        #endregion
        #region Grid
        private void RefreshGrid                ()
        {
            if (NzGrid.InvokeRequired)
                NzGrid.Invoke(new MethodInvoker(delegate
                {
                    NzGrid.DataSource = _List?.Where(x => !x.is_disable)?.ToList();
                }));
            else
                NzGrid.DataSource = _List?.Where(x => !x.is_disable)?.ToList();
        }
        private void NzGrid_RowDoubleClick      (object sender, RowActionEventArgs e)
        {
            NzSelect.PerformClick();
        }
        private void NzGrid_KeyPress            (object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                NzSelect.PerformClick();
        }
        private void NzGridOnKeyPress           (object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar))
            {
                NzFilterBox.Focus();
                SendKeys.Send(e.KeyChar.ToString());
            }
        }
        #endregion

    }
}
