using ShareLib.Component;

namespace Nz.Anbar.WinForms.Settings
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
			this.NsStorageSetting = new ShareLib.Component.NsSettingTabPage();
			this.NsAdvancedSearch = new MS_Control.Controls.MS_CheckBox();
			this.NsMainGroup = new MS_Control.Controls.MS_CheckBox();
			this.NsPrintRemaind = new MS_Control.Controls.MS_CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.NzTabs)).BeginInit();
			this.NzTabs.SuspendLayout();
			this.NsStorageSetting.SuspendLayout();
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
			this.NzTabs.Size = new System.Drawing.Size(563, 307);
			this.NzTabs.TabIndex = 710;
			this.NzTabs.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.NsStorageSetting});
			this.NzTabs.TabsStateStyles.DisabledFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.NzTabs.TabsStateStyles.DisabledFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.NzTabs.TabsStateStyles.FormatStyle.BackColor = System.Drawing.Color.LightBlue;
			this.NzTabs.TabsStateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.Gold;
			this.NzTabs.TabsStateStyles.SelectedFormatStyle.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
			this.NzTabs.UseThemes = false;
			this.NzTabs.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
			// 
			// NsStorageSetting
			// 
			this.NsStorageSetting.Controls.Add(this.NsAdvancedSearch);
			this.NsStorageSetting.Controls.Add(this.NsMainGroup);
			this.NsStorageSetting.Controls.Add(this.NsPrintRemaind);
			this.NsStorageSetting.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NsStorageSetting.Location = new System.Drawing.Point(0, 23);
			this.NsStorageSetting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.NsStorageSetting.Name = "NsStorageSetting";
			this.NsStorageSetting.PanelFormatStyle.Alpha = 70;
			this.NsStorageSetting.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
			this.NsStorageSetting.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
			this.NsStorageSetting.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsStorageSetting.Size = new System.Drawing.Size(563, 284);
			this.NsStorageSetting.TabStop = true;
			this.NsStorageSetting.Text = "خرید و فروش";
			// 
			// NsAdvancedSearch
			// 
			this.NsAdvancedSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NsAdvancedSearch.BackColor = System.Drawing.Color.Transparent;
			this.NsAdvancedSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsAdvancedSearch.Location = new System.Drawing.Point(38, 87);
			this.NsAdvancedSearch.Margin = new System.Windows.Forms.Padding(6, 13, 6, 13);
			this.NsAdvancedSearch.MS_BorderColor = System.Drawing.Color.Transparent;
			this.NsAdvancedSearch.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsAdvancedSearch.MS_Change_Border_Color_On_Enter = true;
			this.NsAdvancedSearch.MS_Change_Color_On_Checked = true;
			this.NsAdvancedSearch.MS_Change_Color_On_Enter = true;
			this.NsAdvancedSearch.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NsAdvancedSearch.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsAdvancedSearch.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsAdvancedSearch.MS_Exit_By_Down = true;
			this.NsAdvancedSearch.MS_Exit_By_Enter = true;
			this.NsAdvancedSearch.MS_Exit_By_Up = true;
			this.NsAdvancedSearch.MS_Last_Control = null;
			this.NsAdvancedSearch.MS_Next_Control = null;
			this.NsAdvancedSearch.MS_UnChecked_Color = System.Drawing.Color.Transparent;
			this.NsAdvancedSearch.Name = "NsAdvancedSearch";
			this.NsAdvancedSearch.ShowFocusRectangle = false;
			this.NsAdvancedSearch.Size = new System.Drawing.Size(501, 31);
			this.NsAdvancedSearch.TabIndex = 818;
			this.NsAdvancedSearch.Text = "  به صورت پیش فرض از جستجوی داخل جملات در جستجوی کالا استفاده شود";
			this.NsAdvancedSearch.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			// 
			// NsMainGroup
			// 
			this.NsMainGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NsMainGroup.BackColor = System.Drawing.Color.Transparent;
			this.NsMainGroup.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsMainGroup.Location = new System.Drawing.Point(38, 50);
			this.NsMainGroup.Margin = new System.Windows.Forms.Padding(6, 13, 6, 13);
			this.NsMainGroup.MS_BorderColor = System.Drawing.Color.Transparent;
			this.NsMainGroup.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsMainGroup.MS_Change_Border_Color_On_Enter = true;
			this.NsMainGroup.MS_Change_Color_On_Checked = true;
			this.NsMainGroup.MS_Change_Color_On_Enter = true;
			this.NsMainGroup.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NsMainGroup.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsMainGroup.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsMainGroup.MS_Exit_By_Down = true;
			this.NsMainGroup.MS_Exit_By_Enter = true;
			this.NsMainGroup.MS_Exit_By_Up = true;
			this.NsMainGroup.MS_Last_Control = null;
			this.NsMainGroup.MS_Next_Control = null;
			this.NsMainGroup.MS_UnChecked_Color = System.Drawing.Color.Transparent;
			this.NsMainGroup.Name = "NsMainGroup";
			this.NsMainGroup.ShowFocusRectangle = false;
			this.NsMainGroup.Size = new System.Drawing.Size(501, 31);
			this.NsMainGroup.TabIndex = 817;
			this.NsMainGroup.Text = "  گروه اصلی کالا/خدمات در سیستم استفاده شود";
			this.NsMainGroup.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			// 
			// NsPrintRemaind
			// 
			this.NsPrintRemaind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NsPrintRemaind.BackColor = System.Drawing.Color.Transparent;
			this.NsPrintRemaind.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsPrintRemaind.Location = new System.Drawing.Point(38, 13);
			this.NsPrintRemaind.Margin = new System.Windows.Forms.Padding(6, 13, 6, 13);
			this.NsPrintRemaind.MS_BorderColor = System.Drawing.Color.Transparent;
			this.NsPrintRemaind.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsPrintRemaind.MS_Change_Border_Color_On_Enter = true;
			this.NsPrintRemaind.MS_Change_Color_On_Checked = true;
			this.NsPrintRemaind.MS_Change_Color_On_Enter = true;
			this.NsPrintRemaind.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NsPrintRemaind.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsPrintRemaind.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsPrintRemaind.MS_Exit_By_Down = true;
			this.NsPrintRemaind.MS_Exit_By_Enter = true;
			this.NsPrintRemaind.MS_Exit_By_Up = true;
			this.NsPrintRemaind.MS_Last_Control = null;
			this.NsPrintRemaind.MS_Next_Control = null;
			this.NsPrintRemaind.MS_UnChecked_Color = System.Drawing.Color.Transparent;
			this.NsPrintRemaind.Name = "NsPrintRemaind";
			this.NsPrintRemaind.ShowFocusRectangle = false;
			this.NsPrintRemaind.Size = new System.Drawing.Size(501, 31);
			this.NsPrintRemaind.TabIndex = 816;
			this.NsPrintRemaind.Text = "  مانده حساب شخص به صورت پیش فرض چاپ شود";
			this.NsPrintRemaind.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			// 
			// TabSettingContainer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.NzTabs);
			this.Name = "TabSettingContainer";
			this.Size = new System.Drawing.Size(563, 307);
			((System.ComponentModel.ISupportInitialize)(this.NzTabs)).EndInit();
			this.NzTabs.ResumeLayout(false);
			this.NsStorageSetting.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Janus.Windows.UI.Tab.UITab NzTabs;
		private NsSettingTabPage NsStorageSetting;
		private MS_Control.Controls.MS_CheckBox NsPrintRemaind;
		private MS_Control.Controls.MS_CheckBox NsMainGroup;
		private MS_Control.Controls.MS_CheckBox NsAdvancedSearch;
	}
}
