namespace NZ.Xazane.WinForms.App
{
    partial class FormDeficit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDeficit));
            this.Panel_Foother = new MS_Control.Controls.MS_Panel();
            this.ms_Save = new MS_Control.Controls.MS_Button_GridX();
            this.ms_Exit = new MS_Control.Controls.MS_Button_GridX();
            this.Tab_Control_Main = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage12 = new Janus.Windows.UI.Tab.UITabPage();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.LineSeperator = new MS_Control.Controls.MS_Text_Simple();
            this.NzVaziat = new NZ.General.WinForms.Component.NzRemainCustomer();
            this.label7 = new System.Windows.Forms.Label();
            this.NzComboShaxs = new NZ.General.WinForms.Component.NzPeople();
            this.NzComboDeficit = new NZ.Xazane.WinForms.Component.NzAccounts();
            this.NzBabat = new MS_Control.Controls.MS_TextBox();
            this.NzSerial = new MS_Control.Controls.MS_NumericTextBox();
            this.NzMab = new MS_Control.Controls.MS_NumericTextBox();
            this.NzDate = new MS_Control.Tarikh.MS_Tarikh_TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNoh = new System.Windows.Forms.Label();
            this.uiTabPage14 = new Janus.Windows.UI.Tab.UITabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mS_Notify1 = new MS_Control.Controls.MS_Notify();
            this.Panel_Foother.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).BeginInit();
            this.Tab_Control_Main.SuspendLayout();
            this.uiTabPage12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.uiTabPage14.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Foother
            // 
            this.Panel_Foother.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Foother.Controls.Add(this.ms_Save);
            this.Panel_Foother.Controls.Add(this.ms_Exit);
            this.Panel_Foother.Location = new System.Drawing.Point(1, 292);
            this.Panel_Foother.MS_BorderColor = System.Drawing.Color.DarkGray;
            this.Panel_Foother.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.Panel_Foother.MS_Color_End = System.Drawing.Color.Gainsboro;
            this.Panel_Foother.MS_Color_Start = System.Drawing.Color.WhiteSmoke;
            this.Panel_Foother.Name = "Panel_Foother";
            this.Panel_Foother.Size = new System.Drawing.Size(499, 57);
            this.Panel_Foother.TabIndex = 3;
            this.Panel_Foother.TabStop = true;
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
            this.ms_Exit.Click += new System.EventHandler(this.ms_Exit_Click);
            // 
            // Tab_Control_Main
            // 
            this.Tab_Control_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab_Control_Main.BackColor = System.Drawing.Color.Transparent;
            this.Tab_Control_Main.Location = new System.Drawing.Point(1, 1);
            this.Tab_Control_Main.MultiLine = true;
            this.Tab_Control_Main.Name = "Tab_Control_Main";
            this.Tab_Control_Main.Office2007CustomColor = System.Drawing.Color.Transparent;
            this.Tab_Control_Main.ShowFocusRectangle = false;
            this.Tab_Control_Main.Size = new System.Drawing.Size(529, 292);
            this.Tab_Control_Main.TabIndex = 2;
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
            this.uiTabPage12.Size = new System.Drawing.Size(497, 290);
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
            this.uiGroupBox1.Controls.Add(this.LineSeperator);
            this.uiGroupBox1.Controls.Add(this.NzVaziat);
            this.uiGroupBox1.Controls.Add(this.label7);
            this.uiGroupBox1.Controls.Add(this.NzComboShaxs);
            this.uiGroupBox1.Controls.Add(this.NzComboDeficit);
            this.uiGroupBox1.Controls.Add(this.NzBabat);
            this.uiGroupBox1.Controls.Add(this.NzSerial);
            this.uiGroupBox1.Controls.Add(this.NzMab);
            this.uiGroupBox1.Controls.Add(this.NzDate);
            this.uiGroupBox1.Controls.Add(this.label11);
            this.uiGroupBox1.Controls.Add(this.label10);
            this.uiGroupBox1.Controls.Add(this.label5);
            this.uiGroupBox1.Controls.Add(this.label6);
            this.uiGroupBox1.Controls.Add(this.label4);
            this.uiGroupBox1.Controls.Add(this.lblNoh);
            this.uiGroupBox1.Location = new System.Drawing.Point(8, 7);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(478, 276);
            this.uiGroupBox1.TabIndex = 0;
            // 
            // LineSeperator
            // 
            this.LineSeperator.BackColor = System.Drawing.Color.Maroon;
            this.LineSeperator.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LineSeperator.Location = new System.Drawing.Point(0, 83);
            this.LineSeperator.MS_BorderColor = System.Drawing.Color.Silver;
            this.LineSeperator.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.LineSeperator.MS_Change_Border_Color_On_Enter = false;
            this.LineSeperator.MS_Change_Color_On_Enter = false;
            this.LineSeperator.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.LineSeperator.MS_Enter_Color = System.Drawing.Color.Empty;
            this.LineSeperator.MS_Exit_By_Down = false;
            this.LineSeperator.MS_Exit_By_Enter = false;
            this.LineSeperator.MS_Exit_By_Up = false;
            this.LineSeperator.MS_Last_Control = null;
            this.LineSeperator.MS_Next_Control = null;
            this.LineSeperator.Multiline = true;
            this.LineSeperator.Name = "LineSeperator";
            this.LineSeperator.ReadOnly = true;
            this.LineSeperator.Size = new System.Drawing.Size(496, 4);
            this.LineSeperator.TabIndex = 834;
            this.LineSeperator.TabStop = false;
            // 
            // NzVaziat
            // 
            this.NzVaziat.Font = new System.Drawing.Font("IRANSans(Small)", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NzVaziat.Location = new System.Drawing.Point(156, 44);
            this.NzVaziat.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzVaziat.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzVaziat.MS_Color_End = System.Drawing.Color.Empty;
            this.NzVaziat.MS_Color_Start = System.Drawing.Color.Empty;
            this.NzVaziat.Name = "NzVaziat";
            this.NzVaziat.Size = new System.Drawing.Size(191, 30);
            this.NzVaziat.TabIndex = 833;
            this.NzVaziat.Text = "0";
            this.NzVaziat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(353, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 23);
            this.label7.TabIndex = 831;
            this.label7.Text = "وضعیت :";
            // 
            // NzComboShaxs
            // 
            this.NzComboShaxs.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat;
            this.NzComboShaxs.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
            this.NzComboShaxs.DropSize = new System.Drawing.Size(275, 29);
            this.NzComboShaxs.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
            this.NzComboShaxs.Location = new System.Drawing.Point(73, 13);
            this.NzComboShaxs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NzComboShaxs.MS_Auto_Popup = false;
            this.NzComboShaxs.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzComboShaxs.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzComboShaxs.MS_CaptureFocus = false;
            this.NzComboShaxs.MS_Change_Border_Color_On_Enter = true;
            this.NzComboShaxs.MS_Change_Color_On_Enter = true;
            this.NzComboShaxs.MS_Drop_Direction = MS_Control.TSDD.KindShow.Right;
            this.NzComboShaxs.MS_DropDownSizeMode = MS_Control.TSDD.SizeMode.Control_Size;
            this.NzComboShaxs.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.NzComboShaxs.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzComboShaxs.MS_Exit_By_Down = true;
            this.NzComboShaxs.MS_Exit_By_Enter = true;
            this.NzComboShaxs.MS_Exit_By_Up = true;
            this.NzComboShaxs.MS_Last_Control = null;
            this.NzComboShaxs.MS_Next_Control = null;
            this.NzComboShaxs.Name = "NzComboShaxs";
            this.NzComboShaxs.Office2007CustomColor = System.Drawing.Color.SkyBlue;
            this.NzComboShaxs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzComboShaxs.Size = new System.Drawing.Size(275, 29);
            this.NzComboShaxs.TabIndex = 6;
            this.NzComboShaxs.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // NzComboDeficit
            // 
            this.NzComboDeficit.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat;
            this.NzComboDeficit.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
            this.NzComboDeficit.DropSize = new System.Drawing.Size(275, 29);
            this.NzComboDeficit.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
            this.NzComboDeficit.Location = new System.Drawing.Point(73, 94);
            this.NzComboDeficit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NzComboDeficit.MS_Auto_Popup = false;
            this.NzComboDeficit.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzComboDeficit.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzComboDeficit.MS_CaptureFocus = false;
            this.NzComboDeficit.MS_Change_Border_Color_On_Enter = true;
            this.NzComboDeficit.MS_Change_Color_On_Enter = true;
            this.NzComboDeficit.MS_Drop_Direction = MS_Control.TSDD.KindShow.Right;
            this.NzComboDeficit.MS_DropDownSizeMode = MS_Control.TSDD.SizeMode.Control_Size;
            this.NzComboDeficit.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.NzComboDeficit.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzComboDeficit.MS_Exit_By_Down = true;
            this.NzComboDeficit.MS_Exit_By_Enter = true;
            this.NzComboDeficit.MS_Exit_By_Up = true;
            this.NzComboDeficit.MS_Last_Control = null;
            this.NzComboDeficit.MS_Next_Control = null;
            this.NzComboDeficit.Name = "NzComboDeficit";
            this.NzComboDeficit.Office2007CustomColor = System.Drawing.Color.SkyBlue;
            this.NzComboDeficit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzComboDeficit.Size = new System.Drawing.Size(275, 29);
            this.NzComboDeficit.TabIndex = 6;
            this.NzComboDeficit.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // NzBabat
            // 
            this.NzBabat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzBabat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzBabat.Location = new System.Drawing.Point(3, 216);
            this.NzBabat.MaxLength = 200;
            this.NzBabat.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzBabat.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzBabat.MS_Change_Border_Color_On_Enter = true;
            this.NzBabat.MS_Change_Color_On_Enter = true;
            this.NzBabat.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.NzBabat.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzBabat.MS_Exit_By_Down = true;
            this.NzBabat.MS_Exit_By_Enter = true;
            this.NzBabat.MS_Exit_By_Up = true;
            this.NzBabat.MS_Last_Control = null;
            this.NzBabat.MS_Next_Control = this.ms_Save;
            this.NzBabat.Name = "NzBabat";
            this.NzBabat.Size = new System.Drawing.Size(345, 29);
            this.NzBabat.TabIndex = 10;
            // 
            // NzSerial
            // 
            this.NzSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzSerial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzSerial.DigitGroup = false;
            this.NzSerial.Location = new System.Drawing.Point(187, 154);
            this.NzSerial.Mode = MS_Control.Controls.MS_NumericTextBox.TextBoxMode.IntNumber;
            this.NzSerial.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzSerial.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzSerial.MS_Change_Border_Color_On_Enter = true;
            this.NzSerial.MS_Change_Color_On_Enter = true;
            this.NzSerial.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.NzSerial.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzSerial.MS_Exit_By_Down = true;
            this.NzSerial.MS_Exit_By_Enter = true;
            this.NzSerial.MS_Exit_By_Up = true;
            this.NzSerial.MS_Is_Negative = false;
            this.NzSerial.MS_Last_Control = null;
            this.NzSerial.MS_Next_Control = null;
            this.NzSerial.Name = "NzSerial";
            this.NzSerial.Size = new System.Drawing.Size(161, 29);
            this.NzSerial.TabIndex = 8;
            this.NzSerial.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.NzSerial.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // NzMab
            // 
            this.NzMab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzMab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzMab.Location = new System.Drawing.Point(187, 185);
            this.NzMab.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzMab.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzMab.MS_Change_Border_Color_On_Enter = true;
            this.NzMab.MS_Change_Color_On_Enter = true;
            this.NzMab.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.NzMab.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzMab.MS_Exit_By_Down = true;
            this.NzMab.MS_Exit_By_Enter = true;
            this.NzMab.MS_Exit_By_Up = true;
            this.NzMab.MS_Is_Negative = false;
            this.NzMab.MS_Last_Control = null;
            this.NzMab.MS_Next_Control = null;
            this.NzMab.Name = "NzMab";
            this.NzMab.Size = new System.Drawing.Size(161, 29);
            this.NzMab.TabIndex = 9;
            this.NzMab.TextAlignment = Janus.Windows.GridEX.TextAlignment.Far;
            this.NzMab.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // NzDate
            // 
            this.NzDate.AllowInternalTab = false;
            this.NzDate.AllowResizeDropDown = false;
            this.NzDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzDate.AutoHeight = true;
            this.NzDate.BackColor = System.Drawing.Color.White;
            this.NzDate.ControlSize = new System.Drawing.Size(0, 0);
            this.NzDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NzDate.DropSize = new System.Drawing.Size(0, 0);
            this.NzDate.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F);
            this.NzDate.Location = new System.Drawing.Point(249, 125);
            this.NzDate.MinimumSize = new System.Drawing.Size(99, 27);
            this.NzDate.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzDate.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzDate.MS_Change_Border_Color_On_Enter = true;
            this.NzDate.MS_Change_Color_On_Enter = true;
            this.NzDate.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.NzDate.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzDate.MS_Exit_By_Down = true;
            this.NzDate.MS_Exit_By_Enter = true;
            this.NzDate.MS_Exit_By_Up = true;
            this.NzDate.MS_Last_Control = null;
            this.NzDate.MS_Next_Control = null;
            this.NzDate.MS_Separation = '/';
            this.NzDate.MS_Tarikh = null;
            this.NzDate.Name = "NzDate";
            this.NzDate.ReadOnly = false;
            this.NzDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NzDate.Size = new System.Drawing.Size(99, 27);
            this.NzDate.TabIndex = 7;
            this.NzDate.Text = "//";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(353, 219);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 23);
            this.label11.TabIndex = 824;
            this.label11.Text = "بابت :";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(353, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 23);
            this.label10.TabIndex = 824;
            this.label10.Text = "مبلغ :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(353, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 23);
            this.label5.TabIndex = 824;
            this.label5.Text = " سریال :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(353, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 23);
            this.label6.TabIndex = 824;
            this.label6.Text = "طرف حساب :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(353, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 824;
            this.label4.Text = "در تاریخ :";
            // 
            // lblNoh
            // 
            this.lblNoh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNoh.AutoSize = true;
            this.lblNoh.BackColor = System.Drawing.Color.Transparent;
            this.lblNoh.Location = new System.Drawing.Point(353, 97);
            this.lblNoh.Name = "lblNoh";
            this.lblNoh.Size = new System.Drawing.Size(120, 23);
            this.lblNoh.TabIndex = 824;
            this.lblNoh.Text = "انتخاب نوع کسورات :";
            // 
            // uiTabPage14
            // 
            this.uiTabPage14.AutoScroll = true;
            this.uiTabPage14.Controls.Add(this.label16);
            this.uiTabPage14.Controls.Add(this.label15);
            this.uiTabPage14.Controls.Add(this.label12);
            this.uiTabPage14.Controls.Add(this.label13);
            this.uiTabPage14.Controls.Add(this.label2);
            this.uiTabPage14.Controls.Add(this.label1);
            this.uiTabPage14.Location = new System.Drawing.Point(1, 1);
            this.uiTabPage14.Name = "uiTabPage14";
            this.uiTabPage14.PanelFormatStyle.Alpha = 70;
            this.uiTabPage14.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
            this.uiTabPage14.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
            this.uiTabPage14.PanelFormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical;
            this.uiTabPage14.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiTabPage14.Size = new System.Drawing.Size(497, 329);
            this.uiTabPage14.TabStop = true;
            this.uiTabPage14.Text = "پرسش و پاسخ";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label16.Location = new System.Drawing.Point(349, 113);
            this.label16.Name = "label16";
            this.label16.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label16.Size = new System.Drawing.Size(130, 47);
            this.label16.TabIndex = 6;
            this.label16.Text = "کاربر به کلمه عبور پیش فرض تغییر می کند و کاربر می تواند مجدداً رمز عبور را تعیین" +
    " کند .";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label15.Location = new System.Drawing.Point(392, 197);
            this.label15.Name = "label15";
            this.label15.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label15.Size = new System.Drawing.Size(87, 30);
            this.label15.TabIndex = 5;
            this.label15.Text = "کلیک کنید با این کار کلمه عبور";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label12.Location = new System.Drawing.Point(392, 160);
            this.label12.Name = "label12";
            this.label12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label12.Size = new System.Drawing.Size(87, 30);
            this.label12.TabIndex = 3;
            this.label12.Text = "در این صورت در لیست کاربران بروی دکمه";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.ForeColor = System.Drawing.Color.Maroon;
            this.label13.Location = new System.Drawing.Point(326, 91);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label13.Size = new System.Drawing.Size(153, 22);
            this.label13.TabIndex = 2;
            this.label13.Text = "در صورتی که کاربر رمز عبور خود را فراموش کرد چکار باید کرد ؟";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(320, 34);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(153, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "در هنگام تعریف کاربران، رمز ورود با رمز عبور پیش فرض تعیین می گردد. در اولین ورود" +
    " کاربر به برنامه از وی رمز عبور جدید درخواست می شود.";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(320, 6);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(153, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "رمز ورود کاربر چیست ؟";
            // 
            // FormDeficit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 349);
            this.Controls.Add(this.Panel_Foother);
            this.Controls.Add(this.Tab_Control_Main);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDeficit";
            this.Text = "کسورات و اضافات";
            this.Shown += new System.EventHandler(this.FormDeficit_Shown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormDeficit_KeyUp);
            this.Panel_Foother.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).EndInit();
            this.Tab_Control_Main.ResumeLayout(false);
            this.uiTabPage12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.uiTabPage14.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MS_Control.Controls.MS_Panel Panel_Foother;
        private MS_Control.Controls.MS_Button_GridX ms_Save;
        private MS_Control.Controls.MS_Button_GridX ms_Exit;
        private Janus.Windows.UI.Tab.UITab Tab_Control_Main;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage12;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private Component.NzAccounts NzComboDeficit;
        private MS_Control.Controls.MS_TextBox NzBabat;
        private MS_Control.Controls.MS_NumericTextBox NzSerial;
        private MS_Control.Controls.MS_NumericTextBox NzMab;
        private MS_Control.Tarikh.MS_Tarikh_TextBox NzDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNoh;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private NZ.General.WinForms.Component.NzPeople NzComboShaxs;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private General.WinForms.Component.NzRemainCustomer NzVaziat;
        private MS_Control.Controls.MS_Notify mS_Notify1;
        private MS_Control.Controls.MS_Text_Simple LineSeperator;
    }
}