namespace NZ.General.WinForms.Base
{
    partial class Form_User
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
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem1 = new Janus.Windows.EditControls.UIComboBoxItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_User));
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem2 = new Janus.Windows.EditControls.UIComboBoxItem();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem3 = new Janus.Windows.EditControls.UIComboBoxItem();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem4 = new Janus.Windows.EditControls.UIComboBoxItem();
            Janus.Windows.EditControls.UIComboBoxItem uiComboBoxItem5 = new Janus.Windows.EditControls.UIComboBoxItem();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ms_Is_Disable = new MS_Control.Controls.MS_ComboBox_Janus();
            this.label9 = new System.Windows.Forms.Label();
            this.ms_Pic = new System.Windows.Forms.PictureBox();
            this.ms_Open_Pic = new MS_Control.Controls.MS_Button_GridX();
            this.ms_Delete_Pic = new MS_Control.Controls.MS_Button_GridX();
            this.uiTabPage12 = new Janus.Windows.UI.Tab.UITabPage();
            this.uiGroupBox2 = new Janus.Windows.EditControls.UIGroupBox();
            this.ms_Code = new MS_Control.Controls.MS_NumericTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ms_Kind = new MS_Control.Controls.MS_ComboBox_Janus();
            this.ms_Pas_Def = new MS_Control.Controls.MS_TextBox();
            this.ms_User_Name = new MS_Control.Controls.MS_TextBox();
            this.ms_Title = new MS_Control.Controls.MS_TextBox();
            this.ms_Exit = new MS_Control.Controls.MS_Button_GridX();
            this.ms_Save = new MS_Control.Controls.MS_Button_GridX();
            this.Panel_Foother = new MS_Control.Controls.MS_Panel();
            this.uiTabPage14 = new Janus.Windows.UI.Tab.UITabPage();
            this.Tab_Control_Main = new Janus.Windows.UI.Tab.UITab();
            this.mS_Notify1 = new MS_Control.Controls.MS_Notify();
            ((System.ComponentModel.ISupportInitialize)(this.ms_Pic)).BeginInit();
            this.uiTabPage12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).BeginInit();
            this.uiGroupBox2.SuspendLayout();
            this.Panel_Foother.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).BeginInit();
            this.Tab_Control_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(194, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 23);
            this.label7.TabIndex = 162;
            this.label7.Text = "کــد کاربر :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(194, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 23);
            this.label6.TabIndex = 161;
            this.label6.Text = "نـام و نام خانوادگی :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(194, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 160;
            this.label3.Text = "نـام کـاربری :";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(194, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 23);
            this.label5.TabIndex = 159;
            this.label5.Text = "رمز عبور پیش فـرض :";
            // 
            // ms_Is_Disable
            // 
            this.ms_Is_Disable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_Is_Disable.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.ms_Is_Disable.Cursor = System.Windows.Forms.Cursors.Hand;
            uiComboBoxItem1.FormatStyle.Alpha = 0;
            uiComboBoxItem1.Image = ((System.Drawing.Image)(resources.GetObject("uiComboBoxItem1.Image")));
            uiComboBoxItem1.IsSeparator = false;
            uiComboBoxItem1.Text = "فعال";
            uiComboBoxItem2.FormatStyle.Alpha = 0;
            uiComboBoxItem2.Image = ((System.Drawing.Image)(resources.GetObject("uiComboBoxItem2.Image")));
            uiComboBoxItem2.IsSeparator = false;
            uiComboBoxItem2.Text = "غیر فعال";
            this.ms_Is_Disable.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            uiComboBoxItem1,
            uiComboBoxItem2});
            this.ms_Is_Disable.Location = new System.Drawing.Point(64, 170);
            this.ms_Is_Disable.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.ms_Is_Disable.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_Is_Disable.MS_Change_Border_Color_On_Enter = true;
            this.ms_Is_Disable.MS_Change_Color_On_Enter = true;
            this.ms_Is_Disable.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ms_Is_Disable.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_Is_Disable.MS_Exit_By_Down = true;
            this.ms_Is_Disable.MS_Exit_By_Enter = true;
            this.ms_Is_Disable.MS_Exit_By_Up = true;
            this.ms_Is_Disable.MS_Last_Control = null;
            this.ms_Is_Disable.MS_Next_Control = null;
            this.ms_Is_Disable.Name = "ms_Is_Disable";
            this.ms_Is_Disable.Size = new System.Drawing.Size(128, 29);
            this.ms_Is_Disable.TabIndex = 3;
            this.ms_Is_Disable.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Location = new System.Drawing.Point(194, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 23);
            this.label9.TabIndex = 165;
            this.label9.Text = "وضـعیت ورود :";
            // 
            // ms_Pic
            // 
            this.ms_Pic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_Pic.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ms_Pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ms_Pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_Pic.Location = new System.Drawing.Point(4, 10);
            this.ms_Pic.Margin = new System.Windows.Forms.Padding(4);
            this.ms_Pic.Name = "ms_Pic";
            this.ms_Pic.Size = new System.Drawing.Size(215, 215);
            this.ms_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ms_Pic.TabIndex = 166;
            this.ms_Pic.TabStop = false;
            // 
            // ms_Open_Pic
            // 
            this.ms_Open_Pic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_Open_Pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_Open_Pic.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_Open_Pic.Image = global::MS_Resource.GlobalResources.OpenFolder;
            this.ms_Open_Pic.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center;
            this.ms_Open_Pic.Location = new System.Drawing.Point(196, 232);
            this.ms_Open_Pic.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.ms_Open_Pic.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_Open_Pic.MS_Change_Border_Color_On_Enter = false;
            this.ms_Open_Pic.MS_Change_Color_On_Enter = false;
            this.ms_Open_Pic.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.ms_Open_Pic.MS_Enter_Color = System.Drawing.Color.Empty;
            this.ms_Open_Pic.Name = "ms_Open_Pic";
            this.ms_Open_Pic.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.ms_Open_Pic.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
            this.ms_Open_Pic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ms_Open_Pic.ShowFocusRectangle = false;
            this.ms_Open_Pic.Size = new System.Drawing.Size(23, 22);
            this.ms_Open_Pic.TabIndex = 816;
            this.ms_Open_Pic.TabStop = false;
            this.ms_Open_Pic.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.ms_Open_Pic.UseThemes = false;
            this.ms_Open_Pic.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ms_Open_Pic.WordWrap = false;
            this.ms_Open_Pic.Click += new System.EventHandler(this.ms_Open_Pic_Click);
            // 
            // ms_Delete_Pic
            // 
            this.ms_Delete_Pic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_Delete_Pic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_Delete_Pic.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_Delete_Pic.Image = global::MS_Resource.GlobalResources._ms_Delete;
            this.ms_Delete_Pic.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Center;
            this.ms_Delete_Pic.Location = new System.Drawing.Point(167, 232);
            this.ms_Delete_Pic.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.ms_Delete_Pic.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_Delete_Pic.MS_Change_Border_Color_On_Enter = false;
            this.ms_Delete_Pic.MS_Change_Color_On_Enter = false;
            this.ms_Delete_Pic.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.ms_Delete_Pic.MS_Enter_Color = System.Drawing.Color.Empty;
            this.ms_Delete_Pic.Name = "ms_Delete_Pic";
            this.ms_Delete_Pic.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.ms_Delete_Pic.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
            this.ms_Delete_Pic.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ms_Delete_Pic.ShowFocusRectangle = false;
            this.ms_Delete_Pic.Size = new System.Drawing.Size(23, 22);
            this.ms_Delete_Pic.TabIndex = 817;
            this.ms_Delete_Pic.TabStop = false;
            this.ms_Delete_Pic.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.ms_Delete_Pic.UseThemes = false;
            this.ms_Delete_Pic.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ms_Delete_Pic.WordWrap = false;
            this.ms_Delete_Pic.Click += new System.EventHandler(this.ms_Delete_Pic_Click);
            // 
            // uiTabPage12
            // 
            this.uiTabPage12.Controls.Add(this.uiGroupBox2);
            this.uiTabPage12.Controls.Add(this.ms_Delete_Pic);
            this.uiTabPage12.Controls.Add(this.ms_Open_Pic);
            this.uiTabPage12.Controls.Add(this.ms_Pic);
            this.uiTabPage12.Location = new System.Drawing.Point(1, 1);
            this.uiTabPage12.Name = "uiTabPage12";
            this.uiTabPage12.PanelFormatStyle.Alpha = 70;
            this.uiTabPage12.PanelFormatStyle.BackColor = System.Drawing.Color.SkyBlue;
            this.uiTabPage12.PanelFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.UseAlpha;
            this.uiTabPage12.PanelFormatStyle.BackgroundGradientMode = Janus.Windows.UI.BackgroundGradientMode.Vertical;
            this.uiTabPage12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiTabPage12.Size = new System.Drawing.Size(570, 266);
            this.uiTabPage12.TabStop = true;
            this.uiTabPage12.Text = "اطلاعات";
            // 
            // uiGroupBox2
            // 
            this.uiGroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.uiGroupBox2.BorderColor = System.Drawing.Color.LightBlue;
            this.uiGroupBox2.Controls.Add(this.ms_Code);
            this.uiGroupBox2.Controls.Add(this.label4);
            this.uiGroupBox2.Controls.Add(this.label7);
            this.uiGroupBox2.Controls.Add(this.ms_Kind);
            this.uiGroupBox2.Controls.Add(this.label6);
            this.uiGroupBox2.Controls.Add(this.ms_Pas_Def);
            this.uiGroupBox2.Controls.Add(this.label3);
            this.uiGroupBox2.Controls.Add(this.ms_User_Name);
            this.uiGroupBox2.Controls.Add(this.label5);
            this.uiGroupBox2.Controls.Add(this.ms_Title);
            this.uiGroupBox2.Controls.Add(this.ms_Is_Disable);
            this.uiGroupBox2.Controls.Add(this.label9);
            this.uiGroupBox2.Location = new System.Drawing.Point(238, 3);
            this.uiGroupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.uiGroupBox2.Name = "uiGroupBox2";
            this.uiGroupBox2.Size = new System.Drawing.Size(323, 258);
            this.uiGroupBox2.TabIndex = 0;
            // 
            // ms_Code
            // 
            this.ms_Code.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_Code.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_Code.DigitGroup = false;
            this.ms_Code.Enabled = false;
            this.ms_Code.Location = new System.Drawing.Point(125, 32);
            this.ms_Code.Mode = MS_Control.Controls.MS_NumericTextBox.TextBoxMode.IntNumber;
            this.ms_Code.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.ms_Code.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_Code.MS_Change_Border_Color_On_Enter = true;
            this.ms_Code.MS_Change_Color_On_Enter = true;
            this.ms_Code.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ms_Code.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_Code.MS_Exit_By_Down = true;
            this.ms_Code.MS_Exit_By_Enter = true;
            this.ms_Code.MS_Exit_By_Up = true;
            this.ms_Code.MS_Is_Negative = false;
            this.ms_Code.MS_Last_Control = null;
            this.ms_Code.MS_Next_Control = null;
            this.ms_Code.Name = "ms_Code";
            this.ms_Code.ReadOnly = true;
            this.ms_Code.Size = new System.Drawing.Size(68, 29);
            this.ms_Code.TabIndex = 0;
            this.ms_Code.TabStop = false;
            this.ms_Code.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.ms_Code.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(194, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 821;
            this.label4.Text = "نــوع کــاربر :";
            // 
            // ms_Kind
            // 
            this.ms_Kind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_Kind.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.ms_Kind.Cursor = System.Windows.Forms.Cursors.Hand;
            uiComboBoxItem3.FormatStyle.Alpha = 0;
            uiComboBoxItem3.Image = ((System.Drawing.Image)(resources.GetObject("uiComboBoxItem3.Image")));
            uiComboBoxItem3.IsSeparator = false;
            uiComboBoxItem3.Text = "مدیر سیستم";
            uiComboBoxItem4.FormatStyle.Alpha = 0;
            uiComboBoxItem4.Image = ((System.Drawing.Image)(resources.GetObject("uiComboBoxItem4.Image")));
            uiComboBoxItem4.IsSeparator = false;
            uiComboBoxItem4.Text = "کاربر ارشد";
            uiComboBoxItem5.FormatStyle.Alpha = 0;
            uiComboBoxItem5.Image = ((System.Drawing.Image)(resources.GetObject("uiComboBoxItem5.Image")));
            uiComboBoxItem5.IsSeparator = false;
            uiComboBoxItem5.Text = "کاربر عادی";
            this.ms_Kind.Items.AddRange(new Janus.Windows.EditControls.UIComboBoxItem[] {
            uiComboBoxItem3,
            uiComboBoxItem4,
            uiComboBoxItem5});
            this.ms_Kind.Location = new System.Drawing.Point(64, 205);
            this.ms_Kind.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.ms_Kind.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_Kind.MS_Change_Border_Color_On_Enter = true;
            this.ms_Kind.MS_Change_Color_On_Enter = true;
            this.ms_Kind.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ms_Kind.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_Kind.MS_Exit_By_Down = true;
            this.ms_Kind.MS_Exit_By_Enter = true;
            this.ms_Kind.MS_Exit_By_Up = true;
            this.ms_Kind.MS_Last_Control = null;
            this.ms_Kind.MS_Next_Control = null;
            this.ms_Kind.Name = "ms_Kind";
            this.ms_Kind.Size = new System.Drawing.Size(128, 29);
            this.ms_Kind.TabIndex = 5;
            this.ms_Kind.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // ms_Pas_Def
            // 
            this.ms_Pas_Def.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_Pas_Def.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_Pas_Def.Location = new System.Drawing.Point(45, 136);
            this.ms_Pas_Def.MaxLength = 200;
            this.ms_Pas_Def.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.ms_Pas_Def.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_Pas_Def.MS_Change_Border_Color_On_Enter = true;
            this.ms_Pas_Def.MS_Change_Color_On_Enter = true;
            this.ms_Pas_Def.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ms_Pas_Def.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_Pas_Def.MS_Exit_By_Down = true;
            this.ms_Pas_Def.MS_Exit_By_Enter = true;
            this.ms_Pas_Def.MS_Exit_By_Up = true;
            this.ms_Pas_Def.MS_Last_Control = null;
            this.ms_Pas_Def.MS_Next_Control = null;
            this.ms_Pas_Def.Name = "ms_Pas_Def";
            this.ms_Pas_Def.Size = new System.Drawing.Size(148, 29);
            this.ms_Pas_Def.TabIndex = 2;
            // 
            // ms_User_Name
            // 
            this.ms_User_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_User_Name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_User_Name.Location = new System.Drawing.Point(45, 101);
            this.ms_User_Name.MaxLength = 100;
            this.ms_User_Name.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.ms_User_Name.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_User_Name.MS_Change_Border_Color_On_Enter = true;
            this.ms_User_Name.MS_Change_Color_On_Enter = true;
            this.ms_User_Name.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ms_User_Name.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_User_Name.MS_Exit_By_Down = true;
            this.ms_User_Name.MS_Exit_By_Enter = true;
            this.ms_User_Name.MS_Exit_By_Up = true;
            this.ms_User_Name.MS_Last_Control = null;
            this.ms_User_Name.MS_Next_Control = null;
            this.ms_User_Name.Name = "ms_User_Name";
            this.ms_User_Name.Size = new System.Drawing.Size(148, 29);
            this.ms_User_Name.TabIndex = 1;
            // 
            // ms_Title
            // 
            this.ms_Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_Title.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_Title.Location = new System.Drawing.Point(20, 67);
            this.ms_Title.MaxLength = 200;
            this.ms_Title.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.ms_Title.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_Title.MS_Change_Border_Color_On_Enter = true;
            this.ms_Title.MS_Change_Color_On_Enter = true;
            this.ms_Title.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ms_Title.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_Title.MS_Exit_By_Down = true;
            this.ms_Title.MS_Exit_By_Enter = true;
            this.ms_Title.MS_Exit_By_Up = true;
            this.ms_Title.MS_Last_Control = null;
            this.ms_Title.MS_Next_Control = null;
            this.ms_Title.Name = "ms_Title";
            this.ms_Title.Size = new System.Drawing.Size(173, 29);
            this.ms_Title.TabIndex = 0;
            // 
            // ms_Exit
            // 
            this.ms_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_Exit.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_Exit.Image = global::MS_Resource.GlobalResources._ms_Back;
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
            // ms_Save
            // 
            this.ms_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_Save.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_Save.Image = global::MS_Resource.GlobalResources._ms_Save;
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
            // Panel_Foother
            // 
            this.Panel_Foother.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Panel_Foother.Controls.Add(this.ms_Save);
            this.Panel_Foother.Controls.Add(this.ms_Exit);
            this.Panel_Foother.Location = new System.Drawing.Point(1, 267);
            this.Panel_Foother.MS_BorderColor = System.Drawing.Color.DarkGray;
            this.Panel_Foother.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.Panel_Foother.MS_Color_End = System.Drawing.Color.Gainsboro;
            this.Panel_Foother.MS_Color_Start = System.Drawing.Color.WhiteSmoke;
            this.Panel_Foother.Name = "Panel_Foother";
            this.Panel_Foother.Size = new System.Drawing.Size(572, 48);
            this.Panel_Foother.TabIndex = 1;
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
            this.uiTabPage14.Size = new System.Drawing.Size(570, 266);
            this.uiTabPage14.TabStop = true;
            this.uiTabPage14.Text = "پرسش و پاسخ";
            // 
            // Tab_Control_Main
            // 
            this.Tab_Control_Main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tab_Control_Main.BackColor = System.Drawing.Color.Transparent;
            this.Tab_Control_Main.Location = new System.Drawing.Point(1, 0);
            this.Tab_Control_Main.MultiLine = true;
            this.Tab_Control_Main.Name = "Tab_Control_Main";
            this.Tab_Control_Main.Office2007CustomColor = System.Drawing.Color.Transparent;
            this.Tab_Control_Main.ShowFocusRectangle = false;
            this.Tab_Control_Main.Size = new System.Drawing.Size(602, 268);
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
            // Form_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 315);
            this.Controls.Add(this.Panel_Foother);
            this.Controls.Add(this.Tab_Control_Main);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_User";
            this.Text = "کــاربــران";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.ms_Pic)).EndInit();
            this.uiTabPage12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox2)).EndInit();
            this.uiGroupBox2.ResumeLayout(false);
            this.uiGroupBox2.PerformLayout();
            this.Panel_Foother.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Tab_Control_Main)).EndInit();
            this.Tab_Control_Main.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private MS_Control.Controls.MS_ComboBox_Janus ms_Is_Disable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox ms_Pic;
        private MS_Control.Controls.MS_Button_GridX ms_Open_Pic;
        private MS_Control.Controls.MS_Button_GridX ms_Delete_Pic;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage12;
        private MS_Control.Controls.MS_Button_GridX ms_Exit;
        private MS_Control.Controls.MS_Button_GridX ms_Save;
        private MS_Control.Controls.MS_Panel Panel_Foother;
        private Janus.Windows.UI.Tab.UITabPage uiTabPage14;
        private Janus.Windows.UI.Tab.UITab Tab_Control_Main;
        private MS_Control.Controls.MS_TextBox ms_Pas_Def;
        private MS_Control.Controls.MS_TextBox ms_User_Name;
        private MS_Control.Controls.MS_TextBox ms_Title;
        private MS_Control.Controls.MS_NumericTextBox ms_Code;
        private System.Windows.Forms.Label label4;
        private MS_Control.Controls.MS_ComboBox_Janus ms_Kind;
        private MS_Control.Controls.MS_Notify mS_Notify1;
        private Janus.Windows.EditControls.UIGroupBox uiGroupBox2;
    }
}