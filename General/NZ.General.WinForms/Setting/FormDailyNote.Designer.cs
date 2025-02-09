namespace NZ.General.WinForms.Setting
{
    partial class FormDailyNote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDailyNote));
            Janus.Windows.GridEX.GridEXLayout NzGrid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_DesignTimeLayout_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.ButtonImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_DesignTimeLayout_Reference_1 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.HeaderImage");
            this.NzGrid = new MS_Control.Controls.MS_GridX();
            this.NzCurrentDate = new MS_Control.Tarikh.MS_Tatikh_View();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mS_Menu1 = new MS_Control.Controls.MS_Menu();
            this.NzSummaryNote = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.NzGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.mS_Menu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // NzGrid
            // 
            this.NzGrid.AllowAddNew = Janus.Windows.GridEX.InheritableBoolean.True;
            this.NzGrid.AllowDelete = Janus.Windows.GridEX.InheritableBoolean.True;
            this.NzGrid.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.True;
            this.NzGrid.AlternatingColors = true;
            this.NzGrid.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.NzGrid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NzGrid.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
            this.NzGrid.BuiltInTextsData = resources.GetString("NzGrid.BuiltInTextsData");
            this.NzGrid.CellSelectionMode = Janus.Windows.GridEX.CellSelectionMode.SingleCell;
            this.NzGrid.ColumnAutoResize = true;
            this.NzGrid.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet;
            this.NzGrid.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NzGrid.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            NzGrid_DesignTimeLayout_Reference_0.Instance = ((object)(resources.GetObject("NzGrid_DesignTimeLayout_Reference_0.Instance")));
            NzGrid_DesignTimeLayout_Reference_1.Instance = ((object)(resources.GetObject("NzGrid_DesignTimeLayout_Reference_1.Instance")));
            NzGrid_DesignTimeLayout.LayoutReferences.AddRange(new Janus.Windows.Common.Layouts.JanusLayoutReference[] {
            NzGrid_DesignTimeLayout_Reference_0,
            NzGrid_DesignTimeLayout_Reference_1});
            NzGrid_DesignTimeLayout.LayoutString = resources.GetString("NzGrid_DesignTimeLayout.LayoutString");
            this.NzGrid.DesignTimeLayout = NzGrid_DesignTimeLayout;
            this.NzGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NzGrid.DynamicFiltering = true;
            this.NzGrid.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.NextCell;
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
            this.NzGrid.Location = new System.Drawing.Point(0, 40);
            this.NzGrid.Name = "NzGrid";
            this.NzGrid.NewRowPosition = Janus.Windows.GridEX.NewRowPosition.BottomRow;
            this.NzGrid.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
            this.NzGrid.Office2007CustomColor = System.Drawing.SystemColors.HotTrack;
            this.NzGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzGrid.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
            this.NzGrid.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.NzGrid.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.NzGrid.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.White;
            this.NzGrid.SelectOnExpand = false;
            this.NzGrid.Size = new System.Drawing.Size(563, 281);
            this.NzGrid.TabIndex = 728;
            this.NzGrid.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzGrid.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.NzGrid.TreeLineColor = System.Drawing.Color.Black;
            this.NzGrid.UpdateMode = Janus.Windows.GridEX.UpdateMode.CellUpdate;
            this.NzGrid.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.NzGrid.RecordUpdated += new System.EventHandler(this.NzGrid_RecordUpdated);
            this.NzGrid.RecordAdded += new System.EventHandler(this.NzGrid_RecordAdded);
            this.NzGrid.AddingRecord += new System.ComponentModel.CancelEventHandler(this.NzGrid_AddingRecord);
            this.NzGrid.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.mS_GridX1_ColumnButtonClick);
            // 
            // NzCurrentDate
            // 
            this.NzCurrentDate.BackColor = System.Drawing.Color.White;
            this.NzCurrentDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NzCurrentDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NzCurrentDate.Font = new System.Drawing.Font("IRANSans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NzCurrentDate.Location = new System.Drawing.Point(0, 0);
            this.NzCurrentDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NzCurrentDate.Name = "NzCurrentDate";
            this.NzCurrentDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzCurrentDate.Size = new System.Drawing.Size(209, 281);
            this.NzCurrentDate.TabIndex = 727;
            this.NzCurrentDate.NzDateChanged += new System.EventHandler(this.mS_Tatikh_View1_NzDateChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NzCurrentDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(563, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 281);
            this.panel1.TabIndex = 729;
            // 
            // mS_Menu1
            // 
            this.mS_Menu1.AutoSize = false;
            this.mS_Menu1.Font = new System.Drawing.Font("IRANSans(Small) Medium", 12F);
            this.mS_Menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NzSummaryNote});
            this.mS_Menu1.Location = new System.Drawing.Point(0, 0);
            this.mS_Menu1.MS_BorderColor = System.Drawing.Color.CornflowerBlue;
            this.mS_Menu1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_Menu1.MS_Color_End = System.Drawing.Color.LightSteelBlue;
            this.mS_Menu1.MS_Color_Start = System.Drawing.Color.AliceBlue;
            this.mS_Menu1.Name = "mS_Menu1";
            this.mS_Menu1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mS_Menu1.Size = new System.Drawing.Size(772, 40);
            this.mS_Menu1.TabIndex = 730;
            this.mS_Menu1.Text = "mS_Menu1";
            // 
            // NzSummaryNote
            // 
            this.NzSummaryNote.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.NzSummaryNote.Font = new System.Drawing.Font("IRANSans(Small) Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NzSummaryNote.Image = ((System.Drawing.Image)(resources.GetObject("NzSummaryNote.Image")));
            this.NzSummaryNote.Margin = new System.Windows.Forms.Padding(15, 0, 2, 0);
            this.NzSummaryNote.Name = "NzSummaryNote";
            this.NzSummaryNote.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.NzSummaryNote.Size = new System.Drawing.Size(95, 36);
            this.NzSummaryNote.Tag = "1";
            this.NzSummaryNote.Text = "در یک نگاه";
            this.NzSummaryNote.Click += new System.EventHandler(this.NzSummaryNote_Click);
            // 
            // FormDailyNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 321);
            this.Controls.Add(this.NzGrid);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mS_Menu1);
            this.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDailyNote";
            this.Text = "یادداشت روزانه";
            this.Load += new System.EventHandler(this.FormDailyNote_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormDailyNote_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.NzGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.mS_Menu1.ResumeLayout(false);
            this.mS_Menu1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MS_Control.Controls.MS_GridX NzGrid;
        private MS_Control.Tarikh.MS_Tatikh_View NzCurrentDate;
        private System.Windows.Forms.Panel panel1;
        private MS_Control.Controls.MS_Menu mS_Menu1;
        private System.Windows.Forms.ToolStripMenuItem NzSummaryNote;
    }
}