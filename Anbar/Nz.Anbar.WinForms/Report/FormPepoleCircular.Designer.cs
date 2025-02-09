namespace Nz.Anbar.WinForms.Report
{
    partial class FormPepoleCircular
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
            Janus.Windows.GridEX.GridEXLayout NzGrid_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_0_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.ButtonImage");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPepoleCircular));
            Janus.Windows.GridEX.GridEXLayout NzGridMisc_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGridMisc_Layout_0_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.ButtonImage");
            this.Tab_Control_Main = new Janus.Windows.UI.Tab.UITab();
            this.NzGrid = new MS_Control.Controls.MS_GridX();
            this.Splitter1 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.NzGridMisc = new MS_Control.Controls.MS_GridX();
            this.mS_Panel1 = new MS_Control.Controls.MS_Panel();
            this.NzPrint = new MS_Control.Controls.MS_Button_GridX();
            this.NzReport = new MS_Control.Controls.MS_Button_GridX();
            this.NzDateTo = new MS_Control.Tarikh.MS_Tarikh_TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NzDateFrom = new MS_Control.Tarikh.MS_Tarikh_TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mS_Notify1 = new MS_Control.Controls.MS_Notify();
            this.uiTabPage12 = new Janus.Windows.UI.Tab.UITabPage();
            this.uiTabPage14 = new Janus.Windows.UI.Tab.UITabPage();
            this.NzCustomerRemain = new NZ.General.WinForms.Component.NzRemainCustomer();
            this.NzCustomer = new NZ.General.WinForms.Component.NzPeople();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).BeginInit();
            this.Tab_Control_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NzGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NzGridMisc)).BeginInit();
            this.mS_Panel1.SuspendLayout();
            this.uiTabPage12.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab_Control_Main
            // 
            this.Tab_Control_Main.BackColor = System.Drawing.Color.Transparent;
            this.Tab_Control_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab_Control_Main.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Tab_Control_Main.Location = new System.Drawing.Point(0, 0);
            this.Tab_Control_Main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tab_Control_Main.MultiLine = true;
            this.Tab_Control_Main.Name = "Tab_Control_Main";
            this.Tab_Control_Main.Office2007CustomColor = System.Drawing.Color.Transparent;
            this.Tab_Control_Main.ShowFocusRectangle = false;
            this.Tab_Control_Main.Size = new System.Drawing.Size(861, 466);
            this.Tab_Control_Main.TabIndex = 5;
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
            // NzGrid
            // 
            this.NzGrid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.NzGrid.AlternatingColors = true;
            this.NzGrid.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.PowderBlue;
            this.NzGrid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NzGrid.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
            this.NzGrid.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell;
            this.NzGrid.CellToolTip = Janus.Windows.GridEX.CellToolTip.NoToolTip;
            this.NzGrid.ColumnAutoResize = true;
            this.NzGrid.ColumnHeaders = Janus.Windows.GridEX.InheritableBoolean.False;
            this.NzGrid.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet;
            this.NzGrid.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NzGrid.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            this.NzGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NzGrid.DynamicFiltering = true;
            this.NzGrid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell;
            this.NzGrid.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.NzGrid.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.NzGrid.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzGrid.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.NzGrid.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle;
            this.NzGrid.FocusCellFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Flat;
            this.NzGrid.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzGrid.FocusCellFormatStyle.FontSize = 15F;
            this.NzGrid.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid;
            this.NzGrid.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
            this.NzGrid.GridLineColor = System.Drawing.Color.Black;
            this.NzGrid.GridLines = Janus.Windows.GridEX.GridLines.Vertical;
            this.NzGrid.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.NzGrid.GroupByBoxVisible = false;
            this.NzGrid.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.NzGrid.HeaderFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.NzGrid.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            NzGrid_Layout_0.IsCurrentLayout = true;
            NzGrid_Layout_0.Key = "Items";
            NzGrid_Layout_0_Reference_0.Instance = ((object)(resources.GetObject("NzGrid_Layout_0_Reference_0.Instance")));
            NzGrid_Layout_0.LayoutReferences.AddRange(new Janus.Windows.Common.Layouts.JanusLayoutReference[] {
            NzGrid_Layout_0_Reference_0});
            NzGrid_Layout_0.LayoutString = resources.GetString("NzGrid_Layout_0.LayoutString");
            this.NzGrid.Layouts.AddRange(new Janus.Windows.GridEX.GridEXLayout[] {
            NzGrid_Layout_0});
            this.NzGrid.Location = new System.Drawing.Point(0, 74);
            this.NzGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NzGrid.Name = "NzGrid";
            this.NzGrid.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            this.NzGrid.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
            this.NzGrid.Office2007CustomColor = System.Drawing.SystemColors.HotTrack;
            this.NzGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzGrid.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
            this.NzGrid.SelectedFormatStyle.BackColor = System.Drawing.Color.AntiqueWhite;
            this.NzGrid.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.NzGrid.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.AntiqueWhite;
            this.NzGrid.SelectOnExpand = false;
            this.NzGrid.Size = new System.Drawing.Size(827, 219);
            this.NzGrid.TabIndex = 5;
            this.NzGrid.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation;
            this.NzGrid.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.NzGrid.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzGrid.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.NzGrid.TreeLineColor = System.Drawing.Color.Black;
            this.NzGrid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
            this.NzGrid.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.NzGrid.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.NzGrid_ColumnButtonClick);
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
            this.Splitter1.Location = new System.Drawing.Point(0, 293);
            this.Splitter1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Splitter1.Name = "Splitter1";
            this.Splitter1.Size = new System.Drawing.Size(827, 5);
            this.Splitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.Splitter1.TabIndex = 751;
            this.Splitter1.TabStop = false;
            // 
            // NzGridMisc
            // 
            this.NzGridMisc.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.NzGridMisc.AlternatingColors = true;
            this.NzGridMisc.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.PowderBlue;
            this.NzGridMisc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NzGridMisc.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
            this.NzGridMisc.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell;
            this.NzGridMisc.CellToolTip = Janus.Windows.GridEX.CellToolTip.NoToolTip;
            this.NzGridMisc.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet;
            this.NzGridMisc.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NzGridMisc.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            this.NzGridMisc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NzGridMisc.DynamicFiltering = true;
            this.NzGridMisc.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell;
            this.NzGridMisc.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.NzGridMisc.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzGridMisc.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.NzGridMisc.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle;
            this.NzGridMisc.FocusCellFormatStyle.Appearance = Janus.Windows.GridEX.Appearance.Flat;
            this.NzGridMisc.FocusCellFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzGridMisc.FocusCellFormatStyle.FontSize = 15F;
            this.NzGridMisc.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid;
            this.NzGridMisc.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
            this.NzGridMisc.GridLineColor = System.Drawing.Color.Black;
            this.NzGridMisc.GridLines = Janus.Windows.GridEX.GridLines.Vertical;
            this.NzGridMisc.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.NzGridMisc.GroupByBoxVisible = false;
            this.NzGridMisc.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.NzGridMisc.HeaderFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.NzGridMisc.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            NzGridMisc_Layout_0.IsCurrentLayout = true;
            NzGridMisc_Layout_0.Key = "Items";
            NzGridMisc_Layout_0_Reference_0.Instance = ((object)(resources.GetObject("NzGridMisc_Layout_0_Reference_0.Instance")));
            NzGridMisc_Layout_0.LayoutReferences.AddRange(new Janus.Windows.Common.Layouts.JanusLayoutReference[] {
            NzGridMisc_Layout_0_Reference_0});
            NzGridMisc_Layout_0.LayoutString = resources.GetString("NzGridMisc_Layout_0.LayoutString");
            this.NzGridMisc.Layouts.AddRange(new Janus.Windows.GridEX.GridEXLayout[] {
            NzGridMisc_Layout_0});
            this.NzGridMisc.Location = new System.Drawing.Point(0, 298);
            this.NzGridMisc.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.NzGridMisc.Name = "NzGridMisc";
            this.NzGridMisc.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            this.NzGridMisc.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
            this.NzGridMisc.Office2007CustomColor = System.Drawing.SystemColors.HotTrack;
            this.NzGridMisc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzGridMisc.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
            this.NzGridMisc.SelectedFormatStyle.BackColor = System.Drawing.Color.AntiqueWhite;
            this.NzGridMisc.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.NzGridMisc.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.AntiqueWhite;
            this.NzGridMisc.SelectOnExpand = false;
            this.NzGridMisc.Size = new System.Drawing.Size(827, 166);
            this.NzGridMisc.TabIndex = 750;
            this.NzGridMisc.TabKeyBehavior = Janus.Windows.GridEX.TabKeyBehavior.ControlNavigation;
            this.NzGridMisc.TableHeaders = Janus.Windows.GridEX.InheritableBoolean.True;
            this.NzGridMisc.TabStop = false;
            this.NzGridMisc.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.NzGridMisc.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzGridMisc.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.NzGridMisc.TreeLineColor = System.Drawing.Color.Black;
            this.NzGridMisc.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
            this.NzGridMisc.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.NzGridMisc.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.NzGridMisc_ColumnButtonClick);
            // 
            // mS_Panel1
            // 
            this.mS_Panel1.Controls.Add(this.NzCustomerRemain);
            this.mS_Panel1.Controls.Add(this.NzCustomer);
            this.mS_Panel1.Controls.Add(this.NzPrint);
            this.mS_Panel1.Controls.Add(this.NzReport);
            this.mS_Panel1.Controls.Add(this.NzDateTo);
            this.mS_Panel1.Controls.Add(this.label3);
            this.mS_Panel1.Controls.Add(this.label2);
            this.mS_Panel1.Controls.Add(this.label1);
            this.mS_Panel1.Controls.Add(this.NzDateFrom);
            this.mS_Panel1.Controls.Add(this.label8);
            this.mS_Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.mS_Panel1.Location = new System.Drawing.Point(0, 0);
            this.mS_Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mS_Panel1.MS_BorderColor = System.Drawing.Color.Aqua;
            this.mS_Panel1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_Panel1.MS_Color_End = System.Drawing.Color.SkyBlue;
            this.mS_Panel1.MS_Color_Start = System.Drawing.Color.AliceBlue;
            this.mS_Panel1.Name = "mS_Panel1";
            this.mS_Panel1.Size = new System.Drawing.Size(827, 74);
            this.mS_Panel1.TabIndex = 721;
            // 
            // NzPrint
            // 
            this.NzPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzPrint.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NzPrint.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NzPrint.Image = ((System.Drawing.Image)(resources.GetObject("NzPrint.Image")));
            this.NzPrint.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.NzPrint.Location = new System.Drawing.Point(112, 42);
            this.NzPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NzPrint.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzPrint.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzPrint.MS_Change_Border_Color_On_Enter = false;
            this.NzPrint.MS_Change_Color_On_Enter = false;
            this.NzPrint.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.NzPrint.MS_Enter_Color = System.Drawing.Color.Empty;
            this.NzPrint.Name = "NzPrint";
            this.NzPrint.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.NzPrint.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
            this.NzPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzPrint.ShowFocusRectangle = false;
            this.NzPrint.Size = new System.Drawing.Size(122, 30);
            this.NzPrint.TabIndex = 760;
            this.NzPrint.Text = "چـاپ";
            this.NzPrint.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.NzPrint.UseThemes = false;
            this.NzPrint.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.NzPrint.WordWrap = false;
            this.NzPrint.Click += new System.EventHandler(this.NzPrint_Click);
            // 
            // NzReport
            // 
            this.NzReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzReport.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NzReport.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NzReport.Image = ((System.Drawing.Image)(resources.GetObject("NzReport.Image")));
            this.NzReport.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.NzReport.Location = new System.Drawing.Point(112, 8);
            this.NzReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NzReport.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzReport.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzReport.MS_Change_Border_Color_On_Enter = false;
            this.NzReport.MS_Change_Color_On_Enter = false;
            this.NzReport.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.NzReport.MS_Enter_Color = System.Drawing.Color.Empty;
            this.NzReport.Name = "NzReport";
            this.NzReport.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.NzReport.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
            this.NzReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzReport.ShowFocusRectangle = false;
            this.NzReport.Size = new System.Drawing.Size(122, 30);
            this.NzReport.TabIndex = 760;
            this.NzReport.Text = "مشـاهده گزارش";
            this.NzReport.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.NzReport.UseThemes = false;
            this.NzReport.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.NzReport.WordWrap = false;
            this.NzReport.Click += new System.EventHandler(this.NzReport_Click);
            // 
            // NzDateTo
            // 
            this.NzDateTo.AllowInternalTab = false;
            this.NzDateTo.AllowResizeDropDown = false;
            this.NzDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzDateTo.AutoHeight = false;
            this.NzDateTo.BackColor = System.Drawing.Color.White;
            this.NzDateTo.ControlSize = new System.Drawing.Size(0, 0);
            this.NzDateTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NzDateTo.DropSize = new System.Drawing.Size(0, 0);
            this.NzDateTo.Font = new System.Drawing.Font("IRANSans(Small)", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NzDateTo.Location = new System.Drawing.Point(253, 40);
            this.NzDateTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NzDateTo.MinimumSize = new System.Drawing.Size(107, 29);
            this.NzDateTo.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzDateTo.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzDateTo.MS_Change_Border_Color_On_Enter = true;
            this.NzDateTo.MS_Change_Color_On_Enter = true;
            this.NzDateTo.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NzDateTo.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzDateTo.MS_Exit_By_Down = true;
            this.NzDateTo.MS_Exit_By_Enter = true;
            this.NzDateTo.MS_Exit_By_Up = true;
            this.NzDateTo.MS_Last_Control = null;
            this.NzDateTo.MS_Next_Control = null;
            this.NzDateTo.MS_Separation = '/';
            this.NzDateTo.MS_Tarikh = null;
            this.NzDateTo.Name = "NzDateTo";
            this.NzDateTo.ReadOnly = false;
            this.NzDateTo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NzDateTo.Size = new System.Drawing.Size(114, 29);
            this.NzDateTo.TabIndex = 759;
            this.NzDateTo.Text = "//";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(736, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 761;
            this.label3.Text = "وضعیت فعلی :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(736, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 23);
            this.label2.TabIndex = 761;
            this.label2.Text = "شخص :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(368, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 762;
            this.label1.Text = "تا تاریخ :";
            // 
            // NzDateFrom
            // 
            this.NzDateFrom.AllowInternalTab = false;
            this.NzDateFrom.AllowResizeDropDown = false;
            this.NzDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzDateFrom.AutoHeight = false;
            this.NzDateFrom.BackColor = System.Drawing.Color.White;
            this.NzDateFrom.ControlSize = new System.Drawing.Size(0, 0);
            this.NzDateFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NzDateFrom.DropSize = new System.Drawing.Size(0, 0);
            this.NzDateFrom.Font = new System.Drawing.Font("IRANSans(Small)", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NzDateFrom.Location = new System.Drawing.Point(253, 8);
            this.NzDateFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NzDateFrom.MinimumSize = new System.Drawing.Size(107, 29);
            this.NzDateFrom.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzDateFrom.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzDateFrom.MS_Change_Border_Color_On_Enter = true;
            this.NzDateFrom.MS_Change_Color_On_Enter = true;
            this.NzDateFrom.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NzDateFrom.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzDateFrom.MS_Exit_By_Down = true;
            this.NzDateFrom.MS_Exit_By_Enter = true;
            this.NzDateFrom.MS_Exit_By_Up = true;
            this.NzDateFrom.MS_Last_Control = null;
            this.NzDateFrom.MS_Next_Control = null;
            this.NzDateFrom.MS_Separation = '/';
            this.NzDateFrom.MS_Tarikh = null;
            this.NzDateFrom.Name = "NzDateFrom";
            this.NzDateFrom.ReadOnly = false;
            this.NzDateFrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NzDateFrom.Size = new System.Drawing.Size(114, 29);
            this.NzDateFrom.TabIndex = 758;
            this.NzDateFrom.Text = "//";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(368, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 23);
            this.label8.TabIndex = 763;
            this.label8.Text = "از تاریخ :";
            // 
            // uiTabPage12
            // 
            this.uiTabPage12.Controls.Add(this.NzGrid);
            this.uiTabPage12.Controls.Add(this.Splitter1);
            this.uiTabPage12.Controls.Add(this.NzGridMisc);
            this.uiTabPage12.Controls.Add(this.mS_Panel1);
            this.uiTabPage12.Location = new System.Drawing.Point(1, 1);
            this.uiTabPage12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiTabPage12.Name = "uiTabPage12";
            this.uiTabPage12.PanelFormatStyle.Alpha = 70;
            this.uiTabPage12.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
            this.uiTabPage12.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
            this.uiTabPage12.PanelFormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical;
            this.uiTabPage12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiTabPage12.Size = new System.Drawing.Size(827, 464);
            this.uiTabPage12.TabStop = true;
            this.uiTabPage12.Text = "اطلاعات";
            // 
            // uiTabPage14
            // 
            this.uiTabPage14.AutoScroll = true;
            this.uiTabPage14.Location = new System.Drawing.Point(1, 1);
            this.uiTabPage14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiTabPage14.Name = "uiTabPage14";
            this.uiTabPage14.PanelFormatStyle.Alpha = 70;
            this.uiTabPage14.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
            this.uiTabPage14.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
            this.uiTabPage14.PanelFormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical;
            this.uiTabPage14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiTabPage14.Size = new System.Drawing.Size(600, 277);
            this.uiTabPage14.TabStop = true;
            this.uiTabPage14.Text = "پرسش و پاسخ";
            // 
            // NzCustomerRemain
            // 
            this.NzCustomerRemain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzCustomerRemain.BackColor = System.Drawing.Color.White;
            this.NzCustomerRemain.Font = new System.Drawing.Font("IRANSans(Small)", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NzCustomerRemain.Location = new System.Drawing.Point(570, 40);
            this.NzCustomerRemain.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzCustomerRemain.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzCustomerRemain.MS_Color_End = System.Drawing.Color.Empty;
            this.NzCustomerRemain.MS_Color_Start = System.Drawing.Color.Empty;
            this.NzCustomerRemain.Name = "NzCustomerRemain";
            this.NzCustomerRemain.Size = new System.Drawing.Size(165, 28);
            this.NzCustomerRemain.TabIndex = 768;
            this.NzCustomerRemain.Text = "0";
            this.NzCustomerRemain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NzCustomer
            // 
            this.NzCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzCustomer.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
            this.NzCustomer.DropSize = new System.Drawing.Size(304, 31);
            this.NzCustomer.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
            this.NzCustomer.Location = new System.Drawing.Point(431, 6);
            this.NzCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NzCustomer.MS_Auto_Popup = false;
            this.NzCustomer.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzCustomer.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzCustomer.MS_CaptureFocus = false;
            this.NzCustomer.MS_Change_Border_Color_On_Enter = true;
            this.NzCustomer.MS_Change_Color_On_Enter = true;
            this.NzCustomer.MS_Drop_Direction = MS_Control.TSDD.KindShow.Right;
            this.NzCustomer.MS_DropDownSizeMode = MS_Control.TSDD.SizeMode.Control_Size;
            this.NzCustomer.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NzCustomer.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzCustomer.MS_Exit_By_Down = true;
            this.NzCustomer.MS_Exit_By_Enter = true;
            this.NzCustomer.MS_Exit_By_Up = true;
            this.NzCustomer.MS_Last_Control = null;
            this.NzCustomer.MS_Next_Control = null;
            this.NzCustomer.Name = "NzCustomer";
            this.NzCustomer.Office2007CustomColor = System.Drawing.Color.SkyBlue;
            this.NzCustomer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzCustomer.Size = new System.Drawing.Size(304, 31);
            this.NzCustomer.TabIndex = 764;
            this.NzCustomer.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.NzCustomer.MS_On_Row_Selected += new System.EventHandler<MS_Control.TSDD.On_Selected>(this.NzCustomer_MSOnRowSelected);
            // 
            // FormPepoleCircular
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(861, 466);
            this.Controls.Add(this.Tab_Control_Main);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPepoleCircular";
            this.Text = "گزارش ریز تراکنش شخص";
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).EndInit();
            this.Tab_Control_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NzGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NzGridMisc)).EndInit();
            this.mS_Panel1.ResumeLayout(false);
            this.mS_Panel1.PerformLayout();
            this.uiTabPage12.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.UI.Tab.UITab Tab_Control_Main;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage12;
        private MS_Control.Controls.MS_GridX NzGrid;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage14;
        private MS_Control.Controls.MS_Notify mS_Notify1;
        private MS_Control.Controls.MS_Panel mS_Panel1;
        private NZ.General.WinForms.Component.NzPeople NzCustomer;
        private MS_Control.Controls.MS_Button_GridX NzReport;
        private MS_Control.Tarikh.MS_Tarikh_TextBox NzDateTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MS_Control.Tarikh.MS_Tarikh_TextBox NzDateFrom;
        private System.Windows.Forms.Label label8;
        private MS_Control.Controls.MS_GridX NzGridMisc;
        private DevComponents.DotNetBar.ExpandableSplitter Splitter1;
        private MS_Control.Controls.MS_Button_GridX NzPrint;
        private NZ.General.WinForms.Component.NzRemainCustomer NzCustomerRemain;
        private System.Windows.Forms.Label label3;
    }
}