namespace Nz.Order.Winforms.Settings
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
			this.NsOrderSetting = new ShareLib.Component.NsSettingTabPage();
			this.NsAutoSyncOrders = new MS_Control.Controls.MS_CheckBox();
			this.NsSyncInterval = new MS_Control.Controls.MS_NumericTextBox();
			this.NsAutoSyncStock = new MS_Control.Controls.MS_CheckBox();
			this.NsApikey = new MS_Control.Controls.MS_TextBox();
			this.mS_Label1 = new MS_Control.Controls.MS_Label();
			this.mS_Label4 = new MS_Control.Controls.MS_Label();
			this.mS_Label3 = new MS_Control.Controls.MS_Label();
			((System.ComponentModel.ISupportInitialize)(this.NzTabs)).BeginInit();
			this.NzTabs.SuspendLayout();
			this.NsOrderSetting.SuspendLayout();
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
			this.NzTabs.Size = new System.Drawing.Size(805, 436);
			this.NzTabs.TabIndex = 712;
			this.NzTabs.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.NsOrderSetting});
			this.NzTabs.TabsStateStyles.DisabledFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.NzTabs.TabsStateStyles.DisabledFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.NzTabs.TabsStateStyles.FormatStyle.BackColor = System.Drawing.Color.LightBlue;
			this.NzTabs.TabsStateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.Gold;
			this.NzTabs.TabsStateStyles.SelectedFormatStyle.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
			this.NzTabs.UseThemes = false;
			this.NzTabs.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
			// 
			// NsOrderSetting
			// 
			this.NsOrderSetting.AutoScroll = true;
			this.NsOrderSetting.Controls.Add(this.NsAutoSyncOrders);
			this.NsOrderSetting.Controls.Add(this.NsSyncInterval);
			this.NsOrderSetting.Controls.Add(this.NsAutoSyncStock);
			this.NsOrderSetting.Controls.Add(this.NsApikey);
			this.NsOrderSetting.Controls.Add(this.mS_Label1);
			this.NsOrderSetting.Controls.Add(this.mS_Label4);
			this.NsOrderSetting.Controls.Add(this.mS_Label3);
			this.NsOrderSetting.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NsOrderSetting.Location = new System.Drawing.Point(0, 23);
			this.NsOrderSetting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.NsOrderSetting.Name = "NsOrderSetting";
			this.NsOrderSetting.PanelFormatStyle.Alpha = 70;
			this.NsOrderSetting.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
			this.NsOrderSetting.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
			this.NsOrderSetting.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsOrderSetting.Size = new System.Drawing.Size(805, 413);
			this.NsOrderSetting.TabStop = true;
			this.NsOrderSetting.Text = "سفارشات";
			// 
			// NsAutoSyncOrders
			// 
			this.NsAutoSyncOrders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsAutoSyncOrders.BackColor = System.Drawing.Color.Transparent;
			this.NsAutoSyncOrders.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsAutoSyncOrders.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F);
			this.NsAutoSyncOrders.Location = new System.Drawing.Point(353, 98);
			this.NsAutoSyncOrders.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsAutoSyncOrders.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
			this.NsAutoSyncOrders.MS_Change_Border_Color_On_Enter = true;
			this.NsAutoSyncOrders.MS_Change_Color_On_Checked = true;
			this.NsAutoSyncOrders.MS_Change_Color_On_Enter = true;
			this.NsAutoSyncOrders.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NsAutoSyncOrders.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsAutoSyncOrders.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsAutoSyncOrders.MS_Exit_By_Down = true;
			this.NsAutoSyncOrders.MS_Exit_By_Enter = true;
			this.NsAutoSyncOrders.MS_Exit_By_Up = true;
			this.NsAutoSyncOrders.MS_Last_Control = null;
			this.NsAutoSyncOrders.MS_Next_Control = null;
			this.NsAutoSyncOrders.MS_UnChecked_Color = System.Drawing.Color.Transparent;
			this.NsAutoSyncOrders.Name = "NsAutoSyncOrders";
			this.NsAutoSyncOrders.ShowFocusRectangle = false;
			this.NsAutoSyncOrders.Size = new System.Drawing.Size(372, 26);
			this.NsAutoSyncOrders.TabIndex = 195;
			this.NsAutoSyncOrders.Text = "   ثبت سفارشات سامانه به صورت فاکتور فروش  به صورت خودکار";
			this.NsAutoSyncOrders.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			// 
			// NsSyncInterval
			// 
			this.NsSyncInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsSyncInterval.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsSyncInterval.DigitGroup = false;
			this.NsSyncInterval.Location = new System.Drawing.Point(206, 77);
			this.NsSyncInterval.MaxLength = 2;
			this.NsSyncInterval.Mode = MS_Control.Controls.MS_NumericTextBox.TextBoxMode.IntNumber;
			this.NsSyncInterval.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsSyncInterval.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsSyncInterval.MS_Change_Border_Color_On_Enter = true;
			this.NsSyncInterval.MS_Change_Color_On_Enter = true;
			this.NsSyncInterval.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsSyncInterval.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsSyncInterval.MS_Exit_By_Down = true;
			this.NsSyncInterval.MS_Exit_By_Enter = true;
			this.NsSyncInterval.MS_Exit_By_Up = true;
			this.NsSyncInterval.MS_Is_Negative = false;
			this.NsSyncInterval.MS_Last_Control = null;
			this.NsSyncInterval.MS_Next_Control = null;
			this.NsSyncInterval.Name = "NsSyncInterval";
			this.NsSyncInterval.Size = new System.Drawing.Size(42, 29);
			this.NsSyncInterval.TabIndex = 193;
			this.NsSyncInterval.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.NsSyncInterval.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			// 
			// NsAutoSyncStock
			// 
			this.NsAutoSyncStock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsAutoSyncStock.BackColor = System.Drawing.Color.Transparent;
			this.NsAutoSyncStock.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsAutoSyncStock.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F);
			this.NsAutoSyncStock.Location = new System.Drawing.Point(489, 63);
			this.NsAutoSyncStock.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsAutoSyncStock.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
			this.NsAutoSyncStock.MS_Change_Border_Color_On_Enter = true;
			this.NsAutoSyncStock.MS_Change_Color_On_Checked = true;
			this.NsAutoSyncStock.MS_Change_Color_On_Enter = true;
			this.NsAutoSyncStock.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NsAutoSyncStock.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsAutoSyncStock.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsAutoSyncStock.MS_Exit_By_Down = true;
			this.NsAutoSyncStock.MS_Exit_By_Enter = true;
			this.NsAutoSyncStock.MS_Exit_By_Up = true;
			this.NsAutoSyncStock.MS_Last_Control = null;
			this.NsAutoSyncStock.MS_Next_Control = null;
			this.NsAutoSyncStock.MS_UnChecked_Color = System.Drawing.Color.Transparent;
			this.NsAutoSyncStock.Name = "NsAutoSyncStock";
			this.NsAutoSyncStock.ShowFocusRectangle = false;
			this.NsAutoSyncStock.Size = new System.Drawing.Size(236, 26);
			this.NsAutoSyncStock.TabIndex = 191;
			this.NsAutoSyncStock.Text = "   ارسال موجودی کالا ها به صورت خودکار";
			this.NsAutoSyncStock.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			// 
			// NsApikey
			// 
			this.NsApikey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NsApikey.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsApikey.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
			this.NsApikey.Location = new System.Drawing.Point(93, 13);
			this.NsApikey.MaxLength = 200;
			this.NsApikey.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsApikey.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsApikey.MS_Change_Border_Color_On_Enter = true;
			this.NsApikey.MS_Change_Color_On_Enter = true;
			this.NsApikey.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsApikey.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsApikey.MS_Exit_By_Down = true;
			this.NsApikey.MS_Exit_By_Enter = true;
			this.NsApikey.MS_Exit_By_Up = true;
			this.NsApikey.MS_Last_Control = null;
			this.NsApikey.MS_Next_Control = null;
			this.NsApikey.Name = "NsApikey";
			this.NsApikey.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.NsApikey.Size = new System.Drawing.Size(632, 31);
			this.NsApikey.TabIndex = 190;
			// 
			// mS_Label1
			// 
			this.mS_Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mS_Label1.AutoSize = true;
			this.mS_Label1.BackColor = System.Drawing.Color.Transparent;
			this.mS_Label1.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.mS_Label1.Location = new System.Drawing.Point(731, 16);
			this.mS_Label1.MS_Border_Radius = 5;
			this.mS_Label1.MS_Color_End = System.Drawing.Color.Empty;
			this.mS_Label1.MS_Color_Start = System.Drawing.Color.Empty;
			this.mS_Label1.Name = "mS_Label1";
			this.mS_Label1.Size = new System.Drawing.Size(67, 23);
			this.mS_Label1.TabIndex = 189;
			this.mS_Label1.Text = "کلید Api : ";
			this.mS_Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// mS_Label4
			// 
			this.mS_Label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mS_Label4.AutoSize = true;
			this.mS_Label4.BackColor = System.Drawing.Color.Transparent;
			this.mS_Label4.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.mS_Label4.Location = new System.Drawing.Point(169, 80);
			this.mS_Label4.MS_Border_Radius = 5;
			this.mS_Label4.MS_Color_End = System.Drawing.Color.Empty;
			this.mS_Label4.MS_Color_Start = System.Drawing.Color.Empty;
			this.mS_Label4.Name = "mS_Label4";
			this.mS_Label4.Size = new System.Drawing.Size(38, 23);
			this.mS_Label4.TabIndex = 194;
			this.mS_Label4.Text = "دقیقه";
			this.mS_Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// mS_Label3
			// 
			this.mS_Label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mS_Label3.AutoSize = true;
			this.mS_Label3.BackColor = System.Drawing.Color.Transparent;
			this.mS_Label3.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.mS_Label3.Location = new System.Drawing.Point(249, 80);
			this.mS_Label3.MS_Border_Radius = 5;
			this.mS_Label3.MS_Color_End = System.Drawing.Color.Empty;
			this.mS_Label3.MS_Color_Start = System.Drawing.Color.Empty;
			this.mS_Label3.Name = "mS_Label3";
			this.mS_Label3.Size = new System.Drawing.Size(38, 23);
			this.mS_Label3.TabIndex = 192;
			this.mS_Label3.Text = "در هر";
			this.mS_Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// TabSettingContainer
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.NzTabs);
			this.Name = "TabSettingContainer";
			this.Size = new System.Drawing.Size(805, 436);
			((System.ComponentModel.ISupportInitialize)(this.NzTabs)).EndInit();
			this.NzTabs.ResumeLayout(false);
			this.NsOrderSetting.ResumeLayout(false);
			this.NsOrderSetting.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Janus.Windows.UI.Tab.UITab NzTabs;
		private ShareLib.Component.NsSettingTabPage NsOrderSetting;
		private MS_Control.Controls.MS_CheckBox NsAutoSyncStock;
		private MS_Control.Controls.MS_TextBox NsApikey;
		private MS_Control.Controls.MS_Label mS_Label1;
		private MS_Control.Controls.MS_Label mS_Label3;
		private MS_Control.Controls.MS_CheckBox NsAutoSyncOrders;
		private MS_Control.Controls.MS_NumericTextBox NsSyncInterval;
		private MS_Control.Controls.MS_Label mS_Label4;
	}
}
