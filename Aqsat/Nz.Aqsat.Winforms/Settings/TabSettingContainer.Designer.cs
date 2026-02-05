namespace Nz.Asat.Winforms.Settings
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
			this.NsBarSetting = new ShareLib.Component.NsSettingTabPage();
			this.mS_Label1 = new MS_Control.Controls.MS_Label();
			this.mS_Label2 = new MS_Control.Controls.MS_Label();
			this.NsPhoneNumber = new MS_Control.Controls.MS_TextBox();
			this.NsCardNumber = new MS_Control.Controls.MS_TextBox();
			((System.ComponentModel.ISupportInitialize)(this.NzTabs)).BeginInit();
			this.NzTabs.SuspendLayout();
			this.NsBarSetting.SuspendLayout();
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
			this.NzTabs.Size = new System.Drawing.Size(654, 362);
			this.NzTabs.TabIndex = 711;
			this.NzTabs.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.NsBarSetting});
			this.NzTabs.TabsStateStyles.DisabledFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.NzTabs.TabsStateStyles.DisabledFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.NzTabs.TabsStateStyles.FormatStyle.BackColor = System.Drawing.Color.LightBlue;
			this.NzTabs.TabsStateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.Gold;
			this.NzTabs.TabsStateStyles.SelectedFormatStyle.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
			this.NzTabs.UseThemes = false;
			this.NzTabs.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
			// 
			// NsBarSetting
			// 
			this.NsBarSetting.AutoScroll = true;
			this.NsBarSetting.Controls.Add(this.NsCardNumber);
			this.NsBarSetting.Controls.Add(this.NsPhoneNumber);
			this.NsBarSetting.Controls.Add(this.mS_Label2);
			this.NsBarSetting.Controls.Add(this.mS_Label1);
			this.NsBarSetting.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NsBarSetting.Location = new System.Drawing.Point(0, 23);
			this.NsBarSetting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.NsBarSetting.Name = "NsBarSetting";
			this.NsBarSetting.PanelFormatStyle.Alpha = 70;
			this.NsBarSetting.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
			this.NsBarSetting.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
			this.NsBarSetting.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsBarSetting.Size = new System.Drawing.Size(654, 339);
			this.NsBarSetting.TabStop = true;
			this.NsBarSetting.Text = "اقساط";
			// 
			// mS_Label1
			// 
			this.mS_Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mS_Label1.AutoSize = true;
			this.mS_Label1.BackColor = System.Drawing.Color.Transparent;
			this.mS_Label1.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.mS_Label1.Location = new System.Drawing.Point(439, 20);
			this.mS_Label1.MS_Border_Radius = 5;
			this.mS_Label1.MS_Color_End = System.Drawing.Color.Empty;
			this.mS_Label1.MS_Color_Start = System.Drawing.Color.Empty;
			this.mS_Label1.Name = "mS_Label1";
			this.mS_Label1.Size = new System.Drawing.Size(212, 23);
			this.mS_Label1.TabIndex = 189;
			this.mS_Label1.Text = "شماره موبایل برای ارسال فیش واریزی :";
			this.mS_Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// mS_Label2
			// 
			this.mS_Label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mS_Label2.AutoSize = true;
			this.mS_Label2.BackColor = System.Drawing.Color.Transparent;
			this.mS_Label2.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.mS_Label2.Location = new System.Drawing.Point(439, 65);
			this.mS_Label2.MS_Border_Radius = 5;
			this.mS_Label2.MS_Color_End = System.Drawing.Color.Empty;
			this.mS_Label2.MS_Color_Start = System.Drawing.Color.Empty;
			this.mS_Label2.Name = "mS_Label2";
			this.mS_Label2.Size = new System.Drawing.Size(190, 23);
			this.mS_Label2.TabIndex = 189;
			this.mS_Label2.Text = "شمراه کارت برای وازیر وجه اقساط :";
			this.mS_Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// NsPhoneNumber
			// 
			this.NsPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NsPhoneNumber.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsPhoneNumber.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
			this.NsPhoneNumber.Location = new System.Drawing.Point(293, 17);
			this.NsPhoneNumber.MaxLength = 200;
			this.NsPhoneNumber.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsPhoneNumber.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsPhoneNumber.MS_Change_Border_Color_On_Enter = true;
			this.NsPhoneNumber.MS_Change_Color_On_Enter = true;
			this.NsPhoneNumber.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsPhoneNumber.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsPhoneNumber.MS_Exit_By_Down = true;
			this.NsPhoneNumber.MS_Exit_By_Enter = true;
			this.NsPhoneNumber.MS_Exit_By_Up = true;
			this.NsPhoneNumber.MS_Last_Control = null;
			this.NsPhoneNumber.MS_Next_Control = null;
			this.NsPhoneNumber.Name = "NsPhoneNumber";
			this.NsPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.NsPhoneNumber.Size = new System.Drawing.Size(140, 31);
			this.NsPhoneNumber.TabIndex = 190;
			// 
			// NsCardNumber
			// 
			this.NsCardNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NsCardNumber.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsCardNumber.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
			this.NsCardNumber.Location = new System.Drawing.Point(137, 62);
			this.NsCardNumber.MaxLength = 200;
			this.NsCardNumber.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsCardNumber.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsCardNumber.MS_Change_Border_Color_On_Enter = true;
			this.NsCardNumber.MS_Change_Color_On_Enter = true;
			this.NsCardNumber.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsCardNumber.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsCardNumber.MS_Exit_By_Down = true;
			this.NsCardNumber.MS_Exit_By_Enter = true;
			this.NsCardNumber.MS_Exit_By_Up = true;
			this.NsCardNumber.MS_Last_Control = null;
			this.NsCardNumber.MS_Next_Control = null;
			this.NsCardNumber.Name = "NsCardNumber";
			this.NsCardNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.NsCardNumber.Size = new System.Drawing.Size(296, 31);
			this.NsCardNumber.TabIndex = 190;
			// 
			// TabSettingContainer
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.NzTabs);
			this.Name = "TabSettingContainer";
			this.Size = new System.Drawing.Size(654, 362);
			((System.ComponentModel.ISupportInitialize)(this.NzTabs)).EndInit();
			this.NzTabs.ResumeLayout(false);
			this.NsBarSetting.ResumeLayout(false);
			this.NsBarSetting.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Janus.Windows.UI.Tab.UITab NzTabs;
		private ShareLib.Component.NsSettingTabPage NsBarSetting;
        private MS_Control.Controls.MS_Label mS_Label1;
        private MS_Control.Controls.MS_Label mS_Label2;
        private MS_Control.Controls.MS_TextBox NsPhoneNumber;
        private MS_Control.Controls.MS_TextBox NsCardNumber;
    }
}
