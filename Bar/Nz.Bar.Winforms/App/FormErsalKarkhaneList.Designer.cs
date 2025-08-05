namespace Nz.Bar.Winforms.App
{
	partial class FormErsalKarkhaneList
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormErsalKarkhaneList));
			Janus.Windows.GridEX.GridEXLayout ms_Grid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
			Janus.Windows.Common.Layouts.JanusLayoutReference ms_Grid_DesignTimeLayout_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.ButtonImage");
			Janus.Windows.Common.Layouts.JanusLayoutReference ms_Grid_DesignTimeLayout_Reference_1 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.HeaderImage");
			Janus.Windows.Common.Layouts.JanusLayoutReference ms_Grid_DesignTimeLayout_Reference_2 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.ButtonImage");
			Janus.Windows.Common.Layouts.JanusLayoutReference ms_Grid_DesignTimeLayout_Reference_3 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.HeaderImage");
			this.ms_Grid = new MS_Control.Controls.MS_GridX();
			this.uiTabPage14 = new Janus.Windows.UI.Tab.UITabPage();
			this.helpItems1 = new ShareLib.Component.HelpItems();
			this.uiTabPage6 = new Janus.Windows.UI.Tab.UITabPage();
			this.uiTabPage7 = new Janus.Windows.UI.Tab.UITabPage();
			this.ms_mah = new Janus.Windows.UI.Tab.UITab();
			this.uiTabPage8 = new Janus.Windows.UI.Tab.UITabPage();
			this.uiTabPage9 = new Janus.Windows.UI.Tab.UITabPage();
			this.uiTabPage10 = new Janus.Windows.UI.Tab.UITabPage();
			this.uiTabPage11 = new Janus.Windows.UI.Tab.UITabPage();
			this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
			this.uiTabPage13 = new Janus.Windows.UI.Tab.UITabPage();
			this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
			this.uiTabPage15 = new Janus.Windows.UI.Tab.UITabPage();
			this.uiTabPage16 = new Janus.Windows.UI.Tab.UITabPage();
			this.uiTabPage17 = new Janus.Windows.UI.Tab.UITabPage();
			this.uiTabPage18 = new Janus.Windows.UI.Tab.UITabPage();
			this.NzAddItem = new System.Windows.Forms.ToolStripButton();
			this.Tab_Control_Main = new Janus.Windows.UI.Tab.UITab();
			this.uiTabPage12 = new Janus.Windows.UI.Tab.UITabPage();
			this.mS_Panel1 = new MS_Control.Controls.MS_Panel();
			this.mS_Tool_Strip1 = new MS_Control.Controls.MS_Tool_Strip();
			this.NzRefreshList = new System.Windows.Forms.ToolStripButton();
			this.mS_GridX_Setting1 = new MS_Control.Controls.MS_GridX_Setting();
			((System.ComponentModel.ISupportInitialize)(this.ms_Grid)).BeginInit();
			this.uiTabPage14.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ms_mah)).BeginInit();
			this.ms_mah.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).BeginInit();
			this.Tab_Control_Main.SuspendLayout();
			this.uiTabPage12.SuspendLayout();
			this.mS_Panel1.SuspendLayout();
			this.mS_Tool_Strip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// ms_Grid
			// 
			this.ms_Grid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.ms_Grid.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.True;
			this.ms_Grid.AlternatingColors = true;
			this.ms_Grid.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ms_Grid.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ms_Grid.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
			this.ms_Grid.BuiltInTextsData = resources.GetString("ms_Grid.BuiltInTextsData");
			this.ms_Grid.ColumnAutoResize = true;
			this.ms_Grid.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet;
			this.ms_Grid.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.ms_Grid.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
			ms_Grid_DesignTimeLayout_Reference_0.Instance = ((object)(resources.GetObject("ms_Grid_DesignTimeLayout_Reference_0.Instance")));
			ms_Grid_DesignTimeLayout_Reference_1.Instance = ((object)(resources.GetObject("ms_Grid_DesignTimeLayout_Reference_1.Instance")));
			ms_Grid_DesignTimeLayout_Reference_2.Instance = ((object)(resources.GetObject("ms_Grid_DesignTimeLayout_Reference_2.Instance")));
			ms_Grid_DesignTimeLayout_Reference_3.Instance = ((object)(resources.GetObject("ms_Grid_DesignTimeLayout_Reference_3.Instance")));
			ms_Grid_DesignTimeLayout.LayoutReferences.AddRange(new Janus.Windows.Common.Layouts.JanusLayoutReference[] {
            ms_Grid_DesignTimeLayout_Reference_0,
            ms_Grid_DesignTimeLayout_Reference_1,
            ms_Grid_DesignTimeLayout_Reference_2,
            ms_Grid_DesignTimeLayout_Reference_3});
			ms_Grid_DesignTimeLayout.LayoutString = resources.GetString("ms_Grid_DesignTimeLayout.LayoutString");
			this.ms_Grid.DesignTimeLayout = ms_Grid_DesignTimeLayout;
			this.ms_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ms_Grid.DynamicFiltering = true;
			this.ms_Grid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.ms_Grid.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.ms_Grid.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
			this.ms_Grid.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ms_Grid.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
			this.ms_Grid.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle;
			this.ms_Grid.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid;
			this.ms_Grid.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.ms_Grid.FrozenColumns = 2;
			this.ms_Grid.GridLineColor = System.Drawing.Color.Black;
			this.ms_Grid.GridLines = Janus.Windows.GridEX.GridLines.Vertical;
			this.ms_Grid.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
			this.ms_Grid.GroupByBoxVisible = false;
			this.ms_Grid.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ms_Grid.HeaderFormatStyle.ForeColor = System.Drawing.Color.Black;
			this.ms_Grid.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
			this.ms_Grid.Location = new System.Drawing.Point(0, 49);
			this.ms_Grid.Name = "ms_Grid";
			this.ms_Grid.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
			this.ms_Grid.Office2007CustomColor = System.Drawing.SystemColors.HotTrack;
			this.ms_Grid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ms_Grid.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
			this.ms_Grid.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.ms_Grid.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black;
			this.ms_Grid.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.ms_Grid.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelectionSameTable;
			this.ms_Grid.SelectOnExpand = false;
			this.ms_Grid.Size = new System.Drawing.Size(1305, 620);
			this.ms_Grid.TabIndex = 719;
			this.ms_Grid.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ms_Grid.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.ms_Grid.TreeLineColor = System.Drawing.Color.Black;
			this.ms_Grid.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			this.ms_Grid.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.ms_Grid_ColumnButtonClick);
			// 
			// uiTabPage14
			// 
			this.uiTabPage14.AutoScroll = true;
			this.uiTabPage14.Controls.Add(this.helpItems1);
			this.uiTabPage14.Location = new System.Drawing.Point(1, 1);
			this.uiTabPage14.Name = "uiTabPage14";
			this.uiTabPage14.PanelFormatStyle.Alpha = 70;
			this.uiTabPage14.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
			this.uiTabPage14.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
			this.uiTabPage14.PanelFormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical;
			this.uiTabPage14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.uiTabPage14.Size = new System.Drawing.Size(1305, 669);
			this.uiTabPage14.TabStop = true;
			this.uiTabPage14.Text = "پرسش و پاسخ";
			// 
			// helpItems1
			// 
			this.helpItems1.AutoScroll = true;
			this.helpItems1.BackColor = System.Drawing.Color.Transparent;
			this.helpItems1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.helpItems1.Location = new System.Drawing.Point(0, 0);
			this.helpItems1.Name = "helpItems1";
			this.helpItems1.Size = new System.Drawing.Size(1305, 669);
			this.helpItems1.TabIndex = 0;
			// 
			// uiTabPage6
			// 
			this.uiTabPage6.Location = new System.Drawing.Point(0, 30);
			this.uiTabPage6.Name = "uiTabPage6";
			this.uiTabPage6.Size = new System.Drawing.Size(872, 0);
			this.uiTabPage6.TabStop = true;
			this.uiTabPage6.Text = "لـیست کـلی";
			// 
			// uiTabPage7
			// 
			this.uiTabPage7.Location = new System.Drawing.Point(0, 27);
			this.uiTabPage7.Name = "uiTabPage7";
			this.uiTabPage7.Size = new System.Drawing.Size(831, 1);
			this.uiTabPage7.TabStop = true;
			this.uiTabPage7.Text = "اسـفـنـد";
			// 
			// ms_mah
			// 
			this.ms_mah.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.ms_mah.BackColor = System.Drawing.Color.Transparent;
			this.ms_mah.FirstTabOffset = 10;
			this.ms_mah.Font = new System.Drawing.Font("IRANSans(Small)", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.ms_mah.Location = new System.Drawing.Point(250, 20);
			this.ms_mah.Name = "ms_mah";
			this.ms_mah.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
			this.ms_mah.Office2007CustomColor = System.Drawing.Color.AntiqueWhite;
			this.ms_mah.PageBorder = Janus.Windows.UI.Tab.PageBorder.None;
			this.ms_mah.PanelFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ms_mah.ShowFocusRectangle = false;
			this.ms_mah.Size = new System.Drawing.Size(872, 28);
			this.ms_mah.TabIndex = 708;
			this.ms_mah.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage6,
            this.uiTabPage7,
            this.uiTabPage8,
            this.uiTabPage9,
            this.uiTabPage10,
            this.uiTabPage11,
            this.uiTabPage1,
            this.uiTabPage13,
            this.uiTabPage2,
            this.uiTabPage15,
            this.uiTabPage16,
            this.uiTabPage17,
            this.uiTabPage18});
			this.ms_mah.TabsStateStyles.DisabledFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ms_mah.TabsStateStyles.DisabledFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.ms_mah.TabsStateStyles.FormatStyle.BackColor = System.Drawing.Color.LightBlue;
			this.ms_mah.TabsStateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.Gold;
			this.ms_mah.TabsStateStyles.SelectedFormatStyle.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
			this.ms_mah.UseThemes = false;
			this.ms_mah.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
			// 
			// uiTabPage8
			// 
			this.uiTabPage8.Location = new System.Drawing.Point(0, 30);
			this.uiTabPage8.Name = "uiTabPage8";
			this.uiTabPage8.Size = new System.Drawing.Size(872, 0);
			this.uiTabPage8.TabStop = true;
			this.uiTabPage8.Text = "بـهـمـن";
			// 
			// uiTabPage9
			// 
			this.uiTabPage9.Location = new System.Drawing.Point(0, 27);
			this.uiTabPage9.Name = "uiTabPage9";
			this.uiTabPage9.Size = new System.Drawing.Size(831, 1);
			this.uiTabPage9.TabStop = true;
			this.uiTabPage9.Text = "دی";
			// 
			// uiTabPage10
			// 
			this.uiTabPage10.Location = new System.Drawing.Point(0, 27);
			this.uiTabPage10.Name = "uiTabPage10";
			this.uiTabPage10.Size = new System.Drawing.Size(831, 1);
			this.uiTabPage10.TabStop = true;
			this.uiTabPage10.Text = "آذر";
			// 
			// uiTabPage11
			// 
			this.uiTabPage11.Location = new System.Drawing.Point(0, 24);
			this.uiTabPage11.Name = "uiTabPage11";
			this.uiTabPage11.Size = new System.Drawing.Size(855, 1);
			this.uiTabPage11.TabStop = true;
			this.uiTabPage11.Text = "آبــان";
			// 
			// uiTabPage1
			// 
			this.uiTabPage1.Location = new System.Drawing.Point(0, 27);
			this.uiTabPage1.Name = "uiTabPage1";
			this.uiTabPage1.Size = new System.Drawing.Size(845, 1);
			this.uiTabPage1.TabStop = true;
			this.uiTabPage1.Text = "مـهــر";
			// 
			// uiTabPage13
			// 
			this.uiTabPage13.Location = new System.Drawing.Point(0, 27);
			this.uiTabPage13.Name = "uiTabPage13";
			this.uiTabPage13.Size = new System.Drawing.Size(831, 1);
			this.uiTabPage13.TabStop = true;
			this.uiTabPage13.Text = "شــهـریـور";
			// 
			// uiTabPage2
			// 
			this.uiTabPage2.Location = new System.Drawing.Point(0, 27);
			this.uiTabPage2.Name = "uiTabPage2";
			this.uiTabPage2.Size = new System.Drawing.Size(831, 1);
			this.uiTabPage2.TabStop = true;
			this.uiTabPage2.Text = "مــرداد";
			// 
			// uiTabPage15
			// 
			this.uiTabPage15.Location = new System.Drawing.Point(0, 24);
			this.uiTabPage15.Name = "uiTabPage15";
			this.uiTabPage15.Size = new System.Drawing.Size(855, 1);
			this.uiTabPage15.TabStop = true;
			this.uiTabPage15.Text = "تـیــر";
			// 
			// uiTabPage16
			// 
			this.uiTabPage16.Location = new System.Drawing.Point(0, 24);
			this.uiTabPage16.Name = "uiTabPage16";
			this.uiTabPage16.Size = new System.Drawing.Size(855, 1);
			this.uiTabPage16.TabStop = true;
			this.uiTabPage16.Text = "خــرداد";
			// 
			// uiTabPage17
			// 
			this.uiTabPage17.Location = new System.Drawing.Point(0, 27);
			this.uiTabPage17.Name = "uiTabPage17";
			this.uiTabPage17.Size = new System.Drawing.Size(831, 1);
			this.uiTabPage17.TabStop = true;
			this.uiTabPage17.Text = "اردیـبهـشـت";
			// 
			// uiTabPage18
			// 
			this.uiTabPage18.Location = new System.Drawing.Point(0, 30);
			this.uiTabPage18.Name = "uiTabPage18";
			this.uiTabPage18.Size = new System.Drawing.Size(872, 0);
			this.uiTabPage18.TabStop = true;
			this.uiTabPage18.Text = "فـروردیـن";
			// 
			// NzAddItem
			// 
			this.NzAddItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.NzAddItem.Image = ((System.Drawing.Image)(resources.GetObject("NzAddItem.Image")));
			this.NzAddItem.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.NzAddItem.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.NzAddItem.Name = "NzAddItem";
			this.NzAddItem.Size = new System.Drawing.Size(28, 28);
			this.NzAddItem.Text = "فاکتور جدید";
			this.NzAddItem.Click += new System.EventHandler(this.ms_Add_Click);
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
			this.Tab_Control_Main.Size = new System.Drawing.Size(1339, 696);
			this.Tab_Control_Main.TabIndex = 733;
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
			this.uiTabPage12.Controls.Add(this.ms_Grid);
			this.uiTabPage12.Controls.Add(this.mS_Panel1);
			this.uiTabPage12.Controls.Add(this.mS_GridX_Setting1);
			this.uiTabPage12.Location = new System.Drawing.Point(1, 1);
			this.uiTabPage12.Name = "uiTabPage12";
			this.uiTabPage12.PanelFormatStyle.Alpha = 70;
			this.uiTabPage12.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
			this.uiTabPage12.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
			this.uiTabPage12.PanelFormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical;
			this.uiTabPage12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.uiTabPage12.Size = new System.Drawing.Size(1305, 694);
			this.uiTabPage12.TabStop = true;
			this.uiTabPage12.Text = "اطلاعات";
			// 
			// mS_Panel1
			// 
			this.mS_Panel1.Controls.Add(this.mS_Tool_Strip1);
			this.mS_Panel1.Controls.Add(this.ms_mah);
			this.mS_Panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.mS_Panel1.Location = new System.Drawing.Point(0, 0);
			this.mS_Panel1.MS_BorderColor = System.Drawing.Color.Aqua;
			this.mS_Panel1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.mS_Panel1.MS_Color_End = System.Drawing.Color.SkyBlue;
			this.mS_Panel1.MS_Color_Start = System.Drawing.Color.AliceBlue;
			this.mS_Panel1.Name = "mS_Panel1";
			this.mS_Panel1.Size = new System.Drawing.Size(1305, 49);
			this.mS_Panel1.TabIndex = 721;
			// 
			// mS_Tool_Strip1
			// 
			this.mS_Tool_Strip1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mS_Tool_Strip1.Dock = System.Windows.Forms.DockStyle.None;
			this.mS_Tool_Strip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.mS_Tool_Strip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.mS_Tool_Strip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NzRefreshList,
            this.NzAddItem});
			this.mS_Tool_Strip1.Location = new System.Drawing.Point(1226, 0);
			this.mS_Tool_Strip1.MS_BorderColor = System.Drawing.Color.SkyBlue;
			this.mS_Tool_Strip1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.mS_Tool_Strip1.MS_Color_End = System.Drawing.Color.LightBlue;
			this.mS_Tool_Strip1.MS_Color_Start = System.Drawing.Color.AliceBlue;
			this.mS_Tool_Strip1.Name = "mS_Tool_Strip1";
			this.mS_Tool_Strip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.mS_Tool_Strip1.Size = new System.Drawing.Size(79, 28);
			this.mS_Tool_Strip1.TabIndex = 709;
			this.mS_Tool_Strip1.Text = "mS_Tool_Strip1";
			// 
			// NzRefreshList
			// 
			this.NzRefreshList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.NzRefreshList.Image = ((System.Drawing.Image)(resources.GetObject("NzRefreshList.Image")));
			this.NzRefreshList.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.NzRefreshList.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.NzRefreshList.Name = "NzRefreshList";
			this.NzRefreshList.Size = new System.Drawing.Size(28, 28);
			this.NzRefreshList.Text = "بروز رســانی لیست";
			this.NzRefreshList.Click += new System.EventHandler(this.NzRefreshList_Click);
			// 
			// mS_GridX_Setting1
			// 
			this.mS_GridX_Setting1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.mS_GridX_Setting1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.mS_GridX_Setting1.Location = new System.Drawing.Point(0, 669);
			this.mS_GridX_Setting1.MS_BorderColor = System.Drawing.Color.DodgerBlue;
			this.mS_GridX_Setting1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.mS_GridX_Setting1.MS_Color_End = System.Drawing.Color.PowderBlue;
			this.mS_GridX_Setting1.MS_Color_Start = System.Drawing.Color.AliceBlue;
			this.mS_GridX_Setting1.MS_GridX = this.ms_Grid;
			this.mS_GridX_Setting1.Name = "mS_GridX_Setting1";
			this.mS_GridX_Setting1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.mS_GridX_Setting1.Size = new System.Drawing.Size(1305, 25);
			this.mS_GridX_Setting1.TabIndex = 735;
			this.mS_GridX_Setting1.Text = "mS_GridX_Setting1";
			// 
			// FormErsalKarkhaneList
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1339, 696);
			this.Controls.Add(this.Tab_Control_Main);
			this.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.Name = "FormErsalKarkhaneList";
			this.Text = "لیسـت ارسال به کارخانه";
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormListStorage_KeyUp);
			((System.ComponentModel.ISupportInitialize)(this.ms_Grid)).EndInit();
			this.uiTabPage14.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ms_mah)).EndInit();
			this.ms_mah.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).EndInit();
			this.Tab_Control_Main.ResumeLayout(false);
			this.uiTabPage12.ResumeLayout(false);
			this.uiTabPage12.PerformLayout();
			this.mS_Panel1.ResumeLayout(false);
			this.mS_Panel1.PerformLayout();
			this.mS_Tool_Strip1.ResumeLayout(false);
			this.mS_Tool_Strip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private MS_Control.Controls.MS_GridX ms_Grid;
		private Janus.Windows.UI.Tab.UITabPage uiTabPage14;
		private ShareLib.Component.HelpItems helpItems1;
		private Janus.Windows.UI.Tab.UITabPage uiTabPage6;
		private Janus.Windows.UI.Tab.UITabPage uiTabPage7;
		private Janus.Windows.UI.Tab.UITab ms_mah;
		private Janus.Windows.UI.Tab.UITabPage uiTabPage8;
		private Janus.Windows.UI.Tab.UITabPage uiTabPage9;
		private Janus.Windows.UI.Tab.UITabPage uiTabPage10;
		private Janus.Windows.UI.Tab.UITabPage uiTabPage11;
		private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
		private Janus.Windows.UI.Tab.UITabPage uiTabPage13;
		private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
		private Janus.Windows.UI.Tab.UITabPage uiTabPage15;
		private Janus.Windows.UI.Tab.UITabPage uiTabPage16;
		private Janus.Windows.UI.Tab.UITabPage uiTabPage17;
		private Janus.Windows.UI.Tab.UITabPage uiTabPage18;
		private System.Windows.Forms.ToolStripButton NzAddItem;
		private Janus.Windows.UI.Tab.UITab Tab_Control_Main;
		private Janus.Windows.UI.Tab.UITabPage uiTabPage12;
		private MS_Control.Controls.MS_Panel mS_Panel1;
		private MS_Control.Controls.MS_Tool_Strip mS_Tool_Strip1;
		private System.Windows.Forms.ToolStripButton NzRefreshList;
		private MS_Control.Controls.MS_GridX_Setting mS_GridX_Setting1;
	}
}