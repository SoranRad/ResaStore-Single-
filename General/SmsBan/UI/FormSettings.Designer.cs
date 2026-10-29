namespace SmsBan.UI
{
	partial class FormSettings
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
			this.panelMain = new MS_Control.Controls.MS_Panel();
			this.table = new System.Windows.Forms.TableLayoutPanel();
			this.lblConnection = new MS_Control.Controls.MS_Label();
			this.txtConnection = new MS_Control.Controls.MS_TextBox();
			this.lblMaxPerDay = new MS_Control.Controls.MS_Label();
			this.txtMaxPerDay = new MS_Control.Controls.MS_TextBox();
			this.lblMaxPerMinute = new MS_Control.Controls.MS_Label();
			this.txtMaxPerMinute = new MS_Control.Controls.MS_TextBox();
			this.lblCharsPerPage = new MS_Control.Controls.MS_Label();
			this.txtCharsPerPage = new MS_Control.Controls.MS_TextBox();
			this.lblCountryCode = new MS_Control.Controls.MS_Label();
			this.txtCountryCode = new MS_Control.Controls.MS_TextBox();
			this.lblDeviceNumber = new MS_Control.Controls.MS_Label();
			this.txtDeviceNumber = new MS_Control.Controls.MS_TextBox();
			this.lblValidity = new MS_Control.Controls.MS_Label();
			this.cmbValidity = new MS_Control.Controls.MS_ComboBox();
			this.lblPartInterval = new MS_Control.Controls.MS_Label();
			this.txtPartInterval = new MS_Control.Controls.MS_TextBox();
			this.lblModemRetry = new MS_Control.Controls.MS_Label();
			this.txtModemRetry = new MS_Control.Controls.MS_TextBox();
			this.lblSmsCenter = new MS_Control.Controls.MS_Label();
			this.txtSmsCenter = new MS_Control.Controls.MS_TextBox();
			this.lblReadInterval = new MS_Control.Controls.MS_Label();
			this.txtReadInterval = new MS_Control.Controls.MS_TextBox();
			this.lblMaxRetry = new MS_Control.Controls.MS_Label();
			this.txtMaxRetry = new MS_Control.Controls.MS_TextBox();
			this.panelChecks = new System.Windows.Forms.FlowLayoutPanel();
			this.chkIsModemHost = new MS_Control.Controls.MS_CheckBox();
			this.chkDeliveryReport = new MS_Control.Controls.MS_CheckBox();
			this.chkDeleteAfterRead = new MS_Control.Controls.MS_CheckBox();
			this.panelButtons = new System.Windows.Forms.FlowLayoutPanel();
			this.btnOk = new MS_Control.Controls.MS_Button();
			this.btnCancel = new MS_Control.Controls.MS_Button();
			this.table.SuspendLayout();
			this.panelChecks.SuspendLayout();
			this.panelButtons.SuspendLayout();
			this.SuspendLayout();
			// 
			// panelMain
			// 
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(0, 0);
			this.panelMain.MS_BorderColor = System.Drawing.Color.Silver;
			this.panelMain.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.panelMain.MS_Color_End = System.Drawing.Color.Empty;
			this.panelMain.MS_Color_Start = System.Drawing.Color.Empty;
			this.panelMain.Name = "panelMain";
			this.panelMain.Padding = new System.Windows.Forms.Padding(8);
			this.panelMain.Size = new System.Drawing.Size(604, 641);
			this.panelMain.TabIndex = 0;
			// 
			// table
			// 
			this.table.ColumnCount = 2;
			this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
			this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.table.Controls.Add(this.lblConnection, 0, 0);
			this.table.Controls.Add(this.txtConnection, 1, 0);
			this.table.Controls.Add(this.lblMaxPerDay, 0, 1);
			this.table.Controls.Add(this.txtMaxPerDay, 1, 1);
			this.table.Controls.Add(this.lblMaxPerMinute, 0, 2);
			this.table.Controls.Add(this.txtMaxPerMinute, 1, 2);
			this.table.Controls.Add(this.lblCharsPerPage, 0, 3);
			this.table.Controls.Add(this.txtCharsPerPage, 1, 3);
			this.table.Controls.Add(this.lblCountryCode, 0, 4);
			this.table.Controls.Add(this.txtCountryCode, 1, 4);
			this.table.Controls.Add(this.lblDeviceNumber, 0, 5);
			this.table.Controls.Add(this.txtDeviceNumber, 1, 5);
			this.table.Controls.Add(this.lblValidity, 0, 6);
			this.table.Controls.Add(this.cmbValidity, 1, 6);
			this.table.Controls.Add(this.lblPartInterval, 0, 7);
			this.table.Controls.Add(this.txtPartInterval, 1, 7);
			this.table.Controls.Add(this.lblModemRetry, 0, 8);
			this.table.Controls.Add(this.txtModemRetry, 1, 8);
			this.table.Controls.Add(this.lblSmsCenter, 0, 9);
			this.table.Controls.Add(this.txtSmsCenter, 1, 9);
			this.table.Controls.Add(this.lblReadInterval, 0, 10);
			this.table.Controls.Add(this.txtReadInterval, 1, 10);
			this.table.Controls.Add(this.lblMaxRetry, 0, 11);
			this.table.Controls.Add(this.txtMaxRetry, 1, 11);
			this.table.Controls.Add(this.panelChecks, 0, 12);
			this.table.Controls.Add(this.panelButtons, 0, 13);
			this.table.Dock = System.Windows.Forms.DockStyle.Fill;
			this.table.Location = new System.Drawing.Point(8, 8);
			this.table.Name = "table";
			this.table.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.table.RowCount = 14;
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
			this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
			this.table.Size = new System.Drawing.Size(588, 625);
			this.table.TabIndex = 0;
			// 
			// lblConnection
			// 
			this.lblConnection.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblConnection.Location = new System.Drawing.Point(411, 4);
			this.lblConnection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.lblConnection.MS_Border_Radius = 5;
			this.lblConnection.MS_Color_End = System.Drawing.Color.DodgerBlue;
			this.lblConnection.MS_Color_Start = System.Drawing.Color.LightSkyBlue;
			this.lblConnection.Name = "lblConnection";
			this.lblConnection.Size = new System.Drawing.Size(174, 66);
			this.lblConnection.TabIndex = 0;
			this.lblConnection.Text = "رشته اتصال";
			this.lblConnection.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtConnection
			// 
			this.txtConnection.Cursor = System.Windows.Forms.Cursors.Hand;
			this.txtConnection.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtConnection.Location = new System.Drawing.Point(3, 4);
			this.txtConnection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtConnection.MS_BorderColor = System.Drawing.Color.Silver;
			this.txtConnection.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.txtConnection.MS_Change_Border_Color_On_Enter = false;
			this.txtConnection.MS_Change_Color_On_Enter = false;
			this.txtConnection.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.txtConnection.MS_Enter_Color = System.Drawing.Color.Empty;
			this.txtConnection.MS_Exit_By_Down = false;
			this.txtConnection.MS_Exit_By_Enter = false;
			this.txtConnection.MS_Exit_By_Up = false;
			this.txtConnection.MS_Last_Control = null;
			this.txtConnection.MS_Next_Control = null;
			this.txtConnection.Multiline = true;
			this.txtConnection.Name = "txtConnection";
			this.txtConnection.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtConnection.Size = new System.Drawing.Size(402, 66);
			this.txtConnection.TabIndex = 1;
			// 
			// lblMaxPerDay
			// 
			this.lblMaxPerDay.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblMaxPerDay.Location = new System.Drawing.Point(411, 78);
			this.lblMaxPerDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.lblMaxPerDay.MS_Border_Radius = 5;
			this.lblMaxPerDay.MS_Color_End = System.Drawing.Color.DodgerBlue;
			this.lblMaxPerDay.MS_Color_Start = System.Drawing.Color.LightSkyBlue;
			this.lblMaxPerDay.Name = "lblMaxPerDay";
			this.lblMaxPerDay.Size = new System.Drawing.Size(174, 26);
			this.lblMaxPerDay.TabIndex = 2;
			this.lblMaxPerDay.Text = "حداکثر پیامک روزانه";
			this.lblMaxPerDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtMaxPerDay
			// 
			this.txtMaxPerDay.Cursor = System.Windows.Forms.Cursors.Hand;
			this.txtMaxPerDay.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtMaxPerDay.Location = new System.Drawing.Point(3, 78);
			this.txtMaxPerDay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtMaxPerDay.MS_BorderColor = System.Drawing.Color.Silver;
			this.txtMaxPerDay.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.txtMaxPerDay.MS_Change_Border_Color_On_Enter = false;
			this.txtMaxPerDay.MS_Change_Color_On_Enter = false;
			this.txtMaxPerDay.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.txtMaxPerDay.MS_Enter_Color = System.Drawing.Color.Empty;
			this.txtMaxPerDay.MS_Exit_By_Down = false;
			this.txtMaxPerDay.MS_Exit_By_Enter = false;
			this.txtMaxPerDay.MS_Exit_By_Up = false;
			this.txtMaxPerDay.MS_Last_Control = null;
			this.txtMaxPerDay.MS_Next_Control = null;
			this.txtMaxPerDay.Name = "txtMaxPerDay";
			this.txtMaxPerDay.Size = new System.Drawing.Size(402, 26);
			this.txtMaxPerDay.TabIndex = 3;
			this.txtMaxPerDay.Text = "500";
			// 
			// lblMaxPerMinute
			// 
			this.lblMaxPerMinute.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblMaxPerMinute.Location = new System.Drawing.Point(411, 112);
			this.lblMaxPerMinute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.lblMaxPerMinute.MS_Border_Radius = 5;
			this.lblMaxPerMinute.MS_Color_End = System.Drawing.Color.DodgerBlue;
			this.lblMaxPerMinute.MS_Color_Start = System.Drawing.Color.LightSkyBlue;
			this.lblMaxPerMinute.Name = "lblMaxPerMinute";
			this.lblMaxPerMinute.Size = new System.Drawing.Size(174, 26);
			this.lblMaxPerMinute.TabIndex = 4;
			this.lblMaxPerMinute.Text = "حداکثر پیامک در دقیقه";
			this.lblMaxPerMinute.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtMaxPerMinute
			// 
			this.txtMaxPerMinute.Cursor = System.Windows.Forms.Cursors.Hand;
			this.txtMaxPerMinute.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtMaxPerMinute.Location = new System.Drawing.Point(3, 112);
			this.txtMaxPerMinute.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtMaxPerMinute.MS_BorderColor = System.Drawing.Color.Silver;
			this.txtMaxPerMinute.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.txtMaxPerMinute.MS_Change_Border_Color_On_Enter = false;
			this.txtMaxPerMinute.MS_Change_Color_On_Enter = false;
			this.txtMaxPerMinute.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.txtMaxPerMinute.MS_Enter_Color = System.Drawing.Color.Empty;
			this.txtMaxPerMinute.MS_Exit_By_Down = false;
			this.txtMaxPerMinute.MS_Exit_By_Enter = false;
			this.txtMaxPerMinute.MS_Exit_By_Up = false;
			this.txtMaxPerMinute.MS_Last_Control = null;
			this.txtMaxPerMinute.MS_Next_Control = null;
			this.txtMaxPerMinute.Name = "txtMaxPerMinute";
			this.txtMaxPerMinute.Size = new System.Drawing.Size(402, 26);
			this.txtMaxPerMinute.TabIndex = 5;
			this.txtMaxPerMinute.Text = "50";
			// 
			// lblCharsPerPage
			// 
			this.lblCharsPerPage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblCharsPerPage.Location = new System.Drawing.Point(411, 146);
			this.lblCharsPerPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.lblCharsPerPage.MS_Border_Radius = 5;
			this.lblCharsPerPage.MS_Color_End = System.Drawing.Color.DodgerBlue;
			this.lblCharsPerPage.MS_Color_Start = System.Drawing.Color.LightSkyBlue;
			this.lblCharsPerPage.Name = "lblCharsPerPage";
			this.lblCharsPerPage.Size = new System.Drawing.Size(174, 26);
			this.lblCharsPerPage.TabIndex = 6;
			this.lblCharsPerPage.Text = "حروف در هر صفحه";
			this.lblCharsPerPage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCharsPerPage
			// 
			this.txtCharsPerPage.Cursor = System.Windows.Forms.Cursors.Hand;
			this.txtCharsPerPage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtCharsPerPage.Location = new System.Drawing.Point(3, 146);
			this.txtCharsPerPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtCharsPerPage.MS_BorderColor = System.Drawing.Color.Silver;
			this.txtCharsPerPage.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.txtCharsPerPage.MS_Change_Border_Color_On_Enter = false;
			this.txtCharsPerPage.MS_Change_Color_On_Enter = false;
			this.txtCharsPerPage.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.txtCharsPerPage.MS_Enter_Color = System.Drawing.Color.Empty;
			this.txtCharsPerPage.MS_Exit_By_Down = false;
			this.txtCharsPerPage.MS_Exit_By_Enter = false;
			this.txtCharsPerPage.MS_Exit_By_Up = false;
			this.txtCharsPerPage.MS_Last_Control = null;
			this.txtCharsPerPage.MS_Next_Control = null;
			this.txtCharsPerPage.Name = "txtCharsPerPage";
			this.txtCharsPerPage.Size = new System.Drawing.Size(402, 26);
			this.txtCharsPerPage.TabIndex = 7;
			this.txtCharsPerPage.Text = "70";
			// 
			// lblCountryCode
			// 
			this.lblCountryCode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblCountryCode.Location = new System.Drawing.Point(411, 180);
			this.lblCountryCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.lblCountryCode.MS_Border_Radius = 5;
			this.lblCountryCode.MS_Color_End = System.Drawing.Color.DodgerBlue;
			this.lblCountryCode.MS_Color_Start = System.Drawing.Color.LightSkyBlue;
			this.lblCountryCode.Name = "lblCountryCode";
			this.lblCountryCode.Size = new System.Drawing.Size(174, 26);
			this.lblCountryCode.TabIndex = 8;
			this.lblCountryCode.Text = "پیش‌شماره کشور";
			this.lblCountryCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCountryCode
			// 
			this.txtCountryCode.Cursor = System.Windows.Forms.Cursors.Hand;
			this.txtCountryCode.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtCountryCode.Location = new System.Drawing.Point(3, 180);
			this.txtCountryCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtCountryCode.MS_BorderColor = System.Drawing.Color.Silver;
			this.txtCountryCode.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.txtCountryCode.MS_Change_Border_Color_On_Enter = false;
			this.txtCountryCode.MS_Change_Color_On_Enter = false;
			this.txtCountryCode.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.txtCountryCode.MS_Enter_Color = System.Drawing.Color.Empty;
			this.txtCountryCode.MS_Exit_By_Down = false;
			this.txtCountryCode.MS_Exit_By_Enter = false;
			this.txtCountryCode.MS_Exit_By_Up = false;
			this.txtCountryCode.MS_Last_Control = null;
			this.txtCountryCode.MS_Next_Control = null;
			this.txtCountryCode.Name = "txtCountryCode";
			this.txtCountryCode.Size = new System.Drawing.Size(402, 26);
			this.txtCountryCode.TabIndex = 9;
			this.txtCountryCode.Text = "98";
			// 
			// lblDeviceNumber
			// 
			this.lblDeviceNumber.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblDeviceNumber.Location = new System.Drawing.Point(411, 214);
			this.lblDeviceNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.lblDeviceNumber.MS_Border_Radius = 5;
			this.lblDeviceNumber.MS_Color_End = System.Drawing.Color.DodgerBlue;
			this.lblDeviceNumber.MS_Color_Start = System.Drawing.Color.LightSkyBlue;
			this.lblDeviceNumber.Name = "lblDeviceNumber";
			this.lblDeviceNumber.Size = new System.Drawing.Size(174, 26);
			this.lblDeviceNumber.TabIndex = 10;
			this.lblDeviceNumber.Text = "شماره دستگاه (۰ تا ۱۲۷)";
			this.lblDeviceNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtDeviceNumber
			// 
			this.txtDeviceNumber.Cursor = System.Windows.Forms.Cursors.Hand;
			this.txtDeviceNumber.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtDeviceNumber.Location = new System.Drawing.Point(3, 214);
			this.txtDeviceNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtDeviceNumber.MS_BorderColor = System.Drawing.Color.Silver;
			this.txtDeviceNumber.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.txtDeviceNumber.MS_Change_Border_Color_On_Enter = false;
			this.txtDeviceNumber.MS_Change_Color_On_Enter = false;
			this.txtDeviceNumber.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.txtDeviceNumber.MS_Enter_Color = System.Drawing.Color.Empty;
			this.txtDeviceNumber.MS_Exit_By_Down = false;
			this.txtDeviceNumber.MS_Exit_By_Enter = false;
			this.txtDeviceNumber.MS_Exit_By_Up = false;
			this.txtDeviceNumber.MS_Last_Control = null;
			this.txtDeviceNumber.MS_Next_Control = null;
			this.txtDeviceNumber.Name = "txtDeviceNumber";
			this.txtDeviceNumber.Size = new System.Drawing.Size(402, 26);
			this.txtDeviceNumber.TabIndex = 11;
			this.txtDeviceNumber.Text = "1";
			// 
			// lblValidity
			// 
			this.lblValidity.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblValidity.Location = new System.Drawing.Point(411, 248);
			this.lblValidity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.lblValidity.MS_Border_Radius = 5;
			this.lblValidity.MS_Color_End = System.Drawing.Color.DodgerBlue;
			this.lblValidity.MS_Color_Start = System.Drawing.Color.LightSkyBlue;
			this.lblValidity.Name = "lblValidity";
			this.lblValidity.Size = new System.Drawing.Size(174, 26);
			this.lblValidity.TabIndex = 12;
			this.lblValidity.Text = "مدت اعتبار پیامک";
			this.lblValidity.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmbValidity
			// 
			this.cmbValidity.Cursor = System.Windows.Forms.Cursors.Hand;
			this.cmbValidity.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cmbValidity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbValidity.Items.AddRange(new object[] {
            "۱ ساعت",
            "۳ ساعت",
            "۶ ساعت",
            "۱۲ ساعت",
            "۲۴ ساعت",
            "۱ هفته",
            "حداکثر"});
			this.cmbValidity.Location = new System.Drawing.Point(3, 248);
			this.cmbValidity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cmbValidity.MS_BorderColor = System.Drawing.Color.Silver;
			this.cmbValidity.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.cmbValidity.MS_Change_Border_Color_On_Enter = false;
			this.cmbValidity.MS_Change_Color_On_Enter = false;
			this.cmbValidity.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.cmbValidity.MS_Enter_Color = System.Drawing.Color.Empty;
			this.cmbValidity.MS_Exit_By_Down = false;
			this.cmbValidity.MS_Exit_By_Enter = false;
			this.cmbValidity.MS_Exit_By_Up = false;
			this.cmbValidity.MS_Last_Control = null;
			this.cmbValidity.MS_Next_Control = null;
			this.cmbValidity.Name = "cmbValidity";
			this.cmbValidity.Size = new System.Drawing.Size(402, 21);
			this.cmbValidity.TabIndex = 13;
			// 
			// lblPartInterval
			// 
			this.lblPartInterval.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblPartInterval.Location = new System.Drawing.Point(411, 282);
			this.lblPartInterval.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.lblPartInterval.MS_Border_Radius = 5;
			this.lblPartInterval.MS_Color_End = System.Drawing.Color.DodgerBlue;
			this.lblPartInterval.MS_Color_Start = System.Drawing.Color.LightSkyBlue;
			this.lblPartInterval.Name = "lblPartInterval";
			this.lblPartInterval.Size = new System.Drawing.Size(174, 26);
			this.lblPartInterval.TabIndex = 14;
			this.lblPartInterval.Text = "تاخیر بین بخش‌ها (ms)";
			this.lblPartInterval.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtPartInterval
			// 
			this.txtPartInterval.Cursor = System.Windows.Forms.Cursors.Hand;
			this.txtPartInterval.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtPartInterval.Location = new System.Drawing.Point(3, 282);
			this.txtPartInterval.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtPartInterval.MS_BorderColor = System.Drawing.Color.Silver;
			this.txtPartInterval.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.txtPartInterval.MS_Change_Border_Color_On_Enter = false;
			this.txtPartInterval.MS_Change_Color_On_Enter = false;
			this.txtPartInterval.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.txtPartInterval.MS_Enter_Color = System.Drawing.Color.Empty;
			this.txtPartInterval.MS_Exit_By_Down = false;
			this.txtPartInterval.MS_Exit_By_Enter = false;
			this.txtPartInterval.MS_Exit_By_Up = false;
			this.txtPartInterval.MS_Last_Control = null;
			this.txtPartInterval.MS_Next_Control = null;
			this.txtPartInterval.Name = "txtPartInterval";
			this.txtPartInterval.Size = new System.Drawing.Size(402, 26);
			this.txtPartInterval.TabIndex = 15;
			this.txtPartInterval.Text = "1000";
			// 
			// lblModemRetry
			// 
			this.lblModemRetry.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblModemRetry.Location = new System.Drawing.Point(411, 316);
			this.lblModemRetry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.lblModemRetry.MS_Border_Radius = 5;
			this.lblModemRetry.MS_Color_End = System.Drawing.Color.DodgerBlue;
			this.lblModemRetry.MS_Color_Start = System.Drawing.Color.LightSkyBlue;
			this.lblModemRetry.Name = "lblModemRetry";
			this.lblModemRetry.Size = new System.Drawing.Size(174, 26);
			this.lblModemRetry.TabIndex = 16;
			this.lblModemRetry.Text = "تلاش مجدد مودم";
			this.lblModemRetry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtModemRetry
			// 
			this.txtModemRetry.Cursor = System.Windows.Forms.Cursors.Hand;
			this.txtModemRetry.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtModemRetry.Location = new System.Drawing.Point(3, 316);
			this.txtModemRetry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtModemRetry.MS_BorderColor = System.Drawing.Color.Silver;
			this.txtModemRetry.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.txtModemRetry.MS_Change_Border_Color_On_Enter = false;
			this.txtModemRetry.MS_Change_Color_On_Enter = false;
			this.txtModemRetry.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.txtModemRetry.MS_Enter_Color = System.Drawing.Color.Empty;
			this.txtModemRetry.MS_Exit_By_Down = false;
			this.txtModemRetry.MS_Exit_By_Enter = false;
			this.txtModemRetry.MS_Exit_By_Up = false;
			this.txtModemRetry.MS_Last_Control = null;
			this.txtModemRetry.MS_Next_Control = null;
			this.txtModemRetry.Name = "txtModemRetry";
			this.txtModemRetry.Size = new System.Drawing.Size(402, 26);
			this.txtModemRetry.TabIndex = 17;
			this.txtModemRetry.Text = "2";
			// 
			// lblSmsCenter
			// 
			this.lblSmsCenter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblSmsCenter.Location = new System.Drawing.Point(411, 350);
			this.lblSmsCenter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.lblSmsCenter.MS_Border_Radius = 5;
			this.lblSmsCenter.MS_Color_End = System.Drawing.Color.DodgerBlue;
			this.lblSmsCenter.MS_Color_Start = System.Drawing.Color.LightSkyBlue;
			this.lblSmsCenter.Name = "lblSmsCenter";
			this.lblSmsCenter.Size = new System.Drawing.Size(174, 26);
			this.lblSmsCenter.TabIndex = 18;
			this.lblSmsCenter.Text = "مرکز پیامک (اختیاری)";
			this.lblSmsCenter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtSmsCenter
			// 
			this.txtSmsCenter.Cursor = System.Windows.Forms.Cursors.Hand;
			this.txtSmsCenter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtSmsCenter.Location = new System.Drawing.Point(3, 350);
			this.txtSmsCenter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtSmsCenter.MS_BorderColor = System.Drawing.Color.Silver;
			this.txtSmsCenter.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.txtSmsCenter.MS_Change_Border_Color_On_Enter = false;
			this.txtSmsCenter.MS_Change_Color_On_Enter = false;
			this.txtSmsCenter.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.txtSmsCenter.MS_Enter_Color = System.Drawing.Color.Empty;
			this.txtSmsCenter.MS_Exit_By_Down = false;
			this.txtSmsCenter.MS_Exit_By_Enter = false;
			this.txtSmsCenter.MS_Exit_By_Up = false;
			this.txtSmsCenter.MS_Last_Control = null;
			this.txtSmsCenter.MS_Next_Control = null;
			this.txtSmsCenter.Name = "txtSmsCenter";
			this.txtSmsCenter.Size = new System.Drawing.Size(402, 26);
			this.txtSmsCenter.TabIndex = 19;
			// 
			// lblReadInterval
			// 
			this.lblReadInterval.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblReadInterval.Location = new System.Drawing.Point(411, 384);
			this.lblReadInterval.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.lblReadInterval.MS_Border_Radius = 5;
			this.lblReadInterval.MS_Color_End = System.Drawing.Color.DodgerBlue;
			this.lblReadInterval.MS_Color_Start = System.Drawing.Color.LightSkyBlue;
			this.lblReadInterval.Name = "lblReadInterval";
			this.lblReadInterval.Size = new System.Drawing.Size(174, 26);
			this.lblReadInterval.TabIndex = 20;
			this.lblReadInterval.Text = "فاصله خواندن (دقیقه)";
			this.lblReadInterval.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtReadInterval
			// 
			this.txtReadInterval.Cursor = System.Windows.Forms.Cursors.Hand;
			this.txtReadInterval.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtReadInterval.Location = new System.Drawing.Point(3, 384);
			this.txtReadInterval.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtReadInterval.MS_BorderColor = System.Drawing.Color.Silver;
			this.txtReadInterval.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.txtReadInterval.MS_Change_Border_Color_On_Enter = false;
			this.txtReadInterval.MS_Change_Color_On_Enter = false;
			this.txtReadInterval.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.txtReadInterval.MS_Enter_Color = System.Drawing.Color.Empty;
			this.txtReadInterval.MS_Exit_By_Down = false;
			this.txtReadInterval.MS_Exit_By_Enter = false;
			this.txtReadInterval.MS_Exit_By_Up = false;
			this.txtReadInterval.MS_Last_Control = null;
			this.txtReadInterval.MS_Next_Control = null;
			this.txtReadInterval.Name = "txtReadInterval";
			this.txtReadInterval.Size = new System.Drawing.Size(402, 26);
			this.txtReadInterval.TabIndex = 21;
			this.txtReadInterval.Text = "5";
			// 
			// lblMaxRetry
			// 
			this.lblMaxRetry.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lblMaxRetry.Location = new System.Drawing.Point(411, 418);
			this.lblMaxRetry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.lblMaxRetry.MS_Border_Radius = 5;
			this.lblMaxRetry.MS_Color_End = System.Drawing.Color.DodgerBlue;
			this.lblMaxRetry.MS_Color_Start = System.Drawing.Color.LightSkyBlue;
			this.lblMaxRetry.Name = "lblMaxRetry";
			this.lblMaxRetry.Size = new System.Drawing.Size(174, 26);
			this.lblMaxRetry.TabIndex = 22;
			this.lblMaxRetry.Text = "بازگشت به صف پس از خطا";
			this.lblMaxRetry.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtMaxRetry
			// 
			this.txtMaxRetry.Cursor = System.Windows.Forms.Cursors.Hand;
			this.txtMaxRetry.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtMaxRetry.Location = new System.Drawing.Point(3, 418);
			this.txtMaxRetry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.txtMaxRetry.MS_BorderColor = System.Drawing.Color.Silver;
			this.txtMaxRetry.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.txtMaxRetry.MS_Change_Border_Color_On_Enter = false;
			this.txtMaxRetry.MS_Change_Color_On_Enter = false;
			this.txtMaxRetry.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.txtMaxRetry.MS_Enter_Color = System.Drawing.Color.Empty;
			this.txtMaxRetry.MS_Exit_By_Down = false;
			this.txtMaxRetry.MS_Exit_By_Enter = false;
			this.txtMaxRetry.MS_Exit_By_Up = false;
			this.txtMaxRetry.MS_Last_Control = null;
			this.txtMaxRetry.MS_Next_Control = null;
			this.txtMaxRetry.Name = "txtMaxRetry";
			this.txtMaxRetry.Size = new System.Drawing.Size(402, 26);
			this.txtMaxRetry.TabIndex = 23;
			this.txtMaxRetry.Text = "3";
			// 
			// panelChecks
			// 
			this.table.SetColumnSpan(this.panelChecks, 2);
			this.panelChecks.Controls.Add(this.chkIsModemHost);
			this.panelChecks.Controls.Add(this.chkDeliveryReport);
			this.panelChecks.Controls.Add(this.chkDeleteAfterRead);
			this.panelChecks.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelChecks.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.panelChecks.Location = new System.Drawing.Point(3, 452);
			this.panelChecks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panelChecks.Name = "panelChecks";
			this.panelChecks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.panelChecks.Size = new System.Drawing.Size(582, 104);
			this.panelChecks.TabIndex = 24;
			// 
			// chkIsModemHost
			// 
			this.chkIsModemHost.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkIsModemHost.Location = new System.Drawing.Point(339, 4);
			this.chkIsModemHost.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.chkIsModemHost.MS_BorderColor = System.Drawing.Color.Silver;
			this.chkIsModemHost.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.chkIsModemHost.MS_Change_Border_Color_On_Enter = false;
			this.chkIsModemHost.MS_Change_Color_On_Checked = false;
			this.chkIsModemHost.MS_Change_Color_On_Enter = false;
			this.chkIsModemHost.MS_Checked_Color = System.Drawing.Color.Empty;
			this.chkIsModemHost.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.chkIsModemHost.MS_Enter_Color = System.Drawing.Color.Empty;
			this.chkIsModemHost.MS_Exit_By_Down = false;
			this.chkIsModemHost.MS_Exit_By_Enter = false;
			this.chkIsModemHost.MS_Exit_By_Up = false;
			this.chkIsModemHost.MS_Last_Control = null;
			this.chkIsModemHost.MS_Next_Control = null;
			this.chkIsModemHost.MS_UnChecked_Color = System.Drawing.Color.Empty;
			this.chkIsModemHost.Name = "chkIsModemHost";
			this.chkIsModemHost.Size = new System.Drawing.Size(240, 24);
			this.chkIsModemHost.TabIndex = 0;
			this.chkIsModemHost.Text = "این کامپیوتر به مودم وصل است";
			// 
			// chkDeliveryReport
			// 
			this.chkDeliveryReport.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkDeliveryReport.Location = new System.Drawing.Point(399, 36);
			this.chkDeliveryReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.chkDeliveryReport.MS_BorderColor = System.Drawing.Color.Silver;
			this.chkDeliveryReport.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.chkDeliveryReport.MS_Change_Border_Color_On_Enter = false;
			this.chkDeliveryReport.MS_Change_Color_On_Checked = false;
			this.chkDeliveryReport.MS_Change_Color_On_Enter = false;
			this.chkDeliveryReport.MS_Checked_Color = System.Drawing.Color.Empty;
			this.chkDeliveryReport.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.chkDeliveryReport.MS_Enter_Color = System.Drawing.Color.Empty;
			this.chkDeliveryReport.MS_Exit_By_Down = false;
			this.chkDeliveryReport.MS_Exit_By_Enter = false;
			this.chkDeliveryReport.MS_Exit_By_Up = false;
			this.chkDeliveryReport.MS_Last_Control = null;
			this.chkDeliveryReport.MS_Next_Control = null;
			this.chkDeliveryReport.MS_UnChecked_Color = System.Drawing.Color.Empty;
			this.chkDeliveryReport.Name = "chkDeliveryReport";
			this.chkDeliveryReport.Size = new System.Drawing.Size(180, 24);
			this.chkDeliveryReport.TabIndex = 1;
			this.chkDeliveryReport.Text = "درخواست گزارش تحویل";
			// 
			// chkDeleteAfterRead
			// 
			this.chkDeleteAfterRead.Cursor = System.Windows.Forms.Cursors.Hand;
			this.chkDeleteAfterRead.Location = new System.Drawing.Point(319, 68);
			this.chkDeleteAfterRead.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.chkDeleteAfterRead.MS_BorderColor = System.Drawing.Color.Silver;
			this.chkDeleteAfterRead.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.chkDeleteAfterRead.MS_Change_Border_Color_On_Enter = false;
			this.chkDeleteAfterRead.MS_Change_Color_On_Checked = false;
			this.chkDeleteAfterRead.MS_Change_Color_On_Enter = false;
			this.chkDeleteAfterRead.MS_Checked_Color = System.Drawing.Color.Empty;
			this.chkDeleteAfterRead.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.chkDeleteAfterRead.MS_Enter_Color = System.Drawing.Color.Empty;
			this.chkDeleteAfterRead.MS_Exit_By_Down = false;
			this.chkDeleteAfterRead.MS_Exit_By_Enter = false;
			this.chkDeleteAfterRead.MS_Exit_By_Up = false;
			this.chkDeleteAfterRead.MS_Last_Control = null;
			this.chkDeleteAfterRead.MS_Next_Control = null;
			this.chkDeleteAfterRead.MS_UnChecked_Color = System.Drawing.Color.Empty;
			this.chkDeleteAfterRead.Name = "chkDeleteAfterRead";
			this.chkDeleteAfterRead.Size = new System.Drawing.Size(260, 24);
			this.chkDeleteAfterRead.TabIndex = 2;
			this.chkDeleteAfterRead.Text = "حذف پیامک از مودم پس از خواندن";
			// 
			// panelButtons
			// 
			this.table.SetColumnSpan(this.panelButtons, 2);
			this.panelButtons.Controls.Add(this.btnOk);
			this.panelButtons.Controls.Add(this.btnCancel);
			this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelButtons.Location = new System.Drawing.Point(3, 564);
			this.panelButtons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.panelButtons.Name = "panelButtons";
			this.panelButtons.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.panelButtons.Size = new System.Drawing.Size(582, 57);
			this.panelButtons.TabIndex = 25;
			// 
			// btnOk
			// 
			this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnOk.Location = new System.Drawing.Point(469, 4);
			this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnOk.MS_BorderColor = System.Drawing.Color.DodgerBlue;
			this.btnOk.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.btnOk.MS_Change_Border_Color_On_Enter = false;
			this.btnOk.MS_Change_Color_On_Enter = false;
			this.btnOk.MS_Color_End = System.Drawing.Color.PowderBlue;
			this.btnOk.MS_Color_Start = System.Drawing.Color.AliceBlue;
			this.btnOk.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.btnOk.MS_Enter_Color = System.Drawing.Color.Empty;
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(110, 40);
			this.btnOk.TabIndex = 0;
			this.btnOk.Text = "تأیید";
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnCancel.Location = new System.Drawing.Point(353, 4);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnCancel.MS_BorderColor = System.Drawing.Color.DodgerBlue;
			this.btnCancel.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.btnCancel.MS_Change_Border_Color_On_Enter = false;
			this.btnCancel.MS_Change_Color_On_Enter = false;
			this.btnCancel.MS_Color_End = System.Drawing.Color.PowderBlue;
			this.btnCancel.MS_Color_Start = System.Drawing.Color.AliceBlue;
			this.btnCancel.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.btnCancel.MS_Enter_Color = System.Drawing.Color.Empty;
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(110, 40);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "انصراف";
			// 
			// FormSettings
			// 
			this.AcceptButton = this.btnOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(604, 641);
			this.Controls.Add(this.panelMain);
			this.Font = new System.Drawing.Font("IRANSans(Small)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.ForeColor = System.Drawing.SystemColors.Control;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormSettings";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "تنظیمات ماژول ارسال پیامک";
			this.table.ResumeLayout(false);
			this.table.PerformLayout();
			this.panelChecks.ResumeLayout(false);
			this.panelButtons.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private MS_Control.Controls.MS_Panel panelMain;
		private System.Windows.Forms.TableLayoutPanel table;
		private MS_Control.Controls.MS_Label lblConnection;
		private MS_Control.Controls.MS_TextBox txtConnection;
		private MS_Control.Controls.MS_Label lblMaxPerDay;
		private MS_Control.Controls.MS_TextBox txtMaxPerDay;
		private MS_Control.Controls.MS_Label lblMaxPerMinute;
		private MS_Control.Controls.MS_TextBox txtMaxPerMinute;
		private MS_Control.Controls.MS_Label lblCharsPerPage;
		private MS_Control.Controls.MS_TextBox txtCharsPerPage;
		private MS_Control.Controls.MS_Label lblCountryCode;
		private MS_Control.Controls.MS_TextBox txtCountryCode;
		private MS_Control.Controls.MS_Label lblDeviceNumber;
		private MS_Control.Controls.MS_TextBox txtDeviceNumber;
		private MS_Control.Controls.MS_Label lblValidity;
		private MS_Control.Controls.MS_ComboBox cmbValidity;
		private MS_Control.Controls.MS_Label lblPartInterval;
		private MS_Control.Controls.MS_TextBox txtPartInterval;
		private MS_Control.Controls.MS_Label lblModemRetry;
		private MS_Control.Controls.MS_TextBox txtModemRetry;
		private MS_Control.Controls.MS_Label lblSmsCenter;
		private MS_Control.Controls.MS_TextBox txtSmsCenter;
		private MS_Control.Controls.MS_Label lblReadInterval;
		private MS_Control.Controls.MS_TextBox txtReadInterval;
		private MS_Control.Controls.MS_Label lblMaxRetry;
		private MS_Control.Controls.MS_TextBox txtMaxRetry;
		private System.Windows.Forms.FlowLayoutPanel panelChecks;
		private MS_Control.Controls.MS_CheckBox chkIsModemHost;
		private MS_Control.Controls.MS_CheckBox chkDeliveryReport;
		private MS_Control.Controls.MS_CheckBox chkDeleteAfterRead;
		private System.Windows.Forms.FlowLayoutPanel panelButtons;
		private MS_Control.Controls.MS_Button btnOk;
		private MS_Control.Controls.MS_Button btnCancel;
	}
}
