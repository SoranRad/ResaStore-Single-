namespace NZ.General.WinForms.Setting
{
    partial class FormUserAccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserAccess));
            Janus.Windows.GridEX.GridEXLayout mS_GridX1_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.Tab_Control_Main = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage12 = new Janus.Windows.UI.Tab.UITabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.expandableSplitter2 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.mS_GridX1 = new MS_Control.Controls.MS_GridX();
            this.header_Tool_Strip = new MS_Control.Controls.MS_Tool_Strip();
            this.ms_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ms_CheckAll = new System.Windows.Forms.ToolStripButton();
            this.ms_UnCheckAll = new System.Windows.Forms.ToolStripButton();
            this.uiTabPage14 = new Janus.Windows.UI.Tab.UITabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).BeginInit();
            this.Tab_Control_Main.SuspendLayout();
            this.uiTabPage12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mS_GridX1)).BeginInit();
            this.header_Tool_Strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab_Control_Main
            // 
            this.Tab_Control_Main.BackColor = System.Drawing.Color.Transparent;
            this.Tab_Control_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab_Control_Main.Font = new System.Drawing.Font("IRANSans(Small)", 12F);
            this.Tab_Control_Main.Location = new System.Drawing.Point(0, 0);
            this.Tab_Control_Main.MultiLine = true;
            this.Tab_Control_Main.Name = "Tab_Control_Main";
            this.Tab_Control_Main.Office2007CustomColor = System.Drawing.Color.Transparent;
            this.Tab_Control_Main.ShowFocusRectangle = false;
            this.Tab_Control_Main.Size = new System.Drawing.Size(800, 488);
            this.Tab_Control_Main.TabIndex = 743;
            this.Tab_Control_Main.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage12,
            this.uiTabPage14});
            this.Tab_Control_Main.TabsStateStyles.DisabledFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Tab_Control_Main.TabsStateStyles.DisabledFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Tab_Control_Main.TabsStateStyles.FormatStyle.BackColor = System.Drawing.Color.PowderBlue;
            this.Tab_Control_Main.TabsStateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.Gold;
            this.Tab_Control_Main.TabsStateStyles.SelectedFormatStyle.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.Tab_Control_Main.TabStripAlignment = Janus.Windows.UI.Tab.TabStripAlignment.Right;
            this.Tab_Control_Main.TextOrientation = Janus.Windows.UI.Tab.TextOrientation.Vertical;
            this.Tab_Control_Main.UseThemes = false;
            this.Tab_Control_Main.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
            // 
            // uiTabPage12
            // 
            this.uiTabPage12.Controls.Add(this.treeView1);
            this.uiTabPage12.Controls.Add(this.expandableSplitter2);
            this.uiTabPage12.Controls.Add(this.mS_GridX1);
            this.uiTabPage12.Controls.Add(this.header_Tool_Strip);
            this.uiTabPage12.Location = new System.Drawing.Point(1, 1);
            this.uiTabPage12.Name = "uiTabPage12";
            this.uiTabPage12.PanelFormatStyle.Alpha = 70;
            this.uiTabPage12.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
            this.uiTabPage12.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
            this.uiTabPage12.PanelFormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical;
            this.uiTabPage12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiTabPage12.Size = new System.Drawing.Size(770, 486);
            this.uiTabPage12.TabStop = true;
            this.uiTabPage12.Text = "اطلاعات";
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.CheckBoxes = true;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.FullRowSelect = true;
            this.treeView1.HideSelection = false;
            this.treeView1.HotTracking = true;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Indent = 25;
            this.treeView1.ItemHeight = 24;
            this.treeView1.LineColor = System.Drawing.Color.Green;
            this.treeView1.Location = new System.Drawing.Point(0, 25);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 8, 4, 4);
            this.treeView1.Name = "treeView1";
            this.treeView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.treeView1.RightToLeftLayout = true;
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(445, 461);
            this.treeView1.TabIndex = 743;
            this.treeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            // 
            // expandableSplitter2
            // 
            this.expandableSplitter2.AnimationTime = 250;
            this.expandableSplitter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.expandableSplitter2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(136)))), ((int)(((byte)(237)))));
            this.expandableSplitter2.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandableSplitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.expandableSplitter2.Expandable = false;
            this.expandableSplitter2.ExpandableControl = this.mS_GridX1;
            this.expandableSplitter2.ExpandActionClick = false;
            this.expandableSplitter2.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(136)))), ((int)(((byte)(237)))));
            this.expandableSplitter2.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter2.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter2.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter2.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter2.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.expandableSplitter2.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter2.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(96)))));
            this.expandableSplitter2.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(139)))));
            this.expandableSplitter2.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.expandableSplitter2.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.expandableSplitter2.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(136)))), ((int)(((byte)(237)))));
            this.expandableSplitter2.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter2.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter2.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(136)))), ((int)(((byte)(237)))));
            this.expandableSplitter2.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.expandableSplitter2.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter2.Location = new System.Drawing.Point(445, 25);
            this.expandableSplitter2.MinExtra = 250;
            this.expandableSplitter2.MinSize = 250;
            this.expandableSplitter2.Name = "expandableSplitter2";
            this.expandableSplitter2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.expandableSplitter2.Size = new System.Drawing.Size(6, 461);
            this.expandableSplitter2.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter2.TabIndex = 745;
            this.expandableSplitter2.TabStop = false;
            // 
            // mS_GridX1
            // 
            this.mS_GridX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.mS_GridX1.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.True;
            this.mS_GridX1.AlternatingColors = true;
            this.mS_GridX1.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mS_GridX1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mS_GridX1.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
            this.mS_GridX1.BuiltInTextsData = resources.GetString("mS_GridX1.BuiltInTextsData");
            this.mS_GridX1.ColumnAutoResize = true;
            this.mS_GridX1.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet;
            this.mS_GridX1.Cursor = System.Windows.Forms.Cursors.Default;
            this.mS_GridX1.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            mS_GridX1_DesignTimeLayout.LayoutString = resources.GetString("mS_GridX1_DesignTimeLayout.LayoutString");
            this.mS_GridX1.DesignTimeLayout = mS_GridX1_DesignTimeLayout;
            this.mS_GridX1.Dock = System.Windows.Forms.DockStyle.Right;
            this.mS_GridX1.DynamicFiltering = true;
            this.mS_GridX1.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.mS_GridX1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.mS_GridX1.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.mS_GridX1.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mS_GridX1.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.mS_GridX1.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle;
            this.mS_GridX1.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid;
            this.mS_GridX1.Font = new System.Drawing.Font("IRANSans(Small)", 12F);
            this.mS_GridX1.FrozenColumns = 2;
            this.mS_GridX1.GridLineColor = System.Drawing.Color.Black;
            this.mS_GridX1.GridLines = Janus.Windows.GridEX.GridLines.Vertical;
            this.mS_GridX1.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.mS_GridX1.GroupByBoxVisible = false;
            this.mS_GridX1.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.mS_GridX1.HeaderFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.mS_GridX1.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.mS_GridX1.Location = new System.Drawing.Point(451, 25);
            this.mS_GridX1.Name = "mS_GridX1";
            this.mS_GridX1.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
            this.mS_GridX1.Office2007CustomColor = System.Drawing.SystemColors.HotTrack;
            this.mS_GridX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mS_GridX1.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
            this.mS_GridX1.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.mS_GridX1.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.mS_GridX1.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.mS_GridX1.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelectionSameTable;
            this.mS_GridX1.SelectOnExpand = false;
            this.mS_GridX1.Size = new System.Drawing.Size(319, 461);
            this.mS_GridX1.TabIndex = 742;
            this.mS_GridX1.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mS_GridX1.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.mS_GridX1.TreeLineColor = System.Drawing.Color.Black;
            this.mS_GridX1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.mS_GridX1.SelectionChanged += new System.EventHandler(this.mS_GridX1_SelectionChanged);
            // 
            // header_Tool_Strip
            // 
            this.header_Tool_Strip.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.header_Tool_Strip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.header_Tool_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ms_Save,
            this.toolStripSeparator1,
            this.ms_CheckAll,
            this.ms_UnCheckAll});
            this.header_Tool_Strip.Location = new System.Drawing.Point(0, 0);
            this.header_Tool_Strip.MS_BorderColor = System.Drawing.Color.DodgerBlue;
            this.header_Tool_Strip.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.header_Tool_Strip.MS_Color_End = System.Drawing.Color.PowderBlue;
            this.header_Tool_Strip.MS_Color_Start = System.Drawing.Color.AliceBlue;
            this.header_Tool_Strip.Name = "header_Tool_Strip";
            this.header_Tool_Strip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.header_Tool_Strip.Size = new System.Drawing.Size(770, 25);
            this.header_Tool_Strip.TabIndex = 744;
            this.header_Tool_Strip.TabStop = true;
            // 
            // ms_Save
            // 
            this.ms_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_Save.Image = global::MS_Resource.GlobalResources.save;
            this.ms_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ms_Save.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.ms_Save.Name = "ms_Save";
            this.ms_Save.Size = new System.Drawing.Size(23, 22);
            this.ms_Save.Text = "ذخیره تغـییرات";
            this.ms_Save.Click += new System.EventHandler(this.ms_Save_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ms_CheckAll
            // 
            this.ms_CheckAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_CheckAll.Image = global::MS_Resource.GlobalResources._ms_Save;
            this.ms_CheckAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ms_CheckAll.Margin = new System.Windows.Forms.Padding(1, 1, 5, 2);
            this.ms_CheckAll.Name = "ms_CheckAll";
            this.ms_CheckAll.Size = new System.Drawing.Size(23, 22);
            this.ms_CheckAll.Text = "اعـطای کلیـه دسـترسی هـا";
            this.ms_CheckAll.ToolTipText = "اعـطای کلیـه دسـترسی هـا";
            this.ms_CheckAll.Click += new System.EventHandler(this.ms_CheckAll_Click);
            // 
            // ms_UnCheckAll
            // 
            this.ms_UnCheckAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ms_UnCheckAll.Image = global::MS_Resource.GlobalResources._ms_Laqv_Save;
            this.ms_UnCheckAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ms_UnCheckAll.Margin = new System.Windows.Forms.Padding(0, 1, 2, 2);
            this.ms_UnCheckAll.Name = "ms_UnCheckAll";
            this.ms_UnCheckAll.Size = new System.Drawing.Size(23, 22);
            this.ms_UnCheckAll.Text = "لـغو کلیه دسترسی هـا";
            this.ms_UnCheckAll.ToolTipText = "لـغو کلیه دسترسی هـا";
            this.ms_UnCheckAll.Click += new System.EventHandler(this.ms_UnCheckAll_Click);
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
            this.uiTabPage14.Size = new System.Drawing.Size(770, 486);
            this.uiTabPage14.TabStop = true;
            this.uiTabPage14.Text = "پرسش و پاسخ";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // FormUserAccess
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 488);
            this.Controls.Add(this.Tab_Control_Main);
            this.Font = new System.Drawing.Font("IRANSans(Small)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormUserAccess";
            this.Text = "تعیین دسترسی کاربران";
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).EndInit();
            this.Tab_Control_Main.ResumeLayout(false);
            this.uiTabPage12.ResumeLayout(false);
            this.uiTabPage12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mS_GridX1)).EndInit();
            this.header_Tool_Strip.ResumeLayout(false);
            this.header_Tool_Strip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.UI.Tab.UITab Tab_Control_Main;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage12;
        private System.Windows.Forms.TreeView treeView1;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter2;
        private MS_Control.Controls.MS_GridX mS_GridX1;
        private MS_Control.Controls.MS_Tool_Strip header_Tool_Strip;
        private System.Windows.Forms.ToolStripButton ms_Save;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ms_CheckAll;
        private System.Windows.Forms.ToolStripButton ms_UnCheckAll;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage14;
        private System.Windows.Forms.ImageList imageList1;
    }
}