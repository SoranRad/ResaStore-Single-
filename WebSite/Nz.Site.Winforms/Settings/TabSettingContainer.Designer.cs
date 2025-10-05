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
			Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem1 = new Janus.Windows.EditControls.UIComboBoxItem();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabSettingContainer));
			Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem2 = new Janus.Windows.EditControls.UIComboBoxItem();
			Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem3 = new Janus.Windows.EditControls.UIComboBoxItem();
			Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem4 = new Janus.Windows.EditControls.UIComboBoxItem();
			this.NzTabs = new Janus.Windows.UI.Tab.UITab();
			this.NsSiteSetting = new ShareLib.Component.NsSettingTabPage();
			this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
			this.NzBankAccount = new NZ.Xazane.WinForms.Component.NzAccounts();
			this.NzLocation = new Nz.Anbar.WinForms.Component.NzLocationEx();
			this.NzKindSale = new MS_Control.Controls.MS_ComboBox_Janus();
			this.NzKindSaleLbl = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
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
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
			this.uiGroupBox2.SuspendLayout();
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
			this.NzTabs.Size = new System.Drawing.Size(654, 458);
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
			this.NsSiteSetting.Controls.Add(this.uiGroupBox2);
			this.NsSiteSetting.Controls.Add(this.uiGroupBox1);
			this.NsSiteSetting.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NsSiteSetting.Location = new System.Drawing.Point(0, 23);
			this.NsSiteSetting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.NsSiteSetting.Name = "NsSiteSetting";
			this.NsSiteSetting.PanelFormatStyle.Alpha = 70;
			this.NsSiteSetting.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
			this.NsSiteSetting.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
			this.NsSiteSetting.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsSiteSetting.Size = new System.Drawing.Size(654, 435);
			this.NsSiteSetting.TabStop = true;
			this.NsSiteSetting.Text = "  وب سایت  ";
			// 
			// uiGroupBox2
			// 
			this.uiGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.uiGroupBox2.BackColor = System.Drawing.Color.Transparent;
			this.uiGroupBox2.BorderColor = System.Drawing.Color.LightBlue;
			this.uiGroupBox2.Controls.Add(this.NzBankAccount);
			this.uiGroupBox2.Controls.Add(this.NzLocation);
			this.uiGroupBox2.Controls.Add(this.NzKindSale);
			this.uiGroupBox2.Controls.Add(this.NzKindSaleLbl);
			this.uiGroupBox2.Controls.Add(this.label4);
			this.uiGroupBox2.Controls.Add(this.label6);
			this.uiGroupBox2.Location = new System.Drawing.Point(11, 216);
			this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(2);
			this.uiGroupBox2.Name = "uiGroupBox2";
			this.uiGroupBox2.Size = new System.Drawing.Size(632, 191);
			this.uiGroupBox2.TabIndex = 1;
			this.uiGroupBox2.Text = "تنظیمات فاکتور";
			// 
			// NzBankAccount
			// 
			this.NzBankAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzBankAccount.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
			this.NzBankAccount.DropSize = new System.Drawing.Size(289, 32);
			this.NzBankAccount.Font = new System.Drawing.Font("IRANSans(Small)", 15F);
			this.NzBankAccount.Location = new System.Drawing.Point(231, 133);
			this.NzBankAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.NzBankAccount.MS_Auto_Popup = false;
			this.NzBankAccount.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzBankAccount.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzBankAccount.MS_CaptureFocus = false;
			this.NzBankAccount.MS_Change_Border_Color_On_Enter = true;
			this.NzBankAccount.MS_Change_Color_On_Enter = true;
			this.NzBankAccount.MS_Drop_Direction = MS_Control.TSDD.KindShow.Right;
			this.NzBankAccount.MS_DropDownSizeMode = MS_Control.TSDD.SizeMode.Control_Size;
			this.NzBankAccount.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NzBankAccount.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzBankAccount.MS_Exit_By_Down = true;
			this.NzBankAccount.MS_Exit_By_Enter = true;
			this.NzBankAccount.MS_Exit_By_Up = true;
			this.NzBankAccount.MS_Last_Control = null;
			this.NzBankAccount.MS_Next_Control = null;
			this.NzBankAccount.Name = "NzBankAccount";
			this.NzBankAccount.Office2007CustomColor = System.Drawing.Color.SkyBlue;
			this.NzBankAccount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NzBankAccount.Size = new System.Drawing.Size(289, 32);
			this.NzBankAccount.TabIndex = 770;
			this.NzBankAccount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			// 
			// NzLocation
			// 
			this.NzLocation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzLocation.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
			this.NzLocation.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NzLocation.DropSize = new System.Drawing.Size(132, 29);
			this.NzLocation.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NzLocation.Location = new System.Drawing.Point(388, 41);
			this.NzLocation.MS_Auto_Popup = false;
			this.NzLocation.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzLocation.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzLocation.MS_CaptureFocus = false;
			this.NzLocation.MS_Change_Border_Color_On_Enter = true;
			this.NzLocation.MS_Change_Color_On_Enter = true;
			this.NzLocation.MS_Drop_Direction = MS_Control.TSDD.KindShow.Right;
			this.NzLocation.MS_DropDownSizeMode = MS_Control.TSDD.SizeMode.Control_Size;
			this.NzLocation.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NzLocation.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzLocation.MS_Exit_By_Down = true;
			this.NzLocation.MS_Exit_By_Enter = true;
			this.NzLocation.MS_Exit_By_Up = true;
			this.NzLocation.MS_Last_Control = null;
			this.NzLocation.MS_Next_Control = null;
			this.NzLocation.Name = "NzLocation";
			this.NzLocation.Size = new System.Drawing.Size(132, 29);
			this.NzLocation.TabIndex = 769;
			this.NzLocation.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			// 
			// NzKindSale
			// 
			this.NzKindSale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzKindSale.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
			this.NzKindSale.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NzKindSale.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			uiComboBoxItem1.FormatStyle.Alpha = 0;
			uiComboBoxItem1.Image = ((System.Drawing.Image)(resources.GetObject("uiComboBoxItem1.Image")));
			uiComboBoxItem1.IsSeparator = false;
			uiComboBoxItem1.Text = "فروش خرده";
			uiComboBoxItem2.FormatStyle.Alpha = 0;
			uiComboBoxItem2.Image = ((System.Drawing.Image)(resources.GetObject("uiComboBoxItem2.Image")));
			uiComboBoxItem2.IsSeparator = false;
			uiComboBoxItem2.Text = "فروش عمـده";
			uiComboBoxItem3.FormatStyle.Alpha = 0;
			uiComboBoxItem3.IsSeparator = false;
			uiComboBoxItem3.Text = "همکاری";
			uiComboBoxItem4.FormatStyle.Alpha = 0;
			uiComboBoxItem4.IsSeparator = false;
			uiComboBoxItem4.Text = "تخفیفات";
			this.NzKindSale.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            uiComboBoxItem1,
            uiComboBoxItem2,
            uiComboBoxItem3,
            uiComboBoxItem4});
			this.NzKindSale.Location = new System.Drawing.Point(379, 85);
			this.NzKindSale.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzKindSale.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzKindSale.MS_Change_Border_Color_On_Enter = true;
			this.NzKindSale.MS_Change_Color_On_Enter = true;
			this.NzKindSale.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NzKindSale.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzKindSale.MS_Exit_By_Down = true;
			this.NzKindSale.MS_Exit_By_Enter = true;
			this.NzKindSale.MS_Exit_By_Up = true;
			this.NzKindSale.MS_Last_Control = null;
			this.NzKindSale.MS_Next_Control = null;
			this.NzKindSale.Name = "NzKindSale";
			this.NzKindSale.Size = new System.Drawing.Size(141, 29);
			this.NzKindSale.TabIndex = 768;
			this.NzKindSale.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			// 
			// NzKindSaleLbl
			// 
			this.NzKindSaleLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzKindSaleLbl.AutoSize = true;
			this.NzKindSaleLbl.BackColor = System.Drawing.Color.Transparent;
			this.NzKindSaleLbl.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NzKindSaleLbl.Location = new System.Drawing.Point(526, 88);
			this.NzKindSaleLbl.Name = "NzKindSaleLbl";
			this.NzKindSaleLbl.Size = new System.Drawing.Size(71, 23);
			this.NzKindSaleLbl.TabIndex = 766;
			this.NzKindSaleLbl.Text = "نوع فروش :";
			this.NzKindSaleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.label4.Location = new System.Drawing.Point(526, 126);
			this.label4.Name = "label4";
			this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label4.Size = new System.Drawing.Size(85, 46);
			this.label4.TabIndex = 161;
			this.label4.Text = "حساب\r\n بانکی تسویه :";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.label6.Location = new System.Drawing.Point(526, 44);
			this.label6.Name = "label6";
			this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.label6.Size = new System.Drawing.Size(94, 23);
			this.label6.TabIndex = 161;
			this.label6.Text = "موقعیت فروش :";
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
			this.uiGroupBox1.Size = new System.Drawing.Size(632, 191);
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
			this.Size = new System.Drawing.Size(654, 458);
			((System.ComponentModel.ISupportInitialize)(this.NzTabs)).EndInit();
			this.NzTabs.ResumeLayout(false);
			this.NsSiteSetting.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
			this.uiGroupBox2.ResumeLayout(false);
			this.uiGroupBox2.PerformLayout();
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
		private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label NzKindSaleLbl;
		private Anbar.WinForms.Component.NzLocationEx NzLocation;
		private MS_Control.Controls.MS_ComboBox_Janus NzKindSale;
		private NZ.Xazane.WinForms.Component.NzAccounts NzBankAccount;
	}
}
