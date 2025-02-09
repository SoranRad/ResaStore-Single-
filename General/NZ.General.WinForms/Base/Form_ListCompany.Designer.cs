namespace NZ.General.WinForms.Base
{
    partial class Form_ListCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ListCompany));
            Janus.Windows.GridEX.GridEXLayout mS_GridX1_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
            Janus.Windows.Common.Layouts.JanusLayoutReference mS_GridX1_DesignTimeLayout_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.ButtonImage");
            Janus.Windows.Common.Layouts.JanusLayoutReference mS_GridX1_DesignTimeLayout_Reference_1 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column0.HeaderImage");
            this.mS_GridX1 = new MS_Control.Controls.MS_GridX();
            this.mS_GridX_Setting1 = new MS_Control.Controls.MS_GridX_Setting();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.mS_GridX1)).BeginInit();
            this.mS_GridX_Setting1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mS_GridX1
            // 
            this.mS_GridX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
            this.mS_GridX1.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.True;
            this.mS_GridX1.AlternatingColors = true;
            this.mS_GridX1.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mS_GridX1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mS_GridX1.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
            this.mS_GridX1.BuiltInTextsData = resources.GetString("mS_GridX1.BuiltInTextsData");
            this.mS_GridX1.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet;
            this.mS_GridX1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.mS_GridX1.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
            mS_GridX1_DesignTimeLayout_Reference_0.Instance = ((object)(resources.GetObject("mS_GridX1_DesignTimeLayout_Reference_0.Instance")));
            mS_GridX1_DesignTimeLayout_Reference_1.Instance = ((object)(resources.GetObject("mS_GridX1_DesignTimeLayout_Reference_1.Instance")));
            mS_GridX1_DesignTimeLayout.LayoutReferences.AddRange(new Janus.Windows.Common.Layouts.JanusLayoutReference[] {
            mS_GridX1_DesignTimeLayout_Reference_0,
            mS_GridX1_DesignTimeLayout_Reference_1});
            mS_GridX1_DesignTimeLayout.LayoutString = resources.GetString("mS_GridX1_DesignTimeLayout.LayoutString");
            this.mS_GridX1.DesignTimeLayout = mS_GridX1_DesignTimeLayout;
            this.mS_GridX1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mS_GridX1.DynamicFiltering = true;
            this.mS_GridX1.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
            this.mS_GridX1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
            this.mS_GridX1.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
            this.mS_GridX1.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mS_GridX1.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
            this.mS_GridX1.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle;
            this.mS_GridX1.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid;
            this.mS_GridX1.Font = new System.Drawing.Font("IRANSans(Small)", 12F);
            this.mS_GridX1.FrozenColumns = 4;
            this.mS_GridX1.GridLineColor = System.Drawing.Color.Black;
            this.mS_GridX1.GridLines = Janus.Windows.GridEX.GridLines.Vertical;
            this.mS_GridX1.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
            this.mS_GridX1.GroupByBoxVisible = false;
            this.mS_GridX1.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.mS_GridX1.HeaderFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.mS_GridX1.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
            this.mS_GridX1.Location = new System.Drawing.Point(0, 0);
            this.mS_GridX1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mS_GridX1.Name = "mS_GridX1";
            this.mS_GridX1.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
            this.mS_GridX1.Office2007CustomColor = System.Drawing.SystemColors.HotTrack;
            this.mS_GridX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mS_GridX1.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
            this.mS_GridX1.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.mS_GridX1.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.mS_GridX1.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.White;
            this.mS_GridX1.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelectionSameTable;
            this.mS_GridX1.SelectOnExpand = false;
            this.mS_GridX1.Size = new System.Drawing.Size(771, 292);
            this.mS_GridX1.TabIndex = 727;
            this.mS_GridX1.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.mS_GridX1.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
            this.mS_GridX1.TreeLineColor = System.Drawing.Color.Black;
            this.mS_GridX1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            this.mS_GridX1.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.mS_GridX1_ColumnButtonClick);
            // 
            // mS_GridX_Setting1
            // 
            this.mS_GridX_Setting1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mS_GridX_Setting1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mS_GridX_Setting1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1});
            this.mS_GridX_Setting1.Location = new System.Drawing.Point(0, 292);
            this.mS_GridX_Setting1.MS_BorderColor = System.Drawing.Color.DodgerBlue;
            this.mS_GridX_Setting1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_GridX_Setting1.MS_Color_End = System.Drawing.Color.PowderBlue;
            this.mS_GridX_Setting1.MS_Color_Start = System.Drawing.Color.AliceBlue;
            this.mS_GridX_Setting1.MS_GridX = this.mS_GridX1;
            this.mS_GridX_Setting1.Name = "mS_GridX_Setting1";
            this.mS_GridX_Setting1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mS_GridX_Setting1.Size = new System.Drawing.Size(771, 25);
            this.mS_GridX_Setting1.TabIndex = 726;
            this.mS_GridX_Setting1.Text = "mS_GridX_Setting1";
            this.mS_GridX_Setting1.MS_On_Print_Clicked += new System.EventHandler(this.mS_GridX_Setting1_MS_On_Print_Clicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Form_ListCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 317);
            this.Controls.Add(this.mS_GridX1);
            this.Controls.Add(this.mS_GridX_Setting1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_ListCompany";
            this.Text = "مـشخـصات کـسب و کــار";
            ((System.ComponentModel.ISupportInitialize)(this.mS_GridX1)).EndInit();
            this.mS_GridX_Setting1.ResumeLayout(false);
            this.mS_GridX_Setting1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MS_Control.Controls.MS_GridX mS_GridX1;
        private MS_Control.Controls.MS_GridX_Setting mS_GridX_Setting1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}