namespace NZ.General.WinForms.Report
{
    partial class FormListDebit
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
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_0_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.ButtonImage");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListDebit));
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_0_Reference_1 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.HeaderImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_0_Reference_2 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.ButtonImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_0_Reference_3 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.HeaderImage");
            Janus.Windows.GridEX.GridEXLayout NzGrid_Layout_1 = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_1_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.ButtonImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_1_Reference_1 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.HeaderImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_1_Reference_2 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.ButtonImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_1_Reference_3 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.HeaderImage");
            Janus.Windows.GridEX.GridEXLayout NzGrid_Layout_2 = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_2_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.ButtonImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_2_Reference_1 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.HeaderImage");
            this.NzGrid = new MS_Control.Controls.MS_GridX();
            this.mS_GridX_Setting2 = new MS_Control.Controls.MS_GridX_Setting();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mS_Panel1 = new MS_Control.Controls.MS_Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NzDateTo = new MS_Control.Tarikh.MS_Tarikh_TextBox();
            this.NzDateFrom = new MS_Control.Tarikh.MS_Tarikh_TextBox();
            this.NzTabKind = new Janus.Windows.UI.Tab.UITab();
            this.NzTabClear = new Janus.Windows.UI.Tab.UITabPage();
            this.NzTabCredit = new Janus.Windows.UI.Tab.UITabPage();
            this.NzTabDebit = new Janus.Windows.UI.Tab.UITabPage();
            this.ms_Save = new MS_Control.Controls.MS_Button_GridX();
            ((System.ComponentModel.ISupportInitialize)(this.NzGrid)).BeginInit();
            this.mS_GridX_Setting2.SuspendLayout();
            this.mS_Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NzTabKind)).BeginInit();
            this.NzTabKind.SuspendLayout();
            this.SuspendLayout();
            // 
            // NzGrid
            // 
            this.NzGrid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.NzGrid.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.True;
            this.NzGrid.AlternatingColors = true;
            this.NzGrid.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NzGrid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NzGrid.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
            this.NzGrid.ColumnAutoResize = true;
            this.NzGrid.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet;
            this.NzGrid.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NzGrid.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            this.NzGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NzGrid.DynamicFiltering = true;
            this.NzGrid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
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
            NzGrid_Layout_0.Key = "General";
            NzGrid_Layout_0_Reference_0.Instance = ((object)(resources.GetObject("NzGrid_Layout_0_Reference_0.Instance")));
            NzGrid_Layout_0_Reference_1.Instance = ((object)(resources.GetObject("NzGrid_Layout_0_Reference_1.Instance")));
            NzGrid_Layout_0_Reference_2.Instance = ((object)(resources.GetObject("NzGrid_Layout_0_Reference_2.Instance")));
            NzGrid_Layout_0_Reference_3.Instance = ((object)(resources.GetObject("NzGrid_Layout_0_Reference_3.Instance")));
            NzGrid_Layout_0.LayoutReferences.AddRange(new Janus.Windows.Common.Layouts.JanusLayoutReference[] {
            NzGrid_Layout_0_Reference_0,
            NzGrid_Layout_0_Reference_1,
            NzGrid_Layout_0_Reference_2,
            NzGrid_Layout_0_Reference_3});
            NzGrid_Layout_0.LayoutString = resources.GetString("NzGrid_Layout_0.LayoutString");
            NzGrid_Layout_1.Key = "PreFactor";
            NzGrid_Layout_1_Reference_0.Instance = ((object)(resources.GetObject("NzGrid_Layout_1_Reference_0.Instance")));
            NzGrid_Layout_1_Reference_1.Instance = ((object)(resources.GetObject("NzGrid_Layout_1_Reference_1.Instance")));
            NzGrid_Layout_1_Reference_2.Instance = ((object)(resources.GetObject("NzGrid_Layout_1_Reference_2.Instance")));
            NzGrid_Layout_1_Reference_3.Instance = ((object)(resources.GetObject("NzGrid_Layout_1_Reference_3.Instance")));
            NzGrid_Layout_1.LayoutReferences.AddRange(new Janus.Windows.Common.Layouts.JanusLayoutReference[] {
            NzGrid_Layout_1_Reference_0,
            NzGrid_Layout_1_Reference_1,
            NzGrid_Layout_1_Reference_2,
            NzGrid_Layout_1_Reference_3});
            NzGrid_Layout_1.LayoutString = resources.GetString("NzGrid_Layout_1.LayoutString");
            NzGrid_Layout_2.IsCurrentLayout = true;
            NzGrid_Layout_2.Key = "Transfer";
            NzGrid_Layout_2_Reference_0.Instance = ((object)(resources.GetObject("NzGrid_Layout_2_Reference_0.Instance")));
            NzGrid_Layout_2_Reference_1.Instance = ((object)(resources.GetObject("NzGrid_Layout_2_Reference_1.Instance")));
            NzGrid_Layout_2.LayoutReferences.AddRange(new Janus.Windows.Common.Layouts.JanusLayoutReference[] {
            NzGrid_Layout_2_Reference_0,
            NzGrid_Layout_2_Reference_1});
            NzGrid_Layout_2.LayoutString = resources.GetString("NzGrid_Layout_2.LayoutString");
            this.NzGrid.Layouts.AddRange(new Janus.Windows.GridEX.GridEXLayout[] {
            NzGrid_Layout_0,
            NzGrid_Layout_1,
            NzGrid_Layout_2});
            this.NzGrid.Location = new System.Drawing.Point(0, 46);
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
            this.NzGrid.Size = new System.Drawing.Size(828, 409);
            this.NzGrid.TabIndex = 726;
            this.NzGrid.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.NzGrid.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzGrid.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.NzGrid.TreeLineColor = System.Drawing.Color.Black;
            this.NzGrid.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.NzGrid.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.NzGrid_RowDoubleClick);
            this.NzGrid.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.NzGrid_ColumnButtonClick);
            // 
            // mS_GridX_Setting2
            // 
            this.mS_GridX_Setting2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mS_GridX_Setting2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mS_GridX_Setting2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3});
            this.mS_GridX_Setting2.Location = new System.Drawing.Point(0, 455);
            this.mS_GridX_Setting2.MS_BorderColor = System.Drawing.Color.DodgerBlue;
            this.mS_GridX_Setting2.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_GridX_Setting2.MS_Color_End = System.Drawing.Color.PowderBlue;
            this.mS_GridX_Setting2.MS_Color_Start = System.Drawing.Color.AliceBlue;
            this.mS_GridX_Setting2.MS_GridX = this.NzGrid;
            this.mS_GridX_Setting2.Name = "mS_GridX_Setting2";
            this.mS_GridX_Setting2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mS_GridX_Setting2.Size = new System.Drawing.Size(828, 25);
            this.mS_GridX_Setting2.TabIndex = 728;
            this.mS_GridX_Setting2.Text = "mS_GridX_Setting2";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // mS_Panel1
            // 
            this.mS_Panel1.Controls.Add(this.ms_Save);
            this.mS_Panel1.Controls.Add(this.label2);
            this.mS_Panel1.Controls.Add(this.label1);
            this.mS_Panel1.Controls.Add(this.NzDateTo);
            this.mS_Panel1.Controls.Add(this.NzDateFrom);
            this.mS_Panel1.Controls.Add(this.NzTabKind);
            this.mS_Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.mS_Panel1.Location = new System.Drawing.Point(0, 0);
            this.mS_Panel1.MS_BorderColor = System.Drawing.Color.Aqua;
            this.mS_Panel1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_Panel1.MS_Color_End = System.Drawing.Color.SkyBlue;
            this.mS_Panel1.MS_Color_Start = System.Drawing.Color.AliceBlue;
            this.mS_Panel1.Name = "mS_Panel1";
            this.mS_Panel1.Size = new System.Drawing.Size(828, 46);
            this.mS_Panel1.TabIndex = 727;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(596, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 764;
            this.label2.Text = "تا تاریخ :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(772, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 765;
            this.label1.Text = "از تاریخ :";
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
            this.NzDateTo.Location = new System.Drawing.Point(489, 12);
            this.NzDateTo.MinimumSize = new System.Drawing.Size(89, 25);
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
            this.NzDateTo.Size = new System.Drawing.Size(107, 25);
            this.NzDateTo.TabIndex = 1;
            this.NzDateTo.Text = "//";
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
            this.NzDateFrom.Location = new System.Drawing.Point(665, 12);
            this.NzDateFrom.MinimumSize = new System.Drawing.Size(89, 25);
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
            this.NzDateFrom.Size = new System.Drawing.Size(107, 25);
            this.NzDateFrom.TabIndex = 0;
            this.NzDateFrom.Text = "//";
            // 
            // NzTabKind
            // 
            this.NzTabKind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzTabKind.BackColor = System.Drawing.Color.Transparent;
            this.NzTabKind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzTabKind.FirstTabOffset = 25;
            this.NzTabKind.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NzTabKind.Location = new System.Drawing.Point(3, 13);
            this.NzTabKind.Name = "NzTabKind";
            this.NzTabKind.PageBorder = Janus.Windows.UI.Tab.PageBorder.None;
            this.NzTabKind.SettingsKey = "NzFactorKinds";
            this.NzTabKind.ShowFocusRectangle = false;
            this.NzTabKind.Size = new System.Drawing.Size(379, 32);
            this.NzTabKind.TabIndex = 2;
            this.NzTabKind.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.NzTabClear,
            this.NzTabCredit,
            this.NzTabDebit});
            this.NzTabKind.TabsStateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.Yellow;
            this.NzTabKind.TabStripOffset = 4;
            this.NzTabKind.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2007;
            this.NzTabKind.SelectedTabChanged += new Janus.Windows.UI.Tab.TabEventHandler(this.NzTabKind_SelectedTabChanged);
            // 
            // NzTabClear
            // 
            this.NzTabClear.Key = "NzTabClear";
            this.NzTabClear.Location = new System.Drawing.Point(0, 32);
            this.NzTabClear.Name = "NzTabClear";
            this.NzTabClear.Size = new System.Drawing.Size(379, 0);
            this.NzTabClear.TabStop = true;
            this.NzTabClear.Text = "اشخاص بی حسـاب";
            // 
            // NzTabCredit
            // 
            this.NzTabCredit.Key = "NzTabCredit";
            this.NzTabCredit.Location = new System.Drawing.Point(0, 32);
            this.NzTabCredit.Name = "NzTabCredit";
            this.NzTabCredit.Size = new System.Drawing.Size(437, 0);
            this.NzTabCredit.TabStop = true;
            this.NzTabCredit.Text = "لیست بستانکاران";
            // 
            // NzTabDebit
            // 
            this.NzTabDebit.Key = "NzTabDebit";
            this.NzTabDebit.Location = new System.Drawing.Point(0, 32);
            this.NzTabDebit.Name = "NzTabDebit";
            this.NzTabDebit.Size = new System.Drawing.Size(379, 0);
            this.NzTabDebit.TabStop = true;
            this.NzTabDebit.Text = "لیست بدهـکاران";
            // 
            // ms_Save
            // 
            this.ms_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_Save.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_Save.Image = global::MS_Resource.GlobalResources.chart_bar;
            this.ms_Save.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.ms_Save.Location = new System.Drawing.Point(375, 10);
            this.ms_Save.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.ms_Save.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_Save.MS_Change_Border_Color_On_Enter = false;
            this.ms_Save.MS_Change_Color_On_Enter = false;
            this.ms_Save.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.ms_Save.MS_Enter_Color = System.Drawing.Color.Empty;
            this.ms_Save.Name = "ms_Save";
            this.ms_Save.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.ms_Save.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
            this.ms_Save.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ms_Save.ShowFocusRectangle = false;
            this.ms_Save.Size = new System.Drawing.Size(103, 30);
            this.ms_Save.TabIndex = 766;
            this.ms_Save.Text = "نمایش ";
            this.ms_Save.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.ms_Save.UseThemes = false;
            this.ms_Save.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ms_Save.WordWrap = false;
            this.ms_Save.Click += new System.EventHandler(this.ms_Save_Click);
            // 
            // FormListDebit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(828, 480);
            this.Controls.Add(this.NzGrid);
            this.Controls.Add(this.mS_GridX_Setting2);
            this.Controls.Add(this.mS_Panel1);
            this.Font = new System.Drawing.Font("IRANSans(Small)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FormListDebit";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "لیسـت بدهکاران و بستانکاران";
            ((System.ComponentModel.ISupportInitialize)(this.NzGrid)).EndInit();
            this.mS_GridX_Setting2.ResumeLayout(false);
            this.mS_GridX_Setting2.PerformLayout();
            this.mS_Panel1.ResumeLayout(false);
            this.mS_Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NzTabKind)).EndInit();
            this.NzTabKind.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MS_Control.Controls.MS_GridX NzGrid;
        private MS_Control.Controls.MS_GridX_Setting mS_GridX_Setting2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private MS_Control.Controls.MS_Panel mS_Panel1;
        private Janus.Windows.UI.Tab.UITab NzTabKind;
        private Janus.Windows.UI.Tab.UITabPage NzTabDebit;
        private Janus.Windows.UI.Tab.UITabPage NzTabCredit;
        private Janus.Windows.UI.Tab.UITabPage NzTabClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MS_Control.Tarikh.MS_Tarikh_TextBox NzDateTo;
        private MS_Control.Tarikh.MS_Tarikh_TextBox NzDateFrom;
        private MS_Control.Controls.MS_Button_GridX ms_Save;
    }
}