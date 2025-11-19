namespace Nz.Anbar.WinForms.App
{
	partial class Form_ReviewPishFactor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_ReviewPishFactor));
			Janus.Windows.GridEX.GridEXLayout ms_Grid_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
			Janus.Windows.Common.Layouts.JanusLayoutReference ms_Grid_DesignTimeLayout_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.ButtonImage");
			this.ms_Grid = new MS_Control.Controls.MS_GridX();
			((System.ComponentModel.ISupportInitialize)(this.ms_Grid)).BeginInit();
			this.SuspendLayout();
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
			ms_Grid_DesignTimeLayout.LayoutReferences.AddRange(new Janus.Windows.Common.Layouts.JanusLayoutReference[] {
            ms_Grid_DesignTimeLayout_Reference_0});
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
			this.ms_Grid.Font = new System.Drawing.Font("IRANSans(Small)", 12F);
			this.ms_Grid.FrozenColumns = 2;
			this.ms_Grid.GridLineColor = System.Drawing.Color.Black;
			this.ms_Grid.GridLines = Janus.Windows.GridEX.GridLines.Vertical;
			this.ms_Grid.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
			this.ms_Grid.GroupByBoxVisible = false;
			this.ms_Grid.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ms_Grid.HeaderFormatStyle.ForeColor = System.Drawing.Color.Black;
			this.ms_Grid.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
			this.ms_Grid.Location = new System.Drawing.Point(0, 0);
			this.ms_Grid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.ms_Grid.Name = "ms_Grid";
			this.ms_Grid.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
			this.ms_Grid.Office2007CustomColor = System.Drawing.SystemColors.HotTrack;
			this.ms_Grid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ms_Grid.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
			this.ms_Grid.SelectedFormatStyle.BackColor = System.Drawing.Color.Empty;
			this.ms_Grid.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black;
			this.ms_Grid.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.Empty;
			this.ms_Grid.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelectionSameTable;
			this.ms_Grid.SelectOnExpand = false;
			this.ms_Grid.Size = new System.Drawing.Size(490, 548);
			this.ms_Grid.TabIndex = 6;
			this.ms_Grid.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
			this.ms_Grid.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.ms_Grid.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.ms_Grid.TreeLineColor = System.Drawing.Color.Black;
			this.ms_Grid.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			this.ms_Grid.ColumnButtonClick += new Janus.Windows.GridEX.ColumnActionEventHandler(this.ms_Grid_ColumnButtonClick);
			// 
			// Form_ReviewPishFactor
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(490, 548);
			this.Controls.Add(this.ms_Grid);
			this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form_ReviewPishFactor";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "مرور پیش فاکتور";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.ms_Grid)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private MS_Control.Controls.MS_GridX ms_Grid;
	}
}