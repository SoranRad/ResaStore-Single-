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
			this.NsLown = new MS_Control.Controls.MS_CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.NsConStr = new MS_Control.Controls.MS_TextBox();
			this.NsSms = new MS_Control.Controls.MS_CheckBox();
			this.NsPayments = new MS_Control.Controls.MS_CheckBox();
			this.NsStorage = new MS_Control.Controls.MS_CheckBox();
			this.mS_CheckBox1 = new MS_Control.Controls.MS_CheckBox();
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
			this.NzTabs.Size = new System.Drawing.Size(604, 312);
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
			this.NsGeneralSetting.Controls.Add(this.mS_CheckBox1);
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
			this.NsGeneralSetting.Size = new System.Drawing.Size(604, 289);
			this.NsGeneralSetting.TabStop = true;
			this.NsGeneralSetting.Text = "عمومی";
			// 
			// NsLown
			// 
			this.NsLown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsLown.BackColor = System.Drawing.Color.Transparent;
			this.NsLown.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsLown.Location = new System.Drawing.Point(278, 250);
			this.NsLown.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
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
			this.NsLown.Size = new System.Drawing.Size(293, 29);
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
			this.label1.Location = new System.Drawing.Point(507, 132);
			this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
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
			this.label4.Location = new System.Drawing.Point(479, 12);
			this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
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
			this.NsConStr.Location = new System.Drawing.Point(19, 40);
			this.NsConStr.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
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
			this.NsConStr.Size = new System.Drawing.Size(572, 29);
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
			this.NsSms.Location = new System.Drawing.Point(278, 221);
			this.NsSms.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
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
			this.NsSms.Size = new System.Drawing.Size(293, 29);
			this.NsSms.TabIndex = 821;
			this.NsSms.Text = "  ارسال پیامک";
			this.NsSms.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			// 
			// NsPayments
			// 
			this.NsPayments.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsPayments.BackColor = System.Drawing.Color.Transparent;
			this.NsPayments.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsPayments.Location = new System.Drawing.Point(278, 192);
			this.NsPayments.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
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
			this.NsPayments.Size = new System.Drawing.Size(293, 29);
			this.NsPayments.TabIndex = 820;
			this.NsPayments.Text = "  خزانه داری";
			this.NsPayments.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			// 
			// NsStorage
			// 
			this.NsStorage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsStorage.BackColor = System.Drawing.Color.Transparent;
			this.NsStorage.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsStorage.Location = new System.Drawing.Point(278, 163);
			this.NsStorage.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
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
			this.NsStorage.Size = new System.Drawing.Size(293, 29);
			this.NsStorage.TabIndex = 819;
			this.NsStorage.Text = "  خرید و فروش";
			this.NsStorage.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			// 
			// mS_CheckBox1
			// 
			this.mS_CheckBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mS_CheckBox1.BackColor = System.Drawing.Color.Transparent;
			this.mS_CheckBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.mS_CheckBox1.Location = new System.Drawing.Point(278, 72);
			this.mS_CheckBox1.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
			this.mS_CheckBox1.MS_BorderColor = System.Drawing.Color.Transparent;
			this.mS_CheckBox1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.mS_CheckBox1.MS_Change_Border_Color_On_Enter = true;
			this.mS_CheckBox1.MS_Change_Color_On_Checked = true;
			this.mS_CheckBox1.MS_Change_Color_On_Enter = true;
			this.mS_CheckBox1.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.mS_CheckBox1.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.mS_CheckBox1.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.mS_CheckBox1.MS_Exit_By_Down = true;
			this.mS_CheckBox1.MS_Exit_By_Enter = true;
			this.mS_CheckBox1.MS_Exit_By_Up = true;
			this.mS_CheckBox1.MS_Last_Control = null;
			this.mS_CheckBox1.MS_Next_Control = null;
			this.mS_CheckBox1.MS_UnChecked_Color = System.Drawing.Color.Transparent;
			this.mS_CheckBox1.Name = "mS_CheckBox1";
			this.mS_CheckBox1.ShowFocusRectangle = false;
			this.mS_CheckBox1.Size = new System.Drawing.Size(293, 29);
			this.mS_CheckBox1.TabIndex = 826;
			this.mS_CheckBox1.Text = "  امکان اتصال به چند بانک اطلاعاتی فعال باشد.";
			this.mS_CheckBox1.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			// 
			// TabSettingContainer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.NzTabs);
			this.Name = "TabSettingContainer";
			this.Size = new System.Drawing.Size(604, 312);
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
		private MS_Control.Controls.MS_CheckBox mS_CheckBox1;
	}
}
