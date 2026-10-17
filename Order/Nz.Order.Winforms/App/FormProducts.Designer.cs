namespace Nz.Order.Winforms.App
{
	partial class FormProducts
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProducts));
			Janus.Windows.GridEX.GridEXLayout NsGridRemote_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
			Janus.Windows.GridEX.GridEXLayout NsGridLocal_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
			this.Tab_Control_Main = new Janus.Windows.UI.Tab.UITab();
			this.uiTabPage12 = new Janus.Windows.UI.Tab.UITabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.NsGridRemote = new MS_Control.Controls.MS_GridX();
			this.NsGridLocal = new MS_Control.Controls.MS_GridX();
			this.uiTabPage14 = new Janus.Windows.UI.Tab.UITabPage();
			this.NsBottomBar = new MS_Control.Controls.MS_Tool_Strip();
			this.NsRefresh = new System.Windows.Forms.ToolStripButton();
			this.NsSyncMohoudi = new System.Windows.Forms.ToolStripButton();
			this.NsSyncPropreties = new System.Windows.Forms.ToolStripButton();
			((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).BeginInit();
			this.Tab_Control_Main.SuspendLayout();
			this.uiTabPage12.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NsGridRemote)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NsGridLocal)).BeginInit();
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
			this.Tab_Control_Main.Size = new System.Drawing.Size(1439, 706);
			this.Tab_Control_Main.TabIndex = 758;
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
			this.uiTabPage12.Controls.Add(this.tableLayoutPanel1);
			this.uiTabPage12.Location = new System.Drawing.Point(1, 1);
			this.uiTabPage12.Name = "uiTabPage12";
			this.uiTabPage12.PanelFormatStyle.Alpha = 70;
			this.uiTabPage12.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
			this.uiTabPage12.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
			this.uiTabPage12.PanelFormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical;
			this.uiTabPage12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.uiTabPage12.Size = new System.Drawing.Size(1405, 704);
			this.uiTabPage12.TabStop = true;
			this.uiTabPage12.Text = "اطلاعات";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.NsGridRemote, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.NsGridLocal, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1405, 704);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// NsGridRemote
			// 
			this.NsGridRemote.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.NsGridRemote.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.True;
			this.NsGridRemote.AlternatingColors = true;
			this.NsGridRemote.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.NsGridRemote.BackColor = System.Drawing.Color.WhiteSmoke;
			this.NsGridRemote.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat;
			this.NsGridRemote.BuiltInTextsData = resources.GetString("NsGridRemote.BuiltInTextsData");
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
			this.NsGridRemote.FocusStyle = Janus.Windows.GridEX.FocusStyle.None;
			this.NsGridRemote.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NsGridRemote.FrozenColumns = 3;
			this.NsGridRemote.GridLineColor = System.Drawing.Color.Black;
			this.NsGridRemote.GridLines = Janus.Windows.GridEX.GridLines.Vertical;
			this.NsGridRemote.GroupByBoxVisible = false;
			this.NsGridRemote.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.NsGridRemote.HeaderFormatStyle.ForeColor = System.Drawing.Color.Black;
			this.NsGridRemote.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
			this.NsGridRemote.Location = new System.Drawing.Point(3, 3);
			this.NsGridRemote.Name = "NsGridRemote";
			this.NsGridRemote.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
			this.NsGridRemote.Office2007CustomColor = System.Drawing.SystemColors.HotTrack;
			this.NsGridRemote.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsGridRemote.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
			this.NsGridRemote.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.NsGridRemote.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black;
			this.NsGridRemote.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.NsGridRemote.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelectionSameTable;
			this.NsGridRemote.SelectOnExpand = false;
			this.NsGridRemote.Size = new System.Drawing.Size(697, 698);
			this.NsGridRemote.TabIndex = 761;
			this.NsGridRemote.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsGridRemote.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.NsGridRemote.TreeLineColor = System.Drawing.Color.Black;
			this.NsGridRemote.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			// 
			// NsGridLocal
			// 
			this.NsGridLocal.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.NsGridLocal.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.True;
			this.NsGridLocal.AlternatingColors = true;
			this.NsGridLocal.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.NsGridLocal.BackColor = System.Drawing.Color.WhiteSmoke;
			this.NsGridLocal.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat;
			this.NsGridLocal.BuiltInTextsData = resources.GetString("NsGridLocal.BuiltInTextsData");
			this.NsGridLocal.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet;
			this.NsGridLocal.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.NsGridLocal.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
			NsGridLocal_DesignTimeLayout.LayoutString = resources.GetString("NsGridLocal_DesignTimeLayout.LayoutString");
			this.NsGridLocal.DesignTimeLayout = NsGridLocal_DesignTimeLayout;
			this.NsGridLocal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.NsGridLocal.DynamicFiltering = true;
			this.NsGridLocal.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.NsGridLocal.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.NsGridLocal.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
			this.NsGridLocal.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsGridLocal.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
			this.NsGridLocal.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle;
			this.NsGridLocal.FocusStyle = Janus.Windows.GridEX.FocusStyle.None;
			this.NsGridLocal.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NsGridLocal.FrozenColumns = 4;
			this.NsGridLocal.GridLineColor = System.Drawing.Color.Black;
			this.NsGridLocal.GridLines = Janus.Windows.GridEX.GridLines.Vertical;
			this.NsGridLocal.GroupByBoxVisible = false;
			this.NsGridLocal.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.NsGridLocal.HeaderFormatStyle.ForeColor = System.Drawing.Color.Black;
			this.NsGridLocal.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
			this.NsGridLocal.Location = new System.Drawing.Point(706, 3);
			this.NsGridLocal.Name = "NsGridLocal";
			this.NsGridLocal.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
			this.NsGridLocal.Office2007CustomColor = System.Drawing.SystemColors.HotTrack;
			this.NsGridLocal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsGridLocal.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
			this.NsGridLocal.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.NsGridLocal.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black;
			this.NsGridLocal.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.NsGridLocal.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelectionSameTable;
			this.NsGridLocal.SelectOnExpand = false;
			this.NsGridLocal.Size = new System.Drawing.Size(696, 698);
			this.NsGridLocal.TabIndex = 760;
			this.NsGridLocal.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsGridLocal.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.NsGridLocal.TreeLineColor = System.Drawing.Color.Black;
			this.NsGridLocal.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
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
			this.uiTabPage14.Size = new System.Drawing.Size(1179, 704);
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
            this.NsRefresh,
            this.NsSyncPropreties,
            this.NsSyncMohoudi});
			this.NsBottomBar.Location = new System.Drawing.Point(0, 706);
			this.NsBottomBar.MS_BorderColor = System.Drawing.Color.DodgerBlue;
			this.NsBottomBar.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsBottomBar.MS_Color_End = System.Drawing.Color.PowderBlue;
			this.NsBottomBar.MS_Color_Start = System.Drawing.Color.AliceBlue;
			this.NsBottomBar.Name = "NsBottomBar";
			this.NsBottomBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsBottomBar.Size = new System.Drawing.Size(1439, 27);
			this.NsBottomBar.TabIndex = 759;
			this.NsBottomBar.Text = "mS_Tool_Strip1";
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
			// NsSyncMohoudi
			// 
			this.NsSyncMohoudi.Image = ((System.Drawing.Image)(resources.GetObject("NsSyncMohoudi.Image")));
			this.NsSyncMohoudi.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.NsSyncMohoudi.Margin = new System.Windows.Forms.Padding(0, 1, 20, 2);
			this.NsSyncMohoudi.Name = "NsSyncMohoudi";
			this.NsSyncMohoudi.Size = new System.Drawing.Size(156, 24);
			this.NsSyncMohoudi.Text = "ارسال نرخ ها و موجودی";
			this.NsSyncMohoudi.Click += new System.EventHandler(this.NsSyncMohoudi_Click);
			// 
			// NsSyncPropreties
			// 
			this.NsSyncPropreties.Image = ((System.Drawing.Image)(resources.GetObject("NsSyncPropreties.Image")));
			this.NsSyncPropreties.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.NsSyncPropreties.Name = "NsSyncPropreties";
			this.NsSyncPropreties.Size = new System.Drawing.Size(188, 24);
			this.NsSyncPropreties.Text = "ارسال مشخصات کالا و خدمات";
			this.NsSyncPropreties.Click += new System.EventHandler(this.NsSyncPropreties_Click);
			// 
			// FormProducts
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1439, 733);
			this.Controls.Add(this.Tab_Control_Main);
			this.Controls.Add(this.NsBottomBar);
			this.Name = "FormProducts";
			this.Text = "کالا و خدمات";
			this.Shown += new System.EventHandler(this.FormProduct_Shown);
			((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).EndInit();
			this.Tab_Control_Main.ResumeLayout(false);
			this.uiTabPage12.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.NsGridRemote)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NsGridLocal)).EndInit();
			this.NsBottomBar.ResumeLayout(false);
			this.NsBottomBar.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Janus.Windows.UI.Tab.UITab Tab_Control_Main;
		private Janus.Windows.UI.Tab.UITabPage uiTabPage12;
		private Janus.Windows.UI.Tab.UITabPage uiTabPage14;
		private MS_Control.Controls.MS_Tool_Strip NsBottomBar;
		private System.Windows.Forms.ToolStripButton NsRefresh;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private MS_Control.Controls.MS_GridX NsGridLocal;
		private MS_Control.Controls.MS_GridX NsGridRemote;
		private System.Windows.Forms.ToolStripButton NsSyncMohoudi;
		private System.Windows.Forms.ToolStripButton NsSyncPropreties;
	}
}