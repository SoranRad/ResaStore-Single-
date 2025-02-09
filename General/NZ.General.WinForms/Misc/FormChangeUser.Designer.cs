namespace NZ.General.WinForms.Misc
{
    partial class FormChangeUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangeUser));
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.NzUserName = new MS_Control.Controls.MS_TextBox();
            this.NzPass = new MS_Control.Controls.MS_TextBox();
            this.ms_login = new MS_Control.Controls.MS_Button_GridX();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mS_Notify1 = new MS_Control.Controls.MS_Notify();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiGroupBox1.BorderColor = System.Drawing.Color.SteelBlue;
            this.uiGroupBox1.Controls.Add(this.NzUserName);
            this.uiGroupBox1.Controls.Add(this.label3);
            this.uiGroupBox1.Controls.Add(this.label4);
            this.uiGroupBox1.Controls.Add(this.NzPass);
            this.uiGroupBox1.ImageAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.uiGroupBox1.ImageSize = new System.Drawing.Size(24, 24);
            this.uiGroupBox1.Location = new System.Drawing.Point(6, 2);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiGroupBox1.Size = new System.Drawing.Size(301, 130);
            this.uiGroupBox1.TabIndex = 0;
            this.uiGroupBox1.UseThemes = false;
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.VS2005;
            // 
            // NzUserName
            // 
            this.NzUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzUserName.ButtonImage = ((System.Drawing.Image)(resources.GetObject("NzUserName.ButtonImage")));
            this.NzUserName.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image;
            this.NzUserName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzUserName.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
            this.NzUserName.Location = new System.Drawing.Point(31, 30);
            this.NzUserName.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzUserName.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzUserName.MS_Change_Border_Color_On_Enter = true;
            this.NzUserName.MS_Change_Color_On_Enter = true;
            this.NzUserName.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.NzUserName.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NzUserName.MS_Exit_By_Down = true;
            this.NzUserName.MS_Exit_By_Enter = true;
            this.NzUserName.MS_Exit_By_Up = true;
            this.NzUserName.MS_Last_Control = null;
            this.NzUserName.MS_Next_Control = this.NzPass;
            this.NzUserName.Name = "NzUserName";
            this.NzUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzUserName.Size = new System.Drawing.Size(157, 31);
            this.NzUserName.TabIndex = 0;
            this.NzUserName.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // NzPass
            // 
            this.NzPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzPass.ButtonImage = ((System.Drawing.Image)(resources.GetObject("NzPass.ButtonImage")));
            this.NzPass.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image;
            this.NzPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzPass.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
            this.NzPass.ImageHorizontalAlignment = Janus.Windows.GridEX.ImageHorizontalAlignment.Near;
            this.NzPass.Location = new System.Drawing.Point(31, 75);
            this.NzPass.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzPass.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzPass.MS_Change_Border_Color_On_Enter = true;
            this.NzPass.MS_Change_Color_On_Enter = true;
            this.NzPass.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.NzPass.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NzPass.MS_Exit_By_Down = true;
            this.NzPass.MS_Exit_By_Enter = true;
            this.NzPass.MS_Exit_By_Up = true;
            this.NzPass.MS_Last_Control = this.NzUserName;
            this.NzPass.MS_Next_Control = this.ms_login;
            this.NzPass.Name = "NzPass";
            this.NzPass.PasswordChar = '*';
            this.NzPass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzPass.Size = new System.Drawing.Size(157, 31);
            this.NzPass.TabIndex = 1;
            this.NzPass.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2007;
            // 
            // ms_login
            // 
            this.ms_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ms_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_login.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_login.Font = new System.Drawing.Font("IRANSans(Small)", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ms_login.Image = global::MS_Resource.GlobalResources.Negin__31_;
            this.ms_login.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.ms_login.Location = new System.Drawing.Point(6, 138);
            this.ms_login.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.ms_login.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.ms_login.MS_Change_Border_Color_On_Enter = false;
            this.ms_login.MS_Change_Color_On_Enter = false;
            this.ms_login.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.ms_login.MS_Enter_Color = System.Drawing.Color.Empty;
            this.ms_login.Name = "ms_login";
            this.ms_login.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.ms_login.Office2007CustomColor = System.Drawing.Color.LightBlue;
            this.ms_login.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ms_login.ShowFocusRectangle = false;
            this.ms_login.Size = new System.Drawing.Size(129, 33);
            this.ms_login.TabIndex = 1;
            this.ms_login.Text = "تغـییر کاربر";
            this.ms_login.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.ms_login.UseThemes = false;
            this.ms_login.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ms_login.WordWrap = false;
            this.ms_login.Click += new System.EventHandler(this.ms_login_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
            this.label3.Location = new System.Drawing.Point(188, 34);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 80;
            this.label3.Text = "نام کاربری :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
            this.label4.Location = new System.Drawing.Point(188, 79);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(66, 23);
            this.label4.TabIndex = 79;
            this.label4.Text = "کلمه عبور :";
            // 
            // FormChangeUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 178);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.ms_login);
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChangeUser";
            this.Text = "تغییر کاربر جاری";
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private MS_Control.Controls.MS_TextBox NzUserName;
        private MS_Control.Controls.MS_TextBox NzPass;
        private MS_Control.Controls.MS_Button_GridX ms_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MS_Control.Controls.MS_Notify mS_Notify1;
    }
}