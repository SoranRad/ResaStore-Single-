namespace SmsBan.UI
{
	partial class FormQueueMonitor
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQueueMonitor));
			Janus.Windows.GridEX.GridEXLayout gridQueue_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
			Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem1 = new Janus.Windows.EditControls.UIComboBoxItem();
			Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem2 = new Janus.Windows.EditControls.UIComboBoxItem();
			Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem3 = new Janus.Windows.EditControls.UIComboBoxItem();
			Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem4 = new Janus.Windows.EditControls.UIComboBoxItem();
			Janus.Windows.GridEX.GridEXLayout NsGridArchives_DesignTimeLayout = new Janus.Windows.GridEX.GridEXLayout();
			this.NzTabInfo = new Janus.Windows.UI.Tab.UITab();
			this.toolStrip = new MS_Control.Controls.MS_Tool_Strip();
			this.sep1 = new System.Windows.Forms.ToolStripSeparator();
			this.sep3 = new System.Windows.Forms.ToolStripSeparator();
			this.sep4 = new System.Windows.Forms.ToolStripSeparator();
			this.sep5 = new System.Windows.Forms.ToolStripSeparator();
			this.gridQueue = new MS_Control.Controls.MS_GridX();
			this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
			this.NsDateTo = new MS_Control.Tarikh.MS_Tarikh_TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.NsDateFrom = new MS_Control.Tarikh.MS_Tarikh_TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.NsState = new MS_Control.Controls.MS_ComboBox_Janus();
			this.NsCount = new MS_Control.Controls.MS_NumericTextBox();
			this.NsGridArchives = new MS_Control.Controls.MS_GridX();
			this.mS_GridX_Setting1 = new MS_Control.Controls.MS_GridX_Setting();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.mS_GridX_Setting2 = new MS_Control.Controls.MS_GridX_Setting();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.NzTab1 = new Janus.Windows.UI.Tab.UITabPage();
			this.NzTab2 = new Janus.Windows.UI.Tab.UITabPage();
			this.btnRefresh = new System.Windows.Forms.ToolStripButton();
			this.btnTop = new System.Windows.Forms.ToolStripButton();
			this.btnUp = new System.Windows.Forms.ToolStripButton();
			this.btnDown = new System.Windows.Forms.ToolStripButton();
			this.btnBottom = new System.Windows.Forms.ToolStripButton();
			this.btnCancel = new System.Windows.Forms.ToolStripButton();
			this.btnCancelAll = new System.Windows.Forms.ToolStripButton();
			this.btnPauseResume = new System.Windows.Forms.ToolStripButton();
			this.btnStatus = new System.Windows.Forms.ToolStripButton();
			this.NzReport = new MS_Control.Controls.MS_Button_GridX();
			((System.ComponentModel.ISupportInitialize)(this.NzTabInfo)).BeginInit();
			this.NzTabInfo.SuspendLayout();
			this.toolStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridQueue)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
			this.uiGroupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NsGridArchives)).BeginInit();
			this.mS_GridX_Setting1.SuspendLayout();
			this.mS_GridX_Setting2.SuspendLayout();
			this.NzTab1.SuspendLayout();
			this.NzTab2.SuspendLayout();
			this.SuspendLayout();
			// 
			// NzTabInfo
			// 
			this.NzTabInfo.BackColor = System.Drawing.Color.Transparent;
			this.NzTabInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.NzTabInfo.FirstTabOffset = 30;
			this.NzTabInfo.Location = new System.Drawing.Point(0, 29);
			this.NzTabInfo.MultiLine = true;
			this.NzTabInfo.Name = "NzTabInfo";
			this.NzTabInfo.Office2007CustomColor = System.Drawing.Color.Transparent;
			this.NzTabInfo.ShowFocusRectangle = false;
			this.NzTabInfo.Size = new System.Drawing.Size(1048, 499);
			this.NzTabInfo.TabIndex = 1;
			this.NzTabInfo.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.NzTab1,
            this.NzTab2});
			this.NzTabInfo.TabsStateStyles.DisabledFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.NzTabInfo.TabsStateStyles.DisabledFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.NzTabInfo.TabsStateStyles.FormatStyle.BackColor = System.Drawing.Color.PowderBlue;
			this.NzTabInfo.TabsStateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.Gold;
			this.NzTabInfo.TabStripFormatStyle.FontSize = 9F;
			this.NzTabInfo.UseThemes = false;
			this.NzTabInfo.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
			// 
			// toolStrip
			// 
			this.toolStrip.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh,
            this.sep1,
            this.btnTop,
            this.btnUp,
            this.btnDown,
            this.btnBottom,
            this.sep3,
            this.btnCancel,
            this.btnCancelAll,
            this.sep4,
            this.btnPauseResume,
            this.sep5,
            this.btnStatus});
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.MS_BorderColor = System.Drawing.Color.Silver;
			this.toolStrip.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.toolStrip.MS_Color_End = System.Drawing.Color.SkyBlue;
			this.toolStrip.MS_Color_Start = System.Drawing.Color.AliceBlue;
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.toolStrip.Size = new System.Drawing.Size(1048, 29);
			this.toolStrip.TabIndex = 2;
			this.toolStrip.Text = "toolStrip";
			// 
			// sep1
			// 
			this.sep1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.sep1.Name = "sep1";
			this.sep1.Size = new System.Drawing.Size(6, 23);
			// 
			// sep3
			// 
			this.sep3.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.sep3.Name = "sep3";
			this.sep3.Size = new System.Drawing.Size(6, 23);
			// 
			// sep4
			// 
			this.sep4.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.sep4.Name = "sep4";
			this.sep4.Size = new System.Drawing.Size(6, 23);
			// 
			// sep5
			// 
			this.sep5.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.sep5.Name = "sep5";
			this.sep5.Size = new System.Drawing.Size(6, 23);
			// 
			// gridQueue
			// 
			this.gridQueue.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridQueue.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridQueue.AlternatingColors = true;
			this.gridQueue.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.gridQueue.BackColor = System.Drawing.Color.WhiteSmoke;
			this.gridQueue.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
			this.gridQueue.BuiltInTextsData = resources.GetString("gridQueue.BuiltInTextsData");
			this.gridQueue.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet;
			this.gridQueue.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.gridQueue.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
			gridQueue_DesignTimeLayout.LayoutString = resources.GetString("gridQueue_DesignTimeLayout.LayoutString");
			this.gridQueue.DesignTimeLayout = gridQueue_DesignTimeLayout;
			this.gridQueue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridQueue.DynamicFiltering = true;
			this.gridQueue.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridQueue.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.gridQueue.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
			this.gridQueue.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.gridQueue.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
			this.gridQueue.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle;
			this.gridQueue.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid;
			this.gridQueue.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.gridQueue.FrozenColumns = 2;
			this.gridQueue.GridLineColor = System.Drawing.Color.Black;
			this.gridQueue.GridLines = Janus.Windows.GridEX.GridLines.Vertical;
			this.gridQueue.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
			this.gridQueue.GroupByBoxVisible = false;
			this.gridQueue.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.gridQueue.HeaderFormatStyle.ForeColor = System.Drawing.Color.Black;
			this.gridQueue.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
			this.gridQueue.Location = new System.Drawing.Point(0, 0);
			this.gridQueue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.gridQueue.Name = "gridQueue";
			this.gridQueue.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
			this.gridQueue.Office2007CustomColor = System.Drawing.SystemColors.HotTrack;
			this.gridQueue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.gridQueue.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
			this.gridQueue.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.gridQueue.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black;
			this.gridQueue.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.gridQueue.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelectionSameTable;
			this.gridQueue.SelectOnExpand = false;
			this.gridQueue.Size = new System.Drawing.Size(1046, 442);
			this.gridQueue.TabIndex = 721;
			this.gridQueue.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.gridQueue.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.gridQueue.TreeLineColor = System.Drawing.Color.Black;
			this.gridQueue.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			// 
			// uiGroupBox2
			// 
			this.uiGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.uiGroupBox2.BackColor = System.Drawing.Color.Transparent;
			this.uiGroupBox2.BorderColor = System.Drawing.Color.LightBlue;
			this.uiGroupBox2.Controls.Add(this.NsCount);
			this.uiGroupBox2.Controls.Add(this.NsState);
			this.uiGroupBox2.Controls.Add(this.label3);
			this.uiGroupBox2.Controls.Add(this.NsDateTo);
			this.uiGroupBox2.Controls.Add(this.NzReport);
			this.uiGroupBox2.Controls.Add(this.label2);
			this.uiGroupBox2.Controls.Add(this.label1);
			this.uiGroupBox2.Controls.Add(this.NsDateFrom);
			this.uiGroupBox2.Controls.Add(this.label8);
			this.uiGroupBox2.Location = new System.Drawing.Point(7, 2);
			this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(2);
			this.uiGroupBox2.Name = "uiGroupBox2";
			this.uiGroupBox2.Size = new System.Drawing.Size(1032, 57);
			this.uiGroupBox2.TabIndex = 0;
			// 
			// NsDateTo
			// 
			this.NsDateTo.AllowInternalTab = false;
			this.NsDateTo.AllowResizeDropDown = false;
			this.NsDateTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsDateTo.AutoHeight = false;
			this.NsDateTo.BackColor = System.Drawing.Color.White;
			this.NsDateTo.ControlSize = new System.Drawing.Size(0, 0);
			this.NsDateTo.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.NsDateTo.DropSize = new System.Drawing.Size(0, 0);
			this.NsDateTo.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NsDateTo.Location = new System.Drawing.Point(268, 19);
			this.NsDateTo.MinimumSize = new System.Drawing.Size(99, 27);
			this.NsDateTo.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsDateTo.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsDateTo.MS_Change_Border_Color_On_Enter = true;
			this.NsDateTo.MS_Change_Color_On_Enter = true;
			this.NsDateTo.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsDateTo.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsDateTo.MS_Exit_By_Down = true;
			this.NsDateTo.MS_Exit_By_Enter = true;
			this.NsDateTo.MS_Exit_By_Up = true;
			this.NsDateTo.MS_Last_Control = null;
			this.NsDateTo.MS_Next_Control = null;
			this.NsDateTo.MS_Separation = '/';
			this.NsDateTo.MS_Tarikh = null;
			this.NsDateTo.Name = "NsDateTo";
			this.NsDateTo.ReadOnly = false;
			this.NsDateTo.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.NsDateTo.Size = new System.Drawing.Size(109, 27);
			this.NsDateTo.TabIndex = 3;
			this.NsDateTo.Text = "//";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label2.Location = new System.Drawing.Point(970, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 23);
			this.label2.TabIndex = 756;
			this.label2.Text = "وضعیت :";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label1.Location = new System.Drawing.Point(377, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 23);
			this.label1.TabIndex = 756;
			this.label1.Text = "تا تاریخ :";
			// 
			// NsDateFrom
			// 
			this.NsDateFrom.AllowInternalTab = false;
			this.NsDateFrom.AllowResizeDropDown = false;
			this.NsDateFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsDateFrom.AutoHeight = false;
			this.NsDateFrom.BackColor = System.Drawing.Color.White;
			this.NsDateFrom.ControlSize = new System.Drawing.Size(0, 0);
			this.NsDateFrom.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.NsDateFrom.DropSize = new System.Drawing.Size(0, 0);
			this.NsDateFrom.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NsDateFrom.Location = new System.Drawing.Point(457, 19);
			this.NsDateFrom.MinimumSize = new System.Drawing.Size(99, 27);
			this.NsDateFrom.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsDateFrom.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsDateFrom.MS_Change_Border_Color_On_Enter = true;
			this.NsDateFrom.MS_Change_Color_On_Enter = true;
			this.NsDateFrom.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsDateFrom.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsDateFrom.MS_Exit_By_Down = true;
			this.NsDateFrom.MS_Exit_By_Enter = true;
			this.NsDateFrom.MS_Exit_By_Up = true;
			this.NsDateFrom.MS_Last_Control = null;
			this.NsDateFrom.MS_Next_Control = null;
			this.NsDateFrom.MS_Separation = '/';
			this.NsDateFrom.MS_Tarikh = null;
			this.NsDateFrom.Name = "NsDateFrom";
			this.NsDateFrom.ReadOnly = false;
			this.NsDateFrom.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.NsDateFrom.Size = new System.Drawing.Size(109, 27);
			this.NsDateFrom.TabIndex = 2;
			this.NsDateFrom.Text = "//";
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label8.Location = new System.Drawing.Point(566, 21);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(56, 23);
			this.label8.TabIndex = 756;
			this.label8.Text = "از تاریخ :";
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label3.Location = new System.Drawing.Point(719, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(86, 23);
			this.label3.TabIndex = 757;
			this.label3.Text = "تعداد پیام ها :";
			// 
			// NsState
			// 
			this.NsState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsState.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
			this.NsState.Cursor = System.Windows.Forms.Cursors.Hand;
			uiComboBoxItem1.FormatStyle.Alpha = 0;
			uiComboBoxItem1.IsSeparator = false;
			uiComboBoxItem1.Text = "همه";
			uiComboBoxItem2.FormatStyle.Alpha = 0;
			uiComboBoxItem2.IsSeparator = false;
			uiComboBoxItem2.Text = "ارسال شده";
			uiComboBoxItem3.FormatStyle.Alpha = 0;
			uiComboBoxItem3.IsSeparator = false;
			uiComboBoxItem3.Text = "ارسال نشده";
			uiComboBoxItem4.FormatStyle.Alpha = 0;
			uiComboBoxItem4.IsSeparator = false;
			uiComboBoxItem4.Text = "لغو شده";
			this.NsState.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            uiComboBoxItem1,
            uiComboBoxItem2,
            uiComboBoxItem3,
            uiComboBoxItem4});
			this.NsState.Location = new System.Drawing.Point(822, 18);
			this.NsState.Margin = new System.Windows.Forms.Padding(5);
			this.NsState.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsState.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsState.MS_Change_Border_Color_On_Enter = true;
			this.NsState.MS_Change_Color_On_Enter = true;
			this.NsState.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsState.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsState.MS_Exit_By_Down = true;
			this.NsState.MS_Exit_By_Enter = true;
			this.NsState.MS_Exit_By_Up = true;
			this.NsState.MS_Last_Control = null;
			this.NsState.MS_Next_Control = null;
			this.NsState.Name = "NsState";
			this.NsState.Size = new System.Drawing.Size(147, 29);
			this.NsState.TabIndex = 0;
			this.NsState.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			// 
			// NsCount
			// 
			this.NsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsCount.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsCount.DigitGroup = false;
			this.NsCount.Location = new System.Drawing.Point(635, 18);
			this.NsCount.MaxLength = 11;
			this.NsCount.Mode = MS_Control.Controls.MS_NumericTextBox.TextBoxMode.IntNumber;
			this.NsCount.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsCount.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsCount.MS_Change_Border_Color_On_Enter = true;
			this.NsCount.MS_Change_Color_On_Enter = true;
			this.NsCount.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsCount.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsCount.MS_Exit_By_Down = true;
			this.NsCount.MS_Exit_By_Enter = true;
			this.NsCount.MS_Exit_By_Up = true;
			this.NsCount.MS_Is_Negative = false;
			this.NsCount.MS_Last_Control = null;
			this.NsCount.MS_Next_Control = null;
			this.NsCount.Name = "NsCount";
			this.NsCount.Size = new System.Drawing.Size(83, 29);
			this.NsCount.TabIndex = 1;
			this.NsCount.Text = "500";
			this.NsCount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
			this.NsCount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			// 
			// NsGridArchives
			// 
			this.NsGridArchives.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.NsGridArchives.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.True;
			this.NsGridArchives.AlternatingColors = true;
			this.NsGridArchives.AlternatingRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.NsGridArchives.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NsGridArchives.BackColor = System.Drawing.Color.WhiteSmoke;
			this.NsGridArchives.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
			this.NsGridArchives.BuiltInTextsData = resources.GetString("NsGridArchives.BuiltInTextsData");
			this.NsGridArchives.ColumnSetNavigation = Janus.Windows.GridEX.ColumnSetNavigation.ColumnSet;
			this.NsGridArchives.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.NsGridArchives.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
			NsGridArchives_DesignTimeLayout.LayoutString = resources.GetString("NsGridArchives_DesignTimeLayout.LayoutString");
			this.NsGridArchives.DesignTimeLayout = NsGridArchives_DesignTimeLayout;
			this.NsGridArchives.DynamicFiltering = true;
			this.NsGridArchives.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.NsGridArchives.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.NsGridArchives.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
			this.NsGridArchives.FilterRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsGridArchives.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
			this.NsGridArchives.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle;
			this.NsGridArchives.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid;
			this.NsGridArchives.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NsGridArchives.FrozenColumns = 2;
			this.NsGridArchives.GridLineColor = System.Drawing.Color.Black;
			this.NsGridArchives.GridLines = Janus.Windows.GridEX.GridLines.Vertical;
			this.NsGridArchives.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
			this.NsGridArchives.GroupByBoxVisible = false;
			this.NsGridArchives.HeaderFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.NsGridArchives.HeaderFormatStyle.ForeColor = System.Drawing.Color.Black;
			this.NsGridArchives.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
			this.NsGridArchives.Location = new System.Drawing.Point(0, 66);
			this.NsGridArchives.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.NsGridArchives.Name = "NsGridArchives";
			this.NsGridArchives.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
			this.NsGridArchives.Office2007CustomColor = System.Drawing.SystemColors.HotTrack;
			this.NsGridArchives.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsGridArchives.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
			this.NsGridArchives.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.NsGridArchives.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black;
			this.NsGridArchives.SelectedInactiveFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.NsGridArchives.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelectionSameTable;
			this.NsGridArchives.SelectOnExpand = false;
			this.NsGridArchives.Size = new System.Drawing.Size(1046, 376);
			this.NsGridArchives.TabIndex = 722;
			this.NsGridArchives.TotalRowFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsGridArchives.TotalRowPosition = Janus.Windows.GridEX.TotalRowPosition.BottomFixed;
			this.NsGridArchives.TreeLineColor = System.Drawing.Color.Black;
			this.NsGridArchives.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			// 
			// mS_GridX_Setting1
			// 
			this.mS_GridX_Setting1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.mS_GridX_Setting1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.mS_GridX_Setting1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1});
			this.mS_GridX_Setting1.Location = new System.Drawing.Point(0, 441);
			this.mS_GridX_Setting1.MS_BorderColor = System.Drawing.Color.DodgerBlue;
			this.mS_GridX_Setting1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.mS_GridX_Setting1.MS_Color_End = System.Drawing.Color.PowderBlue;
			this.mS_GridX_Setting1.MS_Color_Start = System.Drawing.Color.AliceBlue;
			this.mS_GridX_Setting1.MS_GridX = this.NsGridArchives;
			this.mS_GridX_Setting1.Name = "mS_GridX_Setting1";
			this.mS_GridX_Setting1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.mS_GridX_Setting1.Size = new System.Drawing.Size(1046, 25);
			this.mS_GridX_Setting1.TabIndex = 723;
			this.mS_GridX_Setting1.Text = "mS_GridX_Setting1";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// mS_GridX_Setting2
			// 
			this.mS_GridX_Setting2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.mS_GridX_Setting2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.mS_GridX_Setting2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2});
			this.mS_GridX_Setting2.Location = new System.Drawing.Point(0, 442);
			this.mS_GridX_Setting2.MS_BorderColor = System.Drawing.Color.DodgerBlue;
			this.mS_GridX_Setting2.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.mS_GridX_Setting2.MS_Color_End = System.Drawing.Color.PowderBlue;
			this.mS_GridX_Setting2.MS_Color_Start = System.Drawing.Color.AliceBlue;
			this.mS_GridX_Setting2.MS_GridX = this.gridQueue;
			this.mS_GridX_Setting2.Name = "mS_GridX_Setting2";
			this.mS_GridX_Setting2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.mS_GridX_Setting2.Size = new System.Drawing.Size(1046, 25);
			this.mS_GridX_Setting2.TabIndex = 724;
			this.mS_GridX_Setting2.Text = "mS_GridX_Setting2";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// NzTab1
			// 
			this.NzTab1.Controls.Add(this.gridQueue);
			this.NzTab1.Controls.Add(this.mS_GridX_Setting2);
			this.NzTab1.Location = new System.Drawing.Point(1, 31);
			this.NzTab1.Name = "NzTab1";
			this.NzTab1.PanelFormatStyle.Alpha = 70;
			this.NzTab1.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
			this.NzTab1.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
			this.NzTab1.PanelFormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical;
			this.NzTab1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NzTab1.Size = new System.Drawing.Size(1046, 467);
			this.NzTab1.TabStop = true;
			this.NzTab1.Text = "صف ارسال";
			// 
			// NzTab2
			// 
			this.NzTab2.Controls.Add(this.NsGridArchives);
			this.NzTab2.Controls.Add(this.uiGroupBox2);
			this.NzTab2.Controls.Add(this.mS_GridX_Setting1);
			this.NzTab2.Location = new System.Drawing.Point(1, 31);
			this.NzTab2.Name = "NzTab2";
			this.NzTab2.PanelFormatStyle.Alpha = 70;
			this.NzTab2.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
			this.NzTab2.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
			this.NzTab2.PanelFormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical;
			this.NzTab2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NzTab2.Size = new System.Drawing.Size(1046, 466);
			this.NzTab2.TabStop = true;
			this.NzTab2.Text = "پیام های ارسال شده";
			// 
			// btnRefresh
			// 
			this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnRefresh.Image = global::SmsBan.Properties.Resources.refresh;
			this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnRefresh.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(23, 23);
			this.btnRefresh.Text = "به‌روزرسانی";
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnTop
			// 
			this.btnTop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnTop.Image = global::SmsBan.Properties.Resources.resultset_last;
			this.btnTop.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.btnTop.Name = "btnTop";
			this.btnTop.Size = new System.Drawing.Size(23, 23);
			this.btnTop.Text = "ابتدا";
			this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
			// 
			// btnUp
			// 
			this.btnUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnUp.Image = global::SmsBan.Properties.Resources.resultset_next;
			this.btnUp.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.btnUp.Name = "btnUp";
			this.btnUp.Size = new System.Drawing.Size(23, 23);
			this.btnUp.Text = "بالا";
			this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
			// 
			// btnDown
			// 
			this.btnDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnDown.Image = global::SmsBan.Properties.Resources.resultset_previous;
			this.btnDown.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.btnDown.Name = "btnDown";
			this.btnDown.Size = new System.Drawing.Size(23, 23);
			this.btnDown.Text = "پایین";
			this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
			// 
			// btnBottom
			// 
			this.btnBottom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnBottom.Image = global::SmsBan.Properties.Resources.resultset_first;
			this.btnBottom.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.btnBottom.Name = "btnBottom";
			this.btnBottom.Size = new System.Drawing.Size(23, 23);
			this.btnBottom.Text = "انتها";
			this.btnBottom.Click += new System.EventHandler(this.btnBottom_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnCancel.Image = global::SmsBan.Properties.Resources.Cancel2;
			this.btnCancel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(23, 23);
			this.btnCancel.Text = "لغو مورد";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnCancelAll
			// 
			this.btnCancelAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnCancelAll.Image = global::SmsBan.Properties.Resources.cancel;
			this.btnCancelAll.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.btnCancelAll.Name = "btnCancelAll";
			this.btnCancelAll.Size = new System.Drawing.Size(23, 23);
			this.btnCancelAll.Text = "لغو همه";
			this.btnCancelAll.Click += new System.EventHandler(this.btnCancelAll_Click);
			// 
			// btnPauseResume
			// 
			this.btnPauseResume.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnPauseResume.Image = global::SmsBan.Properties.Resources.Pause;
			this.btnPauseResume.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.btnPauseResume.Name = "btnPauseResume";
			this.btnPauseResume.Size = new System.Drawing.Size(23, 23);
			this.btnPauseResume.Text = "توقف ارسال";
			this.btnPauseResume.Click += new System.EventHandler(this.btnPauseResume_Click);
			// 
			// btnStatus
			// 
			this.btnStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.btnStatus.Image = global::SmsBan.Properties.Resources.information1;
			this.btnStatus.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
			this.btnStatus.Name = "btnStatus";
			this.btnStatus.Size = new System.Drawing.Size(23, 23);
			this.btnStatus.Text = "وضعیت مودم";
			this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
			// 
			// NzReport
			// 
			this.NzReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzReport.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NzReport.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NzReport.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NzReport.Image = ((System.Drawing.Image)(resources.GetObject("NzReport.Image")));
			this.NzReport.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
			this.NzReport.Location = new System.Drawing.Point(36, 15);
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
			this.NzReport.TabIndex = 4;
			this.NzReport.Text = "مشـاهده";
			this.NzReport.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
			this.NzReport.UseThemes = false;
			this.NzReport.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.NzReport.WordWrap = false;
			// 
			// FormQueueMonitor
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(1048, 528);
			this.Controls.Add(this.NzTabInfo);
			this.Controls.Add(this.toolStrip);
			this.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "FormQueueMonitor";
			this.Text = "صف ارسال پیامک";
			this.Shown += new System.EventHandler(this.FormQueueMonitor_Shown);
			((System.ComponentModel.ISupportInitialize)(this.NzTabInfo)).EndInit();
			this.NzTabInfo.ResumeLayout(false);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridQueue)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
			this.uiGroupBox2.ResumeLayout(false);
			this.uiGroupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NsGridArchives)).EndInit();
			this.mS_GridX_Setting1.ResumeLayout(false);
			this.mS_GridX_Setting1.PerformLayout();
			this.mS_GridX_Setting2.ResumeLayout(false);
			this.mS_GridX_Setting2.PerformLayout();
			this.NzTab1.ResumeLayout(false);
			this.NzTab1.PerformLayout();
			this.NzTab2.ResumeLayout(false);
			this.NzTab2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Janus.Windows.UI.Tab.UITab NzTabInfo;
		private Janus.Windows.UI.Tab.UITabPage NzTab1;
		private Janus.Windows.UI.Tab.UITabPage NzTab2;
		private MS_Control.Controls.MS_Tool_Strip toolStrip;
		private System.Windows.Forms.ToolStripButton btnRefresh;
		private System.Windows.Forms.ToolStripSeparator sep1;
		private System.Windows.Forms.ToolStripButton btnTop;
		private System.Windows.Forms.ToolStripButton btnUp;
		private System.Windows.Forms.ToolStripButton btnDown;
		private System.Windows.Forms.ToolStripButton btnBottom;
		private System.Windows.Forms.ToolStripSeparator sep3;
		private System.Windows.Forms.ToolStripButton btnCancel;
		private System.Windows.Forms.ToolStripButton btnCancelAll;
		private System.Windows.Forms.ToolStripSeparator sep4;
		private System.Windows.Forms.ToolStripButton btnPauseResume;
		private System.Windows.Forms.ToolStripSeparator sep5;
		private System.Windows.Forms.ToolStripButton btnStatus;
		private MS_Control.Controls.MS_GridX gridQueue;
		private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
		private MS_Control.Controls.MS_Button_GridX NzReport;
		private MS_Control.Tarikh.MS_Tarikh_TextBox NsDateTo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private MS_Control.Tarikh.MS_Tarikh_TextBox NsDateFrom;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label3;
		private MS_Control.Controls.MS_ComboBox_Janus NsState;
		private MS_Control.Controls.MS_NumericTextBox NsCount;
		private MS_Control.Controls.MS_GridX NsGridArchives;
		private MS_Control.Controls.MS_GridX_Setting mS_GridX_Setting1;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private MS_Control.Controls.MS_GridX_Setting mS_GridX_Setting2;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
	}
}