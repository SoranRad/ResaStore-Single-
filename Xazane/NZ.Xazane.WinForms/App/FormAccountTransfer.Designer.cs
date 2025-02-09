
namespace NZ.Xazane.WinForms.App
{
    partial class FormAccountTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccountTransfer));
            this.Panel_Foother = new MS_Control.Controls.MS_Panel();
            this.ms_Save = new MS_Control.Controls.MS_Button_GridX();
            this.ms_Exit = new MS_Control.Controls.MS_Button_GridX();
            this.Tab_Control_Main = new Janus.Windows.UI.Tab.UITab();
            this.uiTabPage1 = new Janus.Windows.UI.Tab.UITabPage();
            this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
            this.mS_Text_Simple1 = new MS_Control.Controls.MS_Text_Simple();
            this.NzAccountBe = new NZ.Xazane.WinForms.Component.NzAccounts();
            this.label2 = new System.Windows.Forms.Label();
            this.NzAccountAz = new NZ.Xazane.WinForms.Component.NzAccounts();
            this.NzBabat = new MS_Control.Controls.MS_TextBox();
            this.NzSerial = new MS_Control.Controls.MS_NumericTextBox();
            this.NzMab = new MS_Control.Controls.MS_NumericTextBox();
            this.NzDate = new MS_Control.Tarikh.MS_Tarikh_TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.mS_Text_Simple6 = new MS_Control.Controls.MS_Text_Simple();
            this.mS_Text_Simple10 = new MS_Control.Controls.MS_Text_Simple();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NzSanduqBe = new MS_Control.Controls.MS_RadioBox();
            this.NzBankBe = new MS_Control.Controls.MS_RadioBox();
            this.NzTanxahBe = new MS_Control.Controls.MS_RadioBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NzSanduqAz = new MS_Control.Controls.MS_RadioBox();
            this.NzBankAz = new MS_Control.Controls.MS_RadioBox();
            this.NzTanxahAz = new MS_Control.Controls.MS_RadioBox();
            this.uiTabPage2 = new Janus.Windows.UI.Tab.UITabPage();
            this.mS_Notify1 = new MS_Control.Controls.MS_Notify();
            this.Panel_Foother.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).BeginInit();
            this.Tab_Control_Main.SuspendLayout();
            this.uiTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
            this.uiGroupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Foother
            // 
            this.Panel_Foother.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Foother.Controls.Add(this.ms_Save);
            this.Panel_Foother.Controls.Add(this.ms_Exit);
            this.Panel_Foother.Location = new System.Drawing.Point(0, 453);
            this.Panel_Foother.MS_BorderColor = System.Drawing.Color.DarkGray;
            this.Panel_Foother.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.Panel_Foother.MS_Color_End = System.Drawing.Color.Gainsboro;
            this.Panel_Foother.MS_Color_Start = System.Drawing.Color.WhiteSmoke;
            this.Panel_Foother.Name = "Panel_Foother";
            this.Panel_Foother.Size = new System.Drawing.Size(520, 45);
            this.Panel_Foother.TabIndex = 17;
            // 
            // ms_Save
            // 
            this.ms_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_Save.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_Save.Image = ((System.Drawing.Image)(resources.GetObject("ms_Save.Image")));
            this.ms_Save.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.ms_Save.Location = new System.Drawing.Point(150, 8);
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
            this.ms_Exit.Location = new System.Drawing.Point(12, 8);
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
            this.Tab_Control_Main.Location = new System.Drawing.Point(0, -1);
            this.Tab_Control_Main.MultiLine = true;
            this.Tab_Control_Main.Name = "Tab_Control_Main";
            this.Tab_Control_Main.Office2007CustomColor = System.Drawing.Color.Transparent;
            this.Tab_Control_Main.ShowFocusRectangle = false;
            this.Tab_Control_Main.Size = new System.Drawing.Size(550, 454);
            this.Tab_Control_Main.TabIndex = 16;
            this.Tab_Control_Main.TabPages.AddRange(new Janus.Windows.UI.Tab.UITabPage[] {
            this.uiTabPage1,
            this.uiTabPage2});
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
            // uiTabPage1
            // 
            this.uiTabPage1.Controls.Add(this.uiGroupBox2);
            this.uiTabPage1.Location = new System.Drawing.Point(1, 1);
            this.uiTabPage1.Name = "uiTabPage1";
            this.uiTabPage1.PanelFormatStyle.Alpha = 70;
            this.uiTabPage1.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
            this.uiTabPage1.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
            this.uiTabPage1.PanelFormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical;
            this.uiTabPage1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiTabPage1.Size = new System.Drawing.Size(518, 452);
            this.uiTabPage1.TabStop = true;
            this.uiTabPage1.Text = "اطلاعات";
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.uiGroupBox2.BorderColor = System.Drawing.Color.LightBlue;
            this.uiGroupBox2.Controls.Add(this.mS_Text_Simple1);
            this.uiGroupBox2.Controls.Add(this.NzAccountBe);
            this.uiGroupBox2.Controls.Add(this.label2);
            this.uiGroupBox2.Controls.Add(this.NzAccountAz);
            this.uiGroupBox2.Controls.Add(this.NzBabat);
            this.uiGroupBox2.Controls.Add(this.NzSerial);
            this.uiGroupBox2.Controls.Add(this.NzMab);
            this.uiGroupBox2.Controls.Add(this.NzDate);
            this.uiGroupBox2.Controls.Add(this.label6);
            this.uiGroupBox2.Controls.Add(this.label7);
            this.uiGroupBox2.Controls.Add(this.label8);
            this.uiGroupBox2.Controls.Add(this.label1);
            this.uiGroupBox2.Controls.Add(this.label9);
            this.uiGroupBox2.Controls.Add(this.mS_Text_Simple6);
            this.uiGroupBox2.Controls.Add(this.mS_Text_Simple10);
            this.uiGroupBox2.Controls.Add(this.panel1);
            this.uiGroupBox2.Controls.Add(this.panel2);
            this.uiGroupBox2.Location = new System.Drawing.Point(6, 0);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Size = new System.Drawing.Size(506, 445);
            this.uiGroupBox2.TabIndex = 819;
            // 
            // mS_Text_Simple1
            // 
            this.mS_Text_Simple1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mS_Text_Simple1.BackColor = System.Drawing.Color.LightGreen;
            this.mS_Text_Simple1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mS_Text_Simple1.Font = new System.Drawing.Font("IRANSans(Small) Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mS_Text_Simple1.Location = new System.Drawing.Point(56, 163);
            this.mS_Text_Simple1.MS_BorderColor = System.Drawing.Color.SeaGreen;
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
            this.mS_Text_Simple1.Size = new System.Drawing.Size(391, 27);
            this.mS_Text_Simple1.TabIndex = 848;
            this.mS_Text_Simple1.Text = "انتقال وجـه بـه حسـاب        (حساب مقصد)";
            this.mS_Text_Simple1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NzAccountBe
            // 
            this.NzAccountBe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzAccountBe.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
            this.NzAccountBe.DropSize = new System.Drawing.Size(361, 29);
            this.NzAccountBe.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
            this.NzAccountBe.Location = new System.Drawing.Point(56, 242);
            this.NzAccountBe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NzAccountBe.MS_Auto_Popup = false;
            this.NzAccountBe.MS_BorderColor = System.Drawing.Color.DarkGreen;
            this.NzAccountBe.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzAccountBe.MS_CaptureFocus = false;
            this.NzAccountBe.MS_Change_Border_Color_On_Enter = true;
            this.NzAccountBe.MS_Change_Color_On_Enter = true;
            this.NzAccountBe.MS_Drop_Direction = MS_Control.TSDD.KindShow.Right;
            this.NzAccountBe.MS_DropDownSizeMode = MS_Control.TSDD.SizeMode.Control_Size;
            this.NzAccountBe.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.NzAccountBe.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzAccountBe.MS_Exit_By_Down = true;
            this.NzAccountBe.MS_Exit_By_Enter = true;
            this.NzAccountBe.MS_Exit_By_Up = true;
            this.NzAccountBe.MS_Last_Control = null;
            this.NzAccountBe.MS_Next_Control = null;
            this.NzAccountBe.Name = "NzAccountBe";
            this.NzAccountBe.Office2007ColorScheme = Janus.Windows.GridEX.Office2007ColorScheme.Custom;
            this.NzAccountBe.Office2007CustomColor = System.Drawing.Color.ForestGreen;
            this.NzAccountBe.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzAccountBe.Size = new System.Drawing.Size(361, 29);
            this.NzAccountBe.TabIndex = 849;
            this.NzAccountBe.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("IRANSans(Small) Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(422, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 26);
            this.label2.TabIndex = 853;
            this.label2.Text = "حسـاب :";
            // 
            // NzAccountAz
            // 
            this.NzAccountAz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzAccountAz.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.DownArrow;
            this.NzAccountAz.DropSize = new System.Drawing.Size(361, 29);
            this.NzAccountAz.Font = new System.Drawing.Font("IRANSans(Small)", 13F);
            this.NzAccountAz.Location = new System.Drawing.Point(56, 92);
            this.NzAccountAz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NzAccountAz.MS_Auto_Popup = false;
            this.NzAccountAz.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzAccountAz.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzAccountAz.MS_CaptureFocus = false;
            this.NzAccountAz.MS_Change_Border_Color_On_Enter = true;
            this.NzAccountAz.MS_Change_Color_On_Enter = true;
            this.NzAccountAz.MS_Drop_Direction = MS_Control.TSDD.KindShow.Right;
            this.NzAccountAz.MS_DropDownSizeMode = MS_Control.TSDD.SizeMode.Control_Size;
            this.NzAccountAz.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.NzAccountAz.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzAccountAz.MS_Exit_By_Down = true;
            this.NzAccountAz.MS_Exit_By_Enter = true;
            this.NzAccountAz.MS_Exit_By_Up = true;
            this.NzAccountAz.MS_Last_Control = null;
            this.NzAccountAz.MS_Next_Control = null;
            this.NzAccountAz.Name = "NzAccountAz";
            this.NzAccountAz.Office2007CustomColor = System.Drawing.Color.SkyBlue;
            this.NzAccountAz.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzAccountAz.Size = new System.Drawing.Size(361, 29);
            this.NzAccountAz.TabIndex = 834;
            this.NzAccountAz.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // NzBabat
            // 
            this.NzBabat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzBabat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzBabat.Location = new System.Drawing.Point(13, 406);
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
            this.NzBabat.Size = new System.Drawing.Size(405, 29);
            this.NzBabat.TabIndex = 843;
            // 
            // NzSerial
            // 
            this.NzSerial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzSerial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzSerial.DigitGroup = false;
            this.NzSerial.Location = new System.Drawing.Point(311, 340);
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
            this.NzSerial.Size = new System.Drawing.Size(107, 29);
            this.NzSerial.TabIndex = 841;
            this.NzSerial.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.NzSerial.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // NzMab
            // 
            this.NzMab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzMab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzMab.Location = new System.Drawing.Point(257, 373);
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
            this.NzMab.TabIndex = 842;
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
            this.NzDate.Location = new System.Drawing.Point(311, 309);
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
            this.NzDate.Size = new System.Drawing.Size(107, 27);
            this.NzDate.TabIndex = 840;
            this.NzDate.Text = "//";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(423, 409);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 23);
            this.label6.TabIndex = 844;
            this.label6.Text = "بابت :";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(423, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 23);
            this.label7.TabIndex = 845;
            this.label7.Text = "مبلغ :";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(423, 343);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 23);
            this.label8.TabIndex = 846;
            this.label8.Text = " سریال :";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("IRANSans(Small) Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(422, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 26);
            this.label1.TabIndex = 847;
            this.label1.Text = "حسـاب :";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(423, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 23);
            this.label9.TabIndex = 847;
            this.label9.Text = "در تاریخ :";
            // 
            // mS_Text_Simple6
            // 
            this.mS_Text_Simple6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mS_Text_Simple6.BackColor = System.Drawing.Color.SkyBlue;
            this.mS_Text_Simple6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mS_Text_Simple6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.mS_Text_Simple6.Location = new System.Drawing.Point(5, 139);
            this.mS_Text_Simple6.MS_BorderColor = System.Drawing.Color.LightSkyBlue;
            this.mS_Text_Simple6.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
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
            this.mS_Text_Simple6.ReadOnly = true;
            this.mS_Text_Simple6.Size = new System.Drawing.Size(494, 3);
            this.mS_Text_Simple6.TabIndex = 823;
            // 
            // mS_Text_Simple10
            // 
            this.mS_Text_Simple10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mS_Text_Simple10.BackColor = System.Drawing.Color.SkyBlue;
            this.mS_Text_Simple10.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mS_Text_Simple10.Font = new System.Drawing.Font("IRANSans(Small) Medium", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.mS_Text_Simple10.Location = new System.Drawing.Point(56, 12);
            this.mS_Text_Simple10.MS_BorderColor = System.Drawing.Color.DodgerBlue;
            this.mS_Text_Simple10.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.mS_Text_Simple10.MS_Change_Border_Color_On_Enter = false;
            this.mS_Text_Simple10.MS_Change_Color_On_Enter = false;
            this.mS_Text_Simple10.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.mS_Text_Simple10.MS_Enter_Color = System.Drawing.Color.Empty;
            this.mS_Text_Simple10.MS_Exit_By_Down = false;
            this.mS_Text_Simple10.MS_Exit_By_Enter = false;
            this.mS_Text_Simple10.MS_Exit_By_Up = false;
            this.mS_Text_Simple10.MS_Last_Control = null;
            this.mS_Text_Simple10.MS_Next_Control = null;
            this.mS_Text_Simple10.Multiline = true;
            this.mS_Text_Simple10.Name = "mS_Text_Simple10";
            this.mS_Text_Simple10.ReadOnly = true;
            this.mS_Text_Simple10.Size = new System.Drawing.Size(391, 27);
            this.mS_Text_Simple10.TabIndex = 819;
            this.mS_Text_Simple10.Text = "انتقال وجـه از حسـاب       (حساب مبدا)";
            this.mS_Text_Simple10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NzSanduqBe);
            this.panel1.Controls.Add(this.NzBankBe);
            this.panel1.Controls.Add(this.NzTanxahBe);
            this.panel1.Location = new System.Drawing.Point(5, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 57);
            this.panel1.TabIndex = 854;
            // 
            // NzSanduqBe
            // 
            this.NzSanduqBe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzSanduqBe.Appearance = System.Windows.Forms.Appearance.Button;
            this.NzSanduqBe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzSanduqBe.Location = new System.Drawing.Point(355, 12);
            this.NzSanduqBe.MS_BorderColor = System.Drawing.Color.Empty;
            this.NzSanduqBe.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzSanduqBe.MS_Change_Border_Color_On_Enter = false;
            this.NzSanduqBe.MS_Change_Color_On_Checked = false;
            this.NzSanduqBe.MS_Change_Color_On_Enter = false;
            this.NzSanduqBe.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzSanduqBe.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NzSanduqBe.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzSanduqBe.MS_Exit_By_Down = true;
            this.NzSanduqBe.MS_Exit_By_Enter = true;
            this.NzSanduqBe.MS_Exit_By_Up = true;
            this.NzSanduqBe.MS_Last_Control = null;
            this.NzSanduqBe.MS_Next_Control = null;
            this.NzSanduqBe.MS_UnChecked_Color = System.Drawing.Color.Empty;
            this.NzSanduqBe.Name = "NzSanduqBe";
            this.NzSanduqBe.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.NzSanduqBe.Office2007CustomColor = System.Drawing.Color.SeaGreen;
            this.NzSanduqBe.ShowFocusRectangle = false;
            this.NzSanduqBe.Size = new System.Drawing.Size(135, 32);
            this.NzSanduqBe.TabIndex = 852;
            this.NzSanduqBe.Text = "صندوق";
            this.NzSanduqBe.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center;
            this.NzSanduqBe.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.NzSanduqBe.CheckedChanged += new System.EventHandler(this.NzSanduqBe_CheckedChanged);
            // 
            // NzBankBe
            // 
            this.NzBankBe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzBankBe.Appearance = System.Windows.Forms.Appearance.Button;
            this.NzBankBe.Checked = true;
            this.NzBankBe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzBankBe.Location = new System.Drawing.Point(180, 12);
            this.NzBankBe.MS_BorderColor = System.Drawing.Color.Empty;
            this.NzBankBe.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzBankBe.MS_Change_Border_Color_On_Enter = false;
            this.NzBankBe.MS_Change_Color_On_Checked = false;
            this.NzBankBe.MS_Change_Color_On_Enter = false;
            this.NzBankBe.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzBankBe.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NzBankBe.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzBankBe.MS_Exit_By_Down = true;
            this.NzBankBe.MS_Exit_By_Enter = true;
            this.NzBankBe.MS_Exit_By_Up = true;
            this.NzBankBe.MS_Last_Control = null;
            this.NzBankBe.MS_Next_Control = null;
            this.NzBankBe.MS_UnChecked_Color = System.Drawing.Color.Empty;
            this.NzBankBe.Name = "NzBankBe";
            this.NzBankBe.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.NzBankBe.Office2007CustomColor = System.Drawing.Color.SeaGreen;
            this.NzBankBe.ShowFocusRectangle = false;
            this.NzBankBe.Size = new System.Drawing.Size(135, 32);
            this.NzBankBe.TabIndex = 851;
            this.NzBankBe.TabStop = true;
            this.NzBankBe.Text = "حساب بانکی ";
            this.NzBankBe.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center;
            this.NzBankBe.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.NzBankBe.CheckedChanged += new System.EventHandler(this.NzSanduqBe_CheckedChanged);
            // 
            // NzTanxahBe
            // 
            this.NzTanxahBe.Appearance = System.Windows.Forms.Appearance.Button;
            this.NzTanxahBe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzTanxahBe.Location = new System.Drawing.Point(5, 12);
            this.NzTanxahBe.MS_BorderColor = System.Drawing.Color.Empty;
            this.NzTanxahBe.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzTanxahBe.MS_Change_Border_Color_On_Enter = false;
            this.NzTanxahBe.MS_Change_Color_On_Checked = false;
            this.NzTanxahBe.MS_Change_Color_On_Enter = false;
            this.NzTanxahBe.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzTanxahBe.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NzTanxahBe.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzTanxahBe.MS_Exit_By_Down = true;
            this.NzTanxahBe.MS_Exit_By_Enter = true;
            this.NzTanxahBe.MS_Exit_By_Up = true;
            this.NzTanxahBe.MS_Last_Control = null;
            this.NzTanxahBe.MS_Next_Control = null;
            this.NzTanxahBe.MS_UnChecked_Color = System.Drawing.Color.Empty;
            this.NzTanxahBe.Name = "NzTanxahBe";
            this.NzTanxahBe.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.NzTanxahBe.Office2007CustomColor = System.Drawing.Color.SeaGreen;
            this.NzTanxahBe.ShowFocusRectangle = false;
            this.NzTanxahBe.Size = new System.Drawing.Size(135, 32);
            this.NzTanxahBe.TabIndex = 850;
            this.NzTanxahBe.Text = "تنـخواه";
            this.NzTanxahBe.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center;
            this.NzTanxahBe.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.NzTanxahBe.CheckedChanged += new System.EventHandler(this.NzSanduqBe_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.NzSanduqAz);
            this.panel2.Controls.Add(this.NzBankAz);
            this.panel2.Controls.Add(this.NzTanxahAz);
            this.panel2.Location = new System.Drawing.Point(1, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(494, 57);
            this.panel2.TabIndex = 855;
            // 
            // NzSanduqAz
            // 
            this.NzSanduqAz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzSanduqAz.Appearance = System.Windows.Forms.Appearance.Button;
            this.NzSanduqAz.Checked = true;
            this.NzSanduqAz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzSanduqAz.Location = new System.Drawing.Point(354, 12);
            this.NzSanduqAz.MS_BorderColor = System.Drawing.Color.Empty;
            this.NzSanduqAz.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzSanduqAz.MS_Change_Border_Color_On_Enter = false;
            this.NzSanduqAz.MS_Change_Color_On_Checked = false;
            this.NzSanduqAz.MS_Change_Color_On_Enter = false;
            this.NzSanduqAz.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzSanduqAz.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NzSanduqAz.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzSanduqAz.MS_Exit_By_Down = true;
            this.NzSanduqAz.MS_Exit_By_Enter = true;
            this.NzSanduqAz.MS_Exit_By_Up = true;
            this.NzSanduqAz.MS_Last_Control = null;
            this.NzSanduqAz.MS_Next_Control = null;
            this.NzSanduqAz.MS_UnChecked_Color = System.Drawing.Color.Empty;
            this.NzSanduqAz.Name = "NzSanduqAz";
            this.NzSanduqAz.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.NzSanduqAz.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
            this.NzSanduqAz.ShowFocusRectangle = false;
            this.NzSanduqAz.Size = new System.Drawing.Size(135, 32);
            this.NzSanduqAz.TabIndex = 835;
            this.NzSanduqAz.TabStop = true;
            this.NzSanduqAz.Text = "صندوق";
            this.NzSanduqAz.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center;
            this.NzSanduqAz.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.NzSanduqAz.CheckedChanged += new System.EventHandler(this.NzSanduqAz_CheckedChanged);
            // 
            // NzBankAz
            // 
            this.NzBankAz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzBankAz.Appearance = System.Windows.Forms.Appearance.Button;
            this.NzBankAz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzBankAz.Location = new System.Drawing.Point(179, 12);
            this.NzBankAz.MS_BorderColor = System.Drawing.Color.Empty;
            this.NzBankAz.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzBankAz.MS_Change_Border_Color_On_Enter = false;
            this.NzBankAz.MS_Change_Color_On_Checked = false;
            this.NzBankAz.MS_Change_Color_On_Enter = false;
            this.NzBankAz.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzBankAz.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NzBankAz.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzBankAz.MS_Exit_By_Down = true;
            this.NzBankAz.MS_Exit_By_Enter = true;
            this.NzBankAz.MS_Exit_By_Up = true;
            this.NzBankAz.MS_Last_Control = null;
            this.NzBankAz.MS_Next_Control = null;
            this.NzBankAz.MS_UnChecked_Color = System.Drawing.Color.Empty;
            this.NzBankAz.Name = "NzBankAz";
            this.NzBankAz.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.NzBankAz.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
            this.NzBankAz.ShowFocusRectangle = false;
            this.NzBankAz.Size = new System.Drawing.Size(135, 32);
            this.NzBankAz.TabIndex = 835;
            this.NzBankAz.Text = "حساب بانکی ";
            this.NzBankAz.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center;
            this.NzBankAz.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.NzBankAz.CheckedChanged += new System.EventHandler(this.NzSanduqAz_CheckedChanged);
            // 
            // NzTanxahAz
            // 
            this.NzTanxahAz.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzTanxahAz.Appearance = System.Windows.Forms.Appearance.Button;
            this.NzTanxahAz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzTanxahAz.Location = new System.Drawing.Point(4, 12);
            this.NzTanxahAz.MS_BorderColor = System.Drawing.Color.Empty;
            this.NzTanxahAz.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzTanxahAz.MS_Change_Border_Color_On_Enter = false;
            this.NzTanxahAz.MS_Change_Color_On_Checked = false;
            this.NzTanxahAz.MS_Change_Color_On_Enter = false;
            this.NzTanxahAz.MS_Checked_Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzTanxahAz.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.NzTanxahAz.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NzTanxahAz.MS_Exit_By_Down = true;
            this.NzTanxahAz.MS_Exit_By_Enter = true;
            this.NzTanxahAz.MS_Exit_By_Up = true;
            this.NzTanxahAz.MS_Last_Control = null;
            this.NzTanxahAz.MS_Next_Control = null;
            this.NzTanxahAz.MS_UnChecked_Color = System.Drawing.Color.Empty;
            this.NzTanxahAz.Name = "NzTanxahAz";
            this.NzTanxahAz.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.NzTanxahAz.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
            this.NzTanxahAz.ShowFocusRectangle = false;
            this.NzTanxahAz.Size = new System.Drawing.Size(135, 32);
            this.NzTanxahAz.TabIndex = 835;
            this.NzTanxahAz.Text = "تنـخواه";
            this.NzTanxahAz.TextAlignment = Janus.Windows.EditControls.TextAlignment.Center;
            this.NzTanxahAz.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.NzTanxahAz.CheckedChanged += new System.EventHandler(this.NzSanduqAz_CheckedChanged);
            // 
            // uiTabPage2
            // 
            this.uiTabPage2.AutoScroll = true;
            this.uiTabPage2.Location = new System.Drawing.Point(1, 1);
            this.uiTabPage2.Name = "uiTabPage2";
            this.uiTabPage2.PanelFormatStyle.Alpha = 70;
            this.uiTabPage2.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
            this.uiTabPage2.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
            this.uiTabPage2.PanelFormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical;
            this.uiTabPage2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiTabPage2.Size = new System.Drawing.Size(474, 411);
            this.uiTabPage2.TabStop = true;
            this.uiTabPage2.Text = "پرسش و پاسخ";
            // 
            // FormAccountTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 500);
            this.Controls.Add(this.Panel_Foother);
            this.Controls.Add(this.Tab_Control_Main);
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAccountTransfer";
            this.Text = "انتـقال وجوه بین حساب هـا";
            this.Shown += new System.EventHandler(this.Form_Shown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FormAccountTransfer_KeyUp);
            this.Panel_Foother.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).EndInit();
            this.Tab_Control_Main.ResumeLayout(false);
            this.uiTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MS_Control.Controls.MS_Panel Panel_Foother;
        private MS_Control.Controls.MS_Button_GridX ms_Save;
        private MS_Control.Controls.MS_Button_GridX ms_Exit;
        private Janus.Windows.UI.Tab.UITab Tab_Control_Main;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage1;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
        private Component.NzAccounts NzAccountAz;
        private MS_Control.Controls.MS_TextBox NzBabat;
        private MS_Control.Controls.MS_NumericTextBox NzSerial;
        private MS_Control.Controls.MS_NumericTextBox NzMab;
        private MS_Control.Tarikh.MS_Tarikh_TextBox NzDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private MS_Control.Controls.MS_RadioBox NzSanduqAz;
        private MS_Control.Controls.MS_Text_Simple mS_Text_Simple6;
        private MS_Control.Controls.MS_Text_Simple mS_Text_Simple10;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage2;
        private MS_Control.Controls.MS_RadioBox NzTanxahAz;
        private MS_Control.Controls.MS_RadioBox NzBankAz;
        private System.Windows.Forms.Label label1;
        private Component.NzAccounts NzAccountBe;
        private System.Windows.Forms.Label label2;
        private MS_Control.Controls.MS_RadioBox NzTanxahBe;
        private MS_Control.Controls.MS_RadioBox NzBankBe;
        private MS_Control.Controls.MS_RadioBox NzSanduqBe;
        private MS_Control.Controls.MS_Text_Simple mS_Text_Simple1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private MS_Control.Controls.MS_Notify mS_Notify1;
    }
}