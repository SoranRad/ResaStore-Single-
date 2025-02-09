namespace NZ.Xazane.WinForms.App
{
    partial class FormCost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCost));
            this.Panel_Foother = new MS_Control.Controls.MS_Panel();
            this.ms_Save = new MS_Control.Controls.MS_Button_GridX();
            this.ms_Exit = new MS_Control.Controls.MS_Button_GridX();
            this.Tab_Control_Main = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage12 = new Janus.Windows.UI.Tab.UITabPage();
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.NzComboHazine = new NZ.Xazane.WinForms.Component.NzAccounts();
            this.NzComboTanxah = new NZ.Xazane.WinForms.Component.NzAccounts();
            this.NzComboHesabBanki = new NZ.Xazane.WinForms.Component.NzAccounts();
            this.NzComboSandogh = new NZ.Xazane.WinForms.Component.NzAccounts();
            this.NzBabat = new MS_Control.Controls.MS_TextBox();
            this.NzSerial = new MS_Control.Controls.MS_NumericTextBox();
            this.NzMab = new MS_Control.Controls.MS_NumericTextBox();
            this.NzDate = new MS_Control.Tarikh.MS_Tarikh_TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mS_Text_Simple5 = new MS_Control.Controls.MS_Text_Simple();
            this.mS_Text_Simple6 = new MS_Control.Controls.MS_Text_Simple();
            this.mS_Text_Simple4 = new MS_Control.Controls.MS_Text_Simple();
            this.mS_Text_Simple3 = new MS_Control.Controls.MS_Text_Simple();
            this.mS_Text_Simple2 = new MS_Control.Controls.MS_Text_Simple();
            this.NzFundRadio = new MS_Control.Controls.MS_RadioBox();
            this.NzBankRadio = new MS_Control.Controls.MS_RadioBox();
            this.NzCacheRadio = new MS_Control.Controls.MS_RadioBox();
            this.mS_Text_Simple1 = new MS_Control.Controls.MS_Text_Simple();
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
            this.Panel_Foother.Location = new System.Drawing.Point(0, 372);
            this.Panel_Foother.MS_BorderColor = System.Drawing.Color.DarkGray;
            this.Panel_Foother.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.Panel_Foother.MS_Color_End = System.Drawing.Color.Gainsboro;
            this.Panel_Foother.MS_Color_Start = System.Drawing.Color.WhiteSmoke;
            this.Panel_Foother.Name = "Panel_Foother";
            this.Panel_Foother.Size = new System.Drawing.Size(517, 50);
            this.Panel_Foother.TabIndex = 1;
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
            this.Tab_Control_Main.Location = new System.Drawing.Point(1, -1);
            this.Tab_Control_Main.MultiLine = true;
            this.Tab_Control_Main.Name = "Tab_Control_Main";
            this.Tab_Control_Main.Office2007CustomColor = System.Drawing.Color.Transparent;
            this.Tab_Control_Main.ShowFocusRectangle = false;
            this.Tab_Control_Main.Size = new System.Drawing.Size(546, 373);
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
            this.uiTabPage12.Size = new System.Drawing.Size(514, 371);
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
            this.uiGroupBox1.Controls.Add(this.NzComboHazine);
            this.uiGroupBox1.Controls.Add(this.NzComboTanxah);
            this.uiGroupBox1.Controls.Add(this.NzComboHesabBanki);
            this.uiGroupBox1.Controls.Add(this.NzComboSandogh);
            this.uiGroupBox1.Controls.Add(this.NzBabat);
            this.uiGroupBox1.Controls.Add(this.NzSerial);
            this.uiGroupBox1.Controls.Add(this.NzMab);
            this.uiGroupBox1.Controls.Add(this.NzDate);
            this.uiGroupBox1.Controls.Add(this.label11);
            this.uiGroupBox1.Controls.Add(this.label10);
            this.uiGroupBox1.Controls.Add(this.label5);
            this.uiGroupBox1.Controls.Add(this.label4);
            this.uiGroupBox1.Controls.Add(this.label3);
            this.uiGroupBox1.Controls.Add(this.mS_Text_Simple5);
            this.uiGroupBox1.Controls.Add(this.mS_Text_Simple6);
            this.uiGroupBox1.Controls.Add(this.mS_Text_Simple4);
            this.uiGroupBox1.Controls.Add(this.mS_Text_Simple3);
            this.uiGroupBox1.Controls.Add(this.mS_Text_Simple2);
            this.uiGroupBox1.Controls.Add(this.NzFundRadio);
            this.uiGroupBox1.Controls.Add(this.NzBankRadio);
            this.uiGroupBox1.Controls.Add(this.NzCacheRadio);
            this.uiGroupBox1.Controls.Add(this.mS_Text_Simple1);
            this.uiGroupBox1.Location = new System.Drawing.Point(8, 7);
            this.uiGroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(497, 357);
            this.uiGroupBox1.TabIndex = 0;
            // 
            // NzComboHazine
            // 
            this.NzComboHazine.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat;
            this.NzComboHazine.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
            this.NzComboHazine.DropSize = new System.Drawing.Size(275, 29);
            this.NzComboHazine.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
            this.NzComboHazine.Location = new System.Drawing.Point(108, 187);
            this.NzComboHazine.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NzComboHazine.MS_Auto_Popup = false;
            this.NzComboHazine.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzComboHazine.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzComboHazine.MS_CaptureFocus = false;
            this.NzComboHazine.MS_Change_Border_Color_On_Enter = true;
            this.NzComboHazine.MS_Change_Color_On_Enter = true;
            this.NzComboHazine.MS_Drop_Direction = MS_Control.TSDD.KindShow.Right;
            this.NzComboHazine.MS_DropDownSizeMode = MS_Control.TSDD.SizeMode.Control_Size;
            this.NzComboHazine.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.NzComboHazine.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzComboHazine.MS_Exit_By_Down = true;
            this.NzComboHazine.MS_Exit_By_Enter = true;
            this.NzComboHazine.MS_Exit_By_Up = true;
            this.NzComboHazine.MS_Last_Control = null;
            this.NzComboHazine.MS_Next_Control = null;
            this.NzComboHazine.Name = "NzComboHazine";
            this.NzComboHazine.Office2007CustomColor = System.Drawing.Color.SkyBlue;
            this.NzComboHazine.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzComboHazine.Size = new System.Drawing.Size(275, 29);
            this.NzComboHazine.TabIndex = 6;
            this.NzComboHazine.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // NzComboTanxah
            // 
            this.NzComboTanxah.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
            this.NzComboTanxah.DropSize = new System.Drawing.Size(275, 29);
            this.NzComboTanxah.Enabled = false;
            this.NzComboTanxah.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
            this.NzComboTanxah.Location = new System.Drawing.Point(34, 125);
            this.NzComboTanxah.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NzComboTanxah.MS_Auto_Popup = false;
            this.NzComboTanxah.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzComboTanxah.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzComboTanxah.MS_CaptureFocus = false;
            this.NzComboTanxah.MS_Change_Border_Color_On_Enter = true;
            this.NzComboTanxah.MS_Change_Color_On_Enter = true;
            this.NzComboTanxah.MS_Drop_Direction = MS_Control.TSDD.KindShow.Right;
            this.NzComboTanxah.MS_DropDownSizeMode = MS_Control.TSDD.SizeMode.Control_Size;
            this.NzComboTanxah.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.NzComboTanxah.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzComboTanxah.MS_Exit_By_Down = true;
            this.NzComboTanxah.MS_Exit_By_Enter = true;
            this.NzComboTanxah.MS_Exit_By_Up = true;
            this.NzComboTanxah.MS_Last_Control = null;
            this.NzComboTanxah.MS_Next_Control = null;
            this.NzComboTanxah.Name = "NzComboTanxah";
            this.NzComboTanxah.Office2007CustomColor = System.Drawing.Color.SkyBlue;
            this.NzComboTanxah.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzComboTanxah.Size = new System.Drawing.Size(275, 29);
            this.NzComboTanxah.TabIndex = 5;
            this.NzComboTanxah.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // NzComboHesabBanki
            // 
            this.NzComboHesabBanki.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
            this.NzComboHesabBanki.DropSize = new System.Drawing.Size(275, 29);
            this.NzComboHesabBanki.Enabled = false;
            this.NzComboHesabBanki.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
            this.NzComboHesabBanki.Location = new System.Drawing.Point(34, 94);
            this.NzComboHesabBanki.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NzComboHesabBanki.MS_Auto_Popup = false;
            this.NzComboHesabBanki.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzComboHesabBanki.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzComboHesabBanki.MS_CaptureFocus = false;
            this.NzComboHesabBanki.MS_Change_Border_Color_On_Enter = true;
            this.NzComboHesabBanki.MS_Change_Color_On_Enter = true;
            this.NzComboHesabBanki.MS_Drop_Direction = MS_Control.TSDD.KindShow.Right;
            this.NzComboHesabBanki.MS_DropDownSizeMode = MS_Control.TSDD.SizeMode.Control_Size;
            this.NzComboHesabBanki.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.NzComboHesabBanki.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzComboHesabBanki.MS_Exit_By_Down = true;
            this.NzComboHesabBanki.MS_Exit_By_Enter = true;
            this.NzComboHesabBanki.MS_Exit_By_Up = true;
            this.NzComboHesabBanki.MS_Last_Control = this.NzComboSandogh;
            this.NzComboHesabBanki.MS_Next_Control = this.NzComboTanxah;
            this.NzComboHesabBanki.Name = "NzComboHesabBanki";
            this.NzComboHesabBanki.Office2007CustomColor = System.Drawing.Color.SkyBlue;
            this.NzComboHesabBanki.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzComboHesabBanki.Size = new System.Drawing.Size(275, 29);
            this.NzComboHesabBanki.TabIndex = 3;
            this.NzComboHesabBanki.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // NzComboSandogh
            // 
            this.NzComboSandogh.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
            this.NzComboSandogh.DropSize = new System.Drawing.Size(275, 29);
            this.NzComboSandogh.Enabled = false;
            this.NzComboSandogh.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
            this.NzComboSandogh.Location = new System.Drawing.Point(34, 63);
            this.NzComboSandogh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NzComboSandogh.MS_Auto_Popup = false;
            this.NzComboSandogh.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzComboSandogh.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzComboSandogh.MS_CaptureFocus = false;
            this.NzComboSandogh.MS_Change_Border_Color_On_Enter = true;
            this.NzComboSandogh.MS_Change_Color_On_Enter = true;
            this.NzComboSandogh.MS_Drop_Direction = MS_Control.TSDD.KindShow.Right;
            this.NzComboSandogh.MS_DropDownSizeMode = MS_Control.TSDD.SizeMode.Control_Size;
            this.NzComboSandogh.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.NzComboSandogh.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzComboSandogh.MS_Exit_By_Down = true;
            this.NzComboSandogh.MS_Exit_By_Enter = true;
            this.NzComboSandogh.MS_Exit_By_Up = true;
            this.NzComboSandogh.MS_Last_Control = null;
            this.NzComboSandogh.MS_Next_Control = this.NzComboHesabBanki;
            this.NzComboSandogh.Name = "NzComboSandogh";
            this.NzComboSandogh.Office2007CustomColor = System.Drawing.Color.SkyBlue;
            this.NzComboSandogh.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzComboSandogh.Size = new System.Drawing.Size(275, 29);
            this.NzComboSandogh.TabIndex = 1;
            this.NzComboSandogh.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // NzBabat
            // 
            this.NzBabat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzBabat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzBabat.Location = new System.Drawing.Point(32, 309);
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
            this.NzBabat.Size = new System.Drawing.Size(350, 29);
            this.NzBabat.TabIndex = 10;
            // 
            // NzSerial
            // 
            this.NzSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzSerial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzSerial.DigitGroup = false;
            this.NzSerial.Location = new System.Drawing.Point(262, 247);
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
            this.NzSerial.Size = new System.Drawing.Size(120, 29);
            this.NzSerial.TabIndex = 8;
            this.NzSerial.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.NzSerial.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // NzMab
            // 
            this.NzMab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzMab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzMab.Location = new System.Drawing.Point(221, 278);
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
            this.NzDate.Location = new System.Drawing.Point(283, 218);
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
            this.label11.Location = new System.Drawing.Point(382, 312);
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
            this.label10.Location = new System.Drawing.Point(385, 281);
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
            this.label5.Location = new System.Drawing.Point(382, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 23);
            this.label5.TabIndex = 824;
            this.label5.Text = " سریال :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(382, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 23);
            this.label4.TabIndex = 824;
            this.label4.Text = "در تاریخ :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(385, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 23);
            this.label3.TabIndex = 824;
            this.label3.Text = "انتخاب نوع هزینه :";
            // 
            // mS_Text_Simple5
            // 
            this.mS_Text_Simple5.BackColor = System.Drawing.Color.Black;
            this.mS_Text_Simple5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mS_Text_Simple5.Location = new System.Drawing.Point(0, 168);
            this.mS_Text_Simple5.MS_BorderColor = System.Drawing.Color.Silver;
            this.mS_Text_Simple5.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_Text_Simple5.MS_Change_Border_Color_On_Enter = false;
            this.mS_Text_Simple5.MS_Change_Color_On_Enter = false;
            this.mS_Text_Simple5.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.mS_Text_Simple5.MS_Enter_Color = System.Drawing.Color.Empty;
            this.mS_Text_Simple5.MS_Exit_By_Down = false;
            this.mS_Text_Simple5.MS_Exit_By_Enter = false;
            this.mS_Text_Simple5.MS_Exit_By_Up = false;
            this.mS_Text_Simple5.MS_Last_Control = null;
            this.mS_Text_Simple5.MS_Next_Control = null;
            this.mS_Text_Simple5.Multiline = true;
            this.mS_Text_Simple5.Name = "mS_Text_Simple5";
            this.mS_Text_Simple5.ReadOnly = true;
            this.mS_Text_Simple5.Size = new System.Drawing.Size(496, 4);
            this.mS_Text_Simple5.TabIndex = 823;
            // 
            // mS_Text_Simple6
            // 
            this.mS_Text_Simple6.BackColor = System.Drawing.Color.LightCoral;
            this.mS_Text_Simple6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mS_Text_Simple6.Location = new System.Drawing.Point(407, 143);
            this.mS_Text_Simple6.MS_BorderColor = System.Drawing.Color.Empty;
            this.mS_Text_Simple6.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
            this.mS_Text_Simple6.MS_Change_Border_Color_On_Enter = false;
            this.mS_Text_Simple6.MS_Change_Color_On_Enter = false;
            this.mS_Text_Simple6.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.mS_Text_Simple6.MS_Enter_Color = System.Drawing.Color.Empty;
            this.mS_Text_Simple6.MS_Exit_By_Down = false;
            this.mS_Text_Simple6.MS_Exit_By_Enter = false;
            this.mS_Text_Simple6.MS_Exit_By_Up = false;
            this.mS_Text_Simple6.MS_Last_Control = null;
            this.mS_Text_Simple6.MS_Next_Control = null;
            this.mS_Text_Simple6.Multiline = true;
            this.mS_Text_Simple6.Name = "mS_Text_Simple6";
            this.mS_Text_Simple6.Size = new System.Drawing.Size(51, 2);
            this.mS_Text_Simple6.TabIndex = 822;
            // 
            // mS_Text_Simple4
            // 
            this.mS_Text_Simple4.BackColor = System.Drawing.Color.LightCoral;
            this.mS_Text_Simple4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mS_Text_Simple4.Location = new System.Drawing.Point(407, 110);
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
            this.mS_Text_Simple4.Size = new System.Drawing.Size(51, 2);
            this.mS_Text_Simple4.TabIndex = 822;
            // 
            // mS_Text_Simple3
            // 
            this.mS_Text_Simple3.BackColor = System.Drawing.Color.LightCoral;
            this.mS_Text_Simple3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mS_Text_Simple3.Location = new System.Drawing.Point(407, 77);
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
            this.mS_Text_Simple3.Size = new System.Drawing.Size(51, 2);
            this.mS_Text_Simple3.TabIndex = 822;
            // 
            // mS_Text_Simple2
            // 
            this.mS_Text_Simple2.BackColor = System.Drawing.Color.LightCoral;
            this.mS_Text_Simple2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mS_Text_Simple2.Location = new System.Drawing.Point(458, 41);
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
            this.mS_Text_Simple2.Size = new System.Drawing.Size(2, 104);
            this.mS_Text_Simple2.TabIndex = 822;
            // 
            // NzFundRadio
            // 
            this.NzFundRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzFundRadio.Location = new System.Drawing.Point(310, 128);
            this.NzFundRadio.MS_BorderColor = System.Drawing.Color.Empty;
            this.NzFundRadio.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzFundRadio.MS_Change_Border_Color_On_Enter = true;
            this.NzFundRadio.MS_Change_Color_On_Checked = true;
            this.NzFundRadio.MS_Change_Color_On_Enter = true;
            this.NzFundRadio.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzFundRadio.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NzFundRadio.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzFundRadio.MS_Exit_By_Down = true;
            this.NzFundRadio.MS_Exit_By_Enter = true;
            this.NzFundRadio.MS_Exit_By_Up = true;
            this.NzFundRadio.MS_Last_Control = null;
            this.NzFundRadio.MS_Next_Control = null;
            this.NzFundRadio.MS_UnChecked_Color = System.Drawing.Color.Empty;
            this.NzFundRadio.Name = "NzFundRadio";
            this.NzFundRadio.ShowFocusRectangle = false;
            this.NzFundRadio.Size = new System.Drawing.Size(94, 23);
            this.NzFundRadio.TabIndex = 4;
            this.NzFundRadio.Text = "تنخواه :";
            this.NzFundRadio.CheckedChanged += new System.EventHandler(this.NzRadioes_CheckedChanged);
            // 
            // NzBankRadio
            // 
            this.NzBankRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzBankRadio.Location = new System.Drawing.Point(310, 97);
            this.NzBankRadio.MS_BorderColor = System.Drawing.Color.Empty;
            this.NzBankRadio.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzBankRadio.MS_Change_Border_Color_On_Enter = true;
            this.NzBankRadio.MS_Change_Color_On_Checked = true;
            this.NzBankRadio.MS_Change_Color_On_Enter = true;
            this.NzBankRadio.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzBankRadio.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NzBankRadio.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzBankRadio.MS_Exit_By_Down = true;
            this.NzBankRadio.MS_Exit_By_Enter = true;
            this.NzBankRadio.MS_Exit_By_Up = true;
            this.NzBankRadio.MS_Last_Control = null;
            this.NzBankRadio.MS_Next_Control = null;
            this.NzBankRadio.MS_UnChecked_Color = System.Drawing.Color.Empty;
            this.NzBankRadio.Name = "NzBankRadio";
            this.NzBankRadio.ShowFocusRectangle = false;
            this.NzBankRadio.Size = new System.Drawing.Size(94, 23);
            this.NzBankRadio.TabIndex = 2;
            this.NzBankRadio.Text = "حساب بانکی :";
            this.NzBankRadio.CheckedChanged += new System.EventHandler(this.NzRadioes_CheckedChanged);
            // 
            // NzCacheRadio
            // 
            this.NzCacheRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzCacheRadio.Location = new System.Drawing.Point(310, 66);
            this.NzCacheRadio.MS_BorderColor = System.Drawing.Color.Empty;
            this.NzCacheRadio.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzCacheRadio.MS_Change_Border_Color_On_Enter = true;
            this.NzCacheRadio.MS_Change_Color_On_Checked = true;
            this.NzCacheRadio.MS_Change_Color_On_Enter = true;
            this.NzCacheRadio.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzCacheRadio.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NzCacheRadio.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzCacheRadio.MS_Exit_By_Down = true;
            this.NzCacheRadio.MS_Exit_By_Enter = true;
            this.NzCacheRadio.MS_Exit_By_Up = true;
            this.NzCacheRadio.MS_Last_Control = null;
            this.NzCacheRadio.MS_Next_Control = null;
            this.NzCacheRadio.MS_UnChecked_Color = System.Drawing.Color.Empty;
            this.NzCacheRadio.Name = "NzCacheRadio";
            this.NzCacheRadio.ShowFocusRectangle = false;
            this.NzCacheRadio.Size = new System.Drawing.Size(94, 23);
            this.NzCacheRadio.TabIndex = 0;
            this.NzCacheRadio.Text = "صندوق :";
            this.NzCacheRadio.CheckedChanged += new System.EventHandler(this.NzRadioes_CheckedChanged);
            // 
            // mS_Text_Simple1
            // 
            this.mS_Text_Simple1.BackColor = System.Drawing.Color.LightCoral;
            this.mS_Text_Simple1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mS_Text_Simple1.Font = new System.Drawing.Font("IRANSans(Small) Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mS_Text_Simple1.Location = new System.Drawing.Point(310, 15);
            this.mS_Text_Simple1.MS_BorderColor = System.Drawing.Color.Empty;
            this.mS_Text_Simple1.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
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
            this.mS_Text_Simple1.ReadOnly = true;
            this.mS_Text_Simple1.Size = new System.Drawing.Size(150, 28);
            this.mS_Text_Simple1.TabIndex = 819;
            this.mS_Text_Simple1.TabStop = false;
            this.mS_Text_Simple1.Text = "پرداخت مبلغ هزینه از";
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
            this.uiTabPage14.Size = new System.Drawing.Size(514, 371);
            this.uiTabPage14.TabStop = true;
            this.uiTabPage14.Text = "پرسش و پاسخ";
            // 
            // FormCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 422);
            this.Controls.Add(this.Panel_Foother);
            this.Controls.Add(this.Tab_Control_Main);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCost";
            this.Text = "ثبت هزینه ها";
            this.Shown += new System.EventHandler(this.FormCost_Shown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormCost_KeyUp);
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
        private MS_Control.Controls.MS_TextBox NzBabat;
        private MS_Control.Controls.MS_NumericTextBox NzMab;
        private MS_Control.Tarikh.MS_Tarikh_TextBox NzDate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MS_Control.Controls.MS_Text_Simple mS_Text_Simple5;
        private MS_Control.Controls.MS_Text_Simple mS_Text_Simple4;
        private MS_Control.Controls.MS_Text_Simple mS_Text_Simple3;
        private MS_Control.Controls.MS_Text_Simple mS_Text_Simple2;
        private MS_Control.Controls.MS_RadioBox NzBankRadio;
        private MS_Control.Controls.MS_RadioBox NzCacheRadio;
        private MS_Control.Controls.MS_Text_Simple mS_Text_Simple1;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage14;
        private Component.NzAccounts NzComboTanxah;
        private Component.NzAccounts NzComboHesabBanki;
        private Component.NzAccounts NzComboSandogh;
        private MS_Control.Controls.MS_Text_Simple mS_Text_Simple6;
        private MS_Control.Controls.MS_RadioBox NzFundRadio;
        private Component.NzAccounts NzComboHazine;
        private MS_Control.Controls.MS_Notify mS_Notify1;
        private MS_Control.Controls.MS_NumericTextBox NzSerial;
    }
}