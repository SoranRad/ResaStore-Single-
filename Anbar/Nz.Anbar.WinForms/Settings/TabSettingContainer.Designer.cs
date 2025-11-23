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
			this.mS_Text_Simple1 = new MS_Control.Controls.MS_Text_Simple();
			this.NsIsOffActive = new MS_Control.Controls.MS_CheckBox();
			this.NsOffAmount = new MS_Control.Controls.MS_NumericTextBox();
			this.NsIsOffAmount = new MS_Control.Controls.MS_RadioBox();
			this.mS_Text_Simple3 = new MS_Control.Controls.MS_Text_Simple();
			this.mS_Text_Simple2 = new MS_Control.Controls.MS_Text_Simple();
			this.NsIsOffPercent = new MS_Control.Controls.MS_RadioBox();
			this.mS_Text_Simple4 = new MS_Control.Controls.MS_Text_Simple();
			this.NsPrinters = new MS_Control.Controls.MS_ComboBox_Janus();
			this.mS_Lable_Ex3 = new MS_Control.Controls.MS_Lable_Ex();
			this.NzLocation = new Nz.Anbar.WinForms.Component.NzLocation();
			this.mS_Lable_Ex2 = new MS_Control.Controls.MS_Lable_Ex();
			this.NzCustomer = new NZ.General.WinForms.Component.NzPeople();
			this.mS_Lable_Ex1 = new MS_Control.Controls.MS_Lable_Ex();
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
			this.NzTabs.Size = new System.Drawing.Size(563, 423);
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
			this.NsStorageSetting.AutoScroll = true;
			this.NsStorageSetting.Controls.Add(this.mS_Text_Simple1);
			this.NsStorageSetting.Controls.Add(this.NsIsOffActive);
			this.NsStorageSetting.Controls.Add(this.NsOffAmount);
			this.NsStorageSetting.Controls.Add(this.NsIsOffAmount);
			this.NsStorageSetting.Controls.Add(this.mS_Text_Simple3);
			this.NsStorageSetting.Controls.Add(this.mS_Text_Simple2);
			this.NsStorageSetting.Controls.Add(this.NsIsOffPercent);
			this.NsStorageSetting.Controls.Add(this.mS_Text_Simple4);
			this.NsStorageSetting.Controls.Add(this.NsPrinters);
			this.NsStorageSetting.Controls.Add(this.mS_Lable_Ex3);
			this.NsStorageSetting.Controls.Add(this.NzLocation);
			this.NsStorageSetting.Controls.Add(this.mS_Lable_Ex2);
			this.NsStorageSetting.Controls.Add(this.NzCustomer);
			this.NsStorageSetting.Controls.Add(this.mS_Lable_Ex1);
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
			this.NsStorageSetting.Size = new System.Drawing.Size(563, 400);
			this.NsStorageSetting.TabStop = true;
			this.NsStorageSetting.Text = "خرید و فروش";
			// 
			// mS_Text_Simple1
			// 
			this.mS_Text_Simple1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.mS_Text_Simple1.BackColor = System.Drawing.Color.LimeGreen;
			this.mS_Text_Simple1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.mS_Text_Simple1.Location = new System.Drawing.Point(408, 372);
			this.mS_Text_Simple1.MS_BorderColor = System.Drawing.Color.Empty;
			this.mS_Text_Simple1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
			this.mS_Text_Simple1.MS_Change_Border_Color_On_Enter = false;
			this.mS_Text_Simple1.MS_Change_Color_On_Enter = false;
			this.mS_Text_Simple1.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.mS_Text_Simple1.MS_Enter_Color = System.Drawing.Color.Empty;
			this.mS_Text_Simple1.MS_Exit_By_Down = false;
			this.mS_Text_Simple1.MS_Exit_By_Enter = false;
			this.mS_Text_Simple1.MS_Exit_By_Up = false;
			this.mS_Text_Simple1.MS_Last_Control = null;
			this.mS_Text_Simple1.MS_Next_Control = null;
			this.mS_Text_Simple1.Multiline = true;
			this.mS_Text_Simple1.Name = "mS_Text_Simple1";
			this.mS_Text_Simple1.Size = new System.Drawing.Size(12, 2);
			this.mS_Text_Simple1.TabIndex = 862;
			// 
			// NsIsOffActive
			// 
			this.NsIsOffActive.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.NsIsOffActive.BackColor = System.Drawing.Color.Transparent;
			this.NsIsOffActive.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsIsOffActive.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F);
			this.NsIsOffActive.Location = new System.Drawing.Point(431, 339);
			this.NsIsOffActive.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsIsOffActive.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
			this.NsIsOffActive.MS_Change_Border_Color_On_Enter = true;
			this.NsIsOffActive.MS_Change_Color_On_Checked = true;
			this.NsIsOffActive.MS_Change_Color_On_Enter = true;
			this.NsIsOffActive.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NsIsOffActive.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsIsOffActive.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsIsOffActive.MS_Exit_By_Down = true;
			this.NsIsOffActive.MS_Exit_By_Enter = true;
			this.NsIsOffActive.MS_Exit_By_Up = true;
			this.NsIsOffActive.MS_Last_Control = null;
			this.NsIsOffActive.MS_Next_Control = null;
			this.NsIsOffActive.MS_UnChecked_Color = System.Drawing.Color.Transparent;
			this.NsIsOffActive.Name = "NsIsOffActive";
			this.NsIsOffActive.ShowFocusRectangle = false;
			this.NsIsOffActive.Size = new System.Drawing.Size(117, 26);
			this.NsIsOffActive.TabIndex = 861;
			this.NsIsOffActive.Text = "  تخـفیـف فروش : ";
			this.NsIsOffActive.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			this.NsIsOffActive.CheckedChanged += new System.EventHandler(this.NsIsOffActive_CheckedChanged);
			// 
			// NsOffAmount
			// 
			this.NsOffAmount.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.NsOffAmount.ButtonText = "000";
			this.NsOffAmount.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsOffAmount.Enabled = false;
			this.NsOffAmount.Font = new System.Drawing.Font("IRANSans(Small) Medium", 14F);
			this.NsOffAmount.Location = new System.Drawing.Point(241, 333);
			this.NsOffAmount.MaxLength = 0;
			this.NsOffAmount.Mode = MS_Control.Controls.MS_NumericTextBox.TextBoxMode.IntNumber;
			this.NsOffAmount.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsOffAmount.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsOffAmount.MS_Change_Border_Color_On_Enter = true;
			this.NsOffAmount.MS_Change_Color_On_Enter = true;
			this.NsOffAmount.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsOffAmount.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsOffAmount.MS_Exit_By_Down = true;
			this.NsOffAmount.MS_Exit_By_Enter = true;
			this.NsOffAmount.MS_Exit_By_Up = true;
			this.NsOffAmount.MS_Is_Negative = false;
			this.NsOffAmount.MS_Last_Control = null;
			this.NsOffAmount.MS_Next_Control = null;
			this.NsOffAmount.Name = "NsOffAmount";
			this.NsOffAmount.Size = new System.Drawing.Size(100, 30);
			this.NsOffAmount.TabIndex = 860;
			this.NsOffAmount.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
			this.NsOffAmount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			// 
			// NsIsOffAmount
			// 
			this.NsIsOffAmount.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.NsIsOffAmount.BackColor = System.Drawing.Color.LightBlue;
			this.NsIsOffAmount.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsIsOffAmount.Enabled = false;
			this.NsIsOffAmount.Location = new System.Drawing.Point(347, 362);
			this.NsIsOffAmount.MS_BorderColor = System.Drawing.Color.Empty;
			this.NsIsOffAmount.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsIsOffAmount.MS_Change_Border_Color_On_Enter = true;
			this.NsIsOffAmount.MS_Change_Color_On_Checked = true;
			this.NsIsOffAmount.MS_Change_Color_On_Enter = true;
			this.NsIsOffAmount.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsIsOffAmount.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsIsOffAmount.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsIsOffAmount.MS_Exit_By_Down = true;
			this.NsIsOffAmount.MS_Exit_By_Enter = true;
			this.NsIsOffAmount.MS_Exit_By_Up = true;
			this.NsIsOffAmount.MS_Last_Control = null;
			this.NsIsOffAmount.MS_Next_Control = null;
			this.NsIsOffAmount.MS_UnChecked_Color = System.Drawing.Color.LightBlue;
			this.NsIsOffAmount.Name = "NsIsOffAmount";
			this.NsIsOffAmount.ShowFocusRectangle = false;
			this.NsIsOffAmount.Size = new System.Drawing.Size(55, 23);
			this.NsIsOffAmount.TabIndex = 856;
			this.NsIsOffAmount.Text = "مبلغ";
			// 
			// mS_Text_Simple3
			// 
			this.mS_Text_Simple3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.mS_Text_Simple3.BackColor = System.Drawing.Color.LimeGreen;
			this.mS_Text_Simple3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.mS_Text_Simple3.Location = new System.Drawing.Point(419, 350);
			this.mS_Text_Simple3.MS_BorderColor = System.Drawing.Color.Empty;
			this.mS_Text_Simple3.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
			this.mS_Text_Simple3.MS_Change_Border_Color_On_Enter = false;
			this.mS_Text_Simple3.MS_Change_Color_On_Enter = false;
			this.mS_Text_Simple3.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.mS_Text_Simple3.MS_Enter_Color = System.Drawing.Color.Empty;
			this.mS_Text_Simple3.MS_Exit_By_Down = false;
			this.mS_Text_Simple3.MS_Exit_By_Enter = false;
			this.mS_Text_Simple3.MS_Exit_By_Up = false;
			this.mS_Text_Simple3.MS_Last_Control = null;
			this.mS_Text_Simple3.MS_Next_Control = null;
			this.mS_Text_Simple3.Multiline = true;
			this.mS_Text_Simple3.Name = "mS_Text_Simple3";
			this.mS_Text_Simple3.Size = new System.Drawing.Size(16, 2);
			this.mS_Text_Simple3.TabIndex = 857;
			// 
			// mS_Text_Simple2
			// 
			this.mS_Text_Simple2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.mS_Text_Simple2.BackColor = System.Drawing.Color.LimeGreen;
			this.mS_Text_Simple2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.mS_Text_Simple2.Location = new System.Drawing.Point(419, 323);
			this.mS_Text_Simple2.MS_BorderColor = System.Drawing.Color.Empty;
			this.mS_Text_Simple2.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
			this.mS_Text_Simple2.MS_Change_Border_Color_On_Enter = false;
			this.mS_Text_Simple2.MS_Change_Color_On_Enter = false;
			this.mS_Text_Simple2.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.mS_Text_Simple2.MS_Enter_Color = System.Drawing.Color.Empty;
			this.mS_Text_Simple2.MS_Exit_By_Down = false;
			this.mS_Text_Simple2.MS_Exit_By_Enter = false;
			this.mS_Text_Simple2.MS_Exit_By_Up = false;
			this.mS_Text_Simple2.MS_Last_Control = null;
			this.mS_Text_Simple2.MS_Next_Control = null;
			this.mS_Text_Simple2.Multiline = true;
			this.mS_Text_Simple2.Name = "mS_Text_Simple2";
			this.mS_Text_Simple2.Size = new System.Drawing.Size(2, 50);
			this.mS_Text_Simple2.TabIndex = 858;
			// 
			// NsIsOffPercent
			// 
			this.NsIsOffPercent.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.NsIsOffPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsIsOffPercent.Checked = true;
			this.NsIsOffPercent.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsIsOffPercent.Enabled = false;
			this.NsIsOffPercent.FormatStyle.Alpha = 70;
			this.NsIsOffPercent.FormatStyle.BackColor = System.Drawing.Color.SkyBlue;
			this.NsIsOffPercent.FormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
			this.NsIsOffPercent.Location = new System.Drawing.Point(347, 312);
			this.NsIsOffPercent.MS_BorderColor = System.Drawing.Color.Empty;
			this.NsIsOffPercent.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsIsOffPercent.MS_Change_Border_Color_On_Enter = true;
			this.NsIsOffPercent.MS_Change_Color_On_Checked = true;
			this.NsIsOffPercent.MS_Change_Color_On_Enter = true;
			this.NsIsOffPercent.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsIsOffPercent.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsIsOffPercent.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsIsOffPercent.MS_Exit_By_Down = true;
			this.NsIsOffPercent.MS_Exit_By_Enter = true;
			this.NsIsOffPercent.MS_Exit_By_Up = true;
			this.NsIsOffPercent.MS_Last_Control = null;
			this.NsIsOffPercent.MS_Next_Control = null;
			this.NsIsOffPercent.MS_UnChecked_Color = System.Drawing.Color.Empty;
			this.NsIsOffPercent.Name = "NsIsOffPercent";
			this.NsIsOffPercent.ShowFocusRectangle = false;
			this.NsIsOffPercent.Size = new System.Drawing.Size(55, 23);
			this.NsIsOffPercent.TabIndex = 855;
			this.NsIsOffPercent.TabStop = true;
			this.NsIsOffPercent.Text = "درصد";
			// 
			// mS_Text_Simple4
			// 
			this.mS_Text_Simple4.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.mS_Text_Simple4.BackColor = System.Drawing.Color.LimeGreen;
			this.mS_Text_Simple4.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.mS_Text_Simple4.Location = new System.Drawing.Point(408, 322);
			this.mS_Text_Simple4.MS_BorderColor = System.Drawing.Color.Empty;
			this.mS_Text_Simple4.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
			this.mS_Text_Simple4.MS_Change_Border_Color_On_Enter = false;
			this.mS_Text_Simple4.MS_Change_Color_On_Enter = false;
			this.mS_Text_Simple4.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.mS_Text_Simple4.MS_Enter_Color = System.Drawing.Color.Empty;
			this.mS_Text_Simple4.MS_Exit_By_Down = false;
			this.mS_Text_Simple4.MS_Exit_By_Enter = false;
			this.mS_Text_Simple4.MS_Exit_By_Up = false;
			this.mS_Text_Simple4.MS_Last_Control = null;
			this.mS_Text_Simple4.MS_Next_Control = null;
			this.mS_Text_Simple4.Multiline = true;
			this.mS_Text_Simple4.Name = "mS_Text_Simple4";
			this.mS_Text_Simple4.Size = new System.Drawing.Size(12, 2);
			this.mS_Text_Simple4.TabIndex = 859;
			// 
			// NsPrinters
			// 
			this.NsPrinters.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.NsPrinters.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsPrinters.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F);
			this.NsPrinters.Location = new System.Drawing.Point(210, 255);
			this.NsPrinters.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsPrinters.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsPrinters.MS_Change_Border_Color_On_Enter = true;
			this.NsPrinters.MS_Change_Color_On_Enter = true;
			this.NsPrinters.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsPrinters.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.NsPrinters.MS_Exit_By_Down = true;
			this.NsPrinters.MS_Exit_By_Enter = true;
			this.NsPrinters.MS_Exit_By_Up = true;
			this.NsPrinters.MS_Last_Control = null;
			this.NsPrinters.MS_Next_Control = null;
			this.NsPrinters.Name = "NsPrinters";
			this.NsPrinters.Size = new System.Drawing.Size(196, 29);
			this.NsPrinters.TabIndex = 824;
			this.NsPrinters.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			// 
			// mS_Lable_Ex3
			// 
			this.mS_Lable_Ex3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.mS_Lable_Ex3.BackColor = System.Drawing.Color.Transparent;
			this.mS_Lable_Ex3.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
			this.mS_Lable_Ex3.Location = new System.Drawing.Point(412, 246);
			this.mS_Lable_Ex3.MS_BorderColor = System.Drawing.Color.Tan;
			this.mS_Lable_Ex3.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
			this.mS_Lable_Ex3.MS_Color_End = System.Drawing.Color.Empty;
			this.mS_Lable_Ex3.MS_Color_Start = System.Drawing.Color.Empty;
			this.mS_Lable_Ex3.Name = "mS_Lable_Ex3";
			this.mS_Lable_Ex3.Size = new System.Drawing.Size(144, 61);
			this.mS_Lable_Ex3.TabIndex = 823;
			this.mS_Lable_Ex3.Text = "انتخاب دستگاه چاپ\r\n برای بارکد خوان :";
			this.mS_Lable_Ex3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// NzLocation
			// 
			this.NzLocation.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.NzLocation.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
			this.NzLocation.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NzLocation.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NzLocation.Location = new System.Drawing.Point(170, 203);
			this.NzLocation.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzLocation.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzLocation.MS_Change_Border_Color_On_Enter = true;
			this.NzLocation.MS_Change_Color_On_Enter = true;
			this.NzLocation.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NzLocation.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzLocation.MS_Exit_By_Down = true;
			this.NzLocation.MS_Exit_By_Enter = true;
			this.NzLocation.MS_Exit_By_Up = true;
			this.NzLocation.MS_Last_Control = null;
			this.NzLocation.MS_Next_Control = null;
			this.NzLocation.Name = "NzLocation";
			this.NzLocation.Size = new System.Drawing.Size(236, 29);
			this.NzLocation.TabIndex = 822;
			this.NzLocation.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			// 
			// mS_Lable_Ex2
			// 
			this.mS_Lable_Ex2.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.mS_Lable_Ex2.BackColor = System.Drawing.Color.Transparent;
			this.mS_Lable_Ex2.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
			this.mS_Lable_Ex2.Location = new System.Drawing.Point(398, 185);
			this.mS_Lable_Ex2.MS_BorderColor = System.Drawing.Color.Tan;
			this.mS_Lable_Ex2.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
			this.mS_Lable_Ex2.MS_Color_End = System.Drawing.Color.Empty;
			this.mS_Lable_Ex2.MS_Color_Start = System.Drawing.Color.Empty;
			this.mS_Lable_Ex2.Name = "mS_Lable_Ex2";
			this.mS_Lable_Ex2.Size = new System.Drawing.Size(162, 61);
			this.mS_Lable_Ex2.TabIndex = 821;
			this.mS_Lable_Ex2.Text = "موقعیت پیش فرض در فروش بارکدخوان :";
			this.mS_Lable_Ex2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// NzCustomer
			// 
			this.NzCustomer.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.NzCustomer.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
			this.NzCustomer.DropSize = new System.Drawing.Size(236, 31);
			this.NzCustomer.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
			this.NzCustomer.Location = new System.Drawing.Point(170, 139);
			this.NzCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.NzCustomer.MS_Auto_Popup = false;
			this.NzCustomer.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzCustomer.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzCustomer.MS_CaptureFocus = false;
			this.NzCustomer.MS_Change_Border_Color_On_Enter = true;
			this.NzCustomer.MS_Change_Color_On_Enter = true;
			this.NzCustomer.MS_Drop_Direction = MS_Control.TSDD.KindShow.Right;
			this.NzCustomer.MS_DropDownSizeMode = MS_Control.TSDD.SizeMode.Control_Size;
			this.NzCustomer.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NzCustomer.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzCustomer.MS_Exit_By_Down = true;
			this.NzCustomer.MS_Exit_By_Enter = true;
			this.NzCustomer.MS_Exit_By_Up = true;
			this.NzCustomer.MS_Last_Control = null;
			this.NzCustomer.MS_Next_Control = null;
			this.NzCustomer.Name = "NzCustomer";
			this.NzCustomer.Office2007CustomColor = System.Drawing.Color.SkyBlue;
			this.NzCustomer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NzCustomer.Size = new System.Drawing.Size(236, 31);
			this.NzCustomer.TabIndex = 820;
			this.NzCustomer.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			// 
			// mS_Lable_Ex1
			// 
			this.mS_Lable_Ex1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.mS_Lable_Ex1.BackColor = System.Drawing.Color.Transparent;
			this.mS_Lable_Ex1.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
			this.mS_Lable_Ex1.Location = new System.Drawing.Point(398, 124);
			this.mS_Lable_Ex1.MS_BorderColor = System.Drawing.Color.Tan;
			this.mS_Lable_Ex1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
			this.mS_Lable_Ex1.MS_Color_End = System.Drawing.Color.Empty;
			this.mS_Lable_Ex1.MS_Color_Start = System.Drawing.Color.Empty;
			this.mS_Lable_Ex1.Name = "mS_Lable_Ex1";
			this.mS_Lable_Ex1.Size = new System.Drawing.Size(162, 61);
			this.mS_Lable_Ex1.TabIndex = 819;
			this.mS_Lable_Ex1.Text = "حساب پیش فرض شخص\r\n در فروش بارکدخوان :";
			this.mS_Lable_Ex1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// NsAdvancedSearch
			// 
			this.NsAdvancedSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.NsAdvancedSearch.BackColor = System.Drawing.Color.Transparent;
			this.NsAdvancedSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsAdvancedSearch.Location = new System.Drawing.Point(44, 83);
			this.NsAdvancedSearch.Margin = new System.Windows.Forms.Padding(7, 21, 7, 21);
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
			this.NsAdvancedSearch.Size = new System.Drawing.Size(497, 31);
			this.NsAdvancedSearch.TabIndex = 818;
			this.NsAdvancedSearch.Text = "  به صورت پیش فرض از جستجوی داخل جملات در جستجوی کالا استفاده شود";
			this.NsAdvancedSearch.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			// 
			// NsMainGroup
			// 
			this.NsMainGroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.NsMainGroup.BackColor = System.Drawing.Color.Transparent;
			this.NsMainGroup.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsMainGroup.Location = new System.Drawing.Point(44, 52);
			this.NsMainGroup.Margin = new System.Windows.Forms.Padding(7, 21, 7, 21);
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
			this.NsMainGroup.Size = new System.Drawing.Size(497, 31);
			this.NsMainGroup.TabIndex = 817;
			this.NsMainGroup.Text = "  گروه اصلی کالا/خدمات در سیستم استفاده شود";
			this.NsMainGroup.VisualStyle = Janus.Windows.UI.VisualStyle.Office2003;
			// 
			// NsPrintRemaind
			// 
			this.NsPrintRemaind.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.NsPrintRemaind.BackColor = System.Drawing.Color.Transparent;
			this.NsPrintRemaind.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsPrintRemaind.Location = new System.Drawing.Point(44, 21);
			this.NsPrintRemaind.Margin = new System.Windows.Forms.Padding(7, 21, 7, 21);
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
			this.NsPrintRemaind.Size = new System.Drawing.Size(497, 31);
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
			this.Size = new System.Drawing.Size(563, 423);
			((System.ComponentModel.ISupportInitialize)(this.NzTabs)).EndInit();
			this.NzTabs.ResumeLayout(false);
			this.NsStorageSetting.ResumeLayout(false);
			this.NsStorageSetting.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Janus.Windows.UI.Tab.UITab NzTabs;
		private NsSettingTabPage NsStorageSetting;
		private MS_Control.Controls.MS_CheckBox NsPrintRemaind;
		private MS_Control.Controls.MS_CheckBox NsMainGroup;
		private MS_Control.Controls.MS_CheckBox NsAdvancedSearch;
		private MS_Control.Controls.MS_Lable_Ex mS_Lable_Ex1;
		private NZ.General.WinForms.Component.NzPeople NzCustomer;
		private MS_Control.Controls.MS_Lable_Ex mS_Lable_Ex2;
		private Component.NzLocation NzLocation;
		private MS_Control.Controls.MS_Lable_Ex mS_Lable_Ex3;
		private MS_Control.Controls.MS_ComboBox_Janus NsPrinters;
        private MS_Control.Controls.MS_CheckBox NsIsOffActive;
        private MS_Control.Controls.MS_NumericTextBox NsOffAmount;
        private MS_Control.Controls.MS_RadioBox NsIsOffAmount;
        private MS_Control.Controls.MS_Text_Simple mS_Text_Simple3;
        private MS_Control.Controls.MS_Text_Simple mS_Text_Simple2;
        private MS_Control.Controls.MS_RadioBox NsIsOffPercent;
        private MS_Control.Controls.MS_Text_Simple mS_Text_Simple4;
        private MS_Control.Controls.MS_Text_Simple mS_Text_Simple1;
    }
}
