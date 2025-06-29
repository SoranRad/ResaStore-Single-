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
			((System.ComponentModel.ISupportInitialize)(this.NzTabs)).BeginInit();
			this.NzTabs.SuspendLayout();
			this.NsGeneralSetting.SuspendLayout();
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
            this.NsGeneralSetting});
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
			this.NsGeneralSetting.Location = new System.Drawing.Point(0, 23);
			this.NsGeneralSetting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.NsGeneralSetting.Name = "NsGeneralSetting";
			this.NsGeneralSetting.PanelFormatStyle.Alpha = 70;
			this.NsGeneralSetting.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
			this.NsGeneralSetting.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
			this.NsGeneralSetting.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsGeneralSetting.Size = new System.Drawing.Size(764, 395);
			this.NsGeneralSetting.TabStop = true;
			this.NsGeneralSetting.Text = "عمومی";
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
			this.ResumeLayout(false);

		}

		#endregion

		private Janus.Windows.UI.Tab.UITab NzTabs;
		private ShareLib.Component.NsSettingTabPage NsGeneralSetting;
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
	}
}
