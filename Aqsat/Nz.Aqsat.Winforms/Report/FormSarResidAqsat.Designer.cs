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
			Janus.Windows.Common.Layouts.JanusLayoutReference NzGridFuture_Layout_0_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.ButtonImage");
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSarResidAqsat));
			Janus.Windows.Common.Layouts.JanusLayoutReference NzGridFuture_Layout_0_Reference_1 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.HeaderImage");
			this.Tab_Control_Main = new Janus.Windows.UI.Tab.UITab();
			this.uiTabPage12 = new Janus.Windows.UI.Tab.UITabPage();
			this.uiTabPage14 = new Janus.Windows.UI.Tab.UITabPage();
			this.mS_GridX_Setting1 = new MS_Control.Controls.MS_GridX_Setting();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.NsRefresh = new System.Windows.Forms.ToolStripButton();
			this.NzGridFuture = new MS_Control.Controls.MS_GridX();
			((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).BeginInit();
			this.Tab_Control_Main.SuspendLayout();
			this.uiTabPage12.SuspendLayout();
			this.mS_GridX_Setting1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NzGridFuture)).BeginInit();
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
			this.Tab_Control_Main.Size = new System.Drawing.Size(1102, 500);
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
			this.uiTabPage12.Location = new System.Drawing.Point(1, 1);
			this.uiTabPage12.Name = "uiTabPage12";
			this.uiTabPage12.PanelFormatStyle.Alpha = 70;
			this.uiTabPage12.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
			this.uiTabPage12.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
			this.uiTabPage12.PanelFormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical;
			this.uiTabPage12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.uiTabPage12.Size = new System.Drawing.Size(1068, 498);
			this.uiTabPage12.TabStop = true;
			this.uiTabPage12.Text = "اطلاعات";
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
			this.uiTabPage14.Size = new System.Drawing.Size(680, 356);
			this.uiTabPage14.TabStop = true;
			this.uiTabPage14.Text = "پرسش و پاسخ";
			// 
			// mS_GridX_Setting1
			// 
			this.mS_GridX_Setting1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.mS_GridX_Setting1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.mS_GridX_Setting1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.NsRefresh});
			this.mS_GridX_Setting1.Location = new System.Drawing.Point(0, 500);
			this.mS_GridX_Setting1.MS_BorderColor = System.Drawing.Color.DodgerBlue;
			this.mS_GridX_Setting1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.mS_GridX_Setting1.MS_Color_End = System.Drawing.Color.PowderBlue;
			this.mS_GridX_Setting1.MS_Color_Start = System.Drawing.Color.AliceBlue;
			this.mS_GridX_Setting1.MS_GridX = null;
			this.mS_GridX_Setting1.Name = "mS_GridX_Setting1";
			this.mS_GridX_Setting1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.mS_GridX_Setting1.Size = new System.Drawing.Size(1102, 25);
			this.mS_GridX_Setting1.TabIndex = 7;
			this.mS_GridX_Setting1.Text = "mS_GridX_Setting1";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// NsRefresh
			// 
			this.NsRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.NsRefresh.Image = global::MS_Resource.GlobalResources.refresh;
			this.NsRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.NsRefresh.Name = "NsRefresh";
			this.NsRefresh.Size = new System.Drawing.Size(23, 22);
			this.NsRefresh.Text = "بروزرسانی لیست";
			this.NsRefresh.Click += new System.EventHandler(this.NsRefresh_Click);
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
			NzGridFuture_Layout_0.LayoutReferences.AddRange(new Janus.Windows.Common.Layouts.JanusLayoutReference[] {
            NzGridFuture_Layout_0_Reference_0,
            NzGridFuture_Layout_0_Reference_1});
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
			this.NzGridFuture.Size = new System.Drawing.Size(1068, 498);
			this.NzGridFuture.TabIndex = 8;
			this.NzGridFuture.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
			this.NzGridFuture.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzGridFuture.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.NzGridFuture.TreeLineColor = System.Drawing.Color.Black;
			this.NzGridFuture.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			this.NzGridFuture.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.mS_GridX1_ColumnButtonClick);
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
			this.mS_GridX_Setting1.ResumeLayout(false);
			this.mS_GridX_Setting1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NzGridFuture)).EndInit();
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
    }
}