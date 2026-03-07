namespace Nz.Aqsat.Winforms.Report
{
    partial class FormSarResidAqsat
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
			Janus.Windows.GridEX.GridEXLayout NzGridFuture_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
			Janus.Windows.Common.Layouts.JanusLayoutReference NzGridFuture_Layout_0_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.ButtonImage");
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSarResidAqsat));
			Janus.Windows.Common.Layouts.JanusLayoutReference NzGridFuture_Layout_0_Reference_1 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.HeaderImage");
			Janus.Windows.Common.Layouts.JanusLayoutReference NzGridFuture_Layout_0_Reference_2 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column13.ButtonImage");
			Janus.Windows.GridEX.GridEXLayout NzGridItems_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
			Janus.Windows.Common.Layouts.JanusLayoutReference NzGridItems_Layout_0_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.ButtonImage");
			Janus.Windows.Common.Layouts.JanusLayoutReference NzGridItems_Layout_0_Reference_1 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.HeaderImage");
			Janus.Windows.Common.Layouts.JanusLayoutReference NzGridItems_Layout_0_Reference_2 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column7.ButtonImage");
			this.Tab_Control_Main = new Janus.Windows.UI.Tab.UITab();
			this.uiTabPage12 = new Janus.Windows.UI.Tab.UITabPage();
			this.NzGridFuture = new MS_Control.Controls.MS_GridX();
			this.Splitter1 = new DevComponents.DotNetBar.ExpandableSplitter();
			this.NzGridItems = new MS_Control.Controls.MS_GridX();
			this.uiTabPage14 = new Janus.Windows.UI.Tab.UITabPage();
			this.mS_GridX_Setting1 = new MS_Control.Controls.MS_GridX_Setting();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.NsRefresh = new System.Windows.Forms.ToolStripButton();
			this.NsDetail = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.NsMessage = new System.Windows.Forms.ToolStripButton();
			this.NsProgress = new System.Windows.Forms.ToolStripProgressBar();
			this.NsProgressText = new System.Windows.Forms.ToolStripLabel();
			this.NsCancel = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).BeginInit();
			this.Tab_Control_Main.SuspendLayout();
			this.uiTabPage12.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NzGridFuture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NzGridItems)).BeginInit();
			this.mS_GridX_Setting1.SuspendLayout();
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
			this.Tab_Control_Main.Size = new System.Drawing.Size(1102, 499);
			this.Tab_Control_Main.TabIndex = 6;
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
			this.uiTabPage12.Controls.Add(this.NzGridFuture);
			this.uiTabPage12.Controls.Add(this.Splitter1);
			this.uiTabPage12.Controls.Add(this.NzGridItems);
			this.uiTabPage12.Location = new System.Drawing.Point(1, 1);
			this.uiTabPage12.Name = "uiTabPage12";
			this.uiTabPage12.PanelFormatStyle.Alpha = 70;
			this.uiTabPage12.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
			this.uiTabPage12.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
			this.uiTabPage12.PanelFormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical;
			this.uiTabPage12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.uiTabPage12.Size = new System.Drawing.Size(1068, 497);
			this.uiTabPage12.TabStop = true;
			this.uiTabPage12.Text = "اطلاعات";
			// 
			// NzGridFuture
			// 
			this.NzGridFuture.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.NzGridFuture.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.True;
			this.NzGridFuture.AlternatingColors = true;
			this.NzGridFuture.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.NzGridFuture.BackColor = System.Drawing.Color.WhiteSmoke;
			this.NzGridFuture.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
			this.NzGridFuture.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet;
			this.NzGridFuture.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.NzGridFuture.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
			this.NzGridFuture.Dock = System.Windows.Forms.DockStyle.Fill;
			this.NzGridFuture.DynamicFiltering = true;
			this.NzGridFuture.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.NzGridFuture.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.NzGridFuture.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
			this.NzGridFuture.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzGridFuture.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
			this.NzGridFuture.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle;
			this.NzGridFuture.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid;
			this.NzGridFuture.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NzGridFuture.GridLineColor = System.Drawing.Color.Black;
			this.NzGridFuture.GridLines = Janus.Windows.GridEX.GridLines.Vertical;
			this.NzGridFuture.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
			this.NzGridFuture.GroupByBoxVisible = false;
			this.NzGridFuture.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.NzGridFuture.HeaderFormatStyle.ForeColor = System.Drawing.Color.Black;
			this.NzGridFuture.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
			NzGridFuture_Layout_0.IsCurrentLayout = true;
			NzGridFuture_Layout_0.Key = "Transfer";
			NzGridFuture_Layout_0_Reference_0.Instance = ((object)(resources.GetObject("NzGridFuture_Layout_0_Reference_0.Instance")));
			NzGridFuture_Layout_0_Reference_1.Instance = ((object)(resources.GetObject("NzGridFuture_Layout_0_Reference_1.Instance")));
			NzGridFuture_Layout_0_Reference_2.Instance = ((object)(resources.GetObject("NzGridFuture_Layout_0_Reference_2.Instance")));
			NzGridFuture_Layout_0.LayoutReferences.AddRange(new Janus.Windows.Common.Layouts.JanusLayoutReference[] {
            NzGridFuture_Layout_0_Reference_0,
            NzGridFuture_Layout_0_Reference_1,
            NzGridFuture_Layout_0_Reference_2});
			NzGridFuture_Layout_0.LayoutString = resources.GetString("NzGridFuture_Layout_0.LayoutString");
			this.NzGridFuture.Layouts.AddRange(new Janus.Windows.GridEX.GridEXLayout[] {
            NzGridFuture_Layout_0});
			this.NzGridFuture.Location = new System.Drawing.Point(0, 0);
			this.NzGridFuture.Name = "NzGridFuture";
			this.NzGridFuture.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
			this.NzGridFuture.Office2007CustomColor = System.Drawing.SystemColors.HotTrack;
			this.NzGridFuture.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NzGridFuture.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
			this.NzGridFuture.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.NzGridFuture.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black;
			this.NzGridFuture.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.NzGridFuture.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelectionSameTable;
			this.NzGridFuture.SelectOnExpand = false;
			this.NzGridFuture.Size = new System.Drawing.Size(1068, 269);
			this.NzGridFuture.TabIndex = 8;
			this.NzGridFuture.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
			this.NzGridFuture.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzGridFuture.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.NzGridFuture.TreeLineColor = System.Drawing.Color.Black;
			this.NzGridFuture.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			this.NzGridFuture.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.mS_GridX1_ColumnButtonClick);
			this.NzGridFuture.SelectionChanged += new System.EventHandler(this.NzGridFuture_SelectionChanged);
			// 
			// Splitter1
			// 
			this.Splitter1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(136)))), ((int)(((byte)(237)))));
			this.Splitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.Splitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.Splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Splitter1.ExpandActionClick = false;
			this.Splitter1.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(136)))), ((int)(((byte)(237)))));
			this.Splitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.Splitter1.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Splitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.Splitter1.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Splitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.Splitter1.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
			this.Splitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.Splitter1.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(96)))));
			this.Splitter1.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(139)))));
			this.Splitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
			this.Splitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
			this.Splitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(136)))), ((int)(((byte)(237)))));
			this.Splitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.Splitter1.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.Splitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.Splitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(136)))), ((int)(((byte)(237)))));
			this.Splitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.Splitter1.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
			this.Splitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.Splitter1.Location = new System.Drawing.Point(0, 269);
			this.Splitter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Splitter1.Name = "Splitter1";
			this.Splitter1.Size = new System.Drawing.Size(1068, 8);
			this.Splitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
			this.Splitter1.TabIndex = 751;
			this.Splitter1.TabStop = false;
			this.Splitter1.Visible = false;
			// 
			// NzGridItems
			// 
			this.NzGridItems.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.NzGridItems.AlternatingColors = true;
			this.NzGridItems.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.PowderBlue;
			this.NzGridItems.BackColor = System.Drawing.Color.WhiteSmoke;
			this.NzGridItems.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
			this.NzGridItems.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell;
			this.NzGridItems.CellToolTip = Janus.Windows.GridEX.CellToolTip.NoToolTip;
			this.NzGridItems.ColumnHeaders = Janus.Windows.GridEX.InheritableBoolean.False;
			this.NzGridItems.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.NzGridItems.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
			this.NzGridItems.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.NzGridItems.DynamicFiltering = true;
			this.NzGridItems.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell;
			this.NzGridItems.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
			this.NzGridItems.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzGridItems.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
			this.NzGridItems.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle;
			this.NzGridItems.FocusCellFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Flat;
			this.NzGridItems.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzGridItems.FocusCellFormatStyle.FontSize = 15F;
			this.NzGridItems.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid;
			this.NzGridItems.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NzGridItems.GridLineColor = System.Drawing.Color.Black;
			this.NzGridItems.GridLines = Janus.Windows.GridEX.GridLines.Vertical;
			this.NzGridItems.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
			this.NzGridItems.GroupByBoxVisible = false;
			this.NzGridItems.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.NzGridItems.HeaderFormatStyle.ForeColor = System.Drawing.Color.Black;
			this.NzGridItems.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
			NzGridItems_Layout_0.IsCurrentLayout = true;
			NzGridItems_Layout_0.Key = "Items";
			NzGridItems_Layout_0_Reference_0.Instance = ((object)(resources.GetObject("NzGridItems_Layout_0_Reference_0.Instance")));
			NzGridItems_Layout_0_Reference_1.Instance = ((object)(resources.GetObject("NzGridItems_Layout_0_Reference_1.Instance")));
			NzGridItems_Layout_0_Reference_2.Instance = ((object)(resources.GetObject("NzGridItems_Layout_0_Reference_2.Instance")));
			NzGridItems_Layout_0.LayoutReferences.AddRange(new Janus.Windows.Common.Layouts.JanusLayoutReference[] {
            NzGridItems_Layout_0_Reference_0,
            NzGridItems_Layout_0_Reference_1,
            NzGridItems_Layout_0_Reference_2});
			NzGridItems_Layout_0.LayoutString = resources.GetString("NzGridItems_Layout_0.LayoutString");
			this.NzGridItems.Layouts.AddRange(new Janus.Windows.GridEX.GridEXLayout[] {
            NzGridItems_Layout_0});
			this.NzGridItems.Location = new System.Drawing.Point(0, 277);
			this.NzGridItems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.NzGridItems.Name = "NzGridItems";
			this.NzGridItems.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
			this.NzGridItems.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
			this.NzGridItems.Office2007CustomColor = System.Drawing.SystemColors.HotTrack;
			this.NzGridItems.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NzGridItems.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
			this.NzGridItems.SelectedFormatStyle.BackColor = System.Drawing.Color.AntiqueWhite;
			this.NzGridItems.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black;
			this.NzGridItems.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.AntiqueWhite;
			this.NzGridItems.SelectOnExpand = false;
			this.NzGridItems.Size = new System.Drawing.Size(1068, 220);
			this.NzGridItems.TabIndex = 752;
			this.NzGridItems.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation;
			this.NzGridItems.TabStop = false;
			this.NzGridItems.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzGridItems.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.NzGridItems.TreeLineColor = System.Drawing.Color.Black;
			this.NzGridItems.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
			this.NzGridItems.Visible = false;
			this.NzGridItems.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			this.NzGridItems.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.NzGridItems_ColumnButtonClick);
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
			this.uiTabPage14.Size = new System.Drawing.Size(1068, 498);
			this.uiTabPage14.TabStop = true;
			this.uiTabPage14.Text = "پرسش و پاسخ";
			// 
			// mS_GridX_Setting1
			// 
			this.mS_GridX_Setting1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.mS_GridX_Setting1.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.mS_GridX_Setting1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.mS_GridX_Setting1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.NsRefresh,
            this.NsDetail,
            this.toolStripSeparator2,
            this.NsMessage,
            this.NsProgress,
            this.NsProgressText,
            this.NsCancel});
			this.mS_GridX_Setting1.Location = new System.Drawing.Point(0, 499);
			this.mS_GridX_Setting1.MS_BorderColor = System.Drawing.Color.DodgerBlue;
			this.mS_GridX_Setting1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.mS_GridX_Setting1.MS_Color_End = System.Drawing.Color.PowderBlue;
			this.mS_GridX_Setting1.MS_Color_Start = System.Drawing.Color.AliceBlue;
			this.mS_GridX_Setting1.MS_GridX = null;
			this.mS_GridX_Setting1.Name = "mS_GridX_Setting1";
			this.mS_GridX_Setting1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.mS_GridX_Setting1.Size = new System.Drawing.Size(1102, 26);
			this.mS_GridX_Setting1.TabIndex = 7;
			this.mS_GridX_Setting1.Text = "mS_GridX_Setting1";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 26);
			// 
			// NsRefresh
			// 
			this.NsRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.NsRefresh.Image = global::MS_Resource.GlobalResources.refresh;
			this.NsRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.NsRefresh.Name = "NsRefresh";
			this.NsRefresh.Size = new System.Drawing.Size(23, 23);
			this.NsRefresh.Text = "بروزرسانی لیست";
			this.NsRefresh.Click += new System.EventHandler(this.NsRefresh_Click);
			// 
			// NsDetail
			// 
			this.NsDetail.CheckOnClick = true;
			this.NsDetail.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.NsDetail.Image = global::MS_Resource.GlobalResources.application_view_detail;
			this.NsDetail.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.NsDetail.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
			this.NsDetail.Name = "NsDetail";
			this.NsDetail.Size = new System.Drawing.Size(23, 23);
			this.NsDetail.Text = "نمایش جزئیات";
			this.NsDetail.CheckedChanged += new System.EventHandler(this.NsDetail_CheckedChanged);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 26);
			// 
			// NsMessage
			// 
			this.NsMessage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.NsMessage.Image = ((System.Drawing.Image)(resources.GetObject("NsMessage.Image")));
			this.NsMessage.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.NsMessage.Name = "NsMessage";
			this.NsMessage.Size = new System.Drawing.Size(23, 23);
			this.NsMessage.Text = "ارسال پیامک برای ردیف های انتخابی";
			this.NsMessage.Click += new System.EventHandler(this.NsMessage_Click);
			// 
			// NsProgress
			// 
			this.NsProgress.AutoSize = false;
			this.NsProgress.BackColor = System.Drawing.Color.White;
			this.NsProgress.Margin = new System.Windows.Forms.Padding(5, 2, 10, 1);
			this.NsProgress.Name = "NsProgress";
			this.NsProgress.RightToLeftLayout = true;
			this.NsProgress.Size = new System.Drawing.Size(150, 16);
			this.NsProgress.Value = 20;
			this.NsProgress.Visible = false;
			// 
			// NsProgressText
			// 
			this.NsProgressText.Font = new System.Drawing.Font("IRANSans(Small)", 14F, System.Drawing.FontStyle.Bold);
			this.NsProgressText.ForeColor = System.Drawing.Color.Green;
			this.NsProgressText.Name = "NsProgressText";
			this.NsProgressText.Size = new System.Drawing.Size(41, 23);
			this.NsProgressText.Text = "1 / 23";
			this.NsProgressText.Visible = false;
			// 
			// NsCancel
			// 
			this.NsCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.NsCancel.Image = global::MS_Resource.GlobalResources._ms_Delete;
			this.NsCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.NsCancel.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
			this.NsCancel.Name = "NsCancel";
			this.NsCancel.Size = new System.Drawing.Size(23, 23);
			this.NsCancel.Text = "انصراف";
			this.NsCancel.Visible = false;
			this.NsCancel.Click += new System.EventHandler(this.NsCancel_Click);
			// 
			// FormSarResidAqsat
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1102, 525);
			this.Controls.Add(this.Tab_Control_Main);
			this.Controls.Add(this.mS_GridX_Setting1);
			this.Font = new System.Drawing.Font("IRANSans(Small)", 12F);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FormSarResidAqsat";
			this.Text = "گزارش سر رسید اقساط امروز";
			this.Load += new System.EventHandler(this.FormAqsatMoedGozashte_Load);
			((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).EndInit();
			this.Tab_Control_Main.ResumeLayout(false);
			this.uiTabPage12.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.NzGridFuture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NzGridItems)).EndInit();
			this.mS_GridX_Setting1.ResumeLayout(false);
			this.mS_GridX_Setting1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Janus.Windows.UI.Tab.UITab Tab_Control_Main;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage12;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage14;
        private MS_Control.Controls.MS_GridX_Setting mS_GridX_Setting1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton NsRefresh;
        private MS_Control.Controls.MS_GridX NzGridFuture;
		private System.Windows.Forms.ToolStripButton NsDetail;
		private DevComponents.DotNetBar.ExpandableSplitter Splitter1;
		private MS_Control.Controls.MS_GridX NzGridItems;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton NsMessage;
		private System.Windows.Forms.ToolStripProgressBar NsProgress;
		private System.Windows.Forms.ToolStripLabel NsProgressText;
		private System.Windows.Forms.ToolStripButton NsCancel;
	}
}