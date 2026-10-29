namespace SmsBan.UI
{
	partial class FormSimMessages
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
			this.btnLoad = new System.Windows.Forms.ToolStripButton();
			this.sep1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnDelete = new System.Windows.Forms.ToolStripButton();
			this.gridMessages = new MS_Control.Controls.MS_GridX();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridMessages)).BeginInit();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip
			// 
			this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnLoad,
            this.sep1,
            this.btnDelete});
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.toolStrip.Size = new System.Drawing.Size(1004, 27);
			this.toolStrip.TabIndex = 0;
			this.toolStrip.Text = "toolStrip";
			// 
			// btnLoad
			// 
			this.btnLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(150, 24);
			this.btnLoad.Text = "خواندن از سیم‌کارت / مودم";
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// sep1
			// 
			this.sep1.Name = "sep1";
			this.sep1.Size = new System.Drawing.Size(6, 27);
			// 
			// btnDelete
			// 
			this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(130, 24);
			this.btnDelete.Text = "حذف از سیم‌کارت";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
			this.gridMessages.Location = new System.Drawing.Point(0, 27);
			this.gridMessages.Name = "gridMessages";
			this.gridMessages.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
			this.gridMessages.Office2007CustomColor = System.Drawing.SystemColors.HotTrack;
			this.gridMessages.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.gridMessages.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
			this.gridMessages.SelectionMode = Janus.Windows.GridEX.SelectionMode.SingleSelection;
			this.gridMessages.Size = new System.Drawing.Size(1004, 509);
			this.gridMessages.TabIndex = 1;
			this.gridMessages.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
			this.statusStrip.Location = new System.Drawing.Point(0, 536);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.statusStrip.Size = new System.Drawing.Size(1004, 22);
			this.statusStrip.TabIndex = 2;
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(62, 17);
			this.lblStatus.Text = "آماده";
			// 
			// FormSimMessages
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1004, 558);
			this.Controls.Add(this.gridMessages);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.statusStrip);
			this.Font = new System.Drawing.Font("IRANSans(Small)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.MS_Escap = true;
			this.Name = "FormSimMessages";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "پیامک‌های سیم‌کارت";
			this.Load += new System.EventHandler(this.FormSimMessages_Load);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridMessages)).EndInit();
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MS_Control.Controls.MS_Tool_Strip toolStrip;
		private System.Windows.Forms.ToolStripButton btnLoad;
		private System.Windows.Forms.ToolStripSeparator sep1;
		private System.Windows.Forms.ToolStripButton btnDelete;
		private MS_Control.Controls.MS_GridX gridMessages;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel lblStatus;
	}
}
