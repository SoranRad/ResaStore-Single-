namespace Updater
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            this.NzProgress = new System.Windows.Forms.ProgressBar();
            this.NzMessage = new System.Windows.Forms.Label();
            this.NzPercentage = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // NzProgress
            // 
            this.NzProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NzProgress.Location = new System.Drawing.Point(14, 62);
            this.NzProgress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NzProgress.Name = "NzProgress";
            this.NzProgress.Size = new System.Drawing.Size(318, 10);
            this.NzProgress.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.NzProgress.TabIndex = 0;
            this.NzProgress.Value = 25;
            // 
            // NzMessage
            // 
            this.NzMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NzMessage.Location = new System.Drawing.Point(0, 3);
            this.NzMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NzMessage.Name = "NzMessage";
            this.NzMessage.Size = new System.Drawing.Size(344, 28);
            this.NzMessage.TabIndex = 1;
            this.NzMessage.Text = "در حال بررسی بروزرسانی برنامه";
            this.NzMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NzPercentage
            // 
            this.NzPercentage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NzPercentage.Location = new System.Drawing.Point(13, 39);
            this.NzPercentage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NzPercentage.Name = "NzPercentage";
            this.NzPercentage.Size = new System.Drawing.Size(318, 21);
            this.NzPercentage.TabIndex = 2;
            this.NzPercentage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 4000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 75);
            this.Controls.Add(this.NzPercentage);
            this.Controls.Add(this.NzMessage);
            this.Controls.Add(this.NzProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 8, 5, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "";
            this.TopMost = true;
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar NzProgress;
        private System.Windows.Forms.Label NzMessage;
        private System.Windows.Forms.Label NzPercentage;
        private System.Windows.Forms.Timer timer1;
    }
}

