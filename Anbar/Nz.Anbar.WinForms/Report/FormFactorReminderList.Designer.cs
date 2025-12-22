namespace Nz.Anbar.WinForms.Report
{
    partial class FormFactorReminderList
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
			Janus.Windows.Common.Layouts.JanusLayoutReference NzGridHeads_Layout_0_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.ButtonImage");
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFactorReminderList));
			Janus.Windows.Common.Layouts.JanusLayoutReference NzGridHeads_Layout_0_Reference_1 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.HeaderImage");
			Janus.Windows.Common.Layouts.JanusLayoutReference NzGridHeads_Layout_0_Reference_2 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column12.ButtonImage");
			Janus.Windows.Common.Layouts.JanusLayoutReference NzGridHeads_Layout_0_Reference_3 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column12.HeaderImage");
			this.Tab_Control_Main = new Janus.Windows.UI.Tab.UITab();
			this.uiTabPage12 = new Janus.Windows.UI.Tab.UITabPage();
			this.NzGridHeads = new MS_Control.Controls.MS_GridX();
			this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
			this.NzReport = new MS_Control.Controls.MS_Button_GridX();
			this.NzDateFrom = new MS_Control.Tarikh.MS_Tarikh_TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.uiTabPage14 = new Janus.Windows.UI.Tab.UITabPage();
			this.mS_GridX_Setting1 = new MS_Control.Controls.MS_GridX_Setting();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).BeginInit();
			this.Tab_Control_Main.SuspendLayout();
			this.uiTabPage12.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NzGridHeads)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
			this.uiGroupBox2.SuspendLayout();
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
			this.Tab_Control_Main.Size = new System.Drawing.Size(800, 425);
			this.Tab_Control_Main.TabIndex = 2;
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
			this.uiTabPage12.Controls.Add(this.NzGridHeads);
			this.uiTabPage12.Controls.Add(this.uiGroupBox2);
			this.uiTabPage12.Location = new System.Drawing.Point(1, 1);
			this.uiTabPage12.Name = "uiTabPage12";
			this.uiTabPage12.PanelFormatStyle.Alpha = 70;
			this.uiTabPage12.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
			this.uiTabPage12.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
			this.uiTabPage12.PanelFormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical;
			this.uiTabPage12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.uiTabPage12.Size = new System.Drawing.Size(766, 423);
			this.uiTabPage12.TabStop = true;
			this.uiTabPage12.Text = "اطلاعات";
			// 
			// NzGridHeads
			// 
			this.NzGridHeads.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.NzGridHeads.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.True;
			this.NzGridHeads.AlternatingColors = true;
			this.NzGridHeads.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.NzGridHeads.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NzGridHeads.BackColor = System.Drawing.Color.WhiteSmoke;
			this.NzGridHeads.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
			this.NzGridHeads.ColumnAutoResize = true;
			this.NzGridHeads.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet;
			this.NzGridHeads.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.NzGridHeads.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
			this.NzGridHeads.DynamicFiltering = true;
			this.NzGridHeads.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.NzGridHeads.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.NzGridHeads.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
			this.NzGridHeads.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzGridHeads.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
			this.NzGridHeads.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle;
			this.NzGridHeads.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid;
			this.NzGridHeads.Font = new System.Drawing.Font("IRANSans(Small) Light", 15F);
			this.NzGridHeads.FrozenColumns = 3;
			this.NzGridHeads.GridLineColor = System.Drawing.Color.Black;
			this.NzGridHeads.GridLines = Janus.Windows.GridEX.GridLines.Vertical;
			this.NzGridHeads.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
			this.NzGridHeads.GroupByBoxVisible = false;
			this.NzGridHeads.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.NzGridHeads.HeaderFormatStyle.ForeColor = System.Drawing.Color.Black;
			this.NzGridHeads.HeaderFormatStyle.ImageHorizontalAlignment = Janus.Windows.GridEX.ImageHorizontalAlignment.Center;
			this.NzGridHeads.HeaderFormatStyle.ImageVerticalAlignment = Janus.Windows.GridEX.ImageVerticalAlignment.Center;
			this.NzGridHeads.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
			NzGridHeads_Layout_0.IsCurrentLayout = true;
			NzGridHeads_Layout_0.Key = "General";
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
			this.NzGridHeads.Location = new System.Drawing.Point(0, 65);
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
			this.NzGridHeads.Size = new System.Drawing.Size(766, 358);
			this.NzGridHeads.TabIndex = 721;
			this.NzGridHeads.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
			this.NzGridHeads.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzGridHeads.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.NzGridHeads.TreeLineColor = System.Drawing.Color.Black;
			this.NzGridHeads.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			this.NzGridHeads.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.NzGridHeads_ColumnButtonClick);
			// 
			// uiGroupBox2
			// 
			this.uiGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.uiGroupBox2.BackColor = System.Drawing.Color.Transparent;
			this.uiGroupBox2.BorderColor = System.Drawing.Color.LightBlue;
			this.uiGroupBox2.Controls.Add(this.NzReport);
			this.uiGroupBox2.Controls.Add(this.NzDateFrom);
			this.uiGroupBox2.Controls.Add(this.label8);
			this.uiGroupBox2.Location = new System.Drawing.Point(7, -2);
			this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(2);
			this.uiGroupBox2.Name = "uiGroupBox2";
			this.uiGroupBox2.Size = new System.Drawing.Size(751, 60);
			this.uiGroupBox2.TabIndex = 0;
			// 
			// NzReport
			// 
			this.NzReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzReport.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NzReport.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NzReport.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NzReport.Image = ((System.Drawing.Image)(resources.GetObject("NzReport.Image")));
			this.NzReport.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
			this.NzReport.Location = new System.Drawing.Point(443, 16);
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
			this.NzReport.Size = new System.Drawing.Size(129, 35);
			this.NzReport.TabIndex = 3;
			this.NzReport.Text = "مشـاهده گزارش";
			this.NzReport.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
			this.NzReport.UseThemes = false;
			this.NzReport.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.NzReport.WordWrap = false;
			this.NzReport.Click += new System.EventHandler(this.NzReport_Click);
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
			this.NzDateFrom.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NzDateFrom.Location = new System.Drawing.Point(578, 20);
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
			this.NzDateFrom.Size = new System.Drawing.Size(109, 27);
			this.NzDateFrom.TabIndex = 1;
			this.NzDateFrom.Text = "//";
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label8.Location = new System.Drawing.Point(687, 22);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(58, 23);
			this.label8.TabIndex = 756;
			this.label8.Text = "تا تاریخ :";
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
			this.uiTabPage14.Size = new System.Drawing.Size(822, 468);
			this.uiTabPage14.TabStop = true;
			this.uiTabPage14.Text = "پرسش و پاسخ";
			// 
			// mS_GridX_Setting1
			// 
			this.mS_GridX_Setting1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.mS_GridX_Setting1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.mS_GridX_Setting1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1});
			this.mS_GridX_Setting1.Location = new System.Drawing.Point(0, 425);
			this.mS_GridX_Setting1.MS_BorderColor = System.Drawing.Color.DodgerBlue;
			this.mS_GridX_Setting1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.mS_GridX_Setting1.MS_Color_End = System.Drawing.Color.PowderBlue;
			this.mS_GridX_Setting1.MS_Color_Start = System.Drawing.Color.AliceBlue;
			this.mS_GridX_Setting1.MS_GridX = null;
			this.mS_GridX_Setting1.Name = "mS_GridX_Setting1";
			this.mS_GridX_Setting1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.mS_GridX_Setting1.Size = new System.Drawing.Size(800, 25);
			this.mS_GridX_Setting1.TabIndex = 3;
			this.mS_GridX_Setting1.Text = "mS_GridX_Setting1";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// FormFactorReminderList
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Tab_Control_Main);
			this.Controls.Add(this.mS_GridX_Setting1);
			this.Name = "FormFactorReminderList";
			this.Text = "سر رسید فاکتور های تسویه نشده";
			this.Load += new System.EventHandler(this.FormFactorReminderList_Load);
			((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).EndInit();
			this.Tab_Control_Main.ResumeLayout(false);
			this.uiTabPage12.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.NzGridHeads)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
			this.uiGroupBox2.ResumeLayout(false);
			this.uiGroupBox2.PerformLayout();
			this.mS_GridX_Setting1.ResumeLayout(false);
			this.mS_GridX_Setting1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private Janus.Windows.UI.Tab.UITab Tab_Control_Main;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage12;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
        private MS_Control.Controls.MS_Button_GridX NzReport;
        private MS_Control.Tarikh.MS_Tarikh_TextBox NzDateFrom;
        private System.Windows.Forms.Label label8;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage14;
        private MS_Control.Controls.MS_GridX_Setting mS_GridX_Setting1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private MS_Control.Controls.MS_GridX NzGridHeads;
    }
}