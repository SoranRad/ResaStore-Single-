namespace NZ.General.WinForms.Misc
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.NzUserName = new MS_Control.Controls.MS_TextBox();
            this.NzSalmali = new MS_Control.Controls.MS_ComboBox_Janus();
            this.NzPass = new MS_Control.Controls.MS_TextBox();
            this.NzLogin = new MS_Control.Controls.MS_Button_GridX();
            this.label2 = new System.Windows.Forms.Label();
            this.mS_Notify1 = new MS_Control.Controls.MS_Notify();
            this.NzTitleCompany = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.NzLabelCompany = new System.Windows.Forms.Label();
            this.NzCompany = new MS_Control.Controls.MS_ComboBox_Janus();
            this.NzActivation = new MS_Control.Controls.MS_Button_GridX();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // NzUserName
            // 
            this.NzUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            this.NzUserName.BorderStyle = Janus.Windows.GridEX.BorderStyle.None;
            this.NzUserName.ButtonImage = ((System.Drawing.Image)(resources.GetObject("NzUserName.ButtonImage")));
            this.NzUserName.ControlStyle.HoverBaseColor = System.Drawing.SystemColors.ControlDark;
            this.NzUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzUserName.FlatBorderColor = System.Drawing.SystemColors.ScrollBar;
            this.NzUserName.Font = new System.Drawing.Font("IRANSans(Small) Medium", 15F);
            this.NzUserName.ForeColor = System.Drawing.Color.Black;
            this.NzUserName.Location = new System.Drawing.Point(475, 209);
            this.NzUserName.MS_BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.NzUserName.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
            this.NzUserName.MS_Change_Border_Color_On_Enter = true;
            this.NzUserName.MS_Change_Color_On_Enter = true;
            this.NzUserName.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.NzUserName.MS_Enter_Color = System.Drawing.Color.Silver;
            this.NzUserName.MS_Exit_By_Down = true;
            this.NzUserName.MS_Exit_By_Enter = true;
            this.NzUserName.MS_Exit_By_Up = true;
            this.NzUserName.MS_Last_Control = this.NzSalmali;
            this.NzUserName.MS_Next_Control = this.NzPass;
            this.NzUserName.Name = "NzUserName";
            this.NzUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzUserName.Size = new System.Drawing.Size(232, 30);
            this.NzUserName.TabIndex = 0;
            this.NzUserName.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.NzUserName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // NzSalmali
            // 
            this.NzSalmali.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzSalmali.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            this.NzSalmali.BorderStyle = Janus.Windows.UI.BorderStyle.None;
            this.NzSalmali.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.NzSalmali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzSalmali.FlatBorderColor = System.Drawing.SystemColors.ControlDark;
            this.NzSalmali.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F);
            this.NzSalmali.HoverMode = Janus.Windows.EditControls.HoverMode.Highlight;
            this.NzSalmali.Location = new System.Drawing.Point(614, 157);
            this.NzSalmali.MS_BorderColor = System.Drawing.Color.Silver;
            this.NzSalmali.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzSalmali.MS_Change_Border_Color_On_Enter = true;
            this.NzSalmali.MS_Change_Color_On_Enter = true;
            this.NzSalmali.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.NzSalmali.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NzSalmali.MS_Exit_By_Down = false;
            this.NzSalmali.MS_Exit_By_Enter = true;
            this.NzSalmali.MS_Exit_By_Up = false;
            this.NzSalmali.MS_Last_Control = null;
            this.NzSalmali.MS_Next_Control = this.NzUserName;
            this.NzSalmali.Name = "NzSalmali";
            this.NzSalmali.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver;
            this.NzSalmali.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzSalmali.Size = new System.Drawing.Size(93, 29);
            this.NzSalmali.TabIndex = 3;
            this.NzSalmali.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // NzPass
            // 
            this.NzPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            this.NzPass.BorderStyle = Janus.Windows.GridEX.BorderStyle.None;
            this.NzPass.ButtonImage = ((System.Drawing.Image)(resources.GetObject("NzPass.ButtonImage")));
            this.NzPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzPass.Font = new System.Drawing.Font("IRANSans(Small) Medium", 14F);
            this.NzPass.ForeColor = System.Drawing.Color.Black;
            this.NzPass.ImageHorizontalAlignment = Janus.Windows.GridEX.ImageHorizontalAlignment.Near;
            this.NzPass.Location = new System.Drawing.Point(475, 280);
            this.NzPass.MS_BorderColor = System.Drawing.Color.Empty;
            this.NzPass.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.None;
            this.NzPass.MS_Change_Border_Color_On_Enter = true;
            this.NzPass.MS_Change_Color_On_Enter = true;
            this.NzPass.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.NzPass.MS_Enter_Color = System.Drawing.Color.Silver;
            this.NzPass.MS_Exit_By_Down = true;
            this.NzPass.MS_Exit_By_Enter = true;
            this.NzPass.MS_Exit_By_Up = true;
            this.NzPass.MS_Last_Control = this.NzUserName;
            this.NzPass.MS_Next_Control = this.NzLogin;
            this.NzPass.Name = "NzPass";
            this.NzPass.PasswordChar = '●';
            this.NzPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzPass.Size = new System.Drawing.Size(232, 28);
            this.NzPass.TabIndex = 1;
            this.NzPass.TextAlignment = Janus.Windows.GridEX.TextAlignment.Center;
            this.NzPass.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // NzLogin
            // 
            this.NzLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NzLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzLogin.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NzLogin.Font = new System.Drawing.Font("IRANSans(Small) Medium", 14F);
            this.NzLogin.Image = global::MS_Resource.GlobalResources.Negin__38_;
            this.NzLogin.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.NzLogin.Location = new System.Drawing.Point(430, 331);
            this.NzLogin.MS_BorderColor = System.Drawing.Color.Empty;
            this.NzLogin.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzLogin.MS_Change_Border_Color_On_Enter = false;
            this.NzLogin.MS_Change_Color_On_Enter = false;
            this.NzLogin.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.NzLogin.MS_Enter_Color = System.Drawing.Color.Empty;
            this.NzLogin.Name = "NzLogin";
            this.NzLogin.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.NzLogin.Office2007CustomColor = System.Drawing.Color.RoyalBlue;
            this.NzLogin.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzLogin.ShowFocusRectangle = false;
            this.NzLogin.Size = new System.Drawing.Size(169, 35);
            this.NzLogin.StateStyles.FormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(155)))), ((int)(((byte)(209)))));
            this.NzLogin.StateStyles.FormatStyle.BackColorGradient = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(131)))), ((int)(((byte)(178)))));
            this.NzLogin.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.White;
            this.NzLogin.StateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.NzLogin.StateStyles.SelectedFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.Opaque;
            this.NzLogin.StateStyles.SelectedFormatStyle.BackColorGradient = System.Drawing.Color.DeepSkyBlue;
            this.NzLogin.StateStyles.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.NzLogin.TabIndex = 2;
            this.NzLogin.Text = "ورود به سیـستم";
            this.NzLogin.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.NzLogin.UseThemes = false;
            this.NzLogin.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005;
            this.NzLogin.WordWrap = false;
            this.NzLogin.Click += new System.EventHandler(this.NzLogin_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("IRANSans(Small) Medium", 14F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label2.Location = new System.Drawing.Point(712, 160);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 76;
            this.label2.Text = "سال مالی :";
            // 
            // NzTitleCompany
            // 
            this.NzTitleCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NzTitleCompany.BackColor = System.Drawing.Color.Transparent;
            this.NzTitleCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NzTitleCompany.Font = new System.Drawing.Font("IRANSans(FaNum)", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(178)));
            this.NzTitleCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(129)))), ((int)(((byte)(183)))));
            this.NzTitleCompany.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NzTitleCompany.Location = new System.Drawing.Point(413, 70);
            this.NzTitleCompany.Name = "NzTitleCompany";
            this.NzTitleCompany.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzTitleCompany.Size = new System.Drawing.Size(417, 40);
            this.NzTitleCompany.TabIndex = 81;
            this.NzTitleCompany.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::MS_Resource.GlobalResources.support;
            this.pictureBox1.Location = new System.Drawing.Point(24, 402);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.NzSupport_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::MS_Resource.GlobalResources.Negin__50_;
            this.pictureBox2.Location = new System.Drawing.Point(64, 402);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 82;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.NzRestore_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::MS_Resource.GlobalResources.help;
            this.pictureBox3.Location = new System.Drawing.Point(104, 402);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 82;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.NzInfo_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Location = new System.Drawing.Point(802, 22);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(28, 27);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 82;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseEnter += new System.EventHandler(this.pictureBox4_MouseEnter);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            // 
            // NzLabelCompany
            // 
            this.NzLabelCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzLabelCompany.AutoSize = true;
            this.NzLabelCompany.BackColor = System.Drawing.Color.Transparent;
            this.NzLabelCompany.Font = new System.Drawing.Font("IRANSans(Small) Medium", 14F);
            this.NzLabelCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.NzLabelCompany.Location = new System.Drawing.Point(712, 116);
            this.NzLabelCompany.Name = "NzLabelCompany";
            this.NzLabelCompany.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzLabelCompany.Size = new System.Drawing.Size(61, 24);
            this.NzLabelCompany.TabIndex = 76;
            this.NzLabelCompany.Text = "شـرکـت :";
            this.NzLabelCompany.Visible = false;
            // 
            // NzCompany
            // 
            this.NzCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(238)))), ((int)(((byte)(240)))));
            this.NzCompany.BorderStyle = Janus.Windows.UI.BorderStyle.None;
            this.NzCompany.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.NzCompany.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzCompany.FlatBorderColor = System.Drawing.SystemColors.ControlDark;
            this.NzCompany.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F);
            this.NzCompany.HoverMode = Janus.Windows.EditControls.HoverMode.Highlight;
            this.NzCompany.Location = new System.Drawing.Point(430, 113);
            this.NzCompany.MS_BorderColor = System.Drawing.Color.Silver;
            this.NzCompany.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzCompany.MS_Change_Border_Color_On_Enter = true;
            this.NzCompany.MS_Change_Color_On_Enter = true;
            this.NzCompany.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.NzCompany.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NzCompany.MS_Exit_By_Down = false;
            this.NzCompany.MS_Exit_By_Enter = true;
            this.NzCompany.MS_Exit_By_Up = false;
            this.NzCompany.MS_Last_Control = null;
            this.NzCompany.MS_Next_Control = null;
            this.NzCompany.Name = "NzCompany";
            this.NzCompany.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Silver;
            this.NzCompany.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzCompany.Size = new System.Drawing.Size(277, 29);
            this.NzCompany.TabIndex = 3;
            this.NzCompany.Visible = false;
            this.NzCompany.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // NzActivation
            // 
            this.NzActivation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NzActivation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzActivation.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NzActivation.Font = new System.Drawing.Font("IRANSans(Small) Medium", 14F);
            this.NzActivation.Image = global::MS_Resource.GlobalResources.Toolbar2;
            this.NzActivation.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.NzActivation.Location = new System.Drawing.Point(659, 331);
            this.NzActivation.MS_BorderColor = System.Drawing.Color.Empty;
            this.NzActivation.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzActivation.MS_Change_Border_Color_On_Enter = false;
            this.NzActivation.MS_Change_Color_On_Enter = false;
            this.NzActivation.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.NzActivation.MS_Enter_Color = System.Drawing.Color.Empty;
            this.NzActivation.Name = "NzActivation";
            this.NzActivation.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.NzActivation.Office2007CustomColor = System.Drawing.Color.DarkOrange;
            this.NzActivation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzActivation.ShowFocusRectangle = false;
            this.NzActivation.Size = new System.Drawing.Size(135, 35);
            this.NzActivation.StateStyles.FormatStyle.BackColor = System.Drawing.Color.LimeGreen;
            this.NzActivation.StateStyles.FormatStyle.BackColorGradient = System.Drawing.Color.ForestGreen;
            this.NzActivation.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.White;
            this.NzActivation.StateStyles.SelectedFormatStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NzActivation.StateStyles.SelectedFormatStyle.BackColorAlphaMode = Janus.Windows.UI.AlphaMode.Opaque;
            this.NzActivation.StateStyles.SelectedFormatStyle.BackColorGradient = System.Drawing.Color.Gold;
            this.NzActivation.StateStyles.SelectedFormatStyle.ForeColor = System.Drawing.Color.Black;
            this.NzActivation.TabIndex = 83;
            this.NzActivation.Text = "فعال سازی";
            this.NzActivation.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.NzActivation.UseThemes = false;
            this.NzActivation.Visible = false;
            this.NzActivation.VisualStyle = Janus.Windows.UI.VisualStyle.VS2005;
            this.NzActivation.WordWrap = false;
            this.NzActivation.Click += new System.EventHandler(this.NzActivation_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Location = new System.Drawing.Point(6, 83);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(414, 309);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 84;
            this.pictureBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(475, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(232, 2);
            this.label1.TabIndex = 85;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Location = new System.Drawing.Point(475, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 2);
            this.label3.TabIndex = 85;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("IRANSans(Small) Medium", 14F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label4.Location = new System.Drawing.Point(712, 197);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(69, 47);
            this.label4.TabIndex = 86;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("IRANSans(Small) Medium", 14F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.label5.Location = new System.Drawing.Point(712, 267);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(69, 47);
            this.label5.TabIndex = 86;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(838, 437);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.NzActivation);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.NzUserName);
            this.Controls.Add(this.NzTitleCompany);
            this.Controls.Add(this.NzCompany);
            this.Controls.Add(this.NzSalmali);
            this.Controls.Add(this.NzLabelCompany);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NzPass);
            this.Controls.Add(this.NzLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.ShowIcon = false;
            this.Text = "";
            this.Shown += new System.EventHandler(this.FormLogin_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MS_Control.Controls.MS_TextBox NzUserName;
        private MS_Control.Controls.MS_ComboBox_Janus NzSalmali;
        private MS_Control.Controls.MS_TextBox NzPass;
        private MS_Control.Controls.MS_Button_GridX NzLogin;
        private System.Windows.Forms.Label label2;
        private MS_Control.Controls.MS_Notify mS_Notify1;
        private System.Windows.Forms.Label NzTitleCompany;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label NzLabelCompany;
        private MS_Control.Controls.MS_ComboBox_Janus NzCompany;
        private MS_Control.Controls.MS_Button_GridX NzActivation;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}