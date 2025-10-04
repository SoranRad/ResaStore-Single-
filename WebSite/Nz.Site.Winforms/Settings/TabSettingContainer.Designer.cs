namespace Nz.Site.Winforms.Settings
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
			this.NsSiteSetting = new ShareLib.Component.NsSettingTabPage();
			this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
			this.NsSecretKey = new MS_Control.Controls.MS_TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.NsApiKey = new MS_Control.Controls.MS_TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.NsWebSite = new MS_Control.Controls.MS_TextBox();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.NzTabs)).BeginInit();
			this.NzTabs.SuspendLayout();
			this.NsSiteSetting.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
			this.uiGroupBox1.SuspendLayout();
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
			this.NzTabs.TabIndex = 0;
			this.NzTabs.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.NsSiteSetting});
			this.NzTabs.TabsStateStyles.DisabledFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.NzTabs.TabsStateStyles.DisabledFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.NzTabs.TabsStateStyles.FormatStyle.BackColor = System.Drawing.Color.LightBlue;
			this.NzTabs.TabsStateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.Gold;
			this.NzTabs.TabsStateStyles.SelectedFormatStyle.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
			this.NzTabs.UseThemes = false;
			this.NzTabs.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
			// 
			// NsSiteSetting
			// 
			this.NsSiteSetting.AutoScroll = true;
			this.NsSiteSetting.Controls.Add(this.uiGroupBox1);
			this.NsSiteSetting.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NsSiteSetting.Location = new System.Drawing.Point(0, 23);
			this.NsSiteSetting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.NsSiteSetting.Name = "NsSiteSetting";
			this.NsSiteSetting.PanelFormatStyle.Alpha = 70;
			this.NsSiteSetting.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
			this.NsSiteSetting.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
			this.NsSiteSetting.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsSiteSetting.Size = new System.Drawing.Size(654, 339);
			this.NsSiteSetting.TabStop = true;
			this.NsSiteSetting.Text = "  وب سایت  ";
			// 
			// uiGroupBox1
			// 
			this.uiGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.uiGroupBox1.BackColor = System.Drawing.Color.Transparent;
			this.uiGroupBox1.BorderColor = System.Drawing.Color.LightBlue;
			this.uiGroupBox1.Controls.Add(this.NsSecretKey);
			this.uiGroupBox1.Controls.Add(this.label3);
			this.uiGroupBox1.Controls.Add(this.NsApiKey);
			this.uiGroupBox1.Controls.Add(this.label1);
			this.uiGroupBox1.Controls.Add(this.NsWebSite);
			this.uiGroupBox1.Controls.Add(this.label2);
			this.uiGroupBox1.Location = new System.Drawing.Point(11, 12);
			this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.uiGroupBox1.Name = "uiGroupBox1";
			this.uiGroupBox1.Size = new System.Drawing.Size(632, 195);
			this.uiGroupBox1.TabIndex = 0;
			this.uiGroupBox1.Text = " وردپرس (ووکامرس)";
			// 
			// NsSecretKey
			// 
			this.NsSecretKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NsSecretKey.Cursor = System.Windows.Forms.Cursors.Default;
			this.NsSecretKey.Location = new System.Drawing.Point(86, 148);
			this.NsSecretKey.MaxLength = 200;
			this.NsSecretKey.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsSecretKey.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsSecretKey.MS_Change_Border_Color_On_Enter = true;
			this.NsSecretKey.MS_Change_Color_On_Enter = true;
			this.NsSecretKey.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsSecretKey.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsSecretKey.MS_Exit_By_Down = true;
			this.NsSecretKey.MS_Exit_By_Enter = true;
			this.NsSecretKey.MS_Exit_By_Up = true;
			this.NsSecretKey.MS_Last_Control = null;
			this.NsSecretKey.MS_Next_Control = null;
			this.NsSecretKey.Name = "NsSecretKey";
			this.NsSecretKey.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.NsSecretKey.Size = new System.Drawing.Size(530, 29);
			this.NsSecretKey.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.label3.Location = new System.Drawing.Point(2, 154);
			this.label3.Name = "label3";
			this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label3.Size = new System.Drawing.Size(83, 23);
			this.label3.TabIndex = 161;
			this.label3.Text = "Secret Key :";
			// 
			// NsApiKey
			// 
			this.NsApiKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NsApiKey.Cursor = System.Windows.Forms.Cursors.Default;
			this.NsApiKey.Location = new System.Drawing.Point(86, 99);
			this.NsApiKey.MaxLength = 200;
			this.NsApiKey.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsApiKey.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsApiKey.MS_Change_Border_Color_On_Enter = true;
			this.NsApiKey.MS_Change_Color_On_Enter = true;
			this.NsApiKey.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsApiKey.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsApiKey.MS_Exit_By_Down = true;
			this.NsApiKey.MS_Exit_By_Enter = true;
			this.NsApiKey.MS_Exit_By_Up = true;
			this.NsApiKey.MS_Last_Control = null;
			this.NsApiKey.MS_Next_Control = null;
			this.NsApiKey.Name = "NsApiKey";
			this.NsApiKey.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.NsApiKey.Size = new System.Drawing.Size(530, 29);
			this.NsApiKey.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.label1.Location = new System.Drawing.Point(21, 102);
			this.label1.Name = "label1";
			this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label1.Size = new System.Drawing.Size(64, 23);
			this.label1.TabIndex = 161;
			this.label1.Text = "Api Key :";
			// 
			// NsWebSite
			// 
			this.NsWebSite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NsWebSite.Cursor = System.Windows.Forms.Cursors.Default;
			this.NsWebSite.Location = new System.Drawing.Point(86, 50);
			this.NsWebSite.MaxLength = 200;
			this.NsWebSite.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsWebSite.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsWebSite.MS_Change_Border_Color_On_Enter = true;
			this.NsWebSite.MS_Change_Color_On_Enter = true;
			this.NsWebSite.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsWebSite.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsWebSite.MS_Exit_By_Down = true;
			this.NsWebSite.MS_Exit_By_Enter = true;
			this.NsWebSite.MS_Exit_By_Up = true;
			this.NsWebSite.MS_Last_Control = null;
			this.NsWebSite.MS_Next_Control = null;
			this.NsWebSite.Name = "NsWebSite";
			this.NsWebSite.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.NsWebSite.Size = new System.Drawing.Size(530, 29);
			this.NsWebSite.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.label2.Location = new System.Drawing.Point(14, 50);
			this.label2.Name = "label2";
			this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.label2.Size = new System.Drawing.Size(71, 23);
			this.label2.TabIndex = 161;
			this.label2.Text = "Web Site :";
			// 
			// TabSettingContainer
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.NzTabs);
			this.Name = "TabSettingContainer";
			this.Size = new System.Drawing.Size(654, 362);
			((System.ComponentModel.ISupportInitialize)(this.NzTabs)).EndInit();
			this.NzTabs.ResumeLayout(false);
			this.NsSiteSetting.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
			this.uiGroupBox1.ResumeLayout(false);
			this.uiGroupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Janus.Windows.UI.Tab.UITab NzTabs;
		private ShareLib.Component.NsSettingTabPage NsSiteSetting;
		private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
		private MS_Control.Controls.MS_TextBox NsWebSite;
		private System.Windows.Forms.Label label2;
		private MS_Control.Controls.MS_TextBox NsSecretKey;
		private System.Windows.Forms.Label label3;
		private MS_Control.Controls.MS_TextBox NsApiKey;
		private System.Windows.Forms.Label label1;
	}
}
