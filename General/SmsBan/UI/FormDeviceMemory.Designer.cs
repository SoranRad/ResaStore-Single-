namespace SmsBan.UI
{
	partial class FormDeviceMemory
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
			this.toolStrip = new MS_Control.Controls.MS_Tool_Strip();
			this.btnRefresh = new System.Windows.Forms.ToolStripButton();
			this.sep1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnSaveToDb = new System.Windows.Forms.ToolStripButton();
			this.sep2 = new System.Windows.Forms.ToolStripSeparator();
			this.btnDelete = new System.Windows.Forms.ToolStripButton();
			this.btnDeleteSaved = new System.Windows.Forms.ToolStripButton();
			this.btnDeleteAll = new System.Windows.Forms.ToolStripButton();
			this.panelStats = new MS_Control.Controls.MS_Panel();
			this.tblStats = new System.Windows.Forms.TableLayoutPanel();
			this.lblTotal = new MS_Control.Controls.MS_Label();
			this.lblUsed = new MS_Control.Controls.MS_Label();
			this.lblFree = new MS_Control.Controls.MS_Label();
			this.lblCount = new MS_Control.Controls.MS_Label();
			this.lblPercent = new MS_Control.Controls.MS_Label();
			this.progressMemory = new System.Windows.Forms.ProgressBar();
			this.panelRight = new MS_Control.Controls.MS_Panel();
			this.gridContacts = new MS_Control.Controls.MS_GridX();
			this.lblContactsTitle = new MS_Control.Controls.MS_Label();
			this.panelLeft = new MS_Control.Controls.MS_Panel();
			this.gridMessages = new MS_Control.Controls.MS_GridX();
			this.lblMessagesTitle = new MS_Control.Controls.MS_Label();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStrip.SuspendLayout();
			this.panelStats.SuspendLayout();
			this.tblStats.SuspendLayout();
			this.panelRight.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridContacts)).BeginInit();
			this.panelLeft.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridMessages)).BeginInit();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip
			// 
			this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRefresh,
            this.sep1,
            this.btnSaveToDb,
            this.sep2,
            this.btnDelete,
            this.btnDeleteSaved,
            this.btnDeleteAll});
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.toolStrip.Size = new System.Drawing.Size(1100, 27);
			this.toolStrip.TabIndex = 0;
			this.toolStrip.Text = "toolStrip";
			// 
			// btnRefresh
			// 
			this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(110, 24);
			this.btnRefresh.Text = "بازخوانی حافظه";
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// sep1
			// 
			this.sep1.Name = "sep1";
			this.sep1.Size = new System.Drawing.Size(6, 27);
			// 
			// btnSaveToDb
			// 
			this.btnSaveToDb.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnSaveToDb.Name = "btnSaveToDb";
			this.btnSaveToDb.Size = new System.Drawing.Size(120, 24);
			this.btnSaveToDb.Text = "ذخیره در بانک";
			this.btnSaveToDb.Click += new System.EventHandler(this.btnSaveToDb_Click);
			// 
			// sep2
			// 
			this.sep2.Name = "sep2";
			this.sep2.Size = new System.Drawing.Size(6, 27);
			// 
			// btnDelete
			// 
			this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(130, 24);
			this.btnDelete.Text = "حذف پیامک انتخاب‌شده";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnDeleteSaved
			// 
			this.btnDeleteSaved.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnDeleteSaved.Name = "btnDeleteSaved";
			this.btnDeleteSaved.Size = new System.Drawing.Size(150, 24);
			this.btnDeleteSaved.Text = "حذف ذخیره‌شده‌ها";
			this.btnDeleteSaved.Click += new System.EventHandler(this.btnDeleteSaved_Click);
			// 
			// btnDeleteAll
			// 
			this.btnDeleteAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnDeleteAll.Name = "btnDeleteAll";
			this.btnDeleteAll.Size = new System.Drawing.Size(120, 24);
			this.btnDeleteAll.Text = "حذف همه";
			this.btnDeleteAll.Click += new System.EventHandler(this.btnDeleteAll_Click);
			// 
			// panelStats
			// 
			this.panelStats.Controls.Add(this.tblStats);
			this.panelStats.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelStats.Location = new System.Drawing.Point(0, 27);
			this.panelStats.Name = "panelStats";
			this.panelStats.Size = new System.Drawing.Size(1100, 64);
			this.panelStats.TabIndex = 1;
			// 
			// tblStats
			// 
			this.tblStats.ColumnCount = 5;
			this.tblStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tblStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tblStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tblStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tblStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tblStats.Controls.Add(this.lblTotal, 0, 0);
			this.tblStats.Controls.Add(this.lblUsed, 1, 0);
			this.tblStats.Controls.Add(this.lblFree, 2, 0);
			this.tblStats.Controls.Add(this.lblCount, 3, 0);
			this.tblStats.Controls.Add(this.lblPercent, 4, 0);
			this.tblStats.Controls.Add(this.progressMemory, 0, 1);
			this.tblStats.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tblStats.Location = new System.Drawing.Point(0, 0);
			this.tblStats.Name = "tblStats";
			this.tblStats.RowCount = 2;
			this.tblStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
			this.tblStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tblStats.SetColumnSpan(this.progressMemory, 5);
			this.tblStats.Size = new System.Drawing.Size(1100, 64);
			this.tblStats.TabIndex = 0;
			// 
			// lblTotal
			// 
			this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblTotal.Location = new System.Drawing.Point(883, 0);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(214, 38);
			this.lblTotal.TabIndex = 0;
			this.lblTotal.Text = "ظرفیت کل: —";
			this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblUsed
			// 
			this.lblUsed.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblUsed.Location = new System.Drawing.Point(663, 0);
			this.lblUsed.Name = "lblUsed";
			this.lblUsed.Size = new System.Drawing.Size(214, 38);
			this.lblUsed.TabIndex = 1;
			this.lblUsed.Text = "اشغال‌شده: —";
			this.lblUsed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblFree
			// 
			this.lblFree.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblFree.Location = new System.Drawing.Point(443, 0);
			this.lblFree.Name = "lblFree";
			this.lblFree.Size = new System.Drawing.Size(214, 38);
			this.lblFree.TabIndex = 2;
			this.lblFree.Text = "آزاد: —";
			this.lblFree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblCount
			// 
			this.lblCount.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblCount.Location = new System.Drawing.Point(223, 0);
			this.lblCount.Name = "lblCount";
			this.lblCount.Size = new System.Drawing.Size(214, 38);
			this.lblCount.TabIndex = 3;
			this.lblCount.Text = "پیامک: —";
			this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblPercent
			// 
			this.lblPercent.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblPercent.Location = new System.Drawing.Point(3, 0);
			this.lblPercent.Name = "lblPercent";
			this.lblPercent.Size = new System.Drawing.Size(214, 38);
			this.lblPercent.TabIndex = 4;
			this.lblPercent.Text = "استفاده: —";
			this.lblPercent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// progressMemory
			// 
			this.progressMemory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.progressMemory.Location = new System.Drawing.Point(3, 41);
			this.progressMemory.Maximum = 100;
			this.progressMemory.Name = "progressMemory";
			this.progressMemory.Size = new System.Drawing.Size(1094, 20);
			this.progressMemory.TabIndex = 5;
			// 
			// panelRight
			// 
			this.panelRight.Controls.Add(this.gridContacts);
			this.panelRight.Controls.Add(this.lblContactsTitle);
			this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.panelRight.Location = new System.Drawing.Point(760, 91);
			this.panelRight.Name = "panelRight";
			this.panelRight.Size = new System.Drawing.Size(340, 537);
			this.panelRight.TabIndex = 2;
			// 
			// gridContacts
			// 
			this.gridContacts.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridContacts.AlternatingColors = true;
			this.gridContacts.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
			this.gridContacts.ColumnAutoResize = true;
			this.gridContacts.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
			this.gridContacts.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridContacts.DynamicFiltering = true;
			this.gridContacts.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridContacts.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.gridContacts.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
			this.gridContacts.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
			this.gridContacts.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid;
			this.gridContacts.Font = new System.Drawing.Font("IRANSans(Small)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.gridContacts.GridLines = Janus.Windows.GridEX.GridLines.Vertical;
			this.gridContacts.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
			this.gridContacts.GroupByBoxVisible = false;
			this.gridContacts.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
			this.gridContacts.Location = new System.Drawing.Point(0, 34);
			this.gridContacts.Name = "gridContacts";
			this.gridContacts.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
			this.gridContacts.Office2007CustomColor = System.Drawing.SystemColors.HotTrack;
			this.gridContacts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.gridContacts.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
			this.gridContacts.SelectionMode = Janus.Windows.GridEX.SelectionMode.SingleSelection;
			this.gridContacts.Size = new System.Drawing.Size(340, 503);
			this.gridContacts.TabIndex = 1;
			this.gridContacts.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			this.gridContacts.SelectionChanged += new System.EventHandler(this.gridContacts_SelectionChanged);
			// 
			// lblContactsTitle
			// 
			this.lblContactsTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblContactsTitle.Location = new System.Drawing.Point(0, 0);
			this.lblContactsTitle.Name = "lblContactsTitle";
			this.lblContactsTitle.Size = new System.Drawing.Size(340, 34);
			this.lblContactsTitle.TabIndex = 0;
			this.lblContactsTitle.Text = "مخاطبان موجود در حافظه دستگاه";
			this.lblContactsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelLeft
			// 
			this.panelLeft.Controls.Add(this.gridMessages);
			this.panelLeft.Controls.Add(this.lblMessagesTitle);
			this.panelLeft.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelLeft.Location = new System.Drawing.Point(0, 91);
			this.panelLeft.Name = "panelLeft";
			this.panelLeft.Size = new System.Drawing.Size(760, 537);
			this.panelLeft.TabIndex = 3;
			// 
			// gridMessages
			// 
			this.gridMessages.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridMessages.AlternatingColors = true;
			this.gridMessages.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
			this.gridMessages.ColumnAutoResize = true;
			this.gridMessages.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
			this.gridMessages.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridMessages.DynamicFiltering = true;
			this.gridMessages.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridMessages.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.gridMessages.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
			this.gridMessages.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
			this.gridMessages.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid;
			this.gridMessages.Font = new System.Drawing.Font("IRANSans(Small)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.gridMessages.GridLines = Janus.Windows.GridEX.GridLines.Vertical;
			this.gridMessages.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
			this.gridMessages.GroupByBoxVisible = false;
			this.gridMessages.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
			this.gridMessages.Location = new System.Drawing.Point(0, 34);
			this.gridMessages.Name = "gridMessages";
			this.gridMessages.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
			this.gridMessages.Office2007CustomColor = System.Drawing.SystemColors.HotTrack;
			this.gridMessages.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.gridMessages.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
			this.gridMessages.SelectionMode = Janus.Windows.GridEX.SelectionMode.SingleSelection;
			this.gridMessages.Size = new System.Drawing.Size(760, 503);
			this.gridMessages.TabIndex = 1;
			this.gridMessages.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			// 
			// lblMessagesTitle
			// 
			this.lblMessagesTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblMessagesTitle.Location = new System.Drawing.Point(0, 0);
			this.lblMessagesTitle.Name = "lblMessagesTitle";
			this.lblMessagesTitle.Size = new System.Drawing.Size(760, 34);
			this.lblMessagesTitle.TabIndex = 0;
			this.lblMessagesTitle.Text = "پیامک‌های حافظه دستگاه";
			this.lblMessagesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
			this.statusStrip.Location = new System.Drawing.Point(0, 628);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.statusStrip.Size = new System.Drawing.Size(1100, 22);
			this.statusStrip.TabIndex = 4;
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(62, 17);
			this.lblStatus.Text = "آماده";
			// 
			// FormDeviceMemory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1100, 650);
			this.Controls.Add(this.panelLeft);
			this.Controls.Add(this.panelRight);
			this.Controls.Add(this.panelStats);
			this.Controls.Add(this.statusStrip);
			this.Controls.Add(this.toolStrip);
			this.Font = new System.Drawing.Font("IRANSans(Small)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.MS_Escap = true;
			this.Name = "FormDeviceMemory";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "مدیریت حافظه دستگاه";
			this.Load += new System.EventHandler(this.FormDeviceMemory_Load);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.panelStats.ResumeLayout(false);
			this.tblStats.ResumeLayout(false);
			this.panelRight.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridContacts)).EndInit();
			this.panelLeft.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridMessages)).EndInit();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MS_Control.Controls.MS_Tool_Strip toolStrip;
		private System.Windows.Forms.ToolStripButton btnRefresh;
		private System.Windows.Forms.ToolStripSeparator sep1;
		private System.Windows.Forms.ToolStripButton btnSaveToDb;
		private System.Windows.Forms.ToolStripSeparator sep2;
		private System.Windows.Forms.ToolStripButton btnDelete;
		private System.Windows.Forms.ToolStripButton btnDeleteSaved;
		private System.Windows.Forms.ToolStripButton btnDeleteAll;
		private MS_Control.Controls.MS_Panel panelStats;
		private System.Windows.Forms.TableLayoutPanel tblStats;
		private MS_Control.Controls.MS_Label lblTotal;
		private MS_Control.Controls.MS_Label lblUsed;
		private MS_Control.Controls.MS_Label lblFree;
		private MS_Control.Controls.MS_Label lblCount;
		private MS_Control.Controls.MS_Label lblPercent;
		private System.Windows.Forms.ProgressBar progressMemory;
		private MS_Control.Controls.MS_Panel panelRight;
		private MS_Control.Controls.MS_GridX gridContacts;
		private MS_Control.Controls.MS_Label lblContactsTitle;
		private MS_Control.Controls.MS_Panel panelLeft;
		private MS_Control.Controls.MS_GridX gridMessages;
		private MS_Control.Controls.MS_Label lblMessagesTitle;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel lblStatus;
	}
}
