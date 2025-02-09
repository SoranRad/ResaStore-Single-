namespace NZ.Xazane.WinForms.Base
{
    partial class FormListRemaind
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListRemaind));
            Janus.Windows.GridEX.GridEXLayout NzGrid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_DesignTimeLayout_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.ButtonImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_DesignTimeLayout_Reference_1 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.HeaderImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_DesignTimeLayout_Reference_2 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.ButtonImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_DesignTimeLayout_Reference_3 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.HeaderImage");
            this.Tab_Control_Main = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage12 = new Janus.Windows.UI.Tab.UITabPage();
            this.NzGrid = new MS_Control.Controls.MS_GridX();
            this.uiTabPage14 = new Janus.Windows.UI.Tab.UITabPage();
            this.mS_GridX_Setting1 = new MS_Control.Controls.MS_GridX_Setting();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.NzMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NzDebit = new System.Windows.Forms.ToolStripMenuItem();
            this.NzCredit = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).BeginInit();
            this.Tab_Control_Main.SuspendLayout();
            this.uiTabPage12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NzGrid)).BeginInit();
            this.mS_GridX_Setting1.SuspendLayout();
            this.NzMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab_Control_Main
            // 
            this.Tab_Control_Main.BackColor = System.Drawing.Color.Transparent;
            this.Tab_Control_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab_Control_Main.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Tab_Control_Main.Location = new System.Drawing.Point(0, 0);
            this.Tab_Control_Main.MultiLine = true;
            this.Tab_Control_Main.Name = "Tab_Control_Main";
            this.Tab_Control_Main.Office2007CustomColor = System.Drawing.Color.Transparent;
            this.Tab_Control_Main.ShowFocusRectangle = false;
            this.Tab_Control_Main.Size = new System.Drawing.Size(956, 455);
            this.Tab_Control_Main.TabIndex = 723;
            this.Tab_Control_Main.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage12,
            this.uiTabPage14});
            this.Tab_Control_Main.TabsStateStyles.DisabledFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Tab_Control_Main.TabsStateStyles.DisabledFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Tab_Control_Main.TabsStateStyles.FormatStyle.BackColor = System.Drawing.Color.PowderBlue;
            this.Tab_Control_Main.TabsStateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.Gold;
            this.Tab_Control_Main.TabsStateStyles.SelectedFormatStyle.Font = new System.Drawing.Font("IRANSans(Small) Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Tab_Control_Main.TabsStateStyles.SelectedFormatStyle.FontSize = 14F;
            this.Tab_Control_Main.TabStripAlignment = Janus.Windows.UI.Tab.TabStripAlignment.Right;
            this.Tab_Control_Main.TextOrientation = Janus.Windows.UI.Tab.TextOrientation.Vertical;
            this.Tab_Control_Main.UseThemes = false;
            this.Tab_Control_Main.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
            // 
            // uiTabPage12
            // 
            this.uiTabPage12.Controls.Add(this.NzGrid);
            this.uiTabPage12.Location = new System.Drawing.Point(1, 1);
            this.uiTabPage12.Name = "uiTabPage12";
            this.uiTabPage12.PanelFormatStyle.Alpha = 70;
            this.uiTabPage12.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
            this.uiTabPage12.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
            this.uiTabPage12.PanelFormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical;
            this.uiTabPage12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiTabPage12.Size = new System.Drawing.Size(922, 453);
            this.uiTabPage12.TabStop = true;
            this.uiTabPage12.Text = "اطلاعات";
            // 
            // NzGrid
            // 
            this.NzGrid.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.True;
            this.NzGrid.AlternatingColors = true;
            this.NzGrid.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NzGrid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NzGrid.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
            this.NzGrid.BuiltInTextsData = resources.GetString("NzGrid.BuiltInTextsData");
            this.NzGrid.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell;
            this.NzGrid.ColumnAutoResize = true;
            this.NzGrid.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet;
            this.NzGrid.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NzGrid.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            NzGrid_DesignTimeLayout_Reference_0.Instance = ((object)(resources.GetObject("NzGrid_DesignTimeLayout_Reference_0.Instance")));
            NzGrid_DesignTimeLayout_Reference_1.Instance = ((object)(resources.GetObject("NzGrid_DesignTimeLayout_Reference_1.Instance")));
            NzGrid_DesignTimeLayout_Reference_2.Instance = ((object)(resources.GetObject("NzGrid_DesignTimeLayout_Reference_2.Instance")));
            NzGrid_DesignTimeLayout_Reference_3.Instance = ((object)(resources.GetObject("NzGrid_DesignTimeLayout_Reference_3.Instance")));
            NzGrid_DesignTimeLayout.LayoutReferences.AddRange(new Janus.Windows.Common.Layouts.JanusLayoutReference[] {
            NzGrid_DesignTimeLayout_Reference_0,
            NzGrid_DesignTimeLayout_Reference_1,
            NzGrid_DesignTimeLayout_Reference_2,
            NzGrid_DesignTimeLayout_Reference_3});
            NzGrid_DesignTimeLayout.LayoutString = resources.GetString("NzGrid_DesignTimeLayout.LayoutString");
            this.NzGrid.DesignTimeLayout = NzGrid_DesignTimeLayout;
            this.NzGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NzGrid.DynamicFiltering = true;
            this.NzGrid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell;
            this.NzGrid.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.NzGrid.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.NzGrid.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzGrid.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.NzGrid.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle;
            this.NzGrid.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid;
            this.NzGrid.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
            this.NzGrid.FrozenColumns = 2;
            this.NzGrid.GridLineColor = System.Drawing.Color.Black;
            this.NzGrid.GridLines = Janus.Windows.GridEX.GridLines.Vertical;
            this.NzGrid.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
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
            this.NzGrid.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.White;
            this.NzGrid.SelectOnExpand = false;
            this.NzGrid.Size = new System.Drawing.Size(922, 453);
            this.NzGrid.TabIndex = 719;
            this.NzGrid.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.NzGrid.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzGrid.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.NzGrid.TreeLineColor = System.Drawing.Color.Black;
            this.NzGrid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
            this.NzGrid.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.NzGrid.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.NzGridRecieve_RowDoubleClick);
            this.NzGrid.EditModeChanged += new System.EventHandler(this.NzGridRecieve_EditModeChanged);
            this.NzGrid.EditingCell += new Janus.Windows.GridEX.EditingCellEventHandler(this.NzGrid_EditingCell);
            this.NzGrid.CellUpdated += new Janus.Windows.GridEX.ColumnActionEventHandler(this.NzGridRecieve_CellUpdated);
            this.NzGrid.RecordUpdated += new System.EventHandler(this.NzGrid_RecordUpdated);
            this.NzGrid.UpdatingRecord += new System.ComponentModel.CancelEventHandler(this.NzGrid_UpdatingRecord);
            this.NzGrid.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.Grid_ColumnButtonClick);
            this.NzGrid.CurrentCellChanged += new System.EventHandler(this.NzGridRecieve_CurrentCellChanged);
            this.NzGrid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NzGridRecieve_KeyPress);
            // 
            // uiTabPage14
            // 
            this.uiTabPage14.AutoScroll = true;
            this.uiTabPage14.Location = new System.Drawing.Point(1, 1);
            this.uiTabPage14.Name = "uiTabPage14";
            this.uiTabPage14.PanelFormatStyle.Alpha = 70;
            this.uiTabPage14.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
            this.uiTabPage14.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
            this.uiTabPage14.PanelFormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical;
            this.uiTabPage14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiTabPage14.Size = new System.Drawing.Size(922, 453);
            this.uiTabPage14.TabStop = true;
            this.uiTabPage14.Text = "پرسش و پاسخ";
            // 
            // mS_GridX_Setting1
            // 
            this.mS_GridX_Setting1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mS_GridX_Setting1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mS_GridX_Setting1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1});
            this.mS_GridX_Setting1.Location = new System.Drawing.Point(0, 455);
            this.mS_GridX_Setting1.MS_BorderColor = System.Drawing.Color.DodgerBlue;
            this.mS_GridX_Setting1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_GridX_Setting1.MS_Color_End = System.Drawing.Color.PowderBlue;
            this.mS_GridX_Setting1.MS_Color_Start = System.Drawing.Color.AliceBlue;
            this.mS_GridX_Setting1.MS_GridX = this.NzGrid;
            this.mS_GridX_Setting1.Name = "mS_GridX_Setting1";
            this.mS_GridX_Setting1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mS_GridX_Setting1.Size = new System.Drawing.Size(956, 25);
            this.mS_GridX_Setting1.TabIndex = 722;
            this.mS_GridX_Setting1.Text = "mS_GridX_Setting1";
            this.mS_GridX_Setting1.MS_On_Print_Clicked += new System.EventHandler(this.mS_GridX_Setting1_MS_On_Print_Clicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // NzMenu
            // 
            this.NzMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NzDebit,
            this.NzCredit});
            this.NzMenu.Name = "NzMenu";
            this.NzMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzMenu.Size = new System.Drawing.Size(121, 60);
            // 
            // NzDebit
            // 
            this.NzDebit.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
            this.NzDebit.Image = ((System.Drawing.Image)(resources.GetObject("NzDebit.Image")));
            this.NzDebit.Name = "NzDebit";
            this.NzDebit.Size = new System.Drawing.Size(120, 28);
            this.NzDebit.Text = "بـدهکار";
            this.NzDebit.Click += new System.EventHandler(this.NzDebit_Click);
            // 
            // NzCredit
            // 
            this.NzCredit.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
            this.NzCredit.Image = ((System.Drawing.Image)(resources.GetObject("NzCredit.Image")));
            this.NzCredit.Name = "NzCredit";
            this.NzCredit.Size = new System.Drawing.Size(120, 28);
            this.NzCredit.Text = "بستانکار";
            this.NzCredit.Click += new System.EventHandler(this.NzCredit_Click);
            // 
            // FormListRemaind
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(956, 480);
            this.Controls.Add(this.Tab_Control_Main);
            this.Controls.Add(this.mS_GridX_Setting1);
            this.Font = new System.Drawing.Font("IRANSans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormListRemaind";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "مانده حسـاب قبلی اشخاص";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).EndInit();
            this.Tab_Control_Main.ResumeLayout(false);
            this.uiTabPage12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NzGrid)).EndInit();
            this.mS_GridX_Setting1.ResumeLayout(false);
            this.mS_GridX_Setting1.PerformLayout();
            this.NzMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Janus.Windows.UI.Tab.UITab Tab_Control_Main;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage12;
        private MS_Control.Controls.MS_GridX NzGrid;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage14;
        private MS_Control.Controls.MS_GridX_Setting mS_GridX_Setting1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip NzMenu;
        private System.Windows.Forms.ToolStripMenuItem NzDebit;
        private System.Windows.Forms.ToolStripMenuItem NzCredit;
    }
}