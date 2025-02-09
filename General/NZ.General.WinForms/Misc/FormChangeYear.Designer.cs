namespace NZ.General.WinForms.Misc
{
    partial class FormChangeYear
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
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.NzSalmali = new MS_Control.Controls.MS_ComboBox_Janus();
            this.NzCurrentYear = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ms_login = new MS_Control.Controls.MS_Button_GridX();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiGroupBox1.BorderColor = System.Drawing.Color.SteelBlue;
            this.uiGroupBox1.Controls.Add(this.NzSalmali);
            this.uiGroupBox1.Controls.Add(this.NzCurrentYear);
            this.uiGroupBox1.Controls.Add(this.label3);
            this.uiGroupBox1.Controls.Add(this.label4);
            this.uiGroupBox1.ImageAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.uiGroupBox1.ImageSize = new System.Drawing.Size(24, 24);
            this.uiGroupBox1.Location = new System.Drawing.Point(5, 3);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.uiGroupBox1.Size = new System.Drawing.Size(240, 130);
            this.uiGroupBox1.TabIndex = 2;
            this.uiGroupBox1.UseThemes = false;
            this.uiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.VS2005;
            // 
            // NzSalmali
            // 
            this.NzSalmali.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzSalmali.ComboStyle = Janus.Windows.EditControls.ComboStyle.DropDownList;
            this.NzSalmali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NzSalmali.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F);
            this.NzSalmali.HoverMode = Janus.Windows.EditControls.HoverMode.Highlight;
            this.NzSalmali.Location = new System.Drawing.Point(34, 79);
            this.NzSalmali.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.NzSalmali.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.NzSalmali.MS_Change_Border_Color_On_Enter = true;
            this.NzSalmali.MS_Change_Color_On_Enter = true;
            this.NzSalmali.MS_Enter_Border_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.NzSalmali.MS_Enter_Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.NzSalmali.MS_Exit_By_Down = false;
            this.NzSalmali.MS_Exit_By_Enter = true;
            this.NzSalmali.MS_Exit_By_Up = false;
            this.NzSalmali.MS_Last_Control = null;
            this.NzSalmali.MS_Next_Control = null;
            this.NzSalmali.Name = "NzSalmali";
            this.NzSalmali.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzSalmali.Size = new System.Drawing.Size(74, 29);
            this.NzSalmali.TabIndex = 81;
            this.NzSalmali.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            // 
            // NzCurrentYear
            // 
            this.NzCurrentYear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NzCurrentYear.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
            this.NzCurrentYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.NzCurrentYear.Location = new System.Drawing.Point(34, 23);
            this.NzCurrentYear.Name = "NzCurrentYear";
            this.NzCurrentYear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzCurrentYear.Size = new System.Drawing.Size(74, 23);
            this.NzCurrentYear.TabIndex = 80;
            this.NzCurrentYear.Text = "1397";
            this.NzCurrentYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
            this.label3.Location = new System.Drawing.Point(113, 23);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 80;
            this.label3.Text = "سال مالی فعلی :";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("IRANSans(Small)", 14F);
            this.label4.Location = new System.Drawing.Point(113, 82);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(101, 23);
            this.label4.TabIndex = 79;
            this.label4.Text = "سال مالی جدید :";
            // 
            // ms_login
            // 
            this.ms_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ms_login.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ms_login.Font = new System.Drawing.Font("Tahoma", 9.5F);
            this.ms_login.Image = global::MS_Resource.GlobalResources.Negin__26_;
            this.ms_login.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.ms_login.Location = new System.Drawing.Point(5, 143);
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
            this.ms_login.Size = new System.Drawing.Size(136, 33);
            this.ms_login.TabIndex = 3;
            this.ms_login.Text = "تغـییر سال مالی";
            this.ms_login.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.ms_login.UseThemes = false;
            this.ms_login.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.ms_login.WordWrap = false;
            this.ms_login.Click += new System.EventHandler(this.ms_login_Click);
            // 
            // FormChangeYear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 188);
            this.Controls.Add(this.uiGroupBox1);
            this.Controls.Add(this.ms_login);
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChangeYear";
            this.Text = "تغـییر سال مـالی جاری";
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private MS_Control.Controls.MS_Button_GridX ms_login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private MS_Control.Controls.MS_ComboBox_Janus NzSalmali;
        private System.Windows.Forms.Label NzCurrentYear;
    }
}