namespace Nz.Order.Winforms.App
{
	partial class FormCategory
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategory));
			Janus.Windows.GridEX.GridEXLayout NsGridRemote_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
			Janus.Windows.GridEX.GridEXLayout NsGridSubGroup_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
			this.Tab_Control_Main = new Janus.Windows.UI.Tab.UITab();
			this.uiTabPage12 = new Janus.Windows.UI.Tab.UITabPage();
			this.panel1 = new System.Windows.Forms.Panel();
			this.NsGridRemote = new MS_Control.Controls.MS_GridX();
			this.expandableSplitter1 = new DevComponents.DotNetBar.ExpandableSplitter();
			this.panel2 = new System.Windows.Forms.Panel();
			this.NsGridSubGroup = new MS_Control.Controls.MS_GridX();
			this.uiTabPage14 = new Janus.Windows.UI.Tab.UITabPage();
			this.NsBottomBar = new MS_Control.Controls.MS_Tool_Strip();
			this.NsSync = new System.Windows.Forms.ToolStripButton();
			this.NsRefresh = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).BeginInit();
			this.Tab_Control_Main.SuspendLayout();
			this.uiTabPage12.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NsGridRemote)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NsGridSubGroup)).BeginInit();
			this.NsBottomBar.SuspendLayout();
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
			this.Tab_Control_Main.Size = new System.Drawing.Size(1050, 496);
			this.Tab_Control_Main.TabIndex = 751;
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
			this.uiTabPage12.Controls.Add(this.panel1);
			this.uiTabPage12.Location = new System.Drawing.Point(1, 1);
			this.uiTabPage12.Name = "uiTabPage12";
			this.uiTabPage12.PanelFormatStyle.Alpha = 70;
			this.uiTabPage12.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
			this.uiTabPage12.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
			this.uiTabPage12.PanelFormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical;
			this.uiTabPage12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.uiTabPage12.Size = new System.Drawing.Size(1016, 494);
			this.uiTabPage12.TabStop = true;
			this.uiTabPage12.Text = "اطلاعات";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.NsGridRemote);
			this.panel1.Controls.Add(this.expandableSplitter1);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1016, 494);
			this.panel1.TabIndex = 753;
			// 
			// NsGridRemote
			// 
			this.NsGridRemote.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.NsGridRemote.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.True;
			this.NsGridRemote.AlternatingColors = true;
			this.NsGridRemote.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.NsGridRemote.BackColor = System.Drawing.Color.WhiteSmoke;
			this.NsGridRemote.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
			this.NsGridRemote.BuiltInTextsData = resources.GetString("NsGridRemote.BuiltInTextsData");
			this.NsGridRemote.ColumnAutoResize = true;
			this.NsGridRemote.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet;
			this.NsGridRemote.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.NsGridRemote.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
			NsGridRemote_DesignTimeLayout.LayoutString = resources.GetString("NsGridRemote_DesignTimeLayout.LayoutString");
			this.NsGridRemote.DesignTimeLayout = NsGridRemote_DesignTimeLayout;
			this.NsGridRemote.Dock = System.Windows.Forms.DockStyle.Fill;
			this.NsGridRemote.DynamicFiltering = true;
			this.NsGridRemote.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.NsGridRemote.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.NsGridRemote.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
			this.NsGridRemote.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsGridRemote.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
			this.NsGridRemote.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle;
			this.NsGridRemote.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid;
			this.NsGridRemote.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NsGridRemote.FrozenColumns = 2;
			this.NsGridRemote.GridLineColor = System.Drawing.Color.Black;
			this.NsGridRemote.GridLines = Janus.Windows.GridEX.GridLines.Vertical;
			this.NsGridRemote.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
			this.NsGridRemote.GroupByBoxVisible = false;
			this.NsGridRemote.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.NsGridRemote.HeaderFormatStyle.ForeColor = System.Drawing.Color.Black;
			this.NsGridRemote.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
			this.NsGridRemote.Location = new System.Drawing.Point(0, 0);
			this.NsGridRemote.Name = "NsGridRemote";
			this.NsGridRemote.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
			this.NsGridRemote.Office2007CustomColor = System.Drawing.SystemColors.HotTrack;
			this.NsGridRemote.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsGridRemote.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
			this.NsGridRemote.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.NsGridRemote.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black;
			this.NsGridRemote.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.White;
			this.NsGridRemote.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelectionSameTable;
			this.NsGridRemote.SelectOnExpand = false;
			this.NsGridRemote.Size = new System.Drawing.Size(461, 494);
			this.NsGridRemote.TabIndex = 759;
			this.NsGridRemote.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
			this.NsGridRemote.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsGridRemote.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.NsGridRemote.TreeLineColor = System.Drawing.Color.Black;
			this.NsGridRemote.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			// 
			// expandableSplitter1
			// 
			this.expandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(136)))), ((int)(((byte)(237)))));
			this.expandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.expandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.expandableSplitter1.Dock = System.Windows.Forms.DockStyle.Right;
			this.expandableSplitter1.ExpandActionClick = false;
			this.expandableSplitter1.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(136)))), ((int)(((byte)(237)))));
			this.expandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.expandableSplitter1.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.expandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.expandableSplitter1.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.expandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.expandableSplitter1.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
			this.expandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.expandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(140)))), ((int)(((byte)(96)))));
			this.expandableSplitter1.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(175)))), ((int)(((byte)(139)))));
			this.expandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
			this.expandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
			this.expandableSplitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(136)))), ((int)(((byte)(237)))));
			this.expandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.expandableSplitter1.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.expandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.expandableSplitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(136)))), ((int)(((byte)(237)))));
			this.expandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.expandableSplitter1.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
			this.expandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
			this.expandableSplitter1.Location = new System.Drawing.Point(461, 0);
			this.expandableSplitter1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.expandableSplitter1.Name = "expandableSplitter1";
			this.expandableSplitter1.Size = new System.Drawing.Size(8, 494);
			this.expandableSplitter1.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
			this.expandableSplitter1.TabIndex = 758;
			this.expandableSplitter1.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.NsGridSubGroup);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel2.Location = new System.Drawing.Point(469, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(547, 494);
			this.panel2.TabIndex = 756;
			// 
			// NsGridSubGroup
			// 
			this.NsGridSubGroup.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.NsGridSubGroup.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.True;
			this.NsGridSubGroup.AlternatingColors = true;
			this.NsGridSubGroup.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.NsGridSubGroup.BackColor = System.Drawing.Color.WhiteSmoke;
			this.NsGridSubGroup.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
			this.NsGridSubGroup.BuiltInTextsData = resources.GetString("NsGridSubGroup.BuiltInTextsData");
			this.NsGridSubGroup.ColumnAutoResize = true;
			this.NsGridSubGroup.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet;
			this.NsGridSubGroup.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.NsGridSubGroup.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
			NsGridSubGroup_DesignTimeLayout.LayoutString = resources.GetString("NsGridSubGroup_DesignTimeLayout.LayoutString");
			this.NsGridSubGroup.DesignTimeLayout = NsGridSubGroup_DesignTimeLayout;
			this.NsGridSubGroup.Dock = System.Windows.Forms.DockStyle.Fill;
			this.NsGridSubGroup.DynamicFiltering = true;
			this.NsGridSubGroup.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.NsGridSubGroup.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.NsGridSubGroup.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
			this.NsGridSubGroup.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsGridSubGroup.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
			this.NsGridSubGroup.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle;
			this.NsGridSubGroup.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid;
			this.NsGridSubGroup.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NsGridSubGroup.FrozenColumns = 2;
			this.NsGridSubGroup.GridLineColor = System.Drawing.Color.Black;
			this.NsGridSubGroup.GridLines = Janus.Windows.GridEX.GridLines.Vertical;
			this.NsGridSubGroup.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
			this.NsGridSubGroup.GroupByBoxVisible = false;
			this.NsGridSubGroup.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.NsGridSubGroup.HeaderFormatStyle.ForeColor = System.Drawing.Color.Black;
			this.NsGridSubGroup.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
			this.NsGridSubGroup.Location = new System.Drawing.Point(0, 0);
			this.NsGridSubGroup.Name = "NsGridSubGroup";
			this.NsGridSubGroup.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
			this.NsGridSubGroup.Office2007CustomColor = System.Drawing.SystemColors.HotTrack;
			this.NsGridSubGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsGridSubGroup.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
			this.NsGridSubGroup.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.NsGridSubGroup.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black;
			this.NsGridSubGroup.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.White;
			this.NsGridSubGroup.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelectionSameTable;
			this.NsGridSubGroup.SelectOnExpand = false;
			this.NsGridSubGroup.Size = new System.Drawing.Size(547, 494);
			this.NsGridSubGroup.TabIndex = 754;
			this.NsGridSubGroup.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
			this.NsGridSubGroup.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsGridSubGroup.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.NsGridSubGroup.TreeLineColor = System.Drawing.Color.Black;
			this.NsGridSubGroup.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
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
			this.uiTabPage14.Size = new System.Drawing.Size(1016, 521);
			this.uiTabPage14.TabStop = true;
			this.uiTabPage14.Text = "پرسش و پاسخ";
			// 
			// NsBottomBar
			// 
			this.NsBottomBar.AutoSize = false;
			this.NsBottomBar.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.NsBottomBar.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NsBottomBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.NsBottomBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NsSync,
            this.NsRefresh});
			this.NsBottomBar.Location = new System.Drawing.Point(0, 496);
			this.NsBottomBar.MS_BorderColor = System.Drawing.Color.DodgerBlue;
			this.NsBottomBar.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsBottomBar.MS_Color_End = System.Drawing.Color.PowderBlue;
			this.NsBottomBar.MS_Color_Start = System.Drawing.Color.AliceBlue;
			this.NsBottomBar.Name = "NsBottomBar";
			this.NsBottomBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsBottomBar.Size = new System.Drawing.Size(1050, 27);
			this.NsBottomBar.TabIndex = 757;
			this.NsBottomBar.Text = "mS_Tool_Strip1";
			// 
			// NsSync
			// 
			this.NsSync.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.NsSync.Image = ((System.Drawing.Image)(resources.GetObject("NsSync.Image")));
			this.NsSync.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.NsSync.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
			this.NsSync.Name = "NsSync";
			this.NsSync.Size = new System.Drawing.Size(23, 24);
			this.NsSync.ToolTipText = "ارسال اطلاعات به سامانه";
			this.NsSync.Click += new System.EventHandler(this.NsSync_Click);
			// 
			// NsRefresh
			// 
			this.NsRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.NsRefresh.Image = ((System.Drawing.Image)(resources.GetObject("NsRefresh.Image")));
			this.NsRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.NsRefresh.Margin = new System.Windows.Forms.Padding(10, 1, 10, 2);
			this.NsRefresh.Name = "NsRefresh";
			this.NsRefresh.Size = new System.Drawing.Size(23, 24);
			this.NsRefresh.ToolTipText = "دریافت اطلاعات";
			this.NsRefresh.Click += new System.EventHandler(this.NsRefresh_Click);
			// 
			// FormCategory
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1050, 523);
			this.Controls.Add(this.Tab_Control_Main);
			this.Controls.Add(this.NsBottomBar);
			this.Name = "FormCategory";
			this.Text = "دسته بندی ها";
			this.Shown += new System.EventHandler(this.FormCategory_Shown);
			((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).EndInit();
			this.Tab_Control_Main.ResumeLayout(false);
			this.uiTabPage12.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.NsGridRemote)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.NsGridSubGroup)).EndInit();
			this.NsBottomBar.ResumeLayout(false);
			this.NsBottomBar.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Janus.Windows.UI.Tab.UITab Tab_Control_Main;
		private Janus.Windows.UI.Tab.UITabPage uiTabPage12;
		private System.Windows.Forms.Panel panel1;
		private MS_Control.Controls.MS_GridX NsGridRemote;
		private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter1;
		private System.Windows.Forms.Panel panel2;
		private MS_Control.Controls.MS_GridX NsGridSubGroup;
		private Janus.Windows.UI.Tab.UITabPage uiTabPage14;
		private MS_Control.Controls.MS_Tool_Strip NsBottomBar;
		private System.Windows.Forms.ToolStripButton NsSync;
		private System.Windows.Forms.ToolStripButton NsRefresh;
	}
}