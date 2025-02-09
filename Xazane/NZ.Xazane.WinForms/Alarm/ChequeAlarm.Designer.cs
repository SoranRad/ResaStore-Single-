namespace NZ.Xazane.WinForms.Alarm
{
    partial class ChequeAlarm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Janus.Windows.GridEX.GridEXLayout NzGridFuture_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGridFuture_Layout_0_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.ButtonImage");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChequeAlarm));
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGridFuture_Layout_0_Reference_1 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.HeaderImage");
            this.NzTabs = new Janus.Windows.UI.Tab.UITab();
            this.NzTabAlarm = new Janus.Windows.UI.Tab.UITabPage();
            this.NzGridFuture = new MS_Control.Controls.MS_GridX();
            this.mS_Tool_Strip2 = new MS_Control.Controls.MS_Tool_Strip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.NzFutureDays = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.NzRefresh = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.NzTabs)).BeginInit();
            this.NzTabs.SuspendLayout();
            this.NzTabAlarm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NzGridFuture)).BeginInit();
            this.mS_Tool_Strip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NzTabs
            // 
            this.NzTabs.BackColor = System.Drawing.Color.Transparent;
            this.NzTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NzTabs.FirstTabOffset = 10;
            this.NzTabs.Font = new System.Drawing.Font("IRANSans(Small)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NzTabs.Location = new System.Drawing.Point(0, 0);
            this.NzTabs.Name = "NzTabs";
            this.NzTabs.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.NzTabs.Office2007CustomColor = System.Drawing.Color.AntiqueWhite;
            this.NzTabs.PageBorder = Janus.Windows.UI.Tab.PageBorder.None;
            this.NzTabs.PanelFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzTabs.ShowFocusRectangle = false;
            this.NzTabs.Size = new System.Drawing.Size(961, 387);
            this.NzTabs.TabIndex = 711;
            this.NzTabs.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.NzTabAlarm});
            this.NzTabs.TabsStateStyles.DisabledFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NzTabs.TabsStateStyles.DisabledFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NzTabs.TabsStateStyles.FormatStyle.BackColor = System.Drawing.Color.LightBlue;
            this.NzTabs.TabsStateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.Gold;
            this.NzTabs.TabsStateStyles.SelectedFormatStyle.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
            this.NzTabs.UseThemes = false;
            this.NzTabs.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
            // 
            // NzTabAlarm
            // 
            this.NzTabAlarm.Controls.Add(this.NzGridFuture);
            this.NzTabAlarm.Controls.Add(this.mS_Tool_Strip2);
            this.NzTabAlarm.Location = new System.Drawing.Point(0, 23);
            this.NzTabAlarm.Name = "NzTabAlarm";
            this.NzTabAlarm.Size = new System.Drawing.Size(961, 364);
            this.NzTabAlarm.TabStop = true;
            this.NzTabAlarm.Text = "چکـهای روز";
            // 
            // NzGridFuture
            // 
            this.NzGridFuture.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.NzGridFuture.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.True;
            this.NzGridFuture.AlternatingColors = true;
            this.NzGridFuture.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NzGridFuture.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NzGridFuture.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
            this.NzGridFuture.ColumnAutoResize = true;
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
            this.NzGridFuture.FrozenColumns = 2;
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
            this.NzGridFuture.Location = new System.Drawing.Point(0, 35);
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
            this.NzGridFuture.Size = new System.Drawing.Size(961, 329);
            this.NzGridFuture.TabIndex = 7;
            this.NzGridFuture.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.NzGridFuture.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzGridFuture.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.NzGridFuture.TreeLineColor = System.Drawing.Color.Black;
            this.NzGridFuture.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // mS_Tool_Strip2
            // 
            this.mS_Tool_Strip2.Font = new System.Drawing.Font("IRANSans", 11F);
            this.mS_Tool_Strip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mS_Tool_Strip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mS_Tool_Strip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.NzFutureDays,
            this.toolStripLabel2,
            this.NzRefresh});
            this.mS_Tool_Strip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mS_Tool_Strip2.Location = new System.Drawing.Point(0, 0);
            this.mS_Tool_Strip2.MS_BorderColor = System.Drawing.Color.SkyBlue;
            this.mS_Tool_Strip2.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_Tool_Strip2.MS_Color_End = System.Drawing.Color.SkyBlue;
            this.mS_Tool_Strip2.MS_Color_Start = System.Drawing.Color.LightBlue;
            this.mS_Tool_Strip2.Name = "mS_Tool_Strip2";
            this.mS_Tool_Strip2.Padding = new System.Windows.Forms.Padding(5, 3, 5, 2);
            this.mS_Tool_Strip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mS_Tool_Strip2.Size = new System.Drawing.Size(961, 35);
            this.mS_Tool_Strip2.TabIndex = 6;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(135, 27);
            this.toolStripLabel1.Text = "مشـاهده چـک های ";
            // 
            // NzFutureDays
            // 
            this.NzFutureDays.AcceptsReturn = true;
            this.NzFutureDays.AcceptsTab = true;
            this.NzFutureDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NzFutureDays.Font = new System.Drawing.Font("IRANSans", 10F);
            this.NzFutureDays.Margin = new System.Windows.Forms.Padding(1, 0, -6, 0);
            this.NzFutureDays.MaxLength = 4;
            this.NzFutureDays.Name = "NzFutureDays";
            this.NzFutureDays.Size = new System.Drawing.Size(50, 30);
            this.NzFutureDays.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Margin = new System.Windows.Forms.Padding(0, 1, -5, 2);
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(63, 27);
            this.toolStripLabel2.Text = "روز آینده";
            // 
            // NzRefresh
            // 
            this.NzRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NzRefresh.Image = ((System.Drawing.Image)(resources.GetObject("NzRefresh.Image")));
            this.NzRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.NzRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NzRefresh.Name = "NzRefresh";
            this.NzRefresh.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.NzRefresh.Size = new System.Drawing.Size(40, 27);
            this.NzRefresh.Text = "مشـاهده لیست";
            this.NzRefresh.Click += new System.EventHandler(this.NzRefresh_Click);
            // 
            // ChequeAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.NzTabs);
            this.Name = "ChequeAlarm";
            this.Size = new System.Drawing.Size(961, 387);
            ((System.ComponentModel.ISupportInitialize)(this.NzTabs)).EndInit();
            this.NzTabs.ResumeLayout(false);
            this.NzTabAlarm.ResumeLayout(false);
            this.NzTabAlarm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NzGridFuture)).EndInit();
            this.mS_Tool_Strip2.ResumeLayout(false);
            this.mS_Tool_Strip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.UI.Tab.UITab NzTabs;
        private Janus.Windows.UI.Tab.UITabPage NzTabAlarm;
        private MS_Control.Controls.MS_GridX NzGridFuture;
        private MS_Control.Controls.MS_Tool_Strip mS_Tool_Strip2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox NzFutureDays;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripButton NzRefresh;
    }
}
