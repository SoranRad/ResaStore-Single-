namespace Nz.Bar.Winforms.Settings
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
			this.mS_Lable_Ex1 = new MS_Control.Controls.MS_Lable_Ex();
			this.NzObjectSelection = new Nz.Anbar.WinForms.Component.NzObjectCombo();
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
			this.NsBarSetting.Controls.Add(this.NzObjectSelection);
			this.NsBarSetting.Controls.Add(this.mS_Lable_Ex1);
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
			this.NsBarSetting.Text = "بـار";
			// 
			// mS_Lable_Ex1
			// 
			this.mS_Lable_Ex1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.mS_Lable_Ex1.BackColor = System.Drawing.Color.Transparent;
			this.mS_Lable_Ex1.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
			this.mS_Lable_Ex1.Location = new System.Drawing.Point(456, 15);
			this.mS_Lable_Ex1.MS_BorderColor = System.Drawing.Color.Tan;
			this.mS_Lable_Ex1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
			this.mS_Lable_Ex1.MS_Color_End = System.Drawing.Color.Empty;
			this.mS_Lable_Ex1.MS_Color_Start = System.Drawing.Color.Empty;
			this.mS_Lable_Ex1.Name = "mS_Lable_Ex1";
			this.mS_Lable_Ex1.Size = new System.Drawing.Size(178, 61);
			this.mS_Lable_Ex1.TabIndex = 819;
			this.mS_Lable_Ex1.Text = "کالای پیش فرض در خرید بـار";
			this.mS_Lable_Ex1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// NzObjectSelection
			// 
			this.NzObjectSelection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzObjectSelection.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
			this.NzObjectSelection.DropSize = new System.Drawing.Size(290, 27);
			this.NzObjectSelection.Font = new System.Drawing.Font("IRANSans(Small)", 12F);
			this.NzObjectSelection.Location = new System.Drawing.Point(171, 32);
			this.NzObjectSelection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.NzObjectSelection.MS_Auto_Popup = false;
			this.NzObjectSelection.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzObjectSelection.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzObjectSelection.MS_CaptureFocus = false;
			this.NzObjectSelection.MS_Change_Border_Color_On_Enter = true;
			this.NzObjectSelection.MS_Change_Color_On_Enter = true;
			this.NzObjectSelection.MS_Drop_Direction = MS_Control.TSDD.KindShow.Right;
			this.NzObjectSelection.MS_DropDownSizeMode = MS_Control.TSDD.SizeMode.Control_Size;
			this.NzObjectSelection.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NzObjectSelection.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzObjectSelection.MS_Exit_By_Down = true;
			this.NzObjectSelection.MS_Exit_By_Enter = true;
			this.NzObjectSelection.MS_Exit_By_Up = true;
			this.NzObjectSelection.MS_Last_Control = null;
			this.NzObjectSelection.MS_Next_Control = null;
			this.NzObjectSelection.Name = "NzObjectSelection";
			this.NzObjectSelection.Office2007CustomColor = System.Drawing.Color.SkyBlue;
			this.NzObjectSelection.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NzObjectSelection.Size = new System.Drawing.Size(290, 27);
			this.NzObjectSelection.TabIndex = 821;
			this.NzObjectSelection.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
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
		private MS_Control.Controls.MS_Lable_Ex mS_Lable_Ex1;
		private Anbar.WinForms.Component.NzObjectCombo NzObjectSelection;
	}
}
