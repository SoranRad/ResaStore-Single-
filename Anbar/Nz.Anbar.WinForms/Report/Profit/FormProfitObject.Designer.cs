namespace Nz.Anbar.WinForms.Report.Profit
{
    partial class FormProfitObject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfitObject));
            Janus.Windows.GridEX.GridEXLayout ms_Grid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.Common.Layouts.JanusLayoutReference ms_Grid_DesignTimeLayout_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.ButtonImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference ms_Grid_DesignTimeLayout_Reference_1 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.HeaderImage");
            this.Tab_Control_Main = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage12 = new Janus.Windows.UI.Tab.UITabPage();
            this.ms_Grid = new MS_Control.Controls.MS_GridX();
            this.mS_GridX_Setting1 = new MS_Control.Controls.MS_GridX_Setting();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mS_Panel1 = new MS_Control.Controls.MS_Panel();
            this.NzReport = new MS_Control.Controls.MS_Button_GridX();
            this.NzDateFrom = new MS_Control.Tarikh.MS_Tarikh_TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.uiTabPage14 = new Janus.Windows.UI.Tab.UITabPage();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).BeginInit();
            this.Tab_Control_Main.SuspendLayout();
            this.uiTabPage12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ms_Grid)).BeginInit();
            this.mS_GridX_Setting1.SuspendLayout();
            this.mS_Panel1.SuspendLayout();
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
            this.Tab_Control_Main.Size = new System.Drawing.Size(856, 450);
            this.Tab_Control_Main.TabIndex = 7;
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
            this.uiTabPage12.Controls.Add(this.mS_GridX_Setting1);
            this.uiTabPage12.Controls.Add(this.mS_Panel1);
            this.uiTabPage12.Location = new System.Drawing.Point(1, 1);
            this.uiTabPage12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uiTabPage12.Name = "uiTabPage12";
            this.uiTabPage12.PanelFormatStyle.Alpha = 70;
            this.uiTabPage12.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
            this.uiTabPage12.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
            this.uiTabPage12.PanelFormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical;
            this.uiTabPage12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiTabPage12.Size = new System.Drawing.Size(822, 448);
            this.uiTabPage12.TabStop = true;
            this.uiTabPage12.Text = "اطلاعات";
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
            ms_Grid_DesignTimeLayout.LayoutReferences.AddRange(new Janus.Windows.Common.Layouts.JanusLayoutReference[] {
            ms_Grid_DesignTimeLayout_Reference_0,
            ms_Grid_DesignTimeLayout_Reference_1});
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
            this.ms_Grid.Location = new System.Drawing.Point(0, 48);
            this.ms_Grid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.ms_Grid.Size = new System.Drawing.Size(822, 375);
            this.ms_Grid.TabIndex = 5;
            this.ms_Grid.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.ms_Grid.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ms_Grid.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.ms_Grid.TreeLineColor = System.Drawing.Color.Black;
            this.ms_Grid.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.ms_Grid.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.ms_Grid_ColumnButtonClick);
            // 
            // mS_GridX_Setting1
            // 
            this.mS_GridX_Setting1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mS_GridX_Setting1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mS_GridX_Setting1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1});
            this.mS_GridX_Setting1.Location = new System.Drawing.Point(0, 423);
            this.mS_GridX_Setting1.MS_BorderColor = System.Drawing.Color.DodgerBlue;
            this.mS_GridX_Setting1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_GridX_Setting1.MS_Color_End = System.Drawing.Color.PowderBlue;
            this.mS_GridX_Setting1.MS_Color_Start = System.Drawing.Color.AliceBlue;
            this.mS_GridX_Setting1.MS_GridX = this.ms_Grid;
            this.mS_GridX_Setting1.Name = "mS_GridX_Setting1";
            this.mS_GridX_Setting1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mS_GridX_Setting1.Size = new System.Drawing.Size(822, 25);
            this.mS_GridX_Setting1.TabIndex = 4;
            this.mS_GridX_Setting1.Text = "mS_GridX_Setting1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // mS_Panel1
            // 
            this.mS_Panel1.Controls.Add(this.NzReport);
            this.mS_Panel1.Controls.Add(this.NzDateFrom);
            this.mS_Panel1.Controls.Add(this.label8);
            this.mS_Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.mS_Panel1.Location = new System.Drawing.Point(0, 0);
            this.mS_Panel1.MS_BorderColor = System.Drawing.Color.Aqua;
            this.mS_Panel1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_Panel1.MS_Color_End = System.Drawing.Color.PowderBlue;
            this.mS_Panel1.MS_Color_Start = System.Drawing.Color.LightSkyBlue;
            this.mS_Panel1.Name = "mS_Panel1";
            this.mS_Panel1.Size = new System.Drawing.Size(822, 48);
            this.mS_Panel1.TabIndex = 722;
            // 
            // NzReport
            // 
            this.NzReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzReport.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NzReport.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NzReport.Image = ((System.Drawing.Image)(resources.GetObject("NzReport.Image")));
            this.NzReport.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.NzReport.Location = new System.Drawing.Point(518, 6);
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
            this.NzReport.TabIndex = 758;
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
            this.NzDateFrom.Location = new System.Drawing.Point(653, 10);
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
            this.NzDateFrom.TabIndex = 757;
            this.NzDateFrom.Text = "//";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(762, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 23);
            this.label8.TabIndex = 759;
            this.label8.Text = "از تاریخ :";
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
            this.uiTabPage14.Size = new System.Drawing.Size(766, 448);
            this.uiTabPage14.TabStop = true;
            this.uiTabPage14.Text = "پرسش و پاسخ";
            // 
            // FormProfitObject
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(856, 450);
            this.Controls.Add(this.Tab_Control_Main);
            this.Name = "FormProfitObject";
            this.Text = "سود و زیان کالا/خدمات";
            this.Shown += new System.EventHandler(this.FormProfitObject_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).EndInit();
            this.Tab_Control_Main.ResumeLayout(false);
            this.uiTabPage12.ResumeLayout(false);
            this.uiTabPage12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ms_Grid)).EndInit();
            this.mS_GridX_Setting1.ResumeLayout(false);
            this.mS_GridX_Setting1.PerformLayout();
            this.mS_Panel1.ResumeLayout(false);
            this.mS_Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.UI.Tab.UITab Tab_Control_Main;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage12;
        private MS_Control.Controls.MS_GridX ms_Grid;
        private MS_Control.Controls.MS_GridX_Setting mS_GridX_Setting1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage14;
        private MS_Control.Controls.MS_Panel mS_Panel1;
        private MS_Control.Controls.MS_Button_GridX NzReport;
        private MS_Control.Tarikh.MS_Tarikh_TextBox NzDateFrom;
        private System.Windows.Forms.Label label8;
    }
}