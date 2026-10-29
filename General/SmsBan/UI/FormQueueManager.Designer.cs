namespace SmsBan.UI
{
	partial class FormQueueManager
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQueueManager));
			this.toolStrip = new MS_Control.Controls.MS_Tool_Strip();
			this.btnRefresh = new System.Windows.Forms.ToolStripButton();
			this.sep1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnTop = new System.Windows.Forms.ToolStripButton();
			this.btnUp = new System.Windows.Forms.ToolStripButton();
			this.btnDown = new System.Windows.Forms.ToolStripButton();
			this.btnBottom = new System.Windows.Forms.ToolStripButton();
			this.sep2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnUrgent = new System.Windows.Forms.ToolStripButton();
			this.btnMedium = new System.Windows.Forms.ToolStripButton();
			this.btnNormal = new System.Windows.Forms.ToolStripButton();
			this.sep3 = new System.Windows.Forms.ToolStripSeparator();
			this.btnCancel = new System.Windows.Forms.ToolStripButton();
			this.btnCancelAll = new System.Windows.Forms.ToolStripButton();
			this.sep4 = new System.Windows.Forms.ToolStripSeparator();
			this.btnPauseResume = new System.Windows.Forms.ToolStripButton();
			this.sep5 = new System.Windows.Forms.ToolStripSeparator();
			this.btnStatus = new System.Windows.Forms.ToolStripButton();
			this.tabs = new Janus.Windows.UI.Tab.UITab();
			this.tabQueue = new Janus.Windows.UI.Tab.UITabPage();
			this.gridQueue = new MS_Control.Controls.MS_GridX();
			this.tabArchive = new Janus.Windows.UI.Tab.UITabPage();
			this.panelArchive = new MS_Control.Controls.MS_Panel();
			this.gridArchive = new MS_Control.Controls.MS_GridX();
			this.panelArchiveTop = new MS_Control.Controls.MS_Panel();
			this.lblArchiveStatus = new MS_Control.Controls.MS_Label();
			this.cmbArchiveStatus = new MS_Control.Controls.MS_ComboBox();
			this.btnRetry = new MS_Control.Controls.MS_Button();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tabs)).BeginInit();
			this.tabs.SuspendLayout();
			this.tabQueue.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridQueue)).BeginInit();
			this.tabArchive.SuspendLayout();
			this.panelArchive.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridArchive)).BeginInit();
			this.panelArchiveTop.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip
			// 
			this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh,
            this.sep1,
            this.btnTop,
            this.btnUp,
            this.btnDown,
            this.btnBottom,
            this.sep2,
            this.btnUrgent,
            this.btnMedium,
            this.btnNormal,
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
			this.toolStrip.MS_Color_End = System.Drawing.Color.PowderBlue;
			this.toolStrip.MS_Color_Start = System.Drawing.Color.AliceBlue;
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.toolStrip.Size = new System.Drawing.Size(1084, 25);
			this.toolStrip.TabIndex = 0;
			this.toolStrip.Text = "toolStrip";
			// 
			// btnRefresh
			// 
			this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(66, 22);
			this.btnRefresh.Text = "به‌روزرسانی";
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// sep1
			// 
			this.sep1.Name = "sep1";
			this.sep1.Size = new System.Drawing.Size(6, 25);
			// 
			// btnTop
			// 
			this.btnTop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnTop.Name = "btnTop";
			this.btnTop.Size = new System.Drawing.Size(31, 22);
			this.btnTop.Text = "ابتدا";
			this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
			// 
			// btnUp
			// 
			this.btnUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnUp.Name = "btnUp";
			this.btnUp.Size = new System.Drawing.Size(25, 22);
			this.btnUp.Text = "بالا";
			this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
			// 
			// btnDown
			// 
			this.btnDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnDown.Name = "btnDown";
			this.btnDown.Size = new System.Drawing.Size(34, 22);
			this.btnDown.Text = "پایین";
			this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
			// 
			// btnBottom
			// 
			this.btnBottom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnBottom.Name = "btnBottom";
			this.btnBottom.Size = new System.Drawing.Size(31, 22);
			this.btnBottom.Text = "انتها";
			this.btnBottom.Click += new System.EventHandler(this.btnBottom_Click);
			// 
			// sep2
			// 
			this.sep2.Name = "sep2";
			this.sep2.Size = new System.Drawing.Size(6, 25);
			// 
			// btnUrgent
			// 
			this.btnUrgent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnUrgent.Name = "btnUrgent";
			this.btnUrgent.Size = new System.Drawing.Size(53, 22);
			this.btnUrgent.Text = "فوری کن";
			this.btnUrgent.Click += new System.EventHandler(this.btnUrgent_Click);
			// 
			// btnMedium
			// 
			this.btnMedium.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnMedium.Name = "btnMedium";
			this.btnMedium.Size = new System.Drawing.Size(65, 22);
			this.btnMedium.Text = "متوسط کن";
			this.btnMedium.Click += new System.EventHandler(this.btnMedium_Click);
			// 
			// btnNormal
			// 
			this.btnNormal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnNormal.Name = "btnNormal";
			this.btnNormal.Size = new System.Drawing.Size(53, 22);
			this.btnNormal.Text = "عادی کن";
			this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
			// 
			// sep3
			// 
			this.sep3.Name = "sep3";
			this.sep3.Size = new System.Drawing.Size(6, 25);
			// 
			// btnCancel
			// 
			this.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(54, 22);
			this.btnCancel.Text = "لغو مورد";
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnCancelAll
			// 
			this.btnCancelAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnCancelAll.Name = "btnCancelAll";
			this.btnCancelAll.Size = new System.Drawing.Size(52, 22);
			this.btnCancelAll.Text = "لغو همه";
			this.btnCancelAll.Click += new System.EventHandler(this.btnCancelAll_Click);
			// 
			// sep4
			// 
			this.sep4.Name = "sep4";
			this.sep4.Size = new System.Drawing.Size(6, 25);
			// 
			// btnPauseResume
			// 
			this.btnPauseResume.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnPauseResume.Name = "btnPauseResume";
			this.btnPauseResume.Size = new System.Drawing.Size(70, 22);
			this.btnPauseResume.Text = "توقف ارسال";
			this.btnPauseResume.Click += new System.EventHandler(this.btnPauseResume_Click);
			// 
			// sep5
			// 
			this.sep5.Name = "sep5";
			this.sep5.Size = new System.Drawing.Size(6, 25);
			// 
			// btnStatus
			// 
			this.btnStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnStatus.Name = "btnStatus";
			this.btnStatus.Size = new System.Drawing.Size(80, 22);
			this.btnStatus.Text = "وضعیت مودم";
			this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
			// 
			// tabs
			// 
			this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabs.Font = new System.Drawing.Font("IRANSans(Small)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.tabs.Location = new System.Drawing.Point(0, 25);
			this.tabs.MultiLine = true;
			this.tabs.Name = "tabs";
			this.tabs.ShowFocusRectangle = false;
			this.tabs.Size = new System.Drawing.Size(1084, 566);
			this.tabs.TabIndex = 1;
			this.tabs.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.tabQueue,
            this.tabArchive});
			this.tabs.UseThemes = false;
			this.tabs.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
			// 
			// tabQueue
			// 
			this.tabQueue.Controls.Add(this.gridQueue);
			this.tabQueue.Location = new System.Drawing.Point(1, 28);
			this.tabQueue.Name = "tabQueue";
			this.tabQueue.Size = new System.Drawing.Size(1082, 537);
			this.tabQueue.TabStop = true;
			this.tabQueue.Text = "صف ارسال";
			// 
			// gridQueue
			// 
			this.gridQueue.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridQueue.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridQueue.AlternatingColors = true;
			this.gridQueue.BackColor = System.Drawing.Color.WhiteSmoke;
			this.gridQueue.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
			this.gridQueue.BuiltInTextsData = resources.GetString("gridQueue.BuiltInTextsData");
			this.gridQueue.ColumnAutoResize = true;
			this.gridQueue.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
			this.gridQueue.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridQueue.DynamicFiltering = true;
			this.gridQueue.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridQueue.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.gridQueue.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
			this.gridQueue.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
			this.gridQueue.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle;
			this.gridQueue.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid;
			this.gridQueue.Font = new System.Drawing.Font("IRANSans(Small)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.gridQueue.GridLines = Janus.Windows.GridEX.GridLines.Vertical;
			this.gridQueue.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
			this.gridQueue.GroupByBoxVisible = false;
			this.gridQueue.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
			this.gridQueue.Location = new System.Drawing.Point(0, 0);
			this.gridQueue.Name = "gridQueue";
			this.gridQueue.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
			this.gridQueue.Office2007CustomColor = System.Drawing.SystemColors.HotTrack;
			this.gridQueue.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.gridQueue.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
			this.gridQueue.Size = new System.Drawing.Size(1082, 537);
			this.gridQueue.TabIndex = 0;
			this.gridQueue.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			// 
			// tabArchive
			// 
			this.tabArchive.Controls.Add(this.panelArchive);
			this.tabArchive.Location = new System.Drawing.Point(1, 28);
			this.tabArchive.Name = "tabArchive";
			this.tabArchive.Size = new System.Drawing.Size(1082, 537);
			this.tabArchive.TabStop = true;
			this.tabArchive.Text = "آرشیو ارسال‌ها";
			// 
			// panelArchive
			// 
			this.panelArchive.Controls.Add(this.gridArchive);
			this.panelArchive.Controls.Add(this.panelArchiveTop);
			this.panelArchive.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelArchive.Location = new System.Drawing.Point(0, 0);
			this.panelArchive.MS_BorderColor = System.Drawing.Color.Silver;
			this.panelArchive.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.panelArchive.MS_Color_End = System.Drawing.Color.Empty;
			this.panelArchive.MS_Color_Start = System.Drawing.Color.Empty;
			this.panelArchive.Name = "panelArchive";
			this.panelArchive.Size = new System.Drawing.Size(1082, 537);
			this.panelArchive.TabIndex = 0;
			// 
			// gridArchive
			// 
			this.gridArchive.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridArchive.AllowRemoveColumns = Janus.Windows.GridEX.InheritableBoolean.True;
			this.gridArchive.AlternatingColors = true;
			this.gridArchive.BackColor = System.Drawing.Color.WhiteSmoke;
			this.gridArchive.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
			this.gridArchive.BuiltInTextsData = resources.GetString("gridArchive.BuiltInTextsData");
			this.gridArchive.ColumnAutoResize = true;
			this.gridArchive.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
			this.gridArchive.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridArchive.DynamicFiltering = true;
			this.gridArchive.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridArchive.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.gridArchive.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
			this.gridArchive.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
			this.gridArchive.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle;
			this.gridArchive.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid;
			this.gridArchive.Font = new System.Drawing.Font("IRANSans(Small)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.gridArchive.GridLines = Janus.Windows.GridEX.GridLines.Vertical;
			this.gridArchive.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
			this.gridArchive.GroupByBoxVisible = false;
			this.gridArchive.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
			this.gridArchive.Location = new System.Drawing.Point(0, 44);
			this.gridArchive.Name = "gridArchive";
			this.gridArchive.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
			this.gridArchive.Office2007CustomColor = System.Drawing.SystemColors.HotTrack;
			this.gridArchive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.gridArchive.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
			this.gridArchive.Size = new System.Drawing.Size(1082, 493);
			this.gridArchive.TabIndex = 0;
			this.gridArchive.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			// 
			// panelArchiveTop
			// 
			this.panelArchiveTop.Controls.Add(this.lblArchiveStatus);
			this.panelArchiveTop.Controls.Add(this.cmbArchiveStatus);
			this.panelArchiveTop.Controls.Add(this.btnRetry);
			this.panelArchiveTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelArchiveTop.Location = new System.Drawing.Point(0, 0);
			this.panelArchiveTop.MS_BorderColor = System.Drawing.Color.Silver;
			this.panelArchiveTop.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.panelArchiveTop.MS_Color_End = System.Drawing.Color.Empty;
			this.panelArchiveTop.MS_Color_Start = System.Drawing.Color.Empty;
			this.panelArchiveTop.Name = "panelArchiveTop";
			this.panelArchiveTop.Size = new System.Drawing.Size(1082, 44);
			this.panelArchiveTop.TabIndex = 1;
			// 
			// lblArchiveStatus
			// 
			this.lblArchiveStatus.Location = new System.Drawing.Point(940, 8);
			this.lblArchiveStatus.MS_Border_Radius = 5;
			this.lblArchiveStatus.MS_Color_End = System.Drawing.Color.DodgerBlue;
			this.lblArchiveStatus.MS_Color_Start = System.Drawing.Color.LightSkyBlue;
			this.lblArchiveStatus.Name = "lblArchiveStatus";
			this.lblArchiveStatus.Size = new System.Drawing.Size(120, 23);
			this.lblArchiveStatus.TabIndex = 0;
			this.lblArchiveStatus.Text = "وضعیت:";
			this.lblArchiveStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbArchiveStatus
			// 
			this.cmbArchiveStatus.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmbArchiveStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbArchiveStatus.Items.AddRange(new object[] {
            "همه",
            "ارسال شد",
            "ارسال نشد",
            "لغو شد"});
			this.cmbArchiveStatus.Location = new System.Drawing.Point(780, 7);
			this.cmbArchiveStatus.MS_BorderColor = System.Drawing.Color.Silver;
			this.cmbArchiveStatus.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.cmbArchiveStatus.MS_Change_Border_Color_On_Enter = false;
			this.cmbArchiveStatus.MS_Change_Color_On_Enter = false;
			this.cmbArchiveStatus.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.cmbArchiveStatus.MS_Enter_Color = System.Drawing.Color.Empty;
			this.cmbArchiveStatus.MS_Exit_By_Down = false;
			this.cmbArchiveStatus.MS_Exit_By_Enter = false;
			this.cmbArchiveStatus.MS_Exit_By_Up = false;
			this.cmbArchiveStatus.MS_Last_Control = null;
			this.cmbArchiveStatus.MS_Next_Control = null;
			this.cmbArchiveStatus.Name = "cmbArchiveStatus";
			this.cmbArchiveStatus.Size = new System.Drawing.Size(150, 28);
			this.cmbArchiveStatus.TabIndex = 1;
			this.cmbArchiveStatus.SelectedIndexChanged += new System.EventHandler(this.cmbArchiveStatus_SelectedIndexChanged);
			// 
			// btnRetry
			// 
			this.btnRetry.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRetry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnRetry.Location = new System.Drawing.Point(648, 5);
			this.btnRetry.MS_BorderColor = System.Drawing.Color.DodgerBlue;
			this.btnRetry.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.btnRetry.MS_Change_Border_Color_On_Enter = false;
			this.btnRetry.MS_Change_Color_On_Enter = false;
			this.btnRetry.MS_Color_End = System.Drawing.Color.PowderBlue;
			this.btnRetry.MS_Color_Start = System.Drawing.Color.AliceBlue;
			this.btnRetry.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.btnRetry.MS_Enter_Color = System.Drawing.Color.Empty;
			this.btnRetry.Name = "btnRetry";
			this.btnRetry.Size = new System.Drawing.Size(120, 29);
			this.btnRetry.TabIndex = 2;
			this.btnRetry.Text = "بازگشت به صف";
			this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
			this.statusStrip.Location = new System.Drawing.Point(0, 591);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.statusStrip.Size = new System.Drawing.Size(1084, 22);
			this.statusStrip.TabIndex = 2;
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(32, 17);
			this.lblStatus.Text = "آماده";
			// 
			// FormQueueManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1084, 613);
			this.Controls.Add(this.tabs);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.statusStrip);
			this.Font = new System.Drawing.Font("IRANSans(Small)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Name = "FormQueueManager";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "مدیریت صف ارسال پیامک";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormQueueManager_FormClosed);
			this.Load += new System.EventHandler(this.FormQueueManager_Load);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tabs)).EndInit();
			this.tabs.ResumeLayout(false);
			this.tabQueue.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridQueue)).EndInit();
			this.tabArchive.ResumeLayout(false);
			this.panelArchive.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridArchive)).EndInit();
			this.panelArchiveTop.ResumeLayout(false);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MS_Control.Controls.MS_Tool_Strip toolStrip;
		private System.Windows.Forms.ToolStripButton btnRefresh;
		private System.Windows.Forms.ToolStripSeparator sep1;
		private System.Windows.Forms.ToolStripButton btnTop;
		private System.Windows.Forms.ToolStripButton btnUp;
		private System.Windows.Forms.ToolStripButton btnDown;
		private System.Windows.Forms.ToolStripButton btnBottom;
		private System.Windows.Forms.ToolStripSeparator sep2;
		private System.Windows.Forms.ToolStripButton btnUrgent;
		private System.Windows.Forms.ToolStripButton btnMedium;
		private System.Windows.Forms.ToolStripButton btnNormal;
		private System.Windows.Forms.ToolStripSeparator sep3;
		private System.Windows.Forms.ToolStripButton btnCancel;
		private System.Windows.Forms.ToolStripButton btnCancelAll;
		private System.Windows.Forms.ToolStripSeparator sep4;
		private System.Windows.Forms.ToolStripButton btnPauseResume;
		private System.Windows.Forms.ToolStripSeparator sep5;
		private System.Windows.Forms.ToolStripButton btnStatus;
		private Janus.Windows.UI.Tab.UITab tabs;
		private Janus.Windows.UI.Tab.UITabPage tabQueue;
		private MS_Control.Controls.MS_GridX gridQueue;
		private Janus.Windows.UI.Tab.UITabPage tabArchive;
		private MS_Control.Controls.MS_Panel panelArchive;
		private MS_Control.Controls.MS_Panel panelArchiveTop;
		private MS_Control.Controls.MS_Label lblArchiveStatus;
		private MS_Control.Controls.MS_ComboBox cmbArchiveStatus;
		private MS_Control.Controls.MS_Button btnRetry;
		private MS_Control.Controls.MS_GridX gridArchive;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel lblStatus;
	}
}
