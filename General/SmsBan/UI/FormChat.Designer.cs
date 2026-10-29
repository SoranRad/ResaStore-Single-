namespace SmsBan.UI
{
	partial class FormChat
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChat));
			this.toolStrip = new MS_Control.Controls.MS_Tool_Strip();
			this.btnCopy = new System.Windows.Forms.ToolStripButton();
			this.btnDelete = new System.Windows.Forms.ToolStripButton();
			this.sep1 = new System.Windows.Forms.ToolStripSeparator();
			this.btnRefresh = new System.Windows.Forms.ToolStripButton();
			this.panelTop = new MS_Control.Controls.MS_Panel();
			this.flowFilter = new System.Windows.Forms.FlowLayoutPanel();
			this.lblFilter = new MS_Control.Controls.MS_Label();
			this.rbBoth = new MS_Control.Controls.MS_RadioBox();
			this.rbOutgoing = new MS_Control.Controls.MS_RadioBox();
			this.rbIncoming = new MS_Control.Controls.MS_RadioBox();
			this.panelRight = new MS_Control.Controls.MS_Panel();
			this.gridContacts = new MS_Control.Controls.MS_GridX();
			this.lblContactsTitle = new MS_Control.Controls.MS_Label();
			this.panelChat = new MS_Control.Controls.MS_Panel();
			this.panelMessages = new MS_Control.Controls.MS_Panel();
			this.panelHeader = new MS_Control.Controls.MS_Panel();
			this.lblHeader = new MS_Control.Controls.MS_Label();
			this.panelSend = new MS_Control.Controls.MS_Panel();
			this.txtMessage = new MS_Control.Controls.MS_TextBox();
			this.panelSendRight = new MS_Control.Controls.MS_Panel();
			this.cmbPriority = new MS_Control.Controls.MS_ComboBox();
			this.btnSend = new MS_Control.Controls.MS_Button();
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStrip.SuspendLayout();
			this.panelTop.SuspendLayout();
			this.flowFilter.SuspendLayout();
			this.panelRight.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridContacts)).BeginInit();
			this.panelChat.SuspendLayout();
			this.panelHeader.SuspendLayout();
			this.panelSend.SuspendLayout();
			this.panelSendRight.SuspendLayout();
			this.statusStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip
			// 
			this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCopy,
            this.btnDelete,
            this.sep1,
            this.btnRefresh});
			this.toolStrip.Location = new System.Drawing.Point(0, 0);
			this.toolStrip.MS_BorderColor = System.Drawing.Color.Silver;
			this.toolStrip.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.toolStrip.MS_Color_End = System.Drawing.Color.Empty;
			this.toolStrip.MS_Color_Start = System.Drawing.Color.Empty;
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.toolStrip.Size = new System.Drawing.Size(984, 25);
			this.toolStrip.TabIndex = 0;
			this.toolStrip.Text = "toolStrip";
			// 
			// btnCopy
			// 
			this.btnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnCopy.Name = "btnCopy";
			this.btnCopy.Size = new System.Drawing.Size(74, 22);
			this.btnCopy.Text = "کپی متن پیام";
			this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(68, 22);
			this.btnDelete.Text = "حذف پیامک";
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// sep1
			// 
			this.sep1.Name = "sep1";
			this.sep1.Size = new System.Drawing.Size(6, 25);
			// 
			// btnRefresh
			// 
			this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(66, 22);
			this.btnRefresh.Text = "به‌روزرسانی";
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// panelTop
			// 
			this.panelTop.Controls.Add(this.flowFilter);
			this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTop.Location = new System.Drawing.Point(0, 25);
			this.panelTop.MS_BorderColor = System.Drawing.Color.Silver;
			this.panelTop.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.panelTop.MS_Color_End = System.Drawing.Color.Empty;
			this.panelTop.MS_Color_Start = System.Drawing.Color.Empty;
			this.panelTop.Name = "panelTop";
			this.panelTop.Size = new System.Drawing.Size(984, 52);
			this.panelTop.TabIndex = 1;
			// 
			// flowFilter
			// 
			this.flowFilter.Controls.Add(this.lblFilter);
			this.flowFilter.Controls.Add(this.rbBoth);
			this.flowFilter.Controls.Add(this.rbOutgoing);
			this.flowFilter.Controls.Add(this.rbIncoming);
			this.flowFilter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowFilter.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
			this.flowFilter.Location = new System.Drawing.Point(0, 0);
			this.flowFilter.Name = "flowFilter";
			this.flowFilter.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
			this.flowFilter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.flowFilter.Size = new System.Drawing.Size(984, 52);
			this.flowFilter.TabIndex = 0;
			this.flowFilter.WrapContents = false;
			// 
			// lblFilter
			// 
			this.lblFilter.AutoSize = true;
			this.lblFilter.Location = new System.Drawing.Point(22, 16);
			this.lblFilter.Margin = new System.Windows.Forms.Padding(3, 6, 12, 3);
			this.lblFilter.MS_Border_Radius = 5;
			this.lblFilter.MS_Color_End = System.Drawing.Color.DodgerBlue;
			this.lblFilter.MS_Color_Start = System.Drawing.Color.LightSkyBlue;
			this.lblFilter.Name = "lblFilter";
			this.lblFilter.Size = new System.Drawing.Size(74, 20);
			this.lblFilter.TabIndex = 0;
			this.lblFilter.Text = "نمایش پیام‌ها:";
			// 
			// rbBoth
			// 
			this.rbBoth.Checked = true;
			this.rbBoth.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rbBoth.Location = new System.Drawing.Point(102, 14);
			this.rbBoth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
			this.rbBoth.MS_BorderColor = System.Drawing.Color.Silver;
			this.rbBoth.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.rbBoth.MS_Change_Border_Color_On_Enter = false;
			this.rbBoth.MS_Change_Color_On_Checked = false;
			this.rbBoth.MS_Change_Color_On_Enter = false;
			this.rbBoth.MS_Checked_Color = System.Drawing.Color.Empty;
			this.rbBoth.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.rbBoth.MS_Enter_Color = System.Drawing.Color.Empty;
			this.rbBoth.MS_Exit_By_Down = false;
			this.rbBoth.MS_Exit_By_Enter = false;
			this.rbBoth.MS_Exit_By_Up = false;
			this.rbBoth.MS_Last_Control = null;
			this.rbBoth.MS_Next_Control = null;
			this.rbBoth.MS_UnChecked_Color = System.Drawing.Color.Empty;
			this.rbBoth.Name = "rbBoth";
			this.rbBoth.Size = new System.Drawing.Size(43, 24);
			this.rbBoth.TabIndex = 1;
			this.rbBoth.TabStop = true;
			this.rbBoth.Text = "هر دو";
			this.rbBoth.CheckedChanged += new System.EventHandler(this.rbFilter_CheckedChanged);
			// 
			// rbOutgoing
			// 
			this.rbOutgoing.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rbOutgoing.Location = new System.Drawing.Point(151, 14);
			this.rbOutgoing.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
			this.rbOutgoing.MS_BorderColor = System.Drawing.Color.Silver;
			this.rbOutgoing.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.rbOutgoing.MS_Change_Border_Color_On_Enter = false;
			this.rbOutgoing.MS_Change_Color_On_Checked = false;
			this.rbOutgoing.MS_Change_Color_On_Enter = false;
			this.rbOutgoing.MS_Checked_Color = System.Drawing.Color.Empty;
			this.rbOutgoing.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.rbOutgoing.MS_Enter_Color = System.Drawing.Color.Empty;
			this.rbOutgoing.MS_Exit_By_Down = false;
			this.rbOutgoing.MS_Exit_By_Enter = false;
			this.rbOutgoing.MS_Exit_By_Up = false;
			this.rbOutgoing.MS_Last_Control = null;
			this.rbOutgoing.MS_Next_Control = null;
			this.rbOutgoing.MS_UnChecked_Color = System.Drawing.Color.Empty;
			this.rbOutgoing.Name = "rbOutgoing";
			this.rbOutgoing.Size = new System.Drawing.Size(46, 24);
			this.rbOutgoing.TabIndex = 2;
			this.rbOutgoing.Text = "ارسالی";
			this.rbOutgoing.CheckedChanged += new System.EventHandler(this.rbFilter_CheckedChanged);
			// 
			// rbIncoming
			// 
			this.rbIncoming.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rbIncoming.Location = new System.Drawing.Point(203, 14);
			this.rbIncoming.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
			this.rbIncoming.MS_BorderColor = System.Drawing.Color.Silver;
			this.rbIncoming.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.rbIncoming.MS_Change_Border_Color_On_Enter = false;
			this.rbIncoming.MS_Change_Color_On_Checked = false;
			this.rbIncoming.MS_Change_Color_On_Enter = false;
			this.rbIncoming.MS_Checked_Color = System.Drawing.Color.Empty;
			this.rbIncoming.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.rbIncoming.MS_Enter_Color = System.Drawing.Color.Empty;
			this.rbIncoming.MS_Exit_By_Down = false;
			this.rbIncoming.MS_Exit_By_Enter = false;
			this.rbIncoming.MS_Exit_By_Up = false;
			this.rbIncoming.MS_Last_Control = null;
			this.rbIncoming.MS_Next_Control = null;
			this.rbIncoming.MS_UnChecked_Color = System.Drawing.Color.Empty;
			this.rbIncoming.Name = "rbIncoming";
			this.rbIncoming.Size = new System.Drawing.Size(51, 24);
			this.rbIncoming.TabIndex = 3;
			this.rbIncoming.Text = "دریافتی";
			this.rbIncoming.CheckedChanged += new System.EventHandler(this.rbFilter_CheckedChanged);
			// 
			// panelRight
			// 
			this.panelRight.Controls.Add(this.gridContacts);
			this.panelRight.Controls.Add(this.lblContactsTitle);
			this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.panelRight.Location = new System.Drawing.Point(644, 77);
			this.panelRight.MS_BorderColor = System.Drawing.Color.Silver;
			this.panelRight.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.panelRight.MS_Color_End = System.Drawing.Color.Empty;
			this.panelRight.MS_Color_Start = System.Drawing.Color.Empty;
			this.panelRight.Name = "panelRight";
			this.panelRight.Size = new System.Drawing.Size(340, 363);
			this.panelRight.TabIndex = 2;
			// 
			// gridContacts
			// 
			this.gridContacts.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
			this.gridContacts.AlternatingColors = true;
			this.gridContacts.BackColor = System.Drawing.Color.WhiteSmoke;
			this.gridContacts.BorderStyle = Janus.Windows.GridEX.BorderStyle.RaisedLight3D;
			this.gridContacts.BuiltInTextsData = resources.GetString("gridContacts.BuiltInTextsData");
			this.gridContacts.ColumnAutoResize = true;
			this.gridContacts.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains;
			this.gridContacts.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridContacts.DynamicFiltering = true;
			this.gridContacts.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None;
			this.gridContacts.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic;
			this.gridContacts.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
			this.gridContacts.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges;
			this.gridContacts.FocusStyle = Janus.Windows.GridEX.FocusStyle.Solid;
			this.gridContacts.Font = new System.Drawing.Font("IRANSans(Small)", 11F);
			this.gridContacts.GridLines = Janus.Windows.GridEX.GridLines.Horizontal;
			this.gridContacts.GridLineStyle = Janus.Windows.GridEX.GridLineStyle.Solid;
			this.gridContacts.GroupByBoxVisible = false;
			this.gridContacts.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
			this.gridContacts.Location = new System.Drawing.Point(0, 34);
			this.gridContacts.Name = "gridContacts";
			this.gridContacts.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
			this.gridContacts.Office2007CustomColor = System.Drawing.SystemColors.HotTrack;
			this.gridContacts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.gridContacts.RowHeaderContent = Janus.Windows.GridEX.RowHeaderContent.RowIndex;
			this.gridContacts.Size = new System.Drawing.Size(340, 329);
			this.gridContacts.TabIndex = 1;
			this.gridContacts.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			this.gridContacts.SelectionChanged += new System.EventHandler(this.gridContacts_SelectionChanged);
			// 
			// lblContactsTitle
			// 
			this.lblContactsTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblContactsTitle.Font = new System.Drawing.Font("IRANSans(Small)", 12F, System.Drawing.FontStyle.Bold);
			this.lblContactsTitle.Location = new System.Drawing.Point(0, 0);
			this.lblContactsTitle.MS_Border_Radius = 5;
			this.lblContactsTitle.MS_Color_End = System.Drawing.Color.DodgerBlue;
			this.lblContactsTitle.MS_Color_Start = System.Drawing.Color.LightSkyBlue;
			this.lblContactsTitle.Name = "lblContactsTitle";
			this.lblContactsTitle.Size = new System.Drawing.Size(340, 34);
			this.lblContactsTitle.TabIndex = 0;
			this.lblContactsTitle.Text = "مخاطبین";
			this.lblContactsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panelChat
			// 
			this.panelChat.Controls.Add(this.panelMessages);
			this.panelChat.Controls.Add(this.panelHeader);
			this.panelChat.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelChat.Location = new System.Drawing.Point(0, 77);
			this.panelChat.MS_BorderColor = System.Drawing.Color.Silver;
			this.panelChat.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.panelChat.MS_Color_End = System.Drawing.Color.Empty;
			this.panelChat.MS_Color_Start = System.Drawing.Color.Empty;
			this.panelChat.Name = "panelChat";
			this.panelChat.Size = new System.Drawing.Size(644, 363);
			this.panelChat.TabIndex = 3;
			// 
			// panelMessages
			// 
			this.panelMessages.AutoScroll = true;
			this.panelMessages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(229)))), ((int)(((byte)(221)))));
			this.panelMessages.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMessages.Location = new System.Drawing.Point(0, 46);
			this.panelMessages.MS_BorderColor = System.Drawing.Color.Silver;
			this.panelMessages.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.panelMessages.MS_Color_End = System.Drawing.Color.Empty;
			this.panelMessages.MS_Color_Start = System.Drawing.Color.Empty;
			this.panelMessages.Name = "panelMessages";
			this.panelMessages.Size = new System.Drawing.Size(644, 317);
			this.panelMessages.TabIndex = 1;
			// 
			// panelHeader
			// 
			this.panelHeader.Controls.Add(this.lblHeader);
			this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(0, 0);
			this.panelHeader.MS_BorderColor = System.Drawing.Color.Silver;
			this.panelHeader.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.panelHeader.MS_Color_End = System.Drawing.Color.Empty;
			this.panelHeader.MS_Color_Start = System.Drawing.Color.Empty;
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(644, 46);
			this.panelHeader.TabIndex = 0;
			// 
			// lblHeader
			// 
			this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblHeader.Font = new System.Drawing.Font("IRANSans(Small)", 12F, System.Drawing.FontStyle.Bold);
			this.lblHeader.Location = new System.Drawing.Point(0, 0);
			this.lblHeader.MS_Border_Radius = 5;
			this.lblHeader.MS_Color_End = System.Drawing.Color.DodgerBlue;
			this.lblHeader.MS_Color_Start = System.Drawing.Color.LightSkyBlue;
			this.lblHeader.Name = "lblHeader";
			this.lblHeader.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
			this.lblHeader.Size = new System.Drawing.Size(644, 46);
			this.lblHeader.TabIndex = 0;
			this.lblHeader.Text = "یک مخاطب را انتخاب کنید";
			this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// panelSend
			// 
			this.panelSend.Controls.Add(this.txtMessage);
			this.panelSend.Controls.Add(this.panelSendRight);
			this.panelSend.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelSend.Location = new System.Drawing.Point(0, 440);
			this.panelSend.MS_BorderColor = System.Drawing.Color.Silver;
			this.panelSend.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.panelSend.MS_Color_End = System.Drawing.Color.Empty;
			this.panelSend.MS_Color_Start = System.Drawing.Color.Empty;
			this.panelSend.Name = "panelSend";
			this.panelSend.Size = new System.Drawing.Size(984, 112);
			this.panelSend.TabIndex = 4;
			// 
			// txtMessage
			// 
			this.txtMessage.Cursor = System.Windows.Forms.Cursors.Hand;
			this.txtMessage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtMessage.Font = new System.Drawing.Font("IRANSans(Small)", 11F);
			this.txtMessage.Location = new System.Drawing.Point(0, 0);
			this.txtMessage.MS_BorderColor = System.Drawing.Color.Silver;
			this.txtMessage.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.txtMessage.MS_Change_Border_Color_On_Enter = false;
			this.txtMessage.MS_Change_Color_On_Enter = false;
			this.txtMessage.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.txtMessage.MS_Enter_Color = System.Drawing.Color.Empty;
			this.txtMessage.MS_Exit_By_Down = false;
			this.txtMessage.MS_Exit_By_Enter = false;
			this.txtMessage.MS_Exit_By_Up = false;
			this.txtMessage.MS_Last_Control = null;
			this.txtMessage.MS_Next_Control = null;
			this.txtMessage.Multiline = true;
			this.txtMessage.Name = "txtMessage";
			this.txtMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtMessage.Size = new System.Drawing.Size(754, 112);
			this.txtMessage.TabIndex = 0;
			// 
			// panelSendRight
			// 
			this.panelSendRight.Controls.Add(this.cmbPriority);
			this.panelSendRight.Controls.Add(this.btnSend);
			this.panelSendRight.Dock = System.Windows.Forms.DockStyle.Right;
			this.panelSendRight.Location = new System.Drawing.Point(754, 0);
			this.panelSendRight.MS_BorderColor = System.Drawing.Color.Silver;
			this.panelSendRight.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.panelSendRight.MS_Color_End = System.Drawing.Color.Empty;
			this.panelSendRight.MS_Color_Start = System.Drawing.Color.Empty;
			this.panelSendRight.Name = "panelSendRight";
			this.panelSendRight.Size = new System.Drawing.Size(230, 112);
			this.panelSendRight.TabIndex = 1;
			// 
			// cmbPriority
			// 
			this.cmbPriority.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPriority.Items.AddRange(new object[] {
            "عادی",
            "متوسط",
            "فوری"});
			this.cmbPriority.Location = new System.Drawing.Point(10, 12);
			this.cmbPriority.MS_BorderColor = System.Drawing.Color.Silver;
			this.cmbPriority.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.cmbPriority.MS_Change_Border_Color_On_Enter = false;
			this.cmbPriority.MS_Change_Color_On_Enter = false;
			this.cmbPriority.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.cmbPriority.MS_Enter_Color = System.Drawing.Color.Empty;
			this.cmbPriority.MS_Exit_By_Down = false;
			this.cmbPriority.MS_Exit_By_Enter = false;
			this.cmbPriority.MS_Exit_By_Up = false;
			this.cmbPriority.MS_Last_Control = null;
			this.cmbPriority.MS_Next_Control = null;
			this.cmbPriority.Name = "cmbPriority";
			this.cmbPriority.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cmbPriority.Size = new System.Drawing.Size(210, 28);
			this.cmbPriority.TabIndex = 0;
			// 
			// btnSend
			// 
			this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnSend.Location = new System.Drawing.Point(10, 50);
			this.btnSend.MS_BorderColor = System.Drawing.Color.DodgerBlue;
			this.btnSend.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.btnSend.MS_Change_Border_Color_On_Enter = false;
			this.btnSend.MS_Change_Color_On_Enter = false;
			this.btnSend.MS_Color_End = System.Drawing.Color.PowderBlue;
			this.btnSend.MS_Color_Start = System.Drawing.Color.AliceBlue;
			this.btnSend.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.btnSend.MS_Enter_Color = System.Drawing.Color.Empty;
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(210, 48);
			this.btnSend.TabIndex = 1;
			this.btnSend.Text = "ارسال به صف";
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
			this.statusStrip.Location = new System.Drawing.Point(0, 552);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.statusStrip.Size = new System.Drawing.Size(984, 22);
			this.statusStrip.TabIndex = 5;
			// 
			// lblStatus
			// 
			this.lblStatus.Name = "lblStatus";
			this.lblStatus.Size = new System.Drawing.Size(32, 17);
			this.lblStatus.Text = "آماده";
			// 
			// FormChat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(984, 574);
			this.Controls.Add(this.panelChat);
			this.Controls.Add(this.panelRight);
			this.Controls.Add(this.panelSend);
			this.Controls.Add(this.panelTop);
			this.Controls.Add(this.toolStrip);
			this.Controls.Add(this.statusStrip);
			this.Font = new System.Drawing.Font("IRANSans(Small)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Name = "FormChat";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "گفتگوی پیامک";
			this.Load += new System.EventHandler(this.FormChat_Load);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			this.panelTop.ResumeLayout(false);
			this.flowFilter.ResumeLayout(false);
			this.flowFilter.PerformLayout();
			this.panelRight.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.gridContacts)).EndInit();
			this.panelChat.ResumeLayout(false);
			this.panelHeader.ResumeLayout(false);
			this.panelSend.ResumeLayout(false);
			this.panelSend.PerformLayout();
			this.panelSendRight.ResumeLayout(false);
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MS_Control.Controls.MS_Tool_Strip toolStrip;
		private System.Windows.Forms.ToolStripButton btnCopy;
		private System.Windows.Forms.ToolStripButton btnDelete;
		private System.Windows.Forms.ToolStripSeparator sep1;
		private System.Windows.Forms.ToolStripButton btnRefresh;
		private MS_Control.Controls.MS_Panel panelTop;
		private System.Windows.Forms.FlowLayoutPanel flowFilter;
		private MS_Control.Controls.MS_Label lblFilter;
		private MS_Control.Controls.MS_RadioBox rbBoth;
		private MS_Control.Controls.MS_RadioBox rbOutgoing;
		private MS_Control.Controls.MS_RadioBox rbIncoming;
		private MS_Control.Controls.MS_Panel panelRight;
		private MS_Control.Controls.MS_GridX gridContacts;
		private MS_Control.Controls.MS_Label lblContactsTitle;
		private MS_Control.Controls.MS_Panel panelChat;
		private MS_Control.Controls.MS_Panel panelMessages;
		private MS_Control.Controls.MS_Panel panelHeader;
		private MS_Control.Controls.MS_Label lblHeader;
		private MS_Control.Controls.MS_Panel panelSend;
		private MS_Control.Controls.MS_TextBox txtMessage;
		private MS_Control.Controls.MS_Panel panelSendRight;
		private MS_Control.Controls.MS_ComboBox cmbPriority;
		private MS_Control.Controls.MS_Button btnSend;
		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.ToolStripStatusLabel lblStatus;
	}
}
