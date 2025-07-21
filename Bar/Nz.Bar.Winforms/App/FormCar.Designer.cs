namespace Nz.Bar.Winforms.App
{
	partial class FormCar
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCar));
			Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem1 = new Janus.Windows.EditControls.UIComboBoxItem();
			Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem2 = new Janus.Windows.EditControls.UIComboBoxItem();
			this.Panel_Foother = new MS_Control.Controls.MS_Panel();
			this.ms_Save = new MS_Control.Controls.MS_Button_GridX();
			this.ms_Exit = new MS_Control.Controls.MS_Button_GridX();
			this.Tab_Control_Main = new Janus.Windows.UI.Tab.UITab();
			this.uiTabPage12 = new Janus.Windows.UI.Tab.UITabPage();
			this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
			this.NzState = new MS_Control.Controls.MS_ComboBox_Janus();
			this.label1 = new System.Windows.Forms.Label();
			this.NzTitle = new MS_Control.Controls.MS_TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.uiTabPage14 = new Janus.Windows.UI.Tab.UITabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.NzCode = new MS_Control.Controls.MS_NumericTextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.mS_TextBox1 = new MS_Control.Controls.MS_TextBox();
			this.NzCustomer = new NZ.General.WinForms.Component.NzPeople();
			this.Panel_Foother.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).BeginInit();
			this.Tab_Control_Main.SuspendLayout();
			this.uiTabPage12.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
			this.uiGroupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Panel_Foother
			// 
			this.Panel_Foother.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Panel_Foother.Controls.Add(this.ms_Save);
			this.Panel_Foother.Controls.Add(this.ms_Exit);
			this.Panel_Foother.Location = new System.Drawing.Point(1, 261);
			this.Panel_Foother.MS_BorderColor = System.Drawing.Color.DarkGray;
			this.Panel_Foother.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.Panel_Foother.MS_Color_End = System.Drawing.Color.Gainsboro;
			this.Panel_Foother.MS_Color_Start = System.Drawing.Color.WhiteSmoke;
			this.Panel_Foother.Name = "Panel_Foother";
			this.Panel_Foother.Size = new System.Drawing.Size(387, 51);
			this.Panel_Foother.TabIndex = 1;
			// 
			// ms_Save
			// 
			this.ms_Save.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ms_Save.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ms_Save.Image = ((System.Drawing.Image)(resources.GetObject("ms_Save.Image")));
			this.ms_Save.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
			this.ms_Save.Location = new System.Drawing.Point(150, 11);
			this.ms_Save.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.ms_Save.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.ms_Save.MS_Change_Border_Color_On_Enter = false;
			this.ms_Save.MS_Change_Color_On_Enter = false;
			this.ms_Save.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.ms_Save.MS_Enter_Color = System.Drawing.Color.Empty;
			this.ms_Save.Name = "ms_Save";
			this.ms_Save.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
			this.ms_Save.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
			this.ms_Save.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ms_Save.ShowFocusRectangle = false;
			this.ms_Save.Size = new System.Drawing.Size(103, 30);
			this.ms_Save.TabIndex = 0;
			this.ms_Save.Text = "ثـبــت   [F2]";
			this.ms_Save.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
			this.ms_Save.UseThemes = false;
			this.ms_Save.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.ms_Save.WordWrap = false;
			// 
			// ms_Exit
			// 
			this.ms_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ms_Exit.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ms_Exit.Image = ((System.Drawing.Image)(resources.GetObject("ms_Exit.Image")));
			this.ms_Exit.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
			this.ms_Exit.Location = new System.Drawing.Point(12, 11);
			this.ms_Exit.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.ms_Exit.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.ms_Exit.MS_Change_Border_Color_On_Enter = false;
			this.ms_Exit.MS_Change_Color_On_Enter = false;
			this.ms_Exit.MS_Enter_Border_Color = System.Drawing.Color.Empty;
			this.ms_Exit.MS_Enter_Color = System.Drawing.Color.Empty;
			this.ms_Exit.Name = "ms_Exit";
			this.ms_Exit.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
			this.ms_Exit.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
			this.ms_Exit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ms_Exit.ShowFocusRectangle = false;
			this.ms_Exit.Size = new System.Drawing.Size(132, 30);
			this.ms_Exit.TabIndex = 1;
			this.ms_Exit.Text = "انــصــراف   [Esc]";
			this.ms_Exit.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
			this.ms_Exit.UseThemes = false;
			this.ms_Exit.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.ms_Exit.WordWrap = false;
			// 
			// Tab_Control_Main
			// 
			this.Tab_Control_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.Tab_Control_Main.BackColor = System.Drawing.Color.Transparent;
			this.Tab_Control_Main.Font = new System.Drawing.Font("IRANSans(Small) Medium", 14F);
			this.Tab_Control_Main.Location = new System.Drawing.Point(0, 0);
			this.Tab_Control_Main.MultiLine = true;
			this.Tab_Control_Main.Name = "Tab_Control_Main";
			this.Tab_Control_Main.Office2007CustomColor = System.Drawing.Color.Transparent;
			this.Tab_Control_Main.ShowFocusRectangle = false;
			this.Tab_Control_Main.Size = new System.Drawing.Size(421, 261);
			this.Tab_Control_Main.TabIndex = 0;
			this.Tab_Control_Main.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage12,
            this.uiTabPage14});
			this.Tab_Control_Main.TabsStateStyles.DisabledFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Tab_Control_Main.TabsStateStyles.DisabledFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.Tab_Control_Main.TabsStateStyles.FormatStyle.BackColor = System.Drawing.Color.PowderBlue;
			this.Tab_Control_Main.TabsStateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.Gold;
			this.Tab_Control_Main.TabsStateStyles.SelectedFormatStyle.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F);
			this.Tab_Control_Main.TabStripAlignment = Janus.Windows.UI.Tab.TabStripAlignment.Right;
			this.Tab_Control_Main.TextOrientation = Janus.Windows.UI.Tab.TextOrientation.Vertical;
			this.Tab_Control_Main.UseThemes = false;
			this.Tab_Control_Main.VisualStyle = Janus.Windows.UI.Tab.TabVisualStyle.Office2003;
			// 
			// uiTabPage12
			// 
			this.uiTabPage12.Controls.Add(this.uiGroupBox1);
			this.uiTabPage12.Location = new System.Drawing.Point(1, 1);
			this.uiTabPage12.Name = "uiTabPage12";
			this.uiTabPage12.PanelFormatStyle.Alpha = 70;
			this.uiTabPage12.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
			this.uiTabPage12.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
			this.uiTabPage12.PanelFormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical;
			this.uiTabPage12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.uiTabPage12.Size = new System.Drawing.Size(387, 259);
			this.uiTabPage12.TabStop = true;
			this.uiTabPage12.Text = "اطلاعات";
			// 
			// uiGroupBox1
			// 
			this.uiGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.uiGroupBox1.BackColor = System.Drawing.Color.Transparent;
			this.uiGroupBox1.BorderColor = System.Drawing.Color.LightBlue;
			this.uiGroupBox1.Controls.Add(this.NzCustomer);
			this.uiGroupBox1.Controls.Add(this.label3);
			this.uiGroupBox1.Controls.Add(this.label2);
			this.uiGroupBox1.Controls.Add(this.NzCode);
			this.uiGroupBox1.Controls.Add(this.NzState);
			this.uiGroupBox1.Controls.Add(this.label1);
			this.uiGroupBox1.Controls.Add(this.mS_TextBox1);
			this.uiGroupBox1.Controls.Add(this.NzTitle);
			this.uiGroupBox1.Controls.Add(this.label4);
			this.uiGroupBox1.Controls.Add(this.label6);
			this.uiGroupBox1.Location = new System.Drawing.Point(11, 8);
			this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.uiGroupBox1.Name = "uiGroupBox1";
			this.uiGroupBox1.Size = new System.Drawing.Size(363, 237);
			this.uiGroupBox1.TabIndex = 0;
			// 
			// NzState
			// 
			this.NzState.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzState.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
			this.NzState.Cursor = System.Windows.Forms.Cursors.Hand;
			uiComboBoxItem1.FormatStyle.Alpha = 0;
			uiComboBoxItem1.Image = ((System.Drawing.Image)(resources.GetObject("uiComboBoxItem1.Image")));
			uiComboBoxItem1.IsSeparator = false;
			uiComboBoxItem1.Text = "فعال";
			uiComboBoxItem2.FormatStyle.Alpha = 0;
			uiComboBoxItem2.Image = ((System.Drawing.Image)(resources.GetObject("uiComboBoxItem2.Image")));
			uiComboBoxItem2.IsSeparator = false;
			uiComboBoxItem2.Text = "غیر فعال";
			this.NzState.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            uiComboBoxItem1,
            uiComboBoxItem2});
			this.NzState.Location = new System.Drawing.Point(154, 176);
			this.NzState.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzState.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzState.MS_Change_Border_Color_On_Enter = true;
			this.NzState.MS_Change_Color_On_Enter = true;
			this.NzState.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NzState.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzState.MS_Exit_By_Down = true;
			this.NzState.MS_Exit_By_Enter = true;
			this.NzState.MS_Exit_By_Up = true;
			this.NzState.MS_Last_Control = null;
			this.NzState.MS_Next_Control = null;
			this.NzState.Name = "NzState";
			this.NzState.Size = new System.Drawing.Size(115, 30);
			this.NzState.TabIndex = 4;
			this.NzState.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F);
			this.label1.Location = new System.Drawing.Point(271, 180);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 23);
			this.label1.TabIndex = 167;
			this.label1.Text = "وضعیت :";
			// 
			// NzTitle
			// 
			this.NzTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzTitle.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NzTitle.Location = new System.Drawing.Point(117, 100);
			this.NzTitle.MaxLength = 200;
			this.NzTitle.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzTitle.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzTitle.MS_Change_Border_Color_On_Enter = true;
			this.NzTitle.MS_Change_Color_On_Enter = true;
			this.NzTitle.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NzTitle.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzTitle.MS_Exit_By_Down = true;
			this.NzTitle.MS_Exit_By_Enter = true;
			this.NzTitle.MS_Exit_By_Up = true;
			this.NzTitle.MS_Last_Control = null;
			this.NzTitle.MS_Next_Control = null;
			this.NzTitle.Name = "NzTitle";
			this.NzTitle.Size = new System.Drawing.Size(152, 30);
			this.NzTitle.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("IRANSans(Small) Medium", 14F);
			this.label6.Location = new System.Drawing.Point(271, 103);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(77, 24);
			this.label6.TabIndex = 161;
			this.label6.Text = "نوع ماشین :";
			// 
			// uiTabPage14
			// 
			this.uiTabPage14.AutoScroll = true;
			this.uiTabPage14.Location = new System.Drawing.Point(1, 1);
			this.uiTabPage14.Name = "uiTabPage14";
			this.uiTabPage14.PanelFormatStyle.Alpha = 70;
			this.uiTabPage14.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
			this.uiTabPage14.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
			this.uiTabPage14.PanelFormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical;
			this.uiTabPage14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.uiTabPage14.Size = new System.Drawing.Size(448, 209);
			this.uiTabPage14.TabStop = true;
			this.uiTabPage14.Text = "پرسش و پاسخ";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F);
			this.label2.Location = new System.Drawing.Point(271, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 23);
			this.label2.TabIndex = 169;
			this.label2.Text = "کــد :";
			// 
			// NzCode
			// 
			this.NzCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzCode.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NzCode.DigitGroup = false;
			this.NzCode.Font = new System.Drawing.Font("IRANSans(Small) Medium", 14F);
			this.NzCode.Location = new System.Drawing.Point(183, 25);
			this.NzCode.MaxLength = 4;
			this.NzCode.Mode = MS_Control.Controls.MS_NumericTextBox.TextBoxMode.IntNumber;
			this.NzCode.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzCode.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzCode.MS_Change_Border_Color_On_Enter = true;
			this.NzCode.MS_Change_Color_On_Enter = true;
			this.NzCode.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NzCode.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzCode.MS_Exit_By_Down = true;
			this.NzCode.MS_Exit_By_Enter = true;
			this.NzCode.MS_Exit_By_Up = true;
			this.NzCode.MS_Is_Negative = false;
			this.NzCode.MS_Last_Control = null;
			this.NzCode.MS_Next_Control = null;
			this.NzCode.Name = "NzCode";
			this.NzCode.Size = new System.Drawing.Size(86, 30);
			this.NzCode.TabIndex = 0;
			this.NzCode.TabStop = false;
			this.NzCode.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.NzCode.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("IRANSans(Small) Medium", 14F);
			this.label3.Location = new System.Drawing.Point(271, 141);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 24);
			this.label3.TabIndex = 170;
			this.label3.Text = "پلاک :";
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("IRANSans(Small) Medium", 14F);
			this.label4.Location = new System.Drawing.Point(271, 65);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 24);
			this.label4.TabIndex = 161;
			this.label4.Text = "راننده : ";
			// 
			// mS_TextBox1
			// 
			this.mS_TextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.mS_TextBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.mS_TextBox1.Location = new System.Drawing.Point(139, 138);
			this.mS_TextBox1.MaxLength = 200;
			this.mS_TextBox1.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.mS_TextBox1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.mS_TextBox1.MS_Change_Border_Color_On_Enter = true;
			this.mS_TextBox1.MS_Change_Color_On_Enter = true;
			this.mS_TextBox1.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.mS_TextBox1.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.mS_TextBox1.MS_Exit_By_Down = true;
			this.mS_TextBox1.MS_Exit_By_Enter = true;
			this.mS_TextBox1.MS_Exit_By_Up = true;
			this.mS_TextBox1.MS_Last_Control = null;
			this.mS_TextBox1.MS_Next_Control = null;
			this.mS_TextBox1.Name = "mS_TextBox1";
			this.mS_TextBox1.Size = new System.Drawing.Size(130, 30);
			this.mS_TextBox1.TabIndex = 3;
			// 
			// NzCustomer
			// 
			this.NzCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzCustomer.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
			this.NzCustomer.DropSize = new System.Drawing.Size(236, 29);
			this.NzCustomer.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NzCustomer.Location = new System.Drawing.Point(33, 63);
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
			this.NzCustomer.Size = new System.Drawing.Size(236, 29);
			this.NzCustomer.TabIndex = 1;
			this.NzCustomer.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			// 
			// FormCar
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(424, 314);
			this.Controls.Add(this.Panel_Foother);
			this.Controls.Add(this.Tab_Control_Main);
			this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormCar";
			this.Text = "تعریف ماشین و راننده";
			this.Panel_Foother.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).EndInit();
			this.Tab_Control_Main.ResumeLayout(false);
			this.uiTabPage12.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
			this.uiGroupBox1.ResumeLayout(false);
			this.uiGroupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private MS_Control.Controls.MS_Panel Panel_Foother;
		private MS_Control.Controls.MS_Button_GridX ms_Save;
		private MS_Control.Controls.MS_Button_GridX ms_Exit;
		private Janus.Windows.UI.Tab.UITab Tab_Control_Main;
		private Janus.Windows.UI.Tab.UITabPage uiTabPage12;
		private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
		private MS_Control.Controls.MS_ComboBox_Janus NzState;
		private System.Windows.Forms.Label label1;
		private MS_Control.Controls.MS_TextBox NzTitle;
		private System.Windows.Forms.Label label6;
		private Janus.Windows.UI.Tab.UITabPage uiTabPage14;
		private System.Windows.Forms.Label label2;
		private MS_Control.Controls.MS_NumericTextBox NzCode;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private MS_Control.Controls.MS_TextBox mS_TextBox1;
		private NZ.General.WinForms.Component.NzPeople NzCustomer;
	}
}