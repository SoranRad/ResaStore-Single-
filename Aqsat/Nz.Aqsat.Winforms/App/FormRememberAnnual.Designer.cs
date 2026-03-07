namespace Nz.Aqsat.Winforms.App
{
	partial class FormRememberAnnual
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
			this.Tab_Control_Main = new Janus.Windows.UI.Tab.UITab();
			this.uiTabPage12 = new Janus.Windows.UI.Tab.UITabPage();
			this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
			this.NsSampleText = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.NsVasileh = new MS_Control.Controls.MS_TextBox();
			this.NsKind = new Nz.Aqsat.Winforms.Component.NsKindAqsatCombo();
			this.NsSharh = new MS_Control.Controls.MS_TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.NzTarikh = new MS_Control.Tarikh.MS_Tarikh_TextBox();
			this.NzSerial = new MS_Control.Controls.MS_NumericTextBox();
			this.NzCustomer = new NZ.General.WinForms.Component.NzPeople();
			this.label3 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.NzCustomerLable = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Panel_Foother = new MS_Control.Controls.MS_Panel();
			this.ms_Save = new MS_Control.Controls.MS_Button_GridX();
			this.ms_Exit = new MS_Control.Controls.MS_Button_GridX();
			this.mS_Notify1 = new MS_Control.Controls.MS_Notify();
			((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).BeginInit();
			this.Tab_Control_Main.SuspendLayout();
			this.uiTabPage12.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
			this.uiGroupBox1.SuspendLayout();
			this.Panel_Foother.SuspendLayout();
			this.SuspendLayout();
			// 
			// Tab_Control_Main
			// 
			this.Tab_Control_Main.BackColor = System.Drawing.Color.Transparent;
			this.Tab_Control_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Tab_Control_Main.Font = new System.Drawing.Font("IRANSans(Small) Medium", 12F);
			this.Tab_Control_Main.Location = new System.Drawing.Point(0, 0);
			this.Tab_Control_Main.MultiLine = true;
			this.Tab_Control_Main.Name = "Tab_Control_Main";
			this.Tab_Control_Main.Office2007CustomColor = System.Drawing.Color.Transparent;
			this.Tab_Control_Main.ShowFocusRectangle = false;
			this.Tab_Control_Main.Size = new System.Drawing.Size(827, 187);
			this.Tab_Control_Main.TabIndex = 0;
			this.Tab_Control_Main.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage12});
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
			this.uiTabPage12.Size = new System.Drawing.Size(795, 185);
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
			this.uiGroupBox1.Controls.Add(this.NsSampleText);
			this.uiGroupBox1.Controls.Add(this.label4);
			this.uiGroupBox1.Controls.Add(this.NsVasileh);
			this.uiGroupBox1.Controls.Add(this.NsKind);
			this.uiGroupBox1.Controls.Add(this.NsSharh);
			this.uiGroupBox1.Controls.Add(this.label19);
			this.uiGroupBox1.Controls.Add(this.NzTarikh);
			this.uiGroupBox1.Controls.Add(this.NzSerial);
			this.uiGroupBox1.Controls.Add(this.NzCustomer);
			this.uiGroupBox1.Controls.Add(this.label3);
			this.uiGroupBox1.Controls.Add(this.label8);
			this.uiGroupBox1.Controls.Add(this.label1);
			this.uiGroupBox1.Controls.Add(this.NzCustomerLable);
			this.uiGroupBox1.Controls.Add(this.label2);
			this.uiGroupBox1.Location = new System.Drawing.Point(6, 2);
			this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(2);
			this.uiGroupBox1.Name = "uiGroupBox1";
			this.uiGroupBox1.Size = new System.Drawing.Size(782, 179);
			this.uiGroupBox1.TabIndex = 0;
			// 
			// NsSampleText
			// 
			this.NsSampleText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsSampleText.BackColor = System.Drawing.Color.Transparent;
			this.NsSampleText.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NsSampleText.ForeColor = System.Drawing.Color.Green;
			this.NsSampleText.Location = new System.Drawing.Point(6, 140);
			this.NsSampleText.Name = "NsSampleText";
			this.NsSampleText.Size = new System.Drawing.Size(703, 27);
			this.NsSampleText.TabIndex = 780;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.label4.Location = new System.Drawing.Point(708, 144);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(70, 23);
			this.label4.TabIndex = 779;
			this.label4.Text = "نمونه متن :";
			// 
			// NsVasileh
			// 
			this.NsVasileh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsVasileh.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsVasileh.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F);
			this.NsVasileh.Location = new System.Drawing.Point(251, 48);
			this.NsVasileh.MaxLength = 200;
			this.NsVasileh.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsVasileh.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsVasileh.MS_Change_Border_Color_On_Enter = true;
			this.NsVasileh.MS_Change_Color_On_Enter = true;
			this.NsVasileh.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsVasileh.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsVasileh.MS_Exit_By_Down = true;
			this.NsVasileh.MS_Exit_By_Enter = true;
			this.NsVasileh.MS_Exit_By_Up = true;
			this.NsVasileh.MS_Last_Control = null;
			this.NsVasileh.MS_Next_Control = null;
			this.NsVasileh.Name = "NsVasileh";
			this.NsVasileh.Size = new System.Drawing.Size(187, 29);
			this.NsVasileh.TabIndex = 2;
			this.NsVasileh.TextChanged += new System.EventHandler(this.NsVasileh_TextChanged);
			// 
			// NsKind
			// 
			this.NsKind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NsKind.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
			this.NsKind.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsKind.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F);
			this.NsKind.Location = new System.Drawing.Point(84, 48);
			this.NsKind.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.NsKind.MaxDropDownItems = 15;
			this.NsKind.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsKind.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsKind.MS_Change_Border_Color_On_Enter = true;
			this.NsKind.MS_Change_Color_On_Enter = true;
			this.NsKind.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsKind.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsKind.MS_Exit_By_Down = false;
			this.NsKind.MS_Exit_By_Enter = true;
			this.NsKind.MS_Exit_By_Up = false;
			this.NsKind.MS_Last_Control = null;
			this.NsKind.MS_Next_Control = null;
			this.NsKind.Name = "NsKind";
			this.NsKind.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.NsKind.Size = new System.Drawing.Size(165, 29);
			this.NsKind.TabIndex = 3;
			this.NsKind.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.NsKind.SelectedValueChanged += new System.EventHandler(this.NsKind_SelectedValueChanged);
			// 
			// NsSharh
			// 
			this.NsSharh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.NsSharh.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NsSharh.Location = new System.Drawing.Point(5, 101);
			this.NsSharh.MaxLength = 200;
			this.NsSharh.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NsSharh.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NsSharh.MS_Change_Border_Color_On_Enter = true;
			this.NsSharh.MS_Change_Color_On_Enter = true;
			this.NsSharh.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NsSharh.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NsSharh.MS_Exit_By_Down = true;
			this.NsSharh.MS_Exit_By_Enter = true;
			this.NsSharh.MS_Exit_By_Up = true;
			this.NsSharh.MS_Last_Control = null;
			this.NsSharh.MS_Next_Control = null;
			this.NsSharh.Name = "NsSharh";
			this.NsSharh.Size = new System.Drawing.Size(700, 27);
			this.NsSharh.TabIndex = 5;
			this.NsSharh.TextChanged += new System.EventHandler(this.NsSharh_TextChanged);
			// 
			// label19
			// 
			this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label19.AutoSize = true;
			this.label19.BackColor = System.Drawing.Color.Transparent;
			this.label19.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.label19.Location = new System.Drawing.Point(708, 103);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(68, 23);
			this.label19.TabIndex = 777;
			this.label19.Text = "توضیحات :";
			// 
			// NzTarikh
			// 
			this.NzTarikh.AllowInternalTab = false;
			this.NzTarikh.AllowResizeDropDown = false;
			this.NzTarikh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzTarikh.AutoHeight = false;
			this.NzTarikh.BackColor = System.Drawing.Color.White;
			this.NzTarikh.ControlSize = new System.Drawing.Size(0, 0);
			this.NzTarikh.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.NzTarikh.DropSize = new System.Drawing.Size(0, 0);
			this.NzTarikh.Font = new System.Drawing.Font("IRANSans(Small)", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NzTarikh.Location = new System.Drawing.Point(440, 48);
			this.NzTarikh.MinimumSize = new System.Drawing.Size(107, 29);
			this.NzTarikh.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzTarikh.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzTarikh.MS_Change_Border_Color_On_Enter = true;
			this.NzTarikh.MS_Change_Color_On_Enter = true;
			this.NzTarikh.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NzTarikh.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzTarikh.MS_Exit_By_Down = true;
			this.NzTarikh.MS_Exit_By_Enter = true;
			this.NzTarikh.MS_Exit_By_Up = true;
			this.NzTarikh.MS_Last_Control = null;
			this.NzTarikh.MS_Next_Control = null;
			this.NzTarikh.MS_Separation = '/';
			this.NzTarikh.MS_Tarikh = null;
			this.NzTarikh.Name = "NzTarikh";
			this.NzTarikh.ReadOnly = false;
			this.NzTarikh.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.NzTarikh.Size = new System.Drawing.Size(111, 29);
			this.NzTarikh.TabIndex = 1;
			this.NzTarikh.Text = "//";
			// 
			// NzSerial
			// 
			this.NzSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzSerial.ButtonText = "000";
			this.NzSerial.Cursor = System.Windows.Forms.Cursors.Hand;
			this.NzSerial.DigitGroup = false;
			this.NzSerial.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.NzSerial.Location = new System.Drawing.Point(4, 48);
			this.NzSerial.MaxLength = 0;
			this.NzSerial.Mode = MS_Control.Controls.MS_NumericTextBox.TextBoxMode.IntNumber;
			this.NzSerial.MS_BorderColor = System.Drawing.Color.SteelBlue;
			this.NzSerial.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.NzSerial.MS_Change_Border_Color_On_Enter = true;
			this.NzSerial.MS_Change_Color_On_Enter = true;
			this.NzSerial.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.NzSerial.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.NzSerial.MS_Exit_By_Down = true;
			this.NzSerial.MS_Exit_By_Enter = true;
			this.NzSerial.MS_Exit_By_Up = true;
			this.NzSerial.MS_Is_Negative = false;
			this.NzSerial.MS_Last_Control = null;
			this.NzSerial.MS_Next_Control = null;
			this.NzSerial.Name = "NzSerial";
			this.NzSerial.Size = new System.Drawing.Size(78, 29);
			this.NzSerial.TabIndex = 4;
			this.NzSerial.TabStop = false;
			this.NzSerial.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
			this.NzSerial.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			this.NzSerial.TextChanged += new System.EventHandler(this.NzSerial_TextChanged);
			// 
			// NzCustomer
			// 
			this.NzCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzCustomer.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
			this.NzCustomer.DropSize = new System.Drawing.Size(224, 29);
			this.NzCustomer.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NzCustomer.Location = new System.Drawing.Point(553, 48);
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
			this.NzCustomer.Size = new System.Drawing.Size(224, 29);
			this.NzCustomer.TabIndex = 0;
			this.NzCustomer.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
			this.NzCustomer.MS_On_Row_Selected += new System.EventHandler<MS_Control.TSDD.On_Selected>(this.NzCustomer_MS_On_Row_Selected);
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.label3.Location = new System.Drawing.Point(325, 25);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 23);
			this.label3.TabIndex = 778;
			this.label3.Text = "نوع وسیله";
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.label8.Location = new System.Drawing.Point(460, 25);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(73, 23);
			this.label8.TabIndex = 772;
			this.label8.Text = "تاریخ تمدید";
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.label1.Location = new System.Drawing.Point(22, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 23);
			this.label1.TabIndex = 770;
			this.label1.Text = "سریال";
			// 
			// NzCustomerLable
			// 
			this.NzCustomerLable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NzCustomerLable.AutoSize = true;
			this.NzCustomerLable.BackColor = System.Drawing.Color.Transparent;
			this.NzCustomerLable.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.NzCustomerLable.Location = new System.Drawing.Point(635, 25);
			this.NzCustomerLable.Name = "NzCustomerLable";
			this.NzCustomerLable.Size = new System.Drawing.Size(49, 23);
			this.NzCustomerLable.TabIndex = 771;
			this.NzCustomerLable.Text = "مشتری";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
			this.label2.Location = new System.Drawing.Point(137, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 23);
			this.label2.TabIndex = 776;
			this.label2.Text = "نوع قسط";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Panel_Foother
			// 
			this.Panel_Foother.Controls.Add(this.ms_Save);
			this.Panel_Foother.Controls.Add(this.ms_Exit);
			this.Panel_Foother.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.Panel_Foother.Location = new System.Drawing.Point(0, 187);
			this.Panel_Foother.MS_BorderColor = System.Drawing.Color.DarkGray;
			this.Panel_Foother.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
			this.Panel_Foother.MS_Color_End = System.Drawing.Color.Gainsboro;
			this.Panel_Foother.MS_Color_Start = System.Drawing.Color.WhiteSmoke;
			this.Panel_Foother.Name = "Panel_Foother";
			this.Panel_Foother.Size = new System.Drawing.Size(827, 47);
			this.Panel_Foother.TabIndex = 1;
			// 
			// ms_Save
			// 
			this.ms_Save.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ms_Save.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ms_Save.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.ms_Save.Image = global::MS_Resource.GlobalResources._ms_Save;
			this.ms_Save.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
			this.ms_Save.Location = new System.Drawing.Point(6, 8);
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
			this.ms_Save.Click += new System.EventHandler(this.ms_Save_Click);
			// 
			// ms_Exit
			// 
			this.ms_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
			this.ms_Exit.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.ms_Exit.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.ms_Exit.Image = global::MS_Resource.GlobalResources._ms_Back;
			this.ms_Exit.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
			this.ms_Exit.Location = new System.Drawing.Point(119, 8);
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
			this.ms_Exit.Size = new System.Drawing.Size(129, 30);
			this.ms_Exit.TabIndex = 1;
			this.ms_Exit.Text = "انــصــراف   [Esc]";
			this.ms_Exit.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
			this.ms_Exit.UseThemes = false;
			this.ms_Exit.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
			this.ms_Exit.WordWrap = false;
			this.ms_Exit.Click += new System.EventHandler(this.ms_Exit_Click);
			// 
			// FormRememberAnnual
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(827, 234);
			this.Controls.Add(this.Tab_Control_Main);
			this.Controls.Add(this.Panel_Foother);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormRememberAnnual";
			this.ShowInTaskbar = false;
			this.Text = "ثبت یادآوری سالانه";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).EndInit();
			this.Tab_Control_Main.ResumeLayout(false);
			this.uiTabPage12.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
			this.uiGroupBox1.ResumeLayout(false);
			this.uiGroupBox1.PerformLayout();
			this.Panel_Foother.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Janus.Windows.UI.Tab.UITab Tab_Control_Main;
		private Janus.Windows.UI.Tab.UITabPage uiTabPage12;
		private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
		private Component.NsKindAqsatCombo NsKind;
		private MS_Control.Controls.MS_TextBox NsSharh;
		private System.Windows.Forms.Label label19;
		private MS_Control.Tarikh.MS_Tarikh_TextBox NzTarikh;
		private System.Windows.Forms.Label label8;
		private MS_Control.Controls.MS_NumericTextBox NzSerial;
		private System.Windows.Forms.Label label1;
		private NZ.General.WinForms.Component.NzPeople NzCustomer;
		private System.Windows.Forms.Label NzCustomerLable;
		private System.Windows.Forms.Label label2;
		private MS_Control.Controls.MS_TextBox NsVasileh;
		private System.Windows.Forms.Label label3;
		private MS_Control.Controls.MS_Panel Panel_Foother;
		private MS_Control.Controls.MS_Button_GridX ms_Save;
		private MS_Control.Controls.MS_Button_GridX ms_Exit;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label NsSampleText;
		private MS_Control.Controls.MS_Notify mS_Notify1;
	}
}