namespace NZ.Xazane.WinForms.Setting
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
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.NzPos = new NZ.Xazane.WinForms.Component.NzAccounts();
			this.NzCache = new NZ.Xazane.WinForms.Component.NzAccounts();
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
			this.NzTabs.Size = new System.Drawing.Size(691, 436);
			this.NzTabs.TabIndex = 712;
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
			this.NsGeneralSetting.Controls.Add(this.label1);
			this.NsGeneralSetting.Controls.Add(this.label4);
			this.NsGeneralSetting.Controls.Add(this.NzPos);
			this.NsGeneralSetting.Controls.Add(this.NzCache);
			this.NsGeneralSetting.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NsGeneralSetting.Location = new System.Drawing.Point(0, 23);
			this.NsGeneralSetting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.NsGeneralSetting.Name = "NsGeneralSetting";
			this.NsGeneralSetting.PanelFormatStyle.Alpha = 70;
			this.NsGeneralSetting.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
			this.NsGeneralSetting.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
			this.NsGeneralSetting.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsGeneralSetting.Size = new System.Drawing.Size(691, 413);
			this.NsGeneralSetting.TabStop = true;
			this.NsGeneralSetting.Text = "خزانه داری";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F);
			this.label1.Location = new System.Drawing.Point(398, 84);
			this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label1.Size = new System.Drawing.Size(263, 23);
			this.label1.TabIndex = 825;
			this.label1.Text = " : حساب بانکی پیش فرض در تسویه با بارکدخوان";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F);
			this.label4.Location = new System.Drawing.Point(398, 22);
			this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
			this.label4.Name = "label4";
			this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label4.Size = new System.Drawing.Size(272, 23);
			this.label4.TabIndex = 824;
			this.label4.Text = " : حساب صندوق پیش فرض در تسویه با بارکدخوان";
			// 
			// NzPos
			// 
			this.NzPos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NzPos.BackColor = System.Drawing.Color.White;
			this.NzPos.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
			this.NzPos.DropSize = new System.Drawing.Size(369, 37);
			this.NzPos.Font = new System.Drawing.Font("IRANSans(Small)", 18F);
			this.NzPos.Location = new System.Drawing.Point(18, 77);
			this.NzPos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.NzPos.MS_Auto_Popup = false;
			this.NzPos.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzPos.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzPos.MS_CaptureFocus = false;
			this.NzPos.MS_Change_Border_Color_On_Enter = true;
			this.NzPos.MS_Change_Color_On_Enter = true;
			this.NzPos.MS_Drop_Direction = MS_Control.TSDD.KindShow.Right;
			this.NzPos.MS_DropDownSizeMode = MS_Control.TSDD.SizeMode.Control_Size;
			this.NzPos.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NzPos.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzPos.MS_Exit_By_Down = true;
			this.NzPos.MS_Exit_By_Enter = true;
			this.NzPos.MS_Exit_By_Up = true;
			this.NzPos.MS_Last_Control = null;
			this.NzPos.MS_Next_Control = null;
			this.NzPos.Name = "NzPos";
			this.NzPos.Office2007CustomColor = System.Drawing.Color.SkyBlue;
			this.NzPos.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NzPos.Size = new System.Drawing.Size(369, 37);
			this.NzPos.TabIndex = 1;
			this.NzPos.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			// 
			// NzCache
			// 
			this.NzCache.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NzCache.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
			this.NzCache.DropSize = new System.Drawing.Size(370, 37);
			this.NzCache.Font = new System.Drawing.Font("IRANSans(Small)", 18F);
			this.NzCache.Location = new System.Drawing.Point(17, 15);
			this.NzCache.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.NzCache.MS_Auto_Popup = false;
			this.NzCache.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzCache.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzCache.MS_CaptureFocus = false;
			this.NzCache.MS_Change_Border_Color_On_Enter = true;
			this.NzCache.MS_Change_Color_On_Enter = true;
			this.NzCache.MS_Drop_Direction = MS_Control.TSDD.KindShow.Right;
			this.NzCache.MS_DropDownSizeMode = MS_Control.TSDD.SizeMode.Control_Size;
			this.NzCache.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NzCache.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzCache.MS_Exit_By_Down = true;
			this.NzCache.MS_Exit_By_Enter = true;
			this.NzCache.MS_Exit_By_Up = true;
			this.NzCache.MS_Last_Control = null;
			this.NzCache.MS_Next_Control = null;
			this.NzCache.Name = "NzCache";
			this.NzCache.Office2007CustomColor = System.Drawing.Color.SkyBlue;
			this.NzCache.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NzCache.Size = new System.Drawing.Size(370, 37);
			this.NzCache.TabIndex = 2;
			this.NzCache.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			// 
			// TabSettingContainer
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.NzTabs);
			this.Name = "TabSettingContainer";
			this.Size = new System.Drawing.Size(691, 436);
			((System.ComponentModel.ISupportInitialize)(this.NzTabs)).EndInit();
			this.NzTabs.ResumeLayout(false);
			this.NsGeneralSetting.ResumeLayout(false);
			this.NsGeneralSetting.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Janus.Windows.UI.Tab.UITab NzTabs;
		private ShareLib.Component.NsSettingTabPage NsGeneralSetting;
		private Component.NzAccounts NzPos;
		private Component.NzAccounts NzCache;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
	}
}
