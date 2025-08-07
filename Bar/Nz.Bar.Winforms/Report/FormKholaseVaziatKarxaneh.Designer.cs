namespace Nz.Bar.Winforms.Report
{
	partial class FormKholaseVaziatKarxaneh
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
			Janus.Windows.GridEX.GridEXLayout NzGrid_Layout_0 = new Janus.Windows.GridEX.GridEXLayout();
			Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_0_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.ButtonImage");
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKholaseVaziatKarxaneh));
			Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_0_Reference_1 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.HeaderImage");
			Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_0_Reference_2 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.ButtonImage");
			Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_0_Reference_3 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.HeaderImage");
			Janus.Windows.GridEX.GridEXLayout NzGrid_Layout_1 = new Janus.Windows.GridEX.GridEXLayout();
			Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_1_Reference_0 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.ButtonImage");
			Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_1_Reference_1 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column1.HeaderImage");
			Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_1_Reference_2 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.ButtonImage");
			Janus.Windows.Common.Layouts.JanusLayoutReference NzGrid_Layout_1_Reference_3 = new Janus.Windows.Common.Layouts.JanusLayoutReference("GridEXLayoutData.RootTable.Columns.Column2.HeaderImage");
			Janus.Windows.GridEX.GridEXLayout NzGrid_Layout_2 = new Janus.Windows.GridEX.GridEXLayout();
			this.NzGrid = new MS_Control.Controls.MS_GridX();
			this.mS_GridX_Setting2 = new MS_Control.Controls.MS_GridX_Setting();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.mS_Panel1 = new MS_Control.Controls.MS_Panel();
			this.ms_Save = new MS_Control.Controls.MS_Button_GridX();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.NzDateTo = new MS_Control.Tarikh.MS_Tarikh_TextBox();
			this.NzDateFrom = new MS_Control.Tarikh.MS_Tarikh_TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.NzGroup = new NZ.General.WinForms.Component.NzPeopleGroup();
			((System.ComponentModel.ISupportInitialize)(this.NzGrid)).BeginInit();
			this.mS_GridX_Setting2.SuspendLayout();
			this.mS_Panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// NzGrid
			// 
			this.NzGrid.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.NzGrid.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.True;
			this.NzGrid.AlternatingColors = true;
			this.NzGrid.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.NzGrid.BackColor = System.Drawing.Color.WhiteSmoke;
			this.NzGrid.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
			this.NzGrid.ColumnAutoResize = true;
			this.NzGrid.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet;
			this.NzGrid.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.NzGrid.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
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
			NzGrid_Layout_2.LayoutString = resources.GetString("NzGrid_Layout_2.LayoutString");
			this.NzGrid.Layouts.AddRange(new Janus.Windows.GridEX.GridEXLayout[] {
            NzGrid_Layout_0,
            NzGrid_Layout_1,
            NzGrid_Layout_2});
			this.NzGrid.Location = new System.Drawing.Point(0, 46);
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
			this.NzGrid.Size = new System.Drawing.Size(1292, 667);
			this.NzGrid.TabIndex = 729;
			this.NzGrid.TotalRow = Janus.Windows.GridEX.InheritableBoolean.True;
			this.NzGrid.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzGrid.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.NzGrid.TreeLineColor = System.Drawing.Color.Black;
			this.NzGrid.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			this.NzGrid.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.NzGrid_RowDoubleClick);
			// 
			// mS_GridX_Setting2
			// 
			this.mS_GridX_Setting2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.mS_GridX_Setting2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.mS_GridX_Setting2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3});
			this.mS_GridX_Setting2.Location = new System.Drawing.Point(0, 713);
			this.mS_GridX_Setting2.MS_BorderColor = System.Drawing.Color.DodgerBlue;
			this.mS_GridX_Setting2.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.mS_GridX_Setting2.MS_Color_End = System.Drawing.Color.PowderBlue;
			this.mS_GridX_Setting2.MS_Color_Start = System.Drawing.Color.AliceBlue;
			this.mS_GridX_Setting2.MS_GridX = this.NzGrid;
			this.mS_GridX_Setting2.Name = "mS_GridX_Setting2";
			this.mS_GridX_Setting2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.mS_GridX_Setting2.Size = new System.Drawing.Size(1292, 25);
			this.mS_GridX_Setting2.TabIndex = 731;
			this.mS_GridX_Setting2.Text = "mS_GridX_Setting2";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// mS_Panel1
			// 
			this.mS_Panel1.Controls.Add(this.NzGroup);
			this.mS_Panel1.Controls.Add(this.label3);
			this.mS_Panel1.Controls.Add(this.ms_Save);
			this.mS_Panel1.Controls.Add(this.label2);
			this.mS_Panel1.Controls.Add(this.label1);
			this.mS_Panel1.Controls.Add(this.NzDateTo);
			this.mS_Panel1.Controls.Add(this.NzDateFrom);
			this.mS_Panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.mS_Panel1.Location = new System.Drawing.Point(0, 0);
			this.mS_Panel1.MS_BorderColor = System.Drawing.Color.Aqua;
			this.mS_Panel1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.mS_Panel1.MS_Color_End = System.Drawing.Color.SkyBlue;
			this.mS_Panel1.MS_Color_Start = System.Drawing.Color.AliceBlue;
			this.mS_Panel1.Name = "mS_Panel1";
			this.mS_Panel1.Size = new System.Drawing.Size(1292, 46);
			this.mS_Panel1.TabIndex = 730;
			// 
			// ms_Save
			// 
			this.ms_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.ms_Save.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ms_Save.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ms_Save.Image = ((System.Drawing.Image)(resources.GetObject("ms_Save.Image")));
			this.ms_Save.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
			this.ms_Save.Location = new System.Drawing.Point(439, 8);
			this.ms_Save.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.ms_Save.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.ms_Save.MS_Change_Border_Color_On_Enter = false;
			this.ms_Save.MS_Change_Color_On_Enter = false;
			this.ms_Save.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.ms_Save.MS_Enter_Color = System.Drawing.Color.Empty;
			this.ms_Save.Name = "ms_Save";
			this.ms_Save.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
			this.ms_Save.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
			this.ms_Save.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ms_Save.ShowFocusRectangle = false;
			this.ms_Save.Size = new System.Drawing.Size(103, 30);
			this.ms_Save.TabIndex = 766;
			this.ms_Save.Text = "نمایش ";
			this.ms_Save.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
			this.ms_Save.UseThemes = false;
			this.ms_Save.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.ms_Save.WordWrap = false;
			this.ms_Save.Click += new System.EventHandler(this.ms_Save_Click);
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(660, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 23);
			this.label2.TabIndex = 764;
			this.label2.Text = "تا تاریخ :";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(836, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 23);
			this.label1.TabIndex = 765;
			this.label1.Text = "از تاریخ :";
			// 
			// NzDateTo
			// 
			this.NzDateTo.AllowInternalTab = false;
			this.NzDateTo.AllowResizeDropDown = false;
			this.NzDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzDateTo.AutoHeight = true;
			this.NzDateTo.BackColor = System.Drawing.Color.White;
			this.NzDateTo.ControlSize = new System.Drawing.Size(0, 0);
			this.NzDateTo.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.NzDateTo.DropSize = new System.Drawing.Size(0, 0);
			this.NzDateTo.Location = new System.Drawing.Point(553, 10);
			this.NzDateTo.MinimumSize = new System.Drawing.Size(99, 27);
			this.NzDateTo.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzDateTo.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzDateTo.MS_Change_Border_Color_On_Enter = true;
			this.NzDateTo.MS_Change_Color_On_Enter = true;
			this.NzDateTo.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NzDateTo.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzDateTo.MS_Exit_By_Down = true;
			this.NzDateTo.MS_Exit_By_Enter = true;
			this.NzDateTo.MS_Exit_By_Up = true;
			this.NzDateTo.MS_Last_Control = null;
			this.NzDateTo.MS_Next_Control = null;
			this.NzDateTo.MS_Separation = '/';
			this.NzDateTo.MS_Tarikh = null;
			this.NzDateTo.Name = "NzDateTo";
			this.NzDateTo.ReadOnly = false;
			this.NzDateTo.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.NzDateTo.Size = new System.Drawing.Size(107, 27);
			this.NzDateTo.TabIndex = 1;
			this.NzDateTo.Text = "//";
			// 
			// NzDateFrom
			// 
			this.NzDateFrom.AllowInternalTab = false;
			this.NzDateFrom.AllowResizeDropDown = false;
			this.NzDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzDateFrom.AutoHeight = true;
			this.NzDateFrom.BackColor = System.Drawing.Color.White;
			this.NzDateFrom.ControlSize = new System.Drawing.Size(0, 0);
			this.NzDateFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.NzDateFrom.DropSize = new System.Drawing.Size(0, 0);
			this.NzDateFrom.Location = new System.Drawing.Point(729, 10);
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
			this.NzDateFrom.Size = new System.Drawing.Size(107, 27);
			this.NzDateFrom.TabIndex = 0;
			this.NzDateFrom.Text = "//";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(1143, 12);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(137, 23);
			this.label3.TabIndex = 767;
			this.label3.Text = "گروه حساب کارخانجات :";
			// 
			// NzGroup
			// 
			this.NzGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzGroup.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
			this.NzGroup.DropSize = new System.Drawing.Size(239, 29);
			this.NzGroup.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NzGroup.Location = new System.Drawing.Point(898, 9);
			this.NzGroup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.NzGroup.MS_Auto_Popup = false;
			this.NzGroup.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzGroup.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzGroup.MS_CaptureFocus = false;
			this.NzGroup.MS_Change_Border_Color_On_Enter = true;
			this.NzGroup.MS_Change_Color_On_Enter = true;
			this.NzGroup.MS_Drop_Direction = MS_Control.TSDD.KindShow.Right;
			this.NzGroup.MS_DropDownSizeMode = MS_Control.TSDD.SizeMode.Control_Size;
			this.NzGroup.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NzGroup.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzGroup.MS_Exit_By_Down = true;
			this.NzGroup.MS_Exit_By_Enter = true;
			this.NzGroup.MS_Exit_By_Up = true;
			this.NzGroup.MS_Last_Control = null;
			this.NzGroup.MS_Next_Control = null;
			this.NzGroup.Name = "NzGroup";
			this.NzGroup.Office2007CustomColor = System.Drawing.Color.SkyBlue;
			this.NzGroup.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NzGroup.Size = new System.Drawing.Size(239, 29);
			this.NzGroup.TabIndex = 768;
			this.NzGroup.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			this.NzGroup.MS_On_Row_Selected += new System.EventHandler<MS_Control.TSDD.On_Selected>(this.NzGroup_MS_On_Row_Selected);
			// 
			// FormKholaseVaziatKarxaneh
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1292, 738);
			this.Controls.Add(this.NzGrid);
			this.Controls.Add(this.mS_GridX_Setting2);
			this.Controls.Add(this.mS_Panel1);
			this.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FormKholaseVaziatKarxaneh";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Text = "خلاصه وضعیت کارخانجات";
			((System.ComponentModel.ISupportInitialize)(this.NzGrid)).EndInit();
			this.mS_GridX_Setting2.ResumeLayout(false);
			this.mS_GridX_Setting2.PerformLayout();
			this.mS_Panel1.ResumeLayout(false);
			this.mS_Panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MS_Control.Controls.MS_GridX NzGrid;
		private MS_Control.Controls.MS_GridX_Setting mS_GridX_Setting2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private MS_Control.Controls.MS_Panel mS_Panel1;
		private MS_Control.Controls.MS_Button_GridX ms_Save;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private MS_Control.Tarikh.MS_Tarikh_TextBox NzDateTo;
		private MS_Control.Tarikh.MS_Tarikh_TextBox NzDateFrom;
		private System.Windows.Forms.Label label3;
		private NZ.General.WinForms.Component.NzPeopleGroup NzGroup;
	}
}