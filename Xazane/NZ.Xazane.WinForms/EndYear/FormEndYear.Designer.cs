
namespace NZ.Xazane.WinForms.EndYear
{
    partial class FormEndYear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEndYear));
            Janus.Windows.GridEX.GridEXLayout NzGrid_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_0_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.ButtonImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_0_Reference_1 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.HeaderImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_0_Reference_2 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.ButtonImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_0_Reference_3 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.HeaderImage");
            Janus.Windows.GridEX.GridEXLayout NzGrid_Layout_1 = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_1_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.ButtonImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_1_Reference_1 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.HeaderImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_1_Reference_2 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.ButtonImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_1_Reference_3 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.HeaderImage");
            Janus.Windows.GridEX.GridEXLayout NzGrid_Layout_2 = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_2_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.ButtonImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_2_Reference_1 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.HeaderImage");
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.NzYears = new NZ.General.WinForms.Component.NzYearComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NzTransfer = new MS_Control.Controls.MS_Button_GridX();
            this.label1 = new System.Windows.Forms.Label();
            this.NzGrid = new MS_Control.Controls.MS_GridX();
            this.mS_GridX_Setting2 = new MS_Control.Controls.MS_GridX_Setting();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mS_Notify1 = new MS_Control.Controls.MS_Notify();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NzGrid)).BeginInit();
            this.mS_GridX_Setting2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiGroupBox1.BorderColor = System.Drawing.Color.SteelBlue;
            this.uiGroupBox1.Controls.Add(this.NzYears);
            this.uiGroupBox1.Controls.Add(this.label3);
            this.uiGroupBox1.Controls.Add(this.NzTransfer);
            this.uiGroupBox1.Controls.Add(this.label1);
            this.uiGroupBox1.ImageAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.uiGroupBox1.ImageSize = new System.Drawing.Size(24, 24);
            this.uiGroupBox1.Location = new System.Drawing.Point(9, 3);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiGroupBox1.Size = new System.Drawing.Size(930, 124);
            this.uiGroupBox1.TabIndex = 2;
            this.uiGroupBox1.UseThemes = false;
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.VS2005;
            // 
            // NzYears
            // 
            this.NzYears.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.NzYears.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzYears.HoverMode = Janus.Windows.EditControls.HoverMode.Highlight;
            this.NzYears.Location = new System.Drawing.Point(194, 36);
            this.NzYears.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzYears.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzYears.MS_Change_Border_Color_On_Enter = false;
            this.NzYears.MS_Change_Color_On_Enter = true;
            this.NzYears.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.NzYears.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NzYears.MS_Exit_By_Down = false;
            this.NzYears.MS_Exit_By_Enter = true;
            this.NzYears.MS_Exit_By_Up = false;
            this.NzYears.MS_Last_Control = null;
            this.NzYears.MS_Next_Control = null;
            this.NzYears.Name = "NzYears";
            this.NzYears.Size = new System.Drawing.Size(89, 27);
            this.NzYears.TabIndex = 3;
            this.NzYears.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center;
            this.NzYears.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(452, 13);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(472, 108);
            this.label3.TabIndex = 80;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // NzTransfer
            // 
            this.NzTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzTransfer.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NzTransfer.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.NzTransfer.Image = ((System.Drawing.Image)(resources.GetObject("NzTransfer.Image")));
            this.NzTransfer.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.NzTransfer.Location = new System.Drawing.Point(6, 32);
            this.NzTransfer.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzTransfer.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzTransfer.MS_Change_Border_Color_On_Enter = false;
            this.NzTransfer.MS_Change_Color_On_Enter = false;
            this.NzTransfer.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.NzTransfer.MS_Enter_Color = System.Drawing.Color.Empty;
            this.NzTransfer.Name = "NzTransfer";
            this.NzTransfer.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.NzTransfer.Office2007CustomColor = System.Drawing.Color.LightBlue;
            this.NzTransfer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzTransfer.ShowFocusRectangle = false;
            this.NzTransfer.Size = new System.Drawing.Size(177, 33);
            this.NzTransfer.TabIndex = 0;
            this.NzTransfer.Text = "انتقال به سال مالی مقصد";
            this.NzTransfer.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.NzTransfer.UseThemes = false;
            this.NzTransfer.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.NzTransfer.WordWrap = false;
            this.NzTransfer.Click += new System.EventHandler(this.NzTransfer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
            this.label1.Location = new System.Drawing.Point(194, 12);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 81;
            this.label1.Text = "سال مالی مقصد";
            // 
            // NzGrid
            // 
            this.NzGrid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.NzGrid.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.True;
            this.NzGrid.AlternatingColors = true;
            this.NzGrid.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.NzGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NzGrid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NzGrid.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
            this.NzGrid.ColumnAutoResize = true;
            this.NzGrid.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet;
            this.NzGrid.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NzGrid.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
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
            this.NzGrid.Location = new System.Drawing.Point(0, 131);
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
            this.NzGrid.Size = new System.Drawing.Size(947, 314);
            this.NzGrid.TabIndex = 729;
            this.NzGrid.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.NzGrid.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzGrid.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.NzGrid.TreeLineColor = System.Drawing.Color.Black;
            this.NzGrid.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // mS_GridX_Setting2
            // 
            this.mS_GridX_Setting2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mS_GridX_Setting2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mS_GridX_Setting2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3});
            this.mS_GridX_Setting2.Location = new System.Drawing.Point(0, 444);
            this.mS_GridX_Setting2.MS_BorderColor = System.Drawing.Color.DodgerBlue;
            this.mS_GridX_Setting2.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_GridX_Setting2.MS_Color_End = System.Drawing.Color.PowderBlue;
            this.mS_GridX_Setting2.MS_Color_Start = System.Drawing.Color.AliceBlue;
            this.mS_GridX_Setting2.MS_GridX = this.NzGrid;
            this.mS_GridX_Setting2.Name = "mS_GridX_Setting2";
            this.mS_GridX_Setting2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mS_GridX_Setting2.Size = new System.Drawing.Size(947, 25);
            this.mS_GridX_Setting2.TabIndex = 730;
            this.mS_GridX_Setting2.Text = "mS_GridX_Setting2";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // FormEndYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 469);
            this.Controls.Add(this.NzGrid);
            this.Controls.Add(this.mS_GridX_Setting2);
            this.Controls.Add(this.uiGroupBox1);
            this.Font = new System.Drawing.Font("IRANSans(Small)", 12F);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FormEndYear";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "انتقال مانده حساب اشخاص به سال بعد";
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NzGrid)).EndInit();
            this.mS_GridX_Setting2.ResumeLayout(false);
            this.mS_GridX_Setting2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.Label label3;
        private MS_Control.Controls.MS_Button_GridX NzTransfer;
        private System.Windows.Forms.Label label1;
        private General.WinForms.Component.NzYearComboBox NzYears;
        private MS_Control.Controls.MS_GridX NzGrid;
        private MS_Control.Controls.MS_GridX_Setting mS_GridX_Setting2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private MS_Control.Controls.MS_Notify mS_Notify1;
    }
}