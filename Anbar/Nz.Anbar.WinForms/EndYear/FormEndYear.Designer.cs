
namespace Nz.Anbar.WinForms.EndYear
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
            Janus.Windows.GridEX.GridEXLayout ms_Grid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.Common.Layouts.JanusLayoutReference ms_Grid_DesignTimeLayout_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.ButtonImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference ms_Grid_DesignTimeLayout_Reference_1 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.HeaderImage");
            this.NzYears = new NZ.General.WinForms.Component.NzYearComboBox();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NzTransfer = new MS_Control.Controls.MS_Button_GridX();
            this.label1 = new System.Windows.Forms.Label();
            this.ms_Grid = new MS_Control.Controls.MS_GridX();
            this.mS_GridX_Setting1 = new MS_Control.Controls.MS_GridX_Setting();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.NzRefresh = new System.Windows.Forms.ToolStripButton();
            this.mS_Notify1 = new MS_Control.Controls.MS_Notify();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ms_Grid)).BeginInit();
            this.mS_GridX_Setting1.SuspendLayout();
            this.SuspendLayout();
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
            this.NzYears.TabIndex = 1;
            this.NzYears.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center;
            this.NzYears.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiGroupBox1.BorderColor = System.Drawing.Color.SteelBlue;
            this.uiGroupBox1.Controls.Add(this.label3);
            this.uiGroupBox1.Controls.Add(this.NzTransfer);
            this.uiGroupBox1.Controls.Add(this.NzYears);
            this.uiGroupBox1.Controls.Add(this.label1);
            this.uiGroupBox1.ImageAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.uiGroupBox1.ImageSize = new System.Drawing.Size(24, 24);
            this.uiGroupBox1.Location = new System.Drawing.Point(6, -1);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiGroupBox1.Size = new System.Drawing.Size(862, 88);
            this.uiGroupBox1.TabIndex = 1;
            this.uiGroupBox1.UseThemes = false;
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.VS2005;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
            this.label3.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label3.Location = new System.Drawing.Point(485, 13);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(371, 70);
            this.label3.TabIndex = 80;
            this.label3.Text = "کاربر گرامی به موارد زیر دقت فرمایید\r\nدر لیست زیر کالاهایی که انتخاب می کنید \r\nبه" +
    " موجودی اول دوره سال بعد انتقال داده می شود\r\n";
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
            // ms_Grid
            // 
            this.ms_Grid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.ms_Grid.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.True;
            this.ms_Grid.AlternatingColors = true;
            this.ms_Grid.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ms_Grid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.ms_Grid.Location = new System.Drawing.Point(0, 92);
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
            this.ms_Grid.Size = new System.Drawing.Size(874, 300);
            this.ms_Grid.TabIndex = 0;
            this.ms_Grid.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.ms_Grid.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ms_Grid.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.ms_Grid.TreeLineColor = System.Drawing.Color.Black;
            this.ms_Grid.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // mS_GridX_Setting1
            // 
            this.mS_GridX_Setting1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mS_GridX_Setting1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mS_GridX_Setting1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.NzRefresh});
            this.mS_GridX_Setting1.Location = new System.Drawing.Point(0, 391);
            this.mS_GridX_Setting1.MS_BorderColor = System.Drawing.Color.DodgerBlue;
            this.mS_GridX_Setting1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_GridX_Setting1.MS_Color_End = System.Drawing.Color.PowderBlue;
            this.mS_GridX_Setting1.MS_Color_Start = System.Drawing.Color.AliceBlue;
            this.mS_GridX_Setting1.MS_GridX = this.ms_Grid;
            this.mS_GridX_Setting1.Name = "mS_GridX_Setting1";
            this.mS_GridX_Setting1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mS_GridX_Setting1.Size = new System.Drawing.Size(874, 25);
            this.mS_GridX_Setting1.TabIndex = 6;
            this.mS_GridX_Setting1.Text = "mS_GridX_Setting1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // NzRefresh
            // 
            this.NzRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NzRefresh.Image = ((System.Drawing.Image)(resources.GetObject("NzRefresh.Image")));
            this.NzRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NzRefresh.Name = "NzRefresh";
            this.NzRefresh.Size = new System.Drawing.Size(23, 22);
            this.NzRefresh.Text = "بروز رسانی لیست";
            this.NzRefresh.Click += new System.EventHandler(this.NzRefresh_Click);
            // 
            // FormEndYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 416);
            this.Controls.Add(this.ms_Grid);
            this.Controls.Add(this.mS_GridX_Setting1);
            this.Controls.Add(this.uiGroupBox1);
            this.Font = new System.Drawing.Font("IRANSans(Small)", 12F);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "FormEndYear";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.Text = "انتقال مانده انبار به سال بعد";
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ms_Grid)).EndInit();
            this.mS_GridX_Setting1.ResumeLayout(false);
            this.mS_GridX_Setting1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NZ.General.WinForms.Component.NzYearComboBox NzYears;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.Label label3;
        private MS_Control.Controls.MS_Button_GridX NzTransfer;
        private System.Windows.Forms.Label label1;
        private MS_Control.Controls.MS_GridX ms_Grid;
        private MS_Control.Controls.MS_GridX_Setting mS_GridX_Setting1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton NzRefresh;
        private MS_Control.Controls.MS_Notify mS_Notify1;
    }
}