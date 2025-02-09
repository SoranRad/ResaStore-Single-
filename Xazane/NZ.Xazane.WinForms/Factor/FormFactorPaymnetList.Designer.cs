
namespace NZ.Xazane.WinForms.Factor
{
    partial class FormFactorPaymentList
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
            Janus.Windows.GridEX.GridEXLayout NzGridHeads_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGridHeads_Layout_0_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.ButtonImage");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFactorPaymentList));
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGridHeads_Layout_0_Reference_1 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.HeaderImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGridHeads_Layout_0_Reference_2 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.ButtonImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGridHeads_Layout_0_Reference_3 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.HeaderImage");
            Janus.Windows.GridEX.GridEXLayout NzGridItems_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
            this.NzGridHeads = new MS_Control.Controls.MS_GridX();
            this.Splitter1 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.NzTabInfo = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage3 = new Janus.Windows.UI.Tab.UITabPage();
            this.NzGridItems = new MS_Control.Controls.MS_GridX();
            this.NzTabPos = new Janus.Windows.UI.Tab.UITabPage();
            this.NzPosAmount = new MS_Control.Controls.MS_Decimal_Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NzPosDesc = new System.Windows.Forms.Label();
            this.NzPosIdentity = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NzPosTitle = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NzTabCache = new Janus.Windows.UI.Tab.UITabPage();
            this.NzCacheAmount = new MS_Control.Controls.MS_Decimal_Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.NzCacheDesc = new System.Windows.Forms.Label();
            this.NzCacheTitle = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.mS_GridX_Setting2 = new MS_Control.Controls.MS_GridX_Setting();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mS_Tool_Strip1 = new MS_Control.Controls.MS_Tool_Strip();
            this.NzPrint = new System.Windows.Forms.ToolStripSplitButton();
            this.NzPrintA4 = new System.Windows.Forms.ToolStripMenuItem();
            this.NzPrintA5 = new System.Windows.Forms.ToolStripMenuItem();
            this.NzItems = new System.Windows.Forms.ToolStripButton();
            this.NzRefreshList = new System.Windows.Forms.ToolStripButton();
            this.NzNewPayment = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.NzGridHeads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NzTabInfo)).BeginInit();
            this.NzTabInfo.SuspendLayout();
            this.uiTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NzGridItems)).BeginInit();
            this.NzTabPos.SuspendLayout();
            this.NzTabCache.SuspendLayout();
            this.mS_GridX_Setting2.SuspendLayout();
            this.mS_Tool_Strip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NzGridHeads
            // 
            this.NzGridHeads.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.NzGridHeads.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.True;
            this.NzGridHeads.AlternatingColors = true;
            this.NzGridHeads.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NzGridHeads.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NzGridHeads.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
            this.NzGridHeads.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet;
            this.NzGridHeads.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NzGridHeads.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            this.NzGridHeads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NzGridHeads.DynamicFiltering = true;
            this.NzGridHeads.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.NzGridHeads.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.NzGridHeads.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.NzGridHeads.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzGridHeads.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.NzGridHeads.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle;
            this.NzGridHeads.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid;
            this.NzGridHeads.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
            this.NzGridHeads.FrozenColumns = 5;
            this.NzGridHeads.GridLineColor = System.Drawing.Color.Black;
            this.NzGridHeads.GridLines = Janus.Windows.GridEX.GridLines.Vertical;
            this.NzGridHeads.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.NzGridHeads.GroupByBoxVisible = false;
            this.NzGridHeads.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.NzGridHeads.HeaderFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.NzGridHeads.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            NzGridHeads_Layout_0.IsCurrentLayout = true;
            NzGridHeads_Layout_0.Key = "Transfer";
            NzGridHeads_Layout_0_Reference_0.Instance = ((object)(resources.GetObject("NzGridHeads_Layout_0_Reference_0.Instance")));
            NzGridHeads_Layout_0_Reference_1.Instance = ((object)(resources.GetObject("NzGridHeads_Layout_0_Reference_1.Instance")));
            NzGridHeads_Layout_0_Reference_2.Instance = ((object)(resources.GetObject("NzGridHeads_Layout_0_Reference_2.Instance")));
            NzGridHeads_Layout_0_Reference_3.Instance = ((object)(resources.GetObject("NzGridHeads_Layout_0_Reference_3.Instance")));
            NzGridHeads_Layout_0.LayoutReferences.AddRange(new Janus.Windows.Common.Layouts.JanusLayoutReference[] {
            NzGridHeads_Layout_0_Reference_0,
            NzGridHeads_Layout_0_Reference_1,
            NzGridHeads_Layout_0_Reference_2,
            NzGridHeads_Layout_0_Reference_3});
            NzGridHeads_Layout_0.LayoutString = resources.GetString("NzGridHeads_Layout_0.LayoutString");
            this.NzGridHeads.Layouts.AddRange(new Janus.Windows.GridEX.GridEXLayout[] {
            NzGridHeads_Layout_0});
            this.NzGridHeads.Location = new System.Drawing.Point(0, 30);
            this.NzGridHeads.Name = "NzGridHeads";
            this.NzGridHeads.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
            this.NzGridHeads.Office2007CustomColor = System.Drawing.SystemColors.HotTrack;
            this.NzGridHeads.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzGridHeads.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
            this.NzGridHeads.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.NzGridHeads.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.NzGridHeads.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.NzGridHeads.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelectionSameTable;
            this.NzGridHeads.SelectOnExpand = false;
            this.NzGridHeads.Size = new System.Drawing.Size(970, 303);
            this.NzGridHeads.TabIndex = 6;
            this.NzGridHeads.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.NzGridHeads.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzGridHeads.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.NzGridHeads.TreeLineColor = System.Drawing.Color.Black;
            this.NzGridHeads.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.NzGridHeads.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.NzGridHeads_RowDoubleClick);
            this.NzGridHeads.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.NzGridHeads_ColumnButtonClick);
            this.NzGridHeads.SelectionChanged += new System.EventHandler(this.NzGridHeads_SelectionChanged);
            // 
            // Splitter1
            // 
            this.Splitter1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(136)))), ((int)(((byte)(237)))));
            this.Splitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.Splitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.Splitter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Splitter1.ExpandableControl = this.NzTabInfo;
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
            this.Splitter1.Location = new System.Drawing.Point(0, 358);
            this.Splitter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Splitter1.Name = "Splitter1";
            this.Splitter1.Size = new System.Drawing.Size(970, 8);
            this.Splitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.Splitter1.TabIndex = 7;
            this.Splitter1.TabStop = false;
            this.Splitter1.Visible = false;
            // 
            // NzTabInfo
            // 
            this.NzTabInfo.BackColor = System.Drawing.Color.Transparent;
            this.NzTabInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.NzTabInfo.FirstTabOffset = 30;
            this.NzTabInfo.Font = new System.Drawing.Font("IRANSans(Small) Medium", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NzTabInfo.Location = new System.Drawing.Point(0, 366);
            this.NzTabInfo.Name = "NzTabInfo";
            this.NzTabInfo.Office2007CustomColor = System.Drawing.Color.Transparent;
            this.NzTabInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzTabInfo.ShowFocusRectangle = false;
            this.NzTabInfo.Size = new System.Drawing.Size(970, 183);
            this.NzTabInfo.TabIndex = 8;
            this.NzTabInfo.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage3,
            this.NzTabPos,
            this.NzTabCache});
            this.NzTabInfo.TabsStateStyles.DisabledFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NzTabInfo.TabsStateStyles.DisabledFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NzTabInfo.TabsStateStyles.FormatStyle.BackColor = System.Drawing.Color.PowderBlue;
            this.NzTabInfo.TabsStateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.Gold;
            this.NzTabInfo.TabStripFormatStyle.FontSize = 9F;
            this.NzTabInfo.UseThemes = false;
            this.NzTabInfo.Visible = false;
            this.NzTabInfo.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
            // 
            // uiTabPage3
            // 
            this.uiTabPage3.AutoScroll = true;
            this.uiTabPage3.Controls.Add(this.NzGridItems);
            this.uiTabPage3.Key = "NzTabRecieve";
            this.uiTabPage3.Location = new System.Drawing.Point(1, 26);
            this.uiTabPage3.Name = "uiTabPage3";
            this.uiTabPage3.PanelFormatStyle.Alpha = 70;
            this.uiTabPage3.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
            this.uiTabPage3.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
            this.uiTabPage3.PanelFormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical;
            this.uiTabPage3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiTabPage3.Size = new System.Drawing.Size(968, 156);
            this.uiTabPage3.TabStop = true;
            this.uiTabPage3.Text = "  چـک دریافتی  ";
            // 
            // NzGridItems
            // 
            this.NzGridItems.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.NzGridItems.AlternatingColors = true;
            this.NzGridItems.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NzGridItems.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NzGridItems.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
            this.NzGridItems.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell;
            this.NzGridItems.ColumnAutoResize = true;
            this.NzGridItems.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet;
            this.NzGridItems.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NzGridItems.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            this.NzGridItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NzGridItems.DynamicFiltering = true;
            this.NzGridItems.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell;
            this.NzGridItems.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.NzGridItems.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzGridItems.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.NzGridItems.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle;
            this.NzGridItems.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid;
            this.NzGridItems.Font = new System.Drawing.Font("IRANSans(Small)", 12F);
            this.NzGridItems.FrozenColumns = 2;
            this.NzGridItems.GridLineColor = System.Drawing.Color.Black;
            this.NzGridItems.GridLines = Janus.Windows.GridEX.GridLines.Vertical;
            this.NzGridItems.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.NzGridItems.GroupByBoxVisible = false;
            this.NzGridItems.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.NzGridItems.HeaderFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.NzGridItems.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            NzGridItems_Layout_0.IsCurrentLayout = true;
            NzGridItems_Layout_0.Key = "Cheque_Receive";
            NzGridItems_Layout_0.LayoutString = resources.GetString("NzGridItems_Layout_0.LayoutString");
            this.NzGridItems.Layouts.AddRange(new Janus.Windows.GridEX.GridEXLayout[] {
            NzGridItems_Layout_0});
            this.NzGridItems.Location = new System.Drawing.Point(0, 0);
            this.NzGridItems.Name = "NzGridItems";
            this.NzGridItems.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            this.NzGridItems.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
            this.NzGridItems.Office2007CustomColor = System.Drawing.SystemColors.HotTrack;
            this.NzGridItems.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzGridItems.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
            this.NzGridItems.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.NzGridItems.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.NzGridItems.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.White;
            this.NzGridItems.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelectionSameTable;
            this.NzGridItems.SelectOnExpand = false;
            this.NzGridItems.Size = new System.Drawing.Size(968, 156);
            this.NzGridItems.TabIndex = 0;
            this.NzGridItems.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.NzGridItems.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzGridItems.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.NzGridItems.TreeLineColor = System.Drawing.Color.Black;
            this.NzGridItems.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
            this.NzGridItems.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // NzTabPos
            // 
            this.NzTabPos.Controls.Add(this.NzPosAmount);
            this.NzTabPos.Controls.Add(this.label1);
            this.NzTabPos.Controls.Add(this.label2);
            this.NzTabPos.Controls.Add(this.NzPosDesc);
            this.NzTabPos.Controls.Add(this.NzPosIdentity);
            this.NzTabPos.Controls.Add(this.label6);
            this.NzTabPos.Controls.Add(this.NzPosTitle);
            this.NzTabPos.Controls.Add(this.label5);
            this.NzTabPos.Key = "NzTabPos";
            this.NzTabPos.Location = new System.Drawing.Point(1, 26);
            this.NzTabPos.Name = "NzTabPos";
            this.NzTabPos.PanelFormatStyle.Alpha = 70;
            this.NzTabPos.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
            this.NzTabPos.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
            this.NzTabPos.PanelFormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical;
            this.NzTabPos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzTabPos.Size = new System.Drawing.Size(798, 156);
            this.NzTabPos.TabStop = true;
            this.NzTabPos.Text = "(حواله بانکی / کارتخوان)";
            // 
            // NzPosAmount
            // 
            this.NzPosAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzPosAmount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NzPosAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NzPosAmount.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NzPosAmount.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.NzPosAmount.Location = new System.Drawing.Point(326, 69);
            this.NzPosAmount.MS_BorderColor = System.Drawing.Color.Empty;
            this.NzPosAmount.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzPosAmount.MS_Decimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NzPosAmount.MS_Format_String = "0,0.##;(0,0.##); ";
            this.NzPosAmount.Name = "NzPosAmount";
            this.NzPosAmount.Size = new System.Drawing.Size(170, 27);
            this.NzPosAmount.TabIndex = 855;
            this.NzPosAmount.Text = " ";
            this.NzPosAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(496, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 23);
            this.label1.TabIndex = 850;
            this.label1.Text = "شرح :";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(496, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 23);
            this.label2.TabIndex = 851;
            this.label2.Text = "مبلغ :";
            // 
            // NzPosDesc
            // 
            this.NzPosDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzPosDesc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NzPosDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NzPosDesc.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NzPosDesc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.NzPosDesc.Location = new System.Drawing.Point(136, 100);
            this.NzPosDesc.Name = "NzPosDesc";
            this.NzPosDesc.Size = new System.Drawing.Size(360, 50);
            this.NzPosDesc.TabIndex = 852;
            this.NzPosDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NzPosIdentity
            // 
            this.NzPosIdentity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzPosIdentity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NzPosIdentity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NzPosIdentity.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NzPosIdentity.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.NzPosIdentity.Location = new System.Drawing.Point(295, 38);
            this.NzPosIdentity.Name = "NzPosIdentity";
            this.NzPosIdentity.Size = new System.Drawing.Size(201, 27);
            this.NzPosIdentity.TabIndex = 853;
            this.NzPosIdentity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(496, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 23);
            this.label6.TabIndex = 854;
            this.label6.Text = "شماره پیگیری :";
            // 
            // NzPosTitle
            // 
            this.NzPosTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzPosTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NzPosTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NzPosTitle.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NzPosTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.NzPosTitle.Location = new System.Drawing.Point(224, 7);
            this.NzPosTitle.Name = "NzPosTitle";
            this.NzPosTitle.Size = new System.Drawing.Size(272, 27);
            this.NzPosTitle.TabIndex = 853;
            this.NzPosTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(496, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 23);
            this.label5.TabIndex = 854;
            this.label5.Text = "حساب بانکی :";
            // 
            // NzTabCache
            // 
            this.NzTabCache.AutoScroll = true;
            this.NzTabCache.Controls.Add(this.NzCacheAmount);
            this.NzTabCache.Controls.Add(this.label9);
            this.NzTabCache.Controls.Add(this.label10);
            this.NzTabCache.Controls.Add(this.NzCacheDesc);
            this.NzTabCache.Controls.Add(this.NzCacheTitle);
            this.NzTabCache.Controls.Add(this.label12);
            this.NzTabCache.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NzTabCache.Key = "NzTabCache";
            this.NzTabCache.Location = new System.Drawing.Point(1, 26);
            this.NzTabCache.Name = "NzTabCache";
            this.NzTabCache.PanelFormatStyle.Alpha = 70;
            this.NzTabCache.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
            this.NzTabCache.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
            this.NzTabCache.Size = new System.Drawing.Size(798, 156);
            this.NzTabCache.TabStop = true;
            this.NzTabCache.Text = "نـقـــدی";
            // 
            // NzCacheAmount
            // 
            this.NzCacheAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzCacheAmount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NzCacheAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NzCacheAmount.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.NzCacheAmount.Location = new System.Drawing.Point(326, 44);
            this.NzCacheAmount.MS_BorderColor = System.Drawing.Color.Empty;
            this.NzCacheAmount.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzCacheAmount.MS_Decimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.NzCacheAmount.MS_Format_String = "0,0.##;(0,0.##); ";
            this.NzCacheAmount.Name = "NzCacheAmount";
            this.NzCacheAmount.Size = new System.Drawing.Size(170, 27);
            this.NzCacheAmount.TabIndex = 849;
            this.NzCacheAmount.Text = " ";
            this.NzCacheAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(496, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 23);
            this.label9.TabIndex = 846;
            this.label9.Text = "شرح :";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(496, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 23);
            this.label10.TabIndex = 847;
            this.label10.Text = "مبلغ :";
            // 
            // NzCacheDesc
            // 
            this.NzCacheDesc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzCacheDesc.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NzCacheDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NzCacheDesc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.NzCacheDesc.Location = new System.Drawing.Point(136, 77);
            this.NzCacheDesc.Name = "NzCacheDesc";
            this.NzCacheDesc.Size = new System.Drawing.Size(360, 50);
            this.NzCacheDesc.TabIndex = 848;
            this.NzCacheDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NzCacheTitle
            // 
            this.NzCacheTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzCacheTitle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NzCacheTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NzCacheTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.NzCacheTitle.Location = new System.Drawing.Point(224, 13);
            this.NzCacheTitle.Name = "NzCacheTitle";
            this.NzCacheTitle.Size = new System.Drawing.Size(272, 27);
            this.NzCacheTitle.TabIndex = 848;
            this.NzCacheTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Location = new System.Drawing.Point(496, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 23);
            this.label12.TabIndex = 848;
            this.label12.Text = "صندوق :";
            // 
            // mS_GridX_Setting2
            // 
            this.mS_GridX_Setting2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mS_GridX_Setting2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mS_GridX_Setting2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3});
            this.mS_GridX_Setting2.Location = new System.Drawing.Point(0, 333);
            this.mS_GridX_Setting2.MS_BorderColor = System.Drawing.Color.DodgerBlue;
            this.mS_GridX_Setting2.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_GridX_Setting2.MS_Color_End = System.Drawing.Color.PowderBlue;
            this.mS_GridX_Setting2.MS_Color_Start = System.Drawing.Color.AliceBlue;
            this.mS_GridX_Setting2.MS_GridX = this.NzGridHeads;
            this.mS_GridX_Setting2.Name = "mS_GridX_Setting2";
            this.mS_GridX_Setting2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mS_GridX_Setting2.Size = new System.Drawing.Size(970, 25);
            this.mS_GridX_Setting2.TabIndex = 10;
            this.mS_GridX_Setting2.Text = "mS_GridX_Setting2";
            this.mS_GridX_Setting2.MS_On_Print_Clicked += new System.EventHandler(this.mS_GridX_Setting2_MS_On_Print_Clicked);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // mS_Tool_Strip1
            // 
            this.mS_Tool_Strip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mS_Tool_Strip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NzPrint,
            this.NzItems,
            this.NzRefreshList,
            this.NzNewPayment});
            this.mS_Tool_Strip1.Location = new System.Drawing.Point(0, 0);
            this.mS_Tool_Strip1.MS_BorderColor = System.Drawing.Color.SkyBlue;
            this.mS_Tool_Strip1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_Tool_Strip1.MS_Color_End = System.Drawing.Color.LightBlue;
            this.mS_Tool_Strip1.MS_Color_Start = System.Drawing.Color.AliceBlue;
            this.mS_Tool_Strip1.Name = "mS_Tool_Strip1";
            this.mS_Tool_Strip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mS_Tool_Strip1.Size = new System.Drawing.Size(970, 30);
            this.mS_Tool_Strip1.TabIndex = 9;
            this.mS_Tool_Strip1.Text = "mS_Tool_Strip1";
            // 
            // NzPrint
            // 
            this.NzPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NzPrint.DropDownButtonWidth = 15;
            this.NzPrint.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NzPrintA4,
            this.NzPrintA5});
            this.NzPrint.Image = ((System.Drawing.Image)(resources.GetObject("NzPrint.Image")));
            this.NzPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NzPrint.Margin = new System.Windows.Forms.Padding(2, 1, 2, 2);
            this.NzPrint.Name = "NzPrint";
            this.NzPrint.Size = new System.Drawing.Size(36, 27);
            this.NzPrint.Text = "چاپ فاکتور ";
            this.NzPrint.Click += new System.EventHandler(this.NzPrint_Click);
            // 
            // NzPrintA4
            // 
            this.NzPrintA4.Name = "NzPrintA4";
            this.NzPrintA4.Size = new System.Drawing.Size(180, 22);
            this.NzPrintA4.Text = "چاپ  A4";
            this.NzPrintA4.Click += new System.EventHandler(this.NzPrintA4_Click);
            // 
            // NzPrintA5
            // 
            this.NzPrintA5.Name = "NzPrintA5";
            this.NzPrintA5.Size = new System.Drawing.Size(180, 22);
            this.NzPrintA5.Text = "چاپ  A5";
            this.NzPrintA5.Click += new System.EventHandler(this.NzPrintA5_Click);
            // 
            // NzItems
            // 
            this.NzItems.CheckOnClick = true;
            this.NzItems.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NzItems.Image = ((System.Drawing.Image)(resources.GetObject("NzItems.Image")));
            this.NzItems.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NzItems.Name = "NzItems";
            this.NzItems.Size = new System.Drawing.Size(23, 27);
            this.NzItems.Text = "مشاهده ردیف ها";
            this.NzItems.Click += new System.EventHandler(this.NzItems_Click);
            // 
            // NzRefreshList
            // 
            this.NzRefreshList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NzRefreshList.Image = ((System.Drawing.Image)(resources.GetObject("NzRefreshList.Image")));
            this.NzRefreshList.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NzRefreshList.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.NzRefreshList.Name = "NzRefreshList";
            this.NzRefreshList.Size = new System.Drawing.Size(23, 27);
            this.NzRefreshList.Text = "بروز رســانی لیست";
            this.NzRefreshList.Click += new System.EventHandler(this.NzRefreshList_Click);
            // 
            // NzNewPayment
            // 
            this.NzNewPayment.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.NzNewPayment.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F);
            this.NzNewPayment.ForeColor = System.Drawing.Color.DarkGreen;
            this.NzNewPayment.Image = ((System.Drawing.Image)(resources.GetObject("NzNewPayment.Image")));
            this.NzNewPayment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NzNewPayment.Name = "NzNewPayment";
            this.NzNewPayment.Size = new System.Drawing.Size(121, 27);
            this.NzNewPayment.Text = "ثـبت بـرگه جـدید";
            this.NzNewPayment.ToolTipText = "ثـبت بـرگه جـدید";
            this.NzNewPayment.Click += new System.EventHandler(this.NzAdd_Click);
            // 
            // FormFactorPaymentList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 549);
            this.Controls.Add(this.NzGridHeads);
            this.Controls.Add(this.mS_GridX_Setting2);
            this.Controls.Add(this.Splitter1);
            this.Controls.Add(this.NzTabInfo);
            this.Controls.Add(this.mS_Tool_Strip1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormFactorPaymentList";
            this.Text = "...";
            this.Load += new System.EventHandler(this.FormFactorPaymentList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NzGridHeads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NzTabInfo)).EndInit();
            this.NzTabInfo.ResumeLayout(false);
            this.uiTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NzGridItems)).EndInit();
            this.NzTabPos.ResumeLayout(false);
            this.NzTabPos.PerformLayout();
            this.NzTabCache.ResumeLayout(false);
            this.NzTabCache.PerformLayout();
            this.mS_GridX_Setting2.ResumeLayout(false);
            this.mS_GridX_Setting2.PerformLayout();
            this.mS_Tool_Strip1.ResumeLayout(false);
            this.mS_Tool_Strip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MS_Control.Controls.MS_GridX NzGridHeads;
        private DevComponents.DotNetBar.ExpandableSplitter Splitter1;
        private Janus.Windows.UI.Tab.UITab NzTabInfo;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage3;
        private MS_Control.Controls.MS_GridX NzGridItems;
        private Janus.Windows.UI.Tab.UITabPage NzTabPos;
        private MS_Control.Controls.MS_Decimal_Label NzPosAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NzPosDesc;
        private System.Windows.Forms.Label NzPosIdentity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label NzPosTitle;
        private System.Windows.Forms.Label label5;
        private Janus.Windows.UI.Tab.UITabPage NzTabCache;
        private MS_Control.Controls.MS_Decimal_Label NzCacheAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label NzCacheDesc;
        private System.Windows.Forms.Label NzCacheTitle;
        private System.Windows.Forms.Label label12;
        private MS_Control.Controls.MS_GridX_Setting mS_GridX_Setting2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private MS_Control.Controls.MS_Tool_Strip mS_Tool_Strip1;
        private System.Windows.Forms.ToolStripSplitButton NzPrint;
        private System.Windows.Forms.ToolStripMenuItem NzPrintA4;
        private System.Windows.Forms.ToolStripMenuItem NzPrintA5;
        private System.Windows.Forms.ToolStripButton NzItems;
        private System.Windows.Forms.ToolStripButton NzRefreshList;
        private System.Windows.Forms.ToolStripButton NzNewPayment;
    }
}