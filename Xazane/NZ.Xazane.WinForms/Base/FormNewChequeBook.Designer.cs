namespace NZ.Xazane.WinForms.Base
{
    partial class FormNewChequeBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNewChequeBook));
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem1 = new Janus.Windows.EditControls.UIComboBoxItem();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem2 = new Janus.Windows.EditControls.UIComboBoxItem();
            this.Panel_Foother = new MS_Control.Controls.MS_Panel();
            this.ms_Save = new MS_Control.Controls.MS_Button_GridX();
            this.ms_Exit = new MS_Control.Controls.MS_Button_GridX();
            this.Tab_Control_Main = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage12 = new Janus.Windows.UI.Tab.UITabPage();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NzComboAccount = new NZ.Xazane.WinForms.Component.NzAccounts();
            this.NzTarikhTahvil = new MS_Control.Tarikh.MS_Tarikh_TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NzStartSerial = new MS_Control.Controls.MS_NumericTextBox();
            this.NzTedadBarge = new MS_Control.Controls.MS_NumericTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NzCode = new MS_Control.Controls.MS_NumericTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NzTozihat = new MS_Control.Controls.MS_TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NzState = new MS_Control.Controls.MS_ComboBox_Janus();
            this.label9 = new System.Windows.Forms.Label();
            this.uiTabPage14 = new Janus.Windows.UI.Tab.UITabPage();
            this.mS_Notify1 = new MS_Control.Controls.MS_Notify();
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
            this.Panel_Foother.Location = new System.Drawing.Point(0, 301);
            this.Panel_Foother.MS_BorderColor = System.Drawing.Color.DarkGray;
            this.Panel_Foother.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.Panel_Foother.MS_Color_End = System.Drawing.Color.Gainsboro;
            this.Panel_Foother.MS_Color_Start = System.Drawing.Color.WhiteSmoke;
            this.Panel_Foother.Name = "Panel_Foother";
            this.Panel_Foother.Size = new System.Drawing.Size(383, 48);
            this.Panel_Foother.TabIndex = 7;
            // 
            // ms_Save
            // 
            this.ms_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_Save.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_Save.Image = ((System.Drawing.Image)(resources.GetObject("ms_Save.Image")));
            this.ms_Save.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.ms_Save.Location = new System.Drawing.Point(150, 9);
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
            this.ms_Exit.Image = ((System.Drawing.Image)(resources.GetObject("ms_Exit.Image")));
            this.ms_Exit.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.ms_Exit.Location = new System.Drawing.Point(12, 9);
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
            this.Tab_Control_Main.Location = new System.Drawing.Point(0, 0);
            this.Tab_Control_Main.MultiLine = true;
            this.Tab_Control_Main.Name = "Tab_Control_Main";
            this.Tab_Control_Main.Office2007CustomColor = System.Drawing.Color.Transparent;
            this.Tab_Control_Main.ShowFocusRectangle = false;
            this.Tab_Control_Main.Size = new System.Drawing.Size(413, 302);
            this.Tab_Control_Main.TabIndex = 0;
            this.Tab_Control_Main.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage12,
            this.uiTabPage14});
            this.Tab_Control_Main.TabsStateStyles.DisabledFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Tab_Control_Main.TabsStateStyles.DisabledFormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Tab_Control_Main.TabsStateStyles.FormatStyle.BackColor = System.Drawing.Color.PowderBlue;
            this.Tab_Control_Main.TabsStateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.Gold;
            this.Tab_Control_Main.TabsStateStyles.SelectedFormatStyle.Font = new System.Drawing.Font("Tahoma", 9.5F, System.Drawing.FontStyle.Bold);
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
            this.uiTabPage12.Size = new System.Drawing.Size(381, 300);
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
            this.uiGroupBox1.Controls.Add(this.label1);
            this.uiGroupBox1.Controls.Add(this.NzComboAccount);
            this.uiGroupBox1.Controls.Add(this.NzTarikhTahvil);
            this.uiGroupBox1.Controls.Add(this.label5);
            this.uiGroupBox1.Controls.Add(this.NzStartSerial);
            this.uiGroupBox1.Controls.Add(this.NzTedadBarge);
            this.uiGroupBox1.Controls.Add(this.label4);
            this.uiGroupBox1.Controls.Add(this.NzCode);
            this.uiGroupBox1.Controls.Add(this.label3);
            this.uiGroupBox1.Controls.Add(this.NzTozihat);
            this.uiGroupBox1.Controls.Add(this.label7);
            this.uiGroupBox1.Controls.Add(this.label6);
            this.uiGroupBox1.Controls.Add(this.NzState);
            this.uiGroupBox1.Controls.Add(this.label9);
            this.uiGroupBox1.Location = new System.Drawing.Point(12, 7);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(359, 285);
            this.uiGroupBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F);
            this.label1.Location = new System.Drawing.Point(266, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 823;
            this.label1.Text = "حساب بانکی  :";
            // 
            // NzComboAccount
            // 
            this.NzComboAccount.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
            this.NzComboAccount.DropSize = new System.Drawing.Size(240, 29);
            this.NzComboAccount.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
            this.NzComboAccount.Location = new System.Drawing.Point(24, 52);
            this.NzComboAccount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NzComboAccount.MS_Auto_Popup = false;
            this.NzComboAccount.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzComboAccount.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzComboAccount.MS_CaptureFocus = false;
            this.NzComboAccount.MS_Change_Border_Color_On_Enter = false;
            this.NzComboAccount.MS_Change_Color_On_Enter = false;
            this.NzComboAccount.MS_Drop_Direction = MS_Control.TSDD.KindShow.Right;
            this.NzComboAccount.MS_DropDownSizeMode = MS_Control.TSDD.SizeMode.Control_Size;
            this.NzComboAccount.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.NzComboAccount.MS_Enter_Color = System.Drawing.Color.Empty;
            this.NzComboAccount.MS_Exit_By_Down = false;
            this.NzComboAccount.MS_Exit_By_Enter = false;
            this.NzComboAccount.MS_Exit_By_Up = false;
            this.NzComboAccount.MS_Last_Control = null;
            this.NzComboAccount.MS_Next_Control = null;
            this.NzComboAccount.Name = "NzComboAccount";
            this.NzComboAccount.Office2007CustomColor = System.Drawing.Color.SkyBlue;
            this.NzComboAccount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzComboAccount.Size = new System.Drawing.Size(240, 29);
            this.NzComboAccount.TabIndex = 1;
            this.NzComboAccount.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // NzTarikhTahvil
            // 
            this.NzTarikhTahvil.AllowInternalTab = false;
            this.NzTarikhTahvil.AllowResizeDropDown = false;
            this.NzTarikhTahvil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzTarikhTahvil.AutoHeight = false;
            this.NzTarikhTahvil.BackColor = System.Drawing.Color.White;
            this.NzTarikhTahvil.ControlSize = new System.Drawing.Size(0, 0);
            this.NzTarikhTahvil.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NzTarikhTahvil.DropSize = new System.Drawing.Size(0, 0);
            this.NzTarikhTahvil.Location = new System.Drawing.Point(153, 83);
            this.NzTarikhTahvil.MinimumSize = new System.Drawing.Size(99, 27);
            this.NzTarikhTahvil.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzTarikhTahvil.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzTarikhTahvil.MS_Change_Border_Color_On_Enter = true;
            this.NzTarikhTahvil.MS_Change_Color_On_Enter = true;
            this.NzTarikhTahvil.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.NzTarikhTahvil.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NzTarikhTahvil.MS_Exit_By_Down = true;
            this.NzTarikhTahvil.MS_Exit_By_Enter = true;
            this.NzTarikhTahvil.MS_Exit_By_Up = true;
            this.NzTarikhTahvil.MS_Last_Control = null;
            this.NzTarikhTahvil.MS_Next_Control = null;
            this.NzTarikhTahvil.MS_Separation = '/';
            this.NzTarikhTahvil.MS_Tarikh = null;
            this.NzTarikhTahvil.Name = "NzTarikhTahvil";
            this.NzTarikhTahvil.ReadOnly = false;
            this.NzTarikhTahvil.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NzTarikhTahvil.Size = new System.Drawing.Size(111, 27);
            this.NzTarikhTahvil.TabIndex = 2;
            this.NzTarikhTahvil.Text = "//";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F);
            this.label5.Location = new System.Drawing.Point(266, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 23);
            this.label5.TabIndex = 820;
            this.label5.Text = "تاریخ تحویل :";
            // 
            // NzStartSerial
            // 
            this.NzStartSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzStartSerial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzStartSerial.DigitGroup = false;
            this.NzStartSerial.Enabled = false;
            this.NzStartSerial.Location = new System.Drawing.Point(109, 143);
            this.NzStartSerial.Mode = MS_Control.Controls.MS_NumericTextBox.TextBoxMode.IntNumber;
            this.NzStartSerial.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzStartSerial.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzStartSerial.MS_Change_Border_Color_On_Enter = true;
            this.NzStartSerial.MS_Change_Color_On_Enter = true;
            this.NzStartSerial.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NzStartSerial.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzStartSerial.MS_Exit_By_Down = true;
            this.NzStartSerial.MS_Exit_By_Enter = true;
            this.NzStartSerial.MS_Exit_By_Up = true;
            this.NzStartSerial.MS_Is_Negative = false;
            this.NzStartSerial.MS_Last_Control = null;
            this.NzStartSerial.MS_Next_Control = null;
            this.NzStartSerial.Name = "NzStartSerial";
            this.NzStartSerial.ReadOnly = true;
            this.NzStartSerial.Size = new System.Drawing.Size(155, 29);
            this.NzStartSerial.TabIndex = 4;
            this.NzStartSerial.TabStop = false;
            this.NzStartSerial.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.NzStartSerial.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // NzTedadBarge
            // 
            this.NzTedadBarge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzTedadBarge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzTedadBarge.DigitGroup = false;
            this.NzTedadBarge.Enabled = false;
            this.NzTedadBarge.Location = new System.Drawing.Point(206, 112);
            this.NzTedadBarge.Mode = MS_Control.Controls.MS_NumericTextBox.TextBoxMode.IntNumber;
            this.NzTedadBarge.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzTedadBarge.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzTedadBarge.MS_Change_Border_Color_On_Enter = true;
            this.NzTedadBarge.MS_Change_Color_On_Enter = true;
            this.NzTedadBarge.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NzTedadBarge.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzTedadBarge.MS_Exit_By_Down = true;
            this.NzTedadBarge.MS_Exit_By_Enter = true;
            this.NzTedadBarge.MS_Exit_By_Up = true;
            this.NzTedadBarge.MS_Is_Negative = false;
            this.NzTedadBarge.MS_Last_Control = null;
            this.NzTedadBarge.MS_Next_Control = null;
            this.NzTedadBarge.Name = "NzTedadBarge";
            this.NzTedadBarge.ReadOnly = true;
            this.NzTedadBarge.Size = new System.Drawing.Size(58, 29);
            this.NzTedadBarge.TabIndex = 3;
            this.NzTedadBarge.TabStop = false;
            this.NzTedadBarge.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.NzTedadBarge.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(265, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 23);
            this.label4.TabIndex = 162;
            this.label4.Text = "سریال شروع :";
            // 
            // NzCode
            // 
            this.NzCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzCode.DigitGroup = false;
            this.NzCode.Enabled = false;
            this.NzCode.Location = new System.Drawing.Point(183, 21);
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
            this.NzCode.Size = new System.Drawing.Size(81, 29);
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
            this.label3.Location = new System.Drawing.Point(265, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 23);
            this.label3.TabIndex = 162;
            this.label3.Text = "تعداد برگه :";
            // 
            // NzTozihat
            // 
            this.NzTozihat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzTozihat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzTozihat.Location = new System.Drawing.Point(24, 205);
            this.NzTozihat.MaxLength = 200;
            this.NzTozihat.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzTozihat.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzTozihat.MS_Change_Border_Color_On_Enter = true;
            this.NzTozihat.MS_Change_Color_On_Enter = true;
            this.NzTozihat.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NzTozihat.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzTozihat.MS_Exit_By_Down = true;
            this.NzTozihat.MS_Exit_By_Enter = true;
            this.NzTozihat.MS_Exit_By_Up = true;
            this.NzTozihat.MS_Last_Control = null;
            this.NzTozihat.MS_Next_Control = null;
            this.NzTozihat.Name = "NzTozihat";
            this.NzTozihat.Size = new System.Drawing.Size(240, 29);
            this.NzTozihat.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(265, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 23);
            this.label7.TabIndex = 162;
            this.label7.Text = "کــد :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(265, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 23);
            this.label6.TabIndex = 161;
            this.label6.Text = "توضیحات :";
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
            this.NzState.Location = new System.Drawing.Point(124, 174);
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
            this.NzState.Size = new System.Drawing.Size(140, 29);
            this.NzState.TabIndex = 5;
            this.NzState.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(265, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 23);
            this.label9.TabIndex = 165;
            this.label9.Text = "وضـعیت ورود :";
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
            this.uiTabPage14.Size = new System.Drawing.Size(381, 300);
            this.uiTabPage14.TabStop = true;
            this.uiTabPage14.Text = "پرسش و پاسخ";
            // 
            // FormNewChequeBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 349);
            this.Controls.Add(this.Panel_Foother);
            this.Controls.Add(this.Tab_Control_Main);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNewChequeBook";
            this.Text = "تعریف دسته چک";
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
        private System.Windows.Forms.Label label5;
        private MS_Control.Controls.MS_NumericTextBox NzCode;
        private MS_Control.Controls.MS_TextBox NzTozihat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private MS_Control.Controls.MS_ComboBox_Janus NzState;
        private System.Windows.Forms.Label label9;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage14;
        private MS_Control.Tarikh.MS_Tarikh_TextBox NzTarikhTahvil;
        private MS_Control.Controls.MS_NumericTextBox NzStartSerial;
        private MS_Control.Controls.MS_NumericTextBox NzTedadBarge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Component.NzAccounts NzComboAccount;
        private System.Windows.Forms.Label label1;
        private MS_Control.Controls.MS_Notify mS_Notify1;
    }
}