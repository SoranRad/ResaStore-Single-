namespace Nz.Anbar.WinForms.Report
{
    partial class FormObjectProfit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormObjectProfit));
            Janus.Windows.GridEX.GridEXLayout ms_Grid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.Common.Layouts.JanusLayoutReference ms_Grid_DesignTimeLayout_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.ButtonImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference ms_Grid_DesignTimeLayout_Reference_1 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.HeaderImage");
            this.Tab_Control_Main = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage12 = new Janus.Windows.UI.Tab.UITabPage();
            this.ms_Grid = new MS_Control.Controls.MS_GridX();
            this.mS_GridX_Setting1 = new MS_Control.Controls.MS_GridX_Setting();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.uiTabPage14 = new Janus.Windows.UI.Tab.UITabPage();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).BeginInit();
            this.Tab_Control_Main.SuspendLayout();
            this.uiTabPage12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ms_Grid)).BeginInit();
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
            this.Tab_Control_Main.Size = new System.Drawing.Size(866, 491);
            this.Tab_Control_Main.TabIndex = 4;
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
            this.uiTabPage12.Location = new System.Drawing.Point(1, 1);
            this.uiTabPage12.Name = "uiTabPage12";
            this.uiTabPage12.PanelFormatStyle.Alpha = 70;
            this.uiTabPage12.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
            this.uiTabPage12.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
            this.uiTabPage12.PanelFormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical;
            this.uiTabPage12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiTabPage12.Size = new System.Drawing.Size(832, 489);
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
            this.ms_Grid.Location = new System.Drawing.Point(0, 0);
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
            this.ms_Grid.Size = new System.Drawing.Size(832, 464);
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
            this.mS_GridX_Setting1.Location = new System.Drawing.Point(0, 464);
            this.mS_GridX_Setting1.MS_BorderColor = System.Drawing.Color.DodgerBlue;
            this.mS_GridX_Setting1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_GridX_Setting1.MS_Color_End = System.Drawing.Color.PowderBlue;
            this.mS_GridX_Setting1.MS_Color_Start = System.Drawing.Color.AliceBlue;
            this.mS_GridX_Setting1.MS_GridX = this.ms_Grid;
            this.mS_GridX_Setting1.Name = "mS_GridX_Setting1";
            this.mS_GridX_Setting1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mS_GridX_Setting1.Size = new System.Drawing.Size(832, 25);
            this.mS_GridX_Setting1.TabIndex = 4;
            this.mS_GridX_Setting1.Text = "mS_GridX_Setting1";
            this.mS_GridX_Setting1.MS_On_Print_Clicked += new System.EventHandler(this.mS_GridX_Setting1_MS_On_Print_Clicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            this.uiTabPage14.Size = new System.Drawing.Size(846, 447);
            this.uiTabPage14.TabStop = true;
            this.uiTabPage14.Text = "پرسش و پاسخ";
            // 
            // FormObjectProfit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(866, 491);
            this.Controls.Add(this.Tab_Control_Main);
            this.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormObjectProfit";
            this.Text = " سود و زیان کالا / خدمات";
            this.Shown += new System.EventHandler(this.FormObjectProfit_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).EndInit();
            this.Tab_Control_Main.ResumeLayout(false);
            this.uiTabPage12.ResumeLayout(false);
            this.uiTabPage12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ms_Grid)).EndInit();
            this.mS_GridX_Setting1.ResumeLayout(false);
            this.mS_GridX_Setting1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.UI.Tab.UITab Tab_Control_Main;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage12;
        private MS_Control.Controls.MS_GridX ms_Grid;
        private MS_Control.Controls.MS_GridX_Setting mS_GridX_Setting1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage14;
    }
}