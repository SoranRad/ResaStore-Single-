namespace NZ.General.WinForms.Setting
{
	partial class TabSettingContainer
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabSettingContainer));
			this.mS_Notify1 = new MS_Control.Controls.MS_Notify();
			this.NzTabs = new Janus.Windows.UI.Tab.UITab();
			this.NsGeneralSetting = new ShareLib.Component.NsSettingTabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.NsBackup = new MS_Control.Controls.MS_CheckBox();
			this.NsAlarm = new MS_Control.Controls.MS_CheckBox();
			this.NsMultipleDatabase = new MS_Control.Controls.MS_CheckBox();
			this.NsLown = new MS_Control.Controls.MS_CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.NsConStr = new MS_Control.Controls.MS_TextBox();
			this.NsSms = new MS_Control.Controls.MS_CheckBox();
			this.NsPayments = new MS_Control.Controls.MS_CheckBox();
			this.NsStorage = new MS_Control.Controls.MS_CheckBox();
			this.NsSmsTabPage = new ShareLib.Component.NsSettingTabPage();
			this.NsSmsActivation = new MS_Control.Controls.MS_CheckBox();
			this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
			this.NsExpiration = new MS_Control.Controls.MS_TextBox();
			this.NsSmsAmount = new MS_Control.Controls.MS_Decimal_Label();
			this.NsSmsCount = new MS_Control.Controls.MS_Decimal_Label();
			this.nsLoading2 = new System.Windows.Forms.PictureBox();
			this.NzGetInfo = new MS_Control.Controls.MS_Button_GridX();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.NsGroupBoxSmsInfo = new Janus.Windows.EditControls.UIGroupBox();
			this.NsLoading = new System.Windows.Forms.PictureBox();
			this.NsOK = new MS_Control.Controls.MS_Button_GridX();
			this.NsPassword = new MS_Control.Controls.MS_TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.NsUsername = new MS_Control.Controls.MS_TextBox();
			this.label3 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.NzTabs)).BeginInit();
			this.NzTabs.SuspendLayout();
			this.NsGeneralSetting.SuspendLayout();
			this.NsSmsTabPage.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
			this.uiGroupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nsLoading2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.NsGroupBoxSmsInfo)).BeginInit();
			this.NsGroupBoxSmsInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.NsLoading)).BeginInit();
			this.SuspendLayout();
			// 
			// NzTabs
			// 
			this.NzTabs.BackColor = System.Drawing.Color.Transparent;
			this.NzTabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.NzTabs.FirstTabOffset = 10;
			this.NzTabs.Font = new System.Drawing.Font("IRANSans(Small)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NzTabs.Location = new System.Drawing.Point(0, 0);
			this.NzTabs.Name = "NzTabs";
			this.NzTabs.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
			this.NzTabs.Office2007CustomColor = System.Drawing.Color.AntiqueWhite;
			this.NzTabs.PageBorder = Janus.Windows.UI.Tab.PageBorder.None;
			this.NzTabs.PanelFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzTabs.ShowFocusRectangle = false;
			this.NzTabs.Size = new System.Drawing.Size(764, 418);
			this.NzTabs.TabIndex = 711;
			this.NzTabs.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.NsGeneralSetting,
            this.NsSmsTabPage});
			this.NzTabs.TabsStateStyles.DisabledFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.NzTabs.TabsStateStyles.DisabledFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.NzTabs.TabsStateStyles.FormatStyle.BackColor = System.Drawing.Color.LightBlue;
			this.NzTabs.TabsStateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.Gold;
			this.NzTabs.TabsStateStyles.SelectedFormatStyle.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
			this.NzTabs.UseThemes = false;
			this.NzTabs.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
			// 
			// NsGeneralSetting
			// 
			this.NsGeneralSetting.AutoScroll = true;
			this.NsGeneralSetting.Controls.Add(this.label2);
			this.NsGeneralSetting.Controls.Add(this.NsBackup);
			this.NsGeneralSetting.Controls.Add(this.NsAlarm);
			this.NsGeneralSetting.Controls.Add(this.NsMultipleDatabase);
			this.NsGeneralSetting.Controls.Add(this.NsLown);
			this.NsGeneralSetting.Controls.Add(this.label1);
			this.NsGeneralSetting.Controls.Add(this.label4);
			this.NsGeneralSetting.Controls.Add(this.NsConStr);
			this.NsGeneralSetting.Controls.Add(this.NsSms);
			this.NsGeneralSetting.Controls.Add(this.NsPayments);
			this.NsGeneralSetting.Controls.Add(this.NsStorage);
			this.NsGeneralSetting.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NsGeneralSetting.Location = new System.Drawing.Point(0, 27);
			this.NsGeneralSetting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.NsGeneralSetting.Name = "NsGeneralSetting";
			this.NsGeneralSetting.PanelFormatStyle.Alpha = 70;
			this.NsGeneralSetting.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
			this.NsGeneralSetting.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
			this.NsGeneralSetting.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsGeneralSetting.Size = new System.Drawing.Size(764, 391);
			this.NsGeneralSetting.TabStop = true;
			this.NsGeneralSetting.Text = "  عمومی   ";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F);
			this.label2.Location = new System.Drawing.Point(685, 273);
			this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 23);
			this.label2.TabIndex = 828;
			this.label2.Text = "متفـرقه";
			// 
			// NsBackup
			// 
			this.NsBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsBackup.BackColor = System.Drawing.Color.Transparent;
			this.NsBackup.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsBackup.Location = new System.Drawing.Point(312, 328);
			this.NsBackup.Margin = new System.Windows.Forms.Padding(7, 21, 7, 21);
			this.NsBackup.MS_BorderColor = System.Drawing.Color.Transparent;
			this.NsBackup.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsBackup.MS_Change_Border_Color_On_Enter = true;
			this.NsBackup.MS_Change_Color_On_Checked = true;
			this.NsBackup.MS_Change_Color_On_Enter = true;
			this.NsBackup.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NsBackup.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsBackup.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsBackup.MS_Exit_By_Down = true;
			this.NsBackup.MS_Exit_By_Enter = true;
			this.NsBackup.MS_Exit_By_Up = true;
			this.NsBackup.MS_Last_Control = null;
			this.NsBackup.MS_Next_Control = null;
			this.NsBackup.MS_UnChecked_Color = System.Drawing.Color.Transparent;
			this.NsBackup.Name = "NsBackup";
			this.NsBackup.ShowFocusRectangle = false;
			this.NsBackup.Size = new System.Drawing.Size(399, 21);
			this.NsBackup.TabIndex = 827;
			this.NsBackup.Text = " در هنگام خروج پشتیبان بانک اصلاعاتی گرفته شود.";
			this.NsBackup.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			// 
			// NsAlarm
			// 
			this.NsAlarm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsAlarm.BackColor = System.Drawing.Color.Transparent;
			this.NsAlarm.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsAlarm.Location = new System.Drawing.Point(312, 297);
			this.NsAlarm.Margin = new System.Windows.Forms.Padding(7, 21, 7, 21);
			this.NsAlarm.MS_BorderColor = System.Drawing.Color.Transparent;
			this.NsAlarm.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsAlarm.MS_Change_Border_Color_On_Enter = true;
			this.NsAlarm.MS_Change_Color_On_Checked = true;
			this.NsAlarm.MS_Change_Color_On_Enter = true;
			this.NsAlarm.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NsAlarm.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsAlarm.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsAlarm.MS_Exit_By_Down = true;
			this.NsAlarm.MS_Exit_By_Enter = true;
			this.NsAlarm.MS_Exit_By_Up = true;
			this.NsAlarm.MS_Last_Control = null;
			this.NsAlarm.MS_Next_Control = null;
			this.NsAlarm.MS_UnChecked_Color = System.Drawing.Color.Transparent;
			this.NsAlarm.Name = "NsAlarm";
			this.NsAlarm.ShowFocusRectangle = false;
			this.NsAlarm.Size = new System.Drawing.Size(399, 21);
			this.NsAlarm.TabIndex = 827;
			this.NsAlarm.Text = " سیستم هشدار برای کاربر فعال باشد.";
			this.NsAlarm.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			// 
			// NsMultipleDatabase
			// 
			this.NsMultipleDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsMultipleDatabase.BackColor = System.Drawing.Color.Transparent;
			this.NsMultipleDatabase.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsMultipleDatabase.Location = new System.Drawing.Point(312, 73);
			this.NsMultipleDatabase.Margin = new System.Windows.Forms.Padding(7, 21, 7, 21);
			this.NsMultipleDatabase.MS_BorderColor = System.Drawing.Color.Transparent;
			this.NsMultipleDatabase.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsMultipleDatabase.MS_Change_Border_Color_On_Enter = true;
			this.NsMultipleDatabase.MS_Change_Color_On_Checked = true;
			this.NsMultipleDatabase.MS_Change_Color_On_Enter = true;
			this.NsMultipleDatabase.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NsMultipleDatabase.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsMultipleDatabase.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsMultipleDatabase.MS_Exit_By_Down = true;
			this.NsMultipleDatabase.MS_Exit_By_Enter = true;
			this.NsMultipleDatabase.MS_Exit_By_Up = true;
			this.NsMultipleDatabase.MS_Last_Control = null;
			this.NsMultipleDatabase.MS_Next_Control = null;
			this.NsMultipleDatabase.MS_UnChecked_Color = System.Drawing.Color.Transparent;
			this.NsMultipleDatabase.Name = "NsMultipleDatabase";
			this.NsMultipleDatabase.ShowFocusRectangle = false;
			this.NsMultipleDatabase.Size = new System.Drawing.Size(399, 21);
			this.NsMultipleDatabase.TabIndex = 826;
			this.NsMultipleDatabase.Text = "  امکان اتصال به چند بانک اطلاعاتی فعال باشد.";
			this.NsMultipleDatabase.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			// 
			// NsLown
			// 
			this.NsLown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsLown.BackColor = System.Drawing.Color.Transparent;
			this.NsLown.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsLown.Location = new System.Drawing.Point(312, 232);
			this.NsLown.Margin = new System.Windows.Forms.Padding(7, 21, 7, 21);
			this.NsLown.MS_BorderColor = System.Drawing.Color.Transparent;
			this.NsLown.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsLown.MS_Change_Border_Color_On_Enter = true;
			this.NsLown.MS_Change_Color_On_Checked = true;
			this.NsLown.MS_Change_Color_On_Enter = true;
			this.NsLown.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NsLown.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsLown.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsLown.MS_Exit_By_Down = true;
			this.NsLown.MS_Exit_By_Enter = true;
			this.NsLown.MS_Exit_By_Up = true;
			this.NsLown.MS_Last_Control = null;
			this.NsLown.MS_Next_Control = null;
			this.NsLown.MS_UnChecked_Color = System.Drawing.Color.Transparent;
			this.NsLown.Name = "NsLown";
			this.NsLown.ShowFocusRectangle = false;
			this.NsLown.Size = new System.Drawing.Size(399, 30);
			this.NsLown.TabIndex = 825;
			this.NsLown.Text = "  سیستم اقساط";
			this.NsLown.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F);
			this.label1.Location = new System.Drawing.Point(641, 115);
			this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 23);
			this.label1.TabIndex = 824;
			this.label1.Text = "ماژول های فعال";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F);
			this.label4.Location = new System.Drawing.Point(617, 9);
			this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(116, 23);
			this.label4.TabIndex = 823;
			this.label4.Text = "آدرس بانک اصلاعاتی";
			// 
			// NsConStr
			// 
			this.NsConStr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NsConStr.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.TextButton;
			this.NsConStr.ButtonText = "...";
			this.NsConStr.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsConStr.Location = new System.Drawing.Point(7, 38);
			this.NsConStr.Margin = new System.Windows.Forms.Padding(7, 21, 7, 21);
			this.NsConStr.MaxLength = 200;
			this.NsConStr.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsConStr.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsConStr.MS_Change_Border_Color_On_Enter = true;
			this.NsConStr.MS_Change_Color_On_Enter = true;
			this.NsConStr.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsConStr.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsConStr.MS_Exit_By_Down = true;
			this.NsConStr.MS_Exit_By_Enter = true;
			this.NsConStr.MS_Exit_By_Up = true;
			this.NsConStr.MS_Last_Control = null;
			this.NsConStr.MS_Next_Control = null;
			this.NsConStr.Name = "NsConStr";
			this.NsConStr.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Blue;
			this.NsConStr.ReadOnly = true;
			this.NsConStr.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.NsConStr.Size = new System.Drawing.Size(722, 29);
			this.NsConStr.TabIndex = 822;
			this.NsConStr.TextAlignment = Janus.Windows.GridEX.TextAlignment.Near;
			this.NsConStr.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			this.NsConStr.WordWrap = false;
			this.NsConStr.ButtonClick += new System.EventHandler(this.NzTitle_ButtonClick);
			// 
			// NsSms
			// 
			this.NsSms.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsSms.BackColor = System.Drawing.Color.Transparent;
			this.NsSms.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsSms.Location = new System.Drawing.Point(312, 202);
			this.NsSms.Margin = new System.Windows.Forms.Padding(7, 21, 7, 21);
			this.NsSms.MS_BorderColor = System.Drawing.Color.Transparent;
			this.NsSms.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsSms.MS_Change_Border_Color_On_Enter = true;
			this.NsSms.MS_Change_Color_On_Checked = true;
			this.NsSms.MS_Change_Color_On_Enter = true;
			this.NsSms.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NsSms.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsSms.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsSms.MS_Exit_By_Down = true;
			this.NsSms.MS_Exit_By_Enter = true;
			this.NsSms.MS_Exit_By_Up = true;
			this.NsSms.MS_Last_Control = null;
			this.NsSms.MS_Next_Control = null;
			this.NsSms.MS_UnChecked_Color = System.Drawing.Color.Transparent;
			this.NsSms.Name = "NsSms";
			this.NsSms.ShowFocusRectangle = false;
			this.NsSms.Size = new System.Drawing.Size(399, 30);
			this.NsSms.TabIndex = 821;
			this.NsSms.Text = "  ارسال پیامک";
			this.NsSms.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			// 
			// NsPayments
			// 
			this.NsPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsPayments.BackColor = System.Drawing.Color.Transparent;
			this.NsPayments.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsPayments.Location = new System.Drawing.Point(312, 172);
			this.NsPayments.Margin = new System.Windows.Forms.Padding(7, 21, 7, 21);
			this.NsPayments.MS_BorderColor = System.Drawing.Color.Transparent;
			this.NsPayments.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsPayments.MS_Change_Border_Color_On_Enter = true;
			this.NsPayments.MS_Change_Color_On_Checked = true;
			this.NsPayments.MS_Change_Color_On_Enter = true;
			this.NsPayments.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NsPayments.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsPayments.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsPayments.MS_Exit_By_Down = true;
			this.NsPayments.MS_Exit_By_Enter = true;
			this.NsPayments.MS_Exit_By_Up = true;
			this.NsPayments.MS_Last_Control = null;
			this.NsPayments.MS_Next_Control = null;
			this.NsPayments.MS_UnChecked_Color = System.Drawing.Color.Transparent;
			this.NsPayments.Name = "NsPayments";
			this.NsPayments.ShowFocusRectangle = false;
			this.NsPayments.Size = new System.Drawing.Size(399, 30);
			this.NsPayments.TabIndex = 820;
			this.NsPayments.Text = "  خزانه داری";
			this.NsPayments.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			// 
			// NsStorage
			// 
			this.NsStorage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsStorage.BackColor = System.Drawing.Color.Transparent;
			this.NsStorage.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsStorage.Location = new System.Drawing.Point(312, 142);
			this.NsStorage.Margin = new System.Windows.Forms.Padding(7, 21, 7, 21);
			this.NsStorage.MS_BorderColor = System.Drawing.Color.Transparent;
			this.NsStorage.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsStorage.MS_Change_Border_Color_On_Enter = true;
			this.NsStorage.MS_Change_Color_On_Checked = true;
			this.NsStorage.MS_Change_Color_On_Enter = true;
			this.NsStorage.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NsStorage.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsStorage.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsStorage.MS_Exit_By_Down = true;
			this.NsStorage.MS_Exit_By_Enter = true;
			this.NsStorage.MS_Exit_By_Up = true;
			this.NsStorage.MS_Last_Control = null;
			this.NsStorage.MS_Next_Control = null;
			this.NsStorage.MS_UnChecked_Color = System.Drawing.Color.Transparent;
			this.NsStorage.Name = "NsStorage";
			this.NsStorage.ShowFocusRectangle = false;
			this.NsStorage.Size = new System.Drawing.Size(399, 30);
			this.NsStorage.TabIndex = 819;
			this.NsStorage.Text = "  خرید و فروش";
			this.NsStorage.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			// 
			// NsSmsTabPage
			// 
			this.NsSmsTabPage.AutoScroll = true;
			this.NsSmsTabPage.Controls.Add(this.NsSmsActivation);
			this.NsSmsTabPage.Controls.Add(this.uiGroupBox1);
			this.NsSmsTabPage.Controls.Add(this.NsGroupBoxSmsInfo);
			this.NsSmsTabPage.Location = new System.Drawing.Point(0, 27);
			this.NsSmsTabPage.Name = "NsSmsTabPage";
			this.NsSmsTabPage.PanelFormatStyle.Alpha = 70;
			this.NsSmsTabPage.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
			this.NsSmsTabPage.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
			this.NsSmsTabPage.Size = new System.Drawing.Size(764, 391);
			this.NsSmsTabPage.TabStop = true;
			this.NsSmsTabPage.Text = " پنل پیامکی";
			// 
			// NsSmsActivation
			// 
			this.NsSmsActivation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsSmsActivation.BackColor = System.Drawing.Color.Transparent;
			this.NsSmsActivation.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsSmsActivation.Font = new System.Drawing.Font("IRANSans(Small)", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NsSmsActivation.Location = new System.Drawing.Point(512, 13);
			this.NsSmsActivation.Margin = new System.Windows.Forms.Padding(7, 21, 7, 21);
			this.NsSmsActivation.MS_BorderColor = System.Drawing.Color.LightSkyBlue;
			this.NsSmsActivation.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsSmsActivation.MS_Change_Border_Color_On_Enter = true;
			this.NsSmsActivation.MS_Change_Color_On_Checked = true;
			this.NsSmsActivation.MS_Change_Color_On_Enter = true;
			this.NsSmsActivation.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NsSmsActivation.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsSmsActivation.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsSmsActivation.MS_Exit_By_Down = true;
			this.NsSmsActivation.MS_Exit_By_Enter = true;
			this.NsSmsActivation.MS_Exit_By_Up = true;
			this.NsSmsActivation.MS_Last_Control = null;
			this.NsSmsActivation.MS_Next_Control = null;
			this.NsSmsActivation.MS_UnChecked_Color = System.Drawing.Color.Transparent;
			this.NsSmsActivation.Name = "NsSmsActivation";
			this.NsSmsActivation.Padding = new System.Windows.Forms.Padding(5);
			this.NsSmsActivation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsSmsActivation.ShowFocusRectangle = false;
			this.NsSmsActivation.Size = new System.Drawing.Size(227, 21);
			this.NsSmsActivation.TabIndex = 828;
			this.NsSmsActivation.Text = "  پنل پیامکی برای کاربر فعال است.";
			this.NsSmsActivation.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.NsSmsActivation.CheckedChanged += new System.EventHandler(this.NsSmsActivation_CheckedChanged);
			// 
			// uiGroupBox1
			// 
			this.uiGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.uiGroupBox1.BackColor = System.Drawing.Color.Transparent;
			this.uiGroupBox1.BorderColor = System.Drawing.Color.LightBlue;
			this.uiGroupBox1.Controls.Add(this.NsExpiration);
			this.uiGroupBox1.Controls.Add(this.NsSmsAmount);
			this.uiGroupBox1.Controls.Add(this.NsSmsCount);
			this.uiGroupBox1.Controls.Add(this.nsLoading2);
			this.uiGroupBox1.Controls.Add(this.NzGetInfo);
			this.uiGroupBox1.Controls.Add(this.label8);
			this.uiGroupBox1.Controls.Add(this.label6);
			this.uiGroupBox1.Controls.Add(this.label7);
			this.uiGroupBox1.Location = new System.Drawing.Point(11, 162);
			this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.uiGroupBox1.Name = "uiGroupBox1";
			this.uiGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.uiGroupBox1.Size = new System.Drawing.Size(738, 207);
			this.uiGroupBox1.TabIndex = 4;
			// 
			// NsExpiration
			// 
			this.NsExpiration.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsExpiration.BackColor = System.Drawing.Color.Lavender;
			this.NsExpiration.Cursor = System.Windows.Forms.Cursors.Default;
			this.NsExpiration.Enabled = false;
			this.NsExpiration.Location = new System.Drawing.Point(501, 112);
			this.NsExpiration.MaxLength = 500;
			this.NsExpiration.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsExpiration.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsExpiration.MS_Change_Border_Color_On_Enter = true;
			this.NsExpiration.MS_Change_Color_On_Enter = true;
			this.NsExpiration.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsExpiration.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsExpiration.MS_Exit_By_Down = true;
			this.NsExpiration.MS_Exit_By_Enter = true;
			this.NsExpiration.MS_Exit_By_Up = true;
			this.NsExpiration.MS_Last_Control = null;
			this.NsExpiration.MS_Next_Control = null;
			this.NsExpiration.Name = "NsExpiration";
			this.NsExpiration.ReadOnly = true;
			this.NsExpiration.Size = new System.Drawing.Size(140, 27);
			this.NsExpiration.TabIndex = 770;
			this.NsExpiration.TabStop = false;
			this.NsExpiration.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.NsExpiration.VisualStyle = Janus.Windows.GridEX.VisualStyle.VS2005;
			// 
			// NsSmsAmount
			// 
			this.NsSmsAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsSmsAmount.BackColor = System.Drawing.Color.Lavender;
			this.NsSmsAmount.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
			this.NsSmsAmount.Location = new System.Drawing.Point(501, 67);
			this.NsSmsAmount.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsSmsAmount.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsSmsAmount.MS_Decimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.NsSmsAmount.MS_Format_String = "0,0.##;(0,0.##); ";
			this.NsSmsAmount.Name = "NsSmsAmount";
			this.NsSmsAmount.Size = new System.Drawing.Size(140, 29);
			this.NsSmsAmount.TabIndex = 769;
			this.NsSmsAmount.Text = " ";
			this.NsSmsAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// NsSmsCount
			// 
			this.NsSmsCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsSmsCount.BackColor = System.Drawing.Color.Lavender;
			this.NsSmsCount.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
			this.NsSmsCount.Location = new System.Drawing.Point(501, 23);
			this.NsSmsCount.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsSmsCount.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsSmsCount.MS_Decimal = new decimal(new int[] {
            0,
            0,
            0,
            0});
			this.NsSmsCount.MS_Format_String = "0,0.##;(0,0.##); ";
			this.NsSmsCount.Name = "NsSmsCount";
			this.NsSmsCount.Size = new System.Drawing.Size(140, 29);
			this.NsSmsCount.TabIndex = 769;
			this.NsSmsCount.Text = " ";
			this.NsSmsCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// nsLoading2
			// 
			this.nsLoading2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.nsLoading2.Image = ((System.Drawing.Image)(resources.GetObject("nsLoading2.Image")));
			this.nsLoading2.Location = new System.Drawing.Point(292, 157);
			this.nsLoading2.Name = "nsLoading2";
			this.nsLoading2.Size = new System.Drawing.Size(31, 30);
			this.nsLoading2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.nsLoading2.TabIndex = 169;
			this.nsLoading2.TabStop = false;
			this.nsLoading2.Visible = false;
			// 
			// NzGetInfo
			// 
			this.NzGetInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzGetInfo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NzGetInfo.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NzGetInfo.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NzGetInfo.Image = global::MS_Resource.GlobalResources.Rep__5_;
			this.NzGetInfo.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
			this.NzGetInfo.Location = new System.Drawing.Point(329, 157);
			this.NzGetInfo.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzGetInfo.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzGetInfo.MS_Change_Border_Color_On_Enter = false;
			this.NzGetInfo.MS_Change_Color_On_Enter = false;
			this.NzGetInfo.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.NzGetInfo.MS_Enter_Color = System.Drawing.Color.Empty;
			this.NzGetInfo.Name = "NzGetInfo";
			this.NzGetInfo.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
			this.NzGetInfo.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
			this.NzGetInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NzGetInfo.ShowFocusRectangle = false;
			this.NzGetInfo.Size = new System.Drawing.Size(153, 30);
			this.NzGetInfo.TabIndex = 167;
			this.NzGetInfo.Text = "دریافت مانده پنل";
			this.NzGetInfo.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
			this.NzGetInfo.UseThemes = false;
			this.NzGetInfo.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.NzGetInfo.WordWrap = false;
			this.NzGetInfo.Click += new System.EventHandler(this.NzGetInfo_Click);
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.label8.Location = new System.Drawing.Point(647, 107);
			this.label8.Name = "label8";
			this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label8.Size = new System.Drawing.Size(79, 46);
			this.label8.TabIndex = 166;
			this.label8.Text = "تاریخ انتضای\r\n سرویس :";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.label6.Location = new System.Drawing.Point(647, 67);
			this.label6.Name = "label6";
			this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label6.Size = new System.Drawing.Size(76, 23);
			this.label6.TabIndex = 166;
			this.label6.Text = "مانده نقدی :";
			// 
			// label7
			// 
			this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.label7.Location = new System.Drawing.Point(647, 27);
			this.label7.Name = "label7";
			this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label7.Size = new System.Drawing.Size(82, 23);
			this.label7.TabIndex = 164;
			this.label7.Text = "تعداد پیامک :";
			// 
			// NsGroupBoxSmsInfo
			// 
			this.NsGroupBoxSmsInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NsGroupBoxSmsInfo.BackColor = System.Drawing.Color.Transparent;
			this.NsGroupBoxSmsInfo.BorderColor = System.Drawing.Color.LightBlue;
			this.NsGroupBoxSmsInfo.Controls.Add(this.NsLoading);
			this.NsGroupBoxSmsInfo.Controls.Add(this.NsOK);
			this.NsGroupBoxSmsInfo.Controls.Add(this.NsPassword);
			this.NsGroupBoxSmsInfo.Controls.Add(this.label5);
			this.NsGroupBoxSmsInfo.Controls.Add(this.NsUsername);
			this.NsGroupBoxSmsInfo.Controls.Add(this.label3);
			this.NsGroupBoxSmsInfo.Enabled = false;
			this.NsGroupBoxSmsInfo.Location = new System.Drawing.Point(11, 17);
			this.NsGroupBoxSmsInfo.Margin = new System.Windows.Forms.Padding(2);
			this.NsGroupBoxSmsInfo.Name = "NsGroupBoxSmsInfo";
			this.NsGroupBoxSmsInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsGroupBoxSmsInfo.Size = new System.Drawing.Size(738, 141);
			this.NsGroupBoxSmsInfo.TabIndex = 3;
			// 
			// NsLoading
			// 
			this.NsLoading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsLoading.Image = ((System.Drawing.Image)(resources.GetObject("NsLoading.Image")));
			this.NsLoading.Location = new System.Drawing.Point(292, 97);
			this.NsLoading.Name = "NsLoading";
			this.NsLoading.Size = new System.Drawing.Size(31, 30);
			this.NsLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.NsLoading.TabIndex = 168;
			this.NsLoading.TabStop = false;
			this.NsLoading.Visible = false;
			// 
			// NsOK
			// 
			this.NsOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsOK.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsOK.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NsOK.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NsOK.Image = ((System.Drawing.Image)(resources.GetObject("NsOK.Image")));
			this.NsOK.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
			this.NsOK.Location = new System.Drawing.Point(329, 97);
			this.NsOK.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsOK.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsOK.MS_Change_Border_Color_On_Enter = false;
			this.NsOK.MS_Change_Color_On_Enter = false;
			this.NsOK.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.NsOK.MS_Enter_Color = System.Drawing.Color.Empty;
			this.NsOK.Name = "NsOK";
			this.NsOK.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
			this.NsOK.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
			this.NsOK.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsOK.ShowFocusRectangle = false;
			this.NsOK.Size = new System.Drawing.Size(153, 30);
			this.NsOK.TabIndex = 167;
			this.NsOK.Text = "بررسی صحت اطلاعات";
			this.NsOK.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
			this.NsOK.UseThemes = false;
			this.NsOK.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.NsOK.WordWrap = false;
			this.NsOK.Click += new System.EventHandler(this.NsOK_Click);
			// 
			// NsPassword
			// 
			this.NsPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsPassword.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsPassword.Location = new System.Drawing.Point(501, 100);
			this.NsPassword.MaxLength = 200;
			this.NsPassword.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsPassword.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsPassword.MS_Change_Border_Color_On_Enter = true;
			this.NsPassword.MS_Change_Color_On_Enter = true;
			this.NsPassword.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsPassword.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsPassword.MS_Exit_By_Down = true;
			this.NsPassword.MS_Exit_By_Enter = true;
			this.NsPassword.MS_Exit_By_Up = true;
			this.NsPassword.MS_Last_Control = null;
			this.NsPassword.MS_Next_Control = null;
			this.NsPassword.Name = "NsPassword";
			this.NsPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.NsPassword.Size = new System.Drawing.Size(152, 27);
			this.NsPassword.TabIndex = 165;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.label5.Location = new System.Drawing.Point(659, 102);
			this.label5.Name = "label5";
			this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label5.Size = new System.Drawing.Size(64, 23);
			this.label5.TabIndex = 166;
			this.label5.Text = "کلمه عبور :";
			// 
			// NsUsername
			// 
			this.NsUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsUsername.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsUsername.Location = new System.Drawing.Point(501, 56);
			this.NsUsername.MaxLength = 200;
			this.NsUsername.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsUsername.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsUsername.MS_Change_Border_Color_On_Enter = true;
			this.NsUsername.MS_Change_Color_On_Enter = true;
			this.NsUsername.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsUsername.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsUsername.MS_Exit_By_Down = true;
			this.NsUsername.MS_Exit_By_Enter = true;
			this.NsUsername.MS_Exit_By_Up = true;
			this.NsUsername.MS_Last_Control = null;
			this.NsUsername.MS_Next_Control = null;
			this.NsUsername.Name = "NsUsername";
			this.NsUsername.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.NsUsername.Size = new System.Drawing.Size(152, 27);
			this.NsUsername.TabIndex = 163;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.label3.Location = new System.Drawing.Point(659, 58);
			this.label3.Name = "label3";
			this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label3.Size = new System.Drawing.Size(70, 23);
			this.label3.TabIndex = 164;
			this.label3.Text = "نام کاربری :";
			// 
			// TabSettingContainer
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.NzTabs);
			this.Name = "TabSettingContainer";
			this.Size = new System.Drawing.Size(764, 418);
			((System.ComponentModel.ISupportInitialize)(this.NzTabs)).EndInit();
			this.NzTabs.ResumeLayout(false);
			this.NsGeneralSetting.ResumeLayout(false);
			this.NsGeneralSetting.PerformLayout();
			this.NsSmsTabPage.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
			this.uiGroupBox1.ResumeLayout(false);
			this.uiGroupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nsLoading2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.NsGroupBoxSmsInfo)).EndInit();
			this.NsGroupBoxSmsInfo.ResumeLayout(false);
			this.NsGroupBoxSmsInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.NsLoading)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Janus.Windows.UI.Tab.UITab NzTabs;
		private ShareLib.Component.NsSettingTabPage NsGeneralSetting;
		private ShareLib.Component.NsSettingTabPage NsSmsTabPage;

		private MS_Control.Controls.MS_CheckBox NsSms;
		private MS_Control.Controls.MS_CheckBox NsPayments;
		private MS_Control.Controls.MS_CheckBox NsStorage;
		private MS_Control.Controls.MS_TextBox NsConStr;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private MS_Control.Controls.MS_CheckBox NsLown;
		private MS_Control.Controls.MS_CheckBox NsMultipleDatabase;
		private MS_Control.Controls.MS_CheckBox NsAlarm;
		private MS_Control.Controls.MS_CheckBox NsBackup;
		private System.Windows.Forms.Label label2;
        private Janus.Windows.EditControls.UIGroupBox NsGroupBoxSmsInfo;
        private MS_Control.Controls.MS_TextBox NsPassword;
        private System.Windows.Forms.Label label5;
        private MS_Control.Controls.MS_TextBox NsUsername;
        private System.Windows.Forms.Label label3;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private MS_Control.Controls.MS_Button_GridX NzGetInfo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private MS_Control.Controls.MS_Button_GridX NsOK;
        private System.Windows.Forms.PictureBox NsLoading;
        private MS_Control.Controls.MS_Notify mS_Notify1;
        private MS_Control.Controls.MS_CheckBox NsSmsActivation;
        private System.Windows.Forms.PictureBox nsLoading2;
        private System.Windows.Forms.Label label8;
        private MS_Control.Controls.MS_Decimal_Label NsSmsAmount;
        private MS_Control.Controls.MS_Decimal_Label NsSmsCount;
        private MS_Control.Controls.MS_TextBox NsExpiration;
    }
}
