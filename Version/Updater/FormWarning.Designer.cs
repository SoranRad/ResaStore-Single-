namespace Updater
{
    partial class FormWarning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWarning));
            this.uiGroupBox1 = new Janus.Windows.EditControls.UIGroupBox();
            this.NzNewVersion = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NzCurrentVersion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Nz_Cancel = new MS_Control.Controls.MS_Button_GridX();
            this.Nz_OK = new MS_Control.Controls.MS_Button_GridX();
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).BeginInit();
            this.uiGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiGroupBox1
            // 
            this.uiGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uiGroupBox1.Controls.Add(this.NzNewVersion);
            this.uiGroupBox1.Controls.Add(this.label3);
            this.uiGroupBox1.Controls.Add(this.NzCurrentVersion);
            this.uiGroupBox1.Controls.Add(this.label2);
            this.uiGroupBox1.Controls.Add(this.label1);
            this.uiGroupBox1.Controls.Add(this.Nz_Cancel);
            this.uiGroupBox1.Controls.Add(this.Nz_OK);
            this.uiGroupBox1.Location = new System.Drawing.Point(7, -3);
            this.uiGroupBox1.Name = "uiGroupBox1";
            this.uiGroupBox1.Size = new System.Drawing.Size(342, 167);
            this.uiGroupBox1.TabIndex = 0;
            // 
            // NzNewVersion
            // 
            this.NzNewVersion.ForeColor = System.Drawing.Color.Green;
            this.NzNewVersion.Location = new System.Drawing.Point(127, 97);
            this.NzNewVersion.Name = "NzNewVersion";
            this.NzNewVersion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzNewVersion.Size = new System.Drawing.Size(100, 23);
            this.NzNewVersion.TabIndex = 6;
            this.NzNewVersion.Text = ".";
            this.NzNewVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(233, 97);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "نسخه بروزرسانی :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NzCurrentVersion
            // 
            this.NzCurrentVersion.Location = new System.Drawing.Point(127, 65);
            this.NzCurrentVersion.Name = "NzCurrentVersion";
            this.NzCurrentVersion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NzCurrentVersion.Size = new System.Drawing.Size(100, 23);
            this.NzCurrentVersion.TabIndex = 6;
            this.NzCurrentVersion.Text = ".";
            this.NzCurrentVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 65);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "نسخه فعلی :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(326, 47);
            this.label1.TabIndex = 5;
            this.label1.Text = "نسخه جدیدی از برنامه موجود است.\r\n آیا مایلید برنامه را بروزرسانی کنید ؟";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Nz_Cancel
            // 
            this.Nz_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Nz_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nz_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Nz_Cancel.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Nz_Cancel.Font = new System.Drawing.Font("IRANSans(Small)", 12F);
            this.Nz_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("Nz_Cancel.Image")));
            this.Nz_Cancel.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.Nz_Cancel.Location = new System.Drawing.Point(206, 135);
            this.Nz_Cancel.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.Nz_Cancel.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.Nz_Cancel.MS_Change_Border_Color_On_Enter = false;
            this.Nz_Cancel.MS_Change_Color_On_Enter = false;
            this.Nz_Cancel.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.Nz_Cancel.MS_Enter_Color = System.Drawing.Color.Empty;
            this.Nz_Cancel.Name = "Nz_Cancel";
            this.Nz_Cancel.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.Nz_Cancel.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
            this.Nz_Cancel.ShowFocusRectangle = false;
            this.Nz_Cancel.Size = new System.Drawing.Size(110, 27);
            this.Nz_Cancel.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.Maroon;
            this.Nz_Cancel.TabIndex = 1;
            this.Nz_Cancel.Text = "خیر";
            this.Nz_Cancel.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.Nz_Cancel.UseThemes = false;
            this.Nz_Cancel.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.Nz_Cancel.WordWrap = false;
            this.Nz_Cancel.Click += new System.EventHandler(this.Nz_Cancel_Click);
            // 
            // Nz_OK
            // 
            this.Nz_OK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Nz_OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nz_OK.FlatBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Nz_OK.Font = new System.Drawing.Font("IRANSans(Small)", 12F);
            this.Nz_OK.Image = ((System.Drawing.Image)(resources.GetObject("Nz_OK.Image")));
            this.Nz_OK.ImageHorizontalAlignment = Janus.Windows.EditControls.ImageHorizontalAlignment.Far;
            this.Nz_OK.Location = new System.Drawing.Point(16, 135);
            this.Nz_OK.MS_BorderColor = System.Drawing.Color.SteelBlue;
            this.Nz_OK.MS_BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.Nz_OK.MS_Change_Border_Color_On_Enter = false;
            this.Nz_OK.MS_Change_Color_On_Enter = false;
            this.Nz_OK.MS_Enter_Border_Color = System.Drawing.Color.Empty;
            this.Nz_OK.MS_Enter_Color = System.Drawing.Color.Empty;
            this.Nz_OK.Name = "Nz_OK";
            this.Nz_OK.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
            this.Nz_OK.Office2007CustomColor = System.Drawing.Color.DodgerBlue;
            this.Nz_OK.ShowFocusRectangle = false;
            this.Nz_OK.Size = new System.Drawing.Size(139, 27);
            this.Nz_OK.StateStyles.FormatStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Nz_OK.TabIndex = 0;
            this.Nz_OK.Text = "بله (بروزرسانی شود)";
            this.Nz_OK.TextHorizontalAlignment = Janus.Windows.EditControls.TextAlignment.Near;
            this.Nz_OK.UseThemes = false;
            this.Nz_OK.VisualStyle = Janus.Windows.UI.VisualStyle.Office2007;
            this.Nz_OK.WordWrap = false;
            this.Nz_OK.Click += new System.EventHandler(this.Nz_OK_Click);
            // 
            // FormWarning
            // 
            this.AcceptButton = this.Nz_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Nz_Cancel;
            this.ClientSize = new System.Drawing.Size(358, 168);
            this.ControlBox = false;
            this.Controls.Add(this.uiGroupBox1);
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.Name = "FormWarning";
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "بروزرسانی برنامه";
            ((System.ComponentModel.ISupportInitialize)(this.uiGroupBox1)).EndInit();
            this.uiGroupBox1.ResumeLayout(false);
            this.uiGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Janus.Windows.EditControls.UIGroupBox uiGroupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private MS_Control.Controls.MS_Button_GridX Nz_Cancel;
        private MS_Control.Controls.MS_Button_GridX Nz_OK;
        private System.Windows.Forms.Label NzNewVersion;
        private System.Windows.Forms.Label NzCurrentVersion;
    }
}