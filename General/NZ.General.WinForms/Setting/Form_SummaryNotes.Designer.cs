namespace NZ.General.WinForms.Setting
{
    partial class Form_SummaryNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SummaryNotes));
            Janus.Windows.GridEX.GridEXLayout NzGrid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            this.mS_Menu1 = new MS_Control.Controls.MS_Menu();
            this.NzYearList = new System.Windows.Forms.ToolStripMenuItem();
            this.NzGrid = new MS_Control.Controls.MS_GridX();
            this.mS_Menu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NzGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // mS_Menu1
            // 
            this.mS_Menu1.AutoSize = false;
            this.mS_Menu1.Font = new System.Drawing.Font("IRANSans(Small) Medium", 12F);
            this.mS_Menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NzYearList});
            this.mS_Menu1.Location = new System.Drawing.Point(0, 0);
            this.mS_Menu1.MS_BorderColor = System.Drawing.Color.CornflowerBlue;
            this.mS_Menu1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_Menu1.MS_Color_End = System.Drawing.Color.LightSteelBlue;
            this.mS_Menu1.MS_Color_Start = System.Drawing.Color.AliceBlue;
            this.mS_Menu1.Name = "mS_Menu1";
            this.mS_Menu1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mS_Menu1.Size = new System.Drawing.Size(724, 40);
            this.mS_Menu1.TabIndex = 731;
            this.mS_Menu1.Text = "mS_Menu1";
            // 
            // NzYearList
            // 
            this.NzYearList.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.NzYearList.Font = new System.Drawing.Font("IRANSans(Small) Medium", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.NzYearList.Image = global::MS_Resource.GlobalResources.Negin__26_;
            this.NzYearList.Margin = new System.Windows.Forms.Padding(15, 0, 2, 0);
            this.NzYearList.Name = "NzYearList";
            this.NzYearList.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.NzYearList.Size = new System.Drawing.Size(106, 36);
            this.NzYearList.Tag = "1";
            this.NzYearList.Text = "انتـخاب سال";
            // 
            // NzGrid
            // 
            this.NzGrid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.NzGrid.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.True;
            this.NzGrid.AlternatingColors = true;
            this.NzGrid.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NzGrid.BackColor = System.Drawing.Color.WhiteSmoke;
            this.NzGrid.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
            this.NzGrid.BuiltInTextsData = resources.GetString("NzGrid.BuiltInTextsData");
            this.NzGrid.ColumnAutoResize = true;
            this.NzGrid.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet;
            this.NzGrid.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NzGrid.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            NzGrid_DesignTimeLayout.LayoutString = resources.GetString("NzGrid_DesignTimeLayout.LayoutString");
            this.NzGrid.DesignTimeLayout = NzGrid_DesignTimeLayout;
            this.NzGrid.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.NzGrid.Location = new System.Drawing.Point(0, 40);
            this.NzGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.NzGrid.Size = new System.Drawing.Size(724, 477);
            this.NzGrid.TabIndex = 732;
            this.NzGrid.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
            this.NzGrid.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzGrid.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.NzGrid.TreeLineColor = System.Drawing.Color.Black;
            this.NzGrid.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // Form_SummaryNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 517);
            this.Controls.Add(this.NzGrid);
            this.Controls.Add(this.mS_Menu1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_SummaryNotes";
            this.Text = "کلیه یادداشت های سال";
            this.Shown += new System.EventHandler(this.Form_SummaryNotes_Shown);
            this.mS_Menu1.ResumeLayout(false);
            this.mS_Menu1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NzGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MS_Control.Controls.MS_Menu mS_Menu1;
        private System.Windows.Forms.ToolStripMenuItem NzYearList;
        private MS_Control.Controls.MS_GridX NzGrid;
    }
}