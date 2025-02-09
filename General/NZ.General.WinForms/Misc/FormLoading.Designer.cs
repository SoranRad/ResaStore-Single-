namespace NZ.General.WinForms.Misc
{
    partial class FormLoading
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLoading));
			this.NzTitle = new System.Windows.Forms.Label();
			this.NzProgress = new Janus.Windows.EditControls.UIProgressBar();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// NzTitle
			// 
			this.NzTitle.BackColor = System.Drawing.Color.Transparent;
			this.NzTitle.Font = new System.Drawing.Font("IRANSans(Small) Medium", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NzTitle.Location = new System.Drawing.Point(6, 388);
			this.NzTitle.Name = "NzTitle";
			this.NzTitle.Size = new System.Drawing.Size(423, 28);
			this.NzTitle.TabIndex = 4;
			this.NzTitle.Text = "درحال بارگذاری";
			// 
			// NzProgress
			// 
			this.NzProgress.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.NzProgress.Location = new System.Drawing.Point(6, 419);
			this.NzProgress.Name = "NzProgress";
			this.NzProgress.Office2007ColorScheme = Janus.Windows.UI.Office2007ColorScheme.Custom;
			this.NzProgress.Office2007CustomColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.NzProgress.Size = new System.Drawing.Size(429, 15);
			this.NzProgress.TabIndex = 3;
			this.NzProgress.Value = 1;
			this.NzProgress.VisualStyle = Janus.Windows.UI.VisualStyle.OfficeXP;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(4, 5);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(431, 342);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 5;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("IRANSans(Small) Medium", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Brown;
			this.label1.Location = new System.Drawing.Point(117, 339);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(206, 57);
			this.label1.TabIndex = 4;
			this.label1.Text = "نیک شـاهو";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// FormLoading
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(440, 438);
			this.ControlBox = false;
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.NzProgress);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.NzTitle);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormLoading";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ShowIcon = false;
			this.Text = "";
			this.Shown += new System.EventHandler(this.FormLoading_Shown);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label NzTitle;
        private Janus.Windows.EditControls.UIProgressBar NzProgress;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}