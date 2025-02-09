namespace NZ.General.WinForms.Report
{
    partial class FormBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBill));
            Janus.Windows.GridEX.GridEXLayout NzGrid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.GridEX.GridEXLayout NzGridDetails_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGridDetails_DesignTimeLayout_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.ButtonImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGridDetails_DesignTimeLayout_Reference_1 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.HeaderImage");
            this.Tab_Control_Main = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage12 = new Janus.Windows.UI.Tab.UITabPage();
            this.NzTabInfo = new Janus.Windows.UI.Tab.UITab();
            this.NzTab1 = new Janus.Windows.UI.Tab.UITabPage();
            this.NzGrid = new MS_Control.Controls.MS_GridX();
            this.NzTab2 = new Janus.Windows.UI.Tab.UITabPage();
            this.NzGridDetails = new MS_Control.Controls.MS_GridX();
            this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NzA5Radio = new MS_Control.Controls.MS_RadioBox();
            this.NzA4Radio = new MS_Control.Controls.MS_RadioBox();
            this.NzAllYears = new MS_Control.Controls.MS_CheckBox();
            this.NzTopCount = new Janus.Windows.GridEX.EditControls.IntegerUpDown();
            this.NzReport = new MS_Control.Controls.MS_Button_GridX();
            this.NzPrint = new MS_Control.Controls.MS_Button_GridX();
            this.NzObject = new MS_Control.Controls.MS_RadioBox();
            this.NzGroup = new MS_Control.Controls.MS_RadioBox();
            this.NzCustomer = new NZ.General.WinForms.Component.NzPeople();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.NzDateTo = new MS_Control.Tarikh.MS_Tarikh_TextBox();
            this.NzDateFrom = new MS_Control.Tarikh.MS_Tarikh_TextBox();
            this.uiTabPage14 = new Janus.Windows.UI.Tab.UITabPage();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).BeginInit();
            this.Tab_Control_Main.SuspendLayout();
            this.uiTabPage12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NzTabInfo)).BeginInit();
            this.NzTabInfo.SuspendLayout();
            this.NzTab1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NzGrid)).BeginInit();
            this.NzTab2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NzGridDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
            this.uiGroupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab_Control_Main
            // 
            this.Tab_Control_Main.BackColor = System.Drawing.Color.Transparent;
            this.Tab_Control_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab_Control_Main.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
            this.Tab_Control_Main.Location = new System.Drawing.Point(0, 0);
            this.Tab_Control_Main.MultiLine = true;
            this.Tab_Control_Main.Name = "Tab_Control_Main";
            this.Tab_Control_Main.Office2007CustomColor = System.Drawing.Color.Transparent;
            this.Tab_Control_Main.ShowFocusRectangle = false;
            this.Tab_Control_Main.Size = new System.Drawing.Size(898, 500);
            this.Tab_Control_Main.TabIndex = 0;
            this.Tab_Control_Main.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage12,
            this.uiTabPage14});
            this.Tab_Control_Main.TabsStateStyles.DisabledFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Tab_Control_Main.TabsStateStyles.DisabledFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Tab_Control_Main.TabsStateStyles.FormatStyle.BackColor = System.Drawing.Color.PowderBlue;
            this.Tab_Control_Main.TabsStateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.Gold;
            this.Tab_Control_Main.TabStripAlignment = Janus.Windows.UI.Tab.TabStripAlignment.Right;
            this.Tab_Control_Main.TextOrientation = Janus.Windows.UI.Tab.TextOrientation.Vertical;
            this.Tab_Control_Main.UseThemes = false;
            this.Tab_Control_Main.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
            // 
            // uiTabPage12
            // 
            this.uiTabPage12.Controls.Add(this.NzTabInfo);
            this.uiTabPage12.Controls.Add(this.uiGroupBox2);
            this.uiTabPage12.Location = new System.Drawing.Point(1, 1);
            this.uiTabPage12.Name = "uiTabPage12";
            this.uiTabPage12.PanelFormatStyle.Alpha = 70;
            this.uiTabPage12.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
            this.uiTabPage12.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
            this.uiTabPage12.PanelFormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical;
            this.uiTabPage12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiTabPage12.Size = new System.Drawing.Size(866, 498);
            this.uiTabPage12.TabStop = true;
            this.uiTabPage12.Text = "اطلاعات";
            // 
            // NzTabInfo
            // 
            this.NzTabInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NzTabInfo.BackColor = System.Drawing.Color.Transparent;
            this.NzTabInfo.FirstTabOffset = 30;
            this.NzTabInfo.Location = new System.Drawing.Point(-1, 117);
            this.NzTabInfo.MultiLine = true;
            this.NzTabInfo.Name = "NzTabInfo";
            this.NzTabInfo.Office2007CustomColor = System.Drawing.Color.Transparent;
            this.NzTabInfo.ShowFocusRectangle = false;
            this.NzTabInfo.Size = new System.Drawing.Size(867, 379);
            this.NzTabInfo.TabIndex = 1;
            this.NzTabInfo.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.NzTab1,
            this.NzTab2});
            this.NzTabInfo.TabsStateStyles.DisabledFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NzTabInfo.TabsStateStyles.DisabledFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NzTabInfo.TabsStateStyles.FormatStyle.BackColor = System.Drawing.Color.PowderBlue;
            this.NzTabInfo.TabsStateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.Gold;
            this.NzTabInfo.TabStripFormatStyle.FontSize = 9F;
            this.NzTabInfo.UseThemes = false;
            this.NzTabInfo.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
            // 
            // NzTab1
            // 
            this.NzTab1.Controls.Add(this.NzGrid);
            this.NzTab1.Location = new System.Drawing.Point(1, 31);
            this.NzTab1.Name = "NzTab1";
            this.NzTab1.PanelFormatStyle.Alpha = 70;
            this.NzTab1.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
            this.NzTab1.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
            this.NzTab1.PanelFormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical;
            this.NzTab1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzTab1.Size = new System.Drawing.Size(865, 347);
            this.NzTab1.TabStop = true;
            this.NzTab1.Text = "صـورت حـسـاب کلی";
            // 
            // NzGrid
            // 
            this.NzGrid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.NzGrid.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.True;
            this.NzGrid.AlternatingColors = true;
            this.NzGrid.AlternatingRowFormatStyle.Alpha = 80;
            this.NzGrid.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.LightBlue;
            this.NzGrid.AlternatingRowFormatStyle.BackColorAlphaMode = Janus.Windows.GridEX.AlphaMode.UseAlpha;
            this.NzGrid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NzGrid.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
            this.NzGrid.BuiltInTextsData = resources.GetString("NzGrid.BuiltInTextsData");
            this.NzGrid.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet;
            this.NzGrid.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NzGrid.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            NzGrid_DesignTimeLayout.LayoutString = resources.GetString("NzGrid_DesignTimeLayout.LayoutString");
            this.NzGrid.DesignTimeLayout = NzGrid_DesignTimeLayout;
            this.NzGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NzGrid.DynamicFiltering = true;
            this.NzGrid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.NzGrid.ExpandableGroups = Janus.Windows.GridEX.InheritableBoolean.False;
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
            this.NzGrid.GroupRowFormatStyle.BackColor = System.Drawing.Color.PaleGreen;
            this.NzGrid.GroupRowFormatStyle.BackColorAlphaMode = Janus.Windows.GridEX.AlphaMode.Transparent;
            this.NzGrid.GroupRowFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzGrid.GroupRowFormatStyle.FontSize = 12F;
            this.NzGrid.GroupRowFormatStyle.ForeColor = System.Drawing.Color.Black;
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
            this.NzGrid.Size = new System.Drawing.Size(865, 347);
            this.NzGrid.TabIndex = 0;
            this.NzGrid.ThemedAreas = ((Janus.Windows.GridEX.ThemedArea)((((((((Janus.Windows.GridEX.ThemedArea.ScrollBars | Janus.Windows.GridEX.ThemedArea.EditControls) 
            | Janus.Windows.GridEX.ThemedArea.Headers) 
            | Janus.Windows.GridEX.ThemedArea.TreeGliphs) 
            | Janus.Windows.GridEX.ThemedArea.ControlBorder) 
            | Janus.Windows.GridEX.ThemedArea.Cards) 
            | Janus.Windows.GridEX.ThemedArea.Gridlines) 
            | Janus.Windows.GridEX.ThemedArea.CheckBoxes)));
            this.NzGrid.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.NzGrid.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzGrid.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.NzGrid.TreeLineColor = System.Drawing.Color.Black;
            this.NzGrid.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.NzGrid.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.NzGrid_FormattingRow);
            // 
            // NzTab2
            // 
            this.NzTab2.Controls.Add(this.NzGridDetails);
            this.NzTab2.Location = new System.Drawing.Point(1, 31);
            this.NzTab2.Name = "NzTab2";
            this.NzTab2.PanelFormatStyle.Alpha = 70;
            this.NzTab2.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
            this.NzTab2.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
            this.NzTab2.PanelFormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical;
            this.NzTab2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzTab2.Size = new System.Drawing.Size(865, 347);
            this.NzTab2.TabStop = true;
            this.NzTab2.Text = "ریز صورت حسـاب ";
            // 
            // NzGridDetails
            // 
            this.NzGridDetails.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.NzGridDetails.AlternatingColors = true;
            this.NzGridDetails.AlternatingRowFormatStyle.Alpha = 80;
            this.NzGridDetails.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.LightBlue;
            this.NzGridDetails.AlternatingRowFormatStyle.BackColorAlphaMode = Janus.Windows.GridEX.AlphaMode.UseAlpha;
            this.NzGridDetails.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NzGridDetails.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
            this.NzGridDetails.BuiltInTextsData = resources.GetString("NzGridDetails.BuiltInTextsData");
            this.NzGridDetails.ColumnAutoResize = true;
            this.NzGridDetails.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet;
            this.NzGridDetails.Cursor = System.Windows.Forms.Cursors.Default;
            this.NzGridDetails.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            NzGridDetails_DesignTimeLayout_Reference_0.Instance = ((object)(resources.GetObject("NzGridDetails_DesignTimeLayout_Reference_0.Instance")));
            NzGridDetails_DesignTimeLayout_Reference_1.Instance = ((object)(resources.GetObject("NzGridDetails_DesignTimeLayout_Reference_1.Instance")));
            NzGridDetails_DesignTimeLayout.LayoutReferences.AddRange(new Janus.Windows.Common.Layouts.JanusLayoutReference[] {
            NzGridDetails_DesignTimeLayout_Reference_0,
            NzGridDetails_DesignTimeLayout_Reference_1});
            NzGridDetails_DesignTimeLayout.LayoutString = resources.GetString("NzGridDetails_DesignTimeLayout.LayoutString");
            this.NzGridDetails.DesignTimeLayout = NzGridDetails_DesignTimeLayout;
            this.NzGridDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NzGridDetails.DynamicFiltering = true;
            this.NzGridDetails.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.NzGridDetails.ExpandableGroups = Janus.Windows.GridEX.InheritableBoolean.False;
            this.NzGridDetails.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.NzGridDetails.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.NzGridDetails.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzGridDetails.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.NzGridDetails.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle;
            this.NzGridDetails.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid;
            this.NzGridDetails.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
            this.NzGridDetails.FrozenColumns = 2;
            this.NzGridDetails.GridLineColor = System.Drawing.Color.Black;
            this.NzGridDetails.GridLines = Janus.Windows.GridEX.GridLines.Vertical;
            this.NzGridDetails.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.NzGridDetails.GroupByBoxVisible = false;
            this.NzGridDetails.GroupRowFormatStyle.BackColor = System.Drawing.Color.PaleGreen;
            this.NzGridDetails.GroupRowFormatStyle.BackColorAlphaMode = Janus.Windows.GridEX.AlphaMode.Transparent;
            this.NzGridDetails.GroupRowFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzGridDetails.GroupRowFormatStyle.FontSize = 12F;
            this.NzGridDetails.GroupRowFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.NzGridDetails.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.NzGridDetails.HeaderFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.NzGridDetails.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.NzGridDetails.Location = new System.Drawing.Point(0, 0);
            this.NzGridDetails.Name = "NzGridDetails";
            this.NzGridDetails.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
            this.NzGridDetails.Office2007CustomColor = System.Drawing.SystemColors.HotTrack;
            this.NzGridDetails.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzGridDetails.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
            this.NzGridDetails.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.NzGridDetails.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.NzGridDetails.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.NzGridDetails.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelectionSameTable;
            this.NzGridDetails.SelectOnExpand = false;
            this.NzGridDetails.Size = new System.Drawing.Size(865, 347);
            this.NzGridDetails.TabIndex = 1;
            this.NzGridDetails.ThemedAreas = ((Janus.Windows.GridEX.ThemedArea)((((((((Janus.Windows.GridEX.ThemedArea.ScrollBars | Janus.Windows.GridEX.ThemedArea.EditControls) 
            | Janus.Windows.GridEX.ThemedArea.Headers) 
            | Janus.Windows.GridEX.ThemedArea.TreeGliphs) 
            | Janus.Windows.GridEX.ThemedArea.ControlBorder) 
            | Janus.Windows.GridEX.ThemedArea.Cards) 
            | Janus.Windows.GridEX.ThemedArea.Gridlines) 
            | Janus.Windows.GridEX.ThemedArea.CheckBoxes)));
            this.NzGridDetails.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.NzGridDetails.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzGridDetails.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.NzGridDetails.TreeLineColor = System.Drawing.Color.Black;
            this.NzGridDetails.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.NzGridDetails.FormattingRow += new Janus.Windows.GridEX.RowLoadEventHandler(this.NzGridDetails_FormattingRow);
            this.NzGridDetails.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.NzGridDetails_ColumnButtonClick);
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.uiGroupBox2.BorderColor = System.Drawing.Color.LightBlue;
            this.uiGroupBox2.Controls.Add(this.panel1);
            this.uiGroupBox2.Controls.Add(this.NzAllYears);
            this.uiGroupBox2.Controls.Add(this.NzTopCount);
            this.uiGroupBox2.Controls.Add(this.NzReport);
            this.uiGroupBox2.Controls.Add(this.NzPrint);
            this.uiGroupBox2.Controls.Add(this.NzObject);
            this.uiGroupBox2.Controls.Add(this.NzGroup);
            this.uiGroupBox2.Controls.Add(this.NzCustomer);
            this.uiGroupBox2.Controls.Add(this.label2);
            this.uiGroupBox2.Controls.Add(this.label3);
            this.uiGroupBox2.Controls.Add(this.label1);
            this.uiGroupBox2.Controls.Add(this.label13);
            this.uiGroupBox2.Controls.Add(this.NzDateTo);
            this.uiGroupBox2.Controls.Add(this.NzDateFrom);
            this.uiGroupBox2.Location = new System.Drawing.Point(6, -1);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Size = new System.Drawing.Size(854, 113);
            this.uiGroupBox2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NzA5Radio);
            this.panel1.Controls.Add(this.NzA4Radio);
            this.panel1.Location = new System.Drawing.Point(4, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(131, 33);
            this.panel1.TabIndex = 765;
            // 
            // NzA5Radio
            // 
            this.NzA5Radio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzA5Radio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzA5Radio.Location = new System.Drawing.Point(0, 5);
            this.NzA5Radio.MS_BorderColor = System.Drawing.Color.Empty;
            this.NzA5Radio.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzA5Radio.MS_Change_Border_Color_On_Enter = true;
            this.NzA5Radio.MS_Change_Color_On_Checked = true;
            this.NzA5Radio.MS_Change_Color_On_Enter = true;
            this.NzA5Radio.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzA5Radio.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NzA5Radio.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzA5Radio.MS_Exit_By_Down = true;
            this.NzA5Radio.MS_Exit_By_Enter = true;
            this.NzA5Radio.MS_Exit_By_Up = true;
            this.NzA5Radio.MS_Last_Control = null;
            this.NzA5Radio.MS_Next_Control = null;
            this.NzA5Radio.MS_UnChecked_Color = System.Drawing.Color.Empty;
            this.NzA5Radio.Name = "NzA5Radio";
            this.NzA5Radio.ShowFocusRectangle = false;
            this.NzA5Radio.Size = new System.Drawing.Size(55, 23);
            this.NzA5Radio.TabIndex = 764;
            this.NzA5Radio.TabStop = true;
            this.NzA5Radio.Text = " A5";
            // 
            // NzA4Radio
            // 
            this.NzA4Radio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzA4Radio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzA4Radio.Checked = true;
            this.NzA4Radio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzA4Radio.Location = new System.Drawing.Point(63, 5);
            this.NzA4Radio.MS_BorderColor = System.Drawing.Color.Empty;
            this.NzA4Radio.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzA4Radio.MS_Change_Border_Color_On_Enter = true;
            this.NzA4Radio.MS_Change_Color_On_Checked = true;
            this.NzA4Radio.MS_Change_Color_On_Enter = true;
            this.NzA4Radio.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzA4Radio.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NzA4Radio.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzA4Radio.MS_Exit_By_Down = true;
            this.NzA4Radio.MS_Exit_By_Enter = true;
            this.NzA4Radio.MS_Exit_By_Up = true;
            this.NzA4Radio.MS_Last_Control = null;
            this.NzA4Radio.MS_Next_Control = null;
            this.NzA4Radio.MS_UnChecked_Color = System.Drawing.Color.Empty;
            this.NzA4Radio.Name = "NzA4Radio";
            this.NzA4Radio.ShowFocusRectangle = false;
            this.NzA4Radio.Size = new System.Drawing.Size(68, 23);
            this.NzA4Radio.TabIndex = 764;
            this.NzA4Radio.TabStop = true;
            this.NzA4Radio.Text = " A4";
            // 
            // NzAllYears
            // 
            this.NzAllYears.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzAllYears.BackColor = System.Drawing.Color.Transparent;
            this.NzAllYears.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzAllYears.ForeColor = System.Drawing.Color.Maroon;
            this.NzAllYears.Location = new System.Drawing.Point(603, 55);
            this.NzAllYears.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzAllYears.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
            this.NzAllYears.MS_Change_Border_Color_On_Enter = true;
            this.NzAllYears.MS_Change_Color_On_Checked = true;
            this.NzAllYears.MS_Change_Color_On_Enter = true;
            this.NzAllYears.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NzAllYears.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NzAllYears.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzAllYears.MS_Exit_By_Down = true;
            this.NzAllYears.MS_Exit_By_Enter = true;
            this.NzAllYears.MS_Exit_By_Up = true;
            this.NzAllYears.MS_Last_Control = null;
            this.NzAllYears.MS_Next_Control = null;
            this.NzAllYears.MS_UnChecked_Color = System.Drawing.Color.Transparent;
            this.NzAllYears.Name = "NzAllYears";
            this.NzAllYears.ShowFocusRectangle = false;
            this.NzAllYears.Size = new System.Drawing.Size(82, 26);
            this.NzAllYears.TabIndex = 763;
            this.NzAllYears.Text = "  تمام سالهـا";
            this.NzAllYears.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
            this.NzAllYears.CheckedChanged += new System.EventHandler(this.NzXaridar_CheckedChanged);
            // 
            // NzTopCount
            // 
            this.NzTopCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzTopCount.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
            this.NzTopCount.Location = new System.Drawing.Point(177, 50);
            this.NzTopCount.Maximum = 20;
            this.NzTopCount.MaxLength = 2;
            this.NzTopCount.Minimum = 1;
            this.NzTopCount.Name = "NzTopCount";
            this.NzTopCount.Size = new System.Drawing.Size(43, 29);
            this.NzTopCount.TabIndex = 762;
            this.NzTopCount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.NzTopCount.Value = 3;
            this.NzTopCount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.NzTopCount.ValueChanged += new System.EventHandler(this.NzReport_Click);
            // 
            // NzReport
            // 
            this.NzReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzReport.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NzReport.Image = global::MS_Resource.GlobalResources.chart_bar;
            this.NzReport.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.NzReport.Location = new System.Drawing.Point(6, 12);
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
            this.NzReport.Size = new System.Drawing.Size(129, 30);
            this.NzReport.TabIndex = 5;
            this.NzReport.Text = "مشـاهده گزارش";
            this.NzReport.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.NzReport.UseThemes = false;
            this.NzReport.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.NzReport.WordWrap = false;
            this.NzReport.Click += new System.EventHandler(this.NzReport_Click);
            // 
            // NzPrint
            // 
            this.NzPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzPrint.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NzPrint.Image = global::MS_Resource.GlobalResources.Negin__67_;
            this.NzPrint.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.NzPrint.Location = new System.Drawing.Point(6, 48);
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
            this.NzPrint.Size = new System.Drawing.Size(129, 30);
            this.NzPrint.TabIndex = 6;
            this.NzPrint.Text = "چـاپ گزارش";
            this.NzPrint.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.NzPrint.UseThemes = false;
            this.NzPrint.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.NzPrint.WordWrap = false;
            this.NzPrint.Click += new System.EventHandler(this.NzPrint_Click);
            // 
            // NzObject
            // 
            this.NzObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzObject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzObject.Location = new System.Drawing.Point(700, 72);
            this.NzObject.MS_BorderColor = System.Drawing.Color.Empty;
            this.NzObject.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzObject.MS_Change_Border_Color_On_Enter = true;
            this.NzObject.MS_Change_Color_On_Checked = true;
            this.NzObject.MS_Change_Color_On_Enter = true;
            this.NzObject.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzObject.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NzObject.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzObject.MS_Exit_By_Down = true;
            this.NzObject.MS_Exit_By_Enter = true;
            this.NzObject.MS_Exit_By_Up = true;
            this.NzObject.MS_Last_Control = null;
            this.NzObject.MS_Next_Control = null;
            this.NzObject.MS_UnChecked_Color = System.Drawing.Color.Empty;
            this.NzObject.Name = "NzObject";
            this.NzObject.ShowFocusRectangle = false;
            this.NzObject.Size = new System.Drawing.Size(147, 23);
            this.NzObject.TabIndex = 4;
            this.NzObject.TabStop = true;
            this.NzObject.Text = " به تفکیک کالا و خدمات ";
            // 
            // NzGroup
            // 
            this.NzGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzGroup.Checked = true;
            this.NzGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzGroup.Location = new System.Drawing.Point(704, 43);
            this.NzGroup.MS_BorderColor = System.Drawing.Color.Empty;
            this.NzGroup.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzGroup.MS_Change_Border_Color_On_Enter = true;
            this.NzGroup.MS_Change_Color_On_Checked = true;
            this.NzGroup.MS_Change_Color_On_Enter = true;
            this.NzGroup.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzGroup.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NzGroup.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzGroup.MS_Exit_By_Down = true;
            this.NzGroup.MS_Exit_By_Enter = true;
            this.NzGroup.MS_Exit_By_Up = true;
            this.NzGroup.MS_Last_Control = null;
            this.NzGroup.MS_Next_Control = null;
            this.NzGroup.MS_UnChecked_Color = System.Drawing.Color.Empty;
            this.NzGroup.Name = "NzGroup";
            this.NzGroup.ShowFocusRectangle = false;
            this.NzGroup.Size = new System.Drawing.Size(143, 23);
            this.NzGroup.TabIndex = 3;
            this.NzGroup.TabStop = true;
            this.NzGroup.Text = " به تفکیک گروه فرعی ";
            this.NzGroup.CheckedChanged += new System.EventHandler(this.NzReport_Click);
            // 
            // NzCustomer
            // 
            this.NzCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzCustomer.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
            this.NzCustomer.DropSize = new System.Drawing.Size(268, 27);
            this.NzCustomer.Font = new System.Drawing.Font("IRANSans(Small)", 12F);
            this.NzCustomer.Location = new System.Drawing.Point(528, 10);
            this.NzCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            this.NzCustomer.Size = new System.Drawing.Size(268, 27);
            this.NzCustomer.TabIndex = 0;
            this.NzCustomer.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.NzCustomer.MS_On_Row_Selected += new System.EventHandler<MS_Control.TSDD.On_Selected>(this.NzCustomer_MS_On_Row_Selected);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(537, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 23);
            this.label2.TabIndex = 761;
            this.label2.Text = "تا تاریخ :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(215, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 23);
            this.label3.TabIndex = 761;
            this.label3.Text = "نمایش تعداد ردیف هـای هر فاکتور ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(537, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 23);
            this.label1.TabIndex = 761;
            this.label1.Text = "از تاریخ :";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(795, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 23);
            this.label13.TabIndex = 761;
            this.label13.Text = "شخص :";
            // 
            // NzDateTo
            // 
            this.NzDateTo.AllowInternalTab = false;
            this.NzDateTo.AllowResizeDropDown = false;
            this.NzDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzDateTo.AutoHeight = true;
            this.NzDateTo.BackColor = System.Drawing.Color.White;
            this.NzDateTo.ControlSize = new System.Drawing.Size(0, 0);
            this.NzDateTo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NzDateTo.DropSize = new System.Drawing.Size(0, 0);
            this.NzDateTo.Location = new System.Drawing.Point(424, 70);
            this.NzDateTo.MinimumSize = new System.Drawing.Size(99, 27);
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
            this.NzDateTo.Size = new System.Drawing.Size(107, 27);
            this.NzDateTo.TabIndex = 2;
            this.NzDateTo.Text = "//";
            this.NzDateTo.Leave += new System.EventHandler(this.NzPrint_Click);
            // 
            // NzDateFrom
            // 
            this.NzDateFrom.AllowInternalTab = false;
            this.NzDateFrom.AllowResizeDropDown = false;
            this.NzDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzDateFrom.AutoHeight = true;
            this.NzDateFrom.BackColor = System.Drawing.Color.White;
            this.NzDateFrom.ControlSize = new System.Drawing.Size(0, 0);
            this.NzDateFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NzDateFrom.DropSize = new System.Drawing.Size(0, 0);
            this.NzDateFrom.Location = new System.Drawing.Point(424, 41);
            this.NzDateFrom.MinimumSize = new System.Drawing.Size(99, 27);
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
            this.NzDateFrom.Size = new System.Drawing.Size(107, 27);
            this.NzDateFrom.TabIndex = 1;
            this.NzDateFrom.Text = "//";
            this.NzDateFrom.Leave += new System.EventHandler(this.NzPrint_Click);
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
            this.uiTabPage14.Size = new System.Drawing.Size(738, 498);
            this.uiTabPage14.TabStop = true;
            this.uiTabPage14.Text = "پرسش و پاسخ";
            // 
            // FormBill
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(898, 500);
            this.Controls.Add(this.Tab_Control_Main);
            this.Font = new System.Drawing.Font("IRANSans(Small)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormBill";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "صورت حسـاب مشتریان";
            this.Shown += new System.EventHandler(this.FormBill_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).EndInit();
            this.Tab_Control_Main.ResumeLayout(false);
            this.uiTabPage12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NzTabInfo)).EndInit();
            this.NzTabInfo.ResumeLayout(false);
            this.NzTab1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NzGrid)).EndInit();
            this.NzTab2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NzGridDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.UI.Tab.UITab Tab_Control_Main;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage12;
        private Janus.Windows.UI.Tab.UITab NzTabInfo;
        private Janus.Windows.UI.Tab.UITabPage NzTab1;
        private MS_Control.Tarikh.MS_Tarikh_TextBox NzDateFrom;
        private System.Windows.Forms.Label label13;
        private Janus.Windows.UI.Tab.UITabPage NzTab2;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage14;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
        private Component.NzPeople NzCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private MS_Control.Tarikh.MS_Tarikh_TextBox NzDateTo;
        private MS_Control.Controls.MS_RadioBox NzObject;
        private MS_Control.Controls.MS_RadioBox NzGroup;
        private MS_Control.Controls.MS_Button_GridX NzReport;
        private MS_Control.Controls.MS_Button_GridX NzPrint;
        private MS_Control.Controls.MS_GridX NzGrid;
        private MS_Control.Controls.MS_GridX NzGridDetails;
        private Janus.Windows.GridEX.EditControls.IntegerUpDown NzTopCount;
        private System.Windows.Forms.Label label3;
        private MS_Control.Controls.MS_CheckBox NzAllYears;
        private MS_Control.Controls.MS_RadioBox NzA5Radio;
        private MS_Control.Controls.MS_RadioBox NzA4Radio;
        private System.Windows.Forms.Panel panel1;
    }
}